using AngryMonkey.Cloud.Geography;

namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
	public class CountriesMethods
	{
		private List<Country>? _countries;
		private CloudGeographyClient Client { get; set; }

		internal CountriesMethods(CloudGeographyClient client) => Client = client;

		private List<Country> Countries => _countries ??= DeserializeModel<List<Country>>("countries") ?? new List<Country>();


		public List<Country> GetAll() => Countries;

		public List<Country> Get(params string[] countryCodes) => Countries.Where(key => countryCodes.Any(c => key.CodeCheck(c))).ToList();

		public Country? Get(string countryCode) => Countries.FirstOrDefault(key => key.CodeCheck(countryCode));

		public List<Country> GetByCallingCode(int callingCode)
		{
			string callingCodeString = callingCode.ToString().TrimStart('0');

			callingCode = int.Parse(callingCodeString);

			return Countries.Where(key => key.CallingCode == callingCode).ToList();
		}
	}
}