using AngryMonkey.Cloud.Geography;
namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    private static void FillInSubdivisionsNE()
    {
        AddSubdivisions("NE", new List<Subdivision>()
        {
            new()
            { 
                Code = "1",
                Type = "Region",
                Name = "Agadez",
                LocalName = "Agadez"
            },
            new()
            { 
                Code = "2",
                Type = "Region",
                Name = "Diffa",
                LocalName = "Diffa"
            },
            new()
            { 
                Code = "3",
                Type = "Region",
                Name = "Dosso",
                LocalName = "Dosso"
            },
            new()
            { 
                Code = "4",
                Type = "Region",
                Name = "Maradi",
                LocalName = "Maradi"
            },
            new()
            { 
                Code = "8",
                Type = "District",
                Name = "Niamey",
                LocalName = "Niamey"
            },
            new()
            { 
                Code = "5",
                Type = "Region",
                Name = "Tahoua",
                LocalName = "Tahoua"
            },
            new()
            { 
                Code = "6",
                Type = "Region",
                Name = "Tillabéri",
                LocalName = "Tillabéri"
            },
            new()
            { 
                Code = "7",
                Type = "Region",
                Name = "Zinder",
                LocalName = "Zinder"
            }

        });
    }
}
