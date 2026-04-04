using AngryMonkey.Cloud.Geography;
namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    private static void FillInSubdivisionsCF()
    {
        AddSubdivisions("CF",
        [
            new()
            { 
                Code = "BB",
                Type = SubdivisionTypes.Prefecture,
                Name = "Bamingui-Bangoran",
                LocalName = "Bamingui-Bangoran"
            },
            new()
            { 
                Code = "BGF",
                Type = SubdivisionTypes.Commune,
                Name = "Bangui",
                LocalName = "Bangui"
            },
            new()
            { 
                Code = "BK",
                Type = SubdivisionTypes.Prefecture,
                Name = "Basse-Kotto",
                LocalName = "Basse-Kotto"
            },
            new()
            { 
                Code = "KB",
                Type = SubdivisionTypes.Prefecture,
                Name = "Gribingui",
                LocalName = "Gribingui"
            },
            new()
            { 
                Code = "HK",
                Type = SubdivisionTypes.Prefecture,
                Name = "Haute-Kotto",
                LocalName = "Haute-Kotto"
            },
            new()
            { 
                Code = "HM",
                Type = SubdivisionTypes.Prefecture,
                Name = "Haut-Mbomou",
                LocalName = "Haut-Mbomou"
            },
            new()
            { 
                Code = "KG",
                Type = SubdivisionTypes.Prefecture,
                Name = "Kémo-Gribingui",
                LocalName = "Kémo-Gribingui"
            },
            new()
            { 
                Code = "LB",
                Type = SubdivisionTypes.Prefecture,
                Name = "Lobaye",
                LocalName = "Lobaye"
            },
            new()
            { 
                Code = "HS",
                Type = SubdivisionTypes.Prefecture,
                Name = "Mambéré-Kadéï",
                LocalName = "Mambéré-Kadéï"
            },
            new()
            { 
                Code = "MB",
                Type = SubdivisionTypes.Prefecture,
                Name = "Mbomou",
                LocalName = "Mbomou"
            },
            new()
            { 
                Code = "NM",
                Type = SubdivisionTypes.Prefecture,
                Name = "Nana-Mambéré",
                LocalName = "Nana-Mambéré"
            },
            new()
            { 
                Code = "MP",
                Type = SubdivisionTypes.Prefecture,
                Name = "Ombella-Mpoko",
                LocalName = "Ombella-Mpoko"
            },
            new()
            { 
                Code = "UK",
                Type = SubdivisionTypes.Prefecture,
                Name = "Ouaka",
                LocalName = "Ouaka"
            },
            new()
            { 
                Code = "AC",
                Type = SubdivisionTypes.Prefecture,
                Name = "Ouham",
                LocalName = "Ouham"
            },
            new()
            { 
                Code = "OP",
                Type = SubdivisionTypes.Prefecture,
                Name = "Ouham-Pendé",
                LocalName = "Ouham-Pendé"
            },
            new()
            { 
                Code = "SE",
                Type = SubdivisionTypes.Prefecture,
                Name = "Sangha",
                LocalName = "Sangha"
            },
            new()
            { 
                Code = "VK",
                Type = SubdivisionTypes.Prefecture,
                Name = "Vakaga",
                LocalName = "Vakaga"
            }

        ]);
    }
}
