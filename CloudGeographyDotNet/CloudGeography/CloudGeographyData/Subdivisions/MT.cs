using AngryMonkey.Cloud.Geography;
namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    private static void FillInSubdivisionsMT()
    {
        AddSubdivisions("MT", new List<Subdivision>()
        {
            new()
            { 
                Code = "1",
                Type = "LocalCouncil",
                Name = "Attard",
                LocalName = "Attard"
            },
            new()
            { 
                Code = "2",
                Type = "LocalCouncil",
                Name = "Balzan",
                LocalName = "Balzan"
            },
            new()
            { 
                Code = "3",
                Type = "LocalCouncil",
                Name = "Birgu",
                LocalName = "Birgu"
            },
            new()
            { 
                Code = "4",
                Type = "LocalCouncil",
                Name = "Birkirkara",
                LocalName = "Birkirkara"
            },
            new()
            { 
                Code = "5",
                Type = "LocalCouncil",
                Name = "Birzebbuga",
                LocalName = "Birzebbuga"
            },
            new()
            { 
                Code = "6",
                Type = "LocalCouncil",
                Name = "Bormla",
                LocalName = "Bormla"
            },
            new()
            { 
                Code = "7",
                Type = "LocalCouncil",
                Name = "Dingli",
                LocalName = "Dingli"
            },
            new()
            { 
                Code = "8",
                Type = "LocalCouncil",
                Name = "Fgura",
                LocalName = "Fgura"
            },
            new()
            { 
                Code = "9",
                Type = "LocalCouncil",
                Name = "Floriana",
                LocalName = "Floriana"
            },
            new()
            { 
                Code = "10",
                Type = "LocalCouncil",
                Name = "Fontana",
                LocalName = "Fontana"
            },
            new()
            { 
                Code = "13",
                Type = "LocalCouncil",
                Name = "Ghajnsielem",
                LocalName = "Ghajnsielem"
            },
            new()
            { 
                Code = "14",
                Type = "LocalCouncil",
                Name = "Gharb",
                LocalName = "Gharb"
            },
            new()
            { 
                Code = "15",
                Type = "LocalCouncil",
                Name = "Gharghur",
                LocalName = "Gharghur"
            },
            new()
            { 
                Code = "16",
                Type = "LocalCouncil",
                Name = "Ghasri",
                LocalName = "Ghasri"
            },
            new()
            { 
                Code = "17",
                Type = "LocalCouncil",
                Name = "Ghaxaq",
                LocalName = "Ghaxaq"
            },
            new()
            { 
                Code = "11",
                Type = "LocalCouncil",
                Name = "Gudja",
                LocalName = "Gudja"
            },
            new()
            { 
                Code = "12",
                Type = "LocalCouncil",
                Name = "Gzira",
                LocalName = "Gzira"
            },
            new()
            { 
                Code = "18",
                Type = "LocalCouncil",
                Name = "Hamrun",
                LocalName = "Hamrun"
            },
            new()
            { 
                Code = "19",
                Type = "LocalCouncil",
                Name = "Iklin",
                LocalName = "Iklin"
            },
            new()
            { 
                Code = "20",
                Type = "LocalCouncil",
                Name = "Isla",
                LocalName = "Isla"
            },
            new()
            { 
                Code = "21",
                Type = "LocalCouncil",
                Name = "Kalkara",
                LocalName = "Kalkara"
            },
            new()
            { 
                Code = "22",
                Type = "LocalCouncil",
                Name = "Kercem",
                LocalName = "Kercem"
            },
            new()
            { 
                Code = "23",
                Type = "LocalCouncil",
                Name = "Kirkop",
                LocalName = "Kirkop"
            },
            new()
            { 
                Code = "24",
                Type = "LocalCouncil",
                Name = "Lija",
                LocalName = "Lija"
            },
            new()
            { 
                Code = "25",
                Type = "LocalCouncil",
                Name = "Luqa",
                LocalName = "Luqa"
            },
            new()
            { 
                Code = "26",
                Type = "LocalCouncil",
                Name = "Marsa",
                LocalName = "Marsa"
            },
            new()
            { 
                Code = "27",
                Type = "LocalCouncil",
                Name = "Marsaskala",
                LocalName = "Marsaskala"
            },
            new()
            { 
                Code = "28",
                Type = "LocalCouncil",
                Name = "Marsaxlokk",
                LocalName = "Marsaxlokk"
            },
            new()
            { 
                Code = "29",
                Type = "LocalCouncil",
                Name = "Mdina",
                LocalName = "Mdina"
            },
            new()
            { 
                Code = "30",
                Type = "LocalCouncil",
                Name = "Mellieha",
                LocalName = "Mellieha"
            },
            new()
            { 
                Code = "31",
                Type = "LocalCouncil",
                Name = "Mgarr",
                LocalName = "Mgarr"
            },
            new()
            { 
                Code = "32",
                Type = "LocalCouncil",
                Name = "Mosta",
                LocalName = "Mosta"
            },
            new()
            { 
                Code = "33",
                Type = "LocalCouncil",
                Name = "Mqabba",
                LocalName = "Mqabba"
            },
            new()
            { 
                Code = "34",
                Type = "LocalCouncil",
                Name = "Msida",
                LocalName = "Msida"
            },
            new()
            { 
                Code = "35",
                Type = "LocalCouncil",
                Name = "Mtarfa",
                LocalName = "Mtarfa"
            },
            new()
            { 
                Code = "36",
                Type = "LocalCouncil",
                Name = "Munxar",
                LocalName = "Munxar"
            },
            new()
            { 
                Code = "37",
                Type = "LocalCouncil",
                Name = "Nadur",
                LocalName = "Nadur"
            },
            new()
            { 
                Code = "38",
                Type = "LocalCouncil",
                Name = "Naxxar",
                LocalName = "Naxxar"
            },
            new()
            { 
                Code = "39",
                Type = "LocalCouncil",
                Name = "Paola",
                LocalName = "Paola"
            },
            new()
            { 
                Code = "40",
                Type = "LocalCouncil",
                Name = "Pembroke",
                LocalName = "Pembroke"
            },
            new()
            { 
                Code = "41",
                Type = "LocalCouncil",
                Name = "Pietà",
                LocalName = "Pietà"
            },
            new()
            { 
                Code = "42",
                Type = "LocalCouncil",
                Name = "Qala",
                LocalName = "Qala"
            },
            new()
            { 
                Code = "43",
                Type = "LocalCouncil",
                Name = "Qormi",
                LocalName = "Qormi"
            },
            new()
            { 
                Code = "44",
                Type = "LocalCouncil",
                Name = "Qrendi",
                LocalName = "Qrendi"
            },
            new()
            { 
                Code = "45",
                Type = "LocalCouncil",
                Name = "Rabat Gozo",
                LocalName = "Rabat Gozo"
            },
            new()
            { 
                Code = "46",
                Type = "LocalCouncil",
                Name = "Rabat Malta",
                LocalName = "Rabat Malta"
            },
            new()
            { 
                Code = "47",
                Type = "LocalCouncil",
                Name = "Safi",
                LocalName = "Safi"
            },
            new()
            { 
                Code = "49",
                Type = "LocalCouncil",
                Name = "Saint John",
                LocalName = "Saint John"
            },
            new()
            { 
                Code = "48",
                Type = "LocalCouncil",
                Name = "Saint Julian's",
                LocalName = "Saint Julian's"
            },
            new()
            { 
                Code = "50",
                Type = "LocalCouncil",
                Name = "Saint Lawrence",
                LocalName = "Saint Lawrence"
            },
            new()
            { 
                Code = "53",
                Type = "LocalCouncil",
                Name = "Saint Lucia's",
                LocalName = "Saint Lucia's"
            },
            new()
            { 
                Code = "51",
                Type = "LocalCouncil",
                Name = "Saint Paul's Bay",
                LocalName = "Saint Paul's Bay"
            },
            new()
            { 
                Code = "52",
                Type = "LocalCouncil",
                Name = "Sannat",
                LocalName = "Sannat"
            },
            new()
            { 
                Code = "54",
                Type = "LocalCouncil",
                Name = "Santa Venera",
                LocalName = "Santa Venera"
            },
            new()
            { 
                Code = "55",
                Type = "LocalCouncil",
                Name = "Siggiewi",
                LocalName = "Siggiewi"
            },
            new()
            { 
                Code = "56",
                Type = "LocalCouncil",
                Name = "Sliema",
                LocalName = "Sliema"
            },
            new()
            { 
                Code = "57",
                Type = "LocalCouncil",
                Name = "Swieqi",
                LocalName = "Swieqi"
            },
            new()
            { 
                Code = "58",
                Type = "LocalCouncil",
                Name = "Ta' Xbiex",
                LocalName = "Ta' Xbiex"
            },
            new()
            { 
                Code = "59",
                Type = "LocalCouncil",
                Name = "Tarxien",
                LocalName = "Tarxien"
            },
            new()
            { 
                Code = "60",
                Type = "LocalCouncil",
                Name = "Valletta",
                LocalName = "Valletta"
            },
            new()
            { 
                Code = "61",
                Type = "LocalCouncil",
                Name = "Xaghra",
                LocalName = "Xaghra"
            },
            new()
            { 
                Code = "62",
                Type = "LocalCouncil",
                Name = "Xewkija",
                LocalName = "Xewkija"
            },
            new()
            { 
                Code = "63",
                Type = "LocalCouncil",
                Name = "Xghajra",
                LocalName = "Xghajra"
            },
            new()
            { 
                Code = "64",
                Type = "LocalCouncil",
                Name = "Zabbar",
                LocalName = "Zabbar"
            },
            new()
            { 
                Code = "65",
                Type = "LocalCouncil",
                Name = "Zebbug Gozo",
                LocalName = "Zebbug Gozo"
            },
            new()
            { 
                Code = "66",
                Type = "LocalCouncil",
                Name = "Zebbug Malta",
                LocalName = "Zebbug Malta"
            },
            new()
            { 
                Code = "67",
                Type = "LocalCouncil",
                Name = "Zejtun",
                LocalName = "Zejtun"
            },
            new()
            { 
                Code = "68",
                Type = "LocalCouncil",
                Name = "Zurrieq",
                LocalName = "Zurrieq"
            }

        });
    }
}
