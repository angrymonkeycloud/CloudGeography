using AngryMonkey.Cloud.Geography;
namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    private static void FillInSubdivisionsPA()
    {
        AddSubdivisions("PA", new List<Subdivision>()
        {
            new()
            { 
                Code = "1",
                Type = "Province",
                Name = "Bocas del Toro",
                LocalName = "Bocas del Toro"
            },
            new()
            { 
                Code = "4",
                Type = "Province",
                Name = "Chiriquí",
                LocalName = "Chiriquí"
            },
            new()
            { 
                Code = "2",
                Type = "Province",
                Name = "Coclé",
                LocalName = "Coclé"
            },
            new()
            { 
                Code = "3",
                Type = "Province",
                Name = "Colón",
                LocalName = "Colón"
            },
            new()
            { 
                Code = "5",
                Type = "Province",
                Name = "Darién",
                LocalName = "Darién"
            },
            new()
            { 
                Code = "EM",
                Type = "Region",
                Name = "Emberá",
                LocalName = "Emberá"
            },
            new()
            { 
                Code = "6",
                Type = "Province",
                Name = "Herrera",
                LocalName = "Herrera"
            },
            new()
            { 
                Code = "KY",
                Type = "Region",
                Name = "Kuna Yala",
                LocalName = "Kuna Yala"
            },
            new()
            { 
                Code = "7",
                Type = "Province",
                Name = "Los Santos",
                LocalName = "Los Santos"
            },
            new()
            { 
                Code = "NB",
                Type = "Region",
                Name = "Ngöbe-Buglé",
                LocalName = "Ngöbe-Buglé"
            },
            new()
            { 
                Code = "8",
                Type = "Province",
                Name = "Panamá",
                LocalName = "Panamá"
            },
            new()
            { 
                Code = "10",
                Type = "Province",
                Name = "Panamá Oeste",
                LocalName = "Panamá Oeste"
            },
            new()
            { 
                Code = "9",
                Type = "Province",
                Name = "Veraguas",
                LocalName = "Veraguas"
            }

        });
    }
}
