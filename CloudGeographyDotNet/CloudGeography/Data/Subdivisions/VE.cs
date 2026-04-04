using AngryMonkey.Cloud.Geography;
namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    private static void FillInSubdivisionsVE()
    {
        AddSubdivisions("VE",
        [
            new()
            { 
                Code = "Z",
                Type = SubdivisionTypes.State,
                Name = "Amazonas",
                LocalName = "Amazonas"
            },
            new()
            { 
                Code = "B",
                Type = SubdivisionTypes.State,
                Name = "Anzoátegui",
                LocalName = "Anzoátegui"
            },
            new()
            { 
                Code = "C",
                Type = SubdivisionTypes.State,
                Name = "Apure",
                LocalName = "Apure"
            },
            new()
            { 
                Code = "D",
                Type = SubdivisionTypes.State,
                Name = "Aragua",
                LocalName = "Aragua"
            },
            new()
            { 
                Code = "E",
                Type = SubdivisionTypes.State,
                Name = "Barinas",
                LocalName = "Barinas"
            },
            new()
            { 
                Code = "F",
                Type = SubdivisionTypes.State,
                Name = "Bolívar",
                LocalName = "Bolívar"
            },
            new()
            { 
                Code = "A",
                Type = SubdivisionTypes.District,
                Name = "Capital District",
                LocalName = "Distrito Capital"
            },
            new()
            { 
                Code = "G",
                Type = SubdivisionTypes.State,
                Name = "Carabobo",
                LocalName = "Carabobo"
            },
            new()
            { 
                Code = "H",
                Type = SubdivisionTypes.State,
                Name = "Cojedes",
                LocalName = "Cojedes"
            },
            new()
            { 
                Code = "Y",
                Type = SubdivisionTypes.State,
                Name = "Delta Amacuro",
                LocalName = "Delta Amacuro"
            },
            new()
            { 
                Code = "W",
                Type = SubdivisionTypes.Dependencies,
                Name = "Dependencias Federales",
                LocalName = "Dependencias Federales"
            },
            new()
            { 
                Code = "I",
                Type = SubdivisionTypes.State,
                Name = "Falcón",
                LocalName = "Falcón"
            },
            new()
            { 
                Code = "J",
                Type = SubdivisionTypes.State,
                Name = "Guárico",
                LocalName = "Guárico"
            },
            new()
            { 
                Code = "K",
                Type = SubdivisionTypes.State,
                Name = "Lara",
                LocalName = "Lara"
            },
            new()
            { 
                Code = "L",
                Type = SubdivisionTypes.State,
                Name = "Mérida",
                LocalName = "Mérida"
            },
            new()
            { 
                Code = "M",
                Type = SubdivisionTypes.State,
                Name = "Miranda",
                LocalName = "Miranda"
            },
            new()
            { 
                Code = "N",
                Type = SubdivisionTypes.State,
                Name = "Monagas",
                LocalName = "Monagas"
            },
            new()
            { 
                Code = "O",
                Type = SubdivisionTypes.State,
                Name = "Nueva Esparta",
                LocalName = "Nueva Esparta"
            },
            new()
            { 
                Code = "P",
                Type = SubdivisionTypes.State,
                Name = "Portuguesa",
                LocalName = "Portuguesa"
            },
            new()
            { 
                Code = "R",
                Type = SubdivisionTypes.State,
                Name = "Sucre",
                LocalName = "Sucre"
            },
            new()
            { 
                Code = "S",
                Type = SubdivisionTypes.State,
                Name = "Táchira",
                LocalName = "Táchira"
            },
            new()
            { 
                Code = "T",
                Type = SubdivisionTypes.State,
                Name = "Trujillo",
                LocalName = "Trujillo"
            },
            new()
            { 
                Code = "X",
                Type = SubdivisionTypes.State,
                Name = "vargas",
                LocalName = "vargas"
            },
            new()
            { 
                Code = "U",
                Type = SubdivisionTypes.State,
                Name = "Yaracuy",
                LocalName = "Yaracuy"
            },
            new()
            { 
                Code = "V",
                Type = SubdivisionTypes.State,
                Name = "Zulia",
                LocalName = "Zulia"
            }

        ]);
    }
}
