using AngryMonkey.Cloud.Geography;
namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    private static void FillInSubdivisionsJM()
    {
        AddSubdivisions("JM", new List<Subdivision>()
        {
            new()
            { 
                Code = "13",
                Type = "Parish",
                Name = "Clarendon",
                LocalName = "Clarendon"
            },
            new()
            { 
                Code = "9",
                Type = "Parish",
                Name = "Hanover",
                LocalName = "Hanover"
            },
            new()
            { 
                Code = "1",
                Type = "Parish",
                Name = "Kingston",
                LocalName = "Kingston"
            },
            new()
            { 
                Code = "12",
                Type = "Parish",
                Name = "Manchester",
                LocalName = "Manchester"
            },
            new()
            { 
                Code = "4",
                Type = "Parish",
                Name = "Portland",
                LocalName = "Portland"
            },
            new()
            { 
                Code = "2",
                Type = "Parish",
                Name = "Saint Andrew",
                LocalName = "Saint Andrew"
            },
            new()
            { 
                Code = "6",
                Type = "Parish",
                Name = "Saint Ann",
                LocalName = "Saint Ann"
            },
            new()
            { 
                Code = "14",
                Type = "Parish",
                Name = "Saint Catherine",
                LocalName = "Saint Catherine"
            },
            new()
            { 
                Code = "11",
                Type = "Parish",
                Name = "Saint Elizabeth",
                LocalName = "Saint Elizabeth"
            },
            new()
            { 
                Code = "8",
                Type = "Parish",
                Name = "Saint James",
                LocalName = "Saint James"
            },
            new()
            { 
                Code = "5",
                Type = "Parish",
                Name = "Saint Mary",
                LocalName = "Saint Mary"
            },
            new()
            { 
                Code = "3",
                Type = "Parish",
                Name = "Saint Thomas",
                LocalName = "Saint Thomas"
            },
            new()
            { 
                Code = "7",
                Type = "Parish",
                Name = "Trelawny",
                LocalName = "Trelawny"
            },
            new()
            { 
                Code = "10",
                Type = "Parish",
                Name = "Westmoreland",
                LocalName = "Westmoreland"
            }

        });
    }
}
