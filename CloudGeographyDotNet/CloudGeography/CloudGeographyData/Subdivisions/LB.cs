using AngryMonkey.Cloud.Geography;
namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    private static void FillInSubdivisionsLB()
    {
        AddSubdivisions("LB", new List<Subdivision>()
        {
            new()
            { 
                Code = "AK",
                Type = "Governorate",
                Name = "Akkar",
                LocalName = "عكار"
            },
            new()
            { 
                Code = "BH",
                Type = "Governorate",
                Name = "Baalbek-Hermel",
                LocalName = "بعلبك - الهرمل"
            },
            new()
            { 
                Code = "BA",
                Type = "Governorate",
                Name = "Beirut",
                LocalName = "بيروت"
            },
            new()
            { 
                Code = "BI",
                Type = "Governorate",
                Name = "Beqaa",
                LocalName = "البقاع"
            },
            new()
            { 
                Code = "JL",
                Type = "Governorate",
                Name = "Mount Lebanon",
                LocalName = "جبل لبنان"
            },
            new()
            { 
                Code = "NA",
                Type = "Governorate",
                Name = "Nabatieh",
                LocalName = "النبطية"
            },
            new()
            { 
                Code = "AS",
                Type = "Governorate",
                Name = "North",
                LocalName = "الشمال"
            },
            new()
            { 
                Code = "JA",
                Type = "Governorate",
                Name = "South",
                LocalName = "الجنوب"
            }

        });
    }
}
