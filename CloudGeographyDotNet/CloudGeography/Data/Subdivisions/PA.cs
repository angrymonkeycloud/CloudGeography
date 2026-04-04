using AngryMonkey.Cloud.Geography;
namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    private static void FillInSubdivisionsPA()
    {
        AddSubdivisions("PA",
        [
            new()
            { 
                Code = "1",
                Type = SubdivisionTypes.Province,
                Name = "Bocas del Toro",
                LocalName = "Bocas del Toro"
            },
            new()
            { 
                Code = "4",
                Type = SubdivisionTypes.Province,
                Name = "Chiriquí",
                LocalName = "Chiriquí"
            },
            new()
            { 
                Code = "2",
                Type = SubdivisionTypes.Province,
                Name = "Coclé",
                LocalName = "Coclé"
            },
            new()
            { 
                Code = "3",
                Type = SubdivisionTypes.Province,
                Name = "Colón",
                LocalName = "Colón"
            },
            new()
            { 
                Code = "5",
                Type = SubdivisionTypes.Province,
                Name = "Darién",
                LocalName = "Darién"
            },
            new()
            { 
                Code = "EM",
                Type = SubdivisionTypes.Region,
                Name = "Emberá",
                LocalName = "Emberá"
            },
            new()
            { 
                Code = "6",
                Type = SubdivisionTypes.Province,
                Name = "Herrera",
                LocalName = "Herrera"
            },
            new()
            { 
                Code = "KY",
                Type = SubdivisionTypes.Region,
                Name = "Kuna Yala",
                LocalName = "Kuna Yala"
            },
            new()
            { 
                Code = "7",
                Type = SubdivisionTypes.Province,
                Name = "Los Santos",
                LocalName = "Los Santos"
            },
            new()
            { 
                Code = "NB",
                Type = SubdivisionTypes.Region,
                Name = "Ngöbe-Buglé",
                LocalName = "Ngöbe-Buglé"
            },
            new()
            { 
                Code = "8",
                Type = SubdivisionTypes.Province,
                Name = "Panamá",
                LocalName = "Panamá"
            },
            new()
            { 
                Code = "10",
                Type = SubdivisionTypes.Province,
                Name = "Panamá Oeste",
                LocalName = "Panamá Oeste"
            },
            new()
            { 
                Code = "9",
                Type = SubdivisionTypes.Province,
                Name = "Veraguas",
                LocalName = "Veraguas"
            }

        ]);
    }
}
