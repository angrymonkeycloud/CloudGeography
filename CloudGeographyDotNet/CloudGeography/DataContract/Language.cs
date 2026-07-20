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

	internal bool NameCheck(string query)
	{
		if (string.IsNullOrWhiteSpace(query))
			return false;

		query = query.Trim();

		if (Name != null && Name.Equals(query, StringComparison.OrdinalIgnoreCase))
			return true;

		if (NativeName != null && NativeName.Equals(query, StringComparison.OrdinalIgnoreCase))
			return true;

		if (CodeCheck(query))
			return true;

		return false;
	}
}
