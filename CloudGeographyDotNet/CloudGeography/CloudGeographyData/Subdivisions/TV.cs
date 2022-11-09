using AngryMonkey.Cloud.Geography;
namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    private static void FillInSubdivisionsTV()
    {
        AddSubdivisions("TV", new List<Subdivision>()
        {
            new()
            { 
                Code = "NMG",
                Type = "Island",
                Name = "Nanumaga",
                LocalName = "Nanumaga"
            },
            new()
            { 
                Code = "NMA",
                Type = "Island",
                Name = "Nanumea",
                LocalName = "Nanumea"
            },
            new()
            { 
                Code = "NIT",
                Type = "Island",
                Name = "Niutao",
                LocalName = "Niutao"
            },
            new()
            { 
                Code = "NIU",
                Type = "Island",
                Name = "Nui",
                LocalName = "Nui"
            },
            new()
            { 
                Code = "NKF",
                Type = "Island",
                Name = "Nukufetau",
                LocalName = "Nukufetau"
            },
            new()
            { 
                Code = "NKL",
                Type = "Island",
                Name = "Nukulaelae",
                LocalName = "Nukulaelae"
            },
            new()
            { 
                Code = "VAI",
                Type = "Island",
                Name = "Vaitupu",
                LocalName = "Vaitupu"
            }

        });
    }
}
