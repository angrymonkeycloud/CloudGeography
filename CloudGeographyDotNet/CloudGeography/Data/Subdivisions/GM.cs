using AngryMonkey.Cloud.Geography;
namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    private static void FillInSubdivisionsGM()
    {
        AddSubdivisions("GM",
        [
            new()
            { 
                Code = "B",
                Type = SubdivisionTypes.City,
                Name = "Banjul",
                LocalName = "Banjul"
            },
            new()
            { 
                Code = "M",
                Type = SubdivisionTypes.Division,
                Name = "Central River",
                LocalName = "Central River"
            },
            new()
            { 
                Code = "L",
                Type = SubdivisionTypes.Division,
                Name = "Lower River",
                LocalName = "Lower River"
            },
            new()
            { 
                Code = "N",
                Type = SubdivisionTypes.Division,
                Name = "North Bank",
                LocalName = "North Bank"
            },
            new()
            { 
                Code = "U",
                Type = SubdivisionTypes.Division,
                Name = "Upper River",
                LocalName = "Upper River"
            },
            new()
            { 
                Code = "W",
                Type = SubdivisionTypes.Division,
                Name = "Western",
                LocalName = "Western"
            }

        ]);
    }
}
