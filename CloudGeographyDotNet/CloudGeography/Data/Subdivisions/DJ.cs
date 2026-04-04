using AngryMonkey.Cloud.Geography;
namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    private static void FillInSubdivisionsDJ()
    {
        AddSubdivisions("DJ",
        [
            new()
            { 
                Code = "AS",
                Type = SubdivisionTypes.Region,
                Name = "Ali Sabieh",
                LocalName = "Ali Sabieh"
            },
            new()
            { 
                Code = "AR",
                Type = SubdivisionTypes.Region,
                Name = "Arta",
                LocalName = "Arta"
            },
            new()
            { 
                Code = "DI",
                Type = SubdivisionTypes.Region,
                Name = "Dikhil",
                LocalName = "Dikhil"
            },
            new()
            { 
                Code = "DJ",
                Type = SubdivisionTypes.City,
                Name = "Djibouti",
                LocalName = "Djibouti"
            },
            new()
            { 
                Code = "OB",
                Type = SubdivisionTypes.Region,
                Name = "Obock",
                LocalName = "Obock"
            },
            new()
            { 
                Code = "TA",
                Type = SubdivisionTypes.Region,
                Name = "Tadjourah",
                LocalName = "Tadjourah"
            }

        ]);
    }
}
