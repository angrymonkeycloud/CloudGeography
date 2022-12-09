using AngryMonkey.Cloud.Geography;
namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    private static void FillInSubdivisionsLT()
    {
        AddSubdivisions("LT", new List<Subdivision>()
        {
            new()
            { 
                Code = "41",
                Type = "Municipality",
                Name = "akiai",
                LocalName = "akiai"
            },
            new()
            { 
                Code = "42",
                Type = "Municipality",
                Name = "alcininkai",
                LocalName = "alcininkai"
            },
            new()
            { 
                Code = "44",
                Type = "Municipality",
                Name = "iauliai",
                LocalName = "iauliai"
            },
            new()
            { 
                Code = "SA",
                Type = "County",
                Name = "iauliu Apskritis",
                LocalName = "iauliu Apskritis"
            },
            new()
            { 
                Code = "43",
                Type = "Municipality",
                Name = "iauliu miestas",
                LocalName = "iauliu miestas"
            },
            new()
            { 
                Code = "45",
                Type = "Municipality",
                Name = "ilale",
                LocalName = "ilale"
            },
            new()
            { 
                Code = "46",
                Type = "Municipality",
                Name = "ilute",
                LocalName = "ilute"
            },
            new()
            { 
                Code = "47",
                Type = "Municipality",
                Name = "irvintos",
                LocalName = "irvintos"
            },
            new()
            { 
                Code = "49",
                Type = "Municipality",
                Name = "vencionys",
                LocalName = "vencionys"
            },
            new()
            { 
                Code = "1",
                Type = "Municipality",
                Name = "Akmene",
                LocalName = "Akmene"
            },
            new()
            { 
                Code = "AL",
                Type = "County",
                Name = "Alytaus Apskritis",
                LocalName = "Alytaus Apskritis"
            },
            new()
            { 
                Code = "2",
                Type = "Municipality",
                Name = "Alytaus miestas",
                LocalName = "Alytaus miestas"
            },
            new()
            { 
                Code = "3",
                Type = "Municipality",
                Name = "Alytus",
                LocalName = "Alytus"
            },
            new()
            { 
                Code = "4",
                Type = "Municipality",
                Name = "Anykciai",
                LocalName = "Anykciai"
            },
            new()
            { 
                Code = "6",
                Type = "Municipality",
                Name = "Birai",
                LocalName = "Birai"
            },
            new()
            { 
                Code = "5",
                Type = "Municipality",
                Name = "Birtono",
                LocalName = "Birtono"
            },
            new()
            { 
                Code = "7",
                Type = "Municipality",
                Name = "Druskininkai",
                LocalName = "Druskininkai"
            },
            new()
            { 
                Code = "8",
                Type = "Municipality",
                Name = "Elektrénai",
                LocalName = "Elektrénai"
            },
            new()
            { 
                Code = "9",
                Type = "Municipality",
                Name = "Ignalina",
                LocalName = "Ignalina"
            },
            new()
            { 
                Code = "10",
                Type = "Municipality",
                Name = "Jonava",
                LocalName = "Jonava"
            },
            new()
            { 
                Code = "11",
                Type = "Municipality",
                Name = "Jonikis",
                LocalName = "Jonikis"
            },
            new()
            { 
                Code = "12",
                Type = "Municipality",
                Name = "Jurbarkas",
                LocalName = "Jurbarkas"
            },
            new()
            { 
                Code = "13",
                Type = "Municipality",
                Name = "Kaiiadorys",
                LocalName = "Kaiiadorys"
            },
            new()
            { 
                Code = "14",
                Type = "Municipality",
                Name = "Kalvarijos",
                LocalName = "Kalvarijos"
            },
            new()
            { 
                Code = "16",
                Type = "Municipality",
                Name = "Kaunas",
                LocalName = "Kaunas"
            },
            new()
            { 
                Code = "KU",
                Type = "County",
                Name = "Kauno Apskritis",
                LocalName = "Kauno Apskritis"
            },
            new()
            { 
                Code = "15",
                Type = "Municipality",
                Name = "Kauno miestas",
                LocalName = "Kauno miestas"
            },
            new()
            { 
                Code = "17",
                Type = "Municipality",
                Name = "Kazlu Rudos",
                LocalName = "Kazlu Rudos"
            },
            new()
            { 
                Code = "18",
                Type = "Municipality",
                Name = "Kedainiai",
                LocalName = "Kedainiai"
            },
            new()
            { 
                Code = "19",
                Type = "Municipality",
                Name = "Kelme",
                LocalName = "Kelme"
            },
            new()
            { 
                Code = "21",
                Type = "Municipality",
                Name = "Klaipeda",
                LocalName = "Klaipeda"
            },
            new()
            { 
                Code = "KL",
                Type = "County",
                Name = "Klaipedos apskritis",
                LocalName = "Klaipedos apskritis"
            },
            new()
            { 
                Code = "20",
                Type = "Municipality",
                Name = "Klaipedos miestas",
                LocalName = "Klaipedos miestas"
            },
            new()
            { 
                Code = "22",
                Type = "Municipality",
                Name = "Kretinga",
                LocalName = "Kretinga"
            },
            new()
            { 
                Code = "23",
                Type = "Municipality",
                Name = "Kupikis",
                LocalName = "Kupikis"
            },
            new()
            { 
                Code = "24",
                Type = "Municipality",
                Name = "Lazdijai",
                LocalName = "Lazdijai"
            },
            new()
            { 
                Code = "26",
                Type = "Municipality",
                Name = "Maeikiai",
                LocalName = "Maeikiai"
            },
            new()
            { 
                Code = "25",
                Type = "Municipality",
                Name = "Marijampole",
                LocalName = "Marijampole"
            },
            new()
            { 
                Code = "MR",
                Type = "County",
                Name = "Marijampoles apskritis",
                LocalName = "Marijampoles apskritis"
            },
            new()
            { 
                Code = "27",
                Type = "Municipality",
                Name = "Moletai",
                LocalName = "Moletai"
            },
            new()
            { 
                Code = "28",
                Type = "Municipality",
                Name = "Neringa",
                LocalName = "Neringa"
            },
            new()
            { 
                Code = "29",
                Type = "Municipality",
                Name = "Pagégiai",
                LocalName = "Pagégiai"
            },
            new()
            { 
                Code = "30",
                Type = "Municipality",
                Name = "Pakruojis",
                LocalName = "Pakruojis"
            },
            new()
            { 
                Code = "31",
                Type = "Municipality",
                Name = "Palangos miestas",
                LocalName = "Palangos miestas"
            },
            new()
            { 
                Code = "PN",
                Type = "County",
                Name = "Paneveio apskritis",
                LocalName = "Paneveio apskritis"
            },
            new()
            { 
                Code = "32",
                Type = "Municipality",
                Name = "Paneveio miestas",
                LocalName = "Paneveio miestas"
            },
            new()
            { 
                Code = "33",
                Type = "Municipality",
                Name = "Paneveys",
                LocalName = "Paneveys"
            },
            new()
            { 
                Code = "34",
                Type = "Municipality",
                Name = "Pasvalys",
                LocalName = "Pasvalys"
            },
            new()
            { 
                Code = "35",
                Type = "Municipality",
                Name = "Plunge",
                LocalName = "Plunge"
            },
            new()
            { 
                Code = "36",
                Type = "Municipality",
                Name = "Prienai",
                LocalName = "Prienai"
            },
            new()
            { 
                Code = "37",
                Type = "Municipality",
                Name = "Radvilikis",
                LocalName = "Radvilikis"
            },
            new()
            { 
                Code = "38",
                Type = "Municipality",
                Name = "Raseiniai",
                LocalName = "Raseiniai"
            },
            new()
            { 
                Code = "39",
                Type = "Municipality",
                Name = "Rietavo",
                LocalName = "Rietavo"
            },
            new()
            { 
                Code = "40",
                Type = "Municipality",
                Name = "Rokikis",
                LocalName = "Rokikis"
            },
            new()
            { 
                Code = "48",
                Type = "Municipality",
                Name = "Skuodas",
                LocalName = "Skuodas"
            },
            new()
            { 
                Code = "50",
                Type = "Municipality",
                Name = "Taurage",
                LocalName = "Taurage"
            },
            new()
            { 
                Code = "TA",
                Type = "County",
                Name = "Taurages apskritis",
                LocalName = "Taurages apskritis"
            },
            new()
            { 
                Code = "51",
                Type = "Municipality",
                Name = "Teliai",
                LocalName = "Teliai"
            },
            new()
            { 
                Code = "TE",
                Type = "County",
                Name = "Teliu Apskritis",
                LocalName = "Teliu Apskritis"
            },
            new()
            { 
                Code = "52",
                Type = "Municipality",
                Name = "Trakai",
                LocalName = "Trakai"
            },
            new()
            { 
                Code = "53",
                Type = "Municipality",
                Name = "Ukmerge",
                LocalName = "Ukmerge"
            },
            new()
            { 
                Code = "54",
                Type = "Municipality",
                Name = "Utena",
                LocalName = "Utena"
            },
            new()
            { 
                Code = "UT",
                Type = "County",
                Name = "Utenos Apskritis",
                LocalName = "Utenos Apskritis"
            },
            new()
            { 
                Code = "55",
                Type = "Municipality",
                Name = "Varena",
                LocalName = "Varena"
            },
            new()
            { 
                Code = "56",
                Type = "Municipality",
                Name = "Vilkavikis",
                LocalName = "Vilkavikis"
            },
            new()
            { 
                Code = "VL",
                Type = "County",
                Name = "Vilniaus Apskritis",
                LocalName = "Vilniaus Apskritis"
            },
            new()
            { 
                Code = "57",
                Type = "Municipality",
                Name = "Vilniaus miestas",
                LocalName = "Vilniaus miestas"
            },
            new()
            { 
                Code = "58",
                Type = "Municipality",
                Name = "Vilnius",
                LocalName = "Vilnius"
            },
            new()
            { 
                Code = "59",
                Type = "Municipality",
                Name = "Visaginas",
                LocalName = "Visaginas"
            },
            new()
            { 
                Code = "60",
                Type = "Municipality",
                Name = "Zarasai",
                LocalName = "Zarasai"
            }

        });
    }
}
