using AngryMonkey.Cloud.Geography;
namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    private static void FillInSubdivisionsCA()
    {
        AddSubdivisions("CA", new List<Subdivision>()
        {
            new()
            { 
                Code = "AB",
                Type = "Province",
                Name = "Alberta",
                LocalName = "Alberta"
            },
            new()
            { 
                Code = "BC",
                Type = "Province",
                Name = "British Columbia",
                LocalName = "British Columbia"
            },
            new()
            { 
                Code = "MB",
                Type = "Province",
                Name = "Manitoba",
                LocalName = "Manitoba"
            },
            new()
            { 
                Code = "NB",
                Type = "Province",
                Name = "New Brunswick",
                LocalName = "New Brunswick"
            },
            new()
            { 
                Code = "NL",
                Type = "Province",
                Name = "Newfoundland and Labrador",
                LocalName = "Newfoundland and Labrador"
            },
            new()
            { 
                Code = "NT",
                Type = "Territory",
                Name = "Northwest Territories",
                LocalName = "Northwest Territories"
            },
            new()
            { 
                Code = "NS",
                Type = "Province",
                Name = "Nova Scotia",
                LocalName = "Nova Scotia"
            },
            new()
            { 
                Code = "NU",
                Type = "Territory",
                Name = "Nunavut",
                LocalName = "Nunavut"
            },
            new()
            { 
                Code = "ON",
                Type = "Province",
                Name = "Ontario",
                LocalName = "Ontario"
            },
            new()
            { 
                Code = "PE",
                Type = "Province",
                Name = "Prince Edward Island",
                LocalName = "Prince Edward Island"
            },
            new()
            { 
                Code = "QC",
                Type = "Province",
                Name = "Quebec",
                LocalName = "Quebec"
            },
            new()
            { 
                Code = "SK",
                Type = "Province",
                Name = "Saskatchewan",
                LocalName = "Saskatchewan"
            },
            new()
            { 
                Code = "YT",
                Type = "Territory",
                Name = "Yukon",
                LocalName = "Yukon"
            }

        });
    }
}
