using AngryMonkey.Cloud.Geography;
namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    private static void FillInSubdivisionsCF()
    {
        AddSubdivisions("CF", new List<Subdivision>()
        {
            new(){ Code ="BB", LocalName="Bamingui-Bangoran", Name="Bamingui-Bangoran", Type="Prefecture" },
            new(){ Code ="BGF", LocalName="Bangui", Name="Bangui", Type="Commune" },
            new(){ Code ="BK", LocalName="Basse-Kotto", Name="Basse-Kotto", Type="Prefecture" },
            new(){ Code ="KB", LocalName="Gribingui", Name="Gribingui", Type="Prefecture" },
            new(){ Code ="HK", LocalName="Haute-Kotto", Name="Haute-Kotto", Type="Prefecture" },
            new(){ Code ="HM", LocalName="Haut-Mbomou", Name="Haut-Mbomou", Type="Prefecture" },
            new(){ Code ="KG", LocalName="Kémo-Gribingui", Name="Kémo-Gribingui", Type="Prefecture" },
            new(){ Code ="LB", LocalName="Lobaye", Name="Lobaye", Type="Prefecture" },
            new(){ Code ="HS", LocalName="Mambéré-Kadéï", Name="Mambéré-Kadéï", Type="Prefecture" },
            new(){ Code ="MB", LocalName="Mbomou", Name="Mbomou", Type="Prefecture" },
            new(){ Code ="NM", LocalName="Nana-Mambéré", Name="Nana-Mambéré", Type="Prefecture" },
            new(){ Code ="MP", LocalName="Ombella-Mpoko", Name="Ombella-Mpoko", Type="Prefecture" },
            new(){ Code ="UK", LocalName="Ouaka", Name="Ouaka", Type="Prefecture" },
            new(){ Code ="AC", LocalName="Ouham", Name="Ouham", Type="Prefecture" },
            new(){ Code ="OP", LocalName="Ouham-Pendé", Name="Ouham-Pendé", Type="Prefecture" },
            new(){ Code ="SE", LocalName="Sangha", Name="Sangha", Type="Prefecture" },
            new(){ Code ="VK", LocalName="Vakaga", Name="Vakaga", Type="Prefecture" }

        });
    }
}
