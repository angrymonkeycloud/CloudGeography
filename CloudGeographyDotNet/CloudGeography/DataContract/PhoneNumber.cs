namespace AngryMonkey.Cloud.Geography;

public class PhoneNumber
{
	public string? CountryCallingCode { get; set; } = null;
	public string? CountryCode { get; set; } = null;
	public string Number { get; set; } = string.Empty;

	public string GetFullPhoneNumber()
	{
		if (string.IsNullOrEmpty(CountryCallingCode))
			return Number;

		return $"+{CountryCallingCode}{Number}";
	}
}