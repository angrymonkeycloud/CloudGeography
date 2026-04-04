using AngryMonkey.Cloud.Geography;
namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    private static void FillInSubdivisionsNE()
    {
        AddSubdivisions("NE",
        [
            new()
            { 
                Code = "1",
                Type = SubdivisionTypes.Region,
                Name = "Agadez",
                LocalName = "Agadez"
            },
            new()
            { 
                Code = "2",
                Type = SubdivisionTypes.Region,
                Name = "Diffa",
                LocalName = "Diffa"
            },
            new()
            { 
                Code = "3",
                Type = SubdivisionTypes.Region,
                Name = "Dosso",
                LocalName = "Dosso"
            },
            new()
            { 
                Code = "4",
                Type = SubdivisionTypes.Region,
                Name = "Maradi",
                LocalName = "Maradi"
            },
            new()
            { 
                Code = "8",
                Type = SubdivisionTypes.District,
                Name = "Niamey",
                LocalName = "Niamey"
            },
            new()
            { 
                Code = "5",
                Type = SubdivisionTypes.Region,
                Name = "Tahoua",
                LocalName = "Tahoua"
            },
            new()
            { 
                Code = "6",
                Type = SubdivisionTypes.Region,
                Name = "Tillabéri",
                LocalName = "Tillabéri"
            },
            new()
            { 
                Code = "7",
                Type = SubdivisionTypes.Region,
                Name = "Zinder",
                LocalName = "Zinder"
            }

        ]);
    }
}
