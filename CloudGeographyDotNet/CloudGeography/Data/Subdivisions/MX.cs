using AngryMonkey.Cloud.Geography;
namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    private static void FillInSubdivisionsMX()
    {
        AddSubdivisions("MX",
        [
            new()
            { 
                Code = "AGU",
                Type = SubdivisionTypes.State,
                Name = "Aguascalientes",
                LocalName = "Aguascalientes"
            },
            new()
            { 
                Code = "BCN",
                Type = SubdivisionTypes.State,
                Name = "Baja California",
                LocalName = "Baja California"
            },
            new()
            { 
                Code = "BCS",
                Type = SubdivisionTypes.State,
                Name = "Baja California Sur",
                LocalName = "Baja California Sur"
            },
            new()
            { 
                Code = "CAM",
                Type = SubdivisionTypes.State,
                Name = "Campeche",
                LocalName = "Campeche"
            },
            new()
            { 
                Code = "CHP",
                Type = SubdivisionTypes.State,
                Name = "Chiapas",
                LocalName = "Chiapas"
            },
            new()
            { 
                Code = "CHH",
                Type = SubdivisionTypes.State,
                Name = "Chihuahua",
                LocalName = "Chihuahua"
            },
            new()
            { 
                Code = "CMX",
                Type = SubdivisionTypes.District,
                Name = "Ciudad de Mexico",
                LocalName = "Ciudad de Mexico"
            },
            new()
            { 
                Code = "COA",
                Type = SubdivisionTypes.State,
                Name = "Coahuila de Zaragoza",
                LocalName = "Coahuila de Zaragoza"
            },
            new()
            { 
                Code = "COL",
                Type = SubdivisionTypes.State,
                Name = "Colima",
                LocalName = "Colima"
            },
            new()
            { 
                Code = "DUR",
                Type = SubdivisionTypes.State,
                Name = "Durango",
                LocalName = "Durango"
            },
            new()
            { 
                Code = "GUA",
                Type = SubdivisionTypes.State,
                Name = "Guanajuato",
                LocalName = "Guanajuato"
            },
            new()
            { 
                Code = "GRO",
                Type = SubdivisionTypes.State,
                Name = "Guerrero",
                LocalName = "Guerrero"
            },
            new()
            { 
                Code = "HID",
                Type = SubdivisionTypes.State,
                Name = "Hidalgo",
                LocalName = "Hidalgo"
            },
            new()
            { 
                Code = "JAL",
                Type = SubdivisionTypes.State,
                Name = "Jalisco",
                LocalName = "Jalisco"
            },
            new()
            { 
                Code = "MEX",
                Type = SubdivisionTypes.State,
                Name = "México",
                LocalName = "México"
            },
            new()
            { 
                Code = "MIC",
                Type = SubdivisionTypes.State,
                Name = "Michoacán de Ocampo",
                LocalName = "Michoacán de Ocampo"
            },
            new()
            { 
                Code = "MOR",
                Type = SubdivisionTypes.State,
                Name = "Morelos",
                LocalName = "Morelos"
            },
            new()
            { 
                Code = "NAY",
                Type = SubdivisionTypes.State,
                Name = "Nayarit",
                LocalName = "Nayarit"
            },
            new()
            { 
                Code = "NLE",
                Type = SubdivisionTypes.State,
                Name = "Nuevo León",
                LocalName = "Nuevo León"
            },
            new()
            { 
                Code = "OAX",
                Type = SubdivisionTypes.State,
                Name = "Oaxaca",
                LocalName = "Oaxaca"
            },
            new()
            { 
                Code = "PUE",
                Type = SubdivisionTypes.State,
                Name = "Puebla",
                LocalName = "Puebla"
            },
            new()
            { 
                Code = "QUE",
                Type = SubdivisionTypes.State,
                Name = "Querétaro",
                LocalName = "Querétaro"
            },
            new()
            { 
                Code = "ROO",
                Type = SubdivisionTypes.State,
                Name = "Quintana Roo",
                LocalName = "Quintana Roo"
            },
            new()
            { 
                Code = "SLP",
                Type = SubdivisionTypes.State,
                Name = "San Luis Potosí",
                LocalName = "San Luis Potosí"
            },
            new()
            { 
                Code = "SIN",
                Type = SubdivisionTypes.State,
                Name = "Sinaloa",
                LocalName = "Sinaloa"
            },
            new()
            { 
                Code = "SON",
                Type = SubdivisionTypes.State,
                Name = "Sonora",
                LocalName = "Sonora"
            },
            new()
            { 
                Code = "TAB",
                Type = SubdivisionTypes.State,
                Name = "Tabasco",
                LocalName = "Tabasco"
            },
            new()
            { 
                Code = "TAM",
                Type = SubdivisionTypes.State,
                Name = "Tamaulipas",
                LocalName = "Tamaulipas"
            },
            new()
            { 
                Code = "TLA",
                Type = SubdivisionTypes.State,
                Name = "Tlaxcala",
                LocalName = "Tlaxcala"
            },
            new()
            { 
                Code = "VER",
                Type = SubdivisionTypes.State,
                Name = "Veracruz de Ignacio de la Llave",
                LocalName = "Veracruz de Ignacio de la Llave"
            },
            new()
            { 
                Code = "YUC",
                Type = SubdivisionTypes.State,
                Name = "Yucatán",
                LocalName = "Yucatán"
            },
            new()
            { 
                Code = "ZAC",
                Type = SubdivisionTypes.State,
                Name = "Zacatecas",
                LocalName = "Zacatecas"
            }

        ]);
    }
}
