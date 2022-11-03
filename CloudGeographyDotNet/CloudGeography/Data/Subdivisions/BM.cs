using AngryMonkey.Cloud.Geography;
namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    private static void FillInSubdivisionsBM()
    {
        AddSubdivisions("BM", new List<Subdivision>()
        {
            new(){ Code ="A", LocalName="City of Hamilton", Name="City of Hamilton", Type="Municipality" },
            new(){ Code ="6", LocalName="Devonshire", Name="Devonshire", Type="Parish" },
            new(){ Code ="8", LocalName="Hamilton", Name="Hamilton", Type="Parish" },
            new(){ Code ="4", LocalName="Paget", Name="Paget", Type="Parish" },
            new(){ Code ="5", LocalName="Pembroke", Name="Pembroke", Type="Parish" },
            new(){ Code ="1", LocalName="Sandys", Name="Sandys", Type="Parish" },
            new(){ Code ="7", LocalName="Smith's", Name="Smith's", Type="Parish" },
            new(){ Code ="2", LocalName="Southampton", Name="Southampton", Type="Parish" },
            new(){ Code ="9", LocalName="St George's", Name="St George's", Type="Parish" },
            new(){ Code ="B", LocalName="Town of St. George", Name="Town of St. George", Type="Municipality" },
            new(){ Code ="3", LocalName="Warwick", Name="Warwick", Type="Parish" }

        });
    }
}
