using AngryMonkey.Cloud.Geography;
namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    private static void FillInSubdivisionsDJ()
    {
        AddSubdivisions("DJ", new List<Subdivision>()
        {
            new()
            { 
                Code = "AS",
                Type = "Region",
                Name = "Ali Sabieh",
                LocalName = "Ali Sabieh"
            },
            new()
            { 
                Code = "AR",
                Type = "Region",
                Name = "Arta",
                LocalName = "Arta"
            },
            new()
            { 
                Code = "DI",
                Type = "Region",
                Name = "Dikhil",
                LocalName = "Dikhil"
            },
            new()
            { 
                Code = "DJ",
                Type = "City",
                Name = "Djibouti",
                LocalName = "Djibouti"
            },
            new()
            { 
                Code = "OB",
                Type = "Region",
                Name = "Obock",
                LocalName = "Obock"
            },
            new()
            { 
                Code = "TA",
                Type = "Region",
                Name = "Tadjourah",
                LocalName = "Tadjourah"
            }

        });
    }
}
