using AngryMonkey.Cloud.Geography;
namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    private static void FillInSubdivisionsIQ()
    {
        AddSubdivisions("IQ",
        [
            new()
            { 
                Code = "AN",
                Type = SubdivisionTypes.Governorate,
                Name = "AI Anbar",
                LocalName = "AI Anbar"
            },
            new()
            { 
                Code = "MU",
                Type = SubdivisionTypes.Governorate,
                Name = "AI Muthanná",
                LocalName = "AI Muthanná"
            },
            new()
            { 
                Code = "BA",
                Type = SubdivisionTypes.Governorate,
                Name = "Al Basrah",
                LocalName = "Al Basrah"
            },
            new()
            { 
                Code = "QA",
                Type = SubdivisionTypes.Governorate,
                Name = "Al Qadisiyah",
                LocalName = "Al Qadisiyah"
            },
            new()
            { 
                Code = "NA",
                Type = SubdivisionTypes.Governorate,
                Name = "An Najaf",
                LocalName = "An Najaf"
            },
            new()
            { 
                Code = "AR",
                Type = SubdivisionTypes.Governorate,
                Name = "Arbil",
                LocalName = "Arbil"
            },
            new()
            { 
                Code = "SU",
                Type = SubdivisionTypes.Governorate,
                Name = "As Sulaymaniyah",
                LocalName = "As Sulaymaniyah"
            },
            new()
            { 
                Code = "BB",
                Type = SubdivisionTypes.Governorate,
                Name = "Babil",
                LocalName = "Babil"
            },
            new()
            { 
                Code = "BG",
                Type = SubdivisionTypes.Governorate,
                Name = "Baghdad",
                LocalName = "Baghdad"
            },
            new()
            { 
                Code = "DA",
                Type = SubdivisionTypes.Governorate,
                Name = "Dahuk",
                LocalName = "Dahuk"
            },
            new()
            { 
                Code = "DQ",
                Type = SubdivisionTypes.Governorate,
                Name = "Dhi Qar",
                LocalName = "Dhi Qar"
            },
            new()
            { 
                Code = "DI",
                Type = SubdivisionTypes.Governorate,
                Name = "Diyalá",
                LocalName = "Diyalá"
            },
            new()
            { 
                Code = "KA",
                Type = SubdivisionTypes.Governorate,
                Name = "Karbala'",
                LocalName = "Karbala'"
            },
            new()
            { 
                Code = "KI",
                Type = SubdivisionTypes.Governorate,
                Name = "Kirkuk",
                LocalName = "Kirkuk"
            },
            new()
            { 
                Code = "MA",
                Type = SubdivisionTypes.Governorate,
                Name = "Maysan",
                LocalName = "Maysan"
            },
            new()
            { 
                Code = "NI",
                Type = SubdivisionTypes.Governorate,
                Name = "Ninawá",
                LocalName = "Ninawá"
            },
            new()
            { 
                Code = "SD",
                Type = SubdivisionTypes.Governorate,
                Name = "Salah ad Din",
                LocalName = "Salah ad Din"
            },
            new()
            { 
                Code = "WA",
                Type = SubdivisionTypes.Governorate,
                Name = "Wasit",
                LocalName = "Wasit"
            }

        ]);
    }
}
