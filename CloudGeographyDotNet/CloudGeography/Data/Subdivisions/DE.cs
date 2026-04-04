using AngryMonkey.Cloud.Geography;
namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    private static void FillInSubdivisionsDE()
    {
        AddSubdivisions("DE",
        [
            new()
            { 
                Code = "BW",
                Type = SubdivisionTypes.Land,
                Name = "Baden-Württemberg",
                LocalName = "Baden-Württemberg"
            },
            new()
            { 
                Code = "BY",
                Type = SubdivisionTypes.Land,
                Name = "Bayern",
                LocalName = "Bayern"
            },
            new()
            { 
                Code = "BE",
                Type = SubdivisionTypes.Land,
                Name = "Berlin",
                LocalName = "Berlin"
            },
            new()
            { 
                Code = "BB",
                Type = SubdivisionTypes.Land,
                Name = "Brandenburg",
                LocalName = "Brandenburg"
            },
            new()
            { 
                Code = "HB",
                Type = SubdivisionTypes.Land,
                Name = "Bremen",
                LocalName = "Bremen"
            },
            new()
            { 
                Code = "HH",
                Type = SubdivisionTypes.Land,
                Name = "Hamburg",
                LocalName = "Hamburg"
            },
            new()
            { 
                Code = "HE",
                Type = SubdivisionTypes.Land,
                Name = "Hessen",
                LocalName = "Hessen"
            },
            new()
            { 
                Code = "MV",
                Type = SubdivisionTypes.Land,
                Name = "Mecklenburg-Vorpommern",
                LocalName = "Mecklenburg-Vorpommern"
            },
            new()
            { 
                Code = "NI",
                Type = SubdivisionTypes.Land,
                Name = "Niedersachsen",
                LocalName = "Niedersachsen"
            },
            new()
            { 
                Code = "NW",
                Type = SubdivisionTypes.Land,
                Name = "Nordrhein-Westfalen",
                LocalName = "Nordrhein-Westfalen"
            },
            new()
            { 
                Code = "RP",
                Type = SubdivisionTypes.Land,
                Name = "Rheinland-Pfalz",
                LocalName = "Rheinland-Pfalz"
            },
            new()
            { 
                Code = "SL",
                Type = SubdivisionTypes.Land,
                Name = "Saarland",
                LocalName = "Saarland"
            },
            new()
            { 
                Code = "SN",
                Type = SubdivisionTypes.Land,
                Name = "Sachsen",
                LocalName = "Sachsen"
            },
            new()
            { 
                Code = "ST",
                Type = SubdivisionTypes.Land,
                Name = "Sachsen-Anhalt",
                LocalName = "Sachsen-Anhalt"
            },
            new()
            { 
                Code = "SH",
                Type = SubdivisionTypes.Land,
                Name = "Schleswig-Holstein",
                LocalName = "Schleswig-Holstein"
            },
            new()
            { 
                Code = "TH",
                Type = SubdivisionTypes.Land,
                Name = "Thüringen",
                LocalName = "Thüringen"
            }

        ]);
    }
}
