using AngryMonkey.Cloud.Geography;
namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    private static void FillInSubdivisionsBZ()
    {
        AddSubdivisions("BZ", new List<Subdivision>()
        {
            new(){ Code ="BZ", LocalName="Belize", Name="Belize", Type="District" },
            new(){ Code ="CY", LocalName="Cayo", Name="Cayo", Type="District" },
            new(){ Code ="CZL", LocalName="Corozal", Name="Corozal", Type="District" },
            new(){ Code ="OW", LocalName="Orange Walk", Name="Orange Walk", Type="District" },
            new(){ Code ="SC", LocalName="Stann Creek", Name="Stann Creek", Type="District" },
            new(){ Code ="TOL", LocalName="Toledo", Name="Toledo", Type="District" }

        });
    }
}
