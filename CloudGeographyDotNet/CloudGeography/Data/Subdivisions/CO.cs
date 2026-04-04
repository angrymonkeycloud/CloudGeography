using AngryMonkey.Cloud.Geography;
namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    private static void FillInSubdivisionsCO()
    {
        AddSubdivisions("CO",
        [
            new()
            { 
                Code = "AMA",
                Type = SubdivisionTypes.Department,
                Name = "Amazonas",
                LocalName = "Amazonas"
            },
            new()
            { 
                Code = "ANT",
                Type = SubdivisionTypes.Department,
                Name = "Antioquia",
                LocalName = "Antioquia"
            },
            new()
            { 
                Code = "ARA",
                Type = SubdivisionTypes.Department,
                Name = "Arauca",
                LocalName = "Arauca"
            },
            new()
            { 
                Code = "ATL",
                Type = SubdivisionTypes.Department,
                Name = "Atlántico",
                LocalName = "Atlántico"
            },
            new()
            { 
                Code = "BOL",
                Type = SubdivisionTypes.Department,
                Name = "Bolívar",
                LocalName = "Bolívar"
            },
            new()
            { 
                Code = "BOY",
                Type = SubdivisionTypes.Department,
                Name = "Boyacá",
                LocalName = "Boyacá"
            },
            new()
            { 
                Code = "CAL",
                Type = SubdivisionTypes.Department,
                Name = "Caldas",
                LocalName = "Caldas"
            },
            new()
            { 
                Code = "CAQ",
                Type = SubdivisionTypes.Department,
                Name = "Caquetá",
                LocalName = "Caquetá"
            },
            new()
            { 
                Code = "CAS",
                Type = SubdivisionTypes.Department,
                Name = "Casanare",
                LocalName = "Casanare"
            },
            new()
            { 
                Code = "CAU",
                Type = SubdivisionTypes.Department,
                Name = "Cauca",
                LocalName = "Cauca"
            },
            new()
            { 
                Code = "CES",
                Type = SubdivisionTypes.Department,
                Name = "Cesar",
                LocalName = "Cesar"
            },
            new()
            { 
                Code = "CHO",
                Type = SubdivisionTypes.Department,
                Name = "Chocó",
                LocalName = "Chocó"
            },
            new()
            { 
                Code = "COR",
                Type = SubdivisionTypes.Department,
                Name = "Córdoba",
                LocalName = "Córdoba"
            },
            new()
            { 
                Code = "CUN",
                Type = SubdivisionTypes.Department,
                Name = "Cundinamarca",
                LocalName = "Cundinamarca"
            },
            new()
            { 
                Code = "DC",
                Type = SubdivisionTypes.District,
                Name = "Distrito Capital de Bogotá",
                LocalName = "Distrito Capital de Bogotá"
            },
            new()
            { 
                Code = "GUA",
                Type = SubdivisionTypes.Department,
                Name = "Guainía",
                LocalName = "Guainía"
            },
            new()
            { 
                Code = "GUV",
                Type = SubdivisionTypes.Department,
                Name = "Guaviare",
                LocalName = "Guaviare"
            },
            new()
            { 
                Code = "HUI",
                Type = SubdivisionTypes.Department,
                Name = "Huila",
                LocalName = "Huila"
            },
            new()
            { 
                Code = "LAG",
                Type = SubdivisionTypes.Department,
                Name = "La Guajira",
                LocalName = "La Guajira"
            },
            new()
            { 
                Code = "MAG",
                Type = SubdivisionTypes.Department,
                Name = "Magdalena",
                LocalName = "Magdalena"
            },
            new()
            { 
                Code = "MET",
                Type = SubdivisionTypes.Department,
                Name = "Meta",
                LocalName = "Meta"
            },
            new()
            { 
                Code = "NAR",
                Type = SubdivisionTypes.Department,
                Name = "Nariño",
                LocalName = "Nariño"
            },
            new()
            { 
                Code = "NSA",
                Type = SubdivisionTypes.Department,
                Name = "Norte de Santander",
                LocalName = "Norte de Santander"
            },
            new()
            { 
                Code = "PUT",
                Type = SubdivisionTypes.Department,
                Name = "Putumayo",
                LocalName = "Putumayo"
            },
            new()
            { 
                Code = "QUI",
                Type = SubdivisionTypes.Department,
                Name = "Quindío",
                LocalName = "Quindío"
            },
            new()
            { 
                Code = "RIS",
                Type = SubdivisionTypes.Department,
                Name = "Risaralda",
                LocalName = "Risaralda"
            },
            new()
            { 
                Code = "SAP",
                Type = SubdivisionTypes.Department,
                Name = "San Andrés",
                LocalName = "San Andrés"
            },
            new()
            { 
                Code = "SAN",
                Type = SubdivisionTypes.Department,
                Name = "Santander",
                LocalName = "Santander"
            },
            new()
            { 
                Code = "SUC",
                Type = SubdivisionTypes.Department,
                Name = "Sucre",
                LocalName = "Sucre"
            },
            new()
            { 
                Code = "TOL",
                Type = SubdivisionTypes.Department,
                Name = "Tolima",
                LocalName = "Tolima"
            },
            new()
            { 
                Code = "VAC",
                Type = SubdivisionTypes.Department,
                Name = "Valle del Cauca",
                LocalName = "Valle del Cauca"
            },
            new()
            { 
                Code = "VAU",
                Type = SubdivisionTypes.Department,
                Name = "Vaupés",
                LocalName = "Vaupés"
            },
            new()
            { 
                Code = "VID",
                Type = SubdivisionTypes.Department,
                Name = "Vichada",
                LocalName = "Vichada"
            }

        ]);
    }
}
