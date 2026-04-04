using AngryMonkey.Cloud.Geography;
namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    private static void FillInSubdivisionsGA()
    {
        AddSubdivisions("GA",
        [
            new()
            { 
                Code = "1",
                Type = SubdivisionTypes.Province,
                Name = "Estuaire",
                LocalName = "Estuaire"
            },
            new()
            { 
                Code = "2",
                Type = SubdivisionTypes.Province,
                Name = "Haut-Ogooué",
                LocalName = "Haut-Ogooué"
            },
            new()
            { 
                Code = "3",
                Type = SubdivisionTypes.Province,
                Name = "Moyen-Ogooué",
                LocalName = "Moyen-Ogooué"
            },
            new()
            { 
                Code = "4",
                Type = SubdivisionTypes.Province,
                Name = "Ngounié",
                LocalName = "Ngounié"
            },
            new()
            { 
                Code = "5",
                Type = SubdivisionTypes.Province,
                Name = "Nyanga",
                LocalName = "Nyanga"
            },
            new()
            { 
                Code = "6",
                Type = SubdivisionTypes.Province,
                Name = "Ogooué-Ivindo",
                LocalName = "Ogooué-Ivindo"
            },
            new()
            { 
                Code = "7",
                Type = SubdivisionTypes.Province,
                Name = "Ogooué-Lolo",
                LocalName = "Ogooué-Lolo"
            },
            new()
            { 
                Code = "8",
                Type = SubdivisionTypes.Province,
                Name = "Ogooué-Maritime",
                LocalName = "Ogooué-Maritime"
            },
            new()
            { 
                Code = "9",
                Type = SubdivisionTypes.Province,
                Name = "Woleu-Ntem",
                LocalName = "Woleu-Ntem"
            }

        ]);
    }
}
