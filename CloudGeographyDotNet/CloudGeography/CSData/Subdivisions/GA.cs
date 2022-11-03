using AngryMonkey.Cloud.Geography;
namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    private static void FillInSubdivisionsGA()
    {
        AddSubdivisions("GA", new List<Subdivision>()
        {
            new(){ Code ="1", LocalName="Estuaire", Name="Estuaire", Type="Province" },
            new(){ Code ="2", LocalName="Haut-Ogooué", Name="Haut-Ogooué", Type="Province" },
            new(){ Code ="3", LocalName="Moyen-Ogooué", Name="Moyen-Ogooué", Type="Province" },
            new(){ Code ="4", LocalName="Ngounié", Name="Ngounié", Type="Province" },
            new(){ Code ="5", LocalName="Nyanga", Name="Nyanga", Type="Province" },
            new(){ Code ="6", LocalName="Ogooué-Ivindo", Name="Ogooué-Ivindo", Type="Province" },
            new(){ Code ="7", LocalName="Ogooué-Lolo", Name="Ogooué-Lolo", Type="Province" },
            new(){ Code ="8", LocalName="Ogooué-Maritime", Name="Ogooué-Maritime", Type="Province" },
            new(){ Code ="9", LocalName="Woleu-Ntem", Name="Woleu-Ntem", Type="Province" }

        });
    }
}
