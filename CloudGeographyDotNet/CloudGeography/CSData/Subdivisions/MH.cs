using AngryMonkey.Cloud.Geography;
namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    private static void FillInSubdivisionsMH()
    {
        AddSubdivisions("MH", new List<Subdivision>()
        {
            new(){ Code ="ALL", LocalName="Ailinglapalap", Name="Ailinglapalap", Type="Municipality" },
            new(){ Code ="ALK", LocalName="Ailuk", Name="Ailuk", Type="Municipality" },
            new(){ Code ="ARN", LocalName="Arno", Name="Arno", Type="Municipality" },
            new(){ Code ="AUR", LocalName="Aur", Name="Aur", Type="Municipality" },
            new(){ Code ="KIL", LocalName="Bikini and Kili", Name="Bikini and Kili", Type="Municipality" },
            new(){ Code ="EBO", LocalName="Ebon", Name="Ebon", Type="Municipality" },
            new(){ Code ="ENI", LocalName="Enewetak and Ujelang", Name="Enewetak and Ujelang", Type="Municipality" },
            new(){ Code ="JAB", LocalName="Jabat", Name="Jabat", Type="Municipality" },
            new(){ Code ="JAL", LocalName="Jaluit", Name="Jaluit", Type="Municipality" },
            new(){ Code ="KWA", LocalName="Kwajalein", Name="Kwajalein", Type="Municipality" },
            new(){ Code ="LAE", LocalName="Lae", Name="Lae", Type="Municipality" },
            new(){ Code ="LIB", LocalName="Lib", Name="Lib", Type="Municipality" },
            new(){ Code ="LIK", LocalName="Likiep", Name="Likiep", Type="Municipality" },
            new(){ Code ="MAJ", LocalName="Majuro", Name="Majuro", Type="Municipality" },
            new(){ Code ="MAL", LocalName="Maloelap", Name="Maloelap", Type="Municipality" },
            new(){ Code ="MEJ", LocalName="Mejit", Name="Mejit", Type="Municipality" },
            new(){ Code ="MIL", LocalName="Mili", Name="Mili", Type="Municipality" },
            new(){ Code ="NMK", LocalName="Namdrik", Name="Namdrik", Type="Municipality" },
            new(){ Code ="NMU", LocalName="Namu", Name="Namu", Type="Municipality" },
            new(){ Code ="L", LocalName="Ralik chain", Name="Ralik chain", Type="District" },
            new(){ Code ="T", LocalName="Ratak chain", Name="Ratak chain", Type="District" },
            new(){ Code ="RON", LocalName="Rongelap", Name="Rongelap", Type="Municipality" },
            new(){ Code ="UJA", LocalName="Ujae", Name="Ujae", Type="Municipality" },
            new(){ Code ="UTI", LocalName="Utrik", Name="Utrik", Type="Municipality" },
            new(){ Code ="WTH", LocalName="Wotho", Name="Wotho", Type="Municipality" },
            new(){ Code ="WTJ", LocalName="Wotje", Name="Wotje", Type="Municipality" }

        });
    }
}
