using AngryMonkey.Cloud.Geography;
namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    private static void FillInSubdivisionsBO()
    {
        AddSubdivisions("BO",
        [
            new()
            { 
                Code = "H",
                Type = SubdivisionTypes.Department,
                Name = "Chuquisaca",
                LocalName = "Chuquisaca"
            },
            new()
            { 
                Code = "C",
                Type = SubdivisionTypes.Department,
                Name = "Cochabamba",
                LocalName = "Cochabamba"
            },
            new()
            { 
                Code = "B",
                Type = SubdivisionTypes.Department,
                Name = "El Beni",
                LocalName = "El Beni"
            },
            new()
            { 
                Code = "L",
                Type = SubdivisionTypes.Department,
                Name = "La Paz",
                LocalName = "La Paz"
            },
            new()
            { 
                Code = "O",
                Type = SubdivisionTypes.Department,
                Name = "Oruro",
                LocalName = "Oruro"
            },
            new()
            { 
                Code = "N",
                Type = SubdivisionTypes.Department,
                Name = "Pando",
                LocalName = "Pando"
            },
            new()
            { 
                Code = "P",
                Type = SubdivisionTypes.Department,
                Name = "Potosí",
                LocalName = "Potosí"
            },
            new()
            { 
                Code = "S",
                Type = SubdivisionTypes.Department,
                Name = "Santa Cruz",
                LocalName = "Santa Cruz"
            },
            new()
            { 
                Code = "T",
                Type = SubdivisionTypes.Department,
                Name = "Tarija",
                LocalName = "Tarija"
            }

        ]);
    }
}
