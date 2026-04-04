using AngryMonkey.Cloud.Geography;
namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    private static void FillInSubdivisionsGQ()
    {
        AddSubdivisions("GQ",
        [
            new()
            { 
                Code = "AN",
                Type = SubdivisionTypes.Province,
                Name = "Annobón",
                LocalName = "Annobón"
            },
            new()
            { 
                Code = "BN",
                Type = SubdivisionTypes.Province,
                Name = "Bioko Norte",
                LocalName = "Bioko Norte"
            },
            new()
            { 
                Code = "BS",
                Type = SubdivisionTypes.Province,
                Name = "Bioko Sur",
                LocalName = "Bioko Sur"
            },
            new()
            { 
                Code = "CS",
                Type = SubdivisionTypes.Province,
                Name = "Centro Sur",
                LocalName = "Centro Sur"
            },
            new()
            { 
                Code = "KN",
                Type = SubdivisionTypes.Province,
                Name = "Kié-Ntem",
                LocalName = "Kié-Ntem"
            },
            new()
            { 
                Code = "LI",
                Type = SubdivisionTypes.Province,
                Name = "Litoral",
                LocalName = "Litoral"
            },
            new()
            { 
                Code = "WN",
                Type = SubdivisionTypes.Province,
                Name = "Wele-Nzas",
                LocalName = "Wele-Nzas"
            }

        ]);
    }
}
