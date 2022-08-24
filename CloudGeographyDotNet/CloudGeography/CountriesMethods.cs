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

		public List<Country> Get(params string[] countryCodes) => Countries.Where(key => countryCodes.Contains(key.Code)).ToList();

		public Country? Get(string countryCode) => Countries.FirstOrDefault(key => key.Code.Equals(countryCode.Trim(), StringComparison.OrdinalIgnoreCase));

		public List<Country> Get(int callingCode) => Countries.Where(key => key.CallingCode == callingCode).ToList();
	}
}