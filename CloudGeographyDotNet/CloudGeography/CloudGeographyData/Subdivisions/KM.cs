using AngryMonkey.Cloud.Geography;
namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    private static void FillInSubdivisionsKM()
    {
        AddSubdivisions("KM", new List<Subdivision>()
        {
            new()
            { 
                Code = "A",
                Type = "Island",
                Name = "Anjouan",
                LocalName = "Anjouan"
            },
            new()
            { 
                Code = "G",
                Type = "Island",
                Name = "Grande Comore",
                LocalName = "Grande Comore"
            },
            new()
            { 
                Code = "M",
                Type = "Island",
                Name = "Mohéli",
                LocalName = "Mohéli"
            }

        });
    }
}
