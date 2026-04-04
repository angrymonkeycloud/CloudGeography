using AngryMonkey.Cloud.Geography;
namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    private static void FillInSubdivisionsJM()
    {
        AddSubdivisions("JM",
        [
            new()
            { 
                Code = "13",
                Type = SubdivisionTypes.Parish,
                Name = "Clarendon",
                LocalName = "Clarendon"
            },
            new()
            { 
                Code = "9",
                Type = SubdivisionTypes.Parish,
                Name = "Hanover",
                LocalName = "Hanover"
            },
            new()
            { 
                Code = "1",
                Type = SubdivisionTypes.Parish,
                Name = "Kingston",
                LocalName = "Kingston"
            },
            new()
            { 
                Code = "12",
                Type = SubdivisionTypes.Parish,
                Name = "Manchester",
                LocalName = "Manchester"
            },
            new()
            { 
                Code = "4",
                Type = SubdivisionTypes.Parish,
                Name = "Portland",
                LocalName = "Portland"
            },
            new()
            { 
                Code = "2",
                Type = SubdivisionTypes.Parish,
                Name = "Saint Andrew",
                LocalName = "Saint Andrew"
            },
            new()
            { 
                Code = "6",
                Type = SubdivisionTypes.Parish,
                Name = "Saint Ann",
                LocalName = "Saint Ann"
            },
            new()
            { 
                Code = "14",
                Type = SubdivisionTypes.Parish,
                Name = "Saint Catherine",
                LocalName = "Saint Catherine"
            },
            new()
            { 
                Code = "11",
                Type = SubdivisionTypes.Parish,
                Name = "Saint Elizabeth",
                LocalName = "Saint Elizabeth"
            },
            new()
            { 
                Code = "8",
                Type = SubdivisionTypes.Parish,
                Name = "Saint James",
                LocalName = "Saint James"
            },
            new()
            { 
                Code = "5",
                Type = SubdivisionTypes.Parish,
                Name = "Saint Mary",
                LocalName = "Saint Mary"
            },
            new()
            { 
                Code = "3",
                Type = SubdivisionTypes.Parish,
                Name = "Saint Thomas",
                LocalName = "Saint Thomas"
            },
            new()
            { 
                Code = "7",
                Type = SubdivisionTypes.Parish,
                Name = "Trelawny",
                LocalName = "Trelawny"
            },
            new()
            { 
                Code = "10",
                Type = SubdivisionTypes.Parish,
                Name = "Westmoreland",
                LocalName = "Westmoreland"
            }

        ]);
    }
}
