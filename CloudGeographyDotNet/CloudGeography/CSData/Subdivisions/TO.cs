using AngryMonkey.Cloud.Geography;
namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    private static void FillInSubdivisionsTO()
    {
        AddSubdivisions("TO", new List<Subdivision>()
        {
            new(){ Code ="1", LocalName="'Eua", Name="'Eua", Type="Division" },
            new(){ Code ="2", LocalName="Ha'apai", Name="Ha'apai", Type="Division" },
            new(){ Code ="3", LocalName="Niuas", Name="Niuas", Type="Division" },
            new(){ Code ="4", LocalName="Tongatapu", Name="Tongatapu", Type="Division" },
            new(){ Code ="5", LocalName="Vava'u", Name="Vava'u", Type="Division" }

        });
    }
}
