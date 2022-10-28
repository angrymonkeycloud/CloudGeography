namespace AngryMonkey.Cloud.Geography;

public class CountryCurrency
{
    public Currency Currency
    {
        get
        {
            if (string.IsNullOrEmpty(Code))
                return null;

            return new CloudGeographyClient().Currencies.Get(Code);
        }
    }
    public string Code { get; set; }
	public bool IsOfficial { get; set; }
}
