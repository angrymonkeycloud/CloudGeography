using AngryMonkey.Cloud.Geography;
namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    private static void FillInSubdivisionsRW()
    {
        AddSubdivisions("RW", new List<Subdivision>()
        {
            new()
            { 
                Code = "2",
                Type = "Province",
                Name = "Est",
                LocalName = "Est"
            },
            new()
            { 
                Code = "3",
                Type = "Province",
                Name = "Nord",
                LocalName = "Nord"
            },
            new()
            { 
                Code = "4",
                Type = "Province",
                Name = "Ouest",
                LocalName = "Ouest"
            },
            new()
            { 
                Code = "5",
                Type = "Province",
                Name = "Sud",
                LocalName = "Sud"
            },
            new()
            { 
                Code = "1",
                Type = "City",
                Name = "Ville de Kigali",
                LocalName = "Ville de Kigali"
            }

        });
    }
}
