using AngryMonkey.Cloud.Geography;
namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    private static void FillInSubdivisionsMT()
    {
        AddSubdivisions("MT",
        [
            new()
            { 
                Code = "1",
                Type = SubdivisionTypes.LocalCouncil,
                Name = "Attard",
                LocalName = "Attard"
            },
            new()
            { 
                Code = "2",
                Type = SubdivisionTypes.LocalCouncil,
                Name = "Balzan",
                LocalName = "Balzan"
            },
            new()
            { 
                Code = "3",
                Type = SubdivisionTypes.LocalCouncil,
                Name = "Birgu",
                LocalName = "Birgu"
            },
            new()
            { 
                Code = "4",
                Type = SubdivisionTypes.LocalCouncil,
                Name = "Birkirkara",
                LocalName = "Birkirkara"
            },
            new()
            { 
                Code = "5",
                Type = SubdivisionTypes.LocalCouncil,
                Name = "Birzebbuga",
                LocalName = "Birzebbuga"
            },
            new()
            { 
                Code = "6",
                Type = SubdivisionTypes.LocalCouncil,
                Name = "Bormla",
                LocalName = "Bormla"
            },
            new()
            { 
                Code = "7",
                Type = SubdivisionTypes.LocalCouncil,
                Name = "Dingli",
                LocalName = "Dingli"
            },
            new()
            { 
                Code = "8",
                Type = SubdivisionTypes.LocalCouncil,
                Name = "Fgura",
                LocalName = "Fgura"
            },
            new()
            { 
                Code = "9",
                Type = SubdivisionTypes.LocalCouncil,
                Name = "Floriana",
                LocalName = "Floriana"
            },
            new()
            { 
                Code = "10",
                Type = SubdivisionTypes.LocalCouncil,
                Name = "Fontana",
                LocalName = "Fontana"
            },
            new()
            { 
                Code = "13",
                Type = SubdivisionTypes.LocalCouncil,
                Name = "Ghajnsielem",
                LocalName = "Ghajnsielem"
            },
            new()
            { 
                Code = "14",
                Type = SubdivisionTypes.LocalCouncil,
                Name = "Gharb",
                LocalName = "Gharb"
            },
            new()
            { 
                Code = "15",
                Type = SubdivisionTypes.LocalCouncil,
                Name = "Gharghur",
                LocalName = "Gharghur"
            },
            new()
            { 
                Code = "16",
                Type = SubdivisionTypes.LocalCouncil,
                Name = "Ghasri",
                LocalName = "Ghasri"
            },
            new()
            { 
                Code = "17",
                Type = SubdivisionTypes.LocalCouncil,
                Name = "Ghaxaq",
                LocalName = "Ghaxaq"
            },
            new()
            { 
                Code = "11",
                Type = SubdivisionTypes.LocalCouncil,
                Name = "Gudja",
                LocalName = "Gudja"
            },
            new()
            { 
                Code = "12",
                Type = SubdivisionTypes.LocalCouncil,
                Name = "Gzira",
                LocalName = "Gzira"
            },
            new()
            { 
                Code = "18",
                Type = SubdivisionTypes.LocalCouncil,
                Name = "Hamrun",
                LocalName = "Hamrun"
            },
            new()
            { 
                Code = "19",
                Type = SubdivisionTypes.LocalCouncil,
                Name = "Iklin",
                LocalName = "Iklin"
            },
            new()
            { 
                Code = "20",
                Type = SubdivisionTypes.LocalCouncil,
                Name = "Isla",
                LocalName = "Isla"
            },
            new()
            { 
                Code = "21",
                Type = SubdivisionTypes.LocalCouncil,
                Name = "Kalkara",
                LocalName = "Kalkara"
            },
            new()
            { 
                Code = "22",
                Type = SubdivisionTypes.LocalCouncil,
                Name = "Kercem",
                LocalName = "Kercem"
            },
            new()
            { 
                Code = "23",
                Type = SubdivisionTypes.LocalCouncil,
                Name = "Kirkop",
                LocalName = "Kirkop"
            },
            new()
            { 
                Code = "24",
                Type = SubdivisionTypes.LocalCouncil,
                Name = "Lija",
                LocalName = "Lija"
            },
            new()
            { 
                Code = "25",
                Type = SubdivisionTypes.LocalCouncil,
                Name = "Luqa",
                LocalName = "Luqa"
            },
            new()
            { 
                Code = "26",
                Type = SubdivisionTypes.LocalCouncil,
                Name = "Marsa",
                LocalName = "Marsa"
            },
            new()
            { 
                Code = "27",
                Type = SubdivisionTypes.LocalCouncil,
                Name = "Marsaskala",
                LocalName = "Marsaskala"
            },
            new()
            { 
                Code = "28",
                Type = SubdivisionTypes.LocalCouncil,
                Name = "Marsaxlokk",
                LocalName = "Marsaxlokk"
            },
            new()
            { 
                Code = "29",
                Type = SubdivisionTypes.LocalCouncil,
                Name = "Mdina",
                LocalName = "Mdina"
            },
            new()
            { 
                Code = "30",
                Type = SubdivisionTypes.LocalCouncil,
                Name = "Mellieha",
                LocalName = "Mellieha"
            },
            new()
            { 
                Code = "31",
                Type = SubdivisionTypes.LocalCouncil,
                Name = "Mgarr",
                LocalName = "Mgarr"
            },
            new()
            { 
                Code = "32",
                Type = SubdivisionTypes.LocalCouncil,
                Name = "Mosta",
                LocalName = "Mosta"
            },
            new()
            { 
                Code = "33",
                Type = SubdivisionTypes.LocalCouncil,
                Name = "Mqabba",
                LocalName = "Mqabba"
            },
            new()
            { 
                Code = "34",
                Type = SubdivisionTypes.LocalCouncil,
                Name = "Msida",
                LocalName = "Msida"
            },
            new()
            { 
                Code = "35",
                Type = SubdivisionTypes.LocalCouncil,
                Name = "Mtarfa",
                LocalName = "Mtarfa"
            },
            new()
            { 
                Code = "36",
                Type = SubdivisionTypes.LocalCouncil,
                Name = "Munxar",
                LocalName = "Munxar"
            },
            new()
            { 
                Code = "37",
                Type = SubdivisionTypes.LocalCouncil,
                Name = "Nadur",
                LocalName = "Nadur"
            },
            new()
            { 
                Code = "38",
                Type = SubdivisionTypes.LocalCouncil,
                Name = "Naxxar",
                LocalName = "Naxxar"
            },
            new()
            { 
                Code = "39",
                Type = SubdivisionTypes.LocalCouncil,
                Name = "Paola",
                LocalName = "Paola"
            },
            new()
            { 
                Code = "40",
                Type = SubdivisionTypes.LocalCouncil,
                Name = "Pembroke",
                LocalName = "Pembroke"
            },
            new()
            { 
                Code = "41",
                Type = SubdivisionTypes.LocalCouncil,
                Name = "Pietà",
                LocalName = "Pietà"
            },
            new()
            { 
                Code = "42",
                Type = SubdivisionTypes.LocalCouncil,
                Name = "Qala",
                LocalName = "Qala"
            },
            new()
            { 
                Code = "43",
                Type = SubdivisionTypes.LocalCouncil,
                Name = "Qormi",
                LocalName = "Qormi"
            },
            new()
            { 
                Code = "44",
                Type = SubdivisionTypes.LocalCouncil,
                Name = "Qrendi",
                LocalName = "Qrendi"
            },
            new()
            { 
                Code = "45",
                Type = SubdivisionTypes.LocalCouncil,
                Name = "Rabat Gozo",
                LocalName = "Rabat Gozo"
            },
            new()
            { 
                Code = "46",
                Type = SubdivisionTypes.LocalCouncil,
                Name = "Rabat Malta",
                LocalName = "Rabat Malta"
            },
            new()
            { 
                Code = "47",
                Type = SubdivisionTypes.LocalCouncil,
                Name = "Safi",
                LocalName = "Safi"
            },
            new()
            { 
                Code = "49",
                Type = SubdivisionTypes.LocalCouncil,
                Name = "Saint John",
                LocalName = "Saint John"
            },
            new()
            { 
                Code = "48",
                Type = SubdivisionTypes.LocalCouncil,
                Name = "Saint Julian's",
                LocalName = "Saint Julian's"
            },
            new()
            { 
                Code = "50",
                Type = SubdivisionTypes.LocalCouncil,
                Name = "Saint Lawrence",
                LocalName = "Saint Lawrence"
            },
            new()
            { 
                Code = "53",
                Type = SubdivisionTypes.LocalCouncil,
                Name = "Saint Lucia's",
                LocalName = "Saint Lucia's"
            },
            new()
            { 
                Code = "51",
                Type = SubdivisionTypes.LocalCouncil,
                Name = "Saint Paul's Bay",
                LocalName = "Saint Paul's Bay"
            },
            new()
            { 
                Code = "52",
                Type = SubdivisionTypes.LocalCouncil,
                Name = "Sannat",
                LocalName = "Sannat"
            },
            new()
            { 
                Code = "54",
                Type = SubdivisionTypes.LocalCouncil,
                Name = "Santa Venera",
                LocalName = "Santa Venera"
            },
            new()
            { 
                Code = "55",
                Type = SubdivisionTypes.LocalCouncil,
                Name = "Siggiewi",
                LocalName = "Siggiewi"
            },
            new()
            { 
                Code = "56",
                Type = SubdivisionTypes.LocalCouncil,
                Name = "Sliema",
                LocalName = "Sliema"
            },
            new()
            { 
                Code = "57",
                Type = SubdivisionTypes.LocalCouncil,
                Name = "Swieqi",
                LocalName = "Swieqi"
            },
            new()
            { 
                Code = "58",
                Type = SubdivisionTypes.LocalCouncil,
                Name = "Ta' Xbiex",
                LocalName = "Ta' Xbiex"
            },
            new()
            { 
                Code = "59",
                Type = SubdivisionTypes.LocalCouncil,
                Name = "Tarxien",
                LocalName = "Tarxien"
            },
            new()
            { 
                Code = "60",
                Type = SubdivisionTypes.LocalCouncil,
                Name = "Valletta",
                LocalName = "Valletta"
            },
            new()
            { 
                Code = "61",
                Type = SubdivisionTypes.LocalCouncil,
                Name = "Xaghra",
                LocalName = "Xaghra"
            },
            new()
            { 
                Code = "62",
                Type = SubdivisionTypes.LocalCouncil,
                Name = "Xewkija",
                LocalName = "Xewkija"
            },
            new()
            { 
                Code = "63",
                Type = SubdivisionTypes.LocalCouncil,
                Name = "Xghajra",
                LocalName = "Xghajra"
            },
            new()
            { 
                Code = "64",
                Type = SubdivisionTypes.LocalCouncil,
                Name = "Zabbar",
                LocalName = "Zabbar"
            },
            new()
            { 
                Code = "65",
                Type = SubdivisionTypes.LocalCouncil,
                Name = "Zebbug Gozo",
                LocalName = "Zebbug Gozo"
            },
            new()
            { 
                Code = "66",
                Type = SubdivisionTypes.LocalCouncil,
                Name = "Zebbug Malta",
                LocalName = "Zebbug Malta"
            },
            new()
            { 
                Code = "67",
                Type = SubdivisionTypes.LocalCouncil,
                Name = "Zejtun",
                LocalName = "Zejtun"
            },
            new()
            { 
                Code = "68",
                Type = SubdivisionTypes.LocalCouncil,
                Name = "Zurrieq",
                LocalName = "Zurrieq"
            }

        ]);
    }
}
