namespace CloudGeography.Test
{
	[TestClass]
	public class CountriesTest
	{
		[TestMethod]
		public void Get_Country_By_Code()
		{
			CloudGeographyClient client = new();

			Country? country = client.Countries.Get("US");

			Assert.AreEqual("United States of America", country?.Name);
		}
	}
}