namespace AngryMonkey.Cloud.Geography;

public class Subdivision
{
	public string Code { get; set; }
	public string Name { get; set; }
	public string LocalName { get; set; }
	public string Type { get; set; }

	internal bool CodeCheck(string code)
	{
		code = code.Trim().ToUpper();

		return Code == code;
	}
}
