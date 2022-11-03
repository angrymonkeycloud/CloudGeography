using AngryMonkey.Cloud.Geography;
namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    private static void FillInSubdivisionsPY()
    {
        AddSubdivisions("PY", new List<Subdivision>()
        {
            new()
            { 
                Code = "16",
                Type = "Department",
                Name = "Alto Paraguay",
                LocalName = "Alto Paraguay"
            },
            new()
            { 
                Code = "10",
                Type = "Department",
                Name = "Alto Paraná",
                LocalName = "Alto Paraná"
            },
            new()
            { 
                Code = "13",
                Type = "Department",
                Name = "Amambay",
                LocalName = "Amambay"
            },
            new()
            { 
                Code = "ASU",
                Type = "Capital",
                Name = "Asunción",
                LocalName = "Asunción"
            },
            new()
            { 
                Code = "19",
                Type = "Department",
                Name = "Boquerón",
                LocalName = "Boquerón"
            },
            new()
            { 
                Code = "5",
                Type = "Department",
                Name = "Caaguazú",
                LocalName = "Caaguazú"
            },
            new()
            { 
                Code = "6",
                Type = "Department",
                Name = "Caazapá",
                LocalName = "Caazapá"
            },
            new()
            { 
                Code = "14",
                Type = "Department",
                Name = "Canindeyú",
                LocalName = "Canindeyú"
            },
            new()
            { 
                Code = "11",
                Type = "Department",
                Name = "Central",
                LocalName = "Central"
            },
            new()
            { 
                Code = "1",
                Type = "Department",
                Name = "Concepción",
                LocalName = "Concepción"
            },
            new()
            { 
                Code = "3",
                Type = "Department",
                Name = "Cordillera",
                LocalName = "Cordillera"
            },
            new()
            { 
                Code = "4",
                Type = "Department",
                Name = "Guairá",
                LocalName = "Guairá"
            },
            new()
            { 
                Code = "7",
                Type = "Department",
                Name = "Itapúa",
                LocalName = "Itapúa"
            },
            new()
            { 
                Code = "8",
                Type = "Department",
                Name = "Misiones",
                LocalName = "Misiones"
            },
            new()
            { 
                Code = "12",
                Type = "Department",
                Name = "Ñeembucú",
                LocalName = "Ñeembucú"
            },
            new()
            { 
                Code = "9",
                Type = "Department",
                Name = "Paraguarí",
                LocalName = "Paraguarí"
            },
            new()
            { 
                Code = "15",
                Type = "Department",
                Name = "Presidente Hayes",
                LocalName = "Presidente Hayes"
            },
            new()
            { 
                Code = "2",
                Type = "Department",
                Name = "San Pedro",
                LocalName = "San Pedro"
            }

        });
    }
}
