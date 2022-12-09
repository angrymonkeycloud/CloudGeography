using AngryMonkey.Cloud.Geography;
namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    private static void FillInSubdivisionsDZ()
    {
        AddSubdivisions("DZ", new List<Subdivision>()
        {
            new()
            { 
                Code = "1",
                Type = "Province",
                Name = "Adrar",
                LocalName = "Adrar"
            },
            new()
            { 
                Code = "44",
                Type = "Province",
                Name = "Aïn Defla",
                LocalName = "Aïn Defla"
            },
            new()
            { 
                Code = "46",
                Type = "Province",
                Name = "Aïn Témouchent",
                LocalName = "Aïn Témouchent"
            },
            new()
            { 
                Code = "16",
                Type = "Province",
                Name = "Alger",
                LocalName = "Alger"
            },
            new()
            { 
                Code = "23",
                Type = "Province",
                Name = "Annaba",
                LocalName = "Annaba"
            },
            new()
            { 
                Code = "5",
                Type = "Province",
                Name = "Batna",
                LocalName = "Batna"
            },
            new()
            { 
                Code = "8",
                Type = "Province",
                Name = "Béchar",
                LocalName = "Béchar"
            },
            new()
            { 
                Code = "6",
                Type = "Province",
                Name = "Béjaïa",
                LocalName = "Béjaïa"
            },
            new()
            { 
                Code = "7",
                Type = "Province",
                Name = "Biskra",
                LocalName = "Biskra"
            },
            new()
            { 
                Code = "9",
                Type = "Province",
                Name = "Blida",
                LocalName = "Blida"
            },
            new()
            { 
                Code = "34",
                Type = "Province",
                Name = "Bordj Bou Arréridj",
                LocalName = "Bordj Bou Arréridj"
            },
            new()
            { 
                Code = "10",
                Type = "Province",
                Name = "Bouira",
                LocalName = "Bouira"
            },
            new()
            { 
                Code = "35",
                Type = "Province",
                Name = "Boumerdès",
                LocalName = "Boumerdès"
            },
            new()
            { 
                Code = "2",
                Type = "Province",
                Name = "Chlef",
                LocalName = "Chlef"
            },
            new()
            { 
                Code = "25",
                Type = "Province",
                Name = "Constantine",
                LocalName = "Constantine"
            },
            new()
            { 
                Code = "17",
                Type = "Province",
                Name = "Djelfa",
                LocalName = "Djelfa"
            },
            new()
            { 
                Code = "32",
                Type = "Province",
                Name = "El Bayadh",
                LocalName = "El Bayadh"
            },
            new()
            { 
                Code = "39",
                Type = "Province",
                Name = "El Oued",
                LocalName = "El Oued"
            },
            new()
            { 
                Code = "36",
                Type = "Province",
                Name = "El Tarf",
                LocalName = "El Tarf"
            },
            new()
            { 
                Code = "47",
                Type = "Province",
                Name = "Ghardaïa",
                LocalName = "Ghardaïa"
            },
            new()
            { 
                Code = "24",
                Type = "Province",
                Name = "Guelma",
                LocalName = "Guelma"
            },
            new()
            { 
                Code = "33",
                Type = "Province",
                Name = "Illizi",
                LocalName = "Illizi"
            },
            new()
            { 
                Code = "18",
                Type = "Province",
                Name = "Jijel",
                LocalName = "Jijel"
            },
            new()
            { 
                Code = "40",
                Type = "Province",
                Name = "Khenchela",
                LocalName = "Khenchela"
            },
            new()
            { 
                Code = "3",
                Type = "Province",
                Name = "Laghouat",
                LocalName = "Laghouat"
            },
            new()
            { 
                Code = "29",
                Type = "Province",
                Name = "Mascara",
                LocalName = "Mascara"
            },
            new()
            { 
                Code = "26",
                Type = "Province",
                Name = "Médéa",
                LocalName = "Médéa"
            },
            new()
            { 
                Code = "43",
                Type = "Province",
                Name = "Mila",
                LocalName = "Mila"
            },
            new()
            { 
                Code = "27",
                Type = "Province",
                Name = "Mostaganem",
                LocalName = "Mostaganem"
            },
            new()
            { 
                Code = "28",
                Type = "Province",
                Name = "M'sila",
                LocalName = "M'sila"
            },
            new()
            { 
                Code = "45",
                Type = "Province",
                Name = "Naama",
                LocalName = "Naama"
            },
            new()
            { 
                Code = "31",
                Type = "Province",
                Name = "Oran",
                LocalName = "Oran"
            },
            new()
            { 
                Code = "30",
                Type = "Province",
                Name = "Ouargla",
                LocalName = "Ouargla"
            },
            new()
            { 
                Code = "4",
                Type = "Province",
                Name = "Oum el Bouaghi",
                LocalName = "Oum el Bouaghi"
            },
            new()
            { 
                Code = "48",
                Type = "Province",
                Name = "Relizane",
                LocalName = "Relizane"
            },
            new()
            { 
                Code = "20",
                Type = "Province",
                Name = "Saïda",
                LocalName = "Saïda"
            },
            new()
            { 
                Code = "19",
                Type = "Province",
                Name = "Sétif",
                LocalName = "Sétif"
            },
            new()
            { 
                Code = "22",
                Type = "Province",
                Name = "Sidi Bel Abbès",
                LocalName = "Sidi Bel Abbès"
            },
            new()
            { 
                Code = "21",
                Type = "Province",
                Name = "Skikda",
                LocalName = "Skikda"
            },
            new()
            { 
                Code = "41",
                Type = "Province",
                Name = "Souk Ahras",
                LocalName = "Souk Ahras"
            },
            new()
            { 
                Code = "11",
                Type = "Province",
                Name = "Tamanrasset",
                LocalName = "Tamanrasset"
            },
            new()
            { 
                Code = "12",
                Type = "Province",
                Name = "Tébessa",
                LocalName = "Tébessa"
            },
            new()
            { 
                Code = "14",
                Type = "Province",
                Name = "Tiaret",
                LocalName = "Tiaret"
            },
            new()
            { 
                Code = "37",
                Type = "Province",
                Name = "Tindouf",
                LocalName = "Tindouf"
            },
            new()
            { 
                Code = "42",
                Type = "Province",
                Name = "Tipaza",
                LocalName = "Tipaza"
            },
            new()
            { 
                Code = "38",
                Type = "Province",
                Name = "Tissemsilt",
                LocalName = "Tissemsilt"
            },
            new()
            { 
                Code = "15",
                Type = "Province",
                Name = "Tizi Ouzou",
                LocalName = "Tizi Ouzou"
            },
            new()
            { 
                Code = "13",
                Type = "Province",
                Name = "Tlemcen",
                LocalName = "Tlemcen"
            }

        });
    }
}
