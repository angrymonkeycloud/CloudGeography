using AngryMonkey.Cloud.Geography;

namespace CloudGeography.Test
{
	[TestClass]
	public class FindCountriesTest
	{
		// ── Find by full name ──────────────────────────────────────────────

		[TestMethod]
		public void Find_Country_By_FullName()
		{
			CloudGeographyClient client = new();
			Country? country = client.Countries.Find("United States of America");

			Assert.AreEqual("US", country?.Code);
		}

		[TestMethod]
		public void Find_Country_By_FullName_Lebanon()
		{
			CloudGeographyClient client = new();
			Country? country = client.Countries.Find("Lebanon");

			Assert.AreEqual("LB", country?.Code);
		}

		[TestMethod]
		public void Find_Country_By_FullName_Germany()
		{
			CloudGeographyClient client = new();
			Country? country = client.Countries.Find("Germany");

			Assert.AreEqual("DE", country?.Code);
		}

		// ── Find by short name ─────────────────────────────────────────────

		[TestMethod]
		public void Find_Country_By_ShortName()
		{
			CloudGeographyClient client = new();
			Country? country = client.Countries.Find("United States");

			Assert.AreEqual("US", country?.Code);
		}

		// ── Find by local name ─────────────────────────────────────────────

		[TestMethod]
		public void Find_Country_By_LocalName_Arabic()
		{
			CloudGeographyClient client = new();
			Country? country = client.Countries.Find("لبنان");

			Assert.AreEqual("LB", country?.Code);
		}

		[TestMethod]
		public void Find_Country_By_LocalName_German()
		{
			CloudGeographyClient client = new();
			Country? country = client.Countries.Find("Deutschland");

			Assert.AreEqual("DE", country?.Code);
		}

		[TestMethod]
		public void Find_Country_By_LocalName_Afghanistan()
		{
			CloudGeographyClient client = new();
			Country? country = client.Countries.Find("افغانستان");

			Assert.AreEqual("AF", country?.Code);
		}

		// ── Find by code ───────────────────────────────────────────────────

		[TestMethod]
		public void Find_Country_By_TwoLetterCode()
		{
			CloudGeographyClient client = new();
			Country? country = client.Countries.Find("US");

			Assert.AreEqual("US", country?.Code);
		}

		[TestMethod]
		public void Find_Country_By_ThreeLetterCode()
		{
			CloudGeographyClient client = new();
			Country? country = client.Countries.Find("USA");

			Assert.AreEqual("US", country?.Code);
		}

		[TestMethod]
		public void Find_Country_By_Code_LBN()
		{
			CloudGeographyClient client = new();
			Country? country = client.Countries.Find("LBN");

			Assert.AreEqual("LB", country?.Code);
		}

		// ── Find by alternative names ──────────────────────────────────────

		[TestMethod]
		public void Find_Country_By_AltName_States()
		{
			CloudGeographyClient client = new();
			Country? country = client.Countries.Find("States");

			Assert.AreEqual("US", country?.Code);
		}

		[TestMethod]
		public void Find_Country_By_AltName_America()
		{
			CloudGeographyClient client = new();
			Country? country = client.Countries.Find("America");

			Assert.AreEqual("US", country?.Code);
		}

		[TestMethod]
		public void Find_Country_By_AltName_Britain()
		{
			CloudGeographyClient client = new();
			Country? country = client.Countries.Find("Britain");

			Assert.AreEqual("GB", country?.Code);
		}

		[TestMethod]
		public void Find_Country_By_AltName_GreatBritain()
		{
			CloudGeographyClient client = new();
			Country? country = client.Countries.Find("Great Britain");

			Assert.AreEqual("GB", country?.Code);
		}

		[TestMethod]
		public void Find_Country_By_AltName_England()
		{
			CloudGeographyClient client = new();
			Country? country = client.Countries.Find("England");

			Assert.AreEqual("GB", country?.Code);
		}

		[TestMethod]
		public void Find_Country_By_AltName_UK()
		{
			CloudGeographyClient client = new();
			Country? country = client.Countries.Find("UK");

			Assert.AreEqual("GB", country?.Code);
		}

		[TestMethod]
		public void Find_Country_By_AltName_UAE()
		{
			CloudGeographyClient client = new();
			Country? country = client.Countries.Find("UAE");

			Assert.AreEqual("AE", country?.Code);
		}

		[TestMethod]
		public void Find_Country_By_AltName_Emirates()
		{
			CloudGeographyClient client = new();
			Country? country = client.Countries.Find("Emirates");

			Assert.AreEqual("AE", country?.Code);
		}

		[TestMethod]
		public void Find_Country_By_AltName_SouthKorea()
		{
			CloudGeographyClient client = new();
			Country? country = client.Countries.Find("South Korea");

			Assert.AreEqual("KR", country?.Code);
		}

		[TestMethod]
		public void Find_Country_By_AltName_NorthKorea()
		{
			CloudGeographyClient client = new();
			Country? country = client.Countries.Find("North Korea");

			Assert.AreEqual("KP", country?.Code);
		}

		[TestMethod]
		public void Find_Country_By_AltName_Russia()
		{
			CloudGeographyClient client = new();
			Country? country = client.Countries.Find("Russia");

			Assert.AreEqual("RU", country?.Code);
		}

		[TestMethod]
		public void Find_Country_By_AltName_China()
		{
			CloudGeographyClient client = new();
			Country? country = client.Countries.Find("China");

			Assert.AreEqual("CN", country?.Code);
		}

		[TestMethod]
		public void Find_Country_By_AltName_Saudi()
		{
			CloudGeographyClient client = new();
			Country? country = client.Countries.Find("Saudi");

			Assert.AreEqual("SA", country?.Code);
		}

		[TestMethod]
		public void Find_Country_By_AltName_KSA()
		{
			CloudGeographyClient client = new();
			Country? country = client.Countries.Find("KSA");

			Assert.AreEqual("SA", country?.Code);
		}

		[TestMethod]
		public void Find_Country_By_AltName_Holland()
		{
			CloudGeographyClient client = new();
			Country? country = client.Countries.Find("Holland");

			Assert.AreEqual("NL", country?.Code);
		}

		[TestMethod]
		public void Find_Country_By_AltName_CzechRepublic()
		{
			CloudGeographyClient client = new();
			Country? country = client.Countries.Find("Czech Republic");

			Assert.AreEqual("CZ", country?.Code);
		}

		[TestMethod]
		public void Find_Country_By_AltName_IvoryCoast()
		{
			CloudGeographyClient client = new();
			Country? country = client.Countries.Find("Ivory Coast");

			Assert.AreEqual("CI", country?.Code);
		}

		[TestMethod]
		public void Find_Country_By_AltName_Palestine()
		{
			CloudGeographyClient client = new();
			Country? country = client.Countries.Find("Palestine");

			Assert.AreEqual("PS", country?.Code);
		}

		[TestMethod]
		public void Find_Country_By_AltName_Vatican()
		{
			CloudGeographyClient client = new();
			Country? country = client.Countries.Find("Vatican");

			Assert.AreEqual("VA", country?.Code);
		}

		[TestMethod]
		public void Find_Country_By_AltName_Burma()
		{
			CloudGeographyClient client = new();
			Country? country = client.Countries.Find("Burma");

			Assert.AreEqual("MM", country?.Code);
		}

		[TestMethod]
		public void Find_Country_By_AltName_Turkiye()
		{
			CloudGeographyClient client = new();
			Country? country = client.Countries.Find("Türkiye");

			Assert.AreEqual("TR", country?.Code);
		}

		[TestMethod]
		public void Find_Country_By_AltName_Persia()
		{
			CloudGeographyClient client = new();
			Country? country = client.Countries.Find("Persia");

			Assert.AreEqual("IR", country?.Code);
		}

		[TestMethod]
		public void Find_Country_By_AltName_Taiwan()
		{
			CloudGeographyClient client = new();
			Country? country = client.Countries.Find("Taiwan");

			Assert.AreEqual("TW", country?.Code);
		}

		[TestMethod]
		public void Find_Country_By_AltName_Liban()
		{
			CloudGeographyClient client = new();
			Country? country = client.Countries.Find("Liban");

			Assert.AreEqual("LB", country?.Code);
		}

		[TestMethod]
		public void Find_Country_By_AltName_Schweiz()
		{
			CloudGeographyClient client = new();
			Country? country = client.Countries.Find("Schweiz");

			Assert.AreEqual("CH", country?.Code);
		}

		[TestMethod]
		public void Find_Country_By_AltName_Suisse()
		{
			CloudGeographyClient client = new();
			Country? country = client.Countries.Find("Suisse");

			Assert.AreEqual("CH", country?.Code);
		}

		[TestMethod]
		public void Find_Country_By_AltName_España()
		{
			CloudGeographyClient client = new();
			Country? country = client.Countries.Find("España");

			Assert.AreEqual("ES", country?.Code);
		}

		[TestMethod]
		public void Find_Country_By_AltName_DominicanRepublic()
		{
			CloudGeographyClient client = new();
			Country? country = client.Countries.Find("Dominican Republic");

			Assert.AreEqual("DO", country?.Code);
		}

		// ── Case insensitivity ─────────────────────────────────────────────

		[TestMethod]
		public void Find_Country_CaseInsensitive_LowerCase()
		{
			CloudGeographyClient client = new();
			Country? country = client.Countries.Find("united states of america");

			Assert.AreEqual("US", country?.Code);
		}

		[TestMethod]
		public void Find_Country_CaseInsensitive_UpperCase()
		{
			CloudGeographyClient client = new();
			Country? country = client.Countries.Find("UNITED STATES OF AMERICA");

			Assert.AreEqual("US", country?.Code);
		}

		[TestMethod]
		public void Find_Country_CaseInsensitive_MixedCase()
		{
			CloudGeographyClient client = new();
			Country? country = client.Countries.Find("lEbAnOn");

			Assert.AreEqual("LB", country?.Code);
		}

		[TestMethod]
		public void Find_Country_CaseInsensitive_AltName()
		{
			CloudGeographyClient client = new();
			Country? country = client.Countries.Find("states");

			Assert.AreEqual("US", country?.Code);
		}

		[TestMethod]
		public void Find_Country_CaseInsensitive_Code()
		{
			CloudGeographyClient client = new();
			Country? country = client.Countries.Find("us");

			Assert.AreEqual("US", country?.Code);
		}

		[TestMethod]
		public void Find_Country_CaseInsensitive_ThreeLetterCode()
		{
			CloudGeographyClient client = new();
			Country? country = client.Countries.Find("usa");

			Assert.AreEqual("US", country?.Code);
		}

		// ── Whitespace handling ────────────────────────────────────────────

		[TestMethod]
		public void Find_Country_WithLeadingTrailingSpaces()
		{
			CloudGeographyClient client = new();
			Country? country = client.Countries.Find("  Lebanon  ");

			Assert.AreEqual("LB", country?.Code);
		}

		// ── Not found / null cases ─────────────────────────────────────────

		[TestMethod]
		public void Find_Country_NotFound()
		{
			CloudGeographyClient client = new();
			Country? country = client.Countries.Find("Narnia");

			Assert.IsNull(country);
		}

		[TestMethod]
		public void Find_Country_EmptyString()
		{
			CloudGeographyClient client = new();
			Country? country = client.Countries.Find("");

			Assert.IsNull(country);
		}

		[TestMethod]
		public void Find_Country_WhitespaceOnly()
		{
			CloudGeographyClient client = new();
			Country? country = client.Countries.Find("   ");

			Assert.IsNull(country);
		}

		// ── FindAll ────────────────────────────────────────────────────────

		[TestMethod]
		public void FindAll_Country_By_Name()
		{
			CloudGeographyClient client = new();
			List<Country> countries = client.Countries.FindAll("Lebanon");

			Assert.IsTrue(countries.Count >= 1);
			Assert.IsTrue(countries.Any(c => c.Code == "LB"));
		}

		[TestMethod]
		public void FindAll_Country_By_AltName_Korea()
		{
			CloudGeographyClient client = new();
			List<Country> countries = client.Countries.FindAll("Korea");

			Assert.IsTrue(countries.Count >= 1);
			Assert.IsTrue(countries.Any(c => c.Code == "KR"));
		}

		[TestMethod]
		public void FindAll_Country_NotFound()
		{
			CloudGeographyClient client = new();
			List<Country> countries = client.Countries.FindAll("Narnia");

			Assert.AreEqual(0, countries.Count);
		}

		// ── More countries ─────────────────────────────────────────────────

		[TestMethod]
		public void Find_Country_France()
		{
			CloudGeographyClient client = new();
			Country? country = client.Countries.Find("France");

			Assert.AreEqual("FR", country?.Code);
		}

		[TestMethod]
		public void Find_Country_Japan()
		{
			CloudGeographyClient client = new();
			Country? country = client.Countries.Find("Japan");

			Assert.AreEqual("JP", country?.Code);
		}

		[TestMethod]
		public void Find_Country_India()
		{
			CloudGeographyClient client = new();
			Country? country = client.Countries.Find("India");

			Assert.AreEqual("IN", country?.Code);
		}

		[TestMethod]
		public void Find_Country_Brazil()
		{
			CloudGeographyClient client = new();
			Country? country = client.Countries.Find("Brazil");

			Assert.AreEqual("BR", country?.Code);
		}

		[TestMethod]
		public void Find_Country_Australia()
		{
			CloudGeographyClient client = new();
			Country? country = client.Countries.Find("Australia");

			Assert.AreEqual("AU", country?.Code);
		}

		[TestMethod]
		public void Find_Country_Canada()
		{
			CloudGeographyClient client = new();
			Country? country = client.Countries.Find("Canada");

			Assert.AreEqual("CA", country?.Code);
		}

		[TestMethod]
		public void Find_Country_Egypt()
		{
			CloudGeographyClient client = new();
			Country? country = client.Countries.Find("Egypt");

			Assert.AreEqual("EG", country?.Code);
		}

		[TestMethod]
		public void Find_Country_Mexico()
		{
			CloudGeographyClient client = new();
			Country? country = client.Countries.Find("Mexico");

			Assert.AreEqual("MX", country?.Code);
		}

		[TestMethod]
		public void Find_Country_Italy()
		{
			CloudGeographyClient client = new();
			Country? country = client.Countries.Find("Italy");

			Assert.AreEqual("IT", country?.Code);
		}

		[TestMethod]
		public void Find_Country_Argentina()
		{
			CloudGeographyClient client = new();
			Country? country = client.Countries.Find("Argentina");

			Assert.AreEqual("AR", country?.Code);
		}
	}
}
