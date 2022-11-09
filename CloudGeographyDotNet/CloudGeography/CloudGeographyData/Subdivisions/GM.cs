using AngryMonkey.Cloud.Geography;
namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    private static void FillInSubdivisionsGM()
    {
        AddSubdivisions("GM", new List<Subdivision>()
        {
            new()
            { 
                Code = "B",
                Type = "City",
                Name = "Banjul",
                LocalName = "Banjul"
            },
            new()
            { 
                Code = "M",
                Type = "Division",
                Name = "Central River",
                LocalName = "Central River"
            },
            new()
            { 
                Code = "L",
                Type = "Division",
                Name = "Lower River",
                LocalName = "Lower River"
            },
            new()
            { 
                Code = "N",
                Type = "Division",
                Name = "North Bank",
                LocalName = "North Bank"
            },
            new()
            { 
                Code = "U",
                Type = "Division",
                Name = "Upper River",
                LocalName = "Upper River"
            },
            new()
            { 
                Code = "W",
                Type = "Division",
                Name = "Western",
                LocalName = "Western"
            }

        });
    }
}
