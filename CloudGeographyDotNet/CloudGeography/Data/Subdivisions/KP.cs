using AngryMonkey.Cloud.Geography;
namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    private static void FillInSubdivisionsKP()
    {
        AddSubdivisions("KP",
        [
            new()
            { 
                Code = "4",
                Type = SubdivisionTypes.Province,
                Name = "Chagang",
                LocalName = "자강도"
            },
            new()
            { 
                Code = "7",
                Type = SubdivisionTypes.Province,
                Name = "Kangwon",
                LocalName = "강원도"
            },
            new()
            { 
                Code = "9",
                Type = SubdivisionTypes.Province,
                Name = "North Hamgyong",
                LocalName = "함경북도"
            },
            new()
            { 
                Code = "6",
                Type = SubdivisionTypes.Province,
                Name = "North Hwanghae",
                LocalName = "황해북도"
            },
            new()
            { 
                Code = "3",
                Type = SubdivisionTypes.Province,
                Name = "North Pyongan",
                LocalName = "평안남도"
            },
            new()
            { 
                Code = "1",
                Type = SubdivisionTypes.CapitalCity,
                Name = "Pyongyang",
                LocalName = "평양시 平壤市"
            },
            new()
            { 
                Code = "13",
                Type = SubdivisionTypes.SpecialCity,
                Name = "Rason",
                LocalName = "라선시"
            },
            new()
            { 
                Code = "10",
                Type = SubdivisionTypes.Province,
                Name = "Ryanggang",
                LocalName = "량강도"
            },
            new()
            { 
                Code = "8",
                Type = SubdivisionTypes.Province,
                Name = "South Hamgyong",
                LocalName = "함경남도"
            },
            new()
            { 
                Code = "5",
                Type = SubdivisionTypes.Province,
                Name = "South Hwanghae",
                LocalName = "황해남도"
            },
            new()
            { 
                Code = "2",
                Type = SubdivisionTypes.Province,
                Name = "South Pyongan",
                LocalName = "평안남도"
            }

        ]);
    }
}
