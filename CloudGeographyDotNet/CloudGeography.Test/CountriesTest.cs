namespace CloudGeography.Test
{
	[TestClass]
	public class CountriesTest
	{
		[TestMethod]
		public void Get_Country_By_Country_Code()
		{
			CloudGeographyClient client = new();
			Country? country = client.Countries.Get("US");
			Assert.AreEqual("United States of America", country?.Name);
		}

		[TestMethod]
		public void Get_All_Countries()
		{
			CloudGeographyClient client = new();
			List<Country> country = client.Countries.GetAll();
			Assert.IsTrue(country.Any());
		}

		[TestMethod]
		public void Get_Countries_By_Country_Codes()
		{
			CloudGeographyClient client = new();
			List<Country> country = client.Countries.Get(new[] {"AF", "AL"});
			Assert.IsTrue(country.Any());
		}

		[TestMethod]
		public void Get_Countries_By_Calling_Code()
		{
			CloudGeographyClient client = new();
			List<Country> country = client.Countries.Get(1);
			Assert.IsTrue(country.Any());
		}
	}
}