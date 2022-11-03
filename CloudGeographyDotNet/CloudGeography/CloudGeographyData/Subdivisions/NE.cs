using AngryMonkey.Cloud.Geography;
namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    private static void FillInSubdivisionsNE()
    {
        AddSubdivisions("NE", new List<Subdivision>()
        {
            new(){ Code ="1", LocalName="Agadez", Name="Agadez", Type="Region" },
            new(){ Code ="2", LocalName="Diffa", Name="Diffa", Type="Region" },
            new(){ Code ="3", LocalName="Dosso", Name="Dosso", Type="Region" },
            new(){ Code ="4", LocalName="Maradi", Name="Maradi", Type="Region" },
            new(){ Code ="8", LocalName="Niamey", Name="Niamey", Type="District" },
            new(){ Code ="5", LocalName="Tahoua", Name="Tahoua", Type="Region" },
            new(){ Code ="6", LocalName="Tillabéri", Name="Tillabéri", Type="Region" },
            new(){ Code ="7", LocalName="Zinder", Name="Zinder", Type="Region" }

        });
    }
}
