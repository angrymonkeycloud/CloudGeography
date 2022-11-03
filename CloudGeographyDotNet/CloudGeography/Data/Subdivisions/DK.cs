using AngryMonkey.Cloud.Geography;
namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    private static void FillInSubdivisionsDK()
    {
        AddSubdivisions("DK", new List<Subdivision>()
        {
            new()
            { 
                Code = "84",
                Type = "Region",
                Name = "Hovedstaden",
                LocalName = "Hovedstaden"
            },
            new()
            { 
                Code = "82",
                Type = "Region",
                Name = "Midtjylland",
                LocalName = "Midtjylland"
            },
            new()
            { 
                Code = "81",
                Type = "Region",
                Name = "Nordjylland",
                LocalName = "Nordjylland"
            },
            new()
            { 
                Code = "85",
                Type = "Region",
                Name = "Sjælland",
                LocalName = "Sjælland"
            },
            new()
            { 
                Code = "83",
                Type = "Region",
                Name = "Syddanmark",
                LocalName = "Syddanmark"
            }

        });
    }
}
