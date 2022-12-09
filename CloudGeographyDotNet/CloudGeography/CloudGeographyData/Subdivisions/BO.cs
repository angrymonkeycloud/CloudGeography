using AngryMonkey.Cloud.Geography;
namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    private static void FillInSubdivisionsBO()
    {
        AddSubdivisions("BO", new List<Subdivision>()
        {
            new()
            { 
                Code = "H",
                Type = "Department",
                Name = "Chuquisaca",
                LocalName = "Chuquisaca"
            },
            new()
            { 
                Code = "C",
                Type = "Department",
                Name = "Cochabamba",
                LocalName = "Cochabamba"
            },
            new()
            { 
                Code = "B",
                Type = "Department",
                Name = "El Beni",
                LocalName = "El Beni"
            },
            new()
            { 
                Code = "L",
                Type = "Department",
                Name = "La Paz",
                LocalName = "La Paz"
            },
            new()
            { 
                Code = "O",
                Type = "Department",
                Name = "Oruro",
                LocalName = "Oruro"
            },
            new()
            { 
                Code = "N",
                Type = "Department",
                Name = "Pando",
                LocalName = "Pando"
            },
            new()
            { 
                Code = "P",
                Type = "Department",
                Name = "Potosí",
                LocalName = "Potosí"
            },
            new()
            { 
                Code = "S",
                Type = "Department",
                Name = "Santa Cruz",
                LocalName = "Santa Cruz"
            },
            new()
            { 
                Code = "T",
                Type = "Department",
                Name = "Tarija",
                LocalName = "Tarija"
            }

        });
    }
}
