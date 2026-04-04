using AngryMonkey.Cloud.Geography;
namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    private static void FillInSubdivisionsOM()
    {
        AddSubdivisions("OM",
        [
            new()
            { 
                Code = "DA",
                Type = SubdivisionTypes.Governorate,
                Name = "Ad Dakhiliyah",
                LocalName = "Ad Dakhiliyah"
            },
            new()
            { 
                Code = "WU",
                Type = SubdivisionTypes.Governorate,
                Name = "AI Wusta",
                LocalName = "AI Wusta"
            },
            new()
            { 
                Code = "BU",
                Type = SubdivisionTypes.Governorate,
                Name = "Al Buraymi",
                LocalName = "Al Buraymi"
            },
            new()
            { 
                Code = "ZA",
                Type = SubdivisionTypes.Region,
                Name = "Az Zahirah",
                LocalName = "Az Zahirah"
            },
            new()
            { 
                Code = "BJ",
                Type = SubdivisionTypes.Governorate,
                Name = "Janub al Batinah",
                LocalName = "Janub al Batinah"
            },
            new()
            { 
                Code = "SJ",
                Type = SubdivisionTypes.Governorate,
                Name = "Janub ash Sharqiyah",
                LocalName = "Janub ash Sharqiyah"
            },
            new()
            { 
                Code = "MA",
                Type = SubdivisionTypes.Governorate,
                Name = "Masqat",
                LocalName = "Masqat"
            },
            new()
            { 
                Code = "MU",
                Type = SubdivisionTypes.Governorate,
                Name = "Musandam",
                LocalName = "Musandam"
            },
            new()
            { 
                Code = "BS",
                Type = SubdivisionTypes.Governorate,
                Name = "Shamal al Batinah",
                LocalName = "Shamal al Batinah"
            },
            new()
            { 
                Code = "SS",
                Type = SubdivisionTypes.Governorate,
                Name = "Shamal ash Sharqiyah",
                LocalName = "Shamal ash Sharqiyah"
            },
            new()
            { 
                Code = "ZU",
                Type = SubdivisionTypes.Governorate,
                Name = "Z¸ufar",
                LocalName = "Z¸ufar"
            }

        ]);
    }
}
