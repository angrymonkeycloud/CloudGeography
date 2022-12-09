using AngryMonkey.Cloud.Geography;
namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    private static void FillInSubdivisionsAU()
    {
        AddSubdivisions("AU", new List<Subdivision>()
        {
            new()
            { 
                Code = "ACT",
                Type = "Territory",
                Name = "Australian Capital Territory",
                LocalName = "Australian Capital Territory"
            },
            new()
            { 
                Code = "NSW",
                Type = "State",
                Name = "New South Wales",
                LocalName = "New South Wales"
            },
            new()
            { 
                Code = "NT",
                Type = "Territory",
                Name = "Northern Territory",
                LocalName = "Northern Territory"
            },
            new()
            { 
                Code = "QLD",
                Type = "State",
                Name = "Queensland",
                LocalName = "Queensland"
            },
            new()
            { 
                Code = "SA",
                Type = "State",
                Name = "South Australia",
                LocalName = "South Australia"
            },
            new()
            { 
                Code = "TAS",
                Type = "State",
                Name = "Tasmania",
                LocalName = "Tasmania"
            },
            new()
            { 
                Code = "VIC",
                Type = "State",
                Name = "Victoria",
                LocalName = "Victoria"
            },
            new()
            { 
                Code = "WA",
                Type = "State",
                Name = "Western Australia",
                LocalName = "Western Australia"
            }

        });
    }
}
