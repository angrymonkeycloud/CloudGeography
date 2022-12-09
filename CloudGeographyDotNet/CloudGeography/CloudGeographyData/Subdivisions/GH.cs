using AngryMonkey.Cloud.Geography;
namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    private static void FillInSubdivisionsGH()
    {
        AddSubdivisions("GH", new List<Subdivision>()
        {
            new()
            { 
                Code = "AH",
                Type = "Region",
                Name = "Ashanti",
                LocalName = "Ashanti"
            },
            new()
            { 
                Code = "BA",
                Type = "Region",
                Name = "Brong-Ahafo",
                LocalName = "Brong-Ahafo"
            },
            new()
            { 
                Code = "CP",
                Type = "Region",
                Name = "Central",
                LocalName = "Central"
            },
            new()
            { 
                Code = "EP",
                Type = "Region",
                Name = "Eastern",
                LocalName = "Eastern"
            },
            new()
            { 
                Code = "AA",
                Type = "Region",
                Name = "Greater Accra",
                LocalName = "Greater Accra"
            },
            new()
            { 
                Code = "NP",
                Type = "Region",
                Name = "Northern",
                LocalName = "Northern"
            },
            new()
            { 
                Code = "UE",
                Type = "Region",
                Name = "Upper East",
                LocalName = "Upper East"
            },
            new()
            { 
                Code = "UW",
                Type = "Region",
                Name = "Upper West",
                LocalName = "Upper West"
            },
            new()
            { 
                Code = "TV",
                Type = "Region",
                Name = "Volta",
                LocalName = "Volta"
            },
            new()
            { 
                Code = "WP",
                Type = "Region",
                Name = "Western",
                LocalName = "Western"
            }

        });
    }
}
