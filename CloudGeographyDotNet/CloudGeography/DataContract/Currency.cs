namespace AngryMonkey.Cloud.Geography;

public class Currency
{
	public string Code { get; set; }
	public bool IsOffical { get; set; }
	public string Name { get; set; }
	public string NativeName { get; set; }
	public string NativeSymbol { get; set; }
	public string PluralShortName { get; set; }
	public string ShortName { get; set; }
	public string Symbol { get; set; }

	internal bool CodeCheck(string code)
	{
		code = code.Trim().ToUpper();

		return Code == code;
	}

	internal bool NameCheck(string query)
	{
		if (string.IsNullOrWhiteSpace(query))
			return false;

		query = query.Trim();

		if (Name != null && Name.Equals(query, StringComparison.OrdinalIgnoreCase))
			return true;

		if (ShortName != null && ShortName.Equals(query, StringComparison.OrdinalIgnoreCase))
			return true;

		if (NativeName != null && NativeName.Equals(query, StringComparison.OrdinalIgnoreCase))
			return true;

		if (PluralShortName != null && PluralShortName.Equals(query, StringComparison.OrdinalIgnoreCase))
			return true;

		if (CodeCheck(query))
			return true;

		return false;
	}
}
