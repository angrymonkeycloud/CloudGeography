using AngryMonkey.Cloud.Geography;
namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    private static void FillInSubdivisionsCD()
    {
        AddSubdivisions("CD",
        [
            new()
            { 
                Code = "BU",
                Type = SubdivisionTypes.Province,
                Name = "Bas-Uélé",
                LocalName = "Bas-Uélé"
            },
            new()
            { 
                Code = "EQ",
                Type = SubdivisionTypes.Province,
                Name = "Équateur",
                LocalName = "Équateur"
            },
            new()
            { 
                Code = "HK",
                Type = SubdivisionTypes.Province,
                Name = "Haut-Katanga",
                LocalName = "Haut-Katanga"
            },
            new()
            { 
                Code = "HL",
                Type = SubdivisionTypes.Province,
                Name = "Haut-Lomami",
                LocalName = "Haut-Lomami"
            },
            new()
            { 
                Code = "HU",
                Type = SubdivisionTypes.Province,
                Name = "Haut-Uélé",
                LocalName = "Haut-Uélé"
            },
            new()
            { 
                Code = "IT",
                Type = SubdivisionTypes.Province,
                Name = "Ituri",
                LocalName = "Ituri"
            },
            new()
            { 
                Code = "KS",
                Type = SubdivisionTypes.Province,
                Name = "Kasaï",
                LocalName = "Kasaï"
            },
            new()
            { 
                Code = "KC",
                Type = SubdivisionTypes.Province,
                Name = "Kasaï Central",
                LocalName = "Kasaï Central"
            },
            new()
            { 
                Code = "KE",
                Type = SubdivisionTypes.Province,
                Name = "Kasaï Oriental",
                LocalName = "Kasaï Oriental"
            },
            new()
            { 
                Code = "KN",
                Type = SubdivisionTypes.City,
                Name = "Kinshasa",
                LocalName = "Kinshasa"
            },
            new()
            { 
                Code = "BC",
                Type = SubdivisionTypes.Province,
                Name = "Kongo Central",
                LocalName = "Kongo Central"
            },
            new()
            { 
                Code = "KG",
                Type = SubdivisionTypes.Province,
                Name = "Kwango",
                LocalName = "Kwango"
            },
            new()
            { 
                Code = "KL",
                Type = SubdivisionTypes.Province,
                Name = "Kwilu",
                LocalName = "Kwilu"
            },
            new()
            { 
                Code = "LO",
                Type = SubdivisionTypes.Province,
                Name = "Lomami",
                LocalName = "Lomami"
            },
            new()
            { 
                Code = "LU",
                Type = SubdivisionTypes.Province,
                Name = "Lualaba",
                LocalName = "Lualaba"
            },
            new()
            { 
                Code = "MN",
                Type = SubdivisionTypes.Province,
                Name = "Mai-Ndombe",
                LocalName = "Mai-Ndombe"
            },
            new()
            { 
                Code = "MA",
                Type = SubdivisionTypes.Province,
                Name = "Maniema",
                LocalName = "Maniema"
            },
            new()
            { 
                Code = "MO",
                Type = SubdivisionTypes.Province,
                Name = "Mongala",
                LocalName = "Mongala"
            },
            new()
            { 
                Code = "NK",
                Type = SubdivisionTypes.Province,
                Name = "Nord-Kivu",
                LocalName = "Nord-Kivu"
            },
            new()
            { 
                Code = "NU",
                Type = SubdivisionTypes.Province,
                Name = "Nord-Ubangi",
                LocalName = "Nord-Ubangi"
            },
            new()
            { 
                Code = "SA",
                Type = SubdivisionTypes.Province,
                Name = "Sankuru",
                LocalName = "Sankuru"
            },
            new()
            { 
                Code = "SK",
                Type = SubdivisionTypes.Province,
                Name = "Sud-Kivu",
                LocalName = "Sud-Kivu"
            },
            new()
            { 
                Code = "SU",
                Type = SubdivisionTypes.Province,
                Name = "Sud-Ubangi",
                LocalName = "Sud-Ubangi"
            },
            new()
            { 
                Code = "TA",
                Type = SubdivisionTypes.Province,
                Name = "Tanganyika",
                LocalName = "Tanganyika"
            },
            new()
            { 
                Code = "TO",
                Type = SubdivisionTypes.Province,
                Name = "Tshopo",
                LocalName = "Tshopo"
            },
            new()
            { 
                Code = "TU",
                Type = SubdivisionTypes.Province,
                Name = "Tshuapa",
                LocalName = "Tshuapa"
            }

        ]);
    }
}
