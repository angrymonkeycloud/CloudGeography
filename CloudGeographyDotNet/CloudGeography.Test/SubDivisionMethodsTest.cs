namespace CloudGeography.Test
{
	[TestClass]
	public class SubDivisionMethodsTest
    {
		[TestMethod]
		public void Get_Subdivisions_By_CountryCode()
		{
			CloudGeographyClient client = new();
			List<Subdivision> subdivisions = client.Subdivisions.GetAll("US");
			Assert.IsTrue(subdivisions.Any());
		}
		[TestMethod]
		public void Get_Subdivisions_By_CountryCode_And_SubDivisionCode()
		{
			CloudGeographyClient client = new();
			List<Subdivision> subdivisions = client.Subdivisions.Get("US", new[] { "AL" , "AK" , "AZ" });
			Assert.IsTrue(subdivisions.Any());
		}

		[TestMethod]
		public void Get_Subdivision_By_CountryCode_And_SubDivisionCode()
		{
			CloudGeographyClient client = new();
			Subdivision subdivision = client.Subdivisions.Get("US", "AL");
			Assert.AreEqual("Alabama", subdivision.Name);
		}
	}
}
