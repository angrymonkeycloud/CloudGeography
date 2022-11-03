using AngryMonkey.Cloud.Geography;
namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    private static void FillInSubdivisionsAL()
    {
        AddSubdivisions("AL", new List<Subdivision>()
        {
            new(){ Code ="1", LocalName="Berat", Name="Berat", Type="County" },
            new(){ Code ="9", LocalName="Dibër", Name="Dibër", Type="County" },
            new(){ Code ="2", LocalName="Durrës", Name="Durrës", Type="County" },
            new(){ Code ="3", LocalName="Elbasan", Name="Elbasan", Type="County" },
            new(){ Code ="4", LocalName="Fier", Name="Fier", Type="County" },
            new(){ Code ="5", LocalName="Gjirokastër", Name="Gjirokastër", Type="County" },
            new(){ Code ="6", LocalName="Korçë", Name="Korçë", Type="County" },
            new(){ Code ="7", LocalName="Kukës", Name="Kukës", Type="County" },
            new(){ Code ="8", LocalName="Lezhë", Name="Lezhë", Type="County" },
            new(){ Code ="10", LocalName="Shkodër", Name="Shkodër", Type="County" },
            new(){ Code ="11", LocalName="Tiranë", Name="Tiranë", Type="County" },
            new(){ Code ="12", LocalName="Vlorë", Name="Vlorë", Type="County" }

        });
    }
}
