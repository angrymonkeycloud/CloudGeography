using AngryMonkey.Cloud.Geography;
namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    private static void FillInSubdivisionsLB()
    {
        AddSubdivisions("LB",
        [
            new()
            { 
                Code = "AK",
                Type = SubdivisionTypes.Governorate,
                Name = "Akkar",
                LocalName = "عكار",
                Children =
                [
                    new()
                    {
                        Code = "AK",
                        Type = SubdivisionTypes.District,
                        Name = "Akkar",
                        LocalName = "عكار"
                    }
                ]
            },
            new()
            { 
                Code = "BH",
                Type = SubdivisionTypes.Governorate,
                Name = "Baalbek-Hermel",
                LocalName = "بعلبك - الهرمل",
                Children =
                [
                    new()
                    {
                        Code = "BK",
                        Type = SubdivisionTypes.District,
                        Name = "Baalbek",
                        LocalName = "بعلبك"
                    },
                    new()
                    {
                        Code = "HE",
                        Type = SubdivisionTypes.District,
                        Name = "Hermel",
                        LocalName = "الهرمل"
                    }
                ]
            },
            new()
            { 
                Code = "BA",
                Type = SubdivisionTypes.Governorate,
                Name = "Beirut",
                LocalName = "بيروت",
                Children =
                [
                    new()
                    {
                        Code = "BA",
                        Type = SubdivisionTypes.District,
                        Name = "Beirut",
                        LocalName = "بيروت"
                    }
                ]
            },
            new()
            { 
                Code = "BI",
                Type = SubdivisionTypes.Governorate,
                Name = "Beqaa",
                LocalName = "البقاع",
                Children =
                [
                    new()
                    {
                        Code = "RA",
                        Type = SubdivisionTypes.District,
                        Name = "Rashaya",
                        LocalName = "راشيا"
                    },
                    new()
                    {
                        Code = "BG",
                        Type = SubdivisionTypes.District,
                        Name = "West Beqaa",
                        LocalName = "البقاع الغربي"
                    },
                    new()
                    {
                        Code = "ZA",
                        Type = SubdivisionTypes.District,
                        Name = "Zahle",
                        LocalName = "زحلة"
                    }
                ]
            },
            new()
            { 
                Code = "JL",
                Type = SubdivisionTypes.Governorate,
                Name = "Mount Lebanon",
                LocalName = "جبل لبنان",
                Children =
                [
                    new()
                    {
                        Code = "AL",
                        Type = SubdivisionTypes.District,
                        Name = "Aley",
                        LocalName = "عاليه"
                    },
                    new()
                    {
                        Code = "BD",
                        Type = SubdivisionTypes.District,
                        Name = "Baabda",
                        LocalName = "بعبدا"
                    },
                    new()
                    {
                        Code = "CH",
                        Type = SubdivisionTypes.District,
                        Name = "Chouf",
                        LocalName = "الشوف"
                    },
                    new()
                    {
                        Code = "MT",
                        Type = SubdivisionTypes.District,
                        Name = "Matn",
                        LocalName = "المتن"
                    }
                ]
            },
            new()
            {
                Code = "KJ",
                Type = SubdivisionTypes.Governorate,
                Name = "Keserwan-Jbeil",
                LocalName = "كسروان - جبيل",
                Children =
                [
                    new()
                    {
                        Code = "KE",
                        Type = SubdivisionTypes.District,
                        Name = "Keserwan",
                        LocalName = "كسروان"
                    },
                    new()
                    {
                        Code = "JB",
                        Type = SubdivisionTypes.District,
                        Name = "Byblos",
                        LocalName = "جبيل"
                    }
                ]
            },
            new()
            { 
                Code = "NA",
                Type = SubdivisionTypes.Governorate,
                Name = "Nabatieh",
                LocalName = "النبطية",
                Children =
                [
                    new()
                    {
                        Code = "BJ",
                        Type = SubdivisionTypes.District,
                        Name = "Bint Jbeil",
                        LocalName = "بنت جبيل"
                    },
                    new()
                    {
                        Code = "HA",
                        Type = SubdivisionTypes.District,
                        Name = "Hasbaya",
                        LocalName = "حاصبيا"
                    },
                    new()
                    {
                        Code = "MJ",
                        Type = SubdivisionTypes.District,
                        Name = "Marjeyoun",
                        LocalName = "مرجعيون"
                    },
                    new()
                    {
                        Code = "NB",
                        Type = SubdivisionTypes.District,
                        Name = "Nabatieh",
                        LocalName = "النبطية"
                    }
                ]
            },
            new()
            { 
                Code = "AS",
                Type = SubdivisionTypes.Governorate,
                Name = "North",
                LocalName = "الشمال",
                Children =
                [
                    new()
                    {
                        Code = "BT",
                        Type = SubdivisionTypes.District,
                        Name = "Batroun",
                        LocalName = "البترون"
                    },
                    new()
                    {
                        Code = "BS",
                        Type = SubdivisionTypes.District,
                        Name = "Bcharre",
                        LocalName = "بشري"
                    },
                    new()
                    {
                        Code = "KO",
                        Type = SubdivisionTypes.District,
                        Name = "Koura",
                        LocalName = "الكورة"
                    },
                    new()
                    {
                        Code = "MN",
                        Type = SubdivisionTypes.District,
                        Name = "Miniyeh-Danniyeh",
                        LocalName = "المنية - الضنية"
                    },
                    new()
                    {
                        Code = "TR",
                        Type = SubdivisionTypes.District,
                        Name = "Tripoli",
                        LocalName = "طرابلس"
                    },
                    new()
                    {
                        Code = "ZG",
                        Type = SubdivisionTypes.District,
                        Name = "Zgharta",
                        LocalName = "زغرتا"
                    }
                ]
            },
            new()
            { 
                Code = "JA",
                Type = SubdivisionTypes.Governorate,
                Name = "South",
                LocalName = "الجنوب",
                Children =
                [
                    new()
                    {
                        Code = "JZ",
                        Type = SubdivisionTypes.District,
                        Name = "Jezzine",
                        LocalName = "جزين"
                    },
                    new()
                    {
                        Code = "SD",
                        Type = SubdivisionTypes.District,
                        Name = "Sidon",
                        LocalName = "صيدا"
                    },
                    new()
                    {
                        Code = "TY",
                        Type = SubdivisionTypes.District,
                        Name = "Tyre",
                        LocalName = "صور"
                    }
                ]
            }
        ]);
    }
}
