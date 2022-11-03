using AngryMonkey.Cloud.Geography;
namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    private static void FillInSubdivisionsSL()
    {
        AddSubdivisions("SL", new List<Subdivision>()
        {
            new(){ Code ="E", LocalName="Eastern", Name="Eastern", Type="Province" },
            new(){ Code ="N", LocalName="Northern", Name="Northern", Type="Province" },
            new(){ Code ="S", LocalName="Southern", Name="Southern", Type="Province" },
            new(){ Code ="W", LocalName="Western Area", Name="Western Area", Type="Area" }

        });
    }
}
