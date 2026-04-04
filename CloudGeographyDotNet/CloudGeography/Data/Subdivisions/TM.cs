using AngryMonkey.Cloud.Geography;
namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    private static void FillInSubdivisionsTM()
    {
        AddSubdivisions("TM",
        [
            new()
            { 
                Code = "A",
                Type = SubdivisionTypes.Region,
                Name = "Ahal",
                LocalName = "Ahal"
            },
            new()
            { 
                Code = "S",
                Type = SubdivisionTypes.City,
                Name = "Asgabat",
                LocalName = "Asgabat"
            },
            new()
            { 
                Code = "B",
                Type = SubdivisionTypes.Region,
                Name = "Balkan",
                LocalName = "Balkan"
            },
            new()
            { 
                Code = "D",
                Type = SubdivisionTypes.Region,
                Name = "Dasoguz",
                LocalName = "Dasoguz"
            },
            new()
            { 
                Code = "L",
                Type = SubdivisionTypes.Region,
                Name = "Lebap",
                LocalName = "Lebap"
            },
            new()
            { 
                Code = "M",
                Type = SubdivisionTypes.Region,
                Name = "Mary",
                LocalName = "Mary"
            }

        ]);
    }
}
