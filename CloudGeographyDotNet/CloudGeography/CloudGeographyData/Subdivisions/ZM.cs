using AngryMonkey.Cloud.Geography;
namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    private static void FillInSubdivisionsZM()
    {
        AddSubdivisions("ZM", new List<Subdivision>()
        {
            new(){ Code ="2", LocalName="Central", Name="Central", Type="Province" },
            new(){ Code ="8", LocalName="Copperbelt", Name="Copperbelt", Type="Province" },
            new(){ Code ="3", LocalName="Eastern", Name="Eastern", Type="Province" },
            new(){ Code ="4", LocalName="Luapula", Name="Luapula", Type="Province" },
            new(){ Code ="9", LocalName="Lusaka", Name="Lusaka", Type="Province" },
            new(){ Code ="10", LocalName="Muchinga", Name="Muchinga", Type="Province" },
            new(){ Code ="5", LocalName="Northern", Name="Northern", Type="Province" },
            new(){ Code ="6", LocalName="North-Western", Name="North-Western", Type="Province" },
            new(){ Code ="7", LocalName="Southern", Name="Southern", Type="Province" },
            new(){ Code ="1", LocalName="Western", Name="Western", Type="Province" }

        });
    }
}
