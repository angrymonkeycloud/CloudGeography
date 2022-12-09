using AngryMonkey.Cloud.Geography;
namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    private static void FillInSubdivisionsTG()
    {
        AddSubdivisions("TG", new List<Subdivision>()
        {
            new()
            { 
                Code = "C",
                Type = "Region",
                Name = "Centrale",
                LocalName = "Centrale"
            },
            new()
            { 
                Code = "K",
                Type = "Region",
                Name = "Kara",
                LocalName = "Kara"
            },
            new()
            { 
                Code = "M",
                Type = "Region",
                Name = "Maritime",
                LocalName = "Maritime"
            },
            new()
            { 
                Code = "P",
                Type = "Region",
                Name = "Plateaux",
                LocalName = "Plateaux"
            },
            new()
            { 
                Code = "S",
                Type = "Region",
                Name = "Savannes",
                LocalName = "Savannes"
            }

        });
    }
}
