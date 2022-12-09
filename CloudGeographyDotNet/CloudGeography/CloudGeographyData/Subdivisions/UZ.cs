using AngryMonkey.Cloud.Geography;
namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    private static void FillInSubdivisionsUZ()
    {
        AddSubdivisions("UZ", new List<Subdivision>()
        {
            new()
            { 
                Code = "AN",
                Type = "Region",
                Name = "Andijon",
                LocalName = "Andijon"
            },
            new()
            { 
                Code = "BU",
                Type = "Region",
                Name = "Bukhoro",
                LocalName = "Bukhoro"
            },
            new()
            { 
                Code = "FA",
                Type = "Region",
                Name = "Fargona",
                LocalName = "Fargona"
            },
            new()
            { 
                Code = "JI",
                Type = "Region",
                Name = "Jizzax",
                LocalName = "Jizzax"
            },
            new()
            { 
                Code = "KH",
                Type = "Region",
                Name = "Khorazm",
                LocalName = "Khorazm"
            },
            new()
            { 
                Code = "NG",
                Type = "Region",
                Name = "Namangan",
                LocalName = "Namangan"
            },
            new()
            { 
                Code = "NW",
                Type = "Region",
                Name = "Nawoiy",
                LocalName = "Nawoiy"
            },
            new()
            { 
                Code = "QA",
                Type = "Region",
                Name = "Qashqadaryo",
                LocalName = "Qashqadaryo"
            },
            new()
            { 
                Code = "QR",
                Type = "Republic",
                Name = "Qoraqalpogiston Respublikasi",
                LocalName = "Qoraqalpogiston Respublikasi"
            },
            new()
            { 
                Code = "SA",
                Type = "Region",
                Name = "Samarqand",
                LocalName = "Samarqand"
            },
            new()
            { 
                Code = "SI",
                Type = "Region",
                Name = "Sirdaryo",
                LocalName = "Sirdaryo"
            },
            new()
            { 
                Code = "SU",
                Type = "Region",
                Name = "Surkhondaryo",
                LocalName = "Surkhondaryo"
            },
            new()
            { 
                Code = "TO",
                Type = "Region",
                Name = "Toshkent",
                LocalName = "Toshkent"
            },
            new()
            { 
                Code = "TK",
                Type = "City",
                Name = "Toshkent",
                LocalName = "Toshkent"
            },
            new()
            { 
                Code = "XO",
                Type = "Region",
                Name = "Xorazm",
                LocalName = "Xorazm"
            }

        });
    }
}
