using AngryMonkey.Cloud.Geography;
namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    private static void FillInSubdivisionsSL()
    {
        AddSubdivisions("SL", new List<Subdivision>()
        {
            new()
            { 
                Code = "E",
                Type = "Province",
                Name = "Eastern",
                LocalName = "Eastern"
            },
            new()
            { 
                Code = "N",
                Type = "Province",
                Name = "Northern",
                LocalName = "Northern"
            },
            new()
            { 
                Code = "S",
                Type = "Province",
                Name = "Southern",
                LocalName = "Southern"
            },
            new()
            { 
                Code = "W",
                Type = "Area",
                Name = "Western Area",
                LocalName = "Western Area"
            }

        });
    }
}
