using AngryMonkey.Cloud.Geography;
namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    private static void FillInSubdivisionsSB()
    {
        AddSubdivisions("SB", new List<Subdivision>()
        {
            new()
            { 
                Code = "CT",
                Type = "Territory",
                Name = "Capital Territory",
                LocalName = "Capital Territory"
            },
            new()
            { 
                Code = "CE",
                Type = "Province",
                Name = "Central",
                LocalName = "Central"
            },
            new()
            { 
                Code = "CH",
                Type = "Province",
                Name = "Choiseul",
                LocalName = "Choiseul"
            },
            new()
            { 
                Code = "GU",
                Type = "Province",
                Name = "Guadalcanal",
                LocalName = "Guadalcanal"
            },
            new()
            { 
                Code = "IS",
                Type = "Province",
                Name = "Isabel",
                LocalName = "Isabel"
            },
            new()
            { 
                Code = "MK",
                Type = "Province",
                Name = "Makira-Ulawa",
                LocalName = "Makira-Ulawa"
            },
            new()
            { 
                Code = "ML",
                Type = "Province",
                Name = "Malaita",
                LocalName = "Malaita"
            },
            new()
            { 
                Code = "RB",
                Type = "Province",
                Name = "Rennell and Bellona",
                LocalName = "Rennell and Bellona"
            },
            new()
            { 
                Code = "TE",
                Type = "Province",
                Name = "Temotu",
                LocalName = "Temotu"
            },
            new()
            { 
                Code = "WE",
                Type = "Province",
                Name = "Western",
                LocalName = "Western"
            }

        });
    }
}
