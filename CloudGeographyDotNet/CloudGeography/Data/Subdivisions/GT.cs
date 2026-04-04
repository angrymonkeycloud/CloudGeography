using AngryMonkey.Cloud.Geography;
namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    private static void FillInSubdivisionsGT()
    {
        AddSubdivisions("GT",
        [
            new()
            { 
                Code = "AV",
                Type = SubdivisionTypes.Department,
                Name = "Alta Verapaz",
                LocalName = "Alta Verapaz"
            },
            new()
            { 
                Code = "BV",
                Type = SubdivisionTypes.Department,
                Name = "Baja Verapaz",
                LocalName = "Baja Verapaz"
            },
            new()
            { 
                Code = "CM",
                Type = SubdivisionTypes.Department,
                Name = "Chimaltenango",
                LocalName = "Chimaltenango"
            },
            new()
            { 
                Code = "CQ",
                Type = SubdivisionTypes.Department,
                Name = "Chiquimula",
                LocalName = "Chiquimula"
            },
            new()
            { 
                Code = "PR",
                Type = SubdivisionTypes.Department,
                Name = "El Progreso",
                LocalName = "El Progreso"
            },
            new()
            { 
                Code = "ES",
                Type = SubdivisionTypes.Department,
                Name = "Escuintla",
                LocalName = "Escuintla"
            },
            new()
            { 
                Code = "GU",
                Type = SubdivisionTypes.Department,
                Name = "Guatemala",
                LocalName = "Guatemala"
            },
            new()
            { 
                Code = "HU",
                Type = SubdivisionTypes.Department,
                Name = "Huehuetenango",
                LocalName = "Huehuetenango"
            },
            new()
            { 
                Code = "IZ",
                Type = SubdivisionTypes.Department,
                Name = "Izabal",
                LocalName = "Izabal"
            },
            new()
            { 
                Code = "JA",
                Type = SubdivisionTypes.Department,
                Name = "Jalapa",
                LocalName = "Jalapa"
            },
            new()
            { 
                Code = "JU",
                Type = SubdivisionTypes.Department,
                Name = "Jutiapa",
                LocalName = "Jutiapa"
            },
            new()
            { 
                Code = "PE",
                Type = SubdivisionTypes.Department,
                Name = "Petén",
                LocalName = "Petén"
            },
            new()
            { 
                Code = "QZ",
                Type = SubdivisionTypes.Department,
                Name = "Quetzaltenango",
                LocalName = "Quetzaltenango"
            },
            new()
            { 
                Code = "QC",
                Type = SubdivisionTypes.Department,
                Name = "Quiché",
                LocalName = "Quiché"
            },
            new()
            { 
                Code = "RE",
                Type = SubdivisionTypes.Department,
                Name = "Retalhuleu",
                LocalName = "Retalhuleu"
            },
            new()
            { 
                Code = "SA",
                Type = SubdivisionTypes.Department,
                Name = "Sacatepéquez",
                LocalName = "Sacatepéquez"
            },
            new()
            { 
                Code = "SM",
                Type = SubdivisionTypes.Department,
                Name = "San Marcos",
                LocalName = "San Marcos"
            },
            new()
            { 
                Code = "SR",
                Type = SubdivisionTypes.Department,
                Name = "Santa Rosa",
                LocalName = "Santa Rosa"
            },
            new()
            { 
                Code = "SO",
                Type = SubdivisionTypes.Department,
                Name = "Sololá",
                LocalName = "Sololá"
            },
            new()
            { 
                Code = "SU",
                Type = SubdivisionTypes.Department,
                Name = "Suchitepéquez",
                LocalName = "Suchitepéquez"
            },
            new()
            { 
                Code = "TO",
                Type = SubdivisionTypes.Department,
                Name = "Totonicapán",
                LocalName = "Totonicapán"
            },
            new()
            { 
                Code = "ZA",
                Type = SubdivisionTypes.Department,
                Name = "Zacapa",
                LocalName = "Zacapa"
            }

        ]);
    }
}
