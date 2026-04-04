using AngryMonkey.Cloud.Geography;
namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    private static void FillInSubdivisionsEC()
    {
        AddSubdivisions("EC",
        [
            new()
            { 
                Code = "A",
                Type = SubdivisionTypes.Province,
                Name = "Azuay",
                LocalName = "Azuay"
            },
            new()
            { 
                Code = "B",
                Type = SubdivisionTypes.Province,
                Name = "Bolívar",
                LocalName = "Bolívar"
            },
            new()
            { 
                Code = "F",
                Type = SubdivisionTypes.Province,
                Name = "Cañar",
                LocalName = "Cañar"
            },
            new()
            { 
                Code = "C",
                Type = SubdivisionTypes.Province,
                Name = "Carchi",
                LocalName = "Carchi"
            },
            new()
            { 
                Code = "H",
                Type = SubdivisionTypes.Province,
                Name = "Chimborazo",
                LocalName = "Chimborazo"
            },
            new()
            { 
                Code = "X",
                Type = SubdivisionTypes.Province,
                Name = "Cotopaxi",
                LocalName = "Cotopaxi"
            },
            new()
            { 
                Code = "O",
                Type = SubdivisionTypes.Province,
                Name = "El Oro",
                LocalName = "El Oro"
            },
            new()
            { 
                Code = "E",
                Type = SubdivisionTypes.Province,
                Name = "Esmeraldas",
                LocalName = "Esmeraldas"
            },
            new()
            { 
                Code = "W",
                Type = SubdivisionTypes.Province,
                Name = "Galápagos",
                LocalName = "Galápagos"
            },
            new()
            { 
                Code = "G",
                Type = SubdivisionTypes.Province,
                Name = "Guayas",
                LocalName = "Guayas"
            },
            new()
            { 
                Code = "I",
                Type = SubdivisionTypes.Province,
                Name = "Imbabura",
                LocalName = "Imbabura"
            },
            new()
            { 
                Code = "L",
                Type = SubdivisionTypes.Province,
                Name = "Loja",
                LocalName = "Loja"
            },
            new()
            { 
                Code = "R",
                Type = SubdivisionTypes.Province,
                Name = "Los Ríos",
                LocalName = "Los Ríos"
            },
            new()
            { 
                Code = "M",
                Type = SubdivisionTypes.Province,
                Name = "Manabí",
                LocalName = "Manabí"
            },
            new()
            { 
                Code = "S",
                Type = SubdivisionTypes.Province,
                Name = "Morona-Santiago",
                LocalName = "Morona-Santiago"
            },
            new()
            { 
                Code = "N",
                Type = SubdivisionTypes.Province,
                Name = "Napo",
                LocalName = "Napo"
            },
            new()
            { 
                Code = "D",
                Type = SubdivisionTypes.Province,
                Name = "Orellana",
                LocalName = "Orellana"
            },
            new()
            { 
                Code = "Y",
                Type = SubdivisionTypes.Province,
                Name = "Pastaza",
                LocalName = "Pastaza"
            },
            new()
            { 
                Code = "P",
                Type = SubdivisionTypes.Province,
                Name = "Pichincha",
                LocalName = "Pichincha"
            },
            new()
            { 
                Code = "SE",
                Type = SubdivisionTypes.Province,
                Name = "Santa Elena",
                LocalName = "Santa Elena"
            },
            new()
            { 
                Code = "SD",
                Type = SubdivisionTypes.Province,
                Name = "Santo Domingo de los Tsáchilas",
                LocalName = "Santo Domingo de los Tsáchilas"
            },
            new()
            { 
                Code = "U",
                Type = SubdivisionTypes.Province,
                Name = "Sucumbíos",
                LocalName = "Sucumbíos"
            },
            new()
            { 
                Code = "T",
                Type = SubdivisionTypes.Province,
                Name = "Tungurahua",
                LocalName = "Tungurahua"
            },
            new()
            { 
                Code = "Z",
                Type = SubdivisionTypes.Province,
                Name = "Zamora-Chinchipe",
                LocalName = "Zamora-Chinchipe"
            }

        ]);
    }
}
