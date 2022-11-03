using AngryMonkey.Cloud.Geography;
namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    private static void FillInSubdivisionsID()
    {
        AddSubdivisions("ID", new List<Subdivision>()
        {
            new()
            { 
                Code = "AC",
                Type = "Province",
                Name = "Aceh",
                LocalName = "Aceh"
            },
            new()
            { 
                Code = "BA",
                Type = "Province",
                Name = "Bali",
                LocalName = "Bali"
            },
            new()
            { 
                Code = "BT",
                Type = "Province",
                Name = "Banten",
                LocalName = "Banten"
            },
            new()
            { 
                Code = "BE",
                Type = "Province",
                Name = "Bengkulu",
                LocalName = "Bengkulu"
            },
            new()
            { 
                Code = "GO",
                Type = "Province",
                Name = "Gorontalo",
                LocalName = "Gorontalo"
            },
            new()
            { 
                Code = "JK",
                Type = "District",
                Name = "Jakarta Raya",
                LocalName = "Jakarta Raya"
            },
            new()
            { 
                Code = "JA",
                Type = "Province",
                Name = "Jambi",
                LocalName = "Jambi"
            },
            new()
            { 
                Code = "JB",
                Type = "Province",
                Name = "Jawa Barat",
                LocalName = "Jawa Barat"
            },
            new()
            { 
                Code = "JT",
                Type = "Province",
                Name = "Jawa Tengah",
                LocalName = "Jawa Tengah"
            },
            new()
            { 
                Code = "JI",
                Type = "Province",
                Name = "Jawa Timur",
                LocalName = "Jawa Timur"
            },
            new()
            { 
                Code = "KB",
                Type = "Province",
                Name = "Kalimantan Barat",
                LocalName = "Kalimantan Barat"
            },
            new()
            { 
                Code = "KS",
                Type = "Province",
                Name = "Kalimantan Selatan",
                LocalName = "Kalimantan Selatan"
            },
            new()
            { 
                Code = "KT",
                Type = "Province",
                Name = "Kalimantan Tengah",
                LocalName = "Kalimantan Tengah"
            },
            new()
            { 
                Code = "KI",
                Type = "Province",
                Name = "Kalimantan Timur",
                LocalName = "Kalimantan Timur"
            },
            new()
            { 
                Code = "KU",
                Type = "Province",
                Name = "Kalimantan Utara",
                LocalName = "Kalimantan Utara"
            },
            new()
            { 
                Code = "BB",
                Type = "Province",
                Name = "Kepulauan Bangka Belitung",
                LocalName = "Kepulauan Bangka Belitung"
            },
            new()
            { 
                Code = "KR",
                Type = "Province",
                Name = "Kepulauan Riau",
                LocalName = "Kepulauan Riau"
            },
            new()
            { 
                Code = "LA",
                Type = "Province",
                Name = "Lampung",
                LocalName = "Lampung"
            },
            new()
            { 
                Code = "MA",
                Type = "Province",
                Name = "Maluku",
                LocalName = "Maluku"
            },
            new()
            { 
                Code = "MU",
                Type = "Province",
                Name = "Maluku Utara",
                LocalName = "Maluku Utara"
            },
            new()
            { 
                Code = "NB",
                Type = "Province",
                Name = "Nusa Tenggara Barat",
                LocalName = "Nusa Tenggara Barat"
            },
            new()
            { 
                Code = "NT",
                Type = "Province",
                Name = "Nusa Tenggara Timur",
                LocalName = "Nusa Tenggara Timur"
            },
            new()
            { 
                Code = "PA",
                Type = "Province",
                Name = "Papua",
                LocalName = "Papua"
            },
            new()
            { 
                Code = "PB",
                Type = "Province",
                Name = "Papua Barat",
                LocalName = "Papua Barat"
            },
            new()
            { 
                Code = "RI",
                Type = "Province",
                Name = "Riau",
                LocalName = "Riau"
            },
            new()
            { 
                Code = "SR",
                Type = "Province",
                Name = "Sulawesi Barat",
                LocalName = "Sulawesi Barat"
            },
            new()
            { 
                Code = "SN",
                Type = "Province",
                Name = "Sulawesi Selatan",
                LocalName = "Sulawesi Selatan"
            },
            new()
            { 
                Code = "ST",
                Type = "Province",
                Name = "Sulawesi Tengah",
                LocalName = "Sulawesi Tengah"
            },
            new()
            { 
                Code = "SG",
                Type = "Province",
                Name = "Sulawesi Tenggara",
                LocalName = "Sulawesi Tenggara"
            },
            new()
            { 
                Code = "SA",
                Type = "Province",
                Name = "Sulawesi Utara",
                LocalName = "Sulawesi Utara"
            },
            new()
            { 
                Code = "SB",
                Type = "Province",
                Name = "Sumatera Barat",
                LocalName = "Sumatera Barat"
            },
            new()
            { 
                Code = "SS",
                Type = "Province",
                Name = "Sumatera Selatan",
                LocalName = "Sumatera Selatan"
            },
            new()
            { 
                Code = "SU",
                Type = "Province",
                Name = "Sumatera Utara",
                LocalName = "Sumatera Utara"
            },
            new()
            { 
                Code = "YO",
                Type = "Region",
                Name = "Yogyakarta",
                LocalName = "Yogyakarta"
            }

        });
    }
}
