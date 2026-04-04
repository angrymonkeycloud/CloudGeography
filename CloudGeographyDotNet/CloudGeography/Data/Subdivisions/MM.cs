using AngryMonkey.Cloud.Geography;
namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    private static void FillInSubdivisionsMM()
    {
        AddSubdivisions("MM",
        [
            new()
            { 
                Code = "7",
                Type = SubdivisionTypes.Region,
                Name = "Ayeyarwady",
                LocalName = "Ayeyarwady"
            },
            new()
            { 
                Code = "2",
                Type = SubdivisionTypes.Region,
                Name = "Bago",
                LocalName = "Bago"
            },
            new()
            { 
                Code = "14",
                Type = SubdivisionTypes.State,
                Name = "Chin",
                LocalName = "Chin"
            },
            new()
            { 
                Code = "11",
                Type = SubdivisionTypes.State,
                Name = "Kachin",
                LocalName = "Kachin"
            },
            new()
            { 
                Code = "12",
                Type = SubdivisionTypes.State,
                Name = "Kayah",
                LocalName = "Kayah"
            },
            new()
            { 
                Code = "13",
                Type = SubdivisionTypes.State,
                Name = "Kayin",
                LocalName = "Kayin"
            },
            new()
            { 
                Code = "3",
                Type = SubdivisionTypes.Region,
                Name = "Magway",
                LocalName = "Magway"
            },
            new()
            { 
                Code = "4",
                Type = SubdivisionTypes.Region,
                Name = "Mandalay",
                LocalName = "Mandalay"
            },
            new()
            { 
                Code = "15",
                Type = SubdivisionTypes.State,
                Name = "Mon",
                LocalName = "Mon"
            },
            new()
            { 
                Code = "16",
                Type = SubdivisionTypes.State,
                Name = "Rakhine",
                LocalName = "Rakhine"
            },
            new()
            { 
                Code = "1",
                Type = SubdivisionTypes.Region,
                Name = "Sagaing",
                LocalName = "Sagaing"
            },
            new()
            { 
                Code = "17",
                Type = SubdivisionTypes.State,
                Name = "Shan",
                LocalName = "Shan"
            },
            new()
            { 
                Code = "5",
                Type = SubdivisionTypes.Region,
                Name = "Tanintharyi",
                LocalName = "Tanintharyi"
            },
            new()
            { 
                Code = "6",
                Type = SubdivisionTypes.Region,
                Name = "Yangon",
                LocalName = "Yangon"
            }

        ]);
    }
}
