using AngryMonkey.Cloud.Geography;
namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    private static void FillInSubdivisionsTH()
    {
        AddSubdivisions("TH",
        [
            new()
            { 
                Code = "37",
                Type = SubdivisionTypes.Province,
                Name = "Amnat Charoen",
                LocalName = "Amnat Charoen"
            },
            new()
            { 
                Code = "15",
                Type = SubdivisionTypes.Province,
                Name = "Ang Thong",
                LocalName = "Ang Thong"
            },
            new()
            { 
                Code = "38",
                Type = SubdivisionTypes.Province,
                Name = "Bueng Kan",
                LocalName = "Bueng Kan"
            },
            new()
            { 
                Code = "31",
                Type = SubdivisionTypes.Province,
                Name = "Buri Ram",
                LocalName = "Buri Ram"
            },
            new()
            { 
                Code = "24",
                Type = SubdivisionTypes.Province,
                Name = "Chachoengsao",
                LocalName = "Chachoengsao"
            },
            new()
            { 
                Code = "18",
                Type = SubdivisionTypes.Province,
                Name = "Chai Nat",
                LocalName = "Chai Nat"
            },
            new()
            { 
                Code = "36",
                Type = SubdivisionTypes.Province,
                Name = "Chaiyaphum",
                LocalName = "Chaiyaphum"
            },
            new()
            { 
                Code = "22",
                Type = SubdivisionTypes.Province,
                Name = "Chanthaburi",
                LocalName = "Chanthaburi"
            },
            new()
            { 
                Code = "50",
                Type = SubdivisionTypes.Province,
                Name = "Chiang Mai",
                LocalName = "Chiang Mai"
            },
            new()
            { 
                Code = "57",
                Type = SubdivisionTypes.Province,
                Name = "Chiang Rai",
                LocalName = "Chiang Rai"
            },
            new()
            { 
                Code = "20",
                Type = SubdivisionTypes.Province,
                Name = "Chon Buri",
                LocalName = "Chon Buri"
            },
            new()
            { 
                Code = "86",
                Type = SubdivisionTypes.Province,
                Name = "Chumphon",
                LocalName = "Chumphon"
            },
            new()
            { 
                Code = "46",
                Type = SubdivisionTypes.Province,
                Name = "Kalasin",
                LocalName = "Kalasin"
            },
            new()
            { 
                Code = "62",
                Type = SubdivisionTypes.Province,
                Name = "Kamphaeng Phet",
                LocalName = "Kamphaeng Phet"
            },
            new()
            { 
                Code = "71",
                Type = SubdivisionTypes.Province,
                Name = "Kanchanaburi",
                LocalName = "Kanchanaburi"
            },
            new()
            { 
                Code = "40",
                Type = SubdivisionTypes.Province,
                Name = "Khon Kaen",
                LocalName = "Khon Kaen"
            },
            new()
            { 
                Code = "81",
                Type = SubdivisionTypes.Province,
                Name = "Krabi",
                LocalName = "Krabi"
            },
            new()
            { 
                Code = "10",
                Type = SubdivisionTypes.MetropolitanAdministration,
                Name = "Krung Thep Maha Nakhon",
                LocalName = "Krung Thep Maha Nakhon"
            },
            new()
            { 
                Code = "52",
                Type = SubdivisionTypes.Province,
                Name = "Lampang",
                LocalName = "Lampang"
            },
            new()
            { 
                Code = "51",
                Type = SubdivisionTypes.Province,
                Name = "Lamphun",
                LocalName = "Lamphun"
            },
            new()
            { 
                Code = "42",
                Type = SubdivisionTypes.Province,
                Name = "Loei",
                LocalName = "Loei"
            },
            new()
            { 
                Code = "16",
                Type = SubdivisionTypes.Province,
                Name = "Lop Buri",
                LocalName = "Lop Buri"
            },
            new()
            { 
                Code = "58",
                Type = SubdivisionTypes.Province,
                Name = "Mae Hong Son",
                LocalName = "Mae Hong Son"
            },
            new()
            { 
                Code = "44",
                Type = SubdivisionTypes.Province,
                Name = "Maha Sarakham",
                LocalName = "Maha Sarakham"
            },
            new()
            { 
                Code = "49",
                Type = SubdivisionTypes.Province,
                Name = "Mukdahan",
                LocalName = "Mukdahan"
            },
            new()
            { 
                Code = "26",
                Type = SubdivisionTypes.Province,
                Name = "Nakhon Nayok",
                LocalName = "Nakhon Nayok"
            },
            new()
            { 
                Code = "73",
                Type = SubdivisionTypes.Province,
                Name = "Nakhon Pathom",
                LocalName = "Nakhon Pathom"
            },
            new()
            { 
                Code = "48",
                Type = SubdivisionTypes.Province,
                Name = "Nakhon Phanom",
                LocalName = "Nakhon Phanom"
            },
            new()
            { 
                Code = "30",
                Type = SubdivisionTypes.Province,
                Name = "Nakhon Ratchasima",
                LocalName = "Nakhon Ratchasima"
            },
            new()
            { 
                Code = "60",
                Type = SubdivisionTypes.Province,
                Name = "Nakhon Sawan",
                LocalName = "Nakhon Sawan"
            },
            new()
            { 
                Code = "80",
                Type = SubdivisionTypes.Province,
                Name = "Nakhon Si Thammarat",
                LocalName = "Nakhon Si Thammarat"
            },
            new()
            { 
                Code = "55",
                Type = SubdivisionTypes.Province,
                Name = "Nan",
                LocalName = "Nan"
            },
            new()
            { 
                Code = "96",
                Type = SubdivisionTypes.Province,
                Name = "Narathiwat",
                LocalName = "Narathiwat"
            },
            new()
            { 
                Code = "39",
                Type = SubdivisionTypes.Province,
                Name = "Nong Bua Lam Phu",
                LocalName = "Nong Bua Lam Phu"
            },
            new()
            { 
                Code = "43",
                Type = SubdivisionTypes.Province,
                Name = "Nong Khai",
                LocalName = "Nong Khai"
            },
            new()
            { 
                Code = "12",
                Type = SubdivisionTypes.Province,
                Name = "Nonthaburi",
                LocalName = "Nonthaburi"
            },
            new()
            { 
                Code = "13",
                Type = SubdivisionTypes.Province,
                Name = "Pathum Thani",
                LocalName = "Pathum Thani"
            },
            new()
            { 
                Code = "94",
                Type = SubdivisionTypes.Province,
                Name = "Pattani",
                LocalName = "Pattani"
            },
            new()
            { 
                Code = "82",
                Type = SubdivisionTypes.Province,
                Name = "Phangnga",
                LocalName = "Phangnga"
            },
            new()
            { 
                Code = "93",
                Type = SubdivisionTypes.Province,
                Name = "Phatthalung",
                LocalName = "Phatthalung"
            },
            new()
            { 
                Code = "56",
                Type = SubdivisionTypes.Province,
                Name = "Phayao",
                LocalName = "Phayao"
            },
            new()
            { 
                Code = "67",
                Type = SubdivisionTypes.Province,
                Name = "Phetchabun",
                LocalName = "Phetchabun"
            },
            new()
            { 
                Code = "76",
                Type = SubdivisionTypes.Province,
                Name = "Phetchaburi",
                LocalName = "Phetchaburi"
            },
            new()
            { 
                Code = "66",
                Type = SubdivisionTypes.Province,
                Name = "Phichit",
                LocalName = "Phichit"
            },
            new()
            { 
                Code = "65",
                Type = SubdivisionTypes.Province,
                Name = "Phitsanulok",
                LocalName = "Phitsanulok"
            },
            new()
            { 
                Code = "14",
                Type = SubdivisionTypes.Province,
                Name = "Phra Nakhon Si Ayutthaya",
                LocalName = "Phra Nakhon Si Ayutthaya"
            },
            new()
            { 
                Code = "54",
                Type = SubdivisionTypes.Province,
                Name = "Phrae",
                LocalName = "Phrae"
            },
            new()
            { 
                Code = "83",
                Type = SubdivisionTypes.Province,
                Name = "Phuket",
                LocalName = "Phuket"
            },
            new()
            { 
                Code = "25",
                Type = SubdivisionTypes.Province,
                Name = "Prachin Buri",
                LocalName = "Prachin Buri"
            },
            new()
            { 
                Code = "77",
                Type = SubdivisionTypes.Province,
                Name = "Prachuap Khiri Khan",
                LocalName = "Prachuap Khiri Khan"
            },
            new()
            { 
                Code = "85",
                Type = SubdivisionTypes.Province,
                Name = "Ranong",
                LocalName = "Ranong"
            },
            new()
            { 
                Code = "70",
                Type = SubdivisionTypes.Province,
                Name = "Ratchaburi",
                LocalName = "Ratchaburi"
            },
            new()
            { 
                Code = "21",
                Type = SubdivisionTypes.Province,
                Name = "Rayong",
                LocalName = "Rayong"
            },
            new()
            { 
                Code = "45",
                Type = SubdivisionTypes.Province,
                Name = "Roi Et",
                LocalName = "Roi Et"
            },
            new()
            { 
                Code = "27",
                Type = SubdivisionTypes.Province,
                Name = "Sa Kaeo",
                LocalName = "Sa Kaeo"
            },
            new()
            { 
                Code = "47",
                Type = SubdivisionTypes.Province,
                Name = "Sakon Nakhon",
                LocalName = "Sakon Nakhon"
            },
            new()
            { 
                Code = "11",
                Type = SubdivisionTypes.Province,
                Name = "Samut Prakan",
                LocalName = "Samut Prakan"
            },
            new()
            { 
                Code = "74",
                Type = SubdivisionTypes.Province,
                Name = "Samut Sakhon",
                LocalName = "Samut Sakhon"
            },
            new()
            { 
                Code = "75",
                Type = SubdivisionTypes.Province,
                Name = "Samut Songkhram",
                LocalName = "Samut Songkhram"
            },
            new()
            { 
                Code = "19",
                Type = SubdivisionTypes.Province,
                Name = "Saraburi",
                LocalName = "Saraburi"
            },
            new()
            { 
                Code = "91",
                Type = SubdivisionTypes.Province,
                Name = "Satun",
                LocalName = "Satun"
            },
            new()
            { 
                Code = "33",
                Type = SubdivisionTypes.Province,
                Name = "Si Sa Ket",
                LocalName = "Si Sa Ket"
            },
            new()
            { 
                Code = "17",
                Type = SubdivisionTypes.Province,
                Name = "Sing Buri",
                LocalName = "Sing Buri"
            },
            new()
            { 
                Code = "90",
                Type = SubdivisionTypes.Province,
                Name = "Songkhla",
                LocalName = "Songkhla"
            },
            new()
            { 
                Code = "64",
                Type = SubdivisionTypes.Province,
                Name = "Sukhothai",
                LocalName = "Sukhothai"
            },
            new()
            { 
                Code = "72",
                Type = SubdivisionTypes.Province,
                Name = "Suphan Buri",
                LocalName = "Suphan Buri"
            },
            new()
            { 
                Code = "84",
                Type = SubdivisionTypes.Province,
                Name = "Surat Thani",
                LocalName = "Surat Thani"
            },
            new()
            { 
                Code = "32",
                Type = SubdivisionTypes.Province,
                Name = "Surin",
                LocalName = "Surin"
            },
            new()
            { 
                Code = "63",
                Type = SubdivisionTypes.Province,
                Name = "Tak",
                LocalName = "Tak"
            },
            new()
            { 
                Code = "92",
                Type = SubdivisionTypes.Province,
                Name = "Trang",
                LocalName = "Trang"
            },
            new()
            { 
                Code = "23",
                Type = SubdivisionTypes.Province,
                Name = "Trat",
                LocalName = "Trat"
            },
            new()
            { 
                Code = "34",
                Type = SubdivisionTypes.Province,
                Name = "Ubon Ratchathani",
                LocalName = "Ubon Ratchathani"
            },
            new()
            { 
                Code = "41",
                Type = SubdivisionTypes.Province,
                Name = "Udon Thani",
                LocalName = "Udon Thani"
            },
            new()
            { 
                Code = "61",
                Type = SubdivisionTypes.Province,
                Name = "Uthai Thani",
                LocalName = "Uthai Thani"
            },
            new()
            { 
                Code = "53",
                Type = SubdivisionTypes.Province,
                Name = "Uttaradit",
                LocalName = "Uttaradit"
            },
            new()
            { 
                Code = "95",
                Type = SubdivisionTypes.Province,
                Name = "Yala",
                LocalName = "Yala"
            },
            new()
            { 
                Code = "35",
                Type = SubdivisionTypes.Province,
                Name = "Yasothon",
                LocalName = "Yasothon"
            }

        ]);
    }
}
