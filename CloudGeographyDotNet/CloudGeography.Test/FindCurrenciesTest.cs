using AngryMonkey.Cloud.Geography;

namespace CloudGeography.Test
{
	[TestClass]
	public class FindCurrenciesTest
	{
		// ── Find by full name ──────────────────────────────────────────────

		[TestMethod]
		public void Find_Currency_By_Name_USDollar()
		{
			CloudGeographyClient client = new();
			Currency? currency = client.Currencies.Find("United States Dollar");

			Assert.AreEqual("USD", currency?.Code);
		}

		[TestMethod]
		public void Find_Currency_By_Name_LebanesePound()
		{
			CloudGeographyClient client = new();
			Currency? currency = client.Currencies.Find("Lebanese pound");

			Assert.AreEqual("LBP", currency?.Code);
		}

		[TestMethod]
		public void Find_Currency_By_Name_Euro()
		{
			CloudGeographyClient client = new();
			Currency? currency = client.Currencies.Find("Euro");

			Assert.AreEqual("EUR", currency?.Code);
		}

		[TestMethod]
		public void Find_Currency_By_Name_AfghanAfghani()
		{
			CloudGeographyClient client = new();
			Currency? currency = client.Currencies.Find("Afghan afghani");

			Assert.AreEqual("AFN", currency?.Code);
		}

		// ── Find by short name ─────────────────────────────────────────────

		[TestMethod]
		public void Find_Currency_By_ShortName_USDollar()
		{
			CloudGeographyClient client = new();
			Currency? currency = client.Currencies.Find("US Dollar");

			Assert.AreEqual("USD", currency?.Code);
		}

		[TestMethod]
		public void Find_Currency_By_ShortName_Afghani()
		{
			CloudGeographyClient client = new();
			Currency? currency = client.Currencies.Find("Afghani");

			Assert.AreEqual("AFN", currency?.Code);
		}

		// ── Find by native name ────────────────────────────────────────────

		[TestMethod]
		public void Find_Currency_By_NativeName_USDollars()
		{
			CloudGeographyClient client = new();
			Currency? currency = client.Currencies.Find("US Dollars");

			Assert.AreEqual("USD", currency?.Code);
		}

		[TestMethod]
		public void Find_Currency_By_NativeName_LebanesePoundArabic()
		{
			CloudGeographyClient client = new();
			Currency? currency = client.Currencies.Find("ليرة لبنانية");

			Assert.AreEqual("LBP", currency?.Code);
		}

		[TestMethod]
		public void Find_Currency_By_NativeName_ArmenianDram()
		{
			CloudGeographyClient client = new();
			Currency? currency = client.Currencies.Find("Հայկական Դրամ");

			Assert.AreEqual("AMD", currency?.Code);
		}

		// ── Find by plural short name ──────────────────────────────────────

		[TestMethod]
		public void Find_Currency_By_PluralShortName_LebanesePounds()
		{
			CloudGeographyClient client = new();
			Currency? currency = client.Currencies.Find("Lebanese pounds");

			Assert.AreEqual("LBP", currency?.Code);
		}

		[TestMethod]
		public void Find_Currency_By_PluralShortName_Afghanis()
		{
			CloudGeographyClient client = new();
			Currency? currency = client.Currencies.Find("Afghanis");

			Assert.AreEqual("AFN", currency?.Code);
		}

		// ── Find by code ───────────────────────────────────────────────────

		[TestMethod]
		public void Find_Currency_By_Code_USD()
		{
			CloudGeographyClient client = new();
			Currency? currency = client.Currencies.Find("USD");

			Assert.AreEqual("USD", currency?.Code);
		}

		[TestMethod]
		public void Find_Currency_By_Code_EUR()
		{
			CloudGeographyClient client = new();
			Currency? currency = client.Currencies.Find("EUR");

			Assert.AreEqual("EUR", currency?.Code);
		}

		[TestMethod]
		public void Find_Currency_By_Code_LBP()
		{
			CloudGeographyClient client = new();
			Currency? currency = client.Currencies.Find("LBP");

			Assert.AreEqual("LBP", currency?.Code);
		}

		// ── Case insensitivity ─────────────────────────────────────────────

		[TestMethod]
		public void Find_Currency_CaseInsensitive_LowerCase()
		{
			CloudGeographyClient client = new();
			Currency? currency = client.Currencies.Find("united states dollar");

			Assert.AreEqual("USD", currency?.Code);
		}

		[TestMethod]
		public void Find_Currency_CaseInsensitive_UpperCase()
		{
			CloudGeographyClient client = new();
			Currency? currency = client.Currencies.Find("EURO");

			Assert.AreEqual("EUR", currency?.Code);
		}

		[TestMethod]
		public void Find_Currency_CaseInsensitive_MixedCase()
		{
			CloudGeographyClient client = new();
			Currency? currency = client.Currencies.Find("lEbAnEsE pOuNd");

			Assert.AreEqual("LBP", currency?.Code);
		}

		[TestMethod]
		public void Find_Currency_CaseInsensitive_Code()
		{
			CloudGeographyClient client = new();
			Currency? currency = client.Currencies.Find("usd");

			Assert.AreEqual("USD", currency?.Code);
		}

		// ── Whitespace handling ────────────────────────────────────────────

		[TestMethod]
		public void Find_Currency_WithLeadingTrailingSpaces()
		{
			CloudGeographyClient client = new();
			Currency? currency = client.Currencies.Find("  Euro  ");

			Assert.AreEqual("EUR", currency?.Code);
		}

		// ── Not found / null cases ─────────────────────────────────────────

		[TestMethod]
		public void Find_Currency_NotFound()
		{
			CloudGeographyClient client = new();
			Currency? currency = client.Currencies.Find("Galleon");

			Assert.IsNull(currency);
		}

		[TestMethod]
		public void Find_Currency_EmptyString()
		{
			CloudGeographyClient client = new();
			Currency? currency = client.Currencies.Find("");

			Assert.IsNull(currency);
		}

		[TestMethod]
		public void Find_Currency_WhitespaceOnly()
		{
			CloudGeographyClient client = new();
			Currency? currency = client.Currencies.Find("   ");

			Assert.IsNull(currency);
		}

		// ── FindAll ────────────────────────────────────────────────────────

		[TestMethod]
		public void FindAll_Currency_By_Name()
		{
			CloudGeographyClient client = new();
			List<Currency> currencies = client.Currencies.FindAll("Euro");

			Assert.IsTrue(currencies.Count >= 1);
			Assert.IsTrue(currencies.Any(c => c.Code == "EUR"));
		}

		[TestMethod]
		public void FindAll_Currency_NotFound()
		{
			CloudGeographyClient client = new();
			List<Currency> currencies = client.Currencies.FindAll("Galleon");

			Assert.AreEqual(0, currencies.Count);
		}
	}
}
