using AngryMonkey.Cloud.Geography;
namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    private static void FillInSubdivisionsTR()
    {
        AddSubdivisions("TR",
        [
            new()
            { 
                Code = "1",
                Type = SubdivisionTypes.Province,
                Name = "Adana",
                LocalName = "Adana"
            },
            new()
            { 
                Code = "2",
                Type = SubdivisionTypes.Province,
                Name = "Adiyaman",
                LocalName = "Adiyaman"
            },
            new()
            { 
                Code = "3",
                Type = SubdivisionTypes.Province,
                Name = "Afyonkarahisar",
                LocalName = "Afyonkarahisar"
            },
            new()
            { 
                Code = "4",
                Type = SubdivisionTypes.Province,
                Name = "Agri",
                LocalName = "Agri"
            },
            new()
            { 
                Code = "68",
                Type = SubdivisionTypes.Province,
                Name = "Aksaray",
                LocalName = "Aksaray"
            },
            new()
            { 
                Code = "5",
                Type = SubdivisionTypes.Province,
                Name = "Amasya",
                LocalName = "Amasya"
            },
            new()
            { 
                Code = "6",
                Type = SubdivisionTypes.Province,
                Name = "Ankara",
                LocalName = "Ankara"
            },
            new()
            { 
                Code = "7",
                Type = SubdivisionTypes.Province,
                Name = "Antalya",
                LocalName = "Antalya"
            },
            new()
            { 
                Code = "75",
                Type = SubdivisionTypes.Province,
                Name = "Ardahan",
                LocalName = "Ardahan"
            },
            new()
            { 
                Code = "8",
                Type = SubdivisionTypes.Province,
                Name = "Artvin",
                LocalName = "Artvin"
            },
            new()
            { 
                Code = "9",
                Type = SubdivisionTypes.Province,
                Name = "Aydin",
                LocalName = "Aydin"
            },
            new()
            { 
                Code = "10",
                Type = SubdivisionTypes.Province,
                Name = "Balikesir",
                LocalName = "Balikesir"
            },
            new()
            { 
                Code = "74",
                Type = SubdivisionTypes.Province,
                Name = "Bartin",
                LocalName = "Bartin"
            },
            new()
            { 
                Code = "72",
                Type = SubdivisionTypes.Province,
                Name = "Batman",
                LocalName = "Batman"
            },
            new()
            { 
                Code = "69",
                Type = SubdivisionTypes.Province,
                Name = "Bayburt",
                LocalName = "Bayburt"
            },
            new()
            { 
                Code = "11",
                Type = SubdivisionTypes.Province,
                Name = "Bilecik",
                LocalName = "Bilecik"
            },
            new()
            { 
                Code = "12",
                Type = SubdivisionTypes.Province,
                Name = "Bingöl",
                LocalName = "Bingöl"
            },
            new()
            { 
                Code = "13",
                Type = SubdivisionTypes.Province,
                Name = "Bitlis",
                LocalName = "Bitlis"
            },
            new()
            { 
                Code = "14",
                Type = SubdivisionTypes.Province,
                Name = "Bolu",
                LocalName = "Bolu"
            },
            new()
            { 
                Code = "15",
                Type = SubdivisionTypes.Province,
                Name = "Burdur",
                LocalName = "Burdur"
            },
            new()
            { 
                Code = "16",
                Type = SubdivisionTypes.Province,
                Name = "Bursa",
                LocalName = "Bursa"
            },
            new()
            { 
                Code = "17",
                Type = SubdivisionTypes.Province,
                Name = "Canakkale",
                LocalName = "Canakkale"
            },
            new()
            { 
                Code = "18",
                Type = SubdivisionTypes.Province,
                Name = "Çankiri",
                LocalName = "Çankiri"
            },
            new()
            { 
                Code = "19",
                Type = SubdivisionTypes.Province,
                Name = "Corum",
                LocalName = "Corum"
            },
            new()
            { 
                Code = "20",
                Type = SubdivisionTypes.Province,
                Name = "Denizli",
                LocalName = "Denizli"
            },
            new()
            { 
                Code = "21",
                Type = SubdivisionTypes.Province,
                Name = "Diyarbakir",
                LocalName = "Diyarbakir"
            },
            new()
            { 
                Code = "81",
                Type = SubdivisionTypes.Province,
                Name = "Düzce",
                LocalName = "Düzce"
            },
            new()
            { 
                Code = "22",
                Type = SubdivisionTypes.Province,
                Name = "Edirne",
                LocalName = "Edirne"
            },
            new()
            { 
                Code = "23",
                Type = SubdivisionTypes.Province,
                Name = "Elazig",
                LocalName = "Elazig"
            },
            new()
            { 
                Code = "24",
                Type = SubdivisionTypes.Province,
                Name = "Erzincan",
                LocalName = "Erzincan"
            },
            new()
            { 
                Code = "25",
                Type = SubdivisionTypes.Province,
                Name = "Erzurum",
                LocalName = "Erzurum"
            },
            new()
            { 
                Code = "26",
                Type = SubdivisionTypes.Province,
                Name = "Eskisehir",
                LocalName = "Eskisehir"
            },
            new()
            { 
                Code = "27",
                Type = SubdivisionTypes.Province,
                Name = "Gaziantep",
                LocalName = "Gaziantep"
            },
            new()
            { 
                Code = "28",
                Type = SubdivisionTypes.Province,
                Name = "Giresun",
                LocalName = "Giresun"
            },
            new()
            { 
                Code = "29",
                Type = SubdivisionTypes.Province,
                Name = "Gümüshane",
                LocalName = "Gümüshane"
            },
            new()
            { 
                Code = "30",
                Type = SubdivisionTypes.Province,
                Name = "Hakkari",
                LocalName = "Hakkari"
            },
            new()
            { 
                Code = "31",
                Type = SubdivisionTypes.Province,
                Name = "Hatay",
                LocalName = "Hatay"
            },
            new()
            { 
                Code = "76",
                Type = SubdivisionTypes.Province,
                Name = "Igdir",
                LocalName = "Igdir"
            },
            new()
            { 
                Code = "32",
                Type = SubdivisionTypes.Province,
                Name = "Isparta",
                LocalName = "Isparta"
            },
            new()
            { 
                Code = "34",
                Type = SubdivisionTypes.Province,
                Name = "Istanbul",
                LocalName = "Istanbul"
            },
            new()
            { 
                Code = "35",
                Type = SubdivisionTypes.Province,
                Name = "Izmir",
                LocalName = "Izmir"
            },
            new()
            { 
                Code = "46",
                Type = SubdivisionTypes.Province,
                Name = "Kahramanmaras",
                LocalName = "Kahramanmaras"
            },
            new()
            { 
                Code = "78",
                Type = SubdivisionTypes.Province,
                Name = "Karabuk",
                LocalName = "Karabuk"
            },
            new()
            { 
                Code = "70",
                Type = SubdivisionTypes.Province,
                Name = "Karaman",
                LocalName = "Karaman"
            },
            new()
            { 
                Code = "36",
                Type = SubdivisionTypes.Province,
                Name = "Kars",
                LocalName = "Kars"
            },
            new()
            { 
                Code = "37",
                Type = SubdivisionTypes.Province,
                Name = "Kastamonu",
                LocalName = "Kastamonu"
            },
            new()
            { 
                Code = "38",
                Type = SubdivisionTypes.Province,
                Name = "Kayseri",
                LocalName = "Kayseri"
            },
            new()
            { 
                Code = "79",
                Type = SubdivisionTypes.Province,
                Name = "Kilis",
                LocalName = "Kilis"
            },
            new()
            { 
                Code = "71",
                Type = SubdivisionTypes.Province,
                Name = "Kirikkale",
                LocalName = "Kirikkale"
            },
            new()
            { 
                Code = "39",
                Type = SubdivisionTypes.Province,
                Name = "Kirklareli",
                LocalName = "Kirklareli"
            },
            new()
            { 
                Code = "40",
                Type = SubdivisionTypes.Province,
                Name = "Kirsehir",
                LocalName = "Kirsehir"
            },
            new()
            { 
                Code = "41",
                Type = SubdivisionTypes.Province,
                Name = "Kocaeli",
                LocalName = "Kocaeli"
            },
            new()
            { 
                Code = "42",
                Type = SubdivisionTypes.Province,
                Name = "Konya",
                LocalName = "Konya"
            },
            new()
            { 
                Code = "43",
                Type = SubdivisionTypes.Province,
                Name = "Kütahya",
                LocalName = "Kütahya"
            },
            new()
            { 
                Code = "44",
                Type = SubdivisionTypes.Province,
                Name = "Malatya",
                LocalName = "Malatya"
            },
            new()
            { 
                Code = "45",
                Type = SubdivisionTypes.Province,
                Name = "Manisa",
                LocalName = "Manisa"
            },
            new()
            { 
                Code = "47",
                Type = SubdivisionTypes.Province,
                Name = "Mardin",
                LocalName = "Mardin"
            },
            new()
            { 
                Code = "33",
                Type = SubdivisionTypes.Province,
                Name = "Mersin",
                LocalName = "Mersin"
            },
            new()
            { 
                Code = "48",
                Type = SubdivisionTypes.Province,
                Name = "Mugla",
                LocalName = "Mugla"
            },
            new()
            { 
                Code = "49",
                Type = SubdivisionTypes.Province,
                Name = "Mus",
                LocalName = "Mus"
            },
            new()
            { 
                Code = "50",
                Type = SubdivisionTypes.Province,
                Name = "Nevsehir",
                LocalName = "Nevsehir"
            },
            new()
            { 
                Code = "51",
                Type = SubdivisionTypes.Province,
                Name = "Nigde",
                LocalName = "Nigde"
            },
            new()
            { 
                Code = "52",
                Type = SubdivisionTypes.Province,
                Name = "Ordu",
                LocalName = "Ordu"
            },
            new()
            { 
                Code = "80",
                Type = SubdivisionTypes.Province,
                Name = "Osmaniye",
                LocalName = "Osmaniye"
            },
            new()
            { 
                Code = "53",
                Type = SubdivisionTypes.Province,
                Name = "Rize",
                LocalName = "Rize"
            },
            new()
            { 
                Code = "54",
                Type = SubdivisionTypes.Province,
                Name = "Sakarya",
                LocalName = "Sakarya"
            },
            new()
            { 
                Code = "55",
                Type = SubdivisionTypes.Province,
                Name = "Samsun",
                LocalName = "Samsun"
            },
            new()
            { 
                Code = "63",
                Type = SubdivisionTypes.Province,
                Name = "Sanliurfa",
                LocalName = "Sanliurfa"
            },
            new()
            { 
                Code = "56",
                Type = SubdivisionTypes.Province,
                Name = "Siirt",
                LocalName = "Siirt"
            },
            new()
            { 
                Code = "57",
                Type = SubdivisionTypes.Province,
                Name = "Sinop",
                LocalName = "Sinop"
            },
            new()
            { 
                Code = "73",
                Type = SubdivisionTypes.Province,
                Name = "Sirnak",
                LocalName = "Sirnak"
            },
            new()
            { 
                Code = "58",
                Type = SubdivisionTypes.Province,
                Name = "Sivas",
                LocalName = "Sivas"
            },
            new()
            { 
                Code = "59",
                Type = SubdivisionTypes.Province,
                Name = "Tekirdag",
                LocalName = "Tekirdag"
            },
            new()
            { 
                Code = "60",
                Type = SubdivisionTypes.Province,
                Name = "Tokat",
                LocalName = "Tokat"
            },
            new()
            { 
                Code = "61",
                Type = SubdivisionTypes.Province,
                Name = "Trabzon",
                LocalName = "Trabzon"
            },
            new()
            { 
                Code = "62",
                Type = SubdivisionTypes.Province,
                Name = "Tunceli",
                LocalName = "Tunceli"
            },
            new()
            { 
                Code = "64",
                Type = SubdivisionTypes.Province,
                Name = "Usak",
                LocalName = "Usak"
            },
            new()
            { 
                Code = "65",
                Type = SubdivisionTypes.Province,
                Name = "Van",
                LocalName = "Van"
            },
            new()
            { 
                Code = "77",
                Type = SubdivisionTypes.Province,
                Name = "Yalova",
                LocalName = "Yalova"
            },
            new()
            { 
                Code = "66",
                Type = SubdivisionTypes.Province,
                Name = "Yozgat",
                LocalName = "Yozgat"
            },
            new()
            { 
                Code = "67",
                Type = SubdivisionTypes.Province,
                Name = "Zonguldak",
                LocalName = "Zonguldak"
            }

        ]);
    }
}
