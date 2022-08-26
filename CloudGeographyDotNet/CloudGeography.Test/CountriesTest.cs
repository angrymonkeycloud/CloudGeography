namespace CloudGeography.Test
{
	[TestClass]
	public class CountriesTest
	{
		[TestMethod]
		public void Get_Country_By_CountryCode()
		{
			CloudGeographyClient client = new();
			Country? country = client.Countries.Get("Us");

			Assert.AreEqual("United States of America", country?.Name);
		}

		[TestMethod]
		public void Get_Country_By_CountryCode_ThreeLetters()
		{
			CloudGeographyClient client = new();
			Country? country = client.Countries.Get("uSA");

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
			List<Country> countries = client.Countries.Get(new[] {"US", "LB"});

			Assert.IsTrue(countries.Count == 2);

			Assert.AreEqual("United States of America", countries.First(key => key.Code.Equals("US", StringComparison.OrdinalIgnoreCase)).Name);
			Assert.AreEqual("Lebanon", countries.First(key => key.Code.Equals("LB", StringComparison.OrdinalIgnoreCase)).Name);
		}

		[TestMethod]
		public void Get_Countries_By_CountryCode_Cases()
		{
			CloudGeographyClient client = new();
			List<Country> countries = client.Countries.Get(new[] { "Us", "lB" });

			Assert.IsTrue(countries.Count == 2);

			Assert.AreEqual("United States of America", countries.First(key => key.Code.Equals("US", StringComparison.OrdinalIgnoreCase)).Name);
			Assert.AreEqual("Lebanon", countries.First(key => key.Code.Equals("LB", StringComparison.OrdinalIgnoreCase)).Name);
		}

		[TestMethod]
		public void Get_Countries_By_Calling_Code()
		{
			CloudGeographyClient client = new();
			List<Country> country = client.Countries.GetByCallingCode(1);
			Assert.IsTrue(country.Any());
		}
	}
}