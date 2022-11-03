using AngryMonkey.Cloud.Geography;

namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
	public partial class CurrenciesMethods
	{
		private CloudGeographyClient Client { get; set; }

		internal CurrenciesMethods(CloudGeographyClient client) => Client = client;

		public List<Currency> Get(params string[] currencyCodes) => currencyCodes.Any() ? CurrenciesList.Where(key => currencyCodes.Any(c => key.CodeCheck(c))).ToList() : CurrenciesList;

		public Currency? Get(string currencyCode) => CurrenciesList.FirstOrDefault(key => key.CodeCheck(currencyCode));

		public List<CountryCurrency> GetByCountry(string countryCode) => Client.Countries.Get(countryCode).Currencies;
	}
}