using AngryMonkey.Cloud.Geography;
namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    private static void FillInSubdivisionsLI()
    {
        AddSubdivisions("LI", new List<Subdivision>()
        {
            new(){ Code ="1", LocalName="Balzers", Name="Balzers", Type="Commune" },
            new(){ Code ="2", LocalName="Eschen", Name="Eschen", Type="Commune" },
            new(){ Code ="3", LocalName="Gamprin", Name="Gamprin", Type="Commune" },
            new(){ Code ="4", LocalName="Mauren", Name="Mauren", Type="Commune" },
            new(){ Code ="5", LocalName="Planken", Name="Planken", Type="Commune" },
            new(){ Code ="6", LocalName="Ruggell", Name="Ruggell", Type="Commune" },
            new(){ Code ="7", LocalName="Schaan", Name="Schaan", Type="Commune" },
            new(){ Code ="8", LocalName="Schellenberg", Name="Schellenberg", Type="Commune" },
            new(){ Code ="9", LocalName="Triesen", Name="Triesen", Type="Commune" },
            new(){ Code ="10", LocalName="Triesenberg", Name="Triesenberg", Type="Commune" },
            new(){ Code ="11", LocalName="Vaduz", Name="Vaduz", Type="Commune" }

        });
    }
}
