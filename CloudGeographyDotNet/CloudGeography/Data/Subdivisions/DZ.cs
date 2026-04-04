using AngryMonkey.Cloud.Geography;
namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    private static void FillInSubdivisionsDZ()
    {
        AddSubdivisions("DZ",
        [
            new()
            { 
                Code = "1",
                Type = SubdivisionTypes.Province,
                Name = "Adrar",
                LocalName = "Adrar"
            },
            new()
            { 
                Code = "44",
                Type = SubdivisionTypes.Province,
                Name = "Aïn Defla",
                LocalName = "Aïn Defla"
            },
            new()
            { 
                Code = "46",
                Type = SubdivisionTypes.Province,
                Name = "Aïn Témouchent",
                LocalName = "Aïn Témouchent"
            },
            new()
            { 
                Code = "16",
                Type = SubdivisionTypes.Province,
                Name = "Alger",
                LocalName = "Alger"
            },
            new()
            { 
                Code = "23",
                Type = SubdivisionTypes.Province,
                Name = "Annaba",
                LocalName = "Annaba"
            },
            new()
            { 
                Code = "5",
                Type = SubdivisionTypes.Province,
                Name = "Batna",
                LocalName = "Batna"
            },
            new()
            { 
                Code = "8",
                Type = SubdivisionTypes.Province,
                Name = "Béchar",
                LocalName = "Béchar"
            },
            new()
            { 
                Code = "6",
                Type = SubdivisionTypes.Province,
                Name = "Béjaïa",
                LocalName = "Béjaïa"
            },
            new()
            { 
                Code = "7",
                Type = SubdivisionTypes.Province,
                Name = "Biskra",
                LocalName = "Biskra"
            },
            new()
            { 
                Code = "9",
                Type = SubdivisionTypes.Province,
                Name = "Blida",
                LocalName = "Blida"
            },
            new()
            { 
                Code = "34",
                Type = SubdivisionTypes.Province,
                Name = "Bordj Bou Arréridj",
                LocalName = "Bordj Bou Arréridj"
            },
            new()
            { 
                Code = "10",
                Type = SubdivisionTypes.Province,
                Name = "Bouira",
                LocalName = "Bouira"
            },
            new()
            { 
                Code = "35",
                Type = SubdivisionTypes.Province,
                Name = "Boumerdès",
                LocalName = "Boumerdès"
            },
            new()
            { 
                Code = "2",
                Type = SubdivisionTypes.Province,
                Name = "Chlef",
                LocalName = "Chlef"
            },
            new()
            { 
                Code = "25",
                Type = SubdivisionTypes.Province,
                Name = "Constantine",
                LocalName = "Constantine"
            },
            new()
            { 
                Code = "17",
                Type = SubdivisionTypes.Province,
                Name = "Djelfa",
                LocalName = "Djelfa"
            },
            new()
            { 
                Code = "32",
                Type = SubdivisionTypes.Province,
                Name = "El Bayadh",
                LocalName = "El Bayadh"
            },
            new()
            { 
                Code = "39",
                Type = SubdivisionTypes.Province,
                Name = "El Oued",
                LocalName = "El Oued"
            },
            new()
            { 
                Code = "36",
                Type = SubdivisionTypes.Province,
                Name = "El Tarf",
                LocalName = "El Tarf"
            },
            new()
            { 
                Code = "47",
                Type = SubdivisionTypes.Province,
                Name = "Ghardaïa",
                LocalName = "Ghardaïa"
            },
            new()
            { 
                Code = "24",
                Type = SubdivisionTypes.Province,
                Name = "Guelma",
                LocalName = "Guelma"
            },
            new()
            { 
                Code = "33",
                Type = SubdivisionTypes.Province,
                Name = "Illizi",
                LocalName = "Illizi"
            },
            new()
            { 
                Code = "18",
                Type = SubdivisionTypes.Province,
                Name = "Jijel",
                LocalName = "Jijel"
            },
            new()
            { 
                Code = "40",
                Type = SubdivisionTypes.Province,
                Name = "Khenchela",
                LocalName = "Khenchela"
            },
            new()
            { 
                Code = "3",
                Type = SubdivisionTypes.Province,
                Name = "Laghouat",
                LocalName = "Laghouat"
            },
            new()
            { 
                Code = "29",
                Type = SubdivisionTypes.Province,
                Name = "Mascara",
                LocalName = "Mascara"
            },
            new()
            { 
                Code = "26",
                Type = SubdivisionTypes.Province,
                Name = "Médéa",
                LocalName = "Médéa"
            },
            new()
            { 
                Code = "43",
                Type = SubdivisionTypes.Province,
                Name = "Mila",
                LocalName = "Mila"
            },
            new()
            { 
                Code = "27",
                Type = SubdivisionTypes.Province,
                Name = "Mostaganem",
                LocalName = "Mostaganem"
            },
            new()
            { 
                Code = "28",
                Type = SubdivisionTypes.Province,
                Name = "M'sila",
                LocalName = "M'sila"
            },
            new()
            { 
                Code = "45",
                Type = SubdivisionTypes.Province,
                Name = "Naama",
                LocalName = "Naama"
            },
            new()
            { 
                Code = "31",
                Type = SubdivisionTypes.Province,
                Name = "Oran",
                LocalName = "Oran"
            },
            new()
            { 
                Code = "30",
                Type = SubdivisionTypes.Province,
                Name = "Ouargla",
                LocalName = "Ouargla"
            },
            new()
            { 
                Code = "4",
                Type = SubdivisionTypes.Province,
                Name = "Oum el Bouaghi",
                LocalName = "Oum el Bouaghi"
            },
            new()
            { 
                Code = "48",
                Type = SubdivisionTypes.Province,
                Name = "Relizane",
                LocalName = "Relizane"
            },
            new()
            { 
                Code = "20",
                Type = SubdivisionTypes.Province,
                Name = "Saïda",
                LocalName = "Saïda"
            },
            new()
            { 
                Code = "19",
                Type = SubdivisionTypes.Province,
                Name = "Sétif",
                LocalName = "Sétif"
            },
            new()
            { 
                Code = "22",
                Type = SubdivisionTypes.Province,
                Name = "Sidi Bel Abbès",
                LocalName = "Sidi Bel Abbès"
            },
            new()
            { 
                Code = "21",
                Type = SubdivisionTypes.Province,
                Name = "Skikda",
                LocalName = "Skikda"
            },
            new()
            { 
                Code = "41",
                Type = SubdivisionTypes.Province,
                Name = "Souk Ahras",
                LocalName = "Souk Ahras"
            },
            new()
            { 
                Code = "11",
                Type = SubdivisionTypes.Province,
                Name = "Tamanrasset",
                LocalName = "Tamanrasset"
            },
            new()
            { 
                Code = "12",
                Type = SubdivisionTypes.Province,
                Name = "Tébessa",
                LocalName = "Tébessa"
            },
            new()
            { 
                Code = "14",
                Type = SubdivisionTypes.Province,
                Name = "Tiaret",
                LocalName = "Tiaret"
            },
            new()
            { 
                Code = "37",
                Type = SubdivisionTypes.Province,
                Name = "Tindouf",
                LocalName = "Tindouf"
            },
            new()
            { 
                Code = "42",
                Type = SubdivisionTypes.Province,
                Name = "Tipaza",
                LocalName = "Tipaza"
            },
            new()
            { 
                Code = "38",
                Type = SubdivisionTypes.Province,
                Name = "Tissemsilt",
                LocalName = "Tissemsilt"
            },
            new()
            { 
                Code = "15",
                Type = SubdivisionTypes.Province,
                Name = "Tizi Ouzou",
                LocalName = "Tizi Ouzou"
            },
            new()
            { 
                Code = "13",
                Type = SubdivisionTypes.Province,
                Name = "Tlemcen",
                LocalName = "Tlemcen"
            }

        ]);
    }
}
