using AngryMonkey.Cloud.Geography;
using System.Text.Json;

namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    public partial class CountriesMethods
    {
        private readonly CloudGeographyClient Client;

        internal CountriesMethods(CloudGeographyClient client) => Client = client;

        public List<Country> Get(params string[] countryCodes)
        {
            if (countryCodes.Any())
                return CountriesList.Where(key => countryCodes.Any(c => key.CodeCheck(c))).ToList();

            return CountriesList.Where(key => key.Code.Equals("il", StringComparison.OrdinalIgnoreCase)).ToList();
        }
        public Country? Get(string countryCode) => CountriesList.FirstOrDefault(key => key.CodeCheck(countryCode));

        public List<Country> GetByCallingCode(int callingCode)
        {
            string callingCodeString = callingCode.ToString().TrimStart('0');

            callingCode = int.Parse(callingCodeString);

            return CountriesList.Where(key => key.CallingCode == callingCode).ToList();
        }

        private List<string> CanadianCallingCodes { get; } = new()
        {
            "403", "587", "780", "825", // Alberta
			"236", "250", "604", "672", "778", // British Columbia
			"204", "431", // Manitoba
			"506", // New Brunswick
			"709", // New Brunswick
			"709", // Newfoundland and Labrador
			"902", "782", // Nova Scotia and Prince Edward Island
			"226", "249", "289", "343", "365", "416", "437", "519", "548", "613", "647", "705", "807", "905", // Ontario
			"418", "438", "450", "514", "579", "581", "819", "873", // Quebec
			"306", "639", // Saskatchewan
			"867" // Yukon, Northwest Territories and Nunavut
		};

        public Country? GuessCountryByPhoneNumber(string phoneNumber)
        {
            if (string.IsNullOrEmpty(phoneNumber))
                return null;

            if (phoneNumber.StartsWith("00"))
                phoneNumber = $"+{phoneNumber[2..]}";

            if (phoneNumber.StartsWith("0"))
                phoneNumber = phoneNumber[1..];

            if (phoneNumber.StartsWith('+'))
                phoneNumber = phoneNumber[1..];

            if (phoneNumber.StartsWith("1"))
            {
                phoneNumber = phoneNumber[1..];

                if (phoneNumber.Length < 3)
                    return Get("US");

                string subdivisionCode = phoneNumber[..3];

                if (CanadianCallingCodes.Contains(subdivisionCode))
                    return Get("CA");

                return Get("US");
            }

            string prefix = "";

            for (int i = 0; i < 3; i++)
                try
                {
                    prefix = $"{prefix}{phoneNumber[i]}";

                    List<Country> countries = GetByCallingCode(int.Parse(prefix));

                    if (countries.Any())
                        return countries.First();
                }
                catch { }

            return null;
        }

        /// <summary>
        /// Azure Maps API Key required in client.
        /// </summary>
        /// <param name="coordinate">Coordinates to search.<param>
        /// <returns></returns>
        public async Task<Country?> GetByCoordinates(Coordinate coordinates)
        {
            if (string.IsNullOrEmpty(Client.Configuration?.AzureMapsKey))
                return null;

            // Define the API endpoint
            var endpoint = $"https://atlas.microsoft.com/search/address/reverse/json?subscription-key={Client.Configuration.AzureMapsKey}&api-version=1.0&query={coordinates.Latitude},{coordinates.Longitude}";

            // Create an HTTP client object
            var client = new HttpClient();

            // Call the API endpoint and get the response
            var response = await client.GetAsync(endpoint);

            // Read the response content as a string
            var content = await response.Content.ReadAsStringAsync();

            // Deserialize the JSON response into an object
            BingModels.AddressResponse? addressReponse = JsonSerializer.Deserialize<BingModels.AddressResponse>(content);

            BingModels.AddressReponseList? addressReponseList = addressReponse?.Addresses.FirstOrDefault();

            if (addressReponseList == null)
                return null;

            return Get(addressReponseList.address.countryCode);
        }

        /// <summary>
        /// Azure Maps API Key required in client.
        /// </summary>
        /// <param name="IPAdress">IP Adress to search.</param>
        /// <returns></returns>
        public async Task<Country?> GetByIP(string IPAddress)
        {
            if (string.IsNullOrEmpty(Client.Configuration?.AzureMapsKey))
                return null;

            // Define the API endpoint
            var endpoint = $"https://atlas.microsoft.com/geolocation/ip/json?api-version=1.0&ip={IPAddress}&subscription-key={Client.Configuration.AzureMapsKey}";

            // Create an HTTP client object
            var client = new HttpClient();

            // Call the API endpoint and get the response
            var response = await client.GetAsync(endpoint);

            // Read the response content as a string
            var content = await response.Content.ReadAsStringAsync();

            // Deserialize the JSON response into an object
            BingModels.IPAddressResponse? addressReponse = JsonSerializer.Deserialize<BingModels.IPAddressResponse>(content);

            if (addressReponse == null)
                return null;

            return Get(addressReponse.countryRegion.isoCode);
        }
    }
}