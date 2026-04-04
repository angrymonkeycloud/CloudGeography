using AngryMonkey.Cloud.Geography;
namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    private static void FillInSubdivisionsGH()
    {
        AddSubdivisions("GH",
        [
            new()
            { 
                Code = "AH",
                Type = SubdivisionTypes.Region,
                Name = "Ashanti",
                LocalName = "Ashanti"
            },
            new()
            { 
                Code = "BA",
                Type = SubdivisionTypes.Region,
                Name = "Brong-Ahafo",
                LocalName = "Brong-Ahafo"
            },
            new()
            { 
                Code = "CP",
                Type = SubdivisionTypes.Region,
                Name = "Central",
                LocalName = "Central"
            },
            new()
            { 
                Code = "EP",
                Type = SubdivisionTypes.Region,
                Name = "Eastern",
                LocalName = "Eastern"
            },
            new()
            { 
                Code = "AA",
                Type = SubdivisionTypes.Region,
                Name = "Greater Accra",
                LocalName = "Greater Accra"
            },
            new()
            { 
                Code = "NP",
                Type = SubdivisionTypes.Region,
                Name = "Northern",
                LocalName = "Northern"
            },
            new()
            { 
                Code = "UE",
                Type = SubdivisionTypes.Region,
                Name = "Upper East",
                LocalName = "Upper East"
            },
            new()
            { 
                Code = "UW",
                Type = SubdivisionTypes.Region,
                Name = "Upper West",
                LocalName = "Upper West"
            },
            new()
            { 
                Code = "TV",
                Type = SubdivisionTypes.Region,
                Name = "Volta",
                LocalName = "Volta"
            },
            new()
            { 
                Code = "WP",
                Type = SubdivisionTypes.Region,
                Name = "Western",
                LocalName = "Western"
            }

        ]);
    }
}
