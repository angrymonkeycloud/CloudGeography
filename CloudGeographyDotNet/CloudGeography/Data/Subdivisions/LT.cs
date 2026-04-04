using AngryMonkey.Cloud.Geography;
namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    private static void FillInSubdivisionsLT()
    {
        AddSubdivisions("LT",
        [
            new()
            { 
                Code = "41",
                Type = SubdivisionTypes.Municipality,
                Name = "akiai",
                LocalName = "akiai"
            },
            new()
            { 
                Code = "42",
                Type = SubdivisionTypes.Municipality,
                Name = "alcininkai",
                LocalName = "alcininkai"
            },
            new()
            { 
                Code = "44",
                Type = SubdivisionTypes.Municipality,
                Name = "iauliai",
                LocalName = "iauliai"
            },
            new()
            { 
                Code = "SA",
                Type = SubdivisionTypes.County,
                Name = "iauliu Apskritis",
                LocalName = "iauliu Apskritis"
            },
            new()
            { 
                Code = "43",
                Type = SubdivisionTypes.Municipality,
                Name = "iauliu miestas",
                LocalName = "iauliu miestas"
            },
            new()
            { 
                Code = "45",
                Type = SubdivisionTypes.Municipality,
                Name = "ilale",
                LocalName = "ilale"
            },
            new()
            { 
                Code = "46",
                Type = SubdivisionTypes.Municipality,
                Name = "ilute",
                LocalName = "ilute"
            },
            new()
            { 
                Code = "47",
                Type = SubdivisionTypes.Municipality,
                Name = "irvintos",
                LocalName = "irvintos"
            },
            new()
            { 
                Code = "49",
                Type = SubdivisionTypes.Municipality,
                Name = "vencionys",
                LocalName = "vencionys"
            },
            new()
            { 
                Code = "1",
                Type = SubdivisionTypes.Municipality,
                Name = "Akmene",
                LocalName = "Akmene"
            },
            new()
            { 
                Code = "AL",
                Type = SubdivisionTypes.County,
                Name = "Alytaus Apskritis",
                LocalName = "Alytaus Apskritis"
            },
            new()
            { 
                Code = "2",
                Type = SubdivisionTypes.Municipality,
                Name = "Alytaus miestas",
                LocalName = "Alytaus miestas"
            },
            new()
            { 
                Code = "3",
                Type = SubdivisionTypes.Municipality,
                Name = "Alytus",
                LocalName = "Alytus"
            },
            new()
            { 
                Code = "4",
                Type = SubdivisionTypes.Municipality,
                Name = "Anykciai",
                LocalName = "Anykciai"
            },
            new()
            { 
                Code = "6",
                Type = SubdivisionTypes.Municipality,
                Name = "Birai",
                LocalName = "Birai"
            },
            new()
            { 
                Code = "5",
                Type = SubdivisionTypes.Municipality,
                Name = "Birtono",
                LocalName = "Birtono"
            },
            new()
            { 
                Code = "7",
                Type = SubdivisionTypes.Municipality,
                Name = "Druskininkai",
                LocalName = "Druskininkai"
            },
            new()
            { 
                Code = "8",
                Type = SubdivisionTypes.Municipality,
                Name = "Elektrénai",
                LocalName = "Elektrénai"
            },
            new()
            { 
                Code = "9",
                Type = SubdivisionTypes.Municipality,
                Name = "Ignalina",
                LocalName = "Ignalina"
            },
            new()
            { 
                Code = "10",
                Type = SubdivisionTypes.Municipality,
                Name = "Jonava",
                LocalName = "Jonava"
            },
            new()
            { 
                Code = "11",
                Type = SubdivisionTypes.Municipality,
                Name = "Jonikis",
                LocalName = "Jonikis"
            },
            new()
            { 
                Code = "12",
                Type = SubdivisionTypes.Municipality,
                Name = "Jurbarkas",
                LocalName = "Jurbarkas"
            },
            new()
            { 
                Code = "13",
                Type = SubdivisionTypes.Municipality,
                Name = "Kaiiadorys",
                LocalName = "Kaiiadorys"
            },
            new()
            { 
                Code = "14",
                Type = SubdivisionTypes.Municipality,
                Name = "Kalvarijos",
                LocalName = "Kalvarijos"
            },
            new()
            { 
                Code = "16",
                Type = SubdivisionTypes.Municipality,
                Name = "Kaunas",
                LocalName = "Kaunas"
            },
            new()
            { 
                Code = "KU",
                Type = SubdivisionTypes.County,
                Name = "Kauno Apskritis",
                LocalName = "Kauno Apskritis"
            },
            new()
            { 
                Code = "15",
                Type = SubdivisionTypes.Municipality,
                Name = "Kauno miestas",
                LocalName = "Kauno miestas"
            },
            new()
            { 
                Code = "17",
                Type = SubdivisionTypes.Municipality,
                Name = "Kazlu Rudos",
                LocalName = "Kazlu Rudos"
            },
            new()
            { 
                Code = "18",
                Type = SubdivisionTypes.Municipality,
                Name = "Kedainiai",
                LocalName = "Kedainiai"
            },
            new()
            { 
                Code = "19",
                Type = SubdivisionTypes.Municipality,
                Name = "Kelme",
                LocalName = "Kelme"
            },
            new()
            { 
                Code = "21",
                Type = SubdivisionTypes.Municipality,
                Name = "Klaipeda",
                LocalName = "Klaipeda"
            },
            new()
            { 
                Code = "KL",
                Type = SubdivisionTypes.County,
                Name = "Klaipedos apskritis",
                LocalName = "Klaipedos apskritis"
            },
            new()
            { 
                Code = "20",
                Type = SubdivisionTypes.Municipality,
                Name = "Klaipedos miestas",
                LocalName = "Klaipedos miestas"
            },
            new()
            { 
                Code = "22",
                Type = SubdivisionTypes.Municipality,
                Name = "Kretinga",
                LocalName = "Kretinga"
            },
            new()
            { 
                Code = "23",
                Type = SubdivisionTypes.Municipality,
                Name = "Kupikis",
                LocalName = "Kupikis"
            },
            new()
            { 
                Code = "24",
                Type = SubdivisionTypes.Municipality,
                Name = "Lazdijai",
                LocalName = "Lazdijai"
            },
            new()
            { 
                Code = "26",
                Type = SubdivisionTypes.Municipality,
                Name = "Maeikiai",
                LocalName = "Maeikiai"
            },
            new()
            { 
                Code = "25",
                Type = SubdivisionTypes.Municipality,
                Name = "Marijampole",
                LocalName = "Marijampole"
            },
            new()
            { 
                Code = "MR",
                Type = SubdivisionTypes.County,
                Name = "Marijampoles apskritis",
                LocalName = "Marijampoles apskritis"
            },
            new()
            { 
                Code = "27",
                Type = SubdivisionTypes.Municipality,
                Name = "Moletai",
                LocalName = "Moletai"
            },
            new()
            { 
                Code = "28",
                Type = SubdivisionTypes.Municipality,
                Name = "Neringa",
                LocalName = "Neringa"
            },
            new()
            { 
                Code = "29",
                Type = SubdivisionTypes.Municipality,
                Name = "Pagégiai",
                LocalName = "Pagégiai"
            },
            new()
            { 
                Code = "30",
                Type = SubdivisionTypes.Municipality,
                Name = "Pakruojis",
                LocalName = "Pakruojis"
            },
            new()
            { 
                Code = "31",
                Type = SubdivisionTypes.Municipality,
                Name = "Palangos miestas",
                LocalName = "Palangos miestas"
            },
            new()
            { 
                Code = "PN",
                Type = SubdivisionTypes.County,
                Name = "Paneveio apskritis",
                LocalName = "Paneveio apskritis"
            },
            new()
            { 
                Code = "32",
                Type = SubdivisionTypes.Municipality,
                Name = "Paneveio miestas",
                LocalName = "Paneveio miestas"
            },
            new()
            { 
                Code = "33",
                Type = SubdivisionTypes.Municipality,
                Name = "Paneveys",
                LocalName = "Paneveys"
            },
            new()
            { 
                Code = "34",
                Type = SubdivisionTypes.Municipality,
                Name = "Pasvalys",
                LocalName = "Pasvalys"
            },
            new()
            { 
                Code = "35",
                Type = SubdivisionTypes.Municipality,
                Name = "Plunge",
                LocalName = "Plunge"
            },
            new()
            { 
                Code = "36",
                Type = SubdivisionTypes.Municipality,
                Name = "Prienai",
                LocalName = "Prienai"
            },
            new()
            { 
                Code = "37",
                Type = SubdivisionTypes.Municipality,
                Name = "Radvilikis",
                LocalName = "Radvilikis"
            },
            new()
            { 
                Code = "38",
                Type = SubdivisionTypes.Municipality,
                Name = "Raseiniai",
                LocalName = "Raseiniai"
            },
            new()
            { 
                Code = "39",
                Type = SubdivisionTypes.Municipality,
                Name = "Rietavo",
                LocalName = "Rietavo"
            },
            new()
            { 
                Code = "40",
                Type = SubdivisionTypes.Municipality,
                Name = "Rokikis",
                LocalName = "Rokikis"
            },
            new()
            { 
                Code = "48",
                Type = SubdivisionTypes.Municipality,
                Name = "Skuodas",
                LocalName = "Skuodas"
            },
            new()
            { 
                Code = "50",
                Type = SubdivisionTypes.Municipality,
                Name = "Taurage",
                LocalName = "Taurage"
            },
            new()
            { 
                Code = "TA",
                Type = SubdivisionTypes.County,
                Name = "Taurages apskritis",
                LocalName = "Taurages apskritis"
            },
            new()
            { 
                Code = "51",
                Type = SubdivisionTypes.Municipality,
                Name = "Teliai",
                LocalName = "Teliai"
            },
            new()
            { 
                Code = "TE",
                Type = SubdivisionTypes.County,
                Name = "Teliu Apskritis",
                LocalName = "Teliu Apskritis"
            },
            new()
            { 
                Code = "52",
                Type = SubdivisionTypes.Municipality,
                Name = "Trakai",
                LocalName = "Trakai"
            },
            new()
            { 
                Code = "53",
                Type = SubdivisionTypes.Municipality,
                Name = "Ukmerge",
                LocalName = "Ukmerge"
            },
            new()
            { 
                Code = "54",
                Type = SubdivisionTypes.Municipality,
                Name = "Utena",
                LocalName = "Utena"
            },
            new()
            { 
                Code = "UT",
                Type = SubdivisionTypes.County,
                Name = "Utenos Apskritis",
                LocalName = "Utenos Apskritis"
            },
            new()
            { 
                Code = "55",
                Type = SubdivisionTypes.Municipality,
                Name = "Varena",
                LocalName = "Varena"
            },
            new()
            { 
                Code = "56",
                Type = SubdivisionTypes.Municipality,
                Name = "Vilkavikis",
                LocalName = "Vilkavikis"
            },
            new()
            { 
                Code = "VL",
                Type = SubdivisionTypes.County,
                Name = "Vilniaus Apskritis",
                LocalName = "Vilniaus Apskritis"
            },
            new()
            { 
                Code = "57",
                Type = SubdivisionTypes.Municipality,
                Name = "Vilniaus miestas",
                LocalName = "Vilniaus miestas"
            },
            new()
            { 
                Code = "58",
                Type = SubdivisionTypes.Municipality,
                Name = "Vilnius",
                LocalName = "Vilnius"
            },
            new()
            { 
                Code = "59",
                Type = SubdivisionTypes.Municipality,
                Name = "Visaginas",
                LocalName = "Visaginas"
            },
            new()
            { 
                Code = "60",
                Type = SubdivisionTypes.Municipality,
                Name = "Zarasai",
                LocalName = "Zarasai"
            }

        ]);
    }
}
