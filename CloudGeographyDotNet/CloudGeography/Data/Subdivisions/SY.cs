using AngryMonkey.Cloud.Geography;
namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    private static void FillInSubdivisionsSY()
    {
        AddSubdivisions("SY",
        [
            new()
            { 
                Code = "HA",
                Type = SubdivisionTypes.Governorate,
                Name = "AI Hasakah",
                LocalName = "الحسكة"
            },
            new()
            { 
                Code = "HL",
                Type = SubdivisionTypes.Governorate,
                Name = "Aleppo",
                LocalName = "حلب"
            },
            new()
            { 
                Code = "SU",
                Type = SubdivisionTypes.Governorate,
                Name = "As-Suwayda",
                LocalName = "السويداء"
            },
            new()
            { 
                Code = "DI",
                Type = SubdivisionTypes.Governorate,
                Name = "Damascus",
                LocalName = "دمشق‎"
            },
            new()
            { 
                Code = "DR",
                Type = SubdivisionTypes.Governorate,
                Name = "Daraa",
                LocalName = "درعا"
            },
            new()
            { 
                Code = "DY",
                Type = SubdivisionTypes.Governorate,
                Name = "Deir ez-Zor",
                LocalName = "دير الزور"
            },
            new()
            { 
                Code = "HM",
                Type = SubdivisionTypes.Governorate,
                Name = "Hama",
                LocalName = "حماة"
            },
            new()
            { 
                Code = "HI",
                Type = SubdivisionTypes.Governorate,
                Name = "Homs",
                LocalName = "حمص"
            },
            new()
            { 
                Code = "ID",
                Type = SubdivisionTypes.Governorate,
                Name = "Idlib",
                LocalName = "ادلب"
            },
            new()
            { 
                Code = "LA",
                Type = SubdivisionTypes.Governorate,
                Name = "Latakia",
                LocalName = "اللاذقية"
            },
            new()
            { 
                Code = "QU",
                Type = SubdivisionTypes.Governorate,
                Name = "Quneitra",
                LocalName = "القنيطرة"
            },
            new()
            { 
                Code = "RA",
                Type = SubdivisionTypes.Governorate,
                Name = "Raqqa",
                LocalName = "الرقة"
            },
            new()
            { 
                Code = "RD",
                Type = SubdivisionTypes.Governorate,
                Name = "Rif Dimashq",
                LocalName = "ريف دمشق"
            },
            new()
            { 
                Code = "TA",
                Type = SubdivisionTypes.Governorate,
                Name = "Tartus",
                LocalName = "طرطوس"
            }

        ]);
    }
}
