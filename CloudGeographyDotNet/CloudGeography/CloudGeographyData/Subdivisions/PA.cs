using AngryMonkey.Cloud.Geography;
namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    private static void FillInSubdivisionsPA()
    {
        AddSubdivisions("PA", new List<Subdivision>()
        {
            new(){ Code ="1", LocalName="Bocas del Toro", Name="Bocas del Toro", Type="Province" },
            new(){ Code ="4", LocalName="Chiriquí", Name="Chiriquí", Type="Province" },
            new(){ Code ="2", LocalName="Coclé", Name="Coclé", Type="Province" },
            new(){ Code ="3", LocalName="Colón", Name="Colón", Type="Province" },
            new(){ Code ="5", LocalName="Darién", Name="Darién", Type="Province" },
            new(){ Code ="EM", LocalName="Emberá", Name="Emberá", Type="Region" },
            new(){ Code ="6", LocalName="Herrera", Name="Herrera", Type="Province" },
            new(){ Code ="KY", LocalName="Kuna Yala", Name="Kuna Yala", Type="Region" },
            new(){ Code ="7", LocalName="Los Santos", Name="Los Santos", Type="Province" },
            new(){ Code ="NB", LocalName="Ngöbe-Buglé", Name="Ngöbe-Buglé", Type="Region" },
            new(){ Code ="8", LocalName="Panamá", Name="Panamá", Type="Province" },
            new(){ Code ="10", LocalName="Panamá Oeste", Name="Panamá Oeste", Type="Province" },
            new(){ Code ="9", LocalName="Veraguas", Name="Veraguas", Type="Province" }

        });
    }
}
