using AngryMonkey.Cloud.Geography;
namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    private static void FillInSubdivisionsRU()
    {
        AddSubdivisions("RU",
        [
            new()
            { 
                Code = "AD",
                Type = SubdivisionTypes.Republic,
                Name = "Adygeya",
                LocalName = "Adygeya"
            },
            new()
            { 
                Code = "AL",
                Type = SubdivisionTypes.Republic,
                Name = "Altay",
                LocalName = "Altay"
            },
            new()
            { 
                Code = "ALT",
                Type = SubdivisionTypes.Territory,
                Name = "Altayskiy kray",
                LocalName = "Altayskiy kray"
            },
            new()
            { 
                Code = "AMU",
                Type = SubdivisionTypes.Region,
                Name = "Amurskaya oblast'",
                LocalName = "Amurskaya oblast'"
            },
            new()
            { 
                Code = "ARK",
                Type = SubdivisionTypes.Region,
                Name = "Arkhangel'skaya oblast",
                LocalName = "Arkhangel'skaya oblast"
            },
            new()
            { 
                Code = "AST",
                Type = SubdivisionTypes.Region,
                Name = "Astrakhanskaya oblast'",
                LocalName = "Astrakhanskaya oblast'"
            },
            new()
            { 
                Code = "BA",
                Type = SubdivisionTypes.Republic,
                Name = "Bashkortostan",
                LocalName = "Bashkortostan"
            },
            new()
            { 
                Code = "BEL",
                Type = SubdivisionTypes.Region,
                Name = "Belgorodskaya oblast'",
                LocalName = "Belgorodskaya oblast'"
            },
            new()
            { 
                Code = "BRY",
                Type = SubdivisionTypes.Region,
                Name = "Bryanskaya oblast'",
                LocalName = "Bryanskaya oblast'"
            },
            new()
            { 
                Code = "BU",
                Type = SubdivisionTypes.Republic,
                Name = "Buryatiya",
                LocalName = "Buryatiya"
            },
            new()
            { 
                Code = "CE",
                Type = SubdivisionTypes.Republic,
                Name = "Chechenskaya Respublika",
                LocalName = "Chechenskaya Respublika"
            },
            new()
            { 
                Code = "CHE",
                Type = SubdivisionTypes.Region,
                Name = "Chelyabinskaya oblast'",
                LocalName = "Chelyabinskaya oblast'"
            },
            new()
            { 
                Code = "CHU",
                Type = SubdivisionTypes.District,
                Name = "Chukotskiy avtonomnyy okrug",
                LocalName = "Chukotskiy avtonomnyy okrug"
            },
            new()
            { 
                Code = "CU",
                Type = SubdivisionTypes.Republic,
                Name = "Chuvashskaya Respublika",
                LocalName = "Chuvashskaya Respublika"
            },
            new()
            { 
                Code = "DA",
                Type = SubdivisionTypes.Republic,
                Name = "Dagestan",
                LocalName = "Dagestan"
            },
            new()
            { 
                Code = "IN",
                Type = SubdivisionTypes.Republic,
                Name = "Ingushskaya Respublika",
                LocalName = "Ingushskaya Respublika"
            },
            new()
            { 
                Code = "IRK",
                Type = SubdivisionTypes.Region,
                Name = "Irkutskaya oblast'",
                LocalName = "Irkutskaya oblast'"
            },
            new()
            { 
                Code = "IVA",
                Type = SubdivisionTypes.Region,
                Name = "Ivanovskaya oblast'",
                LocalName = "Ivanovskaya oblast'"
            },
            new()
            { 
                Code = "KB",
                Type = SubdivisionTypes.Republic,
                Name = "Kabardino-Balkarskaya Respublika",
                LocalName = "Kabardino-Balkarskaya Respublika"
            },
            new()
            { 
                Code = "KGD",
                Type = SubdivisionTypes.Region,
                Name = "Kaliningradskaya oblast",
                LocalName = "Kaliningradskaya oblast"
            },
            new()
            { 
                Code = "KL",
                Type = SubdivisionTypes.Republic,
                Name = "Kalmykiya",
                LocalName = "Kalmykiya"
            },
            new()
            { 
                Code = "KLU",
                Type = SubdivisionTypes.Region,
                Name = "Kaluzhskaya oblast'",
                LocalName = "Kaluzhskaya oblast'"
            },
            new()
            { 
                Code = "KAM",
                Type = SubdivisionTypes.Region,
                Name = "Kamchatskaya oblast'",
                LocalName = "Kamchatskaya oblast'"
            },
            new()
            { 
                Code = "KC",
                Type = SubdivisionTypes.Republic,
                Name = "Karachayevo-Cherkesskaya Respublika",
                LocalName = "Karachayevo-Cherkesskaya Respublika"
            },
            new()
            { 
                Code = "KR",
                Type = SubdivisionTypes.Republic,
                Name = "Kareliya",
                LocalName = "Kareliya"
            },
            new()
            { 
                Code = "KEM",
                Type = SubdivisionTypes.Region,
                Name = "Kemerovskaya oblast'",
                LocalName = "Kemerovskaya oblast'"
            },
            new()
            { 
                Code = "KHA",
                Type = SubdivisionTypes.Territory,
                Name = "Khabarovskiy kray",
                LocalName = "Khabarovskiy kray"
            },
            new()
            { 
                Code = "KK",
                Type = SubdivisionTypes.Republic,
                Name = "Khakasiya",
                LocalName = "Khakasiya"
            },
            new()
            { 
                Code = "KHM",
                Type = SubdivisionTypes.District,
                Name = "Khanty-Mansiyskiy avtonomnyy okrug",
                LocalName = "Khanty-Mansiyskiy avtonomnyy okrug"
            },
            new()
            { 
                Code = "KIR",
                Type = SubdivisionTypes.Region,
                Name = "Kirovskaya oblast'",
                LocalName = "Kirovskaya oblast'"
            },
            new()
            { 
                Code = "KO",
                Type = SubdivisionTypes.Republic,
                Name = "Komi",
                LocalName = "Komi"
            },
            new()
            { 
                Code = "KOS",
                Type = SubdivisionTypes.Region,
                Name = "Kostromskaya oblast'",
                LocalName = "Kostromskaya oblast'"
            },
            new()
            { 
                Code = "KDA",
                Type = SubdivisionTypes.Territory,
                Name = "Krasnodarskiy kray",
                LocalName = "Krasnodarskiy kray"
            },
            new()
            { 
                Code = "KYA",
                Type = SubdivisionTypes.Territory,
                Name = "Krasnoyarskiy kray",
                LocalName = "Krasnoyarskiy kray"
            },
            new()
            { 
                Code = "KGN",
                Type = SubdivisionTypes.Region,
                Name = "Kurganskaya oblast'",
                LocalName = "Kurganskaya oblast'"
            },
            new()
            { 
                Code = "KRS",
                Type = SubdivisionTypes.Region,
                Name = "Kurskaya oblast'",
                LocalName = "Kurskaya oblast'"
            },
            new()
            { 
                Code = "LEN",
                Type = SubdivisionTypes.Region,
                Name = "Leningradskaya oblast'",
                LocalName = "Leningradskaya oblast'"
            },
            new()
            { 
                Code = "LIP",
                Type = SubdivisionTypes.Region,
                Name = "Lipetskaya oblast'",
                LocalName = "Lipetskaya oblast'"
            },
            new()
            { 
                Code = "MAG",
                Type = SubdivisionTypes.Region,
                Name = "Magadanskaya oblast'",
                LocalName = "Magadanskaya oblast'"
            },
            new()
            { 
                Code = "ME",
                Type = SubdivisionTypes.Republic,
                Name = "Mariy El",
                LocalName = "Mariy El"
            },
            new()
            { 
                Code = "MO",
                Type = SubdivisionTypes.Republic,
                Name = "Mordoviya",
                LocalName = "Mordoviya"
            },
            new()
            { 
                Code = "MOS",
                Type = SubdivisionTypes.Region,
                Name = "Moskovskaya oblast'",
                LocalName = "Moskovskaya oblast'"
            },
            new()
            { 
                Code = "MUR",
                Type = SubdivisionTypes.Region,
                Name = "Murmanskaya oblast'",
                LocalName = "Murmanskaya oblast'"
            },
            new()
            { 
                Code = "NEN",
                Type = SubdivisionTypes.District,
                Name = "Nenetskiy avtonomnyy okrug",
                LocalName = "Nenetskiy avtonomnyy okrug"
            },
            new()
            { 
                Code = "NIZ",
                Type = SubdivisionTypes.Region,
                Name = "Nizhegorodskaya oblast'",
                LocalName = "Nizhegorodskaya oblast'"
            },
            new()
            { 
                Code = "NGR",
                Type = SubdivisionTypes.Region,
                Name = "Novgorodskaya oblast'",
                LocalName = "Novgorodskaya oblast'"
            },
            new()
            { 
                Code = "NVS",
                Type = SubdivisionTypes.Region,
                Name = "Novosibirskaya oblast'",
                LocalName = "Novosibirskaya oblast'"
            },
            new()
            { 
                Code = "OMS",
                Type = SubdivisionTypes.Region,
                Name = "Omskaya oblast'",
                LocalName = "Omskaya oblast'"
            },
            new()
            { 
                Code = "ORE",
                Type = SubdivisionTypes.Region,
                Name = "Orenburgskaya oblast'",
                LocalName = "Orenburgskaya oblast'"
            },
            new()
            { 
                Code = "ORL",
                Type = SubdivisionTypes.Region,
                Name = "Orlovskaya oblast'",
                LocalName = "Orlovskaya oblast'"
            },
            new()
            { 
                Code = "PNZ",
                Type = SubdivisionTypes.Region,
                Name = "Penzenskaya oblast'",
                LocalName = "Penzenskaya oblast'"
            },
            new()
            { 
                Code = "PER",
                Type = SubdivisionTypes.Territory,
                Name = "Perm",
                LocalName = "Perm"
            },
            new()
            { 
                Code = "PRI",
                Type = SubdivisionTypes.Territory,
                Name = "Primorskiy kray",
                LocalName = "Primorskiy kray"
            },
            new()
            { 
                Code = "PSK",
                Type = SubdivisionTypes.Region,
                Name = "Pskovskaya oblast'",
                LocalName = "Pskovskaya oblast'"
            },
            new()
            { 
                Code = "ROS",
                Type = SubdivisionTypes.Region,
                Name = "Rostovskaya oblast'",
                LocalName = "Rostovskaya oblast'"
            },
            new()
            { 
                Code = "RYA",
                Type = SubdivisionTypes.Region,
                Name = "Ryazanskaya oblast'",
                LocalName = "Ryazanskaya oblast'"
            },
            new()
            { 
                Code = "SA",
                Type = SubdivisionTypes.Republic,
                Name = "Sakha",
                LocalName = "Sakha"
            },
            new()
            { 
                Code = "SAK",
                Type = SubdivisionTypes.Region,
                Name = "Sakhalinskaya oblast'",
                LocalName = "Sakhalinskaya oblast'"
            },
            new()
            { 
                Code = "SAM",
                Type = SubdivisionTypes.Region,
                Name = "Samarskaya oblast'",
                LocalName = "Samarskaya oblast'"
            },
            new()
            { 
                Code = "SAR",
                Type = SubdivisionTypes.Region,
                Name = "Saratovskaya oblast'",
                LocalName = "Saratovskaya oblast'"
            },
            new()
            { 
                Code = "SE",
                Type = SubdivisionTypes.Republic,
                Name = "Severnaya Osetiya",
                LocalName = "Severnaya Osetiya"
            },
            new()
            { 
                Code = "SMO",
                Type = SubdivisionTypes.Region,
                Name = "Smolenskaya oblast'",
                LocalName = "Smolenskaya oblast'"
            },
            new()
            { 
                Code = "STA",
                Type = SubdivisionTypes.Territory,
                Name = "Stavropol'skiy kray",
                LocalName = "Stavropol'skiy kray"
            },
            new()
            { 
                Code = "SVE",
                Type = SubdivisionTypes.Region,
                Name = "Sverdlovskaya oblast'",
                LocalName = "Sverdlovskaya oblast'"
            },
            new()
            { 
                Code = "TAM",
                Type = SubdivisionTypes.Region,
                Name = "Tambovskaya oblast'",
                LocalName = "Tambovskaya oblast'"
            },
            new()
            { 
                Code = "TA",
                Type = SubdivisionTypes.Republic,
                Name = "Tatarstan",
                LocalName = "Tatarstan"
            },
            new()
            { 
                Code = "TOM",
                Type = SubdivisionTypes.Region,
                Name = "Tomskaya oblast'",
                LocalName = "Tomskaya oblast'"
            },
            new()
            { 
                Code = "TUL",
                Type = SubdivisionTypes.Region,
                Name = "Tul'skaya oblast'",
                LocalName = "Tul'skaya oblast'"
            },
            new()
            { 
                Code = "TVE",
                Type = SubdivisionTypes.Region,
                Name = "Tverskaya oblast'",
                LocalName = "Tverskaya oblast'"
            },
            new()
            { 
                Code = "TYU",
                Type = SubdivisionTypes.Region,
                Name = "Tyumenskaya oblast'",
                LocalName = "Tyumenskaya oblast'"
            },
            new()
            { 
                Code = "TY",
                Type = SubdivisionTypes.Republic,
                Name = "Tyva",
                LocalName = "Tyva"
            },
            new()
            { 
                Code = "UD",
                Type = SubdivisionTypes.Republic,
                Name = "Udmurtskaya Respublika",
                LocalName = "Udmurtskaya Respublika"
            },
            new()
            { 
                Code = "ULY",
                Type = SubdivisionTypes.Region,
                Name = "Ul'yanovskaya oblast'",
                LocalName = "Ul'yanovskaya oblast'"
            },
            new()
            { 
                Code = "VLA",
                Type = SubdivisionTypes.Region,
                Name = "Vladimirskaya oblast'",
                LocalName = "Vladimirskaya oblast'"
            },
            new()
            { 
                Code = "VGG",
                Type = SubdivisionTypes.Region,
                Name = "Volgogradskaya oblast'",
                LocalName = "Volgogradskaya oblast'"
            },
            new()
            { 
                Code = "VLG",
                Type = SubdivisionTypes.Region,
                Name = "Vologodskaya oblast'",
                LocalName = "Vologodskaya oblast'"
            },
            new()
            { 
                Code = "VOR",
                Type = SubdivisionTypes.Region,
                Name = "Voronezhskaya oblast'",
                LocalName = "Voronezhskaya oblast'"
            },
            new()
            { 
                Code = "YAN",
                Type = SubdivisionTypes.District,
                Name = "Yamalo-Nenetskiy avtonomnyy okrug",
                LocalName = "Yamalo-Nenetskiy avtonomnyy okrug"
            },
            new()
            { 
                Code = "YAR",
                Type = SubdivisionTypes.Region,
                Name = "Yaroslavskaya oblast'",
                LocalName = "Yaroslavskaya oblast'"
            },
            new()
            { 
                Code = "YEV",
                Type = SubdivisionTypes.Region,
                Name = "Yevreyskaya avtonomnaya oblast'",
                LocalName = "Yevreyskaya avtonomnaya oblast'"
            },
            new()
            { 
                Code = "ZAB",
                Type = SubdivisionTypes.Territory,
                Name = "Zabaykal'skiy kray",
                LocalName = "Zabaykal'skiy kray"
            }

        ]);
    }
}
