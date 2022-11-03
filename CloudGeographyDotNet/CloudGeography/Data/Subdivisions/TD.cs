using AngryMonkey.Cloud.Geography;
namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    private static void FillInSubdivisionsTD()
    {
        AddSubdivisions("TD", new List<Subdivision>()
        {
            new()
            { 
                Code = "BG",
                Type = "Region",
                Name = "Bahr el Gazel",
                LocalName = "بحر الغزال"
            },
            new()
            { 
                Code = "BA",
                Type = "Region",
                Name = "Batha",
                LocalName = "البطحة"
            },
            new()
            { 
                Code = "BO",
                Type = "Region",
                Name = "Borkou",
                LocalName = "بركو"
            },
            new()
            { 
                Code = "CB",
                Type = "Region",
                Name = "Chari-Baguirmi",
                LocalName = "شاري باقرمي"
            },
            new()
            { 
                Code = "EE",
                Type = "Region",
                Name = "Ennedi-Est",
                LocalName = "نيدي الشرقية"
            },
            new()
            { 
                Code = "EO",
                Type = "Region",
                Name = "Ennedi-Ouest",
                LocalName = "إنيدي الغربية"
            },
            new()
            { 
                Code = "GR",
                Type = "Region",
                Name = "Guéra",
                LocalName = "قيرا"
            },
            new()
            { 
                Code = "HL",
                Type = "Region",
                Name = "Hadjer-Lamis",
                LocalName = "حجر لميس"
            },
            new()
            { 
                Code = "KA",
                Type = "Region",
                Name = "Kanem",
                LocalName = "كانم"
            },
            new()
            { 
                Code = "LC",
                Type = "Region",
                Name = "Lac",
                LocalName = "البحيرة"
            },
            new()
            { 
                Code = "LO",
                Type = "Region",
                Name = "Logone-Occidental",
                LocalName = "Logone-Occidental"
            },
            new()
            { 
                Code = "LR",
                Type = "Region",
                Name = "Logone-Oriental",
                LocalName = "Logone-Oriental"
            },
            new()
            { 
                Code = "MA",
                Type = "Region",
                Name = "Mandoul",
                LocalName = "Mandoul"
            },
            new()
            { 
                Code = "ME",
                Type = "Region",
                Name = "Mayo-Kebbi-Est",
                LocalName = "Mayo-Kebbi-Est"
            },
            new()
            { 
                Code = "MO",
                Type = "Region",
                Name = "Mayo-Kebbi-Ouest",
                LocalName = "Mayo-Kebbi-Ouest"
            },
            new()
            { 
                Code = "MC",
                Type = "Region",
                Name = "Moyen-Chari",
                LocalName = "Moyen-Chari"
            },
            new()
            { 
                Code = "ND",
                Type = "Region",
                Name = "N’Djamena",
                LocalName = "انجمينا‎"
            },
            new()
            { 
                Code = "OD",
                Type = "Region",
                Name = "Ouaddaï",
                LocalName = "وداي"
            },
            new()
            { 
                Code = "SA",
                Type = "Region",
                Name = "Salamat",
                LocalName = "Salamat"
            },
            new()
            { 
                Code = "SI",
                Type = "Region",
                Name = "Sila",
                LocalName = "Sila"
            },
            new()
            { 
                Code = "TA",
                Type = "Region",
                Name = "Tandjilé",
                LocalName = "Tandjilé"
            },
            new()
            { 
                Code = "TI",
                Type = "Region",
                Name = "Tibasti",
                LocalName = "تيبستي"
            },
            new()
            { 
                Code = "WF",
                Type = "Region",
                Name = "Wadi Fira",
                LocalName = "وادي فيرا"
            }

        });
    }
}
