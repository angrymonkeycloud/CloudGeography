using AngryMonkey.Cloud.Geography;
namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    private static void FillInSubdivisionsTH()
    {
        AddSubdivisions("TH", new List<Subdivision>()
        {
            new()
            { 
                Code = "37",
                Type = "Province",
                Name = "Amnat Charoen",
                LocalName = "Amnat Charoen"
            },
            new()
            { 
                Code = "15",
                Type = "Province",
                Name = "Ang Thong",
                LocalName = "Ang Thong"
            },
            new()
            { 
                Code = "38",
                Type = "Province",
                Name = "Bueng Kan",
                LocalName = "Bueng Kan"
            },
            new()
            { 
                Code = "31",
                Type = "Province",
                Name = "Buri Ram",
                LocalName = "Buri Ram"
            },
            new()
            { 
                Code = "24",
                Type = "Province",
                Name = "Chachoengsao",
                LocalName = "Chachoengsao"
            },
            new()
            { 
                Code = "18",
                Type = "Province",
                Name = "Chai Nat",
                LocalName = "Chai Nat"
            },
            new()
            { 
                Code = "36",
                Type = "Province",
                Name = "Chaiyaphum",
                LocalName = "Chaiyaphum"
            },
            new()
            { 
                Code = "22",
                Type = "Province",
                Name = "Chanthaburi",
                LocalName = "Chanthaburi"
            },
            new()
            { 
                Code = "50",
                Type = "Province",
                Name = "Chiang Mai",
                LocalName = "Chiang Mai"
            },
            new()
            { 
                Code = "57",
                Type = "Province",
                Name = "Chiang Rai",
                LocalName = "Chiang Rai"
            },
            new()
            { 
                Code = "20",
                Type = "Province",
                Name = "Chon Buri",
                LocalName = "Chon Buri"
            },
            new()
            { 
                Code = "86",
                Type = "Province",
                Name = "Chumphon",
                LocalName = "Chumphon"
            },
            new()
            { 
                Code = "46",
                Type = "Province",
                Name = "Kalasin",
                LocalName = "Kalasin"
            },
            new()
            { 
                Code = "62",
                Type = "Province",
                Name = "Kamphaeng Phet",
                LocalName = "Kamphaeng Phet"
            },
            new()
            { 
                Code = "71",
                Type = "Province",
                Name = "Kanchanaburi",
                LocalName = "Kanchanaburi"
            },
            new()
            { 
                Code = "40",
                Type = "Province",
                Name = "Khon Kaen",
                LocalName = "Khon Kaen"
            },
            new()
            { 
                Code = "81",
                Type = "Province",
                Name = "Krabi",
                LocalName = "Krabi"
            },
            new()
            { 
                Code = "10",
                Type = "MetropolitanAdministration",
                Name = "Krung Thep Maha Nakhon",
                LocalName = "Krung Thep Maha Nakhon"
            },
            new()
            { 
                Code = "52",
                Type = "Province",
                Name = "Lampang",
                LocalName = "Lampang"
            },
            new()
            { 
                Code = "51",
                Type = "Province",
                Name = "Lamphun",
                LocalName = "Lamphun"
            },
            new()
            { 
                Code = "42",
                Type = "Province",
                Name = "Loei",
                LocalName = "Loei"
            },
            new()
            { 
                Code = "16",
                Type = "Province",
                Name = "Lop Buri",
                LocalName = "Lop Buri"
            },
            new()
            { 
                Code = "58",
                Type = "Province",
                Name = "Mae Hong Son",
                LocalName = "Mae Hong Son"
            },
            new()
            { 
                Code = "44",
                Type = "Province",
                Name = "Maha Sarakham",
                LocalName = "Maha Sarakham"
            },
            new()
            { 
                Code = "49",
                Type = "Province",
                Name = "Mukdahan",
                LocalName = "Mukdahan"
            },
            new()
            { 
                Code = "26",
                Type = "Province",
                Name = "Nakhon Nayok",
                LocalName = "Nakhon Nayok"
            },
            new()
            { 
                Code = "73",
                Type = "Province",
                Name = "Nakhon Pathom",
                LocalName = "Nakhon Pathom"
            },
            new()
            { 
                Code = "48",
                Type = "Province",
                Name = "Nakhon Phanom",
                LocalName = "Nakhon Phanom"
            },
            new()
            { 
                Code = "30",
                Type = "Province",
                Name = "Nakhon Ratchasima",
                LocalName = "Nakhon Ratchasima"
            },
            new()
            { 
                Code = "60",
                Type = "Province",
                Name = "Nakhon Sawan",
                LocalName = "Nakhon Sawan"
            },
            new()
            { 
                Code = "80",
                Type = "Province",
                Name = "Nakhon Si Thammarat",
                LocalName = "Nakhon Si Thammarat"
            },
            new()
            { 
                Code = "55",
                Type = "Province",
                Name = "Nan",
                LocalName = "Nan"
            },
            new()
            { 
                Code = "96",
                Type = "Province",
                Name = "Narathiwat",
                LocalName = "Narathiwat"
            },
            new()
            { 
                Code = "39",
                Type = "Province",
                Name = "Nong Bua Lam Phu",
                LocalName = "Nong Bua Lam Phu"
            },
            new()
            { 
                Code = "43",
                Type = "Province",
                Name = "Nong Khai",
                LocalName = "Nong Khai"
            },
            new()
            { 
                Code = "12",
                Type = "Province",
                Name = "Nonthaburi",
                LocalName = "Nonthaburi"
            },
            new()
            { 
                Code = "13",
                Type = "Province",
                Name = "Pathum Thani",
                LocalName = "Pathum Thani"
            },
            new()
            { 
                Code = "94",
                Type = "Province",
                Name = "Pattani",
                LocalName = "Pattani"
            },
            new()
            { 
                Code = "82",
                Type = "Province",
                Name = "Phangnga",
                LocalName = "Phangnga"
            },
            new()
            { 
                Code = "93",
                Type = "Province",
                Name = "Phatthalung",
                LocalName = "Phatthalung"
            },
            new()
            { 
                Code = "56",
                Type = "Province",
                Name = "Phayao",
                LocalName = "Phayao"
            },
            new()
            { 
                Code = "67",
                Type = "Province",
                Name = "Phetchabun",
                LocalName = "Phetchabun"
            },
            new()
            { 
                Code = "76",
                Type = "Province",
                Name = "Phetchaburi",
                LocalName = "Phetchaburi"
            },
            new()
            { 
                Code = "66",
                Type = "Province",
                Name = "Phichit",
                LocalName = "Phichit"
            },
            new()
            { 
                Code = "65",
                Type = "Province",
                Name = "Phitsanulok",
                LocalName = "Phitsanulok"
            },
            new()
            { 
                Code = "14",
                Type = "Province",
                Name = "Phra Nakhon Si Ayutthaya",
                LocalName = "Phra Nakhon Si Ayutthaya"
            },
            new()
            { 
                Code = "54",
                Type = "Province",
                Name = "Phrae",
                LocalName = "Phrae"
            },
            new()
            { 
                Code = "83",
                Type = "Province",
                Name = "Phuket",
                LocalName = "Phuket"
            },
            new()
            { 
                Code = "25",
                Type = "Province",
                Name = "Prachin Buri",
                LocalName = "Prachin Buri"
            },
            new()
            { 
                Code = "77",
                Type = "Province",
                Name = "Prachuap Khiri Khan",
                LocalName = "Prachuap Khiri Khan"
            },
            new()
            { 
                Code = "85",
                Type = "Province",
                Name = "Ranong",
                LocalName = "Ranong"
            },
            new()
            { 
                Code = "70",
                Type = "Province",
                Name = "Ratchaburi",
                LocalName = "Ratchaburi"
            },
            new()
            { 
                Code = "21",
                Type = "Province",
                Name = "Rayong",
                LocalName = "Rayong"
            },
            new()
            { 
                Code = "45",
                Type = "Province",
                Name = "Roi Et",
                LocalName = "Roi Et"
            },
            new()
            { 
                Code = "27",
                Type = "Province",
                Name = "Sa Kaeo",
                LocalName = "Sa Kaeo"
            },
            new()
            { 
                Code = "47",
                Type = "Province",
                Name = "Sakon Nakhon",
                LocalName = "Sakon Nakhon"
            },
            new()
            { 
                Code = "11",
                Type = "Province",
                Name = "Samut Prakan",
                LocalName = "Samut Prakan"
            },
            new()
            { 
                Code = "74",
                Type = "Province",
                Name = "Samut Sakhon",
                LocalName = "Samut Sakhon"
            },
            new()
            { 
                Code = "75",
                Type = "Province",
                Name = "Samut Songkhram",
                LocalName = "Samut Songkhram"
            },
            new()
            { 
                Code = "19",
                Type = "Province",
                Name = "Saraburi",
                LocalName = "Saraburi"
            },
            new()
            { 
                Code = "91",
                Type = "Province",
                Name = "Satun",
                LocalName = "Satun"
            },
            new()
            { 
                Code = "33",
                Type = "Province",
                Name = "Si Sa Ket",
                LocalName = "Si Sa Ket"
            },
            new()
            { 
                Code = "17",
                Type = "Province",
                Name = "Sing Buri",
                LocalName = "Sing Buri"
            },
            new()
            { 
                Code = "90",
                Type = "Province",
                Name = "Songkhla",
                LocalName = "Songkhla"
            },
            new()
            { 
                Code = "64",
                Type = "Province",
                Name = "Sukhothai",
                LocalName = "Sukhothai"
            },
            new()
            { 
                Code = "72",
                Type = "Province",
                Name = "Suphan Buri",
                LocalName = "Suphan Buri"
            },
            new()
            { 
                Code = "84",
                Type = "Province",
                Name = "Surat Thani",
                LocalName = "Surat Thani"
            },
            new()
            { 
                Code = "32",
                Type = "Province",
                Name = "Surin",
                LocalName = "Surin"
            },
            new()
            { 
                Code = "63",
                Type = "Province",
                Name = "Tak",
                LocalName = "Tak"
            },
            new()
            { 
                Code = "92",
                Type = "Province",
                Name = "Trang",
                LocalName = "Trang"
            },
            new()
            { 
                Code = "23",
                Type = "Province",
                Name = "Trat",
                LocalName = "Trat"
            },
            new()
            { 
                Code = "34",
                Type = "Province",
                Name = "Ubon Ratchathani",
                LocalName = "Ubon Ratchathani"
            },
            new()
            { 
                Code = "41",
                Type = "Province",
                Name = "Udon Thani",
                LocalName = "Udon Thani"
            },
            new()
            { 
                Code = "61",
                Type = "Province",
                Name = "Uthai Thani",
                LocalName = "Uthai Thani"
            },
            new()
            { 
                Code = "53",
                Type = "Province",
                Name = "Uttaradit",
                LocalName = "Uttaradit"
            },
            new()
            { 
                Code = "95",
                Type = "Province",
                Name = "Yala",
                LocalName = "Yala"
            },
            new()
            { 
                Code = "35",
                Type = "Province",
                Name = "Yasothon",
                LocalName = "Yasothon"
            }

        });
    }
}
