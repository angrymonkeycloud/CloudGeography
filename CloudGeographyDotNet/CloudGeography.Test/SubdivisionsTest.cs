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
			List<Subdivision> subdivisions = client.Subdivisions.Get("US", ["aL", "Ak", "az"]);

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

			Assert.AreEqual(9, subdivisions.Count);
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
			Assert.AreEqual(4, children.Count);
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
		public void Get_Lebanon_KeserwanJbeil_Governorate()
		{
			CloudGeographyClient client = new();
			Subdivision? gov = client.Subdivisions.Get("LB", "KJ");

			Assert.IsNotNull(gov);
			Assert.AreEqual("Keserwan-Jbeil", gov.Name);
			Assert.AreEqual(SubdivisionTypes.Governorate, gov.Type);

			List<Subdivision>? children = client.Subdivisions.GetChildren("LB", "KJ");
			Assert.IsNotNull(children);
			Assert.AreEqual(2, children.Count);
			Assert.IsTrue(children.Any(c => c.Code == "KE" && c.Name == "Keserwan"));
			Assert.IsTrue(children.Any(c => c.Code == "JB" && c.Name == "Byblos"));
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

		[TestMethod]
		public void Find_Lebanon_Subdivision_By_EnglishName()
		{
			CloudGeographyClient client = new();
			Subdivision? result = client.Subdivisions.Find("LB", "Beirut");

			Assert.IsNotNull(result);
			Assert.AreEqual("BA", result.Code);
		}

		[TestMethod]
		public void Find_Lebanon_Subdivision_By_Code()
		{
			CloudGeographyClient client = new();
			Subdivision? result = client.Subdivisions.Find("LB", "JL");

			Assert.IsNotNull(result);
			Assert.AreEqual("Mount Lebanon", result.Name);
		}

		[TestMethod]
		public void Find_Lebanon_Child_By_EnglishName()
		{
			CloudGeographyClient client = new();
			Subdivision? result = client.Subdivisions.Find("LB", "Baalbek");

			Assert.IsNotNull(result);
			Assert.AreEqual("BK", result.Code);
			Assert.AreEqual(SubdivisionTypes.District, result.Type);
		}

		[TestMethod]
		public void Find_Lebanon_Matn_By_Arabic_Transliteration_ElMetn()
		{
			CloudGeographyClient client = new();
			Subdivision? result = client.Subdivisions.Find("LB", "El Metn");

			Assert.IsNotNull(result);
			Assert.AreEqual("MT", result.Code);
			Assert.AreEqual("Matn", result.Name);
		}

		[TestMethod]
		public void Find_Lebanon_Subdivision_By_ArabicScript()
		{
			CloudGeographyClient client = new();
			Subdivision? result = client.Subdivisions.Find("LB", "بيروت");

			Assert.IsNotNull(result);
			Assert.AreEqual("BA", result.Code);
		}

		[TestMethod]
		public void Find_Lebanon_Beqaa_Variant_Spelling()
		{
			CloudGeographyClient client = new();
			Subdivision? bekaa = client.Subdivisions.Find("LB", "Bekaa");
			Subdivision? beqaa = client.Subdivisions.Find("LB", "Beqaa");

			Assert.IsNotNull(bekaa);
			Assert.IsNotNull(beqaa);
			Assert.AreEqual(bekaa.Code, beqaa.Code);
		}

		[TestMethod]
		public void Find_Subdivision_NotFound_Returns_Null()
		{
			CloudGeographyClient client = new();
			Subdivision? result = client.Subdivisions.Find("LB", "NonExistentPlace");

			Assert.IsNull(result);
		}

		[TestMethod]
		public void FindAll_Lebanon_Returns_Multiple_Matches()
		{
			CloudGeographyClient client = new();
			List<Subdivision> results = client.Subdivisions.FindAll("LB", "Nabatieh");

			// Should match both the Governorate and its District child
			Assert.IsTrue(results.Count >= 2);
			Assert.IsTrue(results.Any(s => s.Type == SubdivisionTypes.Governorate));
			Assert.IsTrue(results.Any(s => s.Type == SubdivisionTypes.District));
		}

		// ── Search API ─────────────────────────────────────────────────────────

		[TestMethod]
		public void Search_SingleToken_ByName_ReturnsResult()
		{
			CloudGeographyClient client = new();
			SubdivisionSearchResult? result = client.Subdivisions.Search(new() { Query = "Beirut", CountryCode = "LB" });

			Assert.IsNotNull(result);
			Assert.AreEqual(1, result.Matches.Count);
			Assert.AreEqual("BA", result.Primary?.Subdivision.Code);
			Assert.AreEqual(1, result.Primary?.Level);
			Assert.IsTrue(result.Score >= 0.9);
		}

		[TestMethod]
		public void Search_SingleToken_ByCode_ReturnsResult()
		{
			CloudGeographyClient client = new();
			SubdivisionSearchResult? result = client.Subdivisions.Search(new() { Query = "JL", CountryCode = "LB" });

			Assert.IsNotNull(result);
			Assert.AreEqual("Mount Lebanon", result.Primary?.Subdivision.Name);
			Assert.AreEqual(1.0, result.Primary?.MatchScore);
		}

		[TestMethod]
		public void Search_SingleToken_ArabicTransliteration_ElMetn()
		{
			CloudGeographyClient client = new();
			SubdivisionSearchResult? result = client.Subdivisions.Search(new() { Query = "El Metn", CountryCode = "LB" });

			Assert.IsNotNull(result);
			Assert.AreEqual("MT", result.Primary?.Subdivision.Code);
			Assert.AreEqual("Matn", result.Primary?.Subdivision.Name);
			Assert.AreEqual(2, result.Primary?.Level);
		}

		[TestMethod]
		public void Search_SingleToken_ArabicScript_Beirut()
		{
			CloudGeographyClient client = new();
			SubdivisionSearchResult? result = client.Subdivisions.Search(new() { Query = "بيروت", CountryCode = "LB" });

			Assert.IsNotNull(result);
			Assert.AreEqual("BA", result.Primary?.Subdivision.Code);
		}

		[TestMethod]
		public void Search_TwoTokens_CommaSeparated_ParentChild()
		{
			CloudGeographyClient client = new();
			// "Mount Lebanon, Matn" – parent first then child
			SubdivisionSearchResult? result = client.Subdivisions.Search(new() { Query = "Mount Lebanon, Matn", CountryCode = "LB" });

			Assert.IsNotNull(result);
			Assert.AreEqual(2, result.Matches.Count);
			Assert.AreEqual("JL", result.Matches[0].Subdivision.Code);
			Assert.AreEqual(1, result.Matches[0].Level);
			Assert.AreEqual("MT", result.Matches[1].Subdivision.Code);
			Assert.AreEqual(2, result.Matches[1].Level);
		}

		[TestMethod]
		public void Search_TwoTokens_ChildFirst_AlsoWorks()
		{
			CloudGeographyClient client = new();
			// "Matn, Mount Lebanon" – child listed before parent, should still resolve
			SubdivisionSearchResult? result = client.Subdivisions.Search(new() { Query = "Meten, Mount Lebanon", CountryCode = "LB" });

			Assert.IsNotNull(result);
			Assert.AreEqual(2, result.Matches.Count);
			Assert.IsTrue(result.Matches.Any(m => m.Subdivision.Code == "JL"));
			Assert.IsTrue(result.Matches.Any(m => m.Subdivision.Code == "MT"));
		}

		[TestMethod]
		public void Search_TwoTokens_SlashSeparated()
		{
			CloudGeographyClient client = new();
			SubdivisionSearchResult? result = client.Subdivisions.Search(new() { Query = "South/Tyre", CountryCode = "LB" });

			Assert.IsNotNull(result);
			Assert.AreEqual(2, result.Matches.Count);
			Assert.IsTrue(result.Matches.Any(m => m.Subdivision.Code == "JA"));
			Assert.IsTrue(result.Matches.Any(m => m.Subdivision.Code == "TY"));
		}

		[TestMethod]
		public void Search_WithParentSubdivisionCode_Valid()
		{
			CloudGeographyClient client = new();
			// Matn is a child of Mount Lebanon (JL) – filter should pass
			SubdivisionSearchResult? result = client.Subdivisions.Search(new()
			{
				Query = "Matn",
				CountryCode = "LB",
				ParentSubdivisionCode = "JL"
			});

			Assert.IsNotNull(result);
			Assert.AreEqual("MT", result.Primary?.Subdivision.Code);
		}

		[TestMethod]
		public void Search_WithParentSubdivisionCode_Invalid_ReturnsNull()
		{
			CloudGeographyClient client = new();
			// Matn is NOT a child of South (JA) – filter should reject
			SubdivisionSearchResult? result = client.Subdivisions.Search(new()
			{
				Query = "Matn",
				CountryCode = "LB",
				ParentSubdivisionCode = "JA"
			});

			Assert.IsNull(result);
		}

		[TestMethod]
		public void Search_WithoutCountryCode_FindsAcrossAllCountries()
		{
			CloudGeographyClient client = new();
			SubdivisionSearchResult? result = client.Subdivisions.Search(new() { Query = "Beirut" });

			Assert.IsNotNull(result);
			Assert.AreEqual("LB", result.CountryCode);
			Assert.AreEqual("BA", result.Primary?.Subdivision.Code);
		}

		[TestMethod]
		public void Search_NotFound_ReturnsNull()
		{
			CloudGeographyClient client = new();
			SubdivisionSearchResult? result = client.Subdivisions.Search(new() { Query = "NonExistentPlace", CountryCode = "LB" });

			Assert.IsNull(result);
		}

		[TestMethod]
		public void Search_ScoreIsHigherForExactCodeThanTransliteration()
		{
			CloudGeographyClient client = new();
			SubdivisionSearchResult? byCode = client.Subdivisions.Search(new() { Query = "MT", CountryCode = "LB" });
			SubdivisionSearchResult? byTranslit = client.Subdivisions.Search(new() { Query = "El Metn", CountryCode = "LB" });

			Assert.IsNotNull(byCode);
			Assert.IsNotNull(byTranslit);
			Assert.IsTrue(byCode.Score > byTranslit.Score);
		}
	}
}
