using AngryMonkey.Cloud.Geography;
namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    private static void FillInSubdivisionsKI()
    {
        AddSubdivisions("KI",
        [
            new()
            { 
                Code = "G",
                Type = SubdivisionTypes.Islands,
                Name = "Gilbert Islands",
                LocalName = "Gilbert Islands"
            },
            new()
            { 
                Code = "L",
                Type = SubdivisionTypes.Islands,
                Name = "Line Islands",
                LocalName = "Line Islands"
            },
            new()
            { 
                Code = "P",
                Type = SubdivisionTypes.Islands,
                Name = "Phoenix Islands",
                LocalName = "Phoenix Islands"
            }

        ]);
    }
}
