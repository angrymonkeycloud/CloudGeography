using AngryMonkey.Cloud.Geography;
namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    private static void FillInSubdivisionsRO()
    {
        AddSubdivisions("RO",
        [
            new()
            { 
                Code = "AB",
                Type = SubdivisionTypes.Departments,
                Name = "Alba",
                LocalName = "Alba"
            },
            new()
            { 
                Code = "AR",
                Type = SubdivisionTypes.Departments,
                Name = "Arad",
                LocalName = "Arad"
            },
            new()
            { 
                Code = "AG",
                Type = SubdivisionTypes.Departments,
                Name = "Arges",
                LocalName = "Arges"
            },
            new()
            { 
                Code = "BC",
                Type = SubdivisionTypes.Departments,
                Name = "Bacau",
                LocalName = "Bacau"
            },
            new()
            { 
                Code = "BH",
                Type = SubdivisionTypes.Departments,
                Name = "Bihor",
                LocalName = "Bihor"
            },
            new()
            { 
                Code = "BN",
                Type = SubdivisionTypes.Departments,
                Name = "Bistrita-Nasaud",
                LocalName = "Bistrita-Nasaud"
            },
            new()
            { 
                Code = "BT",
                Type = SubdivisionTypes.Departments,
                Name = "Botosani",
                LocalName = "Botosani"
            },
            new()
            { 
                Code = "BR",
                Type = SubdivisionTypes.Departments,
                Name = "Braila",
                LocalName = "Braila"
            },
            new()
            { 
                Code = "BV",
                Type = SubdivisionTypes.Departments,
                Name = "Brasov",
                LocalName = "Brasov"
            },
            new()
            { 
                Code = "B",
                Type = SubdivisionTypes.Municipality,
                Name = "Bucuresti",
                LocalName = "Bucuresti"
            },
            new()
            { 
                Code = "BZ",
                Type = SubdivisionTypes.Departments,
                Name = "Buzau",
                LocalName = "Buzau"
            },
            new()
            { 
                Code = "CL",
                Type = SubdivisionTypes.Departments,
                Name = "Calarasi",
                LocalName = "Calarasi"
            },
            new()
            { 
                Code = "CS",
                Type = SubdivisionTypes.Departments,
                Name = "Caras-Severin",
                LocalName = "Caras-Severin"
            },
            new()
            { 
                Code = "CJ",
                Type = SubdivisionTypes.Departments,
                Name = "Cluj",
                LocalName = "Cluj"
            },
            new()
            { 
                Code = "CT",
                Type = SubdivisionTypes.Departments,
                Name = "Constarta",
                LocalName = "Constarta"
            },
            new()
            { 
                Code = "CV",
                Type = SubdivisionTypes.Departments,
                Name = "Covasna",
                LocalName = "Covasna"
            },
            new()
            { 
                Code = "DB",
                Type = SubdivisionTypes.Departments,
                Name = "Dâmbovita",
                LocalName = "Dâmbovita"
            },
            new()
            { 
                Code = "DJ",
                Type = SubdivisionTypes.Departments,
                Name = "Dolj",
                LocalName = "Dolj"
            },
            new()
            { 
                Code = "GL",
                Type = SubdivisionTypes.Departments,
                Name = "Galati",
                LocalName = "Galati"
            },
            new()
            { 
                Code = "GR",
                Type = SubdivisionTypes.Departments,
                Name = "Giurgiu",
                LocalName = "Giurgiu"
            },
            new()
            { 
                Code = "GJ",
                Type = SubdivisionTypes.Departments,
                Name = "Gorj",
                LocalName = "Gorj"
            },
            new()
            { 
                Code = "HR",
                Type = SubdivisionTypes.Departments,
                Name = "Harghita",
                LocalName = "Harghita"
            },
            new()
            { 
                Code = "HD",
                Type = SubdivisionTypes.Departments,
                Name = "Hunedoara",
                LocalName = "Hunedoara"
            },
            new()
            { 
                Code = "IL",
                Type = SubdivisionTypes.Departments,
                Name = "Ialomita",
                LocalName = "Ialomita"
            },
            new()
            { 
                Code = "IS",
                Type = SubdivisionTypes.Departments,
                Name = "Iasi",
                LocalName = "Iasi"
            },
            new()
            { 
                Code = "IF",
                Type = SubdivisionTypes.Departments,
                Name = "Ilfov",
                LocalName = "Ilfov"
            },
            new()
            { 
                Code = "MM",
                Type = SubdivisionTypes.Departments,
                Name = "Maramures",
                LocalName = "Maramures"
            },
            new()
            { 
                Code = "MH",
                Type = SubdivisionTypes.Departments,
                Name = "Mehedinti",
                LocalName = "Mehedinti"
            },
            new()
            { 
                Code = "MS",
                Type = SubdivisionTypes.Departments,
                Name = "Mures",
                LocalName = "Mures"
            },
            new()
            { 
                Code = "NT",
                Type = SubdivisionTypes.Departments,
                Name = "Neamt",
                LocalName = "Neamt"
            },
            new()
            { 
                Code = "OT",
                Type = SubdivisionTypes.Departments,
                Name = "Olt",
                LocalName = "Olt"
            },
            new()
            { 
                Code = "PH",
                Type = SubdivisionTypes.Departments,
                Name = "Prahova",
                LocalName = "Prahova"
            },
            new()
            { 
                Code = "SJ",
                Type = SubdivisionTypes.Departments,
                Name = "Salaj",
                LocalName = "Salaj"
            },
            new()
            { 
                Code = "SM",
                Type = SubdivisionTypes.Departments,
                Name = "Satu Mare",
                LocalName = "Satu Mare"
            },
            new()
            { 
                Code = "SB",
                Type = SubdivisionTypes.Departments,
                Name = "Sibiu",
                LocalName = "Sibiu"
            },
            new()
            { 
                Code = "SV",
                Type = SubdivisionTypes.Departments,
                Name = "Suceava",
                LocalName = "Suceava"
            },
            new()
            { 
                Code = "TR",
                Type = SubdivisionTypes.Departments,
                Name = "Teleorman",
                LocalName = "Teleorman"
            },
            new()
            { 
                Code = "TM",
                Type = SubdivisionTypes.Departments,
                Name = "Timis",
                LocalName = "Timis"
            },
            new()
            { 
                Code = "TL",
                Type = SubdivisionTypes.Departments,
                Name = "Tulcea",
                LocalName = "Tulcea"
            },
            new()
            { 
                Code = "VL",
                Type = SubdivisionTypes.Departments,
                Name = "Vâlcea",
                LocalName = "Vâlcea"
            },
            new()
            { 
                Code = "VS",
                Type = SubdivisionTypes.Departments,
                Name = "Vaslui",
                LocalName = "Vaslui"
            },
            new()
            { 
                Code = "VN",
                Type = SubdivisionTypes.Departments,
                Name = "Vrancea",
                LocalName = "Vrancea"
            }

        ]);
    }
}
