using AngryMonkey.Cloud.Geography;
namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    private static void FillInSubdivisionsUY()
    {
        AddSubdivisions("UY",
        [
            new()
            { 
                Code = "AR",
                Type = SubdivisionTypes.Department,
                Name = "Artigas",
                LocalName = "Artigas"
            },
            new()
            { 
                Code = "CA",
                Type = SubdivisionTypes.Department,
                Name = "Canelones",
                LocalName = "Canelones"
            },
            new()
            { 
                Code = "CL",
                Type = SubdivisionTypes.Department,
                Name = "Cerro Largo",
                LocalName = "Cerro Largo"
            },
            new()
            { 
                Code = "CO",
                Type = SubdivisionTypes.Department,
                Name = "Colonia",
                LocalName = "Colonia"
            },
            new()
            { 
                Code = "DU",
                Type = SubdivisionTypes.Department,
                Name = "Durazno",
                LocalName = "Durazno"
            },
            new()
            { 
                Code = "FS",
                Type = SubdivisionTypes.Department,
                Name = "Flores",
                LocalName = "Flores"
            },
            new()
            { 
                Code = "FD",
                Type = SubdivisionTypes.Department,
                Name = "Florida",
                LocalName = "Florida"
            },
            new()
            { 
                Code = "LA",
                Type = SubdivisionTypes.Department,
                Name = "Lavalleja",
                LocalName = "Lavalleja"
            },
            new()
            { 
                Code = "MA",
                Type = SubdivisionTypes.Department,
                Name = "Maldonado",
                LocalName = "Maldonado"
            },
            new()
            { 
                Code = "MO",
                Type = SubdivisionTypes.Department,
                Name = "Montevideo",
                LocalName = "Montevideo"
            },
            new()
            { 
                Code = "PA",
                Type = SubdivisionTypes.Department,
                Name = "Paysandú",
                LocalName = "Paysandú"
            },
            new()
            { 
                Code = "RN",
                Type = SubdivisionTypes.Department,
                Name = "Río Negro",
                LocalName = "Río Negro"
            },
            new()
            { 
                Code = "RV",
                Type = SubdivisionTypes.Department,
                Name = "Rivera",
                LocalName = "Rivera"
            },
            new()
            { 
                Code = "RO",
                Type = SubdivisionTypes.Department,
                Name = "Rocha",
                LocalName = "Rocha"
            },
            new()
            { 
                Code = "SA",
                Type = SubdivisionTypes.Department,
                Name = "Salto",
                LocalName = "Salto"
            },
            new()
            { 
                Code = "SJ",
                Type = SubdivisionTypes.Department,
                Name = "San José",
                LocalName = "San José"
            },
            new()
            { 
                Code = "SO",
                Type = SubdivisionTypes.Department,
                Name = "Soriano",
                LocalName = "Soriano"
            },
            new()
            { 
                Code = "TA",
                Type = SubdivisionTypes.Department,
                Name = "Tacuarembó",
                LocalName = "Tacuarembó"
            },
            new()
            { 
                Code = "TT",
                Type = SubdivisionTypes.Department,
                Name = "Treinta y Tres",
                LocalName = "Treinta y Tres"
            }

        ]);
    }
}
