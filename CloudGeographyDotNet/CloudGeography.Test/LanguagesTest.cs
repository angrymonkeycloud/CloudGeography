using AngryMonkey.Cloud.Geography;

namespace CloudGeography.Test
{
	[TestClass]
	public class LanguagesTest
	{
		[TestMethod]
		public void Get_All_Languages()
		{
			CloudGeographyClient client = new();
			List<Language> languages = client.Languages.Get();
			Assert.IsTrue(languages.Any());
		}

		[TestMethod]
		public void Get_Languages_By_Language_Codes()
		{
			CloudGeographyClient client = new();
			List<Language> languages = client.Languages.Get(new[] { "EN", "AR" });

			Assert.IsTrue(languages.Count == 2);

			Assert.AreEqual("English", languages.First(key => key.Code.Equals("EN", StringComparison.OrdinalIgnoreCase)).Name);
			Assert.AreEqual("Arabic", languages.First(key => key.Code.Equals("AR", StringComparison.OrdinalIgnoreCase)).Name);
		}

		[TestMethod]
		public void Get_Languages_By_LanguageCode_Cases()
		{
			CloudGeographyClient client = new();
			List<Language> languages = client.Languages.Get(new[] { "En", "aR" });

			Assert.IsTrue(languages.Count == 2);

			Assert.AreEqual("English", languages.First(key => key.Code.Equals("EN", StringComparison.OrdinalIgnoreCase)).Name);
			Assert.AreEqual("Arabic", languages.First(key => key.Code.Equals("AR", StringComparison.OrdinalIgnoreCase)).Name);
		}

		[TestMethod]
		public void Get_Country_Languages_By_Country_Code()
		{
			CloudGeographyClient client = new();
			List<CountryLanguage> languages = client.Languages.GetByCountry("US");
			Assert.IsTrue(languages.Any());
		}

		[TestMethod]
		public void Get_Country_Languages_By_Country_Code_Where_Language_Is_Not_Null()
		{
			CloudGeographyClient client = new();
			List<CountryLanguage> languages = client.Languages.GetByCountry("US");
			Assert.IsNotNull(languages[0].Code);
		}

		[TestMethod]
		public void Get_Language_By_LanguageCode()
		{
			CloudGeographyClient client = new();
			Language? language = client.Languages.Get("En");

			Assert.AreEqual("English", language?.Name);
		}

		[TestMethod]
		public void Get_Language_By_LanguageCode_ThreeLetters()
		{
			CloudGeographyClient client = new();
			Language? language = client.Languages.Get("eNG");

			Assert.AreEqual("English", language?.Name);
		}
	}
}