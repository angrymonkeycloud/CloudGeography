using AngryMonkey.Cloud.Geography;
namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    private static void FillInSubdivisionsAZ()
    {
        AddSubdivisions("AZ", new List<Subdivision>()
        {
            new()
            { 
                Code = "ABS",
                Type = "Rayon",
                Name = "Abseron",
                LocalName = "Abseron"
            },
            new()
            { 
                Code = "AGC",
                Type = "Rayon",
                Name = "Agcab?di",
                LocalName = "Agcab?di"
            },
            new()
            { 
                Code = "AGM",
                Type = "Rayon",
                Name = "Agdam",
                LocalName = "Agdam"
            },
            new()
            { 
                Code = "AGS",
                Type = "Rayon",
                Name = "Agdas",
                LocalName = "Agdas"
            },
            new()
            { 
                Code = "AGA",
                Type = "Rayon",
                Name = "Agstafa",
                LocalName = "Agstafa"
            },
            new()
            { 
                Code = "AGU",
                Type = "Rayon",
                Name = "Agsu",
                LocalName = "Agsu"
            },
            new()
            { 
                Code = "AST",
                Type = "Rayon",
                Name = "Astara",
                LocalName = "Astara"
            },
            new()
            { 
                Code = "BAR",
                Type = "Rayon",
                Name = "B?rd?",
                LocalName = "B?rd?"
            },
            new()
            { 
                Code = "BAB",
                Type = "Rayon",
                Name = "Bab?k",
                LocalName = "Bab?k"
            },
            new()
            { 
                Code = "BA",
                Type = "Municipality",
                Name = "Baki",
                LocalName = "Baki"
            },
            new()
            { 
                Code = "BAL",
                Type = "Rayon",
                Name = "Balak?n",
                LocalName = "Balak?n"
            },
            new()
            { 
                Code = "BEY",
                Type = "Rayon",
                Name = "Beyl?qan",
                LocalName = "Beyl?qan"
            },
            new()
            { 
                Code = "BIL",
                Type = "Rayon",
                Name = "Bil?suvar",
                LocalName = "Bil?suvar"
            },
            new()
            { 
                Code = "CAB",
                Type = "Rayon",
                Name = "C?brayil",
                LocalName = "C?brayil"
            },
            new()
            { 
                Code = "CAL",
                Type = "Rayon",
                Name = "C?lilabad",
                LocalName = "C?lilabad"
            },
            new()
            { 
                Code = "CUL",
                Type = "Rayon",
                Name = "Culfa",
                LocalName = "Culfa"
            },
            new()
            { 
                Code = "DAS",
                Type = "Rayon",
                Name = "Dask?s?n",
                LocalName = "Dask?s?n"
            },
            new()
            { 
                Code = "FUZ",
                Type = "Rayon",
                Name = "Füzuli",
                LocalName = "Füzuli"
            },
            new()
            { 
                Code = "GAD",
                Type = "Rayon",
                Name = "G?d?b?y",
                LocalName = "G?d?b?y"
            },
            new()
            { 
                Code = "GA",
                Type = "Municipality",
                Name = "G?nc?",
                LocalName = "G?nc?"
            },
            new()
            { 
                Code = "GOR",
                Type = "Rayon",
                Name = "Goranboy",
                LocalName = "Goranboy"
            },
            new()
            { 
                Code = "GOY",
                Type = "Rayon",
                Name = "Göyçay",
                LocalName = "Göyçay"
            },
            new()
            { 
                Code = "GYG",
                Type = "Rayon",
                Name = "Göygöl",
                LocalName = "Göygöl"
            },
            new()
            { 
                Code = "HAC",
                Type = "Rayon",
                Name = "Haciqabul",
                LocalName = "Haciqabul"
            },
            new()
            { 
                Code = "IMI",
                Type = "Rayon",
                Name = "Imisli",
                LocalName = "Imisli"
            },
            new()
            { 
                Code = "ISM",
                Type = "Rayon",
                Name = "Ismayilli",
                LocalName = "Ismayilli"
            },
            new()
            { 
                Code = "KAL",
                Type = "Rayon",
                Name = "K?lb?c?r",
                LocalName = "K?lb?c?r"
            },
            new()
            { 
                Code = "KAN",
                Type = "Rayon",
                Name = "K?ng?rli",
                LocalName = "K?ng?rli"
            },
            new()
            { 
                Code = "KUR",
                Type = "Rayon",
                Name = "Kürd?mir",
                LocalName = "Kürd?mir"
            },
            new()
            { 
                Code = "LA",
                Type = "Municipality",
                Name = "L?nk?ran",
                LocalName = "L?nk?ran"
            },
            new()
            { 
                Code = "LAN",
                Type = "Rayon",
                Name = "L?nk?ran",
                LocalName = "L?nk?ran"
            },
            new()
            { 
                Code = "LAC",
                Type = "Rayon",
                Name = "Laçin",
                LocalName = "Laçin"
            },
            new()
            { 
                Code = "LER",
                Type = "Rayon",
                Name = "Lerik",
                LocalName = "Lerik"
            },
            new()
            { 
                Code = "MAS",
                Type = "Rayon",
                Name = "Masalli",
                LocalName = "Masalli"
            },
            new()
            { 
                Code = "MI",
                Type = "Municipality",
                Name = "Ming?çevir",
                LocalName = "Ming?çevir"
            },
            new()
            { 
                Code = "NA",
                Type = "Municipality",
                Name = "Naftalan",
                LocalName = "Naftalan"
            },
            new()
            { 
                Code = "NX",
                Type = "Republic",
                Name = "Naxçivan",
                LocalName = "Naxçivan"
            },
            new()
            { 
                Code = "NV",
                Type = "Municipality",
                Name = "Naxçivan",
                LocalName = "Naxçivan"
            },
            new()
            { 
                Code = "NEF",
                Type = "Rayon",
                Name = "Neftçala",
                LocalName = "Neftçala"
            },
            new()
            { 
                Code = "OGU",
                Type = "Rayon",
                Name = "Oguz",
                LocalName = "Oguz"
            },
            new()
            { 
                Code = "ORD",
                Type = "Rayon",
                Name = "Ordubad",
                LocalName = "Ordubad"
            },
            new()
            { 
                Code = "QAB",
                Type = "Rayon",
                Name = "Q?b?l?",
                LocalName = "Q?b?l?"
            },
            new()
            { 
                Code = "QAX",
                Type = "Rayon",
                Name = "Qax",
                LocalName = "Qax"
            },
            new()
            { 
                Code = "QAZ",
                Type = "Rayon",
                Name = "Qazax",
                LocalName = "Qazax"
            },
            new()
            { 
                Code = "QOB",
                Type = "Rayon",
                Name = "Qobustan",
                LocalName = "Qobustan"
            },
            new()
            { 
                Code = "QBA",
                Type = "Rayon",
                Name = "Quba",
                LocalName = "Quba"
            },
            new()
            { 
                Code = "QBI",
                Type = "Rayon",
                Name = "Qubadli",
                LocalName = "Qubadli"
            },
            new()
            { 
                Code = "QUS",
                Type = "Rayon",
                Name = "Qusar",
                LocalName = "Qusar"
            },
            new()
            { 
                Code = "SAD",
                Type = "Rayon",
                Name = "S?d?r?k",
                LocalName = "S?d?r?k"
            },
            new()
            { 
                Code = "SA",
                Type = "Municipality",
                Name = "S?ki",
                LocalName = "S?ki"
            },
            new()
            { 
                Code = "SAK",
                Type = "Rayon",
                Name = "S?ki",
                LocalName = "S?ki"
            },
            new()
            { 
                Code = "SKR",
                Type = "Rayon",
                Name = "S?mkir",
                LocalName = "S?mkir"
            },
            new()
            { 
                Code = "SAR",
                Type = "Rayon",
                Name = "S?rur",
                LocalName = "S?rur"
            },
            new()
            { 
                Code = "SAT",
                Type = "Rayon",
                Name = "Saatli",
                LocalName = "Saatli"
            },
            new()
            { 
                Code = "SAB",
                Type = "Rayon",
                Name = "Sabirabad",
                LocalName = "Sabirabad"
            },
            new()
            { 
                Code = "SBN",
                Type = "Rayon",
                Name = "Sabran",
                LocalName = "Sabran"
            },
            new()
            { 
                Code = "SAH",
                Type = "Rayon",
                Name = "Sahbuz",
                LocalName = "Sahbuz"
            },
            new()
            { 
                Code = "SAL",
                Type = "Rayon",
                Name = "Salyan",
                LocalName = "Salyan"
            },
            new()
            { 
                Code = "SMI",
                Type = "Rayon",
                Name = "Samaxi",
                LocalName = "Samaxi"
            },
            new()
            { 
                Code = "SMX",
                Type = "Rayon",
                Name = "Samux",
                LocalName = "Samux"
            },
            new()
            { 
                Code = "SR",
                Type = "Municipality",
                Name = "Sirvan",
                LocalName = "Sirvan"
            },
            new()
            { 
                Code = "SIY",
                Type = "Rayon",
                Name = "Siy?z?n",
                LocalName = "Siy?z?n"
            },
            new()
            { 
                Code = "SM",
                Type = "Municipality",
                Name = "Sumqayit",
                LocalName = "Sumqayit"
            },
            new()
            { 
                Code = "SUS",
                Type = "Rayon",
                Name = "Susa",
                LocalName = "Susa"
            },
            new()
            { 
                Code = "TAR",
                Type = "Rayon",
                Name = "T?rt?r",
                LocalName = "T?rt?r"
            },
            new()
            { 
                Code = "TOV",
                Type = "Rayon",
                Name = "Tovuz",
                LocalName = "Tovuz"
            },
            new()
            { 
                Code = "UCA",
                Type = "Rayon",
                Name = "Ucar",
                LocalName = "Ucar"
            },
            new()
            { 
                Code = "XAC",
                Type = "Rayon",
                Name = "Xaçmaz",
                LocalName = "Xaçmaz"
            },
            new()
            { 
                Code = "XA",
                Type = "Municipality",
                Name = "Xank?ndi",
                LocalName = "Xank?ndi"
            },
            new()
            { 
                Code = "XIZ",
                Type = "Rayon",
                Name = "Xizi",
                LocalName = "Xizi"
            },
            new()
            { 
                Code = "XCI",
                Type = "Rayon",
                Name = "Xocali",
                LocalName = "Xocali"
            },
            new()
            { 
                Code = "XVD",
                Type = "Rayon",
                Name = "Xocav?nd",
                LocalName = "Xocav?nd"
            },
            new()
            { 
                Code = "YAR",
                Type = "Rayon",
                Name = "Yardimli",
                LocalName = "Yardimli"
            },
            new()
            { 
                Code = "YEV",
                Type = "Rayon",
                Name = "Yevlax",
                LocalName = "Yevlax"
            },
            new()
            { 
                Code = "YE",
                Type = "Municipality",
                Name = "Yevlax",
                LocalName = "Yevlax"
            },
            new()
            { 
                Code = "ZAN",
                Type = "Rayon",
                Name = "Z?ngilan",
                LocalName = "Z?ngilan"
            },
            new()
            { 
                Code = "ZAR",
                Type = "Rayon",
                Name = "Z?rdab",
                LocalName = "Z?rdab"
            },
            new()
            { 
                Code = "ZAQ",
                Type = "Rayon",
                Name = "Zaqatala",
                LocalName = "Zaqatala"
            }

        });
    }
}
