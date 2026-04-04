using AngryMonkey.Cloud.Geography;
namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    private static void FillInSubdivisionsTG()
    {
        AddSubdivisions("TG",
        [
            new()
            { 
                Code = "C",
                Type = SubdivisionTypes.Region,
                Name = "Centrale",
                LocalName = "Centrale"
            },
            new()
            { 
                Code = "K",
                Type = SubdivisionTypes.Region,
                Name = "Kara",
                LocalName = "Kara"
            },
            new()
            { 
                Code = "M",
                Type = SubdivisionTypes.Region,
                Name = "Maritime",
                LocalName = "Maritime"
            },
            new()
            { 
                Code = "P",
                Type = SubdivisionTypes.Region,
                Name = "Plateaux",
                LocalName = "Plateaux"
            },
            new()
            { 
                Code = "S",
                Type = SubdivisionTypes.Region,
                Name = "Savannes",
                LocalName = "Savannes"
            }

        ]);
    }
}
