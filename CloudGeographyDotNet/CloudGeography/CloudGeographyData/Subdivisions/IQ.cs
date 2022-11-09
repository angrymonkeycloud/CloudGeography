using AngryMonkey.Cloud.Geography;
namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    private static void FillInSubdivisionsIQ()
    {
        AddSubdivisions("IQ", new List<Subdivision>()
        {
            new()
            { 
                Code = "AN",
                Type = "Governorate",
                Name = "AI Anbar",
                LocalName = "AI Anbar"
            },
            new()
            { 
                Code = "MU",
                Type = "Governorate",
                Name = "AI Muthanná",
                LocalName = "AI Muthanná"
            },
            new()
            { 
                Code = "BA",
                Type = "Governorate",
                Name = "Al Basrah",
                LocalName = "Al Basrah"
            },
            new()
            { 
                Code = "QA",
                Type = "Governorate",
                Name = "Al Qadisiyah",
                LocalName = "Al Qadisiyah"
            },
            new()
            { 
                Code = "NA",
                Type = "Governorate",
                Name = "An Najaf",
                LocalName = "An Najaf"
            },
            new()
            { 
                Code = "AR",
                Type = "Governorate",
                Name = "Arbil",
                LocalName = "Arbil"
            },
            new()
            { 
                Code = "SU",
                Type = "Governorate",
                Name = "As Sulaymaniyah",
                LocalName = "As Sulaymaniyah"
            },
            new()
            { 
                Code = "BB",
                Type = "Governorate",
                Name = "Babil",
                LocalName = "Babil"
            },
            new()
            { 
                Code = "BG",
                Type = "Governorate",
                Name = "Baghdad",
                LocalName = "Baghdad"
            },
            new()
            { 
                Code = "DA",
                Type = "Governorate",
                Name = "Dahuk",
                LocalName = "Dahuk"
            },
            new()
            { 
                Code = "DQ",
                Type = "Governorate",
                Name = "Dhi Qar",
                LocalName = "Dhi Qar"
            },
            new()
            { 
                Code = "DI",
                Type = "Governorate",
                Name = "Diyalá",
                LocalName = "Diyalá"
            },
            new()
            { 
                Code = "KA",
                Type = "Governorate",
                Name = "Karbala'",
                LocalName = "Karbala'"
            },
            new()
            { 
                Code = "KI",
                Type = "Governorate",
                Name = "Kirkuk",
                LocalName = "Kirkuk"
            },
            new()
            { 
                Code = "MA",
                Type = "Governorate",
                Name = "Maysan",
                LocalName = "Maysan"
            },
            new()
            { 
                Code = "NI",
                Type = "Governorate",
                Name = "Ninawá",
                LocalName = "Ninawá"
            },
            new()
            { 
                Code = "SD",
                Type = "Governorate",
                Name = "Salah ad Din",
                LocalName = "Salah ad Din"
            },
            new()
            { 
                Code = "WA",
                Type = "Governorate",
                Name = "Wasit",
                LocalName = "Wasit"
            }

        });
    }
}
