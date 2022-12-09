using AngryMonkey.Cloud.Geography;
namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    private static void FillInSubdivisionsTM()
    {
        AddSubdivisions("TM", new List<Subdivision>()
        {
            new()
            { 
                Code = "A",
                Type = "Region",
                Name = "Ahal",
                LocalName = "Ahal"
            },
            new()
            { 
                Code = "S",
                Type = "City",
                Name = "Asgabat",
                LocalName = "Asgabat"
            },
            new()
            { 
                Code = "B",
                Type = "Region",
                Name = "Balkan",
                LocalName = "Balkan"
            },
            new()
            { 
                Code = "D",
                Type = "Region",
                Name = "Dasoguz",
                LocalName = "Dasoguz"
            },
            new()
            { 
                Code = "L",
                Type = "Region",
                Name = "Lebap",
                LocalName = "Lebap"
            },
            new()
            { 
                Code = "M",
                Type = "Region",
                Name = "Mary",
                LocalName = "Mary"
            }

        });
    }
}
