using AngryMonkey.Cloud.Geography;
namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    private static void FillInSubdivisionsBJ()
    {
        AddSubdivisions("BJ", new List<Subdivision>()
        {
            new()
            { 
                Code = "AL",
                Type = "Department",
                Name = "Alibori",
                LocalName = "Alibori"
            },
            new()
            { 
                Code = "AK",
                Type = "Department",
                Name = "Atacora",
                LocalName = "Atacora"
            },
            new()
            { 
                Code = "AQ",
                Type = "Department",
                Name = "Atlantique",
                LocalName = "Atlantique"
            },
            new()
            { 
                Code = "BO",
                Type = "Department",
                Name = "Borgou",
                LocalName = "Borgou"
            },
            new()
            { 
                Code = "CO",
                Type = "Department",
                Name = "Collines",
                LocalName = "Collines"
            },
            new()
            { 
                Code = "KO",
                Type = "Department",
                Name = "Couffo",
                LocalName = "Couffo"
            },
            new()
            { 
                Code = "DO",
                Type = "Department",
                Name = "Donga",
                LocalName = "Donga"
            },
            new()
            { 
                Code = "LI",
                Type = "Department",
                Name = "Littoral",
                LocalName = "Littoral"
            },
            new()
            { 
                Code = "MO",
                Type = "Department",
                Name = "Mono",
                LocalName = "Mono"
            },
            new()
            { 
                Code = "OU",
                Type = "Department",
                Name = "Ouémé",
                LocalName = "Ouémé"
            },
            new()
            { 
                Code = "PL",
                Type = "Department",
                Name = "Plateau",
                LocalName = "Plateau"
            },
            new()
            { 
                Code = "ZO",
                Type = "Department",
                Name = "Zou",
                LocalName = "Zou"
            }

        });
    }
}
