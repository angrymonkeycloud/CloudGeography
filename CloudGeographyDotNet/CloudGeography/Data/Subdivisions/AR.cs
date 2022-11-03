using AngryMonkey.Cloud.Geography;
namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    private static void FillInSubdivisionsAR()
    {
        AddSubdivisions("AR", new List<Subdivision>()
        {
            new()
            { 
                Code = "B",
                Type = "Province",
                Name = "Buenos Aires",
                LocalName = "Buenos Aires"
            },
            new()
            { 
                Code = "K",
                Type = "Province",
                Name = "Catamarca",
                LocalName = "Catamarca"
            },
            new()
            { 
                Code = "H",
                Type = "Province",
                Name = "Chaco",
                LocalName = "Chaco"
            },
            new()
            { 
                Code = "U",
                Type = "Province",
                Name = "Chubut",
                LocalName = "Chubut"
            },
            new()
            { 
                Code = "C",
                Type = "City",
                Name = "Ciudad Autónoma de Buenos Aires",
                LocalName = "Ciudad Autónoma de Buenos Aires"
            },
            new()
            { 
                Code = "X",
                Type = "Province",
                Name = "Córdoba",
                LocalName = "Córdoba"
            },
            new()
            { 
                Code = "W",
                Type = "Province",
                Name = "Corrientes",
                LocalName = "Corrientes"
            },
            new()
            { 
                Code = "E",
                Type = "Province",
                Name = "Entre Ríos",
                LocalName = "Entre Ríos"
            },
            new()
            { 
                Code = "P",
                Type = "Province",
                Name = "Formosa",
                LocalName = "Formosa"
            },
            new()
            { 
                Code = "Y",
                Type = "Province",
                Name = "Jujuy",
                LocalName = "Jujuy"
            },
            new()
            { 
                Code = "L",
                Type = "Province",
                Name = "La Pampa",
                LocalName = "La Pampa"
            },
            new()
            { 
                Code = "F",
                Type = "Province",
                Name = "La Rioja",
                LocalName = "La Rioja"
            },
            new()
            { 
                Code = "M",
                Type = "Province",
                Name = "Mendoza",
                LocalName = "Mendoza"
            },
            new()
            { 
                Code = "N",
                Type = "Province",
                Name = "Misiones",
                LocalName = "Misiones"
            },
            new()
            { 
                Code = "Q",
                Type = "Province",
                Name = "Neuquén",
                LocalName = "Neuquén"
            },
            new()
            { 
                Code = "R",
                Type = "Province",
                Name = "Río Negro",
                LocalName = "Río Negro"
            },
            new()
            { 
                Code = "A",
                Type = "Province",
                Name = "Salta",
                LocalName = "Salta"
            },
            new()
            { 
                Code = "J",
                Type = "Province",
                Name = "San Juan",
                LocalName = "San Juan"
            },
            new()
            { 
                Code = "D",
                Type = "Province",
                Name = "San Luis",
                LocalName = "San Luis"
            },
            new()
            { 
                Code = "Z",
                Type = "Province",
                Name = "Santa Cruz",
                LocalName = "Santa Cruz"
            },
            new()
            { 
                Code = "S",
                Type = "Province",
                Name = "Santa Fe",
                LocalName = "Santa Fe"
            },
            new()
            { 
                Code = "G",
                Type = "Province",
                Name = "Santiago del Estero",
                LocalName = "Santiago del Estero"
            },
            new()
            { 
                Code = "V",
                Type = "Province",
                Name = "Tierra del Fuego",
                LocalName = "Tierra del Fuego"
            },
            new()
            { 
                Code = "T",
                Type = "Province",
                Name = "Tucumán",
                LocalName = "Tucumán"
            }

        });
    }
}
