using AngryMonkey.Cloud.Geography;
namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    private static void FillInSubdivisionsDK()
    {
        AddSubdivisions("DK",
        [
            new()
            { 
                Code = "84",
                Type = SubdivisionTypes.Region,
                Name = "Hovedstaden",
                LocalName = "Hovedstaden"
            },
            new()
            { 
                Code = "82",
                Type = SubdivisionTypes.Region,
                Name = "Midtjylland",
                LocalName = "Midtjylland"
            },
            new()
            { 
                Code = "81",
                Type = SubdivisionTypes.Region,
                Name = "Nordjylland",
                LocalName = "Nordjylland"
            },
            new()
            { 
                Code = "85",
                Type = SubdivisionTypes.Region,
                Name = "Sjælland",
                LocalName = "Sjælland"
            },
            new()
            { 
                Code = "83",
                Type = SubdivisionTypes.Region,
                Name = "Syddanmark",
                LocalName = "Syddanmark"
            }

        ]);
    }
}
