using AngryMonkey.Cloud.Geography;
namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    private static void FillInSubdivisionsKP()
    {
        AddSubdivisions("KP", new List<Subdivision>()
        {
            new()
            { 
                Code = "4",
                Type = "Province",
                Name = "Chagang",
                LocalName = "자강도"
            },
            new()
            { 
                Code = "7",
                Type = "Province",
                Name = "Kangwon",
                LocalName = "강원도"
            },
            new()
            { 
                Code = "9",
                Type = "Province",
                Name = "North Hamgyong",
                LocalName = "함경북도"
            },
            new()
            { 
                Code = "6",
                Type = "Province",
                Name = "North Hwanghae",
                LocalName = "황해북도"
            },
            new()
            { 
                Code = "3",
                Type = "Province",
                Name = "North Pyongan",
                LocalName = "평안남도"
            },
            new()
            { 
                Code = "1",
                Type = "CapitalCity",
                Name = "Pyongyang",
                LocalName = "평양시 平壤市"
            },
            new()
            { 
                Code = "13",
                Type = "SpecialCity",
                Name = "Rason",
                LocalName = "라선시"
            },
            new()
            { 
                Code = "10",
                Type = "Province",
                Name = "Ryanggang",
                LocalName = "량강도"
            },
            new()
            { 
                Code = "8",
                Type = "Province",
                Name = "South Hamgyong",
                LocalName = "함경남도"
            },
            new()
            { 
                Code = "5",
                Type = "Province",
                Name = "South Hwanghae",
                LocalName = "황해남도"
            },
            new()
            { 
                Code = "2",
                Type = "Province",
                Name = "South Pyongan",
                LocalName = "평안남도"
            }

        });
    }
}
