using AngryMonkey.Cloud.Geography;
namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    private static void FillInSubdivisionsSI()
    {
        AddSubdivisions("SI",
        [
            new()
            { 
                Code = "190",
                Type = SubdivisionTypes.Municipality,
                Name = "alec",
                LocalName = "alec"
            },
            new()
            { 
                Code = "33",
                Type = SubdivisionTypes.Municipality,
                Name = "alovci",
                LocalName = "alovci"
            },
            new()
            { 
                Code = "146",
                Type = SubdivisionTypes.Municipality,
                Name = "elezniki",
                LocalName = "elezniki"
            },
            new()
            { 
                Code = "183",
                Type = SubdivisionTypes.Municipality,
                Name = "empeter-Vrtojba",
                LocalName = "empeter-Vrtojba"
            },
            new()
            { 
                Code = "117",
                Type = SubdivisionTypes.Municipality,
                Name = "encur",
                LocalName = "encur"
            },
            new()
            { 
                Code = "118",
                Type = SubdivisionTypes.Municipality,
                Name = "entilj",
                LocalName = "entilj"
            },
            new()
            { 
                Code = "119",
                Type = SubdivisionTypes.Municipality,
                Name = "entjernej",
                LocalName = "entjernej"
            },
            new()
            { 
                Code = "120",
                Type = SubdivisionTypes.Municipality,
                Name = "entjur",
                LocalName = "entjur"
            },
            new()
            { 
                Code = "211",
                Type = SubdivisionTypes.Municipality,
                Name = "entrupert",
                LocalName = "entrupert"
            },
            new()
            { 
                Code = "191",
                Type = SubdivisionTypes.Municipality,
                Name = "etale",
                LocalName = "etale"
            },
            new()
            { 
                Code = "147",
                Type = SubdivisionTypes.Municipality,
                Name = "iri",
                LocalName = "iri"
            },
            new()
            { 
                Code = "192",
                Type = SubdivisionTypes.Municipality,
                Name = "irovnica",
                LocalName = "irovnica"
            },
            new()
            { 
                Code = "121",
                Type = SubdivisionTypes.Municipality,
                Name = "kocjan",
                LocalName = "kocjan"
            },
            new()
            { 
                Code = "122",
                Type = SubdivisionTypes.Municipality,
                Name = "kofja Loka",
                LocalName = "kofja Loka"
            },
            new()
            { 
                Code = "123",
                Type = SubdivisionTypes.Municipality,
                Name = "kofljica",
                LocalName = "kofljica"
            },
            new()
            { 
                Code = "124",
                Type = SubdivisionTypes.Municipality,
                Name = "marje pri Jelah",
                LocalName = "marje pri Jelah"
            },
            new()
            { 
                Code = "206",
                Type = SubdivisionTypes.Municipality,
                Name = "marjeke Toplice",
                LocalName = "marjeke Toplice"
            },
            new()
            { 
                Code = "125",
                Type = SubdivisionTypes.Municipality,
                Name = "martno ob Paki",
                LocalName = "martno ob Paki"
            },
            new()
            { 
                Code = "194",
                Type = SubdivisionTypes.Municipality,
                Name = "martno pri Litiji",
                LocalName = "martno pri Litiji"
            },
            new()
            { 
                Code = "126",
                Type = SubdivisionTypes.Municipality,
                Name = "otanj",
                LocalName = "otanj"
            },
            new()
            { 
                Code = "127",
                Type = SubdivisionTypes.Municipality,
                Name = "tore",
                LocalName = "tore"
            },
            new()
            { 
                Code = "193",
                Type = SubdivisionTypes.Municipality,
                Name = "uemberk",
                LocalName = "uemberk"
            },
            new()
            { 
                Code = "1",
                Type = SubdivisionTypes.Municipality,
                Name = "Ajdovcina",
                LocalName = "Ajdovcina"
            },
            new()
            { 
                Code = "213",
                Type = SubdivisionTypes.Municipality,
                Name = "Ankaran",
                LocalName = "Ankaran"
            },
            new()
            { 
                Code = "195",
                Type = SubdivisionTypes.Municipality,
                Name = "Apace",
                LocalName = "Apace"
            },
            new()
            { 
                Code = "2",
                Type = SubdivisionTypes.Municipality,
                Name = "Beltinci",
                LocalName = "Beltinci"
            },
            new()
            { 
                Code = "148",
                Type = SubdivisionTypes.Municipality,
                Name = "Benedikt",
                LocalName = "Benedikt"
            },
            new()
            { 
                Code = "149",
                Type = SubdivisionTypes.Municipality,
                Name = "Bistrica ob Sotli",
                LocalName = "Bistrica ob Sotli"
            },
            new()
            { 
                Code = "3",
                Type = SubdivisionTypes.Municipality,
                Name = "Bled",
                LocalName = "Bled"
            },
            new()
            { 
                Code = "150",
                Type = SubdivisionTypes.Municipality,
                Name = "Bloke",
                LocalName = "Bloke"
            },
            new()
            { 
                Code = "4",
                Type = SubdivisionTypes.Municipality,
                Name = "Bohinj",
                LocalName = "Bohinj"
            },
            new()
            { 
                Code = "5",
                Type = SubdivisionTypes.Municipality,
                Name = "Borovnica",
                LocalName = "Borovnica"
            },
            new()
            { 
                Code = "6",
                Type = SubdivisionTypes.Municipality,
                Name = "Bovec",
                LocalName = "Bovec"
            },
            new()
            { 
                Code = "151",
                Type = SubdivisionTypes.Municipality,
                Name = "Braslovce",
                LocalName = "Braslovce"
            },
            new()
            { 
                Code = "7",
                Type = SubdivisionTypes.Municipality,
                Name = "Brda",
                LocalName = "Brda"
            },
            new()
            { 
                Code = "9",
                Type = SubdivisionTypes.Municipality,
                Name = "Breice",
                LocalName = "Breice"
            },
            new()
            { 
                Code = "8",
                Type = SubdivisionTypes.Municipality,
                Name = "Brezovica",
                LocalName = "Brezovica"
            },
            new()
            { 
                Code = "152",
                Type = SubdivisionTypes.Municipality,
                Name = "Cankova",
                LocalName = "Cankova"
            },
            new()
            { 
                Code = "11",
                Type = SubdivisionTypes.Municipality,
                Name = "Celje",
                LocalName = "Celje"
            },
            new()
            { 
                Code = "12",
                Type = SubdivisionTypes.Municipality,
                Name = "Cerklje na Gorenjskem",
                LocalName = "Cerklje na Gorenjskem"
            },
            new()
            { 
                Code = "13",
                Type = SubdivisionTypes.Municipality,
                Name = "Cerknica",
                LocalName = "Cerknica"
            },
            new()
            { 
                Code = "14",
                Type = SubdivisionTypes.Municipality,
                Name = "Cerkno",
                LocalName = "Cerkno"
            },
            new()
            { 
                Code = "153",
                Type = SubdivisionTypes.Municipality,
                Name = "Cerkvenjak",
                LocalName = "Cerkvenjak"
            },
            new()
            { 
                Code = "196",
                Type = SubdivisionTypes.Municipality,
                Name = "Cirkulane",
                LocalName = "Cirkulane"
            },
            new()
            { 
                Code = "15",
                Type = SubdivisionTypes.Municipality,
                Name = "Crenovci",
                LocalName = "Crenovci"
            },
            new()
            { 
                Code = "16",
                Type = SubdivisionTypes.Municipality,
                Name = "Crna na Korokem",
                LocalName = "Crna na Korokem"
            },
            new()
            { 
                Code = "17",
                Type = SubdivisionTypes.Municipality,
                Name = "Crnomelj",
                LocalName = "Crnomelj"
            },
            new()
            { 
                Code = "18",
                Type = SubdivisionTypes.Municipality,
                Name = "Destrnik",
                LocalName = "Destrnik"
            },
            new()
            { 
                Code = "19",
                Type = SubdivisionTypes.Municipality,
                Name = "Divaca",
                LocalName = "Divaca"
            },
            new()
            { 
                Code = "154",
                Type = SubdivisionTypes.Municipality,
                Name = "Dobje",
                LocalName = "Dobje"
            },
            new()
            { 
                Code = "20",
                Type = SubdivisionTypes.Municipality,
                Name = "Dobrepolje",
                LocalName = "Dobrepolje"
            },
            new()
            { 
                Code = "155",
                Type = SubdivisionTypes.Municipality,
                Name = "Dobrna",
                LocalName = "Dobrna"
            },
            new()
            { 
                Code = "21",
                Type = SubdivisionTypes.Municipality,
                Name = "Dobrova-Polhov Gradec",
                LocalName = "Dobrova-Polhov Gradec"
            },
            new()
            { 
                Code = "156",
                Type = SubdivisionTypes.Municipality,
                Name = "Dobrovnik",
                LocalName = "Dobrovnik"
            },
            new()
            { 
                Code = "22",
                Type = SubdivisionTypes.Municipality,
                Name = "Dol pri Ljubljani",
                LocalName = "Dol pri Ljubljani"
            },
            new()
            { 
                Code = "157",
                Type = SubdivisionTypes.Municipality,
                Name = "Dolenjske Toplice",
                LocalName = "Dolenjske Toplice"
            },
            new()
            { 
                Code = "23",
                Type = SubdivisionTypes.Municipality,
                Name = "Domale",
                LocalName = "Domale"
            },
            new()
            { 
                Code = "24",
                Type = SubdivisionTypes.Municipality,
                Name = "Dornava",
                LocalName = "Dornava"
            },
            new()
            { 
                Code = "25",
                Type = SubdivisionTypes.Municipality,
                Name = "Dravograd",
                LocalName = "Dravograd"
            },
            new()
            { 
                Code = "26",
                Type = SubdivisionTypes.Municipality,
                Name = "Duplek",
                LocalName = "Duplek"
            },
            new()
            { 
                Code = "27",
                Type = SubdivisionTypes.Municipality,
                Name = "Gorenja vas-Poljane",
                LocalName = "Gorenja vas-Poljane"
            },
            new()
            { 
                Code = "28",
                Type = SubdivisionTypes.Municipality,
                Name = "Gorinica",
                LocalName = "Gorinica"
            },
            new()
            { 
                Code = "207",
                Type = SubdivisionTypes.Municipality,
                Name = "Gorje",
                LocalName = "Gorje"
            },
            new()
            { 
                Code = "29",
                Type = SubdivisionTypes.Municipality,
                Name = "Gornja Radgona",
                LocalName = "Gornja Radgona"
            },
            new()
            { 
                Code = "30",
                Type = SubdivisionTypes.Municipality,
                Name = "Gornji Grad",
                LocalName = "Gornji Grad"
            },
            new()
            { 
                Code = "31",
                Type = SubdivisionTypes.Municipality,
                Name = "Gornji Petrovci",
                LocalName = "Gornji Petrovci"
            },
            new()
            { 
                Code = "158",
                Type = SubdivisionTypes.Municipality,
                Name = "Grad",
                LocalName = "Grad"
            },
            new()
            { 
                Code = "32",
                Type = SubdivisionTypes.Municipality,
                Name = "Grosuplje",
                LocalName = "Grosuplje"
            },
            new()
            { 
                Code = "159",
                Type = SubdivisionTypes.Municipality,
                Name = "Hajdina",
                LocalName = "Hajdina"
            },
            new()
            { 
                Code = "160",
                Type = SubdivisionTypes.Municipality,
                Name = "Hoce-Slivnica",
                LocalName = "Hoce-Slivnica"
            },
            new()
            { 
                Code = "161",
                Type = SubdivisionTypes.Municipality,
                Name = "Hodo",
                LocalName = "Hodo"
            },
            new()
            { 
                Code = "162",
                Type = SubdivisionTypes.Municipality,
                Name = "Horjul",
                LocalName = "Horjul"
            },
            new()
            { 
                Code = "34",
                Type = SubdivisionTypes.Municipality,
                Name = "Hrastnik",
                LocalName = "Hrastnik"
            },
            new()
            { 
                Code = "35",
                Type = SubdivisionTypes.Municipality,
                Name = "Hrpelje-Kozina",
                LocalName = "Hrpelje-Kozina"
            },
            new()
            { 
                Code = "36",
                Type = SubdivisionTypes.Municipality,
                Name = "Idrija",
                LocalName = "Idrija"
            },
            new()
            { 
                Code = "37",
                Type = SubdivisionTypes.Municipality,
                Name = "Ig",
                LocalName = "Ig"
            },
            new()
            { 
                Code = "38",
                Type = SubdivisionTypes.Municipality,
                Name = "Ilirska Bistrica",
                LocalName = "Ilirska Bistrica"
            },
            new()
            { 
                Code = "39",
                Type = SubdivisionTypes.Municipality,
                Name = "Ivancna Gorica",
                LocalName = "Ivancna Gorica"
            },
            new()
            { 
                Code = "40",
                Type = SubdivisionTypes.Municipality,
                Name = "Izola",
                LocalName = "Izola"
            },
            new()
            { 
                Code = "41",
                Type = SubdivisionTypes.Municipality,
                Name = "Jesenice",
                LocalName = "Jesenice"
            },
            new()
            { 
                Code = "163",
                Type = SubdivisionTypes.Municipality,
                Name = "Jezersko",
                LocalName = "Jezersko"
            },
            new()
            { 
                Code = "42",
                Type = SubdivisionTypes.Municipality,
                Name = "Jurinci",
                LocalName = "Jurinci"
            },
            new()
            { 
                Code = "43",
                Type = SubdivisionTypes.Municipality,
                Name = "Kamnik",
                LocalName = "Kamnik"
            },
            new()
            { 
                Code = "44",
                Type = SubdivisionTypes.Municipality,
                Name = "Kanal",
                LocalName = "Kanal"
            },
            new()
            { 
                Code = "45",
                Type = SubdivisionTypes.Municipality,
                Name = "Kidricevo",
                LocalName = "Kidricevo"
            },
            new()
            { 
                Code = "46",
                Type = SubdivisionTypes.Municipality,
                Name = "Kobarid",
                LocalName = "Kobarid"
            },
            new()
            { 
                Code = "47",
                Type = SubdivisionTypes.Municipality,
                Name = "Kobilje",
                LocalName = "Kobilje"
            },
            new()
            { 
                Code = "48",
                Type = SubdivisionTypes.Municipality,
                Name = "Kocevje",
                LocalName = "Kocevje"
            },
            new()
            { 
                Code = "49",
                Type = SubdivisionTypes.Municipality,
                Name = "Komen",
                LocalName = "Komen"
            },
            new()
            { 
                Code = "164",
                Type = SubdivisionTypes.Municipality,
                Name = "Komenda",
                LocalName = "Komenda"
            },
            new()
            { 
                Code = "50",
                Type = SubdivisionTypes.Municipality,
                Name = "Koper",
                LocalName = "Koper"
            },
            new()
            { 
                Code = "197",
                Type = SubdivisionTypes.Municipality,
                Name = "Kosanjevica na Krki",
                LocalName = "Kosanjevica na Krki"
            },
            new()
            { 
                Code = "165",
                Type = SubdivisionTypes.Municipality,
                Name = "Kostel",
                LocalName = "Kostel"
            },
            new()
            { 
                Code = "51",
                Type = SubdivisionTypes.Municipality,
                Name = "Kozje",
                LocalName = "Kozje"
            },
            new()
            { 
                Code = "54",
                Type = SubdivisionTypes.Municipality,
                Name = "Krko",
                LocalName = "Krko"
            },
            new()
            { 
                Code = "52",
                Type = SubdivisionTypes.Municipality,
                Name = "Kranj",
                LocalName = "Kranj"
            },
            new()
            { 
                Code = "53",
                Type = SubdivisionTypes.Municipality,
                Name = "Kranjska Gora",
                LocalName = "Kranjska Gora"
            },
            new()
            { 
                Code = "166",
                Type = SubdivisionTypes.Municipality,
                Name = "Krievci",
                LocalName = "Krievci"
            },
            new()
            { 
                Code = "55",
                Type = SubdivisionTypes.Municipality,
                Name = "Kungota",
                LocalName = "Kungota"
            },
            new()
            { 
                Code = "56",
                Type = SubdivisionTypes.Municipality,
                Name = "Kuzma",
                LocalName = "Kuzma"
            },
            new()
            { 
                Code = "57",
                Type = SubdivisionTypes.Municipality,
                Name = "Lako",
                LocalName = "Lako"
            },
            new()
            { 
                Code = "58",
                Type = SubdivisionTypes.Municipality,
                Name = "Lenart",
                LocalName = "Lenart"
            },
            new()
            { 
                Code = "59",
                Type = SubdivisionTypes.Municipality,
                Name = "Lendava",
                LocalName = "Lendava"
            },
            new()
            { 
                Code = "60",
                Type = SubdivisionTypes.Municipality,
                Name = "Litija",
                LocalName = "Litija"
            },
            new()
            { 
                Code = "61",
                Type = SubdivisionTypes.Municipality,
                Name = "Ljubljana",
                LocalName = "Ljubljana"
            },
            new()
            { 
                Code = "62",
                Type = SubdivisionTypes.Municipality,
                Name = "Ljubno",
                LocalName = "Ljubno"
            },
            new()
            { 
                Code = "63",
                Type = SubdivisionTypes.Municipality,
                Name = "Ljutomer",
                LocalName = "Ljutomer"
            },
            new()
            { 
                Code = "65",
                Type = SubdivisionTypes.Municipality,
                Name = "Loka dolina",
                LocalName = "Loka dolina"
            },
            new()
            { 
                Code = "66",
                Type = SubdivisionTypes.Municipality,
                Name = "Loki Potok",
                LocalName = "Loki Potok"
            },
            new()
            { 
                Code = "64",
                Type = SubdivisionTypes.Municipality,
                Name = "Logatec",
                LocalName = "Logatec"
            },
            new()
            { 
                Code = "208",
                Type = SubdivisionTypes.Municipality,
                Name = "Log-Dragomer",
                LocalName = "Log-Dragomer"
            },
            new()
            { 
                Code = "167",
                Type = SubdivisionTypes.Municipality,
                Name = "Lovrenc na Pohorju",
                LocalName = "Lovrenc na Pohorju"
            },
            new()
            { 
                Code = "67",
                Type = SubdivisionTypes.Municipality,
                Name = "Luce",
                LocalName = "Luce"
            },
            new()
            { 
                Code = "68",
                Type = SubdivisionTypes.Municipality,
                Name = "Lukovica",
                LocalName = "Lukovica"
            },
            new()
            { 
                Code = "69",
                Type = SubdivisionTypes.Municipality,
                Name = "Majperk",
                LocalName = "Majperk"
            },
            new()
            { 
                Code = "198",
                Type = SubdivisionTypes.Municipality,
                Name = "Makole",
                LocalName = "Makole"
            },
            new()
            { 
                Code = "70",
                Type = SubdivisionTypes.Municipality,
                Name = "Maribor",
                LocalName = "Maribor"
            },
            new()
            { 
                Code = "168",
                Type = SubdivisionTypes.Municipality,
                Name = "Markovci",
                LocalName = "Markovci"
            },
            new()
            { 
                Code = "74",
                Type = SubdivisionTypes.Municipality,
                Name = "Meica",
                LocalName = "Meica"
            },
            new()
            { 
                Code = "71",
                Type = SubdivisionTypes.Municipality,
                Name = "Medvode",
                LocalName = "Medvode"
            },
            new()
            { 
                Code = "72",
                Type = SubdivisionTypes.Municipality,
                Name = "Menge",
                LocalName = "Menge"
            },
            new()
            { 
                Code = "73",
                Type = SubdivisionTypes.Municipality,
                Name = "Metlika",
                LocalName = "Metlika"
            },
            new()
            { 
                Code = "169",
                Type = SubdivisionTypes.Municipality,
                Name = "Miklav na Dravskem polju",
                LocalName = "Miklav na Dravskem polju"
            },
            new()
            { 
                Code = "75",
                Type = SubdivisionTypes.Municipality,
                Name = "Miren-Kostanjevica",
                LocalName = "Miren-Kostanjevica"
            },
            new()
            { 
                Code = "212",
                Type = SubdivisionTypes.Municipality,
                Name = "Mirna",
                LocalName = "Mirna"
            },
            new()
            { 
                Code = "170",
                Type = SubdivisionTypes.Municipality,
                Name = "Mirna Pec",
                LocalName = "Mirna Pec"
            },
            new()
            { 
                Code = "76",
                Type = SubdivisionTypes.Municipality,
                Name = "Mislinja",
                LocalName = "Mislinja"
            },
            new()
            { 
                Code = "199",
                Type = SubdivisionTypes.Municipality,
                Name = "Mokronog-Trebelno",
                LocalName = "Mokronog-Trebelno"
            },
            new()
            { 
                Code = "77",
                Type = SubdivisionTypes.Municipality,
                Name = "Moravce",
                LocalName = "Moravce"
            },
            new()
            { 
                Code = "78",
                Type = SubdivisionTypes.Municipality,
                Name = "Moravske Toplice",
                LocalName = "Moravske Toplice"
            },
            new()
            { 
                Code = "79",
                Type = SubdivisionTypes.Municipality,
                Name = "Mozirje",
                LocalName = "Mozirje"
            },
            new()
            { 
                Code = "80",
                Type = SubdivisionTypes.Municipality,
                Name = "Murska Sobota",
                LocalName = "Murska Sobota"
            },
            new()
            { 
                Code = "81",
                Type = SubdivisionTypes.Municipality,
                Name = "Muta",
                LocalName = "Muta"
            },
            new()
            { 
                Code = "82",
                Type = SubdivisionTypes.Municipality,
                Name = "Naklo",
                LocalName = "Naklo"
            },
            new()
            { 
                Code = "83",
                Type = SubdivisionTypes.Municipality,
                Name = "Nazarje",
                LocalName = "Nazarje"
            },
            new()
            { 
                Code = "84",
                Type = SubdivisionTypes.Municipality,
                Name = "Nova Gorica",
                LocalName = "Nova Gorica"
            },
            new()
            { 
                Code = "85",
                Type = SubdivisionTypes.Municipality,
                Name = "Novo mesto",
                LocalName = "Novo mesto"
            },
            new()
            { 
                Code = "86",
                Type = SubdivisionTypes.Municipality,
                Name = "Odranci",
                LocalName = "Odranci"
            },
            new()
            { 
                Code = "171",
                Type = SubdivisionTypes.Municipality,
                Name = "Oplotnica",
                LocalName = "Oplotnica"
            },
            new()
            { 
                Code = "87",
                Type = SubdivisionTypes.Municipality,
                Name = "Ormo",
                LocalName = "Ormo"
            },
            new()
            { 
                Code = "88",
                Type = SubdivisionTypes.Municipality,
                Name = "Osilnica",
                LocalName = "Osilnica"
            },
            new()
            { 
                Code = "89",
                Type = SubdivisionTypes.Municipality,
                Name = "Pesnica",
                LocalName = "Pesnica"
            },
            new()
            { 
                Code = "90",
                Type = SubdivisionTypes.Municipality,
                Name = "Piran",
                LocalName = "Piran"
            },
            new()
            { 
                Code = "91",
                Type = SubdivisionTypes.Municipality,
                Name = "Pivka",
                LocalName = "Pivka"
            },
            new()
            { 
                Code = "92",
                Type = SubdivisionTypes.Municipality,
                Name = "Podcetrtek",
                LocalName = "Podcetrtek"
            },
            new()
            { 
                Code = "172",
                Type = SubdivisionTypes.Municipality,
                Name = "Podlehnik",
                LocalName = "Podlehnik"
            },
            new()
            { 
                Code = "93",
                Type = SubdivisionTypes.Municipality,
                Name = "Podvelka",
                LocalName = "Podvelka"
            },
            new()
            { 
                Code = "200",
                Type = SubdivisionTypes.Municipality,
                Name = "Poljcane",
                LocalName = "Poljcane"
            },
            new()
            { 
                Code = "173",
                Type = SubdivisionTypes.Municipality,
                Name = "Polzela",
                LocalName = "Polzela"
            },
            new()
            { 
                Code = "94",
                Type = SubdivisionTypes.Municipality,
                Name = "Postojna",
                LocalName = "Postojna"
            },
            new()
            { 
                Code = "174",
                Type = SubdivisionTypes.Municipality,
                Name = "Prebold",
                LocalName = "Prebold"
            },
            new()
            { 
                Code = "95",
                Type = SubdivisionTypes.Municipality,
                Name = "Preddvor",
                LocalName = "Preddvor"
            },
            new()
            { 
                Code = "175",
                Type = SubdivisionTypes.Municipality,
                Name = "Prevalje",
                LocalName = "Prevalje"
            },
            new()
            { 
                Code = "96",
                Type = SubdivisionTypes.Municipality,
                Name = "Ptuj",
                LocalName = "Ptuj"
            },
            new()
            { 
                Code = "97",
                Type = SubdivisionTypes.Municipality,
                Name = "Puconci",
                LocalName = "Puconci"
            },
            new()
            { 
                Code = "98",
                Type = SubdivisionTypes.Municipality,
                Name = "Race-Fram",
                LocalName = "Race-Fram"
            },
            new()
            { 
                Code = "99",
                Type = SubdivisionTypes.Municipality,
                Name = "Radece",
                LocalName = "Radece"
            },
            new()
            { 
                Code = "100",
                Type = SubdivisionTypes.Municipality,
                Name = "Radenci",
                LocalName = "Radenci"
            },
            new()
            { 
                Code = "101",
                Type = SubdivisionTypes.Municipality,
                Name = "Radlje ob Dravi",
                LocalName = "Radlje ob Dravi"
            },
            new()
            { 
                Code = "102",
                Type = SubdivisionTypes.Municipality,
                Name = "Radovljica",
                LocalName = "Radovljica"
            },
            new()
            { 
                Code = "103",
                Type = SubdivisionTypes.Municipality,
                Name = "Ravne na Korokem",
                LocalName = "Ravne na Korokem"
            },
            new()
            { 
                Code = "176",
                Type = SubdivisionTypes.Municipality,
                Name = "Razkrije",
                LocalName = "Razkrije"
            },
            new()
            { 
                Code = "209",
                Type = SubdivisionTypes.Municipality,
                Name = "Recica ob Savinji",
                LocalName = "Recica ob Savinji"
            },
            new()
            { 
                Code = "201",
                Type = SubdivisionTypes.Municipality,
                Name = "Renèe-Vogrsko",
                LocalName = "Renèe-Vogrsko"
            },
            new()
            { 
                Code = "104",
                Type = SubdivisionTypes.Municipality,
                Name = "Ribnica",
                LocalName = "Ribnica"
            },
            new()
            { 
                Code = "177",
                Type = SubdivisionTypes.Municipality,
                Name = "Ribnica na Pohorju",
                LocalName = "Ribnica na Pohorju"
            },
            new()
            { 
                Code = "106",
                Type = SubdivisionTypes.Municipality,
                Name = "Rogaka Slatina",
                LocalName = "Rogaka Slatina"
            },
            new()
            { 
                Code = "105",
                Type = SubdivisionTypes.Municipality,
                Name = "Rogaovci",
                LocalName = "Rogaovci"
            },
            new()
            { 
                Code = "107",
                Type = SubdivisionTypes.Municipality,
                Name = "Rogatec",
                LocalName = "Rogatec"
            },
            new()
            { 
                Code = "108",
                Type = SubdivisionTypes.Municipality,
                Name = "Rue",
                LocalName = "Rue"
            },
            new()
            { 
                Code = "111",
                Type = SubdivisionTypes.Municipality,
                Name = "Seana",
                LocalName = "Seana"
            },
            new()
            { 
                Code = "178",
                Type = SubdivisionTypes.Municipality,
                Name = "Selnica ob Dravi",
                LocalName = "Selnica ob Dravi"
            },
            new()
            { 
                Code = "109",
                Type = SubdivisionTypes.Municipality,
                Name = "Semic",
                LocalName = "Semic"
            },
            new()
            { 
                Code = "110",
                Type = SubdivisionTypes.Municipality,
                Name = "Sevnica",
                LocalName = "Sevnica"
            },
            new()
            { 
                Code = "112",
                Type = SubdivisionTypes.Municipality,
                Name = "Slovenj Gradec",
                LocalName = "Slovenj Gradec"
            },
            new()
            { 
                Code = "113",
                Type = SubdivisionTypes.Municipality,
                Name = "Slovenska Bistrica",
                LocalName = "Slovenska Bistrica"
            },
            new()
            { 
                Code = "114",
                Type = SubdivisionTypes.Municipality,
                Name = "Slovenske Konjice",
                LocalName = "Slovenske Konjice"
            },
            new()
            { 
                Code = "179",
                Type = SubdivisionTypes.Municipality,
                Name = "Sodraica",
                LocalName = "Sodraica"
            },
            new()
            { 
                Code = "180",
                Type = SubdivisionTypes.Municipality,
                Name = "Solcava",
                LocalName = "Solcava"
            },
            new()
            { 
                Code = "202",
                Type = SubdivisionTypes.Municipality,
                Name = "Sredice ob Dravi",
                LocalName = "Sredice ob Dravi"
            },
            new()
            { 
                Code = "115",
                Type = SubdivisionTypes.Municipality,
                Name = "Stare",
                LocalName = "Stare"
            },
            new()
            { 
                Code = "203",
                Type = SubdivisionTypes.Municipality,
                Name = "Straa",
                LocalName = "Straa"
            },
            new()
            { 
                Code = "181",
                Type = SubdivisionTypes.Municipality,
                Name = "Sveta Ana",
                LocalName = "Sveta Ana"
            },
            new()
            { 
                Code = "182",
                Type = SubdivisionTypes.Municipality,
                Name = "Sveti Andra v Slovenskih goricah",
                LocalName = "Sveti Andra v Slovenskih goricah"
            },
            new()
            { 
                Code = "116",
                Type = SubdivisionTypes.Municipality,
                Name = "Sveti Jurij",
                LocalName = "Sveti Jurij"
            },
            new()
            { 
                Code = "210",
                Type = SubdivisionTypes.Municipality,
                Name = "Sveti Jurij v Slovenskih Goricah",
                LocalName = "Sveti Jurij v Slovenskih Goricah"
            },
            new()
            { 
                Code = "205",
                Type = SubdivisionTypes.Municipality,
                Name = "Sveti Toma",
                LocalName = "Sveti Toma"
            },
            new()
            { 
                Code = "184",
                Type = SubdivisionTypes.Municipality,
                Name = "Tabor",
                LocalName = "Tabor"
            },
            new()
            { 
                Code = "10",
                Type = SubdivisionTypes.Municipality,
                Name = "Tiina",
                LocalName = "Tiina"
            },
            new()
            { 
                Code = "128",
                Type = SubdivisionTypes.Municipality,
                Name = "Tolmin",
                LocalName = "Tolmin"
            },
            new()
            { 
                Code = "131",
                Type = SubdivisionTypes.Municipality,
                Name = "Tric",
                LocalName = "Tric"
            },
            new()
            { 
                Code = "129",
                Type = SubdivisionTypes.Municipality,
                Name = "Trbovlje",
                LocalName = "Trbovlje"
            },
            new()
            { 
                Code = "130",
                Type = SubdivisionTypes.Municipality,
                Name = "Trebnje",
                LocalName = "Trebnje"
            },
            new()
            { 
                Code = "185",
                Type = SubdivisionTypes.Municipality,
                Name = "Trnovska vas",
                LocalName = "Trnovska vas"
            },
            new()
            { 
                Code = "186",
                Type = SubdivisionTypes.Municipality,
                Name = "Trzin",
                LocalName = "Trzin"
            },
            new()
            { 
                Code = "132",
                Type = SubdivisionTypes.Municipality,
                Name = "Turnice",
                LocalName = "Turnice"
            },
            new()
            { 
                Code = "133",
                Type = SubdivisionTypes.Municipality,
                Name = "Velenje",
                LocalName = "Velenje"
            },
            new()
            { 
                Code = "187",
                Type = SubdivisionTypes.Municipality,
                Name = "Velika Polana",
                LocalName = "Velika Polana"
            },
            new()
            { 
                Code = "134",
                Type = SubdivisionTypes.Municipality,
                Name = "Velike Lace",
                LocalName = "Velike Lace"
            },
            new()
            { 
                Code = "188",
                Type = SubdivisionTypes.Municipality,
                Name = "Verej",
                LocalName = "Verej"
            },
            new()
            { 
                Code = "135",
                Type = SubdivisionTypes.Municipality,
                Name = "Videm",
                LocalName = "Videm"
            },
            new()
            { 
                Code = "136",
                Type = SubdivisionTypes.Municipality,
                Name = "Vipava",
                LocalName = "Vipava"
            },
            new()
            { 
                Code = "137",
                Type = SubdivisionTypes.Municipality,
                Name = "Vitanje",
                LocalName = "Vitanje"
            },
            new()
            { 
                Code = "138",
                Type = SubdivisionTypes.Municipality,
                Name = "Vodice",
                LocalName = "Vodice"
            },
            new()
            { 
                Code = "139",
                Type = SubdivisionTypes.Municipality,
                Name = "Vojnik",
                LocalName = "Vojnik"
            },
            new()
            { 
                Code = "189",
                Type = SubdivisionTypes.Municipality,
                Name = "Vransko",
                LocalName = "Vransko"
            },
            new()
            { 
                Code = "140",
                Type = SubdivisionTypes.Municipality,
                Name = "Vrhnika",
                LocalName = "Vrhnika"
            },
            new()
            { 
                Code = "141",
                Type = SubdivisionTypes.Municipality,
                Name = "Vuzenica",
                LocalName = "Vuzenica"
            },
            new()
            { 
                Code = "142",
                Type = SubdivisionTypes.Municipality,
                Name = "Zagorje ob Savi",
                LocalName = "Zagorje ob Savi"
            },
            new()
            { 
                Code = "143",
                Type = SubdivisionTypes.Municipality,
                Name = "Zavrc",
                LocalName = "Zavrc"
            },
            new()
            { 
                Code = "144",
                Type = SubdivisionTypes.Municipality,
                Name = "Zrece",
                LocalName = "Zrece"
            }

        ]);
    }
}
