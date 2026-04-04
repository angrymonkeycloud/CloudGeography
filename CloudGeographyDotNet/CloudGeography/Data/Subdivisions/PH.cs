using AngryMonkey.Cloud.Geography;
namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    private static void FillInSubdivisionsPH()
    {
        AddSubdivisions("PH",
        [
            new()
            { 
                Code = "ABR",
                Type = SubdivisionTypes.Province,
                Name = "Abra",
                LocalName = "Abra"
            },
            new()
            { 
                Code = "AGN",
                Type = SubdivisionTypes.Province,
                Name = "Agusan del Norte",
                LocalName = "Agusan del Norte"
            },
            new()
            { 
                Code = "AGS",
                Type = SubdivisionTypes.Province,
                Name = "Agusan del Sur",
                LocalName = "Agusan del Sur"
            },
            new()
            { 
                Code = "AKL",
                Type = SubdivisionTypes.Province,
                Name = "Aklan",
                LocalName = "Aklan"
            },
            new()
            { 
                Code = "ALB",
                Type = SubdivisionTypes.Province,
                Name = "Albay",
                LocalName = "Albay"
            },
            new()
            { 
                Code = "ANT",
                Type = SubdivisionTypes.Province,
                Name = "Antique",
                LocalName = "Antique"
            },
            new()
            { 
                Code = "APA",
                Type = SubdivisionTypes.Province,
                Name = "Apayao",
                LocalName = "Apayao"
            },
            new()
            { 
                Code = "AUR",
                Type = SubdivisionTypes.Province,
                Name = "Aurora",
                LocalName = "Aurora"
            },
            new()
            { 
                Code = "BAS",
                Type = SubdivisionTypes.Province,
                Name = "Basilan",
                LocalName = "Basilan"
            },
            new()
            { 
                Code = "BAN",
                Type = SubdivisionTypes.Province,
                Name = "Bataan",
                LocalName = "Bataan"
            },
            new()
            { 
                Code = "BTN",
                Type = SubdivisionTypes.Province,
                Name = "Batanes",
                LocalName = "Batanes"
            },
            new()
            { 
                Code = "BTG",
                Type = SubdivisionTypes.Province,
                Name = "Batangas",
                LocalName = "Batangas"
            },
            new()
            { 
                Code = "BEN",
                Type = SubdivisionTypes.Province,
                Name = "Benguet",
                LocalName = "Benguet"
            },
            new()
            { 
                Code = "BIL",
                Type = SubdivisionTypes.Province,
                Name = "Biliran",
                LocalName = "Biliran"
            },
            new()
            { 
                Code = "BOH",
                Type = SubdivisionTypes.Province,
                Name = "Bohol",
                LocalName = "Bohol"
            },
            new()
            { 
                Code = "BUK",
                Type = SubdivisionTypes.Province,
                Name = "Bukidnon",
                LocalName = "Bukidnon"
            },
            new()
            { 
                Code = "BUL",
                Type = SubdivisionTypes.Province,
                Name = "Bulacan",
                LocalName = "Bulacan"
            },
            new()
            { 
                Code = "CAG",
                Type = SubdivisionTypes.Province,
                Name = "Cagayan",
                LocalName = "Cagayan"
            },
            new()
            { 
                Code = "CAN",
                Type = SubdivisionTypes.Province,
                Name = "Camarines Norte",
                LocalName = "Camarines Norte"
            },
            new()
            { 
                Code = "CAS",
                Type = SubdivisionTypes.Province,
                Name = "Camarines Sur",
                LocalName = "Camarines Sur"
            },
            new()
            { 
                Code = "CAM",
                Type = SubdivisionTypes.Province,
                Name = "Camiguin",
                LocalName = "Camiguin"
            },
            new()
            { 
                Code = "CAP",
                Type = SubdivisionTypes.Province,
                Name = "Capiz",
                LocalName = "Capiz"
            },
            new()
            { 
                Code = "CAT",
                Type = SubdivisionTypes.Province,
                Name = "Catanduanes",
                LocalName = "Catanduanes"
            },
            new()
            { 
                Code = "CAV",
                Type = SubdivisionTypes.Province,
                Name = "Cavite",
                LocalName = "Cavite"
            },
            new()
            { 
                Code = "CEB",
                Type = SubdivisionTypes.Province,
                Name = "Cebu",
                LocalName = "Cebu"
            },
            new()
            { 
                Code = "COM",
                Type = SubdivisionTypes.Province,
                Name = "Compostela Valley",
                LocalName = "Compostela Valley"
            },
            new()
            { 
                Code = "DAV",
                Type = SubdivisionTypes.Province,
                Name = "Davao del Norte",
                LocalName = "Davao del Norte"
            },
            new()
            { 
                Code = "DAS",
                Type = SubdivisionTypes.Province,
                Name = "Davao del Sur",
                LocalName = "Davao del Sur"
            },
            new()
            { 
                Code = "DAO",
                Type = SubdivisionTypes.Province,
                Name = "Davao Oriental",
                LocalName = "Davao Oriental"
            },
            new()
            { 
                Code = "DIN",
                Type = SubdivisionTypes.Province,
                Name = "Dinagat Islands",
                LocalName = "Dinagat Islands"
            },
            new()
            { 
                Code = "EAS",
                Type = SubdivisionTypes.Province,
                Name = "Eastern Samar",
                LocalName = "Eastern Samar"
            },
            new()
            { 
                Code = "GUI",
                Type = SubdivisionTypes.Province,
                Name = "Guimaras",
                LocalName = "Guimaras"
            },
            new()
            { 
                Code = "IFU",
                Type = SubdivisionTypes.Province,
                Name = "Ifugao",
                LocalName = "Ifugao"
            },
            new()
            { 
                Code = "ILN",
                Type = SubdivisionTypes.Province,
                Name = "Ilocos Norte",
                LocalName = "Ilocos Norte"
            },
            new()
            { 
                Code = "ILS",
                Type = SubdivisionTypes.Province,
                Name = "Ilocos Sur",
                LocalName = "Ilocos Sur"
            },
            new()
            { 
                Code = "ILI",
                Type = SubdivisionTypes.Province,
                Name = "Iloilo",
                LocalName = "Iloilo"
            },
            new()
            { 
                Code = "ISA",
                Type = SubdivisionTypes.Province,
                Name = "Isabela",
                LocalName = "Isabela"
            },
            new()
            { 
                Code = "KAL",
                Type = SubdivisionTypes.Province,
                Name = "Kalinga-Apayao",
                LocalName = "Kalinga-Apayao"
            },
            new()
            { 
                Code = "DVO",
                Type = SubdivisionTypes.Province,
                Name = "Kanlurang Dabaw",
                LocalName = "Kanlurang Dabaw"
            },
            new()
            { 
                Code = "NCO",
                Type = SubdivisionTypes.Province,
                Name = "Kotabato",
                LocalName = "Kotabato"
            },
            new()
            { 
                Code = "LUN",
                Type = SubdivisionTypes.Province,
                Name = "La Union",
                LocalName = "La Union"
            },
            new()
            { 
                Code = "LAG",
                Type = SubdivisionTypes.Province,
                Name = "Laguna",
                LocalName = "Laguna"
            },
            new()
            { 
                Code = "LAN",
                Type = SubdivisionTypes.Province,
                Name = "Lanao del Norte",
                LocalName = "Lanao del Norte"
            },
            new()
            { 
                Code = "LAS",
                Type = SubdivisionTypes.Province,
                Name = "Lanao del Sur",
                LocalName = "Lanao del Sur"
            },
            new()
            { 
                Code = "LEY",
                Type = SubdivisionTypes.Province,
                Name = "Leyte",
                LocalName = "Leyte"
            },
            new()
            { 
                Code = "MAG",
                Type = SubdivisionTypes.Province,
                Name = "Maguindanao",
                LocalName = "Maguindanao"
            },
            new()
            { 
                Code = "MAD",
                Type = SubdivisionTypes.Province,
                Name = "Marinduque",
                LocalName = "Marinduque"
            },
            new()
            { 
                Code = "MAS",
                Type = SubdivisionTypes.Province,
                Name = "Masbate",
                LocalName = "Masbate"
            },
            new()
            { 
                Code = "MDC",
                Type = SubdivisionTypes.Province,
                Name = "Mindoro Occidental",
                LocalName = "Mindoro Occidental"
            },
            new()
            { 
                Code = "MDR",
                Type = SubdivisionTypes.Province,
                Name = "Mindoro Oriental",
                LocalName = "Mindoro Oriental"
            },
            new()
            { 
                Code = "MSC",
                Type = SubdivisionTypes.Province,
                Name = "Misamis Occidental",
                LocalName = "Misamis Occidental"
            },
            new()
            { 
                Code = "MSR",
                Type = SubdivisionTypes.Province,
                Name = "Misamis Oriental",
                LocalName = "Misamis Oriental"
            },
            new()
            { 
                Code = "MOU",
                Type = SubdivisionTypes.Province,
                Name = "Mountain Province",
                LocalName = "Mountain Province"
            },
            new()
            { 
                Code = "0",
                Type = SubdivisionTypes.Region,
                Name = "National Capital Région",
                LocalName = "National Capital Région"
            },
            new()
            { 
                Code = "NEC",
                Type = SubdivisionTypes.Province,
                Name = "Negros occidental",
                LocalName = "Negros occidental"
            },
            new()
            { 
                Code = "NER",
                Type = SubdivisionTypes.Province,
                Name = "Negros oriental",
                LocalName = "Negros oriental"
            },
            new()
            { 
                Code = "NSA",
                Type = SubdivisionTypes.Province,
                Name = "Northern Samar",
                LocalName = "Northern Samar"
            },
            new()
            { 
                Code = "NUE",
                Type = SubdivisionTypes.Province,
                Name = "Nueva Ecija",
                LocalName = "Nueva Ecija"
            },
            new()
            { 
                Code = "NUV",
                Type = SubdivisionTypes.Province,
                Name = "Nueva Vizcaya",
                LocalName = "Nueva Vizcaya"
            },
            new()
            { 
                Code = "PLW",
                Type = SubdivisionTypes.Province,
                Name = "Palawan",
                LocalName = "Palawan"
            },
            new()
            { 
                Code = "PAM",
                Type = SubdivisionTypes.Province,
                Name = "Pampanga",
                LocalName = "Pampanga"
            },
            new()
            { 
                Code = "PAN",
                Type = SubdivisionTypes.Province,
                Name = "Pangasinan",
                LocalName = "Pangasinan"
            },
            new()
            { 
                Code = "QUE",
                Type = SubdivisionTypes.Province,
                Name = "Quezon",
                LocalName = "Quezon"
            },
            new()
            { 
                Code = "QUI",
                Type = SubdivisionTypes.Province,
                Name = "Quirino",
                LocalName = "Quirino"
            },
            new()
            { 
                Code = "RIZ",
                Type = SubdivisionTypes.Province,
                Name = "Rizal",
                LocalName = "Rizal"
            },
            new()
            { 
                Code = "ROM",
                Type = SubdivisionTypes.Province,
                Name = "Romblon",
                LocalName = "Romblon"
            },
            new()
            { 
                Code = "SAR",
                Type = SubdivisionTypes.Province,
                Name = "Sarangani",
                LocalName = "Sarangani"
            },
            new()
            { 
                Code = "SIG",
                Type = SubdivisionTypes.Province,
                Name = "Siquijor",
                LocalName = "Siquijor"
            },
            new()
            { 
                Code = "SOR",
                Type = SubdivisionTypes.Province,
                Name = "Sorsogon",
                LocalName = "Sorsogon"
            },
            new()
            { 
                Code = "SCO",
                Type = SubdivisionTypes.Province,
                Name = "South Cotabato",
                LocalName = "South Cotabato"
            },
            new()
            { 
                Code = "SLE",
                Type = SubdivisionTypes.Province,
                Name = "Southern Leyte",
                LocalName = "Southern Leyte"
            },
            new()
            { 
                Code = "SUK",
                Type = SubdivisionTypes.Province,
                Name = "Sultan Kudarat",
                LocalName = "Sultan Kudarat"
            },
            new()
            { 
                Code = "SLU",
                Type = SubdivisionTypes.Province,
                Name = "Sulu",
                LocalName = "Sulu"
            },
            new()
            { 
                Code = "SUN",
                Type = SubdivisionTypes.Province,
                Name = "Surigao del Norte",
                LocalName = "Surigao del Norte"
            },
            new()
            { 
                Code = "SUR",
                Type = SubdivisionTypes.Province,
                Name = "Surigao del Sur",
                LocalName = "Surigao del Sur"
            },
            new()
            { 
                Code = "TAR",
                Type = SubdivisionTypes.Province,
                Name = "Tarlac",
                LocalName = "Tarlac"
            },
            new()
            { 
                Code = "TAW",
                Type = SubdivisionTypes.Province,
                Name = "Tawi-Tawi",
                LocalName = "Tawi-Tawi"
            },
            new()
            { 
                Code = "WSA",
                Type = SubdivisionTypes.Province,
                Name = "Western Samar",
                LocalName = "Western Samar"
            },
            new()
            { 
                Code = "ZMB",
                Type = SubdivisionTypes.Province,
                Name = "Zambales",
                LocalName = "Zambales"
            },
            new()
            { 
                Code = "ZAN",
                Type = SubdivisionTypes.Province,
                Name = "Zamboanga del Norte",
                LocalName = "Zamboanga del Norte"
            },
            new()
            { 
                Code = "ZAS",
                Type = SubdivisionTypes.Province,
                Name = "Zamboanga del Sur",
                LocalName = "Zamboanga del Sur"
            },
            new()
            { 
                Code = "ZSI",
                Type = SubdivisionTypes.Province,
                Name = "Zamboanga Sibuguey",
                LocalName = "Zamboanga Sibuguey"
            }

        ]);
    }
}
