using AngryMonkey.Cloud.Geography;

namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    public partial class LanguagesMethods
    {
        private readonly CloudGeographyClient Client;

        internal LanguagesMethods(CloudGeographyClient client) => Client = client;

        public List<Language> Get(params string[] languageCodes) => languageCodes.Any() ? LanguagesList.Where(key => languageCodes.Any(l => key.CodeCheck(l))).ToList() : LanguagesList;

        public Language? Get(string languageCode) => LanguagesList.FirstOrDefault(key => key.CodeCheck(languageCode));

        public Language? Find(string query) => LanguagesList.FirstOrDefault(key => key.NameCheck(query));

        public List<Language> FindAll(string query) => LanguagesList.Where(key => key.NameCheck(query)).ToList();

        public List<CountryLanguage> GetByCountry(string countryCode) => Client.Countries.Get(countryCode).Languages;
    }
}