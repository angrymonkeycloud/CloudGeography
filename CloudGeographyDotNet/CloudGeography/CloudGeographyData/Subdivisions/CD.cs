using AngryMonkey.Cloud.Geography;
namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    private static void FillInSubdivisionsCD()
    {
        AddSubdivisions("CD", new List<Subdivision>()
        {
            new()
            { 
                Code = "BU",
                Type = "Province",
                Name = "Bas-Uélé",
                LocalName = "Bas-Uélé"
            },
            new()
            { 
                Code = "EQ",
                Type = "Province",
                Name = "Équateur",
                LocalName = "Équateur"
            },
            new()
            { 
                Code = "HK",
                Type = "Province",
                Name = "Haut-Katanga",
                LocalName = "Haut-Katanga"
            },
            new()
            { 
                Code = "HL",
                Type = "Province",
                Name = "Haut-Lomami",
                LocalName = "Haut-Lomami"
            },
            new()
            { 
                Code = "HU",
                Type = "Province",
                Name = "Haut-Uélé",
                LocalName = "Haut-Uélé"
            },
            new()
            { 
                Code = "IT",
                Type = "Province",
                Name = "Ituri",
                LocalName = "Ituri"
            },
            new()
            { 
                Code = "KS",
                Type = "Province",
                Name = "Kasaï",
                LocalName = "Kasaï"
            },
            new()
            { 
                Code = "KC",
                Type = "Province",
                Name = "Kasaï Central",
                LocalName = "Kasaï Central"
            },
            new()
            { 
                Code = "KE",
                Type = "Province",
                Name = "Kasaï Oriental",
                LocalName = "Kasaï Oriental"
            },
            new()
            { 
                Code = "KN",
                Type = "City",
                Name = "Kinshasa",
                LocalName = "Kinshasa"
            },
            new()
            { 
                Code = "BC",
                Type = "Province",
                Name = "Kongo Central",
                LocalName = "Kongo Central"
            },
            new()
            { 
                Code = "KG",
                Type = "Province",
                Name = "Kwango",
                LocalName = "Kwango"
            },
            new()
            { 
                Code = "KL",
                Type = "Province",
                Name = "Kwilu",
                LocalName = "Kwilu"
            },
            new()
            { 
                Code = "LO",
                Type = "Province",
                Name = "Lomami",
                LocalName = "Lomami"
            },
            new()
            { 
                Code = "LU",
                Type = "Province",
                Name = "Lualaba",
                LocalName = "Lualaba"
            },
            new()
            { 
                Code = "MN",
                Type = "Province",
                Name = "Mai-Ndombe",
                LocalName = "Mai-Ndombe"
            },
            new()
            { 
                Code = "MA",
                Type = "Province",
                Name = "Maniema",
                LocalName = "Maniema"
            },
            new()
            { 
                Code = "MO",
                Type = "Province",
                Name = "Mongala",
                LocalName = "Mongala"
            },
            new()
            { 
                Code = "NK",
                Type = "Province",
                Name = "Nord-Kivu",
                LocalName = "Nord-Kivu"
            },
            new()
            { 
                Code = "NU",
                Type = "Province",
                Name = "Nord-Ubangi",
                LocalName = "Nord-Ubangi"
            },
            new()
            { 
                Code = "SA",
                Type = "Province",
                Name = "Sankuru",
                LocalName = "Sankuru"
            },
            new()
            { 
                Code = "SK",
                Type = "Province",
                Name = "Sud-Kivu",
                LocalName = "Sud-Kivu"
            },
            new()
            { 
                Code = "SU",
                Type = "Province",
                Name = "Sud-Ubangi",
                LocalName = "Sud-Ubangi"
            },
            new()
            { 
                Code = "TA",
                Type = "Province",
                Name = "Tanganyika",
                LocalName = "Tanganyika"
            },
            new()
            { 
                Code = "TO",
                Type = "Province",
                Name = "Tshopo",
                LocalName = "Tshopo"
            },
            new()
            { 
                Code = "TU",
                Type = "Province",
                Name = "Tshuapa",
                LocalName = "Tshuapa"
            }

        });
    }
}
