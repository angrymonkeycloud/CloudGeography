using AngryMonkey.Cloud.Geography;
namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    private static void FillInSubdivisionsSV()
    {
        AddSubdivisions("SV",
        [
            new()
            { 
                Code = "AH",
                Type = SubdivisionTypes.Department,
                Name = "Ahuachapán",
                LocalName = "Ahuachapán"
            },
            new()
            { 
                Code = "CA",
                Type = SubdivisionTypes.Department,
                Name = "Cabañas",
                LocalName = "Cabañas"
            },
            new()
            { 
                Code = "CH",
                Type = SubdivisionTypes.Department,
                Name = "Chalatenango",
                LocalName = "Chalatenango"
            },
            new()
            { 
                Code = "CU",
                Type = SubdivisionTypes.Department,
                Name = "Cuscatlán",
                LocalName = "Cuscatlán"
            },
            new()
            { 
                Code = "LI",
                Type = SubdivisionTypes.Department,
                Name = "La Libertad",
                LocalName = "La Libertad"
            },
            new()
            { 
                Code = "PA",
                Type = SubdivisionTypes.Department,
                Name = "La Paz",
                LocalName = "La Paz"
            },
            new()
            { 
                Code = "UN",
                Type = SubdivisionTypes.Department,
                Name = "La Unión",
                LocalName = "La Unión"
            },
            new()
            { 
                Code = "MO",
                Type = SubdivisionTypes.Department,
                Name = "Morazán",
                LocalName = "Morazán"
            },
            new()
            { 
                Code = "SM",
                Type = SubdivisionTypes.Department,
                Name = "San Miguel",
                LocalName = "San Miguel"
            },
            new()
            { 
                Code = "SS",
                Type = SubdivisionTypes.Department,
                Name = "San Salvador",
                LocalName = "San Salvador"
            },
            new()
            { 
                Code = "SV",
                Type = SubdivisionTypes.Department,
                Name = "San Vicente",
                LocalName = "San Vicente"
            },
            new()
            { 
                Code = "SA",
                Type = SubdivisionTypes.Department,
                Name = "Santa Ana",
                LocalName = "Santa Ana"
            },
            new()
            { 
                Code = "SO",
                Type = SubdivisionTypes.Department,
                Name = "Sonsonate",
                LocalName = "Sonsonate"
            },
            new()
            { 
                Code = "US",
                Type = SubdivisionTypes.Department,
                Name = "Usulután",
                LocalName = "Usulután"
            }

        ]);
    }
}
