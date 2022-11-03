using AngryMonkey.Cloud.Geography;
namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    private static void FillInSubdivisionsAT()
    {
        AddSubdivisions("AT", new List<Subdivision>()
        {
            new()
            { 
                Code = "1",
                Type = "State",
                Name = "Burgenland",
                LocalName = "Burgenland"
            },
            new()
            { 
                Code = "2",
                Type = "State",
                Name = "Kärnten",
                LocalName = "Kärnten"
            },
            new()
            { 
                Code = "3",
                Type = "State",
                Name = "Niederösterreich",
                LocalName = "Niederösterreich"
            },
            new()
            { 
                Code = "4",
                Type = "State",
                Name = "Oberösterreich",
                LocalName = "Oberösterreich"
            },
            new()
            { 
                Code = "5",
                Type = "State",
                Name = "Salzburg",
                LocalName = "Salzburg"
            },
            new()
            { 
                Code = "6",
                Type = "State",
                Name = "Steiermark",
                LocalName = "Steiermark"
            },
            new()
            { 
                Code = "7",
                Type = "State",
                Name = "Tirol",
                LocalName = "Tirol"
            },
            new()
            { 
                Code = "8",
                Type = "State",
                Name = "Vorarlberg",
                LocalName = "Vorarlberg"
            },
            new()
            { 
                Code = "9",
                Type = "State",
                Name = "Wien",
                LocalName = "Wien"
            }

        });
    }
}
