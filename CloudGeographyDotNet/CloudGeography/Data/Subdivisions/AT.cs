using AngryMonkey.Cloud.Geography;
namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    private static void FillInSubdivisionsAT()
    {
        AddSubdivisions("AT",
        [
            new()
            { 
                Code = "1",
                Type = SubdivisionTypes.State,
                Name = "Burgenland",
                LocalName = "Burgenland"
            },
            new()
            { 
                Code = "2",
                Type = SubdivisionTypes.State,
                Name = "Kärnten",
                LocalName = "Kärnten"
            },
            new()
            { 
                Code = "3",
                Type = SubdivisionTypes.State,
                Name = "Niederösterreich",
                LocalName = "Niederösterreich"
            },
            new()
            { 
                Code = "4",
                Type = SubdivisionTypes.State,
                Name = "Oberösterreich",
                LocalName = "Oberösterreich"
            },
            new()
            { 
                Code = "5",
                Type = SubdivisionTypes.State,
                Name = "Salzburg",
                LocalName = "Salzburg"
            },
            new()
            { 
                Code = "6",
                Type = SubdivisionTypes.State,
                Name = "Steiermark",
                LocalName = "Steiermark"
            },
            new()
            { 
                Code = "7",
                Type = SubdivisionTypes.State,
                Name = "Tirol",
                LocalName = "Tirol"
            },
            new()
            { 
                Code = "8",
                Type = SubdivisionTypes.State,
                Name = "Vorarlberg",
                LocalName = "Vorarlberg"
            },
            new()
            { 
                Code = "9",
                Type = SubdivisionTypes.State,
                Name = "Wien",
                LocalName = "Wien"
            }

        ]);
    }
}
