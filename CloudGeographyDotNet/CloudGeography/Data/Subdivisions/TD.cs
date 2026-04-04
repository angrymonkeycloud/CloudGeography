using AngryMonkey.Cloud.Geography;
namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    private static void FillInSubdivisionsTD()
    {
        AddSubdivisions("TD",
        [
            new()
            { 
                Code = "BG",
                Type = SubdivisionTypes.Region,
                Name = "Bahr el Gazel",
                LocalName = "بحر الغزال"
            },
            new()
            { 
                Code = "BA",
                Type = SubdivisionTypes.Region,
                Name = "Batha",
                LocalName = "البطحة"
            },
            new()
            { 
                Code = "BO",
                Type = SubdivisionTypes.Region,
                Name = "Borkou",
                LocalName = "بركو"
            },
            new()
            { 
                Code = "CB",
                Type = SubdivisionTypes.Region,
                Name = "Chari-Baguirmi",
                LocalName = "شاري باقرمي"
            },
            new()
            { 
                Code = "EE",
                Type = SubdivisionTypes.Region,
                Name = "Ennedi-Est",
                LocalName = "نيدي الشرقية"
            },
            new()
            { 
                Code = "EO",
                Type = SubdivisionTypes.Region,
                Name = "Ennedi-Ouest",
                LocalName = "إنيدي الغربية"
            },
            new()
            { 
                Code = "GR",
                Type = SubdivisionTypes.Region,
                Name = "Guéra",
                LocalName = "قيرا"
            },
            new()
            { 
                Code = "HL",
                Type = SubdivisionTypes.Region,
                Name = "Hadjer-Lamis",
                LocalName = "حجر لميس"
            },
            new()
            { 
                Code = "KA",
                Type = SubdivisionTypes.Region,
                Name = "Kanem",
                LocalName = "كانم"
            },
            new()
            { 
                Code = "LC",
                Type = SubdivisionTypes.Region,
                Name = "Lac",
                LocalName = "البحيرة"
            },
            new()
            { 
                Code = "LO",
                Type = SubdivisionTypes.Region,
                Name = "Logone-Occidental",
                LocalName = "Logone-Occidental"
            },
            new()
            { 
                Code = "LR",
                Type = SubdivisionTypes.Region,
                Name = "Logone-Oriental",
                LocalName = "Logone-Oriental"
            },
            new()
            { 
                Code = "MA",
                Type = SubdivisionTypes.Region,
                Name = "Mandoul",
                LocalName = "Mandoul"
            },
            new()
            { 
                Code = "ME",
                Type = SubdivisionTypes.Region,
                Name = "Mayo-Kebbi-Est",
                LocalName = "Mayo-Kebbi-Est"
            },
            new()
            { 
                Code = "MO",
                Type = SubdivisionTypes.Region,
                Name = "Mayo-Kebbi-Ouest",
                LocalName = "Mayo-Kebbi-Ouest"
            },
            new()
            { 
                Code = "MC",
                Type = SubdivisionTypes.Region,
                Name = "Moyen-Chari",
                LocalName = "Moyen-Chari"
            },
            new()
            { 
                Code = "ND",
                Type = SubdivisionTypes.Region,
                Name = "N’Djamena",
                LocalName = "انجمينا‎"
            },
            new()
            { 
                Code = "OD",
                Type = SubdivisionTypes.Region,
                Name = "Ouaddaï",
                LocalName = "وداي"
            },
            new()
            { 
                Code = "SA",
                Type = SubdivisionTypes.Region,
                Name = "Salamat",
                LocalName = "Salamat"
            },
            new()
            { 
                Code = "SI",
                Type = SubdivisionTypes.Region,
                Name = "Sila",
                LocalName = "Sila"
            },
            new()
            { 
                Code = "TA",
                Type = SubdivisionTypes.Region,
                Name = "Tandjilé",
                LocalName = "Tandjilé"
            },
            new()
            { 
                Code = "TI",
                Type = SubdivisionTypes.Region,
                Name = "Tibasti",
                LocalName = "تيبستي"
            },
            new()
            { 
                Code = "WF",
                Type = SubdivisionTypes.Region,
                Name = "Wadi Fira",
                LocalName = "وادي فيرا"
            }

        ]);
    }
}
