using AngryMonkey.Cloud.Geography;
namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    private static void FillInSubdivisionsAZ()
    {
        AddSubdivisions("AZ",
        [
            new()
            { 
                Code = "ABS",
                Type = SubdivisionTypes.Rayon,
                Name = "Abseron",
                LocalName = "Abseron"
            },
            new()
            { 
                Code = "AGC",
                Type = SubdivisionTypes.Rayon,
                Name = "Agcab?di",
                LocalName = "Agcab?di"
            },
            new()
            { 
                Code = "AGM",
                Type = SubdivisionTypes.Rayon,
                Name = "Agdam",
                LocalName = "Agdam"
            },
            new()
            { 
                Code = "AGS",
                Type = SubdivisionTypes.Rayon,
                Name = "Agdas",
                LocalName = "Agdas"
            },
            new()
            { 
                Code = "AGA",
                Type = SubdivisionTypes.Rayon,
                Name = "Agstafa",
                LocalName = "Agstafa"
            },
            new()
            { 
                Code = "AGU",
                Type = SubdivisionTypes.Rayon,
                Name = "Agsu",
                LocalName = "Agsu"
            },
            new()
            { 
                Code = "AST",
                Type = SubdivisionTypes.Rayon,
                Name = "Astara",
                LocalName = "Astara"
            },
            new()
            { 
                Code = "BAR",
                Type = SubdivisionTypes.Rayon,
                Name = "B?rd?",
                LocalName = "B?rd?"
            },
            new()
            { 
                Code = "BAB",
                Type = SubdivisionTypes.Rayon,
                Name = "Bab?k",
                LocalName = "Bab?k"
            },
            new()
            { 
                Code = "BA",
                Type = SubdivisionTypes.Municipality,
                Name = "Baki",
                LocalName = "Baki"
            },
            new()
            { 
                Code = "BAL",
                Type = SubdivisionTypes.Rayon,
                Name = "Balak?n",
                LocalName = "Balak?n"
            },
            new()
            { 
                Code = "BEY",
                Type = SubdivisionTypes.Rayon,
                Name = "Beyl?qan",
                LocalName = "Beyl?qan"
            },
            new()
            { 
                Code = "BIL",
                Type = SubdivisionTypes.Rayon,
                Name = "Bil?suvar",
                LocalName = "Bil?suvar"
            },
            new()
            { 
                Code = "CAB",
                Type = SubdivisionTypes.Rayon,
                Name = "C?brayil",
                LocalName = "C?brayil"
            },
            new()
            { 
                Code = "CAL",
                Type = SubdivisionTypes.Rayon,
                Name = "C?lilabad",
                LocalName = "C?lilabad"
            },
            new()
            { 
                Code = "CUL",
                Type = SubdivisionTypes.Rayon,
                Name = "Culfa",
                LocalName = "Culfa"
            },
            new()
            { 
                Code = "DAS",
                Type = SubdivisionTypes.Rayon,
                Name = "Dask?s?n",
                LocalName = "Dask?s?n"
            },
            new()
            { 
                Code = "FUZ",
                Type = SubdivisionTypes.Rayon,
                Name = "Füzuli",
                LocalName = "Füzuli"
            },
            new()
            { 
                Code = "GAD",
                Type = SubdivisionTypes.Rayon,
                Name = "G?d?b?y",
                LocalName = "G?d?b?y"
            },
            new()
            { 
                Code = "GA",
                Type = SubdivisionTypes.Municipality,
                Name = "G?nc?",
                LocalName = "G?nc?"
            },
            new()
            { 
                Code = "GOR",
                Type = SubdivisionTypes.Rayon,
                Name = "Goranboy",
                LocalName = "Goranboy"
            },
            new()
            { 
                Code = "GOY",
                Type = SubdivisionTypes.Rayon,
                Name = "Göyçay",
                LocalName = "Göyçay"
            },
            new()
            { 
                Code = "GYG",
                Type = SubdivisionTypes.Rayon,
                Name = "Göygöl",
                LocalName = "Göygöl"
            },
            new()
            { 
                Code = "HAC",
                Type = SubdivisionTypes.Rayon,
                Name = "Haciqabul",
                LocalName = "Haciqabul"
            },
            new()
            { 
                Code = "IMI",
                Type = SubdivisionTypes.Rayon,
                Name = "Imisli",
                LocalName = "Imisli"
            },
            new()
            { 
                Code = "ISM",
                Type = SubdivisionTypes.Rayon,
                Name = "Ismayilli",
                LocalName = "Ismayilli"
            },
            new()
            { 
                Code = "KAL",
                Type = SubdivisionTypes.Rayon,
                Name = "K?lb?c?r",
                LocalName = "K?lb?c?r"
            },
            new()
            { 
                Code = "KAN",
                Type = SubdivisionTypes.Rayon,
                Name = "K?ng?rli",
                LocalName = "K?ng?rli"
            },
            new()
            { 
                Code = "KUR",
                Type = SubdivisionTypes.Rayon,
                Name = "Kürd?mir",
                LocalName = "Kürd?mir"
            },
            new()
            { 
                Code = "LA",
                Type = SubdivisionTypes.Municipality,
                Name = "L?nk?ran",
                LocalName = "L?nk?ran"
            },
            new()
            { 
                Code = "LAN",
                Type = SubdivisionTypes.Rayon,
                Name = "L?nk?ran",
                LocalName = "L?nk?ran"
            },
            new()
            { 
                Code = "LAC",
                Type = SubdivisionTypes.Rayon,
                Name = "Laçin",
                LocalName = "Laçin"
            },
            new()
            { 
                Code = "LER",
                Type = SubdivisionTypes.Rayon,
                Name = "Lerik",
                LocalName = "Lerik"
            },
            new()
            { 
                Code = "MAS",
                Type = SubdivisionTypes.Rayon,
                Name = "Masalli",
                LocalName = "Masalli"
            },
            new()
            { 
                Code = "MI",
                Type = SubdivisionTypes.Municipality,
                Name = "Ming?çevir",
                LocalName = "Ming?çevir"
            },
            new()
            { 
                Code = "NA",
                Type = SubdivisionTypes.Municipality,
                Name = "Naftalan",
                LocalName = "Naftalan"
            },
            new()
            { 
                Code = "NX",
                Type = SubdivisionTypes.Republic,
                Name = "Naxçivan",
                LocalName = "Naxçivan"
            },
            new()
            { 
                Code = "NV",
                Type = SubdivisionTypes.Municipality,
                Name = "Naxçivan",
                LocalName = "Naxçivan"
            },
            new()
            { 
                Code = "NEF",
                Type = SubdivisionTypes.Rayon,
                Name = "Neftçala",
                LocalName = "Neftçala"
            },
            new()
            { 
                Code = "OGU",
                Type = SubdivisionTypes.Rayon,
                Name = "Oguz",
                LocalName = "Oguz"
            },
            new()
            { 
                Code = "ORD",
                Type = SubdivisionTypes.Rayon,
                Name = "Ordubad",
                LocalName = "Ordubad"
            },
            new()
            { 
                Code = "QAB",
                Type = SubdivisionTypes.Rayon,
                Name = "Q?b?l?",
                LocalName = "Q?b?l?"
            },
            new()
            { 
                Code = "QAX",
                Type = SubdivisionTypes.Rayon,
                Name = "Qax",
                LocalName = "Qax"
            },
            new()
            { 
                Code = "QAZ",
                Type = SubdivisionTypes.Rayon,
                Name = "Qazax",
                LocalName = "Qazax"
            },
            new()
            { 
                Code = "QOB",
                Type = SubdivisionTypes.Rayon,
                Name = "Qobustan",
                LocalName = "Qobustan"
            },
            new()
            { 
                Code = "QBA",
                Type = SubdivisionTypes.Rayon,
                Name = "Quba",
                LocalName = "Quba"
            },
            new()
            { 
                Code = "QBI",
                Type = SubdivisionTypes.Rayon,
                Name = "Qubadli",
                LocalName = "Qubadli"
            },
            new()
            { 
                Code = "QUS",
                Type = SubdivisionTypes.Rayon,
                Name = "Qusar",
                LocalName = "Qusar"
            },
            new()
            { 
                Code = "SAD",
                Type = SubdivisionTypes.Rayon,
                Name = "S?d?r?k",
                LocalName = "S?d?r?k"
            },
            new()
            { 
                Code = "SA",
                Type = SubdivisionTypes.Municipality,
                Name = "S?ki",
                LocalName = "S?ki"
            },
            new()
            { 
                Code = "SAK",
                Type = SubdivisionTypes.Rayon,
                Name = "S?ki",
                LocalName = "S?ki"
            },
            new()
            { 
                Code = "SKR",
                Type = SubdivisionTypes.Rayon,
                Name = "S?mkir",
                LocalName = "S?mkir"
            },
            new()
            { 
                Code = "SAR",
                Type = SubdivisionTypes.Rayon,
                Name = "S?rur",
                LocalName = "S?rur"
            },
            new()
            { 
                Code = "SAT",
                Type = SubdivisionTypes.Rayon,
                Name = "Saatli",
                LocalName = "Saatli"
            },
            new()
            { 
                Code = "SAB",
                Type = SubdivisionTypes.Rayon,
                Name = "Sabirabad",
                LocalName = "Sabirabad"
            },
            new()
            { 
                Code = "SBN",
                Type = SubdivisionTypes.Rayon,
                Name = "Sabran",
                LocalName = "Sabran"
            },
            new()
            { 
                Code = "SAH",
                Type = SubdivisionTypes.Rayon,
                Name = "Sahbuz",
                LocalName = "Sahbuz"
            },
            new()
            { 
                Code = "SAL",
                Type = SubdivisionTypes.Rayon,
                Name = "Salyan",
                LocalName = "Salyan"
            },
            new()
            { 
                Code = "SMI",
                Type = SubdivisionTypes.Rayon,
                Name = "Samaxi",
                LocalName = "Samaxi"
            },
            new()
            { 
                Code = "SMX",
                Type = SubdivisionTypes.Rayon,
                Name = "Samux",
                LocalName = "Samux"
            },
            new()
            { 
                Code = "SR",
                Type = SubdivisionTypes.Municipality,
                Name = "Sirvan",
                LocalName = "Sirvan"
            },
            new()
            { 
                Code = "SIY",
                Type = SubdivisionTypes.Rayon,
                Name = "Siy?z?n",
                LocalName = "Siy?z?n"
            },
            new()
            { 
                Code = "SM",
                Type = SubdivisionTypes.Municipality,
                Name = "Sumqayit",
                LocalName = "Sumqayit"
            },
            new()
            { 
                Code = "SUS",
                Type = SubdivisionTypes.Rayon,
                Name = "Susa",
                LocalName = "Susa"
            },
            new()
            { 
                Code = "TAR",
                Type = SubdivisionTypes.Rayon,
                Name = "T?rt?r",
                LocalName = "T?rt?r"
            },
            new()
            { 
                Code = "TOV",
                Type = SubdivisionTypes.Rayon,
                Name = "Tovuz",
                LocalName = "Tovuz"
            },
            new()
            { 
                Code = "UCA",
                Type = SubdivisionTypes.Rayon,
                Name = "Ucar",
                LocalName = "Ucar"
            },
            new()
            { 
                Code = "XAC",
                Type = SubdivisionTypes.Rayon,
                Name = "Xaçmaz",
                LocalName = "Xaçmaz"
            },
            new()
            { 
                Code = "XA",
                Type = SubdivisionTypes.Municipality,
                Name = "Xank?ndi",
                LocalName = "Xank?ndi"
            },
            new()
            { 
                Code = "XIZ",
                Type = SubdivisionTypes.Rayon,
                Name = "Xizi",
                LocalName = "Xizi"
            },
            new()
            { 
                Code = "XCI",
                Type = SubdivisionTypes.Rayon,
                Name = "Xocali",
                LocalName = "Xocali"
            },
            new()
            { 
                Code = "XVD",
                Type = SubdivisionTypes.Rayon,
                Name = "Xocav?nd",
                LocalName = "Xocav?nd"
            },
            new()
            { 
                Code = "YAR",
                Type = SubdivisionTypes.Rayon,
                Name = "Yardimli",
                LocalName = "Yardimli"
            },
            new()
            { 
                Code = "YEV",
                Type = SubdivisionTypes.Rayon,
                Name = "Yevlax",
                LocalName = "Yevlax"
            },
            new()
            { 
                Code = "YE",
                Type = SubdivisionTypes.Municipality,
                Name = "Yevlax",
                LocalName = "Yevlax"
            },
            new()
            { 
                Code = "ZAN",
                Type = SubdivisionTypes.Rayon,
                Name = "Z?ngilan",
                LocalName = "Z?ngilan"
            },
            new()
            { 
                Code = "ZAR",
                Type = SubdivisionTypes.Rayon,
                Name = "Z?rdab",
                LocalName = "Z?rdab"
            },
            new()
            { 
                Code = "ZAQ",
                Type = SubdivisionTypes.Rayon,
                Name = "Zaqatala",
                LocalName = "Zaqatala"
            }

        ]);
    }
}
