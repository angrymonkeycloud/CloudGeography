using AngryMonkey.Cloud.Geography;
namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    private static void FillInSubdivisionsRO()
    {
        AddSubdivisions("RO", new List<Subdivision>()
        {
            new()
            { 
                Code = "AB",
                Type = "Departments",
                Name = "Alba",
                LocalName = "Alba"
            },
            new()
            { 
                Code = "AR",
                Type = "Departments",
                Name = "Arad",
                LocalName = "Arad"
            },
            new()
            { 
                Code = "AG",
                Type = "Departments",
                Name = "Arges",
                LocalName = "Arges"
            },
            new()
            { 
                Code = "BC",
                Type = "Departments",
                Name = "Bacau",
                LocalName = "Bacau"
            },
            new()
            { 
                Code = "BH",
                Type = "Departments",
                Name = "Bihor",
                LocalName = "Bihor"
            },
            new()
            { 
                Code = "BN",
                Type = "Departments",
                Name = "Bistrita-Nasaud",
                LocalName = "Bistrita-Nasaud"
            },
            new()
            { 
                Code = "BT",
                Type = "Departments",
                Name = "Botosani",
                LocalName = "Botosani"
            },
            new()
            { 
                Code = "BR",
                Type = "Departments",
                Name = "Braila",
                LocalName = "Braila"
            },
            new()
            { 
                Code = "BV",
                Type = "Departments",
                Name = "Brasov",
                LocalName = "Brasov"
            },
            new()
            { 
                Code = "B",
                Type = "Municipality",
                Name = "Bucuresti",
                LocalName = "Bucuresti"
            },
            new()
            { 
                Code = "BZ",
                Type = "Departments",
                Name = "Buzau",
                LocalName = "Buzau"
            },
            new()
            { 
                Code = "CL",
                Type = "Departments",
                Name = "Calarasi",
                LocalName = "Calarasi"
            },
            new()
            { 
                Code = "CS",
                Type = "Departments",
                Name = "Caras-Severin",
                LocalName = "Caras-Severin"
            },
            new()
            { 
                Code = "CJ",
                Type = "Departments",
                Name = "Cluj",
                LocalName = "Cluj"
            },
            new()
            { 
                Code = "CT",
                Type = "Departments",
                Name = "Constarta",
                LocalName = "Constarta"
            },
            new()
            { 
                Code = "CV",
                Type = "Departments",
                Name = "Covasna",
                LocalName = "Covasna"
            },
            new()
            { 
                Code = "DB",
                Type = "Departments",
                Name = "Dâmbovita",
                LocalName = "Dâmbovita"
            },
            new()
            { 
                Code = "DJ",
                Type = "Departments",
                Name = "Dolj",
                LocalName = "Dolj"
            },
            new()
            { 
                Code = "GL",
                Type = "Departments",
                Name = "Galati",
                LocalName = "Galati"
            },
            new()
            { 
                Code = "GR",
                Type = "Departments",
                Name = "Giurgiu",
                LocalName = "Giurgiu"
            },
            new()
            { 
                Code = "GJ",
                Type = "Departments",
                Name = "Gorj",
                LocalName = "Gorj"
            },
            new()
            { 
                Code = "HR",
                Type = "Departments",
                Name = "Harghita",
                LocalName = "Harghita"
            },
            new()
            { 
                Code = "HD",
                Type = "Departments",
                Name = "Hunedoara",
                LocalName = "Hunedoara"
            },
            new()
            { 
                Code = "IL",
                Type = "Departments",
                Name = "Ialomita",
                LocalName = "Ialomita"
            },
            new()
            { 
                Code = "IS",
                Type = "Departments",
                Name = "Iasi",
                LocalName = "Iasi"
            },
            new()
            { 
                Code = "IF",
                Type = "Departments",
                Name = "Ilfov",
                LocalName = "Ilfov"
            },
            new()
            { 
                Code = "MM",
                Type = "Departments",
                Name = "Maramures",
                LocalName = "Maramures"
            },
            new()
            { 
                Code = "MH",
                Type = "Departments",
                Name = "Mehedinti",
                LocalName = "Mehedinti"
            },
            new()
            { 
                Code = "MS",
                Type = "Departments",
                Name = "Mures",
                LocalName = "Mures"
            },
            new()
            { 
                Code = "NT",
                Type = "Departments",
                Name = "Neamt",
                LocalName = "Neamt"
            },
            new()
            { 
                Code = "OT",
                Type = "Departments",
                Name = "Olt",
                LocalName = "Olt"
            },
            new()
            { 
                Code = "PH",
                Type = "Departments",
                Name = "Prahova",
                LocalName = "Prahova"
            },
            new()
            { 
                Code = "SJ",
                Type = "Departments",
                Name = "Salaj",
                LocalName = "Salaj"
            },
            new()
            { 
                Code = "SM",
                Type = "Departments",
                Name = "Satu Mare",
                LocalName = "Satu Mare"
            },
            new()
            { 
                Code = "SB",
                Type = "Departments",
                Name = "Sibiu",
                LocalName = "Sibiu"
            },
            new()
            { 
                Code = "SV",
                Type = "Departments",
                Name = "Suceava",
                LocalName = "Suceava"
            },
            new()
            { 
                Code = "TR",
                Type = "Departments",
                Name = "Teleorman",
                LocalName = "Teleorman"
            },
            new()
            { 
                Code = "TM",
                Type = "Departments",
                Name = "Timis",
                LocalName = "Timis"
            },
            new()
            { 
                Code = "TL",
                Type = "Departments",
                Name = "Tulcea",
                LocalName = "Tulcea"
            },
            new()
            { 
                Code = "VL",
                Type = "Departments",
                Name = "Vâlcea",
                LocalName = "Vâlcea"
            },
            new()
            { 
                Code = "VS",
                Type = "Departments",
                Name = "Vaslui",
                LocalName = "Vaslui"
            },
            new()
            { 
                Code = "VN",
                Type = "Departments",
                Name = "Vrancea",
                LocalName = "Vrancea"
            }

        });
    }
}
