using AngryMonkey.Cloud.Geography;
namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    private static void FillInSubdivisionsLY()
    {
        AddSubdivisions("LY",
        [
            new()
            { 
                Code = "BU",
                Type = SubdivisionTypes.Popularate,
                Name = "Al Butnan",
                LocalName = "Al Butnan"
            },
            new()
            { 
                Code = "JA",
                Type = SubdivisionTypes.Popularate,
                Name = "Al Jabal al Akh?ar",
                LocalName = "Al Jabal al Akh?ar"
            },
            new()
            { 
                Code = "JG",
                Type = SubdivisionTypes.Popularate,
                Name = "Al Jabal al Gharbi",
                LocalName = "Al Jabal al Gharbi"
            },
            new()
            { 
                Code = "JI",
                Type = SubdivisionTypes.Popularate,
                Name = "Al Jafarah",
                LocalName = "Al Jafarah"
            },
            new()
            { 
                Code = "JU",
                Type = SubdivisionTypes.Popularate,
                Name = "Al Jufrah",
                LocalName = "Al Jufrah"
            },
            new()
            { 
                Code = "KF",
                Type = SubdivisionTypes.Popularate,
                Name = "Al Kufrah",
                LocalName = "Al Kufrah"
            },
            new()
            { 
                Code = "MJ",
                Type = SubdivisionTypes.Popularate,
                Name = "Al Marj",
                LocalName = "Al Marj"
            },
            new()
            { 
                Code = "MB",
                Type = SubdivisionTypes.Popularate,
                Name = "Al Marqab",
                LocalName = "Al Marqab"
            },
            new()
            { 
                Code = "WA",
                Type = SubdivisionTypes.Popularate,
                Name = "Al Wa?at",
                LocalName = "Al Wa?at"
            },
            new()
            { 
                Code = "NQ",
                Type = SubdivisionTypes.Popularate,
                Name = "An Nuqat al Khams",
                LocalName = "An Nuqat al Khams"
            },
            new()
            { 
                Code = "ZA",
                Type = SubdivisionTypes.Popularate,
                Name = "Az Zawiyah",
                LocalName = "Az Zawiyah"
            },
            new()
            { 
                Code = "BA",
                Type = SubdivisionTypes.Popularate,
                Name = "Banghazi",
                LocalName = "Banghazi"
            },
            new()
            { 
                Code = "DR",
                Type = SubdivisionTypes.Popularate,
                Name = "Darnah",
                LocalName = "Darnah"
            },
            new()
            { 
                Code = "GT",
                Type = SubdivisionTypes.Popularate,
                Name = "Ghat",
                LocalName = "Ghat"
            },
            new()
            { 
                Code = "MI",
                Type = SubdivisionTypes.Popularate,
                Name = "Misratah",
                LocalName = "Misratah"
            },
            new()
            { 
                Code = "MQ",
                Type = SubdivisionTypes.Popularate,
                Name = "Murzuq",
                LocalName = "Murzuq"
            },
            new()
            { 
                Code = "NL",
                Type = SubdivisionTypes.Popularate,
                Name = "Nalut",
                LocalName = "Nalut"
            },
            new()
            { 
                Code = "SB",
                Type = SubdivisionTypes.Popularate,
                Name = "Sabha",
                LocalName = "Sabha"
            },
            new()
            { 
                Code = "SR",
                Type = SubdivisionTypes.Popularate,
                Name = "Surt",
                LocalName = "Surt"
            },
            new()
            { 
                Code = "TB",
                Type = SubdivisionTypes.Popularate,
                Name = "Tarabulus",
                LocalName = "Tarabulus"
            },
            new()
            { 
                Code = "WD",
                Type = SubdivisionTypes.Popularate,
                Name = "Wadi al Hayat",
                LocalName = "Wadi al Hayat"
            },
            new()
            { 
                Code = "WS",
                Type = SubdivisionTypes.Popularate,
                Name = "Wadi ash Shati?",
                LocalName = "Wadi ash Shati?"
            }

        ]);
    }
}
