using AngryMonkey.Cloud.Geography;
namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    private static void FillInSubdivisionsPH()
    {
        AddSubdivisions("PH", new List<Subdivision>()
        {
            new()
            { 
                Code = "ABR",
                Type = "Province",
                Name = "Abra",
                LocalName = "Abra"
            },
            new()
            { 
                Code = "AGN",
                Type = "Province",
                Name = "Agusan del Norte",
                LocalName = "Agusan del Norte"
            },
            new()
            { 
                Code = "AGS",
                Type = "Province",
                Name = "Agusan del Sur",
                LocalName = "Agusan del Sur"
            },
            new()
            { 
                Code = "AKL",
                Type = "Province",
                Name = "Aklan",
                LocalName = "Aklan"
            },
            new()
            { 
                Code = "ALB",
                Type = "Province",
                Name = "Albay",
                LocalName = "Albay"
            },
            new()
            { 
                Code = "ANT",
                Type = "Province",
                Name = "Antique",
                LocalName = "Antique"
            },
            new()
            { 
                Code = "APA",
                Type = "Province",
                Name = "Apayao",
                LocalName = "Apayao"
            },
            new()
            { 
                Code = "AUR",
                Type = "Province",
                Name = "Aurora",
                LocalName = "Aurora"
            },
            new()
            { 
                Code = "BAS",
                Type = "Province",
                Name = "Basilan",
                LocalName = "Basilan"
            },
            new()
            { 
                Code = "BAN",
                Type = "Province",
                Name = "Bataan",
                LocalName = "Bataan"
            },
            new()
            { 
                Code = "BTN",
                Type = "Province",
                Name = "Batanes",
                LocalName = "Batanes"
            },
            new()
            { 
                Code = "BTG",
                Type = "Province",
                Name = "Batangas",
                LocalName = "Batangas"
            },
            new()
            { 
                Code = "BEN",
                Type = "Province",
                Name = "Benguet",
                LocalName = "Benguet"
            },
            new()
            { 
                Code = "BIL",
                Type = "Province",
                Name = "Biliran",
                LocalName = "Biliran"
            },
            new()
            { 
                Code = "BOH",
                Type = "Province",
                Name = "Bohol",
                LocalName = "Bohol"
            },
            new()
            { 
                Code = "BUK",
                Type = "Province",
                Name = "Bukidnon",
                LocalName = "Bukidnon"
            },
            new()
            { 
                Code = "BUL",
                Type = "Province",
                Name = "Bulacan",
                LocalName = "Bulacan"
            },
            new()
            { 
                Code = "CAG",
                Type = "Province",
                Name = "Cagayan",
                LocalName = "Cagayan"
            },
            new()
            { 
                Code = "CAN",
                Type = "Province",
                Name = "Camarines Norte",
                LocalName = "Camarines Norte"
            },
            new()
            { 
                Code = "CAS",
                Type = "Province",
                Name = "Camarines Sur",
                LocalName = "Camarines Sur"
            },
            new()
            { 
                Code = "CAM",
                Type = "Province",
                Name = "Camiguin",
                LocalName = "Camiguin"
            },
            new()
            { 
                Code = "CAP",
                Type = "Province",
                Name = "Capiz",
                LocalName = "Capiz"
            },
            new()
            { 
                Code = "CAT",
                Type = "Province",
                Name = "Catanduanes",
                LocalName = "Catanduanes"
            },
            new()
            { 
                Code = "CAV",
                Type = "Province",
                Name = "Cavite",
                LocalName = "Cavite"
            },
            new()
            { 
                Code = "CEB",
                Type = "Province",
                Name = "Cebu",
                LocalName = "Cebu"
            },
            new()
            { 
                Code = "COM",
                Type = "Province",
                Name = "Compostela Valley",
                LocalName = "Compostela Valley"
            },
            new()
            { 
                Code = "DAV",
                Type = "Province",
                Name = "Davao del Norte",
                LocalName = "Davao del Norte"
            },
            new()
            { 
                Code = "DAS",
                Type = "Province",
                Name = "Davao del Sur",
                LocalName = "Davao del Sur"
            },
            new()
            { 
                Code = "DAO",
                Type = "Province",
                Name = "Davao Oriental",
                LocalName = "Davao Oriental"
            },
            new()
            { 
                Code = "DIN",
                Type = "Province",
                Name = "Dinagat Islands",
                LocalName = "Dinagat Islands"
            },
            new()
            { 
                Code = "EAS",
                Type = "Province",
                Name = "Eastern Samar",
                LocalName = "Eastern Samar"
            },
            new()
            { 
                Code = "GUI",
                Type = "Province",
                Name = "Guimaras",
                LocalName = "Guimaras"
            },
            new()
            { 
                Code = "IFU",
                Type = "Province",
                Name = "Ifugao",
                LocalName = "Ifugao"
            },
            new()
            { 
                Code = "ILN",
                Type = "Province",
                Name = "Ilocos Norte",
                LocalName = "Ilocos Norte"
            },
            new()
            { 
                Code = "ILS",
                Type = "Province",
                Name = "Ilocos Sur",
                LocalName = "Ilocos Sur"
            },
            new()
            { 
                Code = "ILI",
                Type = "Province",
                Name = "Iloilo",
                LocalName = "Iloilo"
            },
            new()
            { 
                Code = "ISA",
                Type = "Province",
                Name = "Isabela",
                LocalName = "Isabela"
            },
            new()
            { 
                Code = "KAL",
                Type = "Province",
                Name = "Kalinga-Apayao",
                LocalName = "Kalinga-Apayao"
            },
            new()
            { 
                Code = "DVO",
                Type = "Province",
                Name = "Kanlurang Dabaw",
                LocalName = "Kanlurang Dabaw"
            },
            new()
            { 
                Code = "NCO",
                Type = "Province",
                Name = "Kotabato",
                LocalName = "Kotabato"
            },
            new()
            { 
                Code = "LUN",
                Type = "Province",
                Name = "La Union",
                LocalName = "La Union"
            },
            new()
            { 
                Code = "LAG",
                Type = "Province",
                Name = "Laguna",
                LocalName = "Laguna"
            },
            new()
            { 
                Code = "LAN",
                Type = "Province",
                Name = "Lanao del Norte",
                LocalName = "Lanao del Norte"
            },
            new()
            { 
                Code = "LAS",
                Type = "Province",
                Name = "Lanao del Sur",
                LocalName = "Lanao del Sur"
            },
            new()
            { 
                Code = "LEY",
                Type = "Province",
                Name = "Leyte",
                LocalName = "Leyte"
            },
            new()
            { 
                Code = "MAG",
                Type = "Province",
                Name = "Maguindanao",
                LocalName = "Maguindanao"
            },
            new()
            { 
                Code = "MAD",
                Type = "Province",
                Name = "Marinduque",
                LocalName = "Marinduque"
            },
            new()
            { 
                Code = "MAS",
                Type = "Province",
                Name = "Masbate",
                LocalName = "Masbate"
            },
            new()
            { 
                Code = "MDC",
                Type = "Province",
                Name = "Mindoro Occidental",
                LocalName = "Mindoro Occidental"
            },
            new()
            { 
                Code = "MDR",
                Type = "Province",
                Name = "Mindoro Oriental",
                LocalName = "Mindoro Oriental"
            },
            new()
            { 
                Code = "MSC",
                Type = "Province",
                Name = "Misamis Occidental",
                LocalName = "Misamis Occidental"
            },
            new()
            { 
                Code = "MSR",
                Type = "Province",
                Name = "Misamis Oriental",
                LocalName = "Misamis Oriental"
            },
            new()
            { 
                Code = "MOU",
                Type = "Province",
                Name = "Mountain Province",
                LocalName = "Mountain Province"
            },
            new()
            { 
                Code = "0",
                Type = "Region",
                Name = "National Capital Région",
                LocalName = "National Capital Région"
            },
            new()
            { 
                Code = "NEC",
                Type = "Province",
                Name = "Negros occidental",
                LocalName = "Negros occidental"
            },
            new()
            { 
                Code = "NER",
                Type = "Province",
                Name = "Negros oriental",
                LocalName = "Negros oriental"
            },
            new()
            { 
                Code = "NSA",
                Type = "Province",
                Name = "Northern Samar",
                LocalName = "Northern Samar"
            },
            new()
            { 
                Code = "NUE",
                Type = "Province",
                Name = "Nueva Ecija",
                LocalName = "Nueva Ecija"
            },
            new()
            { 
                Code = "NUV",
                Type = "Province",
                Name = "Nueva Vizcaya",
                LocalName = "Nueva Vizcaya"
            },
            new()
            { 
                Code = "PLW",
                Type = "Province",
                Name = "Palawan",
                LocalName = "Palawan"
            },
            new()
            { 
                Code = "PAM",
                Type = "Province",
                Name = "Pampanga",
                LocalName = "Pampanga"
            },
            new()
            { 
                Code = "PAN",
                Type = "Province",
                Name = "Pangasinan",
                LocalName = "Pangasinan"
            },
            new()
            { 
                Code = "QUE",
                Type = "Province",
                Name = "Quezon",
                LocalName = "Quezon"
            },
            new()
            { 
                Code = "QUI",
                Type = "Province",
                Name = "Quirino",
                LocalName = "Quirino"
            },
            new()
            { 
                Code = "RIZ",
                Type = "Province",
                Name = "Rizal",
                LocalName = "Rizal"
            },
            new()
            { 
                Code = "ROM",
                Type = "Province",
                Name = "Romblon",
                LocalName = "Romblon"
            },
            new()
            { 
                Code = "SAR",
                Type = "Province",
                Name = "Sarangani",
                LocalName = "Sarangani"
            },
            new()
            { 
                Code = "SIG",
                Type = "Province",
                Name = "Siquijor",
                LocalName = "Siquijor"
            },
            new()
            { 
                Code = "SOR",
                Type = "Province",
                Name = "Sorsogon",
                LocalName = "Sorsogon"
            },
            new()
            { 
                Code = "SCO",
                Type = "Province",
                Name = "South Cotabato",
                LocalName = "South Cotabato"
            },
            new()
            { 
                Code = "SLE",
                Type = "Province",
                Name = "Southern Leyte",
                LocalName = "Southern Leyte"
            },
            new()
            { 
                Code = "SUK",
                Type = "Province",
                Name = "Sultan Kudarat",
                LocalName = "Sultan Kudarat"
            },
            new()
            { 
                Code = "SLU",
                Type = "Province",
                Name = "Sulu",
                LocalName = "Sulu"
            },
            new()
            { 
                Code = "SUN",
                Type = "Province",
                Name = "Surigao del Norte",
                LocalName = "Surigao del Norte"
            },
            new()
            { 
                Code = "SUR",
                Type = "Province",
                Name = "Surigao del Sur",
                LocalName = "Surigao del Sur"
            },
            new()
            { 
                Code = "TAR",
                Type = "Province",
                Name = "Tarlac",
                LocalName = "Tarlac"
            },
            new()
            { 
                Code = "TAW",
                Type = "Province",
                Name = "Tawi-Tawi",
                LocalName = "Tawi-Tawi"
            },
            new()
            { 
                Code = "WSA",
                Type = "Province",
                Name = "Western Samar",
                LocalName = "Western Samar"
            },
            new()
            { 
                Code = "ZMB",
                Type = "Province",
                Name = "Zambales",
                LocalName = "Zambales"
            },
            new()
            { 
                Code = "ZAN",
                Type = "Province",
                Name = "Zamboanga del Norte",
                LocalName = "Zamboanga del Norte"
            },
            new()
            { 
                Code = "ZAS",
                Type = "Province",
                Name = "Zamboanga del Sur",
                LocalName = "Zamboanga del Sur"
            },
            new()
            { 
                Code = "ZSI",
                Type = "Province",
                Name = "Zamboanga Sibuguey",
                LocalName = "Zamboanga Sibuguey"
            }

        });
    }
}
