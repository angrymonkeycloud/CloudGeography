using AngryMonkey.Cloud.Geography;
namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    private static void FillInSubdivisionsID()
    {
        AddSubdivisions("ID",
        [
            new()
            { 
                Code = "AC",
                Type = SubdivisionTypes.Province,
                Name = "Aceh",
                LocalName = "Aceh"
            },
            new()
            { 
                Code = "BA",
                Type = SubdivisionTypes.Province,
                Name = "Bali",
                LocalName = "Bali"
            },
            new()
            { 
                Code = "BT",
                Type = SubdivisionTypes.Province,
                Name = "Banten",
                LocalName = "Banten"
            },
            new()
            { 
                Code = "BE",
                Type = SubdivisionTypes.Province,
                Name = "Bengkulu",
                LocalName = "Bengkulu"
            },
            new()
            { 
                Code = "GO",
                Type = SubdivisionTypes.Province,
                Name = "Gorontalo",
                LocalName = "Gorontalo"
            },
            new()
            { 
                Code = "JK",
                Type = SubdivisionTypes.District,
                Name = "Jakarta Raya",
                LocalName = "Jakarta Raya"
            },
            new()
            { 
                Code = "JA",
                Type = SubdivisionTypes.Province,
                Name = "Jambi",
                LocalName = "Jambi"
            },
            new()
            { 
                Code = "JB",
                Type = SubdivisionTypes.Province,
                Name = "Jawa Barat",
                LocalName = "Jawa Barat"
            },
            new()
            { 
                Code = "JT",
                Type = SubdivisionTypes.Province,
                Name = "Jawa Tengah",
                LocalName = "Jawa Tengah"
            },
            new()
            { 
                Code = "JI",
                Type = SubdivisionTypes.Province,
                Name = "Jawa Timur",
                LocalName = "Jawa Timur"
            },
            new()
            { 
                Code = "KB",
                Type = SubdivisionTypes.Province,
                Name = "Kalimantan Barat",
                LocalName = "Kalimantan Barat"
            },
            new()
            { 
                Code = "KS",
                Type = SubdivisionTypes.Province,
                Name = "Kalimantan Selatan",
                LocalName = "Kalimantan Selatan"
            },
            new()
            { 
                Code = "KT",
                Type = SubdivisionTypes.Province,
                Name = "Kalimantan Tengah",
                LocalName = "Kalimantan Tengah"
            },
            new()
            { 
                Code = "KI",
                Type = SubdivisionTypes.Province,
                Name = "Kalimantan Timur",
                LocalName = "Kalimantan Timur"
            },
            new()
            { 
                Code = "KU",
                Type = SubdivisionTypes.Province,
                Name = "Kalimantan Utara",
                LocalName = "Kalimantan Utara"
            },
            new()
            { 
                Code = "BB",
                Type = SubdivisionTypes.Province,
                Name = "Kepulauan Bangka Belitung",
                LocalName = "Kepulauan Bangka Belitung"
            },
            new()
            { 
                Code = "KR",
                Type = SubdivisionTypes.Province,
                Name = "Kepulauan Riau",
                LocalName = "Kepulauan Riau"
            },
            new()
            { 
                Code = "LA",
                Type = SubdivisionTypes.Province,
                Name = "Lampung",
                LocalName = "Lampung"
            },
            new()
            { 
                Code = "MA",
                Type = SubdivisionTypes.Province,
                Name = "Maluku",
                LocalName = "Maluku"
            },
            new()
            { 
                Code = "MU",
                Type = SubdivisionTypes.Province,
                Name = "Maluku Utara",
                LocalName = "Maluku Utara"
            },
            new()
            { 
                Code = "NB",
                Type = SubdivisionTypes.Province,
                Name = "Nusa Tenggara Barat",
                LocalName = "Nusa Tenggara Barat"
            },
            new()
            { 
                Code = "NT",
                Type = SubdivisionTypes.Province,
                Name = "Nusa Tenggara Timur",
                LocalName = "Nusa Tenggara Timur"
            },
            new()
            { 
                Code = "PA",
                Type = SubdivisionTypes.Province,
                Name = "Papua",
                LocalName = "Papua"
            },
            new()
            { 
                Code = "PB",
                Type = SubdivisionTypes.Province,
                Name = "Papua Barat",
                LocalName = "Papua Barat"
            },
            new()
            { 
                Code = "RI",
                Type = SubdivisionTypes.Province,
                Name = "Riau",
                LocalName = "Riau"
            },
            new()
            { 
                Code = "SR",
                Type = SubdivisionTypes.Province,
                Name = "Sulawesi Barat",
                LocalName = "Sulawesi Barat"
            },
            new()
            { 
                Code = "SN",
                Type = SubdivisionTypes.Province,
                Name = "Sulawesi Selatan",
                LocalName = "Sulawesi Selatan"
            },
            new()
            { 
                Code = "ST",
                Type = SubdivisionTypes.Province,
                Name = "Sulawesi Tengah",
                LocalName = "Sulawesi Tengah"
            },
            new()
            { 
                Code = "SG",
                Type = SubdivisionTypes.Province,
                Name = "Sulawesi Tenggara",
                LocalName = "Sulawesi Tenggara"
            },
            new()
            { 
                Code = "SA",
                Type = SubdivisionTypes.Province,
                Name = "Sulawesi Utara",
                LocalName = "Sulawesi Utara"
            },
            new()
            { 
                Code = "SB",
                Type = SubdivisionTypes.Province,
                Name = "Sumatera Barat",
                LocalName = "Sumatera Barat"
            },
            new()
            { 
                Code = "SS",
                Type = SubdivisionTypes.Province,
                Name = "Sumatera Selatan",
                LocalName = "Sumatera Selatan"
            },
            new()
            { 
                Code = "SU",
                Type = SubdivisionTypes.Province,
                Name = "Sumatera Utara",
                LocalName = "Sumatera Utara"
            },
            new()
            { 
                Code = "YO",
                Type = SubdivisionTypes.Region,
                Name = "Yogyakarta",
                LocalName = "Yogyakarta"
            }

        ]);
    }
}
