using AngryMonkey.Cloud.Geography;

namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
	public class LanguagesMethods
	{
		private List<Language>? _languages;
		private CloudGeographyClient Client { get; set; }

		internal LanguagesMethods(CloudGeographyClient client) => Client = client;

		private List<Language> Languages => _languages ??= DeserializeModel<List<Language>>("languages") ?? new List<Language>();

		public List<Language> GetAll() => Languages;

		public List<Language> Get(params string[] languageCodes) => Languages.Where(key => languageCodes.Select(key => key.Trim().ToUpper()).Contains(key.Code)).ToList();

		public List<CountryLanguage> GetByCountry(string countryCode) => Client.Countries.Get(countryCode).Languages;

		public Language? Get(string languageCode) => Languages.FirstOrDefault(key => key.Code.Equals(languageCode.Trim(), StringComparison.OrdinalIgnoreCase));
	}
}