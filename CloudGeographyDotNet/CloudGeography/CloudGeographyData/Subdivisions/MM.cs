using AngryMonkey.Cloud.Geography;
namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    private static void FillInSubdivisionsMM()
    {
        AddSubdivisions("MM", new List<Subdivision>()
        {
            new()
            { 
                Code = "7",
                Type = "Region",
                Name = "Ayeyarwady",
                LocalName = "Ayeyarwady"
            },
            new()
            { 
                Code = "2",
                Type = "Region",
                Name = "Bago",
                LocalName = "Bago"
            },
            new()
            { 
                Code = "14",
                Type = "State",
                Name = "Chin",
                LocalName = "Chin"
            },
            new()
            { 
                Code = "11",
                Type = "State",
                Name = "Kachin",
                LocalName = "Kachin"
            },
            new()
            { 
                Code = "12",
                Type = "State",
                Name = "Kayah",
                LocalName = "Kayah"
            },
            new()
            { 
                Code = "13",
                Type = "State",
                Name = "Kayin",
                LocalName = "Kayin"
            },
            new()
            { 
                Code = "3",
                Type = "Region",
                Name = "Magway",
                LocalName = "Magway"
            },
            new()
            { 
                Code = "4",
                Type = "Region",
                Name = "Mandalay",
                LocalName = "Mandalay"
            },
            new()
            { 
                Code = "15",
                Type = "State",
                Name = "Mon",
                LocalName = "Mon"
            },
            new()
            { 
                Code = "16",
                Type = "State",
                Name = "Rakhine",
                LocalName = "Rakhine"
            },
            new()
            { 
                Code = "1",
                Type = "Region",
                Name = "Sagaing",
                LocalName = "Sagaing"
            },
            new()
            { 
                Code = "17",
                Type = "State",
                Name = "Shan",
                LocalName = "Shan"
            },
            new()
            { 
                Code = "5",
                Type = "Region",
                Name = "Tanintharyi",
                LocalName = "Tanintharyi"
            },
            new()
            { 
                Code = "6",
                Type = "Region",
                Name = "Yangon",
                LocalName = "Yangon"
            }

        });
    }
}
