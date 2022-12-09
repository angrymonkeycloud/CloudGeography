using AngryMonkey.Cloud.Geography;
namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    private static void FillInSubdivisionsIT()
    {
        AddSubdivisions("IT", new List<Subdivision>()
        {
            new()
            { 
                Code = "AG",
                Type = "Province",
                Name = "Agrigento",
                LocalName = "Agrigento"
            },
            new()
            { 
                Code = "AL",
                Type = "Province",
                Name = "Alessandria",
                LocalName = "Alessandria"
            },
            new()
            { 
                Code = "AN",
                Type = "Province",
                Name = "Ancona",
                LocalName = "Ancona"
            },
            new()
            { 
                Code = "AO",
                Type = "Province",
                Name = "Aosta / Aoste",
                LocalName = "Aosta / Aoste"
            },
            new()
            { 
                Code = "AR",
                Type = "Province",
                Name = "Arezzo",
                LocalName = "Arezzo"
            },
            new()
            { 
                Code = "AP",
                Type = "Province",
                Name = "Ascoli Piceno",
                LocalName = "Ascoli Piceno"
            },
            new()
            { 
                Code = "AT",
                Type = "Province",
                Name = "Asti",
                LocalName = "Asti"
            },
            new()
            { 
                Code = "AV",
                Type = "Province",
                Name = "Avellino",
                LocalName = "Avellino"
            },
            new()
            { 
                Code = "BA",
                Type = "Province",
                Name = "Bari",
                LocalName = "Bari"
            },
            new()
            { 
                Code = "BT",
                Type = "Province",
                Name = "Barletta-Andria-Trani",
                LocalName = "Barletta-Andria-Trani"
            },
            new()
            { 
                Code = "BL",
                Type = "Province",
                Name = "Belluno",
                LocalName = "Belluno"
            },
            new()
            { 
                Code = "BN",
                Type = "Province",
                Name = "Benevento",
                LocalName = "Benevento"
            },
            new()
            { 
                Code = "BG",
                Type = "Province",
                Name = "Bergamo",
                LocalName = "Bergamo"
            },
            new()
            { 
                Code = "BI",
                Type = "Province",
                Name = "Biella",
                LocalName = "Biella"
            },
            new()
            { 
                Code = "BO",
                Type = "Province",
                Name = "Bologna",
                LocalName = "Bologna"
            },
            new()
            { 
                Code = "BZ",
                Type = "Province",
                Name = "Bolzano / Bozen",
                LocalName = "Bolzano / Bozen"
            },
            new()
            { 
                Code = "BS",
                Type = "Province",
                Name = "Brescia",
                LocalName = "Brescia"
            },
            new()
            { 
                Code = "BR",
                Type = "Province",
                Name = "Brindisi",
                LocalName = "Brindisi"
            },
            new()
            { 
                Code = "CA",
                Type = "Province",
                Name = "Cagliari",
                LocalName = "Cagliari"
            },
            new()
            { 
                Code = "CL",
                Type = "Province",
                Name = "Caltanissetta",
                LocalName = "Caltanissetta"
            },
            new()
            { 
                Code = "CB",
                Type = "Province",
                Name = "Campobasso",
                LocalName = "Campobasso"
            },
            new()
            { 
                Code = "CI",
                Type = "Province",
                Name = "Carbonia-Iglesias",
                LocalName = "Carbonia-Iglesias"
            },
            new()
            { 
                Code = "CE",
                Type = "Province",
                Name = "Caserta",
                LocalName = "Caserta"
            },
            new()
            { 
                Code = "CT",
                Type = "Province",
                Name = "Catania",
                LocalName = "Catania"
            },
            new()
            { 
                Code = "CZ",
                Type = "Province",
                Name = "Catanzaro",
                LocalName = "Catanzaro"
            },
            new()
            { 
                Code = "CH",
                Type = "Province",
                Name = "Chieti",
                LocalName = "Chieti"
            },
            new()
            { 
                Code = "CO",
                Type = "Province",
                Name = "Como",
                LocalName = "Como"
            },
            new()
            { 
                Code = "CS",
                Type = "Province",
                Name = "Cosenza",
                LocalName = "Cosenza"
            },
            new()
            { 
                Code = "CR",
                Type = "Province",
                Name = "Cremona",
                LocalName = "Cremona"
            },
            new()
            { 
                Code = "KR",
                Type = "Province",
                Name = "Crotone",
                LocalName = "Crotone"
            },
            new()
            { 
                Code = "CN",
                Type = "Province",
                Name = "Cuneo",
                LocalName = "Cuneo"
            },
            new()
            { 
                Code = "EN",
                Type = "Province",
                Name = "Enna",
                LocalName = "Enna"
            },
            new()
            { 
                Code = "FM",
                Type = "Province",
                Name = "Fermo",
                LocalName = "Fermo"
            },
            new()
            { 
                Code = "FE",
                Type = "Province",
                Name = "Ferrara",
                LocalName = "Ferrara"
            },
            new()
            { 
                Code = "FI",
                Type = "Province",
                Name = "Firenze",
                LocalName = "Firenze"
            },
            new()
            { 
                Code = "FG",
                Type = "Province",
                Name = "Foggia",
                LocalName = "Foggia"
            },
            new()
            { 
                Code = "FC",
                Type = "Province",
                Name = "Forlì-Cesena",
                LocalName = "Forlì-Cesena"
            },
            new()
            { 
                Code = "FR",
                Type = "Province",
                Name = "Frosinone",
                LocalName = "Frosinone"
            },
            new()
            { 
                Code = "GE",
                Type = "Province",
                Name = "Genova",
                LocalName = "Genova"
            },
            new()
            { 
                Code = "GO",
                Type = "Province",
                Name = "Gorizia",
                LocalName = "Gorizia"
            },
            new()
            { 
                Code = "GR",
                Type = "Province",
                Name = "Grosseto",
                LocalName = "Grosseto"
            },
            new()
            { 
                Code = "IM",
                Type = "Province",
                Name = "Imperia",
                LocalName = "Imperia"
            },
            new()
            { 
                Code = "IS",
                Type = "Province",
                Name = "Isernia",
                LocalName = "Isernia"
            },
            new()
            { 
                Code = "SP",
                Type = "Province",
                Name = "La Spezia",
                LocalName = "La Spezia"
            },
            new()
            { 
                Code = "AQ",
                Type = "Province",
                Name = "L'Aquila",
                LocalName = "L'Aquila"
            },
            new()
            { 
                Code = "LT",
                Type = "Province",
                Name = "Latina",
                LocalName = "Latina"
            },
            new()
            { 
                Code = "LE",
                Type = "Province",
                Name = "Lecce",
                LocalName = "Lecce"
            },
            new()
            { 
                Code = "LC",
                Type = "Province",
                Name = "Lecco",
                LocalName = "Lecco"
            },
            new()
            { 
                Code = "LI",
                Type = "Province",
                Name = "Livorno",
                LocalName = "Livorno"
            },
            new()
            { 
                Code = "LO",
                Type = "Province",
                Name = "Lodi",
                LocalName = "Lodi"
            },
            new()
            { 
                Code = "LU",
                Type = "Province",
                Name = "Lucca",
                LocalName = "Lucca"
            },
            new()
            { 
                Code = "MC",
                Type = "Province",
                Name = "Macerata",
                LocalName = "Macerata"
            },
            new()
            { 
                Code = "MN",
                Type = "Province",
                Name = "Mantova",
                LocalName = "Mantova"
            },
            new()
            { 
                Code = "MS",
                Type = "Province",
                Name = "Massa-Carrara",
                LocalName = "Massa-Carrara"
            },
            new()
            { 
                Code = "MT",
                Type = "Province",
                Name = "Matera",
                LocalName = "Matera"
            },
            new()
            { 
                Code = "VS",
                Type = "Province",
                Name = "Medio Campidano",
                LocalName = "Medio Campidano"
            },
            new()
            { 
                Code = "ME",
                Type = "Province",
                Name = "Messina",
                LocalName = "Messina"
            },
            new()
            { 
                Code = "MI",
                Type = "Province",
                Name = "Milano",
                LocalName = "Milano"
            },
            new()
            { 
                Code = "MO",
                Type = "Province",
                Name = "Modena",
                LocalName = "Modena"
            },
            new()
            { 
                Code = "MB",
                Type = "Province",
                Name = "Monza e Brianza",
                LocalName = "Monza e Brianza"
            },
            new()
            { 
                Code = "NA",
                Type = "Province",
                Name = "Napoli",
                LocalName = "Napoli"
            },
            new()
            { 
                Code = "NO",
                Type = "Province",
                Name = "Novara",
                LocalName = "Novara"
            },
            new()
            { 
                Code = "NU",
                Type = "Province",
                Name = "Nuoro",
                LocalName = "Nuoro"
            },
            new()
            { 
                Code = "OG",
                Type = "Province",
                Name = "Ogliastra",
                LocalName = "Ogliastra"
            },
            new()
            { 
                Code = "OT",
                Type = "Province",
                Name = "Olbia-Tempio",
                LocalName = "Olbia-Tempio"
            },
            new()
            { 
                Code = "OR",
                Type = "Province",
                Name = "Oristano",
                LocalName = "Oristano"
            },
            new()
            { 
                Code = "PD",
                Type = "Province",
                Name = "Padova",
                LocalName = "Padova"
            },
            new()
            { 
                Code = "PA",
                Type = "Province",
                Name = "Palermo",
                LocalName = "Palermo"
            },
            new()
            { 
                Code = "PR",
                Type = "Province",
                Name = "Parma",
                LocalName = "Parma"
            },
            new()
            { 
                Code = "PV",
                Type = "Province",
                Name = "Pavia",
                LocalName = "Pavia"
            },
            new()
            { 
                Code = "PG",
                Type = "Province",
                Name = "Perugia",
                LocalName = "Perugia"
            },
            new()
            { 
                Code = "PU",
                Type = "Province",
                Name = "Pesaro e Urbino",
                LocalName = "Pesaro e Urbino"
            },
            new()
            { 
                Code = "PE",
                Type = "Province",
                Name = "Pescara",
                LocalName = "Pescara"
            },
            new()
            { 
                Code = "PC",
                Type = "Province",
                Name = "Piacenza",
                LocalName = "Piacenza"
            },
            new()
            { 
                Code = "PI",
                Type = "Province",
                Name = "Pisa",
                LocalName = "Pisa"
            },
            new()
            { 
                Code = "PT",
                Type = "Province",
                Name = "Pistoia",
                LocalName = "Pistoia"
            },
            new()
            { 
                Code = "PN",
                Type = "Province",
                Name = "Pordenone",
                LocalName = "Pordenone"
            },
            new()
            { 
                Code = "PZ",
                Type = "Province",
                Name = "Potenza",
                LocalName = "Potenza"
            },
            new()
            { 
                Code = "PO",
                Type = "Province",
                Name = "Prato",
                LocalName = "Prato"
            },
            new()
            { 
                Code = "RG",
                Type = "Province",
                Name = "Ragusa",
                LocalName = "Ragusa"
            },
            new()
            { 
                Code = "RA",
                Type = "Province",
                Name = "Ravenna",
                LocalName = "Ravenna"
            },
            new()
            { 
                Code = "RC",
                Type = "Province",
                Name = "Reggio Calabria",
                LocalName = "Reggio Calabria"
            },
            new()
            { 
                Code = "RE",
                Type = "Province",
                Name = "Reggio Emilia",
                LocalName = "Reggio Emilia"
            },
            new()
            { 
                Code = "RI",
                Type = "Province",
                Name = "Rieti",
                LocalName = "Rieti"
            },
            new()
            { 
                Code = "RN",
                Type = "Province",
                Name = "Rimini",
                LocalName = "Rimini"
            },
            new()
            { 
                Code = "RM",
                Type = "Province",
                Name = "Roma",
                LocalName = "Roma"
            },
            new()
            { 
                Code = "RO",
                Type = "Province",
                Name = "Rovigo",
                LocalName = "Rovigo"
            },
            new()
            { 
                Code = "SA",
                Type = "Province",
                Name = "Salerno",
                LocalName = "Salerno"
            },
            new()
            { 
                Code = "SS",
                Type = "Province",
                Name = "Sassari",
                LocalName = "Sassari"
            },
            new()
            { 
                Code = "SV",
                Type = "Province",
                Name = "Savona",
                LocalName = "Savona"
            },
            new()
            { 
                Code = "SI",
                Type = "Province",
                Name = "Siena",
                LocalName = "Siena"
            },
            new()
            { 
                Code = "SR",
                Type = "Province",
                Name = "Siracusa",
                LocalName = "Siracusa"
            },
            new()
            { 
                Code = "SO",
                Type = "Province",
                Name = "Sondrio",
                LocalName = "Sondrio"
            },
            new()
            { 
                Code = "TA",
                Type = "Province",
                Name = "Taranto",
                LocalName = "Taranto"
            },
            new()
            { 
                Code = "TE",
                Type = "Province",
                Name = "Teramo",
                LocalName = "Teramo"
            },
            new()
            { 
                Code = "TR",
                Type = "Province",
                Name = "Terni",
                LocalName = "Terni"
            },
            new()
            { 
                Code = "TO",
                Type = "Province",
                Name = "Torino",
                LocalName = "Torino"
            },
            new()
            { 
                Code = "TP",
                Type = "Province",
                Name = "Trapani",
                LocalName = "Trapani"
            },
            new()
            { 
                Code = "TN",
                Type = "Province",
                Name = "Trento",
                LocalName = "Trento"
            },
            new()
            { 
                Code = "TV",
                Type = "Province",
                Name = "Treviso",
                LocalName = "Treviso"
            },
            new()
            { 
                Code = "TS",
                Type = "Province",
                Name = "Trieste",
                LocalName = "Trieste"
            },
            new()
            { 
                Code = "UD",
                Type = "Province",
                Name = "Udine",
                LocalName = "Udine"
            },
            new()
            { 
                Code = "VA",
                Type = "Province",
                Name = "Varese",
                LocalName = "Varese"
            },
            new()
            { 
                Code = "VE",
                Type = "Province",
                Name = "Venezia",
                LocalName = "Venezia"
            },
            new()
            { 
                Code = "VB",
                Type = "Province",
                Name = "Verbano-Cusio-Ossola",
                LocalName = "Verbano-Cusio-Ossola"
            },
            new()
            { 
                Code = "VC",
                Type = "Province",
                Name = "Vercelli",
                LocalName = "Vercelli"
            },
            new()
            { 
                Code = "VR",
                Type = "Province",
                Name = "Verona",
                LocalName = "Verona"
            },
            new()
            { 
                Code = "VV",
                Type = "Province",
                Name = "Vibo Valentia",
                LocalName = "Vibo Valentia"
            },
            new()
            { 
                Code = "VI",
                Type = "Province",
                Name = "Vicenza",
                LocalName = "Vicenza"
            },
            new()
            { 
                Code = "VT",
                Type = "Province",
                Name = "Viterbo",
                LocalName = "Viterbo"
            }

        });
    }
}
