using AngryMonkey.Cloud.Geography;
namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    private static void FillInSubdivisionsPL()
    {
        AddSubdivisions("PL",
        [
            new()
            { 
                Code = "DS",
                Type = SubdivisionTypes.Province,
                Name = "Dolnoslaskie",
                LocalName = "Dolnoslaskie"
            },
            new()
            { 
                Code = "KP",
                Type = SubdivisionTypes.Province,
                Name = "Kujawsko-pomorskie",
                LocalName = "Kujawsko-pomorskie"
            },
            new()
            { 
                Code = "LD",
                Type = SubdivisionTypes.Province,
                Name = "Lódzkie",
                LocalName = "Lódzkie"
            },
            new()
            { 
                Code = "LU",
                Type = SubdivisionTypes.Province,
                Name = "Lubelskie",
                LocalName = "Lubelskie"
            },
            new()
            { 
                Code = "LB",
                Type = SubdivisionTypes.Province,
                Name = "Lubuskie",
                LocalName = "Lubuskie"
            },
            new()
            { 
                Code = "MA",
                Type = SubdivisionTypes.Province,
                Name = "Malopolskie",
                LocalName = "Malopolskie"
            },
            new()
            { 
                Code = "MZ",
                Type = SubdivisionTypes.Province,
                Name = "Mazowieckie",
                LocalName = "Mazowieckie"
            },
            new()
            { 
                Code = "OP",
                Type = SubdivisionTypes.Province,
                Name = "Opolskie",
                LocalName = "Opolskie"
            },
            new()
            { 
                Code = "PK",
                Type = SubdivisionTypes.Province,
                Name = "Podkarpackie",
                LocalName = "Podkarpackie"
            },
            new()
            { 
                Code = "PD",
                Type = SubdivisionTypes.Province,
                Name = "Podlaskie",
                LocalName = "Podlaskie"
            },
            new()
            { 
                Code = "PM",
                Type = SubdivisionTypes.Province,
                Name = "Pomorskie",
                LocalName = "Pomorskie"
            },
            new()
            { 
                Code = "SL",
                Type = SubdivisionTypes.Province,
                Name = "Slaskie",
                LocalName = "Slaskie"
            },
            new()
            { 
                Code = "SK",
                Type = SubdivisionTypes.Province,
                Name = "Swietokrzyskie",
                LocalName = "Swietokrzyskie"
            },
            new()
            { 
                Code = "WN",
                Type = SubdivisionTypes.Province,
                Name = "Warminsko-mazurskie",
                LocalName = "Warminsko-mazurskie"
            },
            new()
            { 
                Code = "WP",
                Type = SubdivisionTypes.Province,
                Name = "Wielkopolskie",
                LocalName = "Wielkopolskie"
            },
            new()
            { 
                Code = "ZP",
                Type = SubdivisionTypes.Province,
                Name = "Zachodniopomorskie",
                LocalName = "Zachodniopomorskie"
            }

        ]);
    }
}
