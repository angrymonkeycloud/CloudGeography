using AngryMonkey.Cloud.Geography;
namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    private static void FillInSubdivisionsAU()
    {
        AddSubdivisions("AU",
        [
            new()
            { 
                Code = "ACT",
                Type = SubdivisionTypes.Territory,
                Name = "Australian Capital Territory",
                LocalName = "Australian Capital Territory"
            },
            new()
            { 
                Code = "NSW",
                Type = SubdivisionTypes.State,
                Name = "New South Wales",
                LocalName = "New South Wales"
            },
            new()
            { 
                Code = "NT",
                Type = SubdivisionTypes.Territory,
                Name = "Northern Territory",
                LocalName = "Northern Territory"
            },
            new()
            { 
                Code = "QLD",
                Type = SubdivisionTypes.State,
                Name = "Queensland",
                LocalName = "Queensland"
            },
            new()
            { 
                Code = "SA",
                Type = SubdivisionTypes.State,
                Name = "South Australia",
                LocalName = "South Australia"
            },
            new()
            { 
                Code = "TAS",
                Type = SubdivisionTypes.State,
                Name = "Tasmania",
                LocalName = "Tasmania"
            },
            new()
            { 
                Code = "VIC",
                Type = SubdivisionTypes.State,
                Name = "Victoria",
                LocalName = "Victoria"
            },
            new()
            { 
                Code = "WA",
                Type = SubdivisionTypes.State,
                Name = "Western Australia",
                LocalName = "Western Australia"
            }

        ]);
    }
}
