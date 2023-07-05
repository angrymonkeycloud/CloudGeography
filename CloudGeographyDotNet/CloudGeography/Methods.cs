using System.Reflection;
using Newtonsoft.Json;
using AngryMonkey.Cloud.Geography;

namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
	public CloudGeographyConfig? Configuration { get; set; }
	public CountriesMethods Countries { get; set; }
	public LanguagesMethods Languages { get; set; }
	public CurrenciesMethods Currencies { get; set; }
	public SubdivisionsMethods Subdivisions { get; set; }
	public PhoneNumbersMethods PhoneNumbers { get; set; }
    public TimeZonesMethods TimeZones { get; set; }


    public CloudGeographyClient(CloudGeographyConfig? cloudGeographyConfig = null)
	{
		Countries = new CountriesMethods(this);
		Languages = new LanguagesMethods(this);
		Currencies = new CurrenciesMethods(this);
		Subdivisions = new SubdivisionsMethods(this);
		PhoneNumbers = new PhoneNumbersMethods(this);
		TimeZones = new TimeZonesMethods(this);
        Configuration = cloudGeographyConfig;
    }

	internal static T? DeserializeModel<T>(string fileName, string directory = "")
	{
		Assembly assembly = Assembly.GetExecutingAssembly();

		string fullFileName = $"AngryMonkey.Cloud.Data.{(!string.IsNullOrEmpty(directory) ? $"{directory}." : null)}{fileName.ToLower()}.json";

		using Stream stream = assembly.GetManifestResourceStream(fullFileName);
		StreamReader reader = new(stream);

		return JsonConvert.DeserializeObject<T>(reader.ReadToEnd());
	}
}