using AngryMonkey.Cloud.Geography;
namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    private static void FillInSubdivisionsSL()
    {
        AddSubdivisions("SL",
        [
            new()
            { 
                Code = "E",
                Type = SubdivisionTypes.Province,
                Name = "Eastern",
                LocalName = "Eastern"
            },
            new()
            { 
                Code = "N",
                Type = SubdivisionTypes.Province,
                Name = "Northern",
                LocalName = "Northern"
            },
            new()
            { 
                Code = "S",
                Type = SubdivisionTypes.Province,
                Name = "Southern",
                LocalName = "Southern"
            },
            new()
            { 
                Code = "W",
                Type = SubdivisionTypes.Area,
                Name = "Western Area",
                LocalName = "Western Area"
            }

        ]);
    }
}
