namespace CloudGeography.Test
{
	[TestClass]
	public class LanguagesTest
	{
		[TestMethod]
		public void Get_Languages_By_Country()
		{
			CloudGeographyClient client = new();

			List<CountryLanguage> languages = client.Languages.GetByCountry("US");

			Assert.IsTrue(languages.Any());
		}
	}
}