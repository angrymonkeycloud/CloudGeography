using AngryMonkey.Cloud.Geography;
namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    private static void FillInSubdivisionsJO()
    {
        AddSubdivisions("JO",
        [
            new()
            { 
                Code = "AJ",
                Type = SubdivisionTypes.Governorate,
                Name = "Ajlun",
                LocalName = "Ajlun"
            },
            new()
            { 
                Code = "KA",
                Type = SubdivisionTypes.Governorate,
                Name = "AI Karak",
                LocalName = "AI Karak"
            },
            new()
            { 
                Code = "MA",
                Type = SubdivisionTypes.Governorate,
                Name = "AI Mafraq",
                LocalName = "AI Mafraq"
            },
            new()
            { 
                Code = "AM",
                Type = SubdivisionTypes.Governorate,
                Name = "Al A¯simah",
                LocalName = "Al A¯simah"
            },
            new()
            { 
                Code = "AQ",
                Type = SubdivisionTypes.Governorate,
                Name = "Al Aqabah",
                LocalName = "Al Aqabah"
            },
            new()
            { 
                Code = "BA",
                Type = SubdivisionTypes.Governorate,
                Name = "Al Balqa",
                LocalName = "Al Balqa"
            },
            new()
            { 
                Code = "AT",
                Type = SubdivisionTypes.Governorate,
                Name = "At Tafilah",
                LocalName = "At Tafilah"
            },
            new()
            { 
                Code = "AZ",
                Type = SubdivisionTypes.Governorate,
                Name = "Az Zarqa",
                LocalName = "Az Zarqa"
            },
            new()
            { 
                Code = "IR",
                Type = SubdivisionTypes.Governorate,
                Name = "Irbid",
                LocalName = "Irbid"
            },
            new()
            { 
                Code = "JA",
                Type = SubdivisionTypes.Governorate,
                Name = "Jarash",
                LocalName = "Jarash"
            },
            new()
            { 
                Code = "MN",
                Type = SubdivisionTypes.Governorate,
                Name = "Maan",
                LocalName = "Maan"
            },
            new()
            { 
                Code = "MD",
                Type = SubdivisionTypes.Governorate,
                Name = "Madaba",
                LocalName = "Madaba"
            }

        ]);
    }
}
