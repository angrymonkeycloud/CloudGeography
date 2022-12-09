using AngryMonkey.Cloud.Geography;
namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    private static void FillInSubdivisionsSV()
    {
        AddSubdivisions("SV", new List<Subdivision>()
        {
            new()
            { 
                Code = "AH",
                Type = "Department",
                Name = "Ahuachapán",
                LocalName = "Ahuachapán"
            },
            new()
            { 
                Code = "CA",
                Type = "Department",
                Name = "Cabañas",
                LocalName = "Cabañas"
            },
            new()
            { 
                Code = "CH",
                Type = "Department",
                Name = "Chalatenango",
                LocalName = "Chalatenango"
            },
            new()
            { 
                Code = "CU",
                Type = "Department",
                Name = "Cuscatlán",
                LocalName = "Cuscatlán"
            },
            new()
            { 
                Code = "LI",
                Type = "Department",
                Name = "La Libertad",
                LocalName = "La Libertad"
            },
            new()
            { 
                Code = "PA",
                Type = "Department",
                Name = "La Paz",
                LocalName = "La Paz"
            },
            new()
            { 
                Code = "UN",
                Type = "Department",
                Name = "La Unión",
                LocalName = "La Unión"
            },
            new()
            { 
                Code = "MO",
                Type = "Department",
                Name = "Morazán",
                LocalName = "Morazán"
            },
            new()
            { 
                Code = "SM",
                Type = "Department",
                Name = "San Miguel",
                LocalName = "San Miguel"
            },
            new()
            { 
                Code = "SS",
                Type = "Department",
                Name = "San Salvador",
                LocalName = "San Salvador"
            },
            new()
            { 
                Code = "SV",
                Type = "Department",
                Name = "San Vicente",
                LocalName = "San Vicente"
            },
            new()
            { 
                Code = "SA",
                Type = "Department",
                Name = "Santa Ana",
                LocalName = "Santa Ana"
            },
            new()
            { 
                Code = "SO",
                Type = "Department",
                Name = "Sonsonate",
                LocalName = "Sonsonate"
            },
            new()
            { 
                Code = "US",
                Type = "Department",
                Name = "Usulután",
                LocalName = "Usulután"
            }

        });
    }
}
