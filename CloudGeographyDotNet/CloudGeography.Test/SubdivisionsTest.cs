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

		[TestMethod]
		public void Get_Lebanon_Subdivisions()
		{
			CloudGeographyClient client = new();
			List<Subdivision> subdivisions = client.Subdivisions.Get("LB");

			Assert.AreEqual(8, subdivisions.Count);
		}

		[TestMethod]
		public void Get_Lebanon_Subdivision_Type_Is_Governorate()
		{
			CloudGeographyClient client = new();
			Subdivision? beirut = client.Subdivisions.Get("LB", "BA");

			Assert.IsNotNull(beirut);
			Assert.AreEqual(SubdivisionTypes.Governorate, beirut.Type);
			Assert.AreEqual("Beirut", beirut.Name);
		}

		[TestMethod]
		public void Get_Lebanon_Subdivision_Children()
		{
			CloudGeographyClient client = new();
			List<Subdivision>? children = client.Subdivisions.GetChildren("LB", "JL");

			Assert.IsNotNull(children);
			Assert.AreEqual(6, children.Count);
			Assert.IsTrue(children.All(c => c.Type == SubdivisionTypes.District));
		}

		[TestMethod]
		public void Get_Lebanon_Subdivision_Child()
		{
			CloudGeographyClient client = new();
			Subdivision? child = client.Subdivisions.GetChild("LB", "BH", "BK");

			Assert.IsNotNull(child);
			Assert.AreEqual("Baalbek", child.Name);
			Assert.AreEqual(SubdivisionTypes.District, child.Type);
		}

		[TestMethod]
		public void Get_Lebanon_All_Subdivisions_Flat()
		{
			CloudGeographyClient client = new();
			List<Subdivision> all = client.Subdivisions.GetAll("LB");

			Assert.IsTrue(all.Count > 8);
			Assert.IsTrue(all.Any(s => s.Type == SubdivisionTypes.Governorate));
			Assert.IsTrue(all.Any(s => s.Type == SubdivisionTypes.District));
		}
	}
}
