using AngryMonkey.Cloud.Geography;
namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    private static void FillInSubdivisionsRU()
    {
        AddSubdivisions("RU", new List<Subdivision>()
        {
            new()
            { 
                Code = "AD",
                Type = "Republic",
                Name = "Adygeya",
                LocalName = "Adygeya"
            },
            new()
            { 
                Code = "AL",
                Type = "Republic",
                Name = "Altay",
                LocalName = "Altay"
            },
            new()
            { 
                Code = "ALT",
                Type = "Territory",
                Name = "Altayskiy kray",
                LocalName = "Altayskiy kray"
            },
            new()
            { 
                Code = "AMU",
                Type = "Region",
                Name = "Amurskaya oblast'",
                LocalName = "Amurskaya oblast'"
            },
            new()
            { 
                Code = "ARK",
                Type = "Region",
                Name = "Arkhangel'skaya oblast",
                LocalName = "Arkhangel'skaya oblast"
            },
            new()
            { 
                Code = "AST",
                Type = "Region",
                Name = "Astrakhanskaya oblast'",
                LocalName = "Astrakhanskaya oblast'"
            },
            new()
            { 
                Code = "BA",
                Type = "Republic",
                Name = "Bashkortostan",
                LocalName = "Bashkortostan"
            },
            new()
            { 
                Code = "BEL",
                Type = "Region",
                Name = "Belgorodskaya oblast'",
                LocalName = "Belgorodskaya oblast'"
            },
            new()
            { 
                Code = "BRY",
                Type = "Region",
                Name = "Bryanskaya oblast'",
                LocalName = "Bryanskaya oblast'"
            },
            new()
            { 
                Code = "BU",
                Type = "Republic",
                Name = "Buryatiya",
                LocalName = "Buryatiya"
            },
            new()
            { 
                Code = "CE",
                Type = "Republic",
                Name = "Chechenskaya Respublika",
                LocalName = "Chechenskaya Respublika"
            },
            new()
            { 
                Code = "CHE",
                Type = "Region",
                Name = "Chelyabinskaya oblast'",
                LocalName = "Chelyabinskaya oblast'"
            },
            new()
            { 
                Code = "CHU",
                Type = "District",
                Name = "Chukotskiy avtonomnyy okrug",
                LocalName = "Chukotskiy avtonomnyy okrug"
            },
            new()
            { 
                Code = "CU",
                Type = "Republic",
                Name = "Chuvashskaya Respublika",
                LocalName = "Chuvashskaya Respublika"
            },
            new()
            { 
                Code = "DA",
                Type = "Republic",
                Name = "Dagestan",
                LocalName = "Dagestan"
            },
            new()
            { 
                Code = "IN",
                Type = "Republic",
                Name = "Ingushskaya Respublika",
                LocalName = "Ingushskaya Respublika"
            },
            new()
            { 
                Code = "IRK",
                Type = "Region",
                Name = "Irkutskaya oblast'",
                LocalName = "Irkutskaya oblast'"
            },
            new()
            { 
                Code = "IVA",
                Type = "Region",
                Name = "Ivanovskaya oblast'",
                LocalName = "Ivanovskaya oblast'"
            },
            new()
            { 
                Code = "KB",
                Type = "Republic",
                Name = "Kabardino-Balkarskaya Respublika",
                LocalName = "Kabardino-Balkarskaya Respublika"
            },
            new()
            { 
                Code = "KGD",
                Type = "Region",
                Name = "Kaliningradskaya oblast",
                LocalName = "Kaliningradskaya oblast"
            },
            new()
            { 
                Code = "KL",
                Type = "Republic",
                Name = "Kalmykiya",
                LocalName = "Kalmykiya"
            },
            new()
            { 
                Code = "KLU",
                Type = "Region",
                Name = "Kaluzhskaya oblast'",
                LocalName = "Kaluzhskaya oblast'"
            },
            new()
            { 
                Code = "KAM",
                Type = "Region",
                Name = "Kamchatskaya oblast'",
                LocalName = "Kamchatskaya oblast'"
            },
            new()
            { 
                Code = "KC",
                Type = "Republic",
                Name = "Karachayevo-Cherkesskaya Respublika",
                LocalName = "Karachayevo-Cherkesskaya Respublika"
            },
            new()
            { 
                Code = "KR",
                Type = "Republic",
                Name = "Kareliya",
                LocalName = "Kareliya"
            },
            new()
            { 
                Code = "KEM",
                Type = "Region",
                Name = "Kemerovskaya oblast'",
                LocalName = "Kemerovskaya oblast'"
            },
            new()
            { 
                Code = "KHA",
                Type = "Territory",
                Name = "Khabarovskiy kray",
                LocalName = "Khabarovskiy kray"
            },
            new()
            { 
                Code = "KK",
                Type = "Republic",
                Name = "Khakasiya",
                LocalName = "Khakasiya"
            },
            new()
            { 
                Code = "KHM",
                Type = "District",
                Name = "Khanty-Mansiyskiy avtonomnyy okrug",
                LocalName = "Khanty-Mansiyskiy avtonomnyy okrug"
            },
            new()
            { 
                Code = "KIR",
                Type = "Region",
                Name = "Kirovskaya oblast'",
                LocalName = "Kirovskaya oblast'"
            },
            new()
            { 
                Code = "KO",
                Type = "Republic",
                Name = "Komi",
                LocalName = "Komi"
            },
            new()
            { 
                Code = "KOS",
                Type = "Region",
                Name = "Kostromskaya oblast'",
                LocalName = "Kostromskaya oblast'"
            },
            new()
            { 
                Code = "KDA",
                Type = "Territory",
                Name = "Krasnodarskiy kray",
                LocalName = "Krasnodarskiy kray"
            },
            new()
            { 
                Code = "KYA",
                Type = "Territory",
                Name = "Krasnoyarskiy kray",
                LocalName = "Krasnoyarskiy kray"
            },
            new()
            { 
                Code = "KGN",
                Type = "Region",
                Name = "Kurganskaya oblast'",
                LocalName = "Kurganskaya oblast'"
            },
            new()
            { 
                Code = "KRS",
                Type = "Region",
                Name = "Kurskaya oblast'",
                LocalName = "Kurskaya oblast'"
            },
            new()
            { 
                Code = "LEN",
                Type = "Region",
                Name = "Leningradskaya oblast'",
                LocalName = "Leningradskaya oblast'"
            },
            new()
            { 
                Code = "LIP",
                Type = "Region",
                Name = "Lipetskaya oblast'",
                LocalName = "Lipetskaya oblast'"
            },
            new()
            { 
                Code = "MAG",
                Type = "Region",
                Name = "Magadanskaya oblast'",
                LocalName = "Magadanskaya oblast'"
            },
            new()
            { 
                Code = "ME",
                Type = "Republic",
                Name = "Mariy El",
                LocalName = "Mariy El"
            },
            new()
            { 
                Code = "MO",
                Type = "Republic",
                Name = "Mordoviya",
                LocalName = "Mordoviya"
            },
            new()
            { 
                Code = "MOS",
                Type = "Region",
                Name = "Moskovskaya oblast'",
                LocalName = "Moskovskaya oblast'"
            },
            new()
            { 
                Code = "MUR",
                Type = "Region",
                Name = "Murmanskaya oblast'",
                LocalName = "Murmanskaya oblast'"
            },
            new()
            { 
                Code = "NEN",
                Type = "District",
                Name = "Nenetskiy avtonomnyy okrug",
                LocalName = "Nenetskiy avtonomnyy okrug"
            },
            new()
            { 
                Code = "NIZ",
                Type = "Region",
                Name = "Nizhegorodskaya oblast'",
                LocalName = "Nizhegorodskaya oblast'"
            },
            new()
            { 
                Code = "NGR",
                Type = "Region",
                Name = "Novgorodskaya oblast'",
                LocalName = "Novgorodskaya oblast'"
            },
            new()
            { 
                Code = "NVS",
                Type = "Region",
                Name = "Novosibirskaya oblast'",
                LocalName = "Novosibirskaya oblast'"
            },
            new()
            { 
                Code = "OMS",
                Type = "Region",
                Name = "Omskaya oblast'",
                LocalName = "Omskaya oblast'"
            },
            new()
            { 
                Code = "ORE",
                Type = "Region",
                Name = "Orenburgskaya oblast'",
                LocalName = "Orenburgskaya oblast'"
            },
            new()
            { 
                Code = "ORL",
                Type = "Region",
                Name = "Orlovskaya oblast'",
                LocalName = "Orlovskaya oblast'"
            },
            new()
            { 
                Code = "PNZ",
                Type = "Region",
                Name = "Penzenskaya oblast'",
                LocalName = "Penzenskaya oblast'"
            },
            new()
            { 
                Code = "PER",
                Type = "Territory",
                Name = "Perm",
                LocalName = "Perm"
            },
            new()
            { 
                Code = "PRI",
                Type = "Territory",
                Name = "Primorskiy kray",
                LocalName = "Primorskiy kray"
            },
            new()
            { 
                Code = "PSK",
                Type = "Region",
                Name = "Pskovskaya oblast'",
                LocalName = "Pskovskaya oblast'"
            },
            new()
            { 
                Code = "ROS",
                Type = "Region",
                Name = "Rostovskaya oblast'",
                LocalName = "Rostovskaya oblast'"
            },
            new()
            { 
                Code = "RYA",
                Type = "Region",
                Name = "Ryazanskaya oblast'",
                LocalName = "Ryazanskaya oblast'"
            },
            new()
            { 
                Code = "SA",
                Type = "Republic",
                Name = "Sakha",
                LocalName = "Sakha"
            },
            new()
            { 
                Code = "SAK",
                Type = "Region",
                Name = "Sakhalinskaya oblast'",
                LocalName = "Sakhalinskaya oblast'"
            },
            new()
            { 
                Code = "SAM",
                Type = "Region",
                Name = "Samarskaya oblast'",
                LocalName = "Samarskaya oblast'"
            },
            new()
            { 
                Code = "SAR",
                Type = "Region",
                Name = "Saratovskaya oblast'",
                LocalName = "Saratovskaya oblast'"
            },
            new()
            { 
                Code = "SE",
                Type = "Republic",
                Name = "Severnaya Osetiya",
                LocalName = "Severnaya Osetiya"
            },
            new()
            { 
                Code = "SMO",
                Type = "Region",
                Name = "Smolenskaya oblast'",
                LocalName = "Smolenskaya oblast'"
            },
            new()
            { 
                Code = "STA",
                Type = "Territory",
                Name = "Stavropol'skiy kray",
                LocalName = "Stavropol'skiy kray"
            },
            new()
            { 
                Code = "SVE",
                Type = "Region",
                Name = "Sverdlovskaya oblast'",
                LocalName = "Sverdlovskaya oblast'"
            },
            new()
            { 
                Code = "TAM",
                Type = "Region",
                Name = "Tambovskaya oblast'",
                LocalName = "Tambovskaya oblast'"
            },
            new()
            { 
                Code = "TA",
                Type = "Republic",
                Name = "Tatarstan",
                LocalName = "Tatarstan"
            },
            new()
            { 
                Code = "TOM",
                Type = "Region",
                Name = "Tomskaya oblast'",
                LocalName = "Tomskaya oblast'"
            },
            new()
            { 
                Code = "TUL",
                Type = "Region",
                Name = "Tul'skaya oblast'",
                LocalName = "Tul'skaya oblast'"
            },
            new()
            { 
                Code = "TVE",
                Type = "Region",
                Name = "Tverskaya oblast'",
                LocalName = "Tverskaya oblast'"
            },
            new()
            { 
                Code = "TYU",
                Type = "Region",
                Name = "Tyumenskaya oblast'",
                LocalName = "Tyumenskaya oblast'"
            },
            new()
            { 
                Code = "TY",
                Type = "Republic",
                Name = "Tyva",
                LocalName = "Tyva"
            },
            new()
            { 
                Code = "UD",
                Type = "Republic",
                Name = "Udmurtskaya Respublika",
                LocalName = "Udmurtskaya Respublika"
            },
            new()
            { 
                Code = "ULY",
                Type = "Region",
                Name = "Ul'yanovskaya oblast'",
                LocalName = "Ul'yanovskaya oblast'"
            },
            new()
            { 
                Code = "VLA",
                Type = "Region",
                Name = "Vladimirskaya oblast'",
                LocalName = "Vladimirskaya oblast'"
            },
            new()
            { 
                Code = "VGG",
                Type = "Region",
                Name = "Volgogradskaya oblast'",
                LocalName = "Volgogradskaya oblast'"
            },
            new()
            { 
                Code = "VLG",
                Type = "Region",
                Name = "Vologodskaya oblast'",
                LocalName = "Vologodskaya oblast'"
            },
            new()
            { 
                Code = "VOR",
                Type = "Region",
                Name = "Voronezhskaya oblast'",
                LocalName = "Voronezhskaya oblast'"
            },
            new()
            { 
                Code = "YAN",
                Type = "District",
                Name = "Yamalo-Nenetskiy avtonomnyy okrug",
                LocalName = "Yamalo-Nenetskiy avtonomnyy okrug"
            },
            new()
            { 
                Code = "YAR",
                Type = "Region",
                Name = "Yaroslavskaya oblast'",
                LocalName = "Yaroslavskaya oblast'"
            },
            new()
            { 
                Code = "YEV",
                Type = "Region",
                Name = "Yevreyskaya avtonomnaya oblast'",
                LocalName = "Yevreyskaya avtonomnaya oblast'"
            },
            new()
            { 
                Code = "ZAB",
                Type = "Territory",
                Name = "Zabaykal'skiy kray",
                LocalName = "Zabaykal'skiy kray"
            }

        });
    }
}
