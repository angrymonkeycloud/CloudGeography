using AngryMonkey.Cloud.Geography;
namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    private static void FillInSubdivisionsGQ()
    {
        AddSubdivisions("GQ", new List<Subdivision>()
        {
            new()
            { 
                Code = "AN",
                Type = "Province",
                Name = "Annobón",
                LocalName = "Annobón"
            },
            new()
            { 
                Code = "BN",
                Type = "Province",
                Name = "Bioko Norte",
                LocalName = "Bioko Norte"
            },
            new()
            { 
                Code = "BS",
                Type = "Province",
                Name = "Bioko Sur",
                LocalName = "Bioko Sur"
            },
            new()
            { 
                Code = "CS",
                Type = "Province",
                Name = "Centro Sur",
                LocalName = "Centro Sur"
            },
            new()
            { 
                Code = "KN",
                Type = "Province",
                Name = "Kié-Ntem",
                LocalName = "Kié-Ntem"
            },
            new()
            { 
                Code = "LI",
                Type = "Province",
                Name = "Litoral",
                LocalName = "Litoral"
            },
            new()
            { 
                Code = "WN",
                Type = "Province",
                Name = "Wele-Nzas",
                LocalName = "Wele-Nzas"
            }

        });
    }
}
