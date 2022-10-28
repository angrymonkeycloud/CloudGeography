namespace AngryMonkey.Cloud.Geography;

public class CountryLanguage
{
	public Language Language
	{
		get {
			if (string.IsNullOrEmpty(Code))
				return null;

            return new CloudGeographyClient().Languages.Get(Code);
        }
	}
    public string Code { get; set; }
    public bool IsOfficial { get; set; }

}
