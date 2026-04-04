using AngryMonkey.Cloud.Geography;
namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    private static void FillInSubdivisionsLI()
    {
        AddSubdivisions("LI",
        [
            new()
            { 
                Code = "1",
                Type = SubdivisionTypes.Commune,
                Name = "Balzers",
                LocalName = "Balzers"
            },
            new()
            { 
                Code = "2",
                Type = SubdivisionTypes.Commune,
                Name = "Eschen",
                LocalName = "Eschen"
            },
            new()
            { 
                Code = "3",
                Type = SubdivisionTypes.Commune,
                Name = "Gamprin",
                LocalName = "Gamprin"
            },
            new()
            { 
                Code = "4",
                Type = SubdivisionTypes.Commune,
                Name = "Mauren",
                LocalName = "Mauren"
            },
            new()
            { 
                Code = "5",
                Type = SubdivisionTypes.Commune,
                Name = "Planken",
                LocalName = "Planken"
            },
            new()
            { 
                Code = "6",
                Type = SubdivisionTypes.Commune,
                Name = "Ruggell",
                LocalName = "Ruggell"
            },
            new()
            { 
                Code = "7",
                Type = SubdivisionTypes.Commune,
                Name = "Schaan",
                LocalName = "Schaan"
            },
            new()
            { 
                Code = "8",
                Type = SubdivisionTypes.Commune,
                Name = "Schellenberg",
                LocalName = "Schellenberg"
            },
            new()
            { 
                Code = "9",
                Type = SubdivisionTypes.Commune,
                Name = "Triesen",
                LocalName = "Triesen"
            },
            new()
            { 
                Code = "10",
                Type = SubdivisionTypes.Commune,
                Name = "Triesenberg",
                LocalName = "Triesenberg"
            },
            new()
            { 
                Code = "11",
                Type = SubdivisionTypes.Commune,
                Name = "Vaduz",
                LocalName = "Vaduz"
            }

        ]);
    }
}
