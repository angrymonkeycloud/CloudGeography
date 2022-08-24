using System.Diagnostics.Metrics;
using Newtonsoft.Json;

namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
	public CountriesMethods Countries { get; set; }
	public LanguagesMethods Languages { get; set; }
	public CurrenciesMethods Currencies { get; set; }

	public CloudGeographyClient()
	{
		Countries = new CountriesMethods(this);
		Languages = new LanguagesMethods(this);
		Currencies = new CurrenciesMethods(this);
	}

	internal static T? DeserializeModel<T>(string fileName, string directory = "")
	{
		string path = Path.GetFullPath(Path.Combine(AppContext.BaseDirectory, $"..\\..\\..\\..\\..\\Data{(!string.IsNullOrEmpty(directory) ? $"\\{directory}" : null)}\\{fileName}.json"));

		return JsonConvert.DeserializeObject<T>(File.ReadAllText(path));
	}
}