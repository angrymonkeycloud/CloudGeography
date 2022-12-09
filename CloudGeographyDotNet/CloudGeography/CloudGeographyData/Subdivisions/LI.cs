using AngryMonkey.Cloud.Geography;
namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    private static void FillInSubdivisionsLI()
    {
        AddSubdivisions("LI", new List<Subdivision>()
        {
            new()
            { 
                Code = "1",
                Type = "Commune",
                Name = "Balzers",
                LocalName = "Balzers"
            },
            new()
            { 
                Code = "2",
                Type = "Commune",
                Name = "Eschen",
                LocalName = "Eschen"
            },
            new()
            { 
                Code = "3",
                Type = "Commune",
                Name = "Gamprin",
                LocalName = "Gamprin"
            },
            new()
            { 
                Code = "4",
                Type = "Commune",
                Name = "Mauren",
                LocalName = "Mauren"
            },
            new()
            { 
                Code = "5",
                Type = "Commune",
                Name = "Planken",
                LocalName = "Planken"
            },
            new()
            { 
                Code = "6",
                Type = "Commune",
                Name = "Ruggell",
                LocalName = "Ruggell"
            },
            new()
            { 
                Code = "7",
                Type = "Commune",
                Name = "Schaan",
                LocalName = "Schaan"
            },
            new()
            { 
                Code = "8",
                Type = "Commune",
                Name = "Schellenberg",
                LocalName = "Schellenberg"
            },
            new()
            { 
                Code = "9",
                Type = "Commune",
                Name = "Triesen",
                LocalName = "Triesen"
            },
            new()
            { 
                Code = "10",
                Type = "Commune",
                Name = "Triesenberg",
                LocalName = "Triesenberg"
            },
            new()
            { 
                Code = "11",
                Type = "Commune",
                Name = "Vaduz",
                LocalName = "Vaduz"
            }

        });
    }
}
