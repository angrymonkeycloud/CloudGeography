using AngryMonkey.Cloud.Geography;
namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    private static void FillInSubdivisionsPY()
    {
        AddSubdivisions("PY",
        [
            new()
            { 
                Code = "16",
                Type = SubdivisionTypes.Department,
                Name = "Alto Paraguay",
                LocalName = "Alto Paraguay"
            },
            new()
            { 
                Code = "10",
                Type = SubdivisionTypes.Department,
                Name = "Alto Paraná",
                LocalName = "Alto Paraná"
            },
            new()
            { 
                Code = "13",
                Type = SubdivisionTypes.Department,
                Name = "Amambay",
                LocalName = "Amambay"
            },
            new()
            { 
                Code = "ASU",
                Type = SubdivisionTypes.Capital,
                Name = "Asunción",
                LocalName = "Asunción"
            },
            new()
            { 
                Code = "19",
                Type = SubdivisionTypes.Department,
                Name = "Boquerón",
                LocalName = "Boquerón"
            },
            new()
            { 
                Code = "5",
                Type = SubdivisionTypes.Department,
                Name = "Caaguazú",
                LocalName = "Caaguazú"
            },
            new()
            { 
                Code = "6",
                Type = SubdivisionTypes.Department,
                Name = "Caazapá",
                LocalName = "Caazapá"
            },
            new()
            { 
                Code = "14",
                Type = SubdivisionTypes.Department,
                Name = "Canindeyú",
                LocalName = "Canindeyú"
            },
            new()
            { 
                Code = "11",
                Type = SubdivisionTypes.Department,
                Name = "Central",
                LocalName = "Central"
            },
            new()
            { 
                Code = "1",
                Type = SubdivisionTypes.Department,
                Name = "Concepción",
                LocalName = "Concepción"
            },
            new()
            { 
                Code = "3",
                Type = SubdivisionTypes.Department,
                Name = "Cordillera",
                LocalName = "Cordillera"
            },
            new()
            { 
                Code = "4",
                Type = SubdivisionTypes.Department,
                Name = "Guairá",
                LocalName = "Guairá"
            },
            new()
            { 
                Code = "7",
                Type = SubdivisionTypes.Department,
                Name = "Itapúa",
                LocalName = "Itapúa"
            },
            new()
            { 
                Code = "8",
                Type = SubdivisionTypes.Department,
                Name = "Misiones",
                LocalName = "Misiones"
            },
            new()
            { 
                Code = "12",
                Type = SubdivisionTypes.Department,
                Name = "Ñeembucú",
                LocalName = "Ñeembucú"
            },
            new()
            { 
                Code = "9",
                Type = SubdivisionTypes.Department,
                Name = "Paraguarí",
                LocalName = "Paraguarí"
            },
            new()
            { 
                Code = "15",
                Type = SubdivisionTypes.Department,
                Name = "Presidente Hayes",
                LocalName = "Presidente Hayes"
            },
            new()
            { 
                Code = "2",
                Type = SubdivisionTypes.Department,
                Name = "San Pedro",
                LocalName = "San Pedro"
            }

        ]);
    }
}
