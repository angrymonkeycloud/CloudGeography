namespace AngryMonkey.Cloud.Geography;

public class Language
{
	public string Code { get; set; }
	public bool IsOffical { get; set; }
	public string ThreeLettersCode { get; set; }
	public string Direction { get; set; }
	public string Name { get; set; }
	public string NativeName { get; set; }

	internal bool CodeCheck(string code)
	{
		code = code.Trim().ToUpper();

		return Code == code || ThreeLettersCode == code;
	}
}
