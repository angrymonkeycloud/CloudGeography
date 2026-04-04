using AngryMonkey.Cloud.Geography;
namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    private static void FillInSubdivisionsIL()
    {
        AddSubdivisions("IL",
        [
            new()
            { 
                Code = "M",
                Type = SubdivisionTypes.District,
                Name = "Al Awsat",
                LocalName = "Al Awsat"
            },
            new()
            { 
                Code = "D",
                Type = SubdivisionTypes.District,
                Name = "Al Janubi",
                LocalName = "Al Janubi"
            },
            new()
            { 
                Code = "Z",
                Type = SubdivisionTypes.District,
                Name = "Ash Shamali",
                LocalName = "Ash Shamali"
            },
            new()
            { 
                Code = "HA",
                Type = SubdivisionTypes.District,
                Name = "H_efa",
                LocalName = "H_efa"
            },
            new()
            { 
                Code = "TA",
                Type = SubdivisionTypes.District,
                Name = "Tel-Aviv",
                LocalName = "Tel-Aviv"
            },
            new()
            { 
                Code = "JM",
                Type = SubdivisionTypes.District,
                Name = "Yerushalayim",
                LocalName = "Yerushalayim"
            }

        ]);
    }
}
