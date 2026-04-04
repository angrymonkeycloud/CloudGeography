using AngryMonkey.Cloud.Geography;
namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    private static void FillInSubdivisionsTV()
    {
        AddSubdivisions("TV",
        [
            new()
            { 
                Code = "NMG",
                Type = SubdivisionTypes.Island,
                Name = "Nanumaga",
                LocalName = "Nanumaga"
            },
            new()
            { 
                Code = "NMA",
                Type = SubdivisionTypes.Island,
                Name = "Nanumea",
                LocalName = "Nanumea"
            },
            new()
            { 
                Code = "NIT",
                Type = SubdivisionTypes.Island,
                Name = "Niutao",
                LocalName = "Niutao"
            },
            new()
            { 
                Code = "NIU",
                Type = SubdivisionTypes.Island,
                Name = "Nui",
                LocalName = "Nui"
            },
            new()
            { 
                Code = "NKF",
                Type = SubdivisionTypes.Island,
                Name = "Nukufetau",
                LocalName = "Nukufetau"
            },
            new()
            { 
                Code = "NKL",
                Type = SubdivisionTypes.Island,
                Name = "Nukulaelae",
                LocalName = "Nukulaelae"
            },
            new()
            { 
                Code = "VAI",
                Type = SubdivisionTypes.Island,
                Name = "Vaitupu",
                LocalName = "Vaitupu"
            }

        ]);
    }
}
