using AngryMonkey.Cloud.Geography;
namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    private static void FillInSubdivisionsBJ()
    {
        AddSubdivisions("BJ",
        [
            new()
            { 
                Code = "AL",
                Type = SubdivisionTypes.Department,
                Name = "Alibori",
                LocalName = "Alibori"
            },
            new()
            { 
                Code = "AK",
                Type = SubdivisionTypes.Department,
                Name = "Atacora",
                LocalName = "Atacora"
            },
            new()
            { 
                Code = "AQ",
                Type = SubdivisionTypes.Department,
                Name = "Atlantique",
                LocalName = "Atlantique"
            },
            new()
            { 
                Code = "BO",
                Type = SubdivisionTypes.Department,
                Name = "Borgou",
                LocalName = "Borgou"
            },
            new()
            { 
                Code = "CO",
                Type = SubdivisionTypes.Department,
                Name = "Collines",
                LocalName = "Collines"
            },
            new()
            { 
                Code = "KO",
                Type = SubdivisionTypes.Department,
                Name = "Couffo",
                LocalName = "Couffo"
            },
            new()
            { 
                Code = "DO",
                Type = SubdivisionTypes.Department,
                Name = "Donga",
                LocalName = "Donga"
            },
            new()
            { 
                Code = "LI",
                Type = SubdivisionTypes.Department,
                Name = "Littoral",
                LocalName = "Littoral"
            },
            new()
            { 
                Code = "MO",
                Type = SubdivisionTypes.Department,
                Name = "Mono",
                LocalName = "Mono"
            },
            new()
            { 
                Code = "OU",
                Type = SubdivisionTypes.Department,
                Name = "Ouémé",
                LocalName = "Ouémé"
            },
            new()
            { 
                Code = "PL",
                Type = SubdivisionTypes.Department,
                Name = "Plateau",
                LocalName = "Plateau"
            },
            new()
            { 
                Code = "ZO",
                Type = SubdivisionTypes.Department,
                Name = "Zou",
                LocalName = "Zou"
            }

        ]);
    }
}
