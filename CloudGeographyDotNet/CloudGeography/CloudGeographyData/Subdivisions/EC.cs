using AngryMonkey.Cloud.Geography;
namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    private static void FillInSubdivisionsEC()
    {
        AddSubdivisions("EC", new List<Subdivision>()
        {
            new()
            { 
                Code = "A",
                Type = "Province",
                Name = "Azuay",
                LocalName = "Azuay"
            },
            new()
            { 
                Code = "B",
                Type = "Province",
                Name = "Bolívar",
                LocalName = "Bolívar"
            },
            new()
            { 
                Code = "F",
                Type = "Province",
                Name = "Cañar",
                LocalName = "Cañar"
            },
            new()
            { 
                Code = "C",
                Type = "Province",
                Name = "Carchi",
                LocalName = "Carchi"
            },
            new()
            { 
                Code = "H",
                Type = "Province",
                Name = "Chimborazo",
                LocalName = "Chimborazo"
            },
            new()
            { 
                Code = "X",
                Type = "Province",
                Name = "Cotopaxi",
                LocalName = "Cotopaxi"
            },
            new()
            { 
                Code = "O",
                Type = "Province",
                Name = "El Oro",
                LocalName = "El Oro"
            },
            new()
            { 
                Code = "E",
                Type = "Province",
                Name = "Esmeraldas",
                LocalName = "Esmeraldas"
            },
            new()
            { 
                Code = "W",
                Type = "Province",
                Name = "Galápagos",
                LocalName = "Galápagos"
            },
            new()
            { 
                Code = "G",
                Type = "Province",
                Name = "Guayas",
                LocalName = "Guayas"
            },
            new()
            { 
                Code = "I",
                Type = "Province",
                Name = "Imbabura",
                LocalName = "Imbabura"
            },
            new()
            { 
                Code = "L",
                Type = "Province",
                Name = "Loja",
                LocalName = "Loja"
            },
            new()
            { 
                Code = "R",
                Type = "Province",
                Name = "Los Ríos",
                LocalName = "Los Ríos"
            },
            new()
            { 
                Code = "M",
                Type = "Province",
                Name = "Manabí",
                LocalName = "Manabí"
            },
            new()
            { 
                Code = "S",
                Type = "Province",
                Name = "Morona-Santiago",
                LocalName = "Morona-Santiago"
            },
            new()
            { 
                Code = "N",
                Type = "Province",
                Name = "Napo",
                LocalName = "Napo"
            },
            new()
            { 
                Code = "D",
                Type = "Province",
                Name = "Orellana",
                LocalName = "Orellana"
            },
            new()
            { 
                Code = "Y",
                Type = "Province",
                Name = "Pastaza",
                LocalName = "Pastaza"
            },
            new()
            { 
                Code = "P",
                Type = "Province",
                Name = "Pichincha",
                LocalName = "Pichincha"
            },
            new()
            { 
                Code = "SE",
                Type = "Province",
                Name = "Santa Elena",
                LocalName = "Santa Elena"
            },
            new()
            { 
                Code = "SD",
                Type = "Province",
                Name = "Santo Domingo de los Tsáchilas",
                LocalName = "Santo Domingo de los Tsáchilas"
            },
            new()
            { 
                Code = "U",
                Type = "Province",
                Name = "Sucumbíos",
                LocalName = "Sucumbíos"
            },
            new()
            { 
                Code = "T",
                Type = "Province",
                Name = "Tungurahua",
                LocalName = "Tungurahua"
            },
            new()
            { 
                Code = "Z",
                Type = "Province",
                Name = "Zamora-Chinchipe",
                LocalName = "Zamora-Chinchipe"
            }

        });
    }
}
