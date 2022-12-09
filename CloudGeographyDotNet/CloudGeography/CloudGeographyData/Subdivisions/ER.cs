using AngryMonkey.Cloud.Geography;
namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    private static void FillInSubdivisionsER()
    {
        AddSubdivisions("ER", new List<Subdivision>()
        {
            new()
            { 
                Code = "AN",
                Type = "Region",
                Name = "Anseba",
                LocalName = "Anseba"
            },
            new()
            { 
                Code = "DU",
                Type = "Region",
                Name = "Debub",
                LocalName = "Debub"
            },
            new()
            { 
                Code = "DK",
                Type = "Region",
                Name = "Debubawi Keyyi? Ba?ri",
                LocalName = "Debubawi Keyyi? Ba?ri"
            },
            new()
            { 
                Code = "GB",
                Type = "Region",
                Name = "Gash-Barka",
                LocalName = "Gash-Barka"
            },
            new()
            { 
                Code = "MA",
                Type = "Region",
                Name = "Maikel",
                LocalName = "Maikel"
            },
            new()
            { 
                Code = "SK",
                Type = "Region",
                Name = "Semienawi Keyyi? Ba?ri",
                LocalName = "Semienawi Keyyi? Ba?ri"
            }

        });
    }
}
