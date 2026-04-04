using AngryMonkey.Cloud.Geography;
namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    private static void FillInSubdivisionsCU()
    {
        AddSubdivisions("CU",
        [
            new()
            { 
                Code = "15",
                Type = SubdivisionTypes.Province,
                Name = "Artemisa",
                LocalName = "Artemisa"
            },
            new()
            { 
                Code = "9",
                Type = SubdivisionTypes.Province,
                Name = "Camagüey",
                LocalName = "Camagüey"
            },
            new()
            { 
                Code = "8",
                Type = SubdivisionTypes.Province,
                Name = "Ciego de Ávila",
                LocalName = "Ciego de Ávila"
            },
            new()
            { 
                Code = "6",
                Type = SubdivisionTypes.Province,
                Name = "Cienfuegos",
                LocalName = "Cienfuegos"
            },
            new()
            { 
                Code = "3",
                Type = SubdivisionTypes.Province,
                Name = "Ciudad de La Habana",
                LocalName = "Ciudad de La Habana"
            },
            new()
            { 
                Code = "12",
                Type = SubdivisionTypes.Province,
                Name = "Granma",
                LocalName = "Granma"
            },
            new()
            { 
                Code = "14",
                Type = SubdivisionTypes.Province,
                Name = "Guantánamo",
                LocalName = "Guantánamo"
            },
            new()
            { 
                Code = "11",
                Type = SubdivisionTypes.Province,
                Name = "Holguín",
                LocalName = "Holguín"
            },
            new()
            { 
                Code = "99",
                Type = SubdivisionTypes.Municipality,
                Name = "Isla de la Juventud",
                LocalName = "Isla de la Juventud"
            },
            new()
            { 
                Code = "2",
                Type = SubdivisionTypes.Province,
                Name = "La Habana",
                LocalName = "La Habana"
            },
            new()
            { 
                Code = "10",
                Type = SubdivisionTypes.Province,
                Name = "Las Tunas",
                LocalName = "Las Tunas"
            },
            new()
            { 
                Code = "4",
                Type = SubdivisionTypes.Province,
                Name = "Matanzas",
                LocalName = "Matanzas"
            },
            new()
            { 
                Code = "16",
                Type = SubdivisionTypes.Province,
                Name = "Mayabeque",
                LocalName = "Mayabeque"
            },
            new()
            { 
                Code = "1",
                Type = SubdivisionTypes.Province,
                Name = "Pinar del Río",
                LocalName = "Pinar del Río"
            },
            new()
            { 
                Code = "7",
                Type = SubdivisionTypes.Province,
                Name = "Sancti Spíritus",
                LocalName = "Sancti Spíritus"
            },
            new()
            { 
                Code = "13",
                Type = SubdivisionTypes.Province,
                Name = "Santiago de Cuba",
                LocalName = "Santiago de Cuba"
            },
            new()
            { 
                Code = "5",
                Type = SubdivisionTypes.Province,
                Name = "Villa Clara",
                LocalName = "Villa Clara"
            }

        ]);
    }
}
