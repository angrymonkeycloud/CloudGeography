using AngryMonkey.Cloud.Geography;
namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    private static void FillInSubdivisionsIL()
    {
        AddSubdivisions("IL", new List<Subdivision>()
        {
            new()
            { 
                Code = "M",
                Type = "District",
                Name = "Al Awsat",
                LocalName = "Al Awsat"
            },
            new()
            { 
                Code = "D",
                Type = "District",
                Name = "Al Janubi",
                LocalName = "Al Janubi"
            },
            new()
            { 
                Code = "Z",
                Type = "District",
                Name = "Ash Shamali",
                LocalName = "Ash Shamali"
            },
            new()
            { 
                Code = "HA",
                Type = "District",
                Name = "H_efa",
                LocalName = "H_efa"
            },
            new()
            { 
                Code = "TA",
                Type = "District",
                Name = "Tel-Aviv",
                LocalName = "Tel-Aviv"
            },
            new()
            { 
                Code = "JM",
                Type = "District",
                Name = "Yerushalayim",
                LocalName = "Yerushalayim"
            }

        });
    }
}
