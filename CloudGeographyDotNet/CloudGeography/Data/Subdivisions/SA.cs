using AngryMonkey.Cloud.Geography;
namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    private static void FillInSubdivisionsSA()
    {
        AddSubdivisions("SA",
        [
            new()
            { 
                Code = "11",
                Type = SubdivisionTypes.Province,
                Name = "AI Bahah",
                LocalName = "AI Bahah"
            },
            new()
            { 
                Code = "8",
                Type = SubdivisionTypes.Province,
                Name = "AI Hudud ash Shamaliyah",
                LocalName = "AI Hudud ash Shamaliyah"
            },
            new()
            { 
                Code = "12",
                Type = SubdivisionTypes.Province,
                Name = "AI Jawf",
                LocalName = "AI Jawf"
            },
            new()
            { 
                Code = "5",
                Type = SubdivisionTypes.Province,
                Name = "AI Qasim",
                LocalName = "AI Qasim"
            },
            new()
            { 
                Code = "3",
                Type = SubdivisionTypes.Province,
                Name = "Al Madinah al Munawwarah",
                LocalName = "Al Madinah al Munawwarah"
            },
            new()
            { 
                Code = "1",
                Type = SubdivisionTypes.Province,
                Name = "Ar Riyad",
                LocalName = "Ar Riyad"
            },
            new()
            { 
                Code = "4",
                Type = SubdivisionTypes.Province,
                Name = "Ash Sharqiyah",
                LocalName = "Ash Sharqiyah"
            },
            new()
            { 
                Code = "14",
                Type = SubdivisionTypes.Province,
                Name = "'Asir",
                LocalName = "'Asir"
            },
            new()
            { 
                Code = "6",
                Type = SubdivisionTypes.Province,
                Name = "Ha'il",
                LocalName = "Ha'il"
            },
            new()
            { 
                Code = "9",
                Type = SubdivisionTypes.Province,
                Name = "Jazan",
                LocalName = "Jazan"
            },
            new()
            { 
                Code = "2",
                Type = SubdivisionTypes.Province,
                Name = "Makkah al Mukarramah",
                LocalName = "Makkah al Mukarramah"
            },
            new()
            { 
                Code = "10",
                Type = SubdivisionTypes.Province,
                Name = "Najran",
                LocalName = "Najran"
            },
            new()
            { 
                Code = "7",
                Type = SubdivisionTypes.Province,
                Name = "Tabuk",
                LocalName = "Tabuk"
            }

        ]);
    }
}
