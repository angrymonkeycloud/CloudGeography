using AngryMonkey.Cloud.Geography;
namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    private static void FillInSubdivisionsIT()
    {
        AddSubdivisions("IT",
        [
            new()
            { 
                Code = "AG",
                Type = SubdivisionTypes.Province,
                Name = "Agrigento",
                LocalName = "Agrigento"
            },
            new()
            { 
                Code = "AL",
                Type = SubdivisionTypes.Province,
                Name = "Alessandria",
                LocalName = "Alessandria"
            },
            new()
            { 
                Code = "AN",
                Type = SubdivisionTypes.Province,
                Name = "Ancona",
                LocalName = "Ancona"
            },
            new()
            { 
                Code = "AO",
                Type = SubdivisionTypes.Province,
                Name = "Aosta / Aoste",
                LocalName = "Aosta / Aoste"
            },
            new()
            { 
                Code = "AR",
                Type = SubdivisionTypes.Province,
                Name = "Arezzo",
                LocalName = "Arezzo"
            },
            new()
            { 
                Code = "AP",
                Type = SubdivisionTypes.Province,
                Name = "Ascoli Piceno",
                LocalName = "Ascoli Piceno"
            },
            new()
            { 
                Code = "AT",
                Type = SubdivisionTypes.Province,
                Name = "Asti",
                LocalName = "Asti"
            },
            new()
            { 
                Code = "AV",
                Type = SubdivisionTypes.Province,
                Name = "Avellino",
                LocalName = "Avellino"
            },
            new()
            { 
                Code = "BA",
                Type = SubdivisionTypes.Province,
                Name = "Bari",
                LocalName = "Bari"
            },
            new()
            { 
                Code = "BT",
                Type = SubdivisionTypes.Province,
                Name = "Barletta-Andria-Trani",
                LocalName = "Barletta-Andria-Trani"
            },
            new()
            { 
                Code = "BL",
                Type = SubdivisionTypes.Province,
                Name = "Belluno",
                LocalName = "Belluno"
            },
            new()
            { 
                Code = "BN",
                Type = SubdivisionTypes.Province,
                Name = "Benevento",
                LocalName = "Benevento"
            },
            new()
            { 
                Code = "BG",
                Type = SubdivisionTypes.Province,
                Name = "Bergamo",
                LocalName = "Bergamo"
            },
            new()
            { 
                Code = "BI",
                Type = SubdivisionTypes.Province,
                Name = "Biella",
                LocalName = "Biella"
            },
            new()
            { 
                Code = "BO",
                Type = SubdivisionTypes.Province,
                Name = "Bologna",
                LocalName = "Bologna"
            },
            new()
            { 
                Code = "BZ",
                Type = SubdivisionTypes.Province,
                Name = "Bolzano / Bozen",
                LocalName = "Bolzano / Bozen"
            },
            new()
            { 
                Code = "BS",
                Type = SubdivisionTypes.Province,
                Name = "Brescia",
                LocalName = "Brescia"
            },
            new()
            { 
                Code = "BR",
                Type = SubdivisionTypes.Province,
                Name = "Brindisi",
                LocalName = "Brindisi"
            },
            new()
            { 
                Code = "CA",
                Type = SubdivisionTypes.Province,
                Name = "Cagliari",
                LocalName = "Cagliari"
            },
            new()
            { 
                Code = "CL",
                Type = SubdivisionTypes.Province,
                Name = "Caltanissetta",
                LocalName = "Caltanissetta"
            },
            new()
            { 
                Code = "CB",
                Type = SubdivisionTypes.Province,
                Name = "Campobasso",
                LocalName = "Campobasso"
            },
            new()
            { 
                Code = "CI",
                Type = SubdivisionTypes.Province,
                Name = "Carbonia-Iglesias",
                LocalName = "Carbonia-Iglesias"
            },
            new()
            { 
                Code = "CE",
                Type = SubdivisionTypes.Province,
                Name = "Caserta",
                LocalName = "Caserta"
            },
            new()
            { 
                Code = "CT",
                Type = SubdivisionTypes.Province,
                Name = "Catania",
                LocalName = "Catania"
            },
            new()
            { 
                Code = "CZ",
                Type = SubdivisionTypes.Province,
                Name = "Catanzaro",
                LocalName = "Catanzaro"
            },
            new()
            { 
                Code = "CH",
                Type = SubdivisionTypes.Province,
                Name = "Chieti",
                LocalName = "Chieti"
            },
            new()
            { 
                Code = "CO",
                Type = SubdivisionTypes.Province,
                Name = "Como",
                LocalName = "Como"
            },
            new()
            { 
                Code = "CS",
                Type = SubdivisionTypes.Province,
                Name = "Cosenza",
                LocalName = "Cosenza"
            },
            new()
            { 
                Code = "CR",
                Type = SubdivisionTypes.Province,
                Name = "Cremona",
                LocalName = "Cremona"
            },
            new()
            { 
                Code = "KR",
                Type = SubdivisionTypes.Province,
                Name = "Crotone",
                LocalName = "Crotone"
            },
            new()
            { 
                Code = "CN",
                Type = SubdivisionTypes.Province,
                Name = "Cuneo",
                LocalName = "Cuneo"
            },
            new()
            { 
                Code = "EN",
                Type = SubdivisionTypes.Province,
                Name = "Enna",
                LocalName = "Enna"
            },
            new()
            { 
                Code = "FM",
                Type = SubdivisionTypes.Province,
                Name = "Fermo",
                LocalName = "Fermo"
            },
            new()
            { 
                Code = "FE",
                Type = SubdivisionTypes.Province,
                Name = "Ferrara",
                LocalName = "Ferrara"
            },
            new()
            { 
                Code = "FI",
                Type = SubdivisionTypes.Province,
                Name = "Firenze",
                LocalName = "Firenze"
            },
            new()
            { 
                Code = "FG",
                Type = SubdivisionTypes.Province,
                Name = "Foggia",
                LocalName = "Foggia"
            },
            new()
            { 
                Code = "FC",
                Type = SubdivisionTypes.Province,
                Name = "Forlì-Cesena",
                LocalName = "Forlì-Cesena"
            },
            new()
            { 
                Code = "FR",
                Type = SubdivisionTypes.Province,
                Name = "Frosinone",
                LocalName = "Frosinone"
            },
            new()
            { 
                Code = "GE",
                Type = SubdivisionTypes.Province,
                Name = "Genova",
                LocalName = "Genova"
            },
            new()
            { 
                Code = "GO",
                Type = SubdivisionTypes.Province,
                Name = "Gorizia",
                LocalName = "Gorizia"
            },
            new()
            { 
                Code = "GR",
                Type = SubdivisionTypes.Province,
                Name = "Grosseto",
                LocalName = "Grosseto"
            },
            new()
            { 
                Code = "IM",
                Type = SubdivisionTypes.Province,
                Name = "Imperia",
                LocalName = "Imperia"
            },
            new()
            { 
                Code = "IS",
                Type = SubdivisionTypes.Province,
                Name = "Isernia",
                LocalName = "Isernia"
            },
            new()
            { 
                Code = "SP",
                Type = SubdivisionTypes.Province,
                Name = "La Spezia",
                LocalName = "La Spezia"
            },
            new()
            { 
                Code = "AQ",
                Type = SubdivisionTypes.Province,
                Name = "L'Aquila",
                LocalName = "L'Aquila"
            },
            new()
            { 
                Code = "LT",
                Type = SubdivisionTypes.Province,
                Name = "Latina",
                LocalName = "Latina"
            },
            new()
            { 
                Code = "LE",
                Type = SubdivisionTypes.Province,
                Name = "Lecce",
                LocalName = "Lecce"
            },
            new()
            { 
                Code = "LC",
                Type = SubdivisionTypes.Province,
                Name = "Lecco",
                LocalName = "Lecco"
            },
            new()
            { 
                Code = "LI",
                Type = SubdivisionTypes.Province,
                Name = "Livorno",
                LocalName = "Livorno"
            },
            new()
            { 
                Code = "LO",
                Type = SubdivisionTypes.Province,
                Name = "Lodi",
                LocalName = "Lodi"
            },
            new()
            { 
                Code = "LU",
                Type = SubdivisionTypes.Province,
                Name = "Lucca",
                LocalName = "Lucca"
            },
            new()
            { 
                Code = "MC",
                Type = SubdivisionTypes.Province,
                Name = "Macerata",
                LocalName = "Macerata"
            },
            new()
            { 
                Code = "MN",
                Type = SubdivisionTypes.Province,
                Name = "Mantova",
                LocalName = "Mantova"
            },
            new()
            { 
                Code = "MS",
                Type = SubdivisionTypes.Province,
                Name = "Massa-Carrara",
                LocalName = "Massa-Carrara"
            },
            new()
            { 
                Code = "MT",
                Type = SubdivisionTypes.Province,
                Name = "Matera",
                LocalName = "Matera"
            },
            new()
            { 
                Code = "VS",
                Type = SubdivisionTypes.Province,
                Name = "Medio Campidano",
                LocalName = "Medio Campidano"
            },
            new()
            { 
                Code = "ME",
                Type = SubdivisionTypes.Province,
                Name = "Messina",
                LocalName = "Messina"
            },
            new()
            { 
                Code = "MI",
                Type = SubdivisionTypes.Province,
                Name = "Milano",
                LocalName = "Milano"
            },
            new()
            { 
                Code = "MO",
                Type = SubdivisionTypes.Province,
                Name = "Modena",
                LocalName = "Modena"
            },
            new()
            { 
                Code = "MB",
                Type = SubdivisionTypes.Province,
                Name = "Monza e Brianza",
                LocalName = "Monza e Brianza"
            },
            new()
            { 
                Code = "NA",
                Type = SubdivisionTypes.Province,
                Name = "Napoli",
                LocalName = "Napoli"
            },
            new()
            { 
                Code = "NO",
                Type = SubdivisionTypes.Province,
                Name = "Novara",
                LocalName = "Novara"
            },
            new()
            { 
                Code = "NU",
                Type = SubdivisionTypes.Province,
                Name = "Nuoro",
                LocalName = "Nuoro"
            },
            new()
            { 
                Code = "OG",
                Type = SubdivisionTypes.Province,
                Name = "Ogliastra",
                LocalName = "Ogliastra"
            },
            new()
            { 
                Code = "OT",
                Type = SubdivisionTypes.Province,
                Name = "Olbia-Tempio",
                LocalName = "Olbia-Tempio"
            },
            new()
            { 
                Code = "OR",
                Type = SubdivisionTypes.Province,
                Name = "Oristano",
                LocalName = "Oristano"
            },
            new()
            { 
                Code = "PD",
                Type = SubdivisionTypes.Province,
                Name = "Padova",
                LocalName = "Padova"
            },
            new()
            { 
                Code = "PA",
                Type = SubdivisionTypes.Province,
                Name = "Palermo",
                LocalName = "Palermo"
            },
            new()
            { 
                Code = "PR",
                Type = SubdivisionTypes.Province,
                Name = "Parma",
                LocalName = "Parma"
            },
            new()
            { 
                Code = "PV",
                Type = SubdivisionTypes.Province,
                Name = "Pavia",
                LocalName = "Pavia"
            },
            new()
            { 
                Code = "PG",
                Type = SubdivisionTypes.Province,
                Name = "Perugia",
                LocalName = "Perugia"
            },
            new()
            { 
                Code = "PU",
                Type = SubdivisionTypes.Province,
                Name = "Pesaro e Urbino",
                LocalName = "Pesaro e Urbino"
            },
            new()
            { 
                Code = "PE",
                Type = SubdivisionTypes.Province,
                Name = "Pescara",
                LocalName = "Pescara"
            },
            new()
            { 
                Code = "PC",
                Type = SubdivisionTypes.Province,
                Name = "Piacenza",
                LocalName = "Piacenza"
            },
            new()
            { 
                Code = "PI",
                Type = SubdivisionTypes.Province,
                Name = "Pisa",
                LocalName = "Pisa"
            },
            new()
            { 
                Code = "PT",
                Type = SubdivisionTypes.Province,
                Name = "Pistoia",
                LocalName = "Pistoia"
            },
            new()
            { 
                Code = "PN",
                Type = SubdivisionTypes.Province,
                Name = "Pordenone",
                LocalName = "Pordenone"
            },
            new()
            { 
                Code = "PZ",
                Type = SubdivisionTypes.Province,
                Name = "Potenza",
                LocalName = "Potenza"
            },
            new()
            { 
                Code = "PO",
                Type = SubdivisionTypes.Province,
                Name = "Prato",
                LocalName = "Prato"
            },
            new()
            { 
                Code = "RG",
                Type = SubdivisionTypes.Province,
                Name = "Ragusa",
                LocalName = "Ragusa"
            },
            new()
            { 
                Code = "RA",
                Type = SubdivisionTypes.Province,
                Name = "Ravenna",
                LocalName = "Ravenna"
            },
            new()
            { 
                Code = "RC",
                Type = SubdivisionTypes.Province,
                Name = "Reggio Calabria",
                LocalName = "Reggio Calabria"
            },
            new()
            { 
                Code = "RE",
                Type = SubdivisionTypes.Province,
                Name = "Reggio Emilia",
                LocalName = "Reggio Emilia"
            },
            new()
            { 
                Code = "RI",
                Type = SubdivisionTypes.Province,
                Name = "Rieti",
                LocalName = "Rieti"
            },
            new()
            { 
                Code = "RN",
                Type = SubdivisionTypes.Province,
                Name = "Rimini",
                LocalName = "Rimini"
            },
            new()
            { 
                Code = "RM",
                Type = SubdivisionTypes.Province,
                Name = "Roma",
                LocalName = "Roma"
            },
            new()
            { 
                Code = "RO",
                Type = SubdivisionTypes.Province,
                Name = "Rovigo",
                LocalName = "Rovigo"
            },
            new()
            { 
                Code = "SA",
                Type = SubdivisionTypes.Province,
                Name = "Salerno",
                LocalName = "Salerno"
            },
            new()
            { 
                Code = "SS",
                Type = SubdivisionTypes.Province,
                Name = "Sassari",
                LocalName = "Sassari"
            },
            new()
            { 
                Code = "SV",
                Type = SubdivisionTypes.Province,
                Name = "Savona",
                LocalName = "Savona"
            },
            new()
            { 
                Code = "SI",
                Type = SubdivisionTypes.Province,
                Name = "Siena",
                LocalName = "Siena"
            },
            new()
            { 
                Code = "SR",
                Type = SubdivisionTypes.Province,
                Name = "Siracusa",
                LocalName = "Siracusa"
            },
            new()
            { 
                Code = "SO",
                Type = SubdivisionTypes.Province,
                Name = "Sondrio",
                LocalName = "Sondrio"
            },
            new()
            { 
                Code = "TA",
                Type = SubdivisionTypes.Province,
                Name = "Taranto",
                LocalName = "Taranto"
            },
            new()
            { 
                Code = "TE",
                Type = SubdivisionTypes.Province,
                Name = "Teramo",
                LocalName = "Teramo"
            },
            new()
            { 
                Code = "TR",
                Type = SubdivisionTypes.Province,
                Name = "Terni",
                LocalName = "Terni"
            },
            new()
            { 
                Code = "TO",
                Type = SubdivisionTypes.Province,
                Name = "Torino",
                LocalName = "Torino"
            },
            new()
            { 
                Code = "TP",
                Type = SubdivisionTypes.Province,
                Name = "Trapani",
                LocalName = "Trapani"
            },
            new()
            { 
                Code = "TN",
                Type = SubdivisionTypes.Province,
                Name = "Trento",
                LocalName = "Trento"
            },
            new()
            { 
                Code = "TV",
                Type = SubdivisionTypes.Province,
                Name = "Treviso",
                LocalName = "Treviso"
            },
            new()
            { 
                Code = "TS",
                Type = SubdivisionTypes.Province,
                Name = "Trieste",
                LocalName = "Trieste"
            },
            new()
            { 
                Code = "UD",
                Type = SubdivisionTypes.Province,
                Name = "Udine",
                LocalName = "Udine"
            },
            new()
            { 
                Code = "VA",
                Type = SubdivisionTypes.Province,
                Name = "Varese",
                LocalName = "Varese"
            },
            new()
            { 
                Code = "VE",
                Type = SubdivisionTypes.Province,
                Name = "Venezia",
                LocalName = "Venezia"
            },
            new()
            { 
                Code = "VB",
                Type = SubdivisionTypes.Province,
                Name = "Verbano-Cusio-Ossola",
                LocalName = "Verbano-Cusio-Ossola"
            },
            new()
            { 
                Code = "VC",
                Type = SubdivisionTypes.Province,
                Name = "Vercelli",
                LocalName = "Vercelli"
            },
            new()
            { 
                Code = "VR",
                Type = SubdivisionTypes.Province,
                Name = "Verona",
                LocalName = "Verona"
            },
            new()
            { 
                Code = "VV",
                Type = SubdivisionTypes.Province,
                Name = "Vibo Valentia",
                LocalName = "Vibo Valentia"
            },
            new()
            { 
                Code = "VI",
                Type = SubdivisionTypes.Province,
                Name = "Vicenza",
                LocalName = "Vicenza"
            },
            new()
            { 
                Code = "VT",
                Type = SubdivisionTypes.Province,
                Name = "Viterbo",
                LocalName = "Viterbo"
            }

        ]);
    }
}
