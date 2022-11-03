using AngryMonkey.Cloud.Geography;
namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    private static void FillInSubdivisionsEE()
    {
        AddSubdivisions("EE", new List<Subdivision>()
        {
            new(){ Code ="37", LocalName="Harjumaa", Name="Harjumaa", Type="County" },
            new(){ Code ="39", LocalName="Hiiumaa", Name="Hiiumaa", Type="County" },
            new(){ Code ="44", LocalName="Ida-Virumaa", Name="Ida-Virumaa", Type="County" },
            new(){ Code ="51", LocalName="Järvamaa", Name="Järvamaa", Type="County" },
            new(){ Code ="49", LocalName="Jõgevamaa", Name="Jõgevamaa", Type="County" },
            new(){ Code ="57", LocalName="Läänemaa", Name="Läänemaa", Type="County" },
            new(){ Code ="59", LocalName="Lääne-Virumaa", Name="Lääne-Virumaa", Type="County" },
            new(){ Code ="67", LocalName="Pärnumaa", Name="Pärnumaa", Type="County" },
            new(){ Code ="65", LocalName="Põlvamaa", Name="Põlvamaa", Type="County" },
            new(){ Code ="70", LocalName="Raplamaa", Name="Raplamaa", Type="County" },
            new(){ Code ="74", LocalName="Saaremaa", Name="Saaremaa", Type="County" },
            new(){ Code ="78", LocalName="Tartumaa", Name="Tartumaa", Type="County" },
            new(){ Code ="82", LocalName="Valgamaa", Name="Valgamaa", Type="County" },
            new(){ Code ="84", LocalName="Viljandimaa", Name="Viljandimaa", Type="County" },
            new(){ Code ="86", LocalName="Võrumaa", Name="Võrumaa", Type="County" }

        });
    }
}
