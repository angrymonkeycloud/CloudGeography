using AngryMonkey.Cloud.Geography;
namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    private static void FillInSubdivisionsER()
    {
        AddSubdivisions("ER",
        [
            new()
            { 
                Code = "AN",
                Type = SubdivisionTypes.Region,
                Name = "Anseba",
                LocalName = "Anseba"
            },
            new()
            { 
                Code = "DU",
                Type = SubdivisionTypes.Region,
                Name = "Debub",
                LocalName = "Debub"
            },
            new()
            { 
                Code = "DK",
                Type = SubdivisionTypes.Region,
                Name = "Debubawi Keyyi? Ba?ri",
                LocalName = "Debubawi Keyyi? Ba?ri"
            },
            new()
            { 
                Code = "GB",
                Type = SubdivisionTypes.Region,
                Name = "Gash-Barka",
                LocalName = "Gash-Barka"
            },
            new()
            { 
                Code = "MA",
                Type = SubdivisionTypes.Region,
                Name = "Maikel",
                LocalName = "Maikel"
            },
            new()
            { 
                Code = "SK",
                Type = SubdivisionTypes.Region,
                Name = "Semienawi Keyyi? Ba?ri",
                LocalName = "Semienawi Keyyi? Ba?ri"
            }

        ]);
    }
}
