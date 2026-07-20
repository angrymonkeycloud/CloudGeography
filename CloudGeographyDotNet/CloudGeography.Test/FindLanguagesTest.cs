using AngryMonkey.Cloud.Geography;

namespace CloudGeography.Test
{
	[TestClass]
	public class FindLanguagesTest
	{
		// ── Find by English name ───────────────────────────────────────────

		[TestMethod]
		public void Find_Language_By_Name_English()
		{
			CloudGeographyClient client = new();
			Language? language = client.Languages.Find("English");

			Assert.AreEqual("EN", language?.Code);
		}

		[TestMethod]
		public void Find_Language_By_Name_Arabic()
		{
			CloudGeographyClient client = new();
			Language? language = client.Languages.Find("Arabic");

			Assert.AreEqual("AR", language?.Code);
		}

		[TestMethod]
		public void Find_Language_By_Name_French()
		{
			CloudGeographyClient client = new();
			Language? language = client.Languages.Find("French");

			Assert.AreEqual("FR", language?.Code);
		}

		[TestMethod]
		public void Find_Language_By_Name_Spanish()
		{
			CloudGeographyClient client = new();
			Language? language = client.Languages.Find("Spanish");

			Assert.AreEqual("ES", language?.Code);
		}

		[TestMethod]
		public void Find_Language_By_Name_Japanese()
		{
			CloudGeographyClient client = new();
			Language? language = client.Languages.Find("Japanese");

			Assert.AreEqual("JA", language?.Code);
		}

		[TestMethod]
		public void Find_Language_By_Name_Armenian()
		{
			CloudGeographyClient client = new();
			Language? language = client.Languages.Find("Armenian");

			Assert.AreEqual("HY", language?.Code);
		}

		[TestMethod]
		public void Find_Language_By_Name_Albanian()
		{
			CloudGeographyClient client = new();
			Language? language = client.Languages.Find("Albanian");

			Assert.AreEqual("SQ", language?.Code);
		}

		// ── Find by native name ────────────────────────────────────────────

		[TestMethod]
		public void Find_Language_By_NativeName_Arabic()
		{
			CloudGeographyClient client = new();
			Language? language = client.Languages.Find("العربية");

			Assert.AreEqual("AR", language?.Code);
		}

		[TestMethod]
		public void Find_Language_By_NativeName_French()
		{
			CloudGeographyClient client = new();
			Language? language = client.Languages.Find("français");

			Assert.AreEqual("FR", language?.Code);
		}

		[TestMethod]
		public void Find_Language_By_NativeName_Spanish()
		{
			CloudGeographyClient client = new();
			Language? language = client.Languages.Find("español");

			Assert.AreEqual("ES", language?.Code);
		}

		[TestMethod]
		public void Find_Language_By_NativeName_Japanese()
		{
			CloudGeographyClient client = new();
			Language? language = client.Languages.Find("日本語");

			Assert.AreEqual("JA", language?.Code);
		}

		[TestMethod]
		public void Find_Language_By_NativeName_Armenian()
		{
			CloudGeographyClient client = new();
			Language? language = client.Languages.Find("Հայերեն");

			Assert.AreEqual("HY", language?.Code);
		}

		[TestMethod]
		public void Find_Language_By_NativeName_Shqip()
		{
			CloudGeographyClient client = new();
			Language? language = client.Languages.Find("shqip");

			Assert.AreEqual("SQ", language?.Code);
		}

		// ── Find by code ───────────────────────────────────────────────────

		[TestMethod]
		public void Find_Language_By_TwoLetterCode()
		{
			CloudGeographyClient client = new();
			Language? language = client.Languages.Find("EN");

			Assert.AreEqual("EN", language?.Code);
		}

		[TestMethod]
		public void Find_Language_By_ThreeLetterCode()
		{
			CloudGeographyClient client = new();
			Language? language = client.Languages.Find("ARA");

			Assert.AreEqual("AR", language?.Code);
		}

		[TestMethod]
		public void Find_Language_By_ThreeLetterCode_ENG()
		{
			CloudGeographyClient client = new();
			Language? language = client.Languages.Find("ENG");

			Assert.AreEqual("EN", language?.Code);
		}

		// ── Case insensitivity ─────────────────────────────────────────────

		[TestMethod]
		public void Find_Language_CaseInsensitive_LowerCase()
		{
			CloudGeographyClient client = new();
			Language? language = client.Languages.Find("english");

			Assert.AreEqual("EN", language?.Code);
		}

		[TestMethod]
		public void Find_Language_CaseInsensitive_UpperCase()
		{
			CloudGeographyClient client = new();
			Language? language = client.Languages.Find("FRENCH");

			Assert.AreEqual("FR", language?.Code);
		}

		[TestMethod]
		public void Find_Language_CaseInsensitive_MixedCase()
		{
			CloudGeographyClient client = new();
			Language? language = client.Languages.Find("aRaBiC");

			Assert.AreEqual("AR", language?.Code);
		}

		[TestMethod]
		public void Find_Language_CaseInsensitive_Code()
		{
			CloudGeographyClient client = new();
			Language? language = client.Languages.Find("en");

			Assert.AreEqual("EN", language?.Code);
		}

		// ── Whitespace handling ────────────────────────────────────────────

		[TestMethod]
		public void Find_Language_WithLeadingTrailingSpaces()
		{
			CloudGeographyClient client = new();
			Language? language = client.Languages.Find("  Arabic  ");

			Assert.AreEqual("AR", language?.Code);
		}

		// ── Not found / null cases ─────────────────────────────────────────

		[TestMethod]
		public void Find_Language_NotFound()
		{
			CloudGeographyClient client = new();
			Language? language = client.Languages.Find("Klingon");

			Assert.IsNull(language);
		}

		[TestMethod]
		public void Find_Language_EmptyString()
		{
			CloudGeographyClient client = new();
			Language? language = client.Languages.Find("");

			Assert.IsNull(language);
		}

		[TestMethod]
		public void Find_Language_WhitespaceOnly()
		{
			CloudGeographyClient client = new();
			Language? language = client.Languages.Find("   ");

			Assert.IsNull(language);
		}

		// ── FindAll ────────────────────────────────────────────────────────

		[TestMethod]
		public void FindAll_Language_By_Name()
		{
			CloudGeographyClient client = new();
			List<Language> languages = client.Languages.FindAll("Arabic");

			Assert.IsTrue(languages.Count >= 1);
			Assert.IsTrue(languages.Any(l => l.Code == "AR"));
		}

		[TestMethod]
		public void FindAll_Language_NotFound()
		{
			CloudGeographyClient client = new();
			List<Language> languages = client.Languages.FindAll("Klingon");

			Assert.AreEqual(0, languages.Count);
		}
	}
}
