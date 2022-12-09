using AngryMonkey.Cloud.Geography;
namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    private static void FillInSubdivisionsML()
    {
        AddSubdivisions("ML", new List<Subdivision>()
        {
            new()
            { 
                Code = "BKO",
                Type = "District",
                Name = "Bamako",
                LocalName = "Bamako"
            },
            new()
            { 
                Code = "7",
                Type = "Region",
                Name = "Gao",
                LocalName = "Gao"
            },
            new()
            { 
                Code = "1",
                Type = "Region",
                Name = "Kayes",
                LocalName = "Kayes"
            },
            new()
            { 
                Code = "8",
                Type = "Region",
                Name = "Kidal",
                LocalName = "Kidal"
            },
            new()
            { 
                Code = "2",
                Type = "Region",
                Name = "Koulikoro",
                LocalName = "Koulikoro"
            },
            new()
            { 
                Code = "5",
                Type = "Region",
                Name = "Mopti",
                LocalName = "Mopti"
            },
            new()
            { 
                Code = "4",
                Type = "Region",
                Name = "Ségou",
                LocalName = "Ségou"
            },
            new()
            { 
                Code = "3",
                Type = "Region",
                Name = "Sikasso",
                LocalName = "Sikasso"
            },
            new()
            { 
                Code = "6",
                Type = "Region",
                Name = "Tombouctou",
                LocalName = "Tombouctou"
            }

        });
    }
}
