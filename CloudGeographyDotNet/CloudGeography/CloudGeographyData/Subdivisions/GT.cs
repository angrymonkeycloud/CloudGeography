using AngryMonkey.Cloud.Geography;
namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    private static void FillInSubdivisionsGT()
    {
        AddSubdivisions("GT", new List<Subdivision>()
        {
            new()
            { 
                Code = "AV",
                Type = "Department",
                Name = "Alta Verapaz",
                LocalName = "Alta Verapaz"
            },
            new()
            { 
                Code = "BV",
                Type = "Department",
                Name = "Baja Verapaz",
                LocalName = "Baja Verapaz"
            },
            new()
            { 
                Code = "CM",
                Type = "Department",
                Name = "Chimaltenango",
                LocalName = "Chimaltenango"
            },
            new()
            { 
                Code = "CQ",
                Type = "Department",
                Name = "Chiquimula",
                LocalName = "Chiquimula"
            },
            new()
            { 
                Code = "PR",
                Type = "Department",
                Name = "El Progreso",
                LocalName = "El Progreso"
            },
            new()
            { 
                Code = "ES",
                Type = "Department",
                Name = "Escuintla",
                LocalName = "Escuintla"
            },
            new()
            { 
                Code = "GU",
                Type = "Department",
                Name = "Guatemala",
                LocalName = "Guatemala"
            },
            new()
            { 
                Code = "HU",
                Type = "Department",
                Name = "Huehuetenango",
                LocalName = "Huehuetenango"
            },
            new()
            { 
                Code = "IZ",
                Type = "Department",
                Name = "Izabal",
                LocalName = "Izabal"
            },
            new()
            { 
                Code = "JA",
                Type = "Department",
                Name = "Jalapa",
                LocalName = "Jalapa"
            },
            new()
            { 
                Code = "JU",
                Type = "Department",
                Name = "Jutiapa",
                LocalName = "Jutiapa"
            },
            new()
            { 
                Code = "PE",
                Type = "Department",
                Name = "Petén",
                LocalName = "Petén"
            },
            new()
            { 
                Code = "QZ",
                Type = "Department",
                Name = "Quetzaltenango",
                LocalName = "Quetzaltenango"
            },
            new()
            { 
                Code = "QC",
                Type = "Department",
                Name = "Quiché",
                LocalName = "Quiché"
            },
            new()
            { 
                Code = "RE",
                Type = "Department",
                Name = "Retalhuleu",
                LocalName = "Retalhuleu"
            },
            new()
            { 
                Code = "SA",
                Type = "Department",
                Name = "Sacatepéquez",
                LocalName = "Sacatepéquez"
            },
            new()
            { 
                Code = "SM",
                Type = "Department",
                Name = "San Marcos",
                LocalName = "San Marcos"
            },
            new()
            { 
                Code = "SR",
                Type = "Department",
                Name = "Santa Rosa",
                LocalName = "Santa Rosa"
            },
            new()
            { 
                Code = "SO",
                Type = "Department",
                Name = "Sololá",
                LocalName = "Sololá"
            },
            new()
            { 
                Code = "SU",
                Type = "Department",
                Name = "Suchitepéquez",
                LocalName = "Suchitepéquez"
            },
            new()
            { 
                Code = "TO",
                Type = "Department",
                Name = "Totonicapán",
                LocalName = "Totonicapán"
            },
            new()
            { 
                Code = "ZA",
                Type = "Department",
                Name = "Zacapa",
                LocalName = "Zacapa"
            }

        });
    }
}
