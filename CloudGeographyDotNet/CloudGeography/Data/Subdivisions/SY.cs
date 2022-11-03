using AngryMonkey.Cloud.Geography;
namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    private static void FillInSubdivisionsSY()
    {
        AddSubdivisions("SY", new List<Subdivision>()
        {
            new()
            { 
                Code = "HA",
                Type = "Governorate",
                Name = "AI Hasakah",
                LocalName = "الحسكة"
            },
            new()
            { 
                Code = "HL",
                Type = "Governorate",
                Name = "Aleppo",
                LocalName = "حلب"
            },
            new()
            { 
                Code = "SU",
                Type = "Governorate",
                Name = "As-Suwayda",
                LocalName = "السويداء"
            },
            new()
            { 
                Code = "DI",
                Type = "Governorate",
                Name = "Damascus",
                LocalName = "دمشق‎"
            },
            new()
            { 
                Code = "DR",
                Type = "Governorate",
                Name = "Daraa",
                LocalName = "درعا"
            },
            new()
            { 
                Code = "DY",
                Type = "Governorate",
                Name = "Deir ez-Zor",
                LocalName = "دير الزور"
            },
            new()
            { 
                Code = "HM",
                Type = "Governorate",
                Name = "Hama",
                LocalName = "حماة"
            },
            new()
            { 
                Code = "HI",
                Type = "Governorate",
                Name = "Homs",
                LocalName = "حمص"
            },
            new()
            { 
                Code = "ID",
                Type = "Governorate",
                Name = "Idlib",
                LocalName = "ادلب"
            },
            new()
            { 
                Code = "LA",
                Type = "Governorate",
                Name = "Latakia",
                LocalName = "اللاذقية"
            },
            new()
            { 
                Code = "QU",
                Type = "Governorate",
                Name = "Quneitra",
                LocalName = "القنيطرة"
            },
            new()
            { 
                Code = "RA",
                Type = "Governorate",
                Name = "Raqqa",
                LocalName = "الرقة"
            },
            new()
            { 
                Code = "RD",
                Type = "Governorate",
                Name = "Rif Dimashq",
                LocalName = "ريف دمشق"
            },
            new()
            { 
                Code = "TA",
                Type = "Governorate",
                Name = "Tartus",
                LocalName = "طرطوس"
            }

        });
    }
}
