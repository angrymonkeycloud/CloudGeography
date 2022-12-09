using AngryMonkey.Cloud.Geography;
namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    private static void FillInSubdivisionsBH()
    {
        AddSubdivisions("BH", new List<Subdivision>()
        {
            new()
            { 
                Code = "13",
                Type = "Governorate",
                Name = "Capital Governorate",
                LocalName = "محافظة العاصمة"
            },
            new()
            { 
                Code = "15",
                Type = "Governorate",
                Name = "Muharraq Governorate",
                LocalName = "محافظة المحرق"
            },
            new()
            { 
                Code = "17",
                Type = "Governorate",
                Name = "Northern Governorate",
                LocalName = "المحافظة الشمالية"
            },
            new()
            { 
                Code = "14",
                Type = "Governorate",
                Name = "Southern Governorate",
                LocalName = "المحافظة الجنوبية"
            }

        });
    }
}
