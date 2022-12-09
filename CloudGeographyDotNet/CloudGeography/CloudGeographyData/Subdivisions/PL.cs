using AngryMonkey.Cloud.Geography;
namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    private static void FillInSubdivisionsPL()
    {
        AddSubdivisions("PL", new List<Subdivision>()
        {
            new()
            { 
                Code = "DS",
                Type = "Province",
                Name = "Dolnoslaskie",
                LocalName = "Dolnoslaskie"
            },
            new()
            { 
                Code = "KP",
                Type = "Province",
                Name = "Kujawsko-pomorskie",
                LocalName = "Kujawsko-pomorskie"
            },
            new()
            { 
                Code = "LD",
                Type = "Province",
                Name = "Lódzkie",
                LocalName = "Lódzkie"
            },
            new()
            { 
                Code = "LU",
                Type = "Province",
                Name = "Lubelskie",
                LocalName = "Lubelskie"
            },
            new()
            { 
                Code = "LB",
                Type = "Province",
                Name = "Lubuskie",
                LocalName = "Lubuskie"
            },
            new()
            { 
                Code = "MA",
                Type = "Province",
                Name = "Malopolskie",
                LocalName = "Malopolskie"
            },
            new()
            { 
                Code = "MZ",
                Type = "Province",
                Name = "Mazowieckie",
                LocalName = "Mazowieckie"
            },
            new()
            { 
                Code = "OP",
                Type = "Province",
                Name = "Opolskie",
                LocalName = "Opolskie"
            },
            new()
            { 
                Code = "PK",
                Type = "Province",
                Name = "Podkarpackie",
                LocalName = "Podkarpackie"
            },
            new()
            { 
                Code = "PD",
                Type = "Province",
                Name = "Podlaskie",
                LocalName = "Podlaskie"
            },
            new()
            { 
                Code = "PM",
                Type = "Province",
                Name = "Pomorskie",
                LocalName = "Pomorskie"
            },
            new()
            { 
                Code = "SL",
                Type = "Province",
                Name = "Slaskie",
                LocalName = "Slaskie"
            },
            new()
            { 
                Code = "SK",
                Type = "Province",
                Name = "Swietokrzyskie",
                LocalName = "Swietokrzyskie"
            },
            new()
            { 
                Code = "WN",
                Type = "Province",
                Name = "Warminsko-mazurskie",
                LocalName = "Warminsko-mazurskie"
            },
            new()
            { 
                Code = "WP",
                Type = "Province",
                Name = "Wielkopolskie",
                LocalName = "Wielkopolskie"
            },
            new()
            { 
                Code = "ZP",
                Type = "Province",
                Name = "Zachodniopomorskie",
                LocalName = "Zachodniopomorskie"
            }

        });
    }
}
