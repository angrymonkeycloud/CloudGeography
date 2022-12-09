using AngryMonkey.Cloud.Geography;
namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    private static void FillInSubdivisionsCF()
    {
        AddSubdivisions("CF", new List<Subdivision>()
        {
            new()
            { 
                Code = "BB",
                Type = "Prefecture",
                Name = "Bamingui-Bangoran",
                LocalName = "Bamingui-Bangoran"
            },
            new()
            { 
                Code = "BGF",
                Type = "Commune",
                Name = "Bangui",
                LocalName = "Bangui"
            },
            new()
            { 
                Code = "BK",
                Type = "Prefecture",
                Name = "Basse-Kotto",
                LocalName = "Basse-Kotto"
            },
            new()
            { 
                Code = "KB",
                Type = "Prefecture",
                Name = "Gribingui",
                LocalName = "Gribingui"
            },
            new()
            { 
                Code = "HK",
                Type = "Prefecture",
                Name = "Haute-Kotto",
                LocalName = "Haute-Kotto"
            },
            new()
            { 
                Code = "HM",
                Type = "Prefecture",
                Name = "Haut-Mbomou",
                LocalName = "Haut-Mbomou"
            },
            new()
            { 
                Code = "KG",
                Type = "Prefecture",
                Name = "Kémo-Gribingui",
                LocalName = "Kémo-Gribingui"
            },
            new()
            { 
                Code = "LB",
                Type = "Prefecture",
                Name = "Lobaye",
                LocalName = "Lobaye"
            },
            new()
            { 
                Code = "HS",
                Type = "Prefecture",
                Name = "Mambéré-Kadéï",
                LocalName = "Mambéré-Kadéï"
            },
            new()
            { 
                Code = "MB",
                Type = "Prefecture",
                Name = "Mbomou",
                LocalName = "Mbomou"
            },
            new()
            { 
                Code = "NM",
                Type = "Prefecture",
                Name = "Nana-Mambéré",
                LocalName = "Nana-Mambéré"
            },
            new()
            { 
                Code = "MP",
                Type = "Prefecture",
                Name = "Ombella-Mpoko",
                LocalName = "Ombella-Mpoko"
            },
            new()
            { 
                Code = "UK",
                Type = "Prefecture",
                Name = "Ouaka",
                LocalName = "Ouaka"
            },
            new()
            { 
                Code = "AC",
                Type = "Prefecture",
                Name = "Ouham",
                LocalName = "Ouham"
            },
            new()
            { 
                Code = "OP",
                Type = "Prefecture",
                Name = "Ouham-Pendé",
                LocalName = "Ouham-Pendé"
            },
            new()
            { 
                Code = "SE",
                Type = "Prefecture",
                Name = "Sangha",
                LocalName = "Sangha"
            },
            new()
            { 
                Code = "VK",
                Type = "Prefecture",
                Name = "Vakaga",
                LocalName = "Vakaga"
            }

        });
    }
}
