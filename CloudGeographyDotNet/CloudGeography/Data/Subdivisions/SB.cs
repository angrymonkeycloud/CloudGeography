using AngryMonkey.Cloud.Geography;
namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    private static void FillInSubdivisionsSB()
    {
        AddSubdivisions("SB",
        [
            new()
            { 
                Code = "CT",
                Type = SubdivisionTypes.Territory,
                Name = "Capital Territory",
                LocalName = "Capital Territory"
            },
            new()
            { 
                Code = "CE",
                Type = SubdivisionTypes.Province,
                Name = "Central",
                LocalName = "Central"
            },
            new()
            { 
                Code = "CH",
                Type = SubdivisionTypes.Province,
                Name = "Choiseul",
                LocalName = "Choiseul"
            },
            new()
            { 
                Code = "GU",
                Type = SubdivisionTypes.Province,
                Name = "Guadalcanal",
                LocalName = "Guadalcanal"
            },
            new()
            { 
                Code = "IS",
                Type = SubdivisionTypes.Province,
                Name = "Isabel",
                LocalName = "Isabel"
            },
            new()
            { 
                Code = "MK",
                Type = SubdivisionTypes.Province,
                Name = "Makira-Ulawa",
                LocalName = "Makira-Ulawa"
            },
            new()
            { 
                Code = "ML",
                Type = SubdivisionTypes.Province,
                Name = "Malaita",
                LocalName = "Malaita"
            },
            new()
            { 
                Code = "RB",
                Type = SubdivisionTypes.Province,
                Name = "Rennell and Bellona",
                LocalName = "Rennell and Bellona"
            },
            new()
            { 
                Code = "TE",
                Type = SubdivisionTypes.Province,
                Name = "Temotu",
                LocalName = "Temotu"
            },
            new()
            { 
                Code = "WE",
                Type = SubdivisionTypes.Province,
                Name = "Western",
                LocalName = "Western"
            }

        ]);
    }
}
