using AngryMonkey.Cloud.Geography;
namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    private static void FillInSubdivisionsKI()
    {
        AddSubdivisions("KI", new List<Subdivision>()
        {
            new()
            { 
                Code = "G",
                Type = "Islands",
                Name = "Gilbert Islands",
                LocalName = "Gilbert Islands"
            },
            new()
            { 
                Code = "L",
                Type = "Islands",
                Name = "Line Islands",
                LocalName = "Line Islands"
            },
            new()
            { 
                Code = "P",
                Type = "Islands",
                Name = "Phoenix Islands",
                LocalName = "Phoenix Islands"
            }

        });
    }
}
