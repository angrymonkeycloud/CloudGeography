using AngryMonkey.Cloud.Geography;
namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    private static void FillInSubdivisionsCU()
    {
        AddSubdivisions("CU", new List<Subdivision>()
        {
            new()
            { 
                Code = "15",
                Type = "Province",
                Name = "Artemisa",
                LocalName = "Artemisa"
            },
            new()
            { 
                Code = "9",
                Type = "Province",
                Name = "Camagüey",
                LocalName = "Camagüey"
            },
            new()
            { 
                Code = "8",
                Type = "Province",
                Name = "Ciego de Ávila",
                LocalName = "Ciego de Ávila"
            },
            new()
            { 
                Code = "6",
                Type = "Province",
                Name = "Cienfuegos",
                LocalName = "Cienfuegos"
            },
            new()
            { 
                Code = "3",
                Type = "Province",
                Name = "Ciudad de La Habana",
                LocalName = "Ciudad de La Habana"
            },
            new()
            { 
                Code = "12",
                Type = "Province",
                Name = "Granma",
                LocalName = "Granma"
            },
            new()
            { 
                Code = "14",
                Type = "Province",
                Name = "Guantánamo",
                LocalName = "Guantánamo"
            },
            new()
            { 
                Code = "11",
                Type = "Province",
                Name = "Holguín",
                LocalName = "Holguín"
            },
            new()
            { 
                Code = "99",
                Type = "Municipality",
                Name = "Isla de la Juventud",
                LocalName = "Isla de la Juventud"
            },
            new()
            { 
                Code = "2",
                Type = "Province",
                Name = "La Habana",
                LocalName = "La Habana"
            },
            new()
            { 
                Code = "10",
                Type = "Province",
                Name = "Las Tunas",
                LocalName = "Las Tunas"
            },
            new()
            { 
                Code = "4",
                Type = "Province",
                Name = "Matanzas",
                LocalName = "Matanzas"
            },
            new()
            { 
                Code = "16",
                Type = "Province",
                Name = "Mayabeque",
                LocalName = "Mayabeque"
            },
            new()
            { 
                Code = "1",
                Type = "Province",
                Name = "Pinar del Río",
                LocalName = "Pinar del Río"
            },
            new()
            { 
                Code = "7",
                Type = "Province",
                Name = "Sancti Spíritus",
                LocalName = "Sancti Spíritus"
            },
            new()
            { 
                Code = "13",
                Type = "Province",
                Name = "Santiago de Cuba",
                LocalName = "Santiago de Cuba"
            },
            new()
            { 
                Code = "5",
                Type = "Province",
                Name = "Villa Clara",
                LocalName = "Villa Clara"
            }

        });
    }
}
