using AngryMonkey.Cloud.Geography;
namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    private static void FillInSubdivisionsDE()
    {
        AddSubdivisions("DE", new List<Subdivision>()
        {
            new()
            { 
                Code = "BW",
                Type = "Land",
                Name = "Baden-Württemberg",
                LocalName = "Baden-Württemberg"
            },
            new()
            { 
                Code = "BY",
                Type = "Land",
                Name = "Bayern",
                LocalName = "Bayern"
            },
            new()
            { 
                Code = "BE",
                Type = "Land",
                Name = "Berlin",
                LocalName = "Berlin"
            },
            new()
            { 
                Code = "BB",
                Type = "Land",
                Name = "Brandenburg",
                LocalName = "Brandenburg"
            },
            new()
            { 
                Code = "HB",
                Type = "Land",
                Name = "Bremen",
                LocalName = "Bremen"
            },
            new()
            { 
                Code = "HH",
                Type = "Land",
                Name = "Hamburg",
                LocalName = "Hamburg"
            },
            new()
            { 
                Code = "HE",
                Type = "Land",
                Name = "Hessen",
                LocalName = "Hessen"
            },
            new()
            { 
                Code = "MV",
                Type = "Land",
                Name = "Mecklenburg-Vorpommern",
                LocalName = "Mecklenburg-Vorpommern"
            },
            new()
            { 
                Code = "NI",
                Type = "Land",
                Name = "Niedersachsen",
                LocalName = "Niedersachsen"
            },
            new()
            { 
                Code = "NW",
                Type = "Land",
                Name = "Nordrhein-Westfalen",
                LocalName = "Nordrhein-Westfalen"
            },
            new()
            { 
                Code = "RP",
                Type = "Land",
                Name = "Rheinland-Pfalz",
                LocalName = "Rheinland-Pfalz"
            },
            new()
            { 
                Code = "SL",
                Type = "Land",
                Name = "Saarland",
                LocalName = "Saarland"
            },
            new()
            { 
                Code = "SN",
                Type = "Land",
                Name = "Sachsen",
                LocalName = "Sachsen"
            },
            new()
            { 
                Code = "ST",
                Type = "Land",
                Name = "Sachsen-Anhalt",
                LocalName = "Sachsen-Anhalt"
            },
            new()
            { 
                Code = "SH",
                Type = "Land",
                Name = "Schleswig-Holstein",
                LocalName = "Schleswig-Holstein"
            },
            new()
            { 
                Code = "TH",
                Type = "Land",
                Name = "Thüringen",
                LocalName = "Thüringen"
            }

        });
    }
}
