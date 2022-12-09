using AngryMonkey.Cloud.Geography;
namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    private static void FillInSubdivisionsTR()
    {
        AddSubdivisions("TR", new List<Subdivision>()
        {
            new()
            { 
                Code = "1",
                Type = "Province",
                Name = "Adana",
                LocalName = "Adana"
            },
            new()
            { 
                Code = "2",
                Type = "Province",
                Name = "Adiyaman",
                LocalName = "Adiyaman"
            },
            new()
            { 
                Code = "3",
                Type = "Province",
                Name = "Afyonkarahisar",
                LocalName = "Afyonkarahisar"
            },
            new()
            { 
                Code = "4",
                Type = "Province",
                Name = "Agri",
                LocalName = "Agri"
            },
            new()
            { 
                Code = "68",
                Type = "Province",
                Name = "Aksaray",
                LocalName = "Aksaray"
            },
            new()
            { 
                Code = "5",
                Type = "Province",
                Name = "Amasya",
                LocalName = "Amasya"
            },
            new()
            { 
                Code = "6",
                Type = "Province",
                Name = "Ankara",
                LocalName = "Ankara"
            },
            new()
            { 
                Code = "7",
                Type = "Province",
                Name = "Antalya",
                LocalName = "Antalya"
            },
            new()
            { 
                Code = "75",
                Type = "Province",
                Name = "Ardahan",
                LocalName = "Ardahan"
            },
            new()
            { 
                Code = "8",
                Type = "Province",
                Name = "Artvin",
                LocalName = "Artvin"
            },
            new()
            { 
                Code = "9",
                Type = "Province",
                Name = "Aydin",
                LocalName = "Aydin"
            },
            new()
            { 
                Code = "10",
                Type = "Province",
                Name = "Balikesir",
                LocalName = "Balikesir"
            },
            new()
            { 
                Code = "74",
                Type = "Province",
                Name = "Bartin",
                LocalName = "Bartin"
            },
            new()
            { 
                Code = "72",
                Type = "Province",
                Name = "Batman",
                LocalName = "Batman"
            },
            new()
            { 
                Code = "69",
                Type = "Province",
                Name = "Bayburt",
                LocalName = "Bayburt"
            },
            new()
            { 
                Code = "11",
                Type = "Province",
                Name = "Bilecik",
                LocalName = "Bilecik"
            },
            new()
            { 
                Code = "12",
                Type = "Province",
                Name = "Bingöl",
                LocalName = "Bingöl"
            },
            new()
            { 
                Code = "13",
                Type = "Province",
                Name = "Bitlis",
                LocalName = "Bitlis"
            },
            new()
            { 
                Code = "14",
                Type = "Province",
                Name = "Bolu",
                LocalName = "Bolu"
            },
            new()
            { 
                Code = "15",
                Type = "Province",
                Name = "Burdur",
                LocalName = "Burdur"
            },
            new()
            { 
                Code = "16",
                Type = "Province",
                Name = "Bursa",
                LocalName = "Bursa"
            },
            new()
            { 
                Code = "17",
                Type = "Province",
                Name = "Canakkale",
                LocalName = "Canakkale"
            },
            new()
            { 
                Code = "18",
                Type = "Province",
                Name = "Çankiri",
                LocalName = "Çankiri"
            },
            new()
            { 
                Code = "19",
                Type = "Province",
                Name = "Corum",
                LocalName = "Corum"
            },
            new()
            { 
                Code = "20",
                Type = "Province",
                Name = "Denizli",
                LocalName = "Denizli"
            },
            new()
            { 
                Code = "21",
                Type = "Province",
                Name = "Diyarbakir",
                LocalName = "Diyarbakir"
            },
            new()
            { 
                Code = "81",
                Type = "Province",
                Name = "Düzce",
                LocalName = "Düzce"
            },
            new()
            { 
                Code = "22",
                Type = "Province",
                Name = "Edirne",
                LocalName = "Edirne"
            },
            new()
            { 
                Code = "23",
                Type = "Province",
                Name = "Elazig",
                LocalName = "Elazig"
            },
            new()
            { 
                Code = "24",
                Type = "Province",
                Name = "Erzincan",
                LocalName = "Erzincan"
            },
            new()
            { 
                Code = "25",
                Type = "Province",
                Name = "Erzurum",
                LocalName = "Erzurum"
            },
            new()
            { 
                Code = "26",
                Type = "Province",
                Name = "Eskisehir",
                LocalName = "Eskisehir"
            },
            new()
            { 
                Code = "27",
                Type = "Province",
                Name = "Gaziantep",
                LocalName = "Gaziantep"
            },
            new()
            { 
                Code = "28",
                Type = "Province",
                Name = "Giresun",
                LocalName = "Giresun"
            },
            new()
            { 
                Code = "29",
                Type = "Province",
                Name = "Gümüshane",
                LocalName = "Gümüshane"
            },
            new()
            { 
                Code = "30",
                Type = "Province",
                Name = "Hakkari",
                LocalName = "Hakkari"
            },
            new()
            { 
                Code = "31",
                Type = "Province",
                Name = "Hatay",
                LocalName = "Hatay"
            },
            new()
            { 
                Code = "76",
                Type = "Province",
                Name = "Igdir",
                LocalName = "Igdir"
            },
            new()
            { 
                Code = "32",
                Type = "Province",
                Name = "Isparta",
                LocalName = "Isparta"
            },
            new()
            { 
                Code = "34",
                Type = "Province",
                Name = "Istanbul",
                LocalName = "Istanbul"
            },
            new()
            { 
                Code = "35",
                Type = "Province",
                Name = "Izmir",
                LocalName = "Izmir"
            },
            new()
            { 
                Code = "46",
                Type = "Province",
                Name = "Kahramanmaras",
                LocalName = "Kahramanmaras"
            },
            new()
            { 
                Code = "78",
                Type = "Province",
                Name = "Karabuk",
                LocalName = "Karabuk"
            },
            new()
            { 
                Code = "70",
                Type = "Province",
                Name = "Karaman",
                LocalName = "Karaman"
            },
            new()
            { 
                Code = "36",
                Type = "Province",
                Name = "Kars",
                LocalName = "Kars"
            },
            new()
            { 
                Code = "37",
                Type = "Province",
                Name = "Kastamonu",
                LocalName = "Kastamonu"
            },
            new()
            { 
                Code = "38",
                Type = "Province",
                Name = "Kayseri",
                LocalName = "Kayseri"
            },
            new()
            { 
                Code = "79",
                Type = "Province",
                Name = "Kilis",
                LocalName = "Kilis"
            },
            new()
            { 
                Code = "71",
                Type = "Province",
                Name = "Kirikkale",
                LocalName = "Kirikkale"
            },
            new()
            { 
                Code = "39",
                Type = "Province",
                Name = "Kirklareli",
                LocalName = "Kirklareli"
            },
            new()
            { 
                Code = "40",
                Type = "Province",
                Name = "Kirsehir",
                LocalName = "Kirsehir"
            },
            new()
            { 
                Code = "41",
                Type = "Province",
                Name = "Kocaeli",
                LocalName = "Kocaeli"
            },
            new()
            { 
                Code = "42",
                Type = "Province",
                Name = "Konya",
                LocalName = "Konya"
            },
            new()
            { 
                Code = "43",
                Type = "Province",
                Name = "Kütahya",
                LocalName = "Kütahya"
            },
            new()
            { 
                Code = "44",
                Type = "Province",
                Name = "Malatya",
                LocalName = "Malatya"
            },
            new()
            { 
                Code = "45",
                Type = "Province",
                Name = "Manisa",
                LocalName = "Manisa"
            },
            new()
            { 
                Code = "47",
                Type = "Province",
                Name = "Mardin",
                LocalName = "Mardin"
            },
            new()
            { 
                Code = "33",
                Type = "Province",
                Name = "Mersin",
                LocalName = "Mersin"
            },
            new()
            { 
                Code = "48",
                Type = "Province",
                Name = "Mugla",
                LocalName = "Mugla"
            },
            new()
            { 
                Code = "49",
                Type = "Province",
                Name = "Mus",
                LocalName = "Mus"
            },
            new()
            { 
                Code = "50",
                Type = "Province",
                Name = "Nevsehir",
                LocalName = "Nevsehir"
            },
            new()
            { 
                Code = "51",
                Type = "Province",
                Name = "Nigde",
                LocalName = "Nigde"
            },
            new()
            { 
                Code = "52",
                Type = "Province",
                Name = "Ordu",
                LocalName = "Ordu"
            },
            new()
            { 
                Code = "80",
                Type = "Province",
                Name = "Osmaniye",
                LocalName = "Osmaniye"
            },
            new()
            { 
                Code = "53",
                Type = "Province",
                Name = "Rize",
                LocalName = "Rize"
            },
            new()
            { 
                Code = "54",
                Type = "Province",
                Name = "Sakarya",
                LocalName = "Sakarya"
            },
            new()
            { 
                Code = "55",
                Type = "Province",
                Name = "Samsun",
                LocalName = "Samsun"
            },
            new()
            { 
                Code = "63",
                Type = "Province",
                Name = "Sanliurfa",
                LocalName = "Sanliurfa"
            },
            new()
            { 
                Code = "56",
                Type = "Province",
                Name = "Siirt",
                LocalName = "Siirt"
            },
            new()
            { 
                Code = "57",
                Type = "Province",
                Name = "Sinop",
                LocalName = "Sinop"
            },
            new()
            { 
                Code = "73",
                Type = "Province",
                Name = "Sirnak",
                LocalName = "Sirnak"
            },
            new()
            { 
                Code = "58",
                Type = "Province",
                Name = "Sivas",
                LocalName = "Sivas"
            },
            new()
            { 
                Code = "59",
                Type = "Province",
                Name = "Tekirdag",
                LocalName = "Tekirdag"
            },
            new()
            { 
                Code = "60",
                Type = "Province",
                Name = "Tokat",
                LocalName = "Tokat"
            },
            new()
            { 
                Code = "61",
                Type = "Province",
                Name = "Trabzon",
                LocalName = "Trabzon"
            },
            new()
            { 
                Code = "62",
                Type = "Province",
                Name = "Tunceli",
                LocalName = "Tunceli"
            },
            new()
            { 
                Code = "64",
                Type = "Province",
                Name = "Usak",
                LocalName = "Usak"
            },
            new()
            { 
                Code = "65",
                Type = "Province",
                Name = "Van",
                LocalName = "Van"
            },
            new()
            { 
                Code = "77",
                Type = "Province",
                Name = "Yalova",
                LocalName = "Yalova"
            },
            new()
            { 
                Code = "66",
                Type = "Province",
                Name = "Yozgat",
                LocalName = "Yozgat"
            },
            new()
            { 
                Code = "67",
                Type = "Province",
                Name = "Zonguldak",
                LocalName = "Zonguldak"
            }

        });
    }
}
