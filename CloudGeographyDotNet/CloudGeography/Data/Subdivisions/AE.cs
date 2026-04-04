using AngryMonkey.Cloud.Geography;
namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    private static void FillInSubdivisionsAE()
    {
        AddSubdivisions("AE",
        [
            new()
            { 
                Code = "AZ",
                Type = SubdivisionTypes.Emirate,
                Name = "Abu Dhabi",
                LocalName = "أَبُـوظَـبِي"
            },
            new()
            { 
                Code = "AJ",
                Type = SubdivisionTypes.Emirate,
                Name = "Ajman",
                LocalName = "عجمان"
            },
            new()
            { 
                Code = "FU",
                Type = SubdivisionTypes.Emirate,
                Name = "Al Fujairah",
                LocalName = "الفجيرة"
            },
            new()
            { 
                Code = "DU",
                Type = SubdivisionTypes.Emirate,
                Name = "Dubai",
                LocalName = "دبيّ"
            },
            new()
            { 
                Code = "RK",
                Type = SubdivisionTypes.Emirate,
                Name = "Ras Al Khaimah",
                LocalName = "رَأْس ٱلْخَيْمَة"
            },
            new()
            { 
                Code = "SH",
                Type = SubdivisionTypes.Emirate,
                Name = "Sharjah",
                LocalName = "ٱلشَّارِقَة"
            },
            new()
            { 
                Code = "UQ",
                Type = SubdivisionTypes.Emirate,
                Name = "Umm Al Quwain",
                LocalName = "أم القيوين"
            }

        ]);
    }
}
