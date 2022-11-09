using AngryMonkey.Cloud.Geography;
namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    private static void FillInSubdivisionsFR()
    {
        AddSubdivisions("FR", new List<Subdivision>()
        {
            new()
            { 
                Code = "1",
                Type = "MetropolitanDepartment",
                Name = "Ain",
                LocalName = "Ain"
            },
            new()
            { 
                Code = "2",
                Type = "MetropolitanDepartment",
                Name = "Aisne",
                LocalName = "Aisne"
            },
            new()
            { 
                Code = "3",
                Type = "MetropolitanDepartment",
                Name = "Allier",
                LocalName = "Allier"
            },
            new()
            { 
                Code = "4",
                Type = "MetropolitanDepartment",
                Name = "Alpes-de-Haute-Provence",
                LocalName = "Alpes-de-Haute-Provence"
            },
            new()
            { 
                Code = "6",
                Type = "MetropolitanDepartment",
                Name = "Alpes-Maritimes",
                LocalName = "Alpes-Maritimes"
            },
            new()
            { 
                Code = "7",
                Type = "MetropolitanDepartment",
                Name = "Ardèche",
                LocalName = "Ardèche"
            },
            new()
            { 
                Code = "8",
                Type = "MetropolitanDepartment",
                Name = "Ardennes",
                LocalName = "Ardennes"
            },
            new()
            { 
                Code = "9",
                Type = "MetropolitanDepartment",
                Name = "Ariège",
                LocalName = "Ariège"
            },
            new()
            { 
                Code = "10",
                Type = "MetropolitanDepartment",
                Name = "Aube",
                LocalName = "Aube"
            },
            new()
            { 
                Code = "11",
                Type = "MetropolitanDepartment",
                Name = "Aude",
                LocalName = "Aude"
            },
            new()
            { 
                Code = "12",
                Type = "MetropolitanDepartment",
                Name = "Aveyron",
                LocalName = "Aveyron"
            },
            new()
            { 
                Code = "67",
                Type = "MetropolitanDepartment",
                Name = "Bas-Rhin",
                LocalName = "Bas-Rhin"
            },
            new()
            { 
                Code = "13",
                Type = "MetropolitanDepartment",
                Name = "Bouches-du-Rhône",
                LocalName = "Bouches-du-Rhône"
            },
            new()
            { 
                Code = "14",
                Type = "MetropolitanDepartment",
                Name = "Calvados",
                LocalName = "Calvados"
            },
            new()
            { 
                Code = "15",
                Type = "MetropolitanDepartment",
                Name = "Cantal",
                LocalName = "Cantal"
            },
            new()
            { 
                Code = "16",
                Type = "MetropolitanDepartment",
                Name = "Charente",
                LocalName = "Charente"
            },
            new()
            { 
                Code = "17",
                Type = "MetropolitanDepartment",
                Name = "Charente-Maritime",
                LocalName = "Charente-Maritime"
            },
            new()
            { 
                Code = "18",
                Type = "MetropolitanDepartment",
                Name = "Cher",
                LocalName = "Cher"
            },
            new()
            { 
                Code = "19",
                Type = "MetropolitanDepartment",
                Name = "Corrèze",
                LocalName = "Corrèze"
            },
            new()
            { 
                Code = "2A",
                Type = "MetropolitanDepartment",
                Name = "Corse-du-Sud",
                LocalName = "Corse-du-Sud"
            },
            new()
            { 
                Code = "21",
                Type = "MetropolitanDepartment",
                Name = "Côte-d'Or",
                LocalName = "Côte-d'Or"
            },
            new()
            { 
                Code = "22",
                Type = "MetropolitanDepartment",
                Name = "Côtes-d'Armor",
                LocalName = "Côtes-d'Armor"
            },
            new()
            { 
                Code = "23",
                Type = "MetropolitanDepartment",
                Name = "Creuse",
                LocalName = "Creuse"
            },
            new()
            { 
                Code = "79",
                Type = "MetropolitanDepartment",
                Name = "Deux-Sèvres",
                LocalName = "Deux-Sèvres"
            },
            new()
            { 
                Code = "24",
                Type = "MetropolitanDepartment",
                Name = "Dordogne",
                LocalName = "Dordogne"
            },
            new()
            { 
                Code = "25",
                Type = "MetropolitanDepartment",
                Name = "Doubs",
                LocalName = "Doubs"
            },
            new()
            { 
                Code = "26",
                Type = "MetropolitanDepartment",
                Name = "Drôme",
                LocalName = "Drôme"
            },
            new()
            { 
                Code = "91",
                Type = "MetropolitanDepartment",
                Name = "Essonne",
                LocalName = "Essonne"
            },
            new()
            { 
                Code = "27",
                Type = "MetropolitanDepartment",
                Name = "Eure",
                LocalName = "Eure"
            },
            new()
            { 
                Code = "28",
                Type = "MetropolitanDepartment",
                Name = "Eure-et-Loir",
                LocalName = "Eure-et-Loir"
            },
            new()
            { 
                Code = "29",
                Type = "MetropolitanDepartment",
                Name = "Finistère",
                LocalName = "Finistère"
            },
            new()
            { 
                Code = "30",
                Type = "MetropolitanDepartment",
                Name = "Gard",
                LocalName = "Gard"
            },
            new()
            { 
                Code = "32",
                Type = "MetropolitanDepartment",
                Name = "Gers",
                LocalName = "Gers"
            },
            new()
            { 
                Code = "33",
                Type = "MetropolitanDepartment",
                Name = "Gironde",
                LocalName = "Gironde"
            },
            new()
            { 
                Code = "2B",
                Type = "MetropolitanDepartment",
                Name = "Haute-Corse",
                LocalName = "Haute-Corse"
            },
            new()
            { 
                Code = "31",
                Type = "MetropolitanDepartment",
                Name = "Haute-Garonne",
                LocalName = "Haute-Garonne"
            },
            new()
            { 
                Code = "43",
                Type = "MetropolitanDepartment",
                Name = "Haute-Loire",
                LocalName = "Haute-Loire"
            },
            new()
            { 
                Code = "52",
                Type = "MetropolitanDepartment",
                Name = "Haute-Marne",
                LocalName = "Haute-Marne"
            },
            new()
            { 
                Code = "5",
                Type = "MetropolitanDepartment",
                Name = "Hautes-Alpes",
                LocalName = "Hautes-Alpes"
            },
            new()
            { 
                Code = "70",
                Type = "MetropolitanDepartment",
                Name = "Haute-Saône",
                LocalName = "Haute-Saône"
            },
            new()
            { 
                Code = "74",
                Type = "MetropolitanDepartment",
                Name = "Haute-Savoie",
                LocalName = "Haute-Savoie"
            },
            new()
            { 
                Code = "65",
                Type = "MetropolitanDepartment",
                Name = "Hautes-Pyrénées",
                LocalName = "Hautes-Pyrénées"
            },
            new()
            { 
                Code = "87",
                Type = "MetropolitanDepartment",
                Name = "Haute-Vienne",
                LocalName = "Haute-Vienne"
            },
            new()
            { 
                Code = "68",
                Type = "MetropolitanDepartment",
                Name = "Haut-Rhin",
                LocalName = "Haut-Rhin"
            },
            new()
            { 
                Code = "92",
                Type = "MetropolitanDepartment",
                Name = "Hauts-de-Seine",
                LocalName = "Hauts-de-Seine"
            },
            new()
            { 
                Code = "34",
                Type = "MetropolitanDepartment",
                Name = "Hérault",
                LocalName = "Hérault"
            },
            new()
            { 
                Code = "35",
                Type = "MetropolitanDepartment",
                Name = "Ille-et-Vilaine",
                LocalName = "Ille-et-Vilaine"
            },
            new()
            { 
                Code = "36",
                Type = "MetropolitanDepartment",
                Name = "Indre",
                LocalName = "Indre"
            },
            new()
            { 
                Code = "37",
                Type = "MetropolitanDepartment",
                Name = "Indre-et-Loire",
                LocalName = "Indre-et-Loire"
            },
            new()
            { 
                Code = "38",
                Type = "MetropolitanDepartment",
                Name = "Isère",
                LocalName = "Isère"
            },
            new()
            { 
                Code = "39",
                Type = "MetropolitanDepartment",
                Name = "Jura",
                LocalName = "Jura"
            },
            new()
            { 
                Code = "40",
                Type = "MetropolitanDepartment",
                Name = "Landes",
                LocalName = "Landes"
            },
            new()
            { 
                Code = "42",
                Type = "MetropolitanDepartment",
                Name = "Loire",
                LocalName = "Loire"
            },
            new()
            { 
                Code = "44",
                Type = "MetropolitanDepartment",
                Name = "Loire-Atlantique",
                LocalName = "Loire-Atlantique"
            },
            new()
            { 
                Code = "45",
                Type = "MetropolitanDepartment",
                Name = "Loiret",
                LocalName = "Loiret"
            },
            new()
            { 
                Code = "41",
                Type = "MetropolitanDepartment",
                Name = "Loir-et-Cher",
                LocalName = "Loir-et-Cher"
            },
            new()
            { 
                Code = "46",
                Type = "MetropolitanDepartment",
                Name = "Lot",
                LocalName = "Lot"
            },
            new()
            { 
                Code = "47",
                Type = "MetropolitanDepartment",
                Name = "Lot-et-Garonne",
                LocalName = "Lot-et-Garonne"
            },
            new()
            { 
                Code = "48",
                Type = "MetropolitanDepartment",
                Name = "Lozère",
                LocalName = "Lozère"
            },
            new()
            { 
                Code = "49",
                Type = "MetropolitanDepartment",
                Name = "Maine-et-Loire",
                LocalName = "Maine-et-Loire"
            },
            new()
            { 
                Code = "50",
                Type = "MetropolitanDepartment",
                Name = "Manche",
                LocalName = "Manche"
            },
            new()
            { 
                Code = "51",
                Type = "MetropolitanDepartment",
                Name = "Marne",
                LocalName = "Marne"
            },
            new()
            { 
                Code = "53",
                Type = "MetropolitanDepartment",
                Name = "Mayenne",
                LocalName = "Mayenne"
            },
            new()
            { 
                Code = "54",
                Type = "MetropolitanDepartment",
                Name = "Meurthe-et-Moselle",
                LocalName = "Meurthe-et-Moselle"
            },
            new()
            { 
                Code = "55",
                Type = "MetropolitanDepartment",
                Name = "Meuse",
                LocalName = "Meuse"
            },
            new()
            { 
                Code = "56",
                Type = "MetropolitanDepartment",
                Name = "Morbihan",
                LocalName = "Morbihan"
            },
            new()
            { 
                Code = "57",
                Type = "MetropolitanDepartment",
                Name = "Moselle",
                LocalName = "Moselle"
            },
            new()
            { 
                Code = "58",
                Type = "MetropolitanDepartment",
                Name = "Nièvre",
                LocalName = "Nièvre"
            },
            new()
            { 
                Code = "59",
                Type = "MetropolitanDepartment",
                Name = "Nord",
                LocalName = "Nord"
            },
            new()
            { 
                Code = "60",
                Type = "MetropolitanDepartment",
                Name = "Oise",
                LocalName = "Oise"
            },
            new()
            { 
                Code = "61",
                Type = "MetropolitanDepartment",
                Name = "Orne",
                LocalName = "Orne"
            },
            new()
            { 
                Code = "75",
                Type = "MetropolitanDepartment",
                Name = "Paris",
                LocalName = "Paris"
            },
            new()
            { 
                Code = "62",
                Type = "MetropolitanDepartment",
                Name = "Pas-de-Calais",
                LocalName = "Pas-de-Calais"
            },
            new()
            { 
                Code = "63",
                Type = "MetropolitanDepartment",
                Name = "Puy-de-Dôme",
                LocalName = "Puy-de-Dôme"
            },
            new()
            { 
                Code = "64",
                Type = "MetropolitanDepartment",
                Name = "Pyrénées-Atlantiques",
                LocalName = "Pyrénées-Atlantiques"
            },
            new()
            { 
                Code = "66",
                Type = "MetropolitanDepartment",
                Name = "Pyrénées-Orientales",
                LocalName = "Pyrénées-Orientales"
            },
            new()
            { 
                Code = "69",
                Type = "MetropolitanDepartment",
                Name = "Rhône",
                LocalName = "Rhône"
            },
            new()
            { 
                Code = "71",
                Type = "MetropolitanDepartment",
                Name = "Saône-et-Loire",
                LocalName = "Saône-et-Loire"
            },
            new()
            { 
                Code = "72",
                Type = "MetropolitanDepartment",
                Name = "Sarthe",
                LocalName = "Sarthe"
            },
            new()
            { 
                Code = "73",
                Type = "MetropolitanDepartment",
                Name = "Savoie",
                LocalName = "Savoie"
            },
            new()
            { 
                Code = "77",
                Type = "MetropolitanDepartment",
                Name = "Seine-et-Marne",
                LocalName = "Seine-et-Marne"
            },
            new()
            { 
                Code = "76",
                Type = "MetropolitanDepartment",
                Name = "Seine-Maritime",
                LocalName = "Seine-Maritime"
            },
            new()
            { 
                Code = "93",
                Type = "MetropolitanDepartment",
                Name = "Seine-Saint-Denis",
                LocalName = "Seine-Saint-Denis"
            },
            new()
            { 
                Code = "80",
                Type = "MetropolitanDepartment",
                Name = "Somme",
                LocalName = "Somme"
            },
            new()
            { 
                Code = "81",
                Type = "MetropolitanDepartment",
                Name = "Tarn",
                LocalName = "Tarn"
            },
            new()
            { 
                Code = "82",
                Type = "MetropolitanDepartment",
                Name = "Tarn-et-Garonne",
                LocalName = "Tarn-et-Garonne"
            },
            new()
            { 
                Code = "90",
                Type = "MetropolitanDepartment",
                Name = "Territoire de Belfort",
                LocalName = "Territoire de Belfort"
            },
            new()
            { 
                Code = "94",
                Type = "MetropolitanDepartment",
                Name = "Val-de-Marne",
                LocalName = "Val-de-Marne"
            },
            new()
            { 
                Code = "95",
                Type = "MetropolitanDepartment",
                Name = "Val-d'Oise",
                LocalName = "Val-d'Oise"
            },
            new()
            { 
                Code = "83",
                Type = "MetropolitanDepartment",
                Name = "Var",
                LocalName = "Var"
            },
            new()
            { 
                Code = "84",
                Type = "MetropolitanDepartment",
                Name = "Vaucluse",
                LocalName = "Vaucluse"
            },
            new()
            { 
                Code = "85",
                Type = "MetropolitanDepartment",
                Name = "Vendée",
                LocalName = "Vendée"
            },
            new()
            { 
                Code = "86",
                Type = "MetropolitanDepartment",
                Name = "Vienne",
                LocalName = "Vienne"
            },
            new()
            { 
                Code = "88",
                Type = "MetropolitanDepartment",
                Name = "Vosges",
                LocalName = "Vosges"
            },
            new()
            { 
                Code = "89",
                Type = "MetropolitanDepartment",
                Name = "Yonne",
                LocalName = "Yonne"
            },
            new()
            { 
                Code = "78",
                Type = "MetropolitanDepartment",
                Name = "Yvelines",
                LocalName = "Yvelines"
            }

        });
    }
}
