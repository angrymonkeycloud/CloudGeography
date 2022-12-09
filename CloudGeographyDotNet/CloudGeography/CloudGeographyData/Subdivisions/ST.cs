using AngryMonkey.Cloud.Geography;
namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    private static void FillInSubdivisionsST()
    {
        AddSubdivisions("ST", new List<Subdivision>()
        {
            new()
            { 
                Code = "P",
                Type = "Province",
                Name = "Príncipe",
                LocalName = "Príncipe"
            },
            new()
            { 
                Code = "S",
                Type = "Province",
                Name = "São Tomé",
                LocalName = "São Tomé"
            }

        });
    }
}
