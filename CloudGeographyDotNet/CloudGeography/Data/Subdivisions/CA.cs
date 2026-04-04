using AngryMonkey.Cloud.Geography;
namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    private static void FillInSubdivisionsCA()
    {
        AddSubdivisions("CA",
        [
            new()
            { 
                Code = "AB",
                Type = SubdivisionTypes.Province,
                Name = "Alberta",
                LocalName = "Alberta"
            },
            new()
            { 
                Code = "BC",
                Type = SubdivisionTypes.Province,
                Name = "British Columbia",
                LocalName = "British Columbia"
            },
            new()
            { 
                Code = "MB",
                Type = SubdivisionTypes.Province,
                Name = "Manitoba",
                LocalName = "Manitoba"
            },
            new()
            { 
                Code = "NB",
                Type = SubdivisionTypes.Province,
                Name = "New Brunswick",
                LocalName = "New Brunswick"
            },
            new()
            { 
                Code = "NL",
                Type = SubdivisionTypes.Province,
                Name = "Newfoundland and Labrador",
                LocalName = "Newfoundland and Labrador"
            },
            new()
            { 
                Code = "NT",
                Type = SubdivisionTypes.Territory,
                Name = "Northwest Territories",
                LocalName = "Northwest Territories"
            },
            new()
            { 
                Code = "NS",
                Type = SubdivisionTypes.Province,
                Name = "Nova Scotia",
                LocalName = "Nova Scotia"
            },
            new()
            { 
                Code = "NU",
                Type = SubdivisionTypes.Territory,
                Name = "Nunavut",
                LocalName = "Nunavut"
            },
            new()
            { 
                Code = "ON",
                Type = SubdivisionTypes.Province,
                Name = "Ontario",
                LocalName = "Ontario"
            },
            new()
            { 
                Code = "PE",
                Type = SubdivisionTypes.Province,
                Name = "Prince Edward Island",
                LocalName = "Prince Edward Island"
            },
            new()
            { 
                Code = "QC",
                Type = SubdivisionTypes.Province,
                Name = "Quebec",
                LocalName = "Quebec"
            },
            new()
            { 
                Code = "SK",
                Type = SubdivisionTypes.Province,
                Name = "Saskatchewan",
                LocalName = "Saskatchewan"
            },
            new()
            { 
                Code = "YT",
                Type = SubdivisionTypes.Territory,
                Name = "Yukon",
                LocalName = "Yukon"
            }

        ]);
    }
}
