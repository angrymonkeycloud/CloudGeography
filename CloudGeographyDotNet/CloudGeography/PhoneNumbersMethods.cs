using AngryMonkey.Cloud.Geography;
using System.Text.RegularExpressions;

namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
	public class PhoneNumbersMethods
	{
		private CloudGeographyClient Client { get; set; }

		internal PhoneNumbersMethods(CloudGeographyClient client) => Client = client;

		public bool IsValidPhoneNumber(string number) => Regex.IsMatch(number, @$"^\+?[0-9({PhoneNumberValidCharacters})]{{8,20}}$");
		public static string PhoneNumberValidCharacters => string.Join(@"\", new[] { ' ', '.', '-', '/', '\\', '(', ')' });

		public PhoneNumber Get(string number)
		{
			if (number.StartsWith("00"))
				number = $"+{number[2..]}";

			if (number.StartsWith("0"))
				number = number[1..];

			number = Regex.Replace(number, $"[{PhoneNumberValidCharacters}]", "");

			Country? country = number.StartsWith("+") ? Client.Countries.GuessCountryByPhoneNumber(number) : null;

			PhoneNumber phoneNumber = new();

			if (country == null)
			{
				phoneNumber.Number = number;

				return phoneNumber;
			}

			phoneNumber.CountryCode = country.Code;
			phoneNumber.CountryCallingCode = country.CallingCode.ToString();
			phoneNumber.Number = number[$"+{country.CallingCode}".Length..];

			return phoneNumber;
		}
	}
}