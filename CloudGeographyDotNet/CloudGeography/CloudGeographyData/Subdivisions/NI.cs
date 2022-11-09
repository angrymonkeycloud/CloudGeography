using AngryMonkey.Cloud.Geography;
namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    private static void FillInSubdivisionsNI()
    {
        AddSubdivisions("NI", new List<Subdivision>()
        {
            new()
            { 
                Code = "AN",
                Type = "Region",
                Name = "Atlántico Norte",
                LocalName = "Atlántico Norte"
            },
            new()
            { 
                Code = "AS",
                Type = "Region",
                Name = "Atlántico Sur",
                LocalName = "Atlántico Sur"
            },
            new()
            { 
                Code = "BO",
                Type = "Department",
                Name = "Boaco",
                LocalName = "Boaco"
            },
            new()
            { 
                Code = "CA",
                Type = "Department",
                Name = "Carazo",
                LocalName = "Carazo"
            },
            new()
            { 
                Code = "CI",
                Type = "Department",
                Name = "Chinandega",
                LocalName = "Chinandega"
            },
            new()
            { 
                Code = "CO",
                Type = "Department",
                Name = "Chontales",
                LocalName = "Chontales"
            },
            new()
            { 
                Code = "ES",
                Type = "Department",
                Name = "Estelí",
                LocalName = "Estelí"
            },
            new()
            { 
                Code = "GR",
                Type = "Department",
                Name = "Granada",
                LocalName = "Granada"
            },
            new()
            { 
                Code = "JI",
                Type = "Department",
                Name = "Jinotega",
                LocalName = "Jinotega"
            },
            new()
            { 
                Code = "LE",
                Type = "Department",
                Name = "León",
                LocalName = "León"
            },
            new()
            { 
                Code = "MD",
                Type = "Department",
                Name = "Madriz",
                LocalName = "Madriz"
            },
            new()
            { 
                Code = "MN",
                Type = "Department",
                Name = "Managua",
                LocalName = "Managua"
            },
            new()
            { 
                Code = "MS",
                Type = "Department",
                Name = "Masaya",
                LocalName = "Masaya"
            },
            new()
            { 
                Code = "MT",
                Type = "Department",
                Name = "Matagalpa",
                LocalName = "Matagalpa"
            },
            new()
            { 
                Code = "NS",
                Type = "Department",
                Name = "Nueva Segovia",
                LocalName = "Nueva Segovia"
            },
            new()
            { 
                Code = "SJ",
                Type = "Department",
                Name = "Río San Juan",
                LocalName = "Río San Juan"
            },
            new()
            { 
                Code = "RI",
                Type = "Department",
                Name = "Rivas",
                LocalName = "Rivas"
            }

        });
    }
}
