using AngryMonkey.Cloud.Geography;
namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    private static void FillInSubdivisionsJO()
    {
        AddSubdivisions("JO", new List<Subdivision>()
        {
            new()
            { 
                Code = "AJ",
                Type = "Governorate",
                Name = "Ajlun",
                LocalName = "Ajlun"
            },
            new()
            { 
                Code = "KA",
                Type = "Governorate",
                Name = "AI Karak",
                LocalName = "AI Karak"
            },
            new()
            { 
                Code = "MA",
                Type = "Governorate",
                Name = "AI Mafraq",
                LocalName = "AI Mafraq"
            },
            new()
            { 
                Code = "AM",
                Type = "Governorate",
                Name = "Al A¯simah",
                LocalName = "Al A¯simah"
            },
            new()
            { 
                Code = "AQ",
                Type = "Governorate",
                Name = "Al Aqabah",
                LocalName = "Al Aqabah"
            },
            new()
            { 
                Code = "BA",
                Type = "Governorate",
                Name = "Al Balqa",
                LocalName = "Al Balqa"
            },
            new()
            { 
                Code = "AT",
                Type = "Governorate",
                Name = "At Tafilah",
                LocalName = "At Tafilah"
            },
            new()
            { 
                Code = "AZ",
                Type = "Governorate",
                Name = "Az Zarqa",
                LocalName = "Az Zarqa"
            },
            new()
            { 
                Code = "IR",
                Type = "Governorate",
                Name = "Irbid",
                LocalName = "Irbid"
            },
            new()
            { 
                Code = "JA",
                Type = "Governorate",
                Name = "Jarash",
                LocalName = "Jarash"
            },
            new()
            { 
                Code = "MN",
                Type = "Governorate",
                Name = "Maan",
                LocalName = "Maan"
            },
            new()
            { 
                Code = "MD",
                Type = "Governorate",
                Name = "Madaba",
                LocalName = "Madaba"
            }

        });
    }
}
