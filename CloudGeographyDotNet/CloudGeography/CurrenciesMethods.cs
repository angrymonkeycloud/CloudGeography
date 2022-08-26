using AngryMonkey.Cloud.Geography;

namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
	public class CurrenciesMethods
	{
		private List<Currency>? _currencies;
		private CloudGeographyClient Client { get; set; }

		internal CurrenciesMethods(CloudGeographyClient client) => Client = client;

		private List<Currency> Currencies => _currencies ??= DeserializeModel<List<Currency>>("currencies") ?? new List<Currency>();

		public List<Currency> GetAll() => Currencies;

		public List<Currency> Get(params string[] currencyCodes) => Currencies.Where(key => currencyCodes.Select(key => key.Trim().ToUpper()).Contains(key.Code)).ToList();

		public List<CountryCurrency> GetByCountry(string countryCode) => Client.Countries.Get(countryCode).Currencies;

		public Currency? Get(string currencyCode) => Currencies.FirstOrDefault(key => key.Code.Equals(currencyCode.Trim(), StringComparison.OrdinalIgnoreCase));
	}
}