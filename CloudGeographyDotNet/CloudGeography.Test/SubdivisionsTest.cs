using AngryMonkey.Cloud.Geography;

namespace CloudGeography.Test
{
	[TestClass]
	public class SubdivisionsTest
	{
		[TestMethod]
		public void Get_Subdivisions_By_CountryCode()
		{
			CloudGeographyClient client = new();
			List<Subdivision> subdivisions = client.Subdivisions.Get("US");

			Assert.IsTrue(subdivisions.Any());
		}
		[TestMethod]
		public void Get_Subdivisions_By_CountryCode_NotAvailable()
		{
			CloudGeographyClient client = new();
			List<Subdivision> subdivisions = client.Subdivisions.Get("XX");

			Assert.IsTrue(!subdivisions.Any());
		}
		[TestMethod]
		public void Get_Subdivisions_By_CountryCode_And_SubDivisionCode()
		{
			CloudGeographyClient client = new();
			List<Subdivision> subdivisions = client.Subdivisions.Get("US", new[] { "aL", "Ak", "az" });

			Assert.IsTrue(subdivisions.Count == 3);

			Assert.AreEqual("Alabama", subdivisions.First(key => key.Code.Equals("AL", StringComparison.OrdinalIgnoreCase)).Name);
			Assert.AreEqual("Alaska", subdivisions.First(key => key.Code.Equals("AK", StringComparison.OrdinalIgnoreCase)).Name);
			Assert.AreEqual("Arizona", subdivisions.First(key => key.Code.Equals("AZ", StringComparison.OrdinalIgnoreCase)).Name);
		}

		[TestMethod]
		public void Get_Subdivision_By_CountryCode_And_SubDivisionCode()
		{
			CloudGeographyClient client = new();
			Subdivision? subdivision = client.Subdivisions.Get("US", "AL");

			Assert.AreEqual("Alabama", subdivision?.Name);
		}
	}
}
