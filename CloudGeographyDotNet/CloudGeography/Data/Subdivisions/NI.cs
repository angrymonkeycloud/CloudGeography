using AngryMonkey.Cloud.Geography;
namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    private static void FillInSubdivisionsNI()
    {
        AddSubdivisions("NI",
        [
            new()
            { 
                Code = "AN",
                Type = SubdivisionTypes.Region,
                Name = "Atlántico Norte",
                LocalName = "Atlántico Norte"
            },
            new()
            { 
                Code = "AS",
                Type = SubdivisionTypes.Region,
                Name = "Atlántico Sur",
                LocalName = "Atlántico Sur"
            },
            new()
            { 
                Code = "BO",
                Type = SubdivisionTypes.Department,
                Name = "Boaco",
                LocalName = "Boaco"
            },
            new()
            { 
                Code = "CA",
                Type = SubdivisionTypes.Department,
                Name = "Carazo",
                LocalName = "Carazo"
            },
            new()
            { 
                Code = "CI",
                Type = SubdivisionTypes.Department,
                Name = "Chinandega",
                LocalName = "Chinandega"
            },
            new()
            { 
                Code = "CO",
                Type = SubdivisionTypes.Department,
                Name = "Chontales",
                LocalName = "Chontales"
            },
            new()
            { 
                Code = "ES",
                Type = SubdivisionTypes.Department,
                Name = "Estelí",
                LocalName = "Estelí"
            },
            new()
            { 
                Code = "GR",
                Type = SubdivisionTypes.Department,
                Name = "Granada",
                LocalName = "Granada"
            },
            new()
            { 
                Code = "JI",
                Type = SubdivisionTypes.Department,
                Name = "Jinotega",
                LocalName = "Jinotega"
            },
            new()
            { 
                Code = "LE",
                Type = SubdivisionTypes.Department,
                Name = "León",
                LocalName = "León"
            },
            new()
            { 
                Code = "MD",
                Type = SubdivisionTypes.Department,
                Name = "Madriz",
                LocalName = "Madriz"
            },
            new()
            { 
                Code = "MN",
                Type = SubdivisionTypes.Department,
                Name = "Managua",
                LocalName = "Managua"
            },
            new()
            { 
                Code = "MS",
                Type = SubdivisionTypes.Department,
                Name = "Masaya",
                LocalName = "Masaya"
            },
            new()
            { 
                Code = "MT",
                Type = SubdivisionTypes.Department,
                Name = "Matagalpa",
                LocalName = "Matagalpa"
            },
            new()
            { 
                Code = "NS",
                Type = SubdivisionTypes.Department,
                Name = "Nueva Segovia",
                LocalName = "Nueva Segovia"
            },
            new()
            { 
                Code = "SJ",
                Type = SubdivisionTypes.Department,
                Name = "Río San Juan",
                LocalName = "Río San Juan"
            },
            new()
            { 
                Code = "RI",
                Type = SubdivisionTypes.Department,
                Name = "Rivas",
                LocalName = "Rivas"
            }

        ]);
    }
}
