using AngryMonkey.Cloud.Geography;
namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    private static void FillInSubdivisionsOM()
    {
        AddSubdivisions("OM", new List<Subdivision>()
        {
            new()
            { 
                Code = "DA",
                Type = "Governorate",
                Name = "Ad Dakhiliyah",
                LocalName = "Ad Dakhiliyah"
            },
            new()
            { 
                Code = "WU",
                Type = "Governorate",
                Name = "AI Wusta",
                LocalName = "AI Wusta"
            },
            new()
            { 
                Code = "BU",
                Type = "Governorate",
                Name = "Al Buraymi",
                LocalName = "Al Buraymi"
            },
            new()
            { 
                Code = "ZA",
                Type = "Region",
                Name = "Az Zahirah",
                LocalName = "Az Zahirah"
            },
            new()
            { 
                Code = "BJ",
                Type = "Governorate",
                Name = "Janub al Batinah",
                LocalName = "Janub al Batinah"
            },
            new()
            { 
                Code = "SJ",
                Type = "Governorate",
                Name = "Janub ash Sharqiyah",
                LocalName = "Janub ash Sharqiyah"
            },
            new()
            { 
                Code = "MA",
                Type = "Governorate",
                Name = "Masqat",
                LocalName = "Masqat"
            },
            new()
            { 
                Code = "MU",
                Type = "Governorate",
                Name = "Musandam",
                LocalName = "Musandam"
            },
            new()
            { 
                Code = "BS",
                Type = "Governorate",
                Name = "Shamal al Batinah",
                LocalName = "Shamal al Batinah"
            },
            new()
            { 
                Code = "SS",
                Type = "Governorate",
                Name = "Shamal ash Sharqiyah",
                LocalName = "Shamal ash Sharqiyah"
            },
            new()
            { 
                Code = "ZU",
                Type = "Governorate",
                Name = "Z¸ufar",
                LocalName = "Z¸ufar"
            }

        });
    }
}
