using AngryMonkey.Cloud.Geography;
namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    private static void FillInSubdivisionsUZ()
    {
        AddSubdivisions("UZ",
        [
            new()
            { 
                Code = "AN",
                Type = SubdivisionTypes.Region,
                Name = "Andijon",
                LocalName = "Andijon"
            },
            new()
            { 
                Code = "BU",
                Type = SubdivisionTypes.Region,
                Name = "Bukhoro",
                LocalName = "Bukhoro"
            },
            new()
            { 
                Code = "FA",
                Type = SubdivisionTypes.Region,
                Name = "Fargona",
                LocalName = "Fargona"
            },
            new()
            { 
                Code = "JI",
                Type = SubdivisionTypes.Region,
                Name = "Jizzax",
                LocalName = "Jizzax"
            },
            new()
            { 
                Code = "KH",
                Type = SubdivisionTypes.Region,
                Name = "Khorazm",
                LocalName = "Khorazm"
            },
            new()
            { 
                Code = "NG",
                Type = SubdivisionTypes.Region,
                Name = "Namangan",
                LocalName = "Namangan"
            },
            new()
            { 
                Code = "NW",
                Type = SubdivisionTypes.Region,
                Name = "Nawoiy",
                LocalName = "Nawoiy"
            },
            new()
            { 
                Code = "QA",
                Type = SubdivisionTypes.Region,
                Name = "Qashqadaryo",
                LocalName = "Qashqadaryo"
            },
            new()
            { 
                Code = "QR",
                Type = SubdivisionTypes.Republic,
                Name = "Qoraqalpogiston Respublikasi",
                LocalName = "Qoraqalpogiston Respublikasi"
            },
            new()
            { 
                Code = "SA",
                Type = SubdivisionTypes.Region,
                Name = "Samarqand",
                LocalName = "Samarqand"
            },
            new()
            { 
                Code = "SI",
                Type = SubdivisionTypes.Region,
                Name = "Sirdaryo",
                LocalName = "Sirdaryo"
            },
            new()
            { 
                Code = "SU",
                Type = SubdivisionTypes.Region,
                Name = "Surkhondaryo",
                LocalName = "Surkhondaryo"
            },
            new()
            { 
                Code = "TO",
                Type = SubdivisionTypes.Region,
                Name = "Toshkent",
                LocalName = "Toshkent"
            },
            new()
            { 
                Code = "TK",
                Type = SubdivisionTypes.City,
                Name = "Toshkent",
                LocalName = "Toshkent"
            },
            new()
            { 
                Code = "XO",
                Type = SubdivisionTypes.Region,
                Name = "Xorazm",
                LocalName = "Xorazm"
            }

        ]);
    }
}
