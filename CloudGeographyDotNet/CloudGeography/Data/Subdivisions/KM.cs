using AngryMonkey.Cloud.Geography;
namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    private static void FillInSubdivisionsKM()
    {
        AddSubdivisions("KM",
        [
            new()
            { 
                Code = "A",
                Type = SubdivisionTypes.Island,
                Name = "Anjouan",
                LocalName = "Anjouan"
            },
            new()
            { 
                Code = "G",
                Type = SubdivisionTypes.Island,
                Name = "Grande Comore",
                LocalName = "Grande Comore"
            },
            new()
            { 
                Code = "M",
                Type = SubdivisionTypes.Island,
                Name = "Mohéli",
                LocalName = "Mohéli"
            }

        ]);
    }
}
