using AngryMonkey.Cloud.Geography;
namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    private static void FillInSubdivisionsML()
    {
        AddSubdivisions("ML",
        [
            new()
            { 
                Code = "BKO",
                Type = SubdivisionTypes.District,
                Name = "Bamako",
                LocalName = "Bamako"
            },
            new()
            { 
                Code = "7",
                Type = SubdivisionTypes.Region,
                Name = "Gao",
                LocalName = "Gao"
            },
            new()
            { 
                Code = "1",
                Type = SubdivisionTypes.Region,
                Name = "Kayes",
                LocalName = "Kayes"
            },
            new()
            { 
                Code = "8",
                Type = SubdivisionTypes.Region,
                Name = "Kidal",
                LocalName = "Kidal"
            },
            new()
            { 
                Code = "2",
                Type = SubdivisionTypes.Region,
                Name = "Koulikoro",
                LocalName = "Koulikoro"
            },
            new()
            { 
                Code = "5",
                Type = SubdivisionTypes.Region,
                Name = "Mopti",
                LocalName = "Mopti"
            },
            new()
            { 
                Code = "4",
                Type = SubdivisionTypes.Region,
                Name = "Ségou",
                LocalName = "Ségou"
            },
            new()
            { 
                Code = "3",
                Type = SubdivisionTypes.Region,
                Name = "Sikasso",
                LocalName = "Sikasso"
            },
            new()
            { 
                Code = "6",
                Type = SubdivisionTypes.Region,
                Name = "Tombouctou",
                LocalName = "Tombouctou"
            }

        ]);
    }
}
