using AngryMonkey.Cloud.Geography;
namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    private static void FillInSubdivisionsST()
    {
        AddSubdivisions("ST",
        [
            new()
            { 
                Code = "P",
                Type = SubdivisionTypes.Province,
                Name = "Príncipe",
                LocalName = "Príncipe"
            },
            new()
            { 
                Code = "S",
                Type = SubdivisionTypes.Province,
                Name = "São Tomé",
                LocalName = "São Tomé"
            }

        ]);
    }
}
