using AngryMonkey.Cloud.Geography;
namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    private static void FillInSubdivisionsSA()
    {
        AddSubdivisions("SA", new List<Subdivision>()
        {
            new()
            { 
                Code = "11",
                Type = "Province",
                Name = "AI Bahah",
                LocalName = "AI Bahah"
            },
            new()
            { 
                Code = "8",
                Type = "Province",
                Name = "AI Hudud ash Shamaliyah",
                LocalName = "AI Hudud ash Shamaliyah"
            },
            new()
            { 
                Code = "12",
                Type = "Province",
                Name = "AI Jawf",
                LocalName = "AI Jawf"
            },
            new()
            { 
                Code = "5",
                Type = "Province",
                Name = "AI Qasim",
                LocalName = "AI Qasim"
            },
            new()
            { 
                Code = "3",
                Type = "Province",
                Name = "Al Madinah al Munawwarah",
                LocalName = "Al Madinah al Munawwarah"
            },
            new()
            { 
                Code = "1",
                Type = "Province",
                Name = "Ar Riyad",
                LocalName = "Ar Riyad"
            },
            new()
            { 
                Code = "4",
                Type = "Province",
                Name = "Ash Sharqiyah",
                LocalName = "Ash Sharqiyah"
            },
            new()
            { 
                Code = "14",
                Type = "Province",
                Name = "'Asir",
                LocalName = "'Asir"
            },
            new()
            { 
                Code = "6",
                Type = "Province",
                Name = "Ha'il",
                LocalName = "Ha'il"
            },
            new()
            { 
                Code = "9",
                Type = "Province",
                Name = "Jazan",
                LocalName = "Jazan"
            },
            new()
            { 
                Code = "2",
                Type = "Province",
                Name = "Makkah al Mukarramah",
                LocalName = "Makkah al Mukarramah"
            },
            new()
            { 
                Code = "10",
                Type = "Province",
                Name = "Najran",
                LocalName = "Najran"
            },
            new()
            { 
                Code = "7",
                Type = "Province",
                Name = "Tabuk",
                LocalName = "Tabuk"
            }

        });
    }
}
