using AngryMonkey.Cloud.Geography;
namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    private static void FillInSubdivisionsAR()
    {
        AddSubdivisions("AR",
        [
            new()
            { 
                Code = "B",
                Type = SubdivisionTypes.Province,
                Name = "Buenos Aires",
                LocalName = "Buenos Aires"
            },
            new()
            { 
                Code = "K",
                Type = SubdivisionTypes.Province,
                Name = "Catamarca",
                LocalName = "Catamarca"
            },
            new()
            { 
                Code = "H",
                Type = SubdivisionTypes.Province,
                Name = "Chaco",
                LocalName = "Chaco"
            },
            new()
            { 
                Code = "U",
                Type = SubdivisionTypes.Province,
                Name = "Chubut",
                LocalName = "Chubut"
            },
            new()
            { 
                Code = "C",
                Type = SubdivisionTypes.City,
                Name = "Ciudad Autónoma de Buenos Aires",
                LocalName = "Ciudad Autónoma de Buenos Aires"
            },
            new()
            { 
                Code = "X",
                Type = SubdivisionTypes.Province,
                Name = "Córdoba",
                LocalName = "Córdoba"
            },
            new()
            { 
                Code = "W",
                Type = SubdivisionTypes.Province,
                Name = "Corrientes",
                LocalName = "Corrientes"
            },
            new()
            { 
                Code = "E",
                Type = SubdivisionTypes.Province,
                Name = "Entre Ríos",
                LocalName = "Entre Ríos"
            },
            new()
            { 
                Code = "P",
                Type = SubdivisionTypes.Province,
                Name = "Formosa",
                LocalName = "Formosa"
            },
            new()
            { 
                Code = "Y",
                Type = SubdivisionTypes.Province,
                Name = "Jujuy",
                LocalName = "Jujuy"
            },
            new()
            { 
                Code = "L",
                Type = SubdivisionTypes.Province,
                Name = "La Pampa",
                LocalName = "La Pampa"
            },
            new()
            { 
                Code = "F",
                Type = SubdivisionTypes.Province,
                Name = "La Rioja",
                LocalName = "La Rioja"
            },
            new()
            { 
                Code = "M",
                Type = SubdivisionTypes.Province,
                Name = "Mendoza",
                LocalName = "Mendoza"
            },
            new()
            { 
                Code = "N",
                Type = SubdivisionTypes.Province,
                Name = "Misiones",
                LocalName = "Misiones"
            },
            new()
            { 
                Code = "Q",
                Type = SubdivisionTypes.Province,
                Name = "Neuquén",
                LocalName = "Neuquén"
            },
            new()
            { 
                Code = "R",
                Type = SubdivisionTypes.Province,
                Name = "Río Negro",
                LocalName = "Río Negro"
            },
            new()
            { 
                Code = "A",
                Type = SubdivisionTypes.Province,
                Name = "Salta",
                LocalName = "Salta"
            },
            new()
            { 
                Code = "J",
                Type = SubdivisionTypes.Province,
                Name = "San Juan",
                LocalName = "San Juan"
            },
            new()
            { 
                Code = "D",
                Type = SubdivisionTypes.Province,
                Name = "San Luis",
                LocalName = "San Luis"
            },
            new()
            { 
                Code = "Z",
                Type = SubdivisionTypes.Province,
                Name = "Santa Cruz",
                LocalName = "Santa Cruz"
            },
            new()
            { 
                Code = "S",
                Type = SubdivisionTypes.Province,
                Name = "Santa Fe",
                LocalName = "Santa Fe"
            },
            new()
            { 
                Code = "G",
                Type = SubdivisionTypes.Province,
                Name = "Santiago del Estero",
                LocalName = "Santiago del Estero"
            },
            new()
            { 
                Code = "V",
                Type = SubdivisionTypes.Province,
                Name = "Tierra del Fuego",
                LocalName = "Tierra del Fuego"
            },
            new()
            { 
                Code = "T",
                Type = SubdivisionTypes.Province,
                Name = "Tucumán",
                LocalName = "Tucumán"
            }

        ]);
    }
}
