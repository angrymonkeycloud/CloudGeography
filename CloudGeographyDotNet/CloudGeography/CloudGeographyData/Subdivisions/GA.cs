using AngryMonkey.Cloud.Geography;
namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    private static void FillInSubdivisionsGA()
    {
        AddSubdivisions("GA", new List<Subdivision>()
        {
            new()
            { 
                Code = "1",
                Type = "Province",
                Name = "Estuaire",
                LocalName = "Estuaire"
            },
            new()
            { 
                Code = "2",
                Type = "Province",
                Name = "Haut-Ogooué",
                LocalName = "Haut-Ogooué"
            },
            new()
            { 
                Code = "3",
                Type = "Province",
                Name = "Moyen-Ogooué",
                LocalName = "Moyen-Ogooué"
            },
            new()
            { 
                Code = "4",
                Type = "Province",
                Name = "Ngounié",
                LocalName = "Ngounié"
            },
            new()
            { 
                Code = "5",
                Type = "Province",
                Name = "Nyanga",
                LocalName = "Nyanga"
            },
            new()
            { 
                Code = "6",
                Type = "Province",
                Name = "Ogooué-Ivindo",
                LocalName = "Ogooué-Ivindo"
            },
            new()
            { 
                Code = "7",
                Type = "Province",
                Name = "Ogooué-Lolo",
                LocalName = "Ogooué-Lolo"
            },
            new()
            { 
                Code = "8",
                Type = "Province",
                Name = "Ogooué-Maritime",
                LocalName = "Ogooué-Maritime"
            },
            new()
            { 
                Code = "9",
                Type = "Province",
                Name = "Woleu-Ntem",
                LocalName = "Woleu-Ntem"
            }

        });
    }
}
