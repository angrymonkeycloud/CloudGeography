using AngryMonkey.Cloud.Geography;
namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    private static void FillInSubdivisionsUY()
    {
        AddSubdivisions("UY", new List<Subdivision>()
        {
            new()
            { 
                Code = "AR",
                Type = "Department",
                Name = "Artigas",
                LocalName = "Artigas"
            },
            new()
            { 
                Code = "CA",
                Type = "Department",
                Name = "Canelones",
                LocalName = "Canelones"
            },
            new()
            { 
                Code = "CL",
                Type = "Department",
                Name = "Cerro Largo",
                LocalName = "Cerro Largo"
            },
            new()
            { 
                Code = "CO",
                Type = "Department",
                Name = "Colonia",
                LocalName = "Colonia"
            },
            new()
            { 
                Code = "DU",
                Type = "Department",
                Name = "Durazno",
                LocalName = "Durazno"
            },
            new()
            { 
                Code = "FS",
                Type = "Department",
                Name = "Flores",
                LocalName = "Flores"
            },
            new()
            { 
                Code = "FD",
                Type = "Department",
                Name = "Florida",
                LocalName = "Florida"
            },
            new()
            { 
                Code = "LA",
                Type = "Department",
                Name = "Lavalleja",
                LocalName = "Lavalleja"
            },
            new()
            { 
                Code = "MA",
                Type = "Department",
                Name = "Maldonado",
                LocalName = "Maldonado"
            },
            new()
            { 
                Code = "MO",
                Type = "Department",
                Name = "Montevideo",
                LocalName = "Montevideo"
            },
            new()
            { 
                Code = "PA",
                Type = "Department",
                Name = "Paysandú",
                LocalName = "Paysandú"
            },
            new()
            { 
                Code = "RN",
                Type = "Department",
                Name = "Río Negro",
                LocalName = "Río Negro"
            },
            new()
            { 
                Code = "RV",
                Type = "Department",
                Name = "Rivera",
                LocalName = "Rivera"
            },
            new()
            { 
                Code = "RO",
                Type = "Department",
                Name = "Rocha",
                LocalName = "Rocha"
            },
            new()
            { 
                Code = "SA",
                Type = "Department",
                Name = "Salto",
                LocalName = "Salto"
            },
            new()
            { 
                Code = "SJ",
                Type = "Department",
                Name = "San José",
                LocalName = "San José"
            },
            new()
            { 
                Code = "SO",
                Type = "Department",
                Name = "Soriano",
                LocalName = "Soriano"
            },
            new()
            { 
                Code = "TA",
                Type = "Department",
                Name = "Tacuarembó",
                LocalName = "Tacuarembó"
            },
            new()
            { 
                Code = "TT",
                Type = "Department",
                Name = "Treinta y Tres",
                LocalName = "Treinta y Tres"
            }

        });
    }
}
