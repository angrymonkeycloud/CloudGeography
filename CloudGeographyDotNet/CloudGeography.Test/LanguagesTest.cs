namespace CloudGeography.Test
{
	[TestClass]
	public class LanguagesTest
	{
		[TestMethod]
		public void Get_All_Languages()
		{
			CloudGeographyClient client = new();
			List<Language> languages = client.Languages.GetAll();
			Assert.IsTrue(languages.Any());
		}

		[TestMethod]
		public void Get_Languages_By_Language_Codes()
		{
			CloudGeographyClient client = new();
			List<Language> languages = client.Languages.Get(new[] { "AA" , "AF" });
			Assert.IsTrue(languages.Any());
		}


		[TestMethod]
		public void Get_Country_Languages_By_Country_Code()
		{
			CloudGeographyClient client = new();
			List<CountryLanguage> languages = client.Languages.GetByCountry("US");
			Assert.IsTrue(languages.Any());
		}

		[TestMethod]
		public void Get_Language_By_Language_Code()
		{
			CloudGeographyClient client = new();
			Language ?language = client.Languages.Get("EN");
			Assert.AreEqual("English", language?.Name);
		}
	}
}