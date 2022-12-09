using AngryMonkey.Cloud.Geography;
namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    private static void FillInSubdivisionsAE()
    {
        AddSubdivisions("AE", new List<Subdivision>()
        {
            new()
            { 
                Code = "AZ",
                Type = "Emirate",
                Name = "Abu Dhabi",
                LocalName = "أَبُـوظَـبِي"
            },
            new()
            { 
                Code = "AJ",
                Type = "Emirate",
                Name = "Ajman",
                LocalName = "عجمان"
            },
            new()
            { 
                Code = "FU",
                Type = "Emirate",
                Name = "Al Fujairah",
                LocalName = "الفجيرة"
            },
            new()
            { 
                Code = "DU",
                Type = "Emirate",
                Name = "Dubai",
                LocalName = "دبيّ"
            },
            new()
            { 
                Code = "RK",
                Type = "Emirate",
                Name = "Ras Al Khaimah",
                LocalName = "رَأْس ٱلْخَيْمَة"
            },
            new()
            { 
                Code = "SH",
                Type = "Emirate",
                Name = "Sharjah",
                LocalName = "ٱلشَّارِقَة"
            },
            new()
            { 
                Code = "UQ",
                Type = "Emirate",
                Name = "Umm Al Quwain",
                LocalName = "أم القيوين"
            }

        });
    }
}
