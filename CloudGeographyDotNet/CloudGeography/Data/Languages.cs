using AngryMonkey.Cloud.Geography;
namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    public partial class LanguagesMethods
    {
        private static List<Language> LanguagesList = new()
        {
            new()
            {
                Code = "AA",
                Name = "Afar",
                NativeName = "Qafar",
                Direction = "LTR",
                ThreeLettersCode = "AAR",
            },

            new()
            {
                Code = "AF",
                Name = "Afrikaans",
                NativeName = "Afrikaans",
                Direction = "LTR",
                ThreeLettersCode = "AFR",
            },

            new()
            {
                Code = "AGQ",
                Name = "Aghem",
                NativeName = "Aghem",
                Direction = "LTR",
                ThreeLettersCode = "AGQ",
            },

            new()
            {
                Code = "AK",
                Name = "Akan",
                NativeName = "Akan",
                Direction = "LTR",
                ThreeLettersCode = "AKA",
            },

            new()
            {
                Code = "SQ",
                Name = "Albanian",
                NativeName = "shqip",
                Direction = "LTR",
                ThreeLettersCode = "SQI",
            },

            new()
            {
                Code = "AM",
                Name = "Amharic",
                NativeName = "አማርኛ",
                Direction = "LTR",
                ThreeLettersCode = "AMH",
            },

            new()
            {
                Code = "AR",
                Name = "Arabic",
                NativeName = "العربية",
                Direction = "RTL",
                ThreeLettersCode = "ARA",
            },

            new()
            {
                Code = "HY",
                Name = "Armenian",
                NativeName = "Հայերեն",
                Direction = "LTR",
                ThreeLettersCode = "HYE",
            },

            new()
            {
                Code = "AS",
                Name = "Assamese",
                NativeName = "অসমীয়া",
                Direction = "LTR",
                ThreeLettersCode = "ASM",
            },

            new()
            {
                Code = "AST",
                Name = "Asturian",
                NativeName = "asturianu",
                Direction = "LTR",
                ThreeLettersCode = "AST",
            },

            new()
            {
                Code = "ASA",
                Name = "Asu",
                NativeName = "Kipare",
                Direction = "LTR",
                ThreeLettersCode = "ASA",
            },

            new()
            {
                Code = "AZ",
                Name = "Azerbaijani",
                NativeName = "azərbaycan",
                Direction = "LTR",
                ThreeLettersCode = "AZE",
            },

            new()
            {
                Code = "AZ",
                Name = "Azerbaijani (Cyrillic)",
                NativeName = "Азәрбајҹан дили",
                Direction = "LTR",
                ThreeLettersCode = "AZE",
            },

            new()
            {
                Code = "AZ",
                Name = "Azerbaijani (Latin)",
                NativeName = "azərbaycan",
                Direction = "LTR",
                ThreeLettersCode = "AZE",
            },

            new()
            {
                Code = "KSF",
                Name = "Bafia",
                NativeName = "rikpa",
                Direction = "LTR",
                ThreeLettersCode = "KSF",
            },

            new()
            {
                Code = "BM",
                Name = "Bamanankan",
                NativeName = "bamanakan",
                Direction = "LTR",
                ThreeLettersCode = "BAM",
            },

            new()
            {
                Code = "BM",
                Name = "Bamanankan (Latin)",
                NativeName = "bamanakan",
                Direction = "LTR",
                ThreeLettersCode = "BAM",
            },

            new()
            {
                Code = "BN",
                Name = "Bangla",
                NativeName = "বাংলা",
                Direction = "LTR",
                ThreeLettersCode = "BEN",
            },

            new()
            {
                Code = "BAS",
                Name = "Basaa",
                NativeName = "Ɓàsàa",
                Direction = "LTR",
                ThreeLettersCode = "BAS",
            },

            new()
            {
                Code = "BA",
                Name = "Bashkir",
                NativeName = "Башҡорт",
                Direction = "LTR",
                ThreeLettersCode = "BAK",
            },

            new()
            {
                Code = "EU",
                Name = "Basque",
                NativeName = "euskara",
                Direction = "LTR",
                ThreeLettersCode = "EUS",
            },

            new()
            {
                Code = "BE",
                Name = "Belarusian",
                NativeName = "Беларуская",
                Direction = "LTR",
                ThreeLettersCode = "BEL",
            },

            new()
            {
                Code = "BEM",
                Name = "Bemba",
                NativeName = "Ichibemba",
                Direction = "LTR",
                ThreeLettersCode = "BEM",
            },

            new()
            {
                Code = "BEZ",
                Name = "Bena",
                NativeName = "Hibena",
                Direction = "LTR",
                ThreeLettersCode = "BEZ",
            },

            new()
            {
                Code = "BER",
                Name = "Berber",
                NativeName = "Berber",
                Direction = "LTR",
                ThreeLettersCode = "BER",
            },

            new()
            {
                Code = "BYN",
                Name = "Blin",
                NativeName = "ብሊን",
                Direction = "LTR",
                ThreeLettersCode = "BYN",
            },

            new()
            {
                Code = "BRX",
                Name = "Bodo",
                NativeName = "बड़ो",
                Direction = "LTR",
                ThreeLettersCode = "BRX",
            },

            new()
            {
                Code = "BS",
                Name = "Bosnian",
                NativeName = "bosanski",
                Direction = "LTR",
                ThreeLettersCode = "BOS",
            },

            new()
            {
                Code = "BS",
                Name = "Bosnian (Cyrillic)",
                NativeName = "босански",
                Direction = "LTR",
                ThreeLettersCode = "BOS",
            },

            new()
            {
                Code = "BS",
                Name = "Bosnian (Latin)",
                NativeName = "bosanski",
                Direction = "LTR",
                ThreeLettersCode = "BOS",
            },

            new()
            {
                Code = "BR",
                Name = "Breton",
                NativeName = "brezhoneg",
                Direction = "LTR",
                ThreeLettersCode = "BRE",
            },

            new()
            {
                Code = "BG",
                Name = "Bulgarian",
                NativeName = "български",
                Direction = "LTR",
                ThreeLettersCode = "BUL",
            },

            new()
            {
                Code = "MY",
                Name = "Burmese",
                NativeName = "ဗမာ",
                Direction = "LTR",
                ThreeLettersCode = "MYA",
            },

            new()
            {
                Code = "CA",
                Name = "Catalan",
                NativeName = "català",
                Direction = "LTR",
                ThreeLettersCode = "CAT",
            },

            new()
            {
                Code = "TZM",
                Name = "Central Atlas Tamazight",
                NativeName = "Tamaziɣt n laṭlaṣ",
                Direction = "LTR",
                ThreeLettersCode = "TZM",
            },

            new()
            {
                Code = "TZM",
                Name = "Central Atlas Tamazight (Arabic)",
                NativeName = "أطلس المركزية التامازيتية",
                Direction = "RTL",
                ThreeLettersCode = "TZM",
            },

            new()
            {
                Code = "TZM",
                Name = "Central Atlas Tamazight (Latin)",
                NativeName = "Tamaziɣt n laṭlaṣ",
                Direction = "LTR",
                ThreeLettersCode = "TZM",
            },

            new()
            {
                Code = "TZM",
                Name = "Central Atlas Tamazight (Tifinagh)",
                NativeName = "ⵜⴰⵎⴰⵣⵉⵖⵜ",
                Direction = "LTR",
                ThreeLettersCode = "TZM",
            },

            new()
            {
                Code = "KU",
                Name = "Central Kurdish",
                NativeName = "کوردیی ناوەڕاست",
                Direction = "RTL",
                ThreeLettersCode = "KUR",
            },

            new()
            {
                Code = "KU",
                Name = "Central Kurdish",
                NativeName = "کوردیی ناوەڕاست",
                Direction = "RTL",
                ThreeLettersCode = "KUR",
            },

            new()
            {
                Code = "CE",
                Name = "Chechen",
                NativeName = "нохчийн",
                Direction = "LTR",
                ThreeLettersCode = "CHE",
            },

            new()
            {
                Code = "CHR",
                Name = "Cherokee",
                NativeName = "ᏣᎳᎩ",
                Direction = "LTR",
                ThreeLettersCode = "CHR",
            },

            new()
            {
                Code = "CHR",
                Name = "Cherokee",
                NativeName = "ᏣᎳᎩ",
                Direction = "LTR",
                ThreeLettersCode = "CHR",
            },

            new()
            {
                Code = "CGG",
                Name = "Chiga",
                NativeName = "Rukiga",
                Direction = "LTR",
                ThreeLettersCode = "CGG",
            },

            new()
            {
                Code = "ZH",
                Name = "Chinese",
                NativeName = "中文",
                Direction = "LTR",
                ThreeLettersCode = "ZHO",
            },

            new()
            {
                Code = "ZH",
                Name = "Chinese (Simplified)",
                NativeName = "中文(简体)",
                Direction = "LTR",
                ThreeLettersCode = "ZHO",
            },

            new()
            {
                Code = "ZH",
                Name = "Chinese (Simplified) Legacy",
                NativeName = "中文(简体) 旧版",
                Direction = "LTR",
                ThreeLettersCode = "ZHO",
            },

            new()
            {
                Code = "ZH",
                Name = "Chinese (Traditional)",
                NativeName = "中文(繁體)",
                Direction = "LTR",
                ThreeLettersCode = "ZHO",
            },

            new()
            {
                Code = "ZH",
                Name = "Chinese (Traditional) Legacy",
                NativeName = "中文(繁體) 舊版",
                Direction = "LTR",
                ThreeLettersCode = "ZHO",
            },

            new()
            {
                Code = "CU",
                Name = "Church Slavic",
                NativeName = "церковнослове́нскїй",
                Direction = "LTR",
                ThreeLettersCode = "CHU",
            },

            new()
            {
                Code = "KSH",
                Name = "Colognian",
                NativeName = "Kölsch",
                Direction = "LTR",
                ThreeLettersCode = "KSH",
            },

            new()
            {
                Code = "KW",
                Name = "Cornish",
                NativeName = "kernewek",
                Direction = "LTR",
                ThreeLettersCode = "COR",
            },

            new()
            {
                Code = "CO",
                Name = "Corsican",
                NativeName = "Corsu",
                Direction = "LTR",
                ThreeLettersCode = "COS",
            },

            new()
            {
                Code = "HR",
                Name = "Croatian",
                NativeName = "hrvatski",
                Direction = "LTR",
                ThreeLettersCode = "HRV",
            },

            new()
            {
                Code = "CS",
                Name = "Czech",
                NativeName = "čeština",
                Direction = "LTR",
                ThreeLettersCode = "CES",
            },

            new()
            {
                Code = "DA",
                Name = "Danish",
                NativeName = "dansk",
                Direction = "LTR",
                ThreeLettersCode = "DAN",
            },

            new()
            {
                Code = "PRS",
                Name = "Dari",
                NativeName = "درى",
                Direction = "RTL",
                ThreeLettersCode = "PRS",
            },

            new()
            {
                Code = "DV",
                Name = "Divehi",
                NativeName = "ދިވެހިބަސް",
                Direction = "RTL",
                ThreeLettersCode = "DIV",
            },

            new()
            {
                Code = "DUA",
                Name = "Duala",
                NativeName = "duálá",
                Direction = "LTR",
                ThreeLettersCode = "DUA",
            },

            new()
            {
                Code = "NL",
                Name = "Dutch",
                NativeName = "Nederlands",
                Direction = "LTR",
                ThreeLettersCode = "NLD",
            },

            new()
            {
                Code = "DZ",
                Name = "Dzongkha",
                NativeName = "རྫོང་ཁ",
                Direction = "LTR",
                ThreeLettersCode = "DZO",
            },

            new()
            {
                Code = "BIN",
                Name = "Edo",
                NativeName = "Ẹ̀dó",
                Direction = "LTR",
                ThreeLettersCode = "BIN",
            },

            new()
            {
                Code = "EBU",
                Name = "Embu",
                NativeName = "Kĩembu",
                Direction = "LTR",
                ThreeLettersCode = "EBU",
            },

            new()
            {
                Code = "EN",
                Name = "English",
                NativeName = "English",
                Direction = "LTR",
                ThreeLettersCode = "ENG",
            },

            new()
            {
                Code = "EO",
                Name = "Esperanto",
                NativeName = "esperanto",
                Direction = "LTR",
                ThreeLettersCode = "EPO",
            },

            new()
            {
                Code = "ET",
                Name = "Estonian",
                NativeName = "eesti",
                Direction = "LTR",
                ThreeLettersCode = "EST",
            },

            new()
            {
                Code = "EE",
                Name = "Ewe",
                NativeName = "Eʋegbe",
                Direction = "LTR",
                ThreeLettersCode = "EWE",
            },

            new()
            {
                Code = "EWO",
                Name = "Ewondo",
                NativeName = "ewondo",
                Direction = "LTR",
                ThreeLettersCode = "EWO",
            },

            new()
            {
                Code = "FO",
                Name = "Faroese",
                NativeName = "føroyskt",
                Direction = "LTR",
                ThreeLettersCode = "FAO",
            },

            new()
            {
                Code = "FIL",
                Name = "Filipino",
                NativeName = "Filipino",
                Direction = "LTR",
                ThreeLettersCode = "FIL",
            },

            new()
            {
                Code = "FI",
                Name = "Finnish",
                NativeName = "suomi",
                Direction = "LTR",
                ThreeLettersCode = "FIN",
            },

            new()
            {
                Code = "FR",
                Name = "French",
                NativeName = "français",
                Direction = "LTR",
                ThreeLettersCode = "FRA",
            },

            new()
            {
                Code = "FUR",
                Name = "Friulian",
                NativeName = "furlan",
                Direction = "LTR",
                ThreeLettersCode = "FUR",
            },

            new()
            {
                Code = "FF",
                Name = "Fulah",
                NativeName = "Fulah",
                Direction = "LTR",
                ThreeLettersCode = "FUL",
            },

            new()
            {
                Code = "FF",
                Name = "Fulah",
                NativeName = "Fulah",
                Direction = "LTR",
                ThreeLettersCode = "FUL",
            },

            new()
            {
                Code = "GL",
                Name = "Galician",
                NativeName = "galego",
                Direction = "LTR",
                ThreeLettersCode = "GLG",
            },

            new()
            {
                Code = "LG",
                Name = "Ganda",
                NativeName = "Luganda",
                Direction = "LTR",
                ThreeLettersCode = "LUG",
            },

            new()
            {
                Code = "KA",
                Name = "Georgian",
                NativeName = "ქართული",
                Direction = "LTR",
                ThreeLettersCode = "KAT",
            },

            new()
            {
                Code = "DE",
                Name = "German",
                NativeName = "Deutsch",
                Direction = "LTR",
                ThreeLettersCode = "DEU",
            },

            new()
            {
                Code = "EL",
                Name = "Greek",
                NativeName = "Ελληνικά",
                Direction = "LTR",
                ThreeLettersCode = "ELL",
            },

            new()
            {
                Code = "KL",
                Name = "Greenlandic",
                NativeName = "kalaallisut",
                Direction = "LTR",
                ThreeLettersCode = "KAL",
            },

            new()
            {
                Code = "GN",
                Name = "Guarani",
                NativeName = "Avañe’ẽ",
                Direction = "LTR",
                ThreeLettersCode = "GRN",
            },

            new()
            {
                Code = "GU",
                Name = "Gujarati",
                NativeName = "ગુજરાતી",
                Direction = "LTR",
                ThreeLettersCode = "GUJ",
            },

            new()
            {
                Code = "GUZ",
                Name = "Gusii",
                NativeName = "Ekegusii",
                Direction = "LTR",
                ThreeLettersCode = "GUZ",
            },

            new()
            {
                Code = "HA",
                Name = "Hausa",
                NativeName = "Hausa",
                Direction = "LTR",
                ThreeLettersCode = "HAU",
            },

            new()
            {
                Code = "HA",
                Name = "Hausa (Latin)",
                NativeName = "Hausa",
                Direction = "LTR",
                ThreeLettersCode = "HAU",
            },

            new()
            {
                Code = "HAW",
                Name = "Hawaiian",
                NativeName = "ʻŌlelo Hawaiʻi",
                Direction = "LTR",
                ThreeLettersCode = "HAW",
            },

            new()
            {
                Code = "HE",
                Name = "Hebrew",
                NativeName = "עברית",
                Direction = "RTL",
                ThreeLettersCode = "HEB",
            },

            new()
            {
                Code = "HI",
                Name = "Hindi",
                NativeName = "हिंदी",
                Direction = "LTR",
                ThreeLettersCode = "HIN",
            },

            new()
            {
                Code = "HU",
                Name = "Hungarian",
                NativeName = "magyar",
                Direction = "LTR",
                ThreeLettersCode = "HUN",
            },

            new()
            {
                Code = "IBB",
                Name = "Ibibio",
                NativeName = "Ibibio-Efik",
                Direction = "LTR",
                ThreeLettersCode = "IBB",
            },

            new()
            {
                Code = "IS",
                Name = "Icelandic",
                NativeName = "íslenska",
                Direction = "LTR",
                ThreeLettersCode = "ISL",
            },

            new()
            {
                Code = "IG",
                Name = "Igbo",
                NativeName = "Igbo",
                Direction = "LTR",
                ThreeLettersCode = "IBO",
            },

            new()
            {
                Code = "ID",
                Name = "Indonesian",
                NativeName = "Indonesia",
                Direction = "LTR",
                ThreeLettersCode = "IND",
            },

            new()
            {
                Code = "IA",
                Name = "Interlingua",
                NativeName = "interlingua",
                Direction = "LTR",
                ThreeLettersCode = "INA",
            },

            new()
            {
                Code = "IU",
                Name = "Inuktitut",
                NativeName = "Inuktitut",
                Direction = "LTR",
                ThreeLettersCode = "IKU",
            },

            new()
            {
                Code = "IU",
                Name = "Inuktitut (Latin)",
                NativeName = "Inuktitut",
                Direction = "LTR",
                ThreeLettersCode = "IKU",
            },

            new()
            {
                Code = "IU",
                Name = "Inuktitut (Syllabics)",
                NativeName = "ᐃᓄᒃᑎᑐᑦ",
                Direction = "LTR",
                ThreeLettersCode = "IKU",
            },

            new()
            {
                Code = "IV",
                Name = "Invariant Language (Invariant Country)",
                NativeName = "Invariant Language (Invariant Country)",
                Direction = "LTR",
                ThreeLettersCode = "IVL",
            },

            new()
            {
                Code = "GA",
                Name = "Irish",
                NativeName = "Gaeilge",
                Direction = "LTR",
                ThreeLettersCode = "GLE",
            },

            new()
            {
                Code = "XH",
                Name = "isiXhosa",
                NativeName = "isiXhosa",
                Direction = "LTR",
                ThreeLettersCode = "XHO",
            },

            new()
            {
                Code = "ZU",
                Name = "isiZulu",
                NativeName = "isiZulu",
                Direction = "LTR",
                ThreeLettersCode = "ZUL",
            },

            new()
            {
                Code = "IT",
                Name = "Italian",
                NativeName = "italiano",
                Direction = "LTR",
                ThreeLettersCode = "ITA",
            },

            new()
            {
                Code = "JA",
                Name = "Japanese",
                NativeName = "日本語",
                Direction = "LTR",
                ThreeLettersCode = "JPN",
            },

            new()
            {
                Code = "JV",
                Name = "Javanese",
                NativeName = "Basa Jawa",
                Direction = "LTR",
                ThreeLettersCode = "JAV",
            },

            new()
            {
                Code = "JV",
                Name = "Javanese",
                NativeName = "Basa Jawa",
                Direction = "LTR",
                ThreeLettersCode = "JAV",
            },

            new()
            {
                Code = "JV",
                Name = "Javanese (Javanese)",
                NativeName = "ꦧꦱꦗꦮ",
                Direction = "LTR",
                ThreeLettersCode = "JAV",
            },

            new()
            {
                Code = "DYO",
                Name = "Jola-Fonyi",
                NativeName = "joola",
                Direction = "LTR",
                ThreeLettersCode = "DYO",
            },

            new()
            {
                Code = "KEA",
                Name = "Kabuverdianu",
                NativeName = "kabuverdianu",
                Direction = "LTR",
                ThreeLettersCode = "KEA",
            },

            new()
            {
                Code = "KAB",
                Name = "Kabyle",
                NativeName = "Taqbaylit",
                Direction = "LTR",
                ThreeLettersCode = "KAB",
            },

            new()
            {
                Code = "KKJ",
                Name = "Kako",
                NativeName = "kakɔ",
                Direction = "LTR",
                ThreeLettersCode = "KKJ",
            },

            new()
            {
                Code = "KLN",
                Name = "Kalenjin",
                NativeName = "Kalenjin",
                Direction = "LTR",
                ThreeLettersCode = "KLN",
            },

            new()
            {
                Code = "KAM",
                Name = "Kamba",
                NativeName = "Kikamba",
                Direction = "LTR",
                ThreeLettersCode = "KAM",
            },

            new()
            {
                Code = "KN",
                Name = "Kannada",
                NativeName = "ಕನ್ನಡ",
                Direction = "LTR",
                ThreeLettersCode = "KAN",
            },

            new()
            {
                Code = "KR",
                Name = "Kanuri",
                NativeName = "Kanuri",
                Direction = "LTR",
                ThreeLettersCode = "KAU",
            },

            new()
            {
                Code = "KS",
                Name = "Kashmiri",
                NativeName = "کٲشُر",
                Direction = "LTR",
                ThreeLettersCode = "KAS",
            },

            new()
            {
                Code = "KS",
                Name = "Kashmiri (Devanagari)",
                NativeName = "कॉशुर",
                Direction = "LTR",
                ThreeLettersCode = "KAS",
            },

            new()
            {
                Code = "KS",
                Name = "Kashmiri (Perso-Arabic)",
                NativeName = "کٲشُر",
                Direction = "LTR",
                ThreeLettersCode = "KAS",
            },

            new()
            {
                Code = "KK",
                Name = "Kazakh",
                NativeName = "қазақ тілі",
                Direction = "LTR",
                ThreeLettersCode = "KAZ",
            },

            new()
            {
                Code = "KM",
                Name = "Khmer",
                NativeName = "ភាសាខ្មែរ",
                Direction = "LTR",
                ThreeLettersCode = "KHM",
            },

            new()
            {
                Code = "QUC",
                Name = "K'iche'",
                NativeName = "K'iche'",
                Direction = "LTR",
                ThreeLettersCode = "QUC",
            },

            new()
            {
                Code = "QUC",
                Name = "K'iche'",
                NativeName = "K'iche'",
                Direction = "LTR",
                ThreeLettersCode = "QUC",
            },

            new()
            {
                Code = "KI",
                Name = "Kikuyu",
                NativeName = "Gikuyu",
                Direction = "LTR",
                ThreeLettersCode = "KIK",
            },

            new()
            {
                Code = "RW",
                Name = "Kinyarwanda",
                NativeName = "Kinyarwanda",
                Direction = "LTR",
                ThreeLettersCode = "KIN",
            },

            new()
            {
                Code = "SW",
                Name = "Kiswahili",
                NativeName = "Kiswahili",
                Direction = "LTR",
                ThreeLettersCode = "SWA",
            },

            new()
            {
                Code = "KOK",
                Name = "Konkani",
                NativeName = "कोंकणी",
                Direction = "LTR",
                ThreeLettersCode = "KOK",
            },

            new()
            {
                Code = "KO",
                Name = "Korean",
                NativeName = "한국어",
                Direction = "LTR",
                ThreeLettersCode = "KOR",
            },

            new()
            {
                Code = "KHQ",
                Name = "Koyra Chiini",
                NativeName = "Koyra ciini",
                Direction = "LTR",
                ThreeLettersCode = "KHQ",
            },

            new()
            {
                Code = "SES",
                Name = "Koyraboro Senni",
                NativeName = "Koyraboro senni",
                Direction = "LTR",
                ThreeLettersCode = "SES",
            },

            new()
            {
                Code = "NMG",
                Name = "Kwasio",
                NativeName = "Kwasio",
                Direction = "LTR",
                ThreeLettersCode = "NMG",
            },

            new()
            {
                Code = "KY",
                Name = "Kyrgyz",
                NativeName = "Кыргыз",
                Direction = "LTR",
                ThreeLettersCode = "KIR",
            },

            new()
            {
                Code = "LKT",
                Name = "Lakota",
                NativeName = "Lakȟólʼiyapi",
                Direction = "LTR",
                ThreeLettersCode = "LKT",
            },

            new()
            {
                Code = "LAG",
                Name = "Langi",
                NativeName = "Kɨlaangi",
                Direction = "LTR",
                ThreeLettersCode = "LAG",
            },

            new()
            {
                Code = "LO",
                Name = "Lao",
                NativeName = "ລາວ",
                Direction = "LTR",
                ThreeLettersCode = "LAO",
            },

            new()
            {
                Code = "LA",
                Name = "Latin",
                NativeName = "lingua latīna",
                Direction = "LTR",
                ThreeLettersCode = "LAT",
            },

            new()
            {
                Code = "LV",
                Name = "Latvian",
                NativeName = "latviešu",
                Direction = "LTR",
                ThreeLettersCode = "LAV",
            },

            new()
            {
                Code = "LN",
                Name = "Lingala",
                NativeName = "lingála",
                Direction = "LTR",
                ThreeLettersCode = "LIN",
            },

            new()
            {
                Code = "LT",
                Name = "Lithuanian",
                NativeName = "lietuvių",
                Direction = "LTR",
                ThreeLettersCode = "LIT",
            },

            new()
            {
                Code = "NDS",
                Name = "Low German",
                NativeName = "Neddersass’sch",
                Direction = "LTR",
                ThreeLettersCode = "NDS",
            },

            new()
            {
                Code = "DSB",
                Name = "Lower Sorbian",
                NativeName = "dolnoserbšćina",
                Direction = "LTR",
                ThreeLettersCode = "DSB",
            },

            new()
            {
                Code = "LU",
                Name = "Luba-Katanga",
                NativeName = "Tshiluba",
                Direction = "LTR",
                ThreeLettersCode = "LUB",
            },

            new()
            {
                Code = "LUO",
                Name = "Luo",
                NativeName = "Dholuo",
                Direction = "LTR",
                ThreeLettersCode = "LUO",
            },

            new()
            {
                Code = "LB",
                Name = "Luxembourgish",
                NativeName = "Lëtzebuergesch",
                Direction = "LTR",
                ThreeLettersCode = "LTZ",
            },

            new()
            {
                Code = "LUY",
                Name = "Luyia",
                NativeName = "Luluhia",
                Direction = "LTR",
                ThreeLettersCode = "LUY",
            },

            new()
            {
                Code = "MK",
                Name = "Macedonian",
                NativeName = "македонски",
                Direction = "LTR",
                ThreeLettersCode = "MKD",
            },

            new()
            {
                Code = "JMC",
                Name = "Machame",
                NativeName = "Kimachame",
                Direction = "LTR",
                ThreeLettersCode = "JMC",
            },

            new()
            {
                Code = "MGH",
                Name = "Makhuwa-Meetto",
                NativeName = "Makua",
                Direction = "LTR",
                ThreeLettersCode = "MGH",
            },

            new()
            {
                Code = "KDE",
                Name = "Makonde",
                NativeName = "Chimakonde",
                Direction = "LTR",
                ThreeLettersCode = "KDE",
            },

            new()
            {
                Code = "MG",
                Name = "Malagasy",
                NativeName = "Malagasy",
                Direction = "LTR",
                ThreeLettersCode = "MLG",
            },

            new()
            {
                Code = "MS",
                Name = "Malay",
                NativeName = "Bahasa Melayu",
                Direction = "LTR",
                ThreeLettersCode = "MSA",
            },

            new()
            {
                Code = "ML",
                Name = "Malayalam",
                NativeName = "മലയാളം",
                Direction = "LTR",
                ThreeLettersCode = "MAL",
            },

            new()
            {
                Code = "MT",
                Name = "Maltese",
                NativeName = "Malti",
                Direction = "LTR",
                ThreeLettersCode = "MLT",
            },

            new()
            {
                Code = "MNI",
                Name = "Manipuri",
                NativeName = "মৈতৈলোন্",
                Direction = "LTR",
                ThreeLettersCode = "MNI",
            },

            new()
            {
                Code = "GV",
                Name = "Manx",
                NativeName = "Gaelg",
                Direction = "LTR",
                ThreeLettersCode = "GLV",
            },

            new()
            {
                Code = "MI",
                Name = "Maori",
                NativeName = "Reo Māori",
                Direction = "LTR",
                ThreeLettersCode = "MRI",
            },

            new()
            {
                Code = "ARN",
                Name = "Mapudungun",
                NativeName = "Mapudungun",
                Direction = "LTR",
                ThreeLettersCode = "ARN",
            },

            new()
            {
                Code = "MR",
                Name = "Marathi",
                NativeName = "मराठी",
                Direction = "LTR",
                ThreeLettersCode = "MAR",
            },

            new()
            {
                Code = "MAS",
                Name = "Masai",
                NativeName = "Maa",
                Direction = "LTR",
                ThreeLettersCode = "MAS",
            },

            new()
            {
                Code = "MZN",
                Name = "Mazanderani",
                NativeName = "مازرونی",
                Direction = "LTR",
                ThreeLettersCode = "MZN",
            },

            new()
            {
                Code = "MER",
                Name = "Meru",
                NativeName = "Kĩmĩrũ",
                Direction = "LTR",
                ThreeLettersCode = "MER",
            },

            new()
            {
                Code = "MGO",
                Name = "Metaʼ",
                NativeName = "metaʼ",
                Direction = "LTR",
                ThreeLettersCode = "MGO",
            },

            new()
            {
                Code = "MOH",
                Name = "Mohawk",
                NativeName = "Kanien’kéha",
                Direction = "LTR",
                ThreeLettersCode = "MOH",
            },

            new()
            {
                Code = "MN",
                Name = "Mongolian",
                NativeName = "монгол",
                Direction = "LTR",
                ThreeLettersCode = "MON",
            },

            new()
            {
                Code = "MN",
                Name = "Mongolian",
                NativeName = "монгол",
                Direction = "LTR",
                ThreeLettersCode = "MON",
            },

            new()
            {
                Code = "MN",
                Name = "Mongolian (Traditional Mongolian)",
                NativeName = "ᠮᠣᠩᠭᠣᠤᠯ ᠬᠡᠯᠡ",
                Direction = "LTR",
                ThreeLettersCode = "MON",
            },

            new()
            {
                Code = "MFE",
                Name = "Morisyen",
                NativeName = "kreol morisien",
                Direction = "LTR",
                ThreeLettersCode = "MFE",
            },

            new()
            {
                Code = "MUA",
                Name = "Mundang",
                NativeName = "MUNDAŊ",
                Direction = "LTR",
                ThreeLettersCode = "MUA",
            },

            new()
            {
                Code = "NAQ",
                Name = "Nama",
                NativeName = "Khoekhoegowab",
                Direction = "LTR",
                ThreeLettersCode = "NAQ",
            },

            new()
            {
                Code = "NE",
                Name = "Nepali",
                NativeName = "नेपाली",
                Direction = "LTR",
                ThreeLettersCode = "NEP",
            },

            new()
            {
                Code = "NNH",
                Name = "Ngiemboon",
                NativeName = "Shwóŋò ngiembɔɔn",
                Direction = "LTR",
                ThreeLettersCode = "NNH",
            },

            new()
            {
                Code = "JGO",
                Name = "Ngomba",
                NativeName = "Ndaꞌa",
                Direction = "LTR",
                ThreeLettersCode = "JGO",
            },

            new()
            {
                Code = "NQO",
                Name = "N'ko",
                NativeName = "ߒߞߏ",
                Direction = "RTL",
                ThreeLettersCode = "NQO",
            },

            new()
            {
                Code = "ND",
                Name = "North Ndebele",
                NativeName = "isiNdebele",
                Direction = "LTR",
                ThreeLettersCode = "NDE",
            },

            new()
            {
                Code = "LRC",
                Name = "Northern Luri",
                NativeName = "لۊری شومالی",
                Direction = "LTR",
                ThreeLettersCode = "LRC",
            },

            new()
            {
                Code = "SE",
                Name = "Northern Sami",
                NativeName = "davvisámegiella",
                Direction = "LTR",
                ThreeLettersCode = "SME",
            },

            new()
            {
                Code = "NB",
                Name = "Norwegian",
                NativeName = "norsk",
                Direction = "LTR",
                ThreeLettersCode = "NOB",
            },

            new()
            {
                Code = "NB",
                Name = "Norwegian Bokmål",
                NativeName = "norsk bokmål",
                Direction = "LTR",
                ThreeLettersCode = "NOB",
            },

            new()
            {
                Code = "NN",
                Name = "Norwegian Nynorsk",
                NativeName = "nynorsk",
                Direction = "LTR",
                ThreeLettersCode = "NNO",
            },

            new()
            {
                Code = "NUS",
                Name = "Nuer",
                NativeName = "Thok Nath",
                Direction = "LTR",
                ThreeLettersCode = "NUS",
            },

            new()
            {
                Code = "NYN",
                Name = "Nyankole",
                NativeName = "Runyankore",
                Direction = "LTR",
                ThreeLettersCode = "NYN",
            },

            new()
            {
                Code = "OC",
                Name = "Occitan",
                NativeName = "Occitan",
                Direction = "LTR",
                ThreeLettersCode = "OCI",
            },

            new()
            {
                Code = "OR",
                Name = "Odia",
                NativeName = "ଓଡ଼ିଆ",
                Direction = "LTR",
                ThreeLettersCode = "ORI",
            },

            new()
            {
                Code = "OM",
                Name = "Oromo",
                NativeName = "Oromoo",
                Direction = "LTR",
                ThreeLettersCode = "ORM",
            },

            new()
            {
                Code = "OS",
                Name = "Ossetic",
                NativeName = "ирон",
                Direction = "LTR",
                ThreeLettersCode = "OSS",
            },

            new()
            {
                Code = "PAP",
                Name = "Papiamento",
                NativeName = "Papiamentu",
                Direction = "LTR",
                ThreeLettersCode = "PAP",
            },

            new()
            {
                Code = "PS",
                Name = "Pashto",
                NativeName = "پښتو",
                Direction = "RTL",
                ThreeLettersCode = "PUS",
            },

            new()
            {
                Code = "FA",
                Name = "Persian",
                NativeName = "فارسى",
                Direction = "RTL",
                ThreeLettersCode = "FAS",
            },

            new()
            {
                Code = "PL",
                Name = "Polish",
                NativeName = "polski",
                Direction = "LTR",
                ThreeLettersCode = "POL",
            },

            new()
            {
                Code = "PT",
                Name = "Portuguese",
                NativeName = "português",
                Direction = "LTR",
                ThreeLettersCode = "POR",
            },

            new()
            {
                Code = "PRG",
                Name = "Prussian",
                NativeName = "prūsiskan",
                Direction = "LTR",
                ThreeLettersCode = "PRG",
            },

            new()
            {
                Code = "PA",
                Name = "Punjabi",
                NativeName = "پنجابی",
                Direction = "RTL",
                ThreeLettersCode = "PAN",
            },

            new()
            {
                Code = "PA",
                Name = "Punjabi",
                NativeName = "ਪੰਜਾਬੀ",
                Direction = "LTR",
                ThreeLettersCode = "PAN",
            },

            new()
            {
                Code = "QUZ",
                Name = "Quechua",
                NativeName = "Runasimi",
                Direction = "LTR",
                ThreeLettersCode = "QUB",
            },

            new()
            {
                Code = "RO",
                Name = "Romanian",
                NativeName = "română",
                Direction = "LTR",
                ThreeLettersCode = "RON",
            },

            new()
            {
                Code = "RM",
                Name = "Romansh",
                NativeName = "rumantsch",
                Direction = "LTR",
                ThreeLettersCode = "ROH",
            },

            new()
            {
                Code = "ROF",
                Name = "Rombo",
                NativeName = "Kihorombo",
                Direction = "LTR",
                ThreeLettersCode = "ROF",
            },

            new()
            {
                Code = "RN",
                Name = "Rundi",
                NativeName = "Ikirundi",
                Direction = "LTR",
                ThreeLettersCode = "RUN",
            },

            new()
            {
                Code = "RU",
                Name = "Russian",
                NativeName = "русский",
                Direction = "LTR",
                ThreeLettersCode = "RUS",
            },

            new()
            {
                Code = "RWK",
                Name = "Rwa",
                NativeName = "Kiruwa",
                Direction = "LTR",
                ThreeLettersCode = "RWK",
            },

            new()
            {
                Code = "SSY",
                Name = "Saho",
                NativeName = "Saho",
                Direction = "LTR",
                ThreeLettersCode = "SSY",
            },

            new()
            {
                Code = "SAH",
                Name = "Sakha",
                NativeName = "Саха",
                Direction = "LTR",
                ThreeLettersCode = "SAH",
            },

            new()
            {
                Code = "SAQ",
                Name = "Samburu",
                NativeName = "Kisampur",
                Direction = "LTR",
                ThreeLettersCode = "SAQ",
            },

            new()
            {
                Code = "SMN",
                Name = "Sami (Inari)",
                NativeName = "anarâškielâ",
                Direction = "LTR",
                ThreeLettersCode = "SMN",
            },

            new()
            {
                Code = "SMJ",
                Name = "Sami (Lule)",
                NativeName = "julevusámegiella",
                Direction = "LTR",
                ThreeLettersCode = "SMJ",
            },

            new()
            {
                Code = "SMS",
                Name = "Sami (Skolt)",
                NativeName = "sää´mǩiõll",
                Direction = "LTR",
                ThreeLettersCode = "SMS",
            },

            new()
            {
                Code = "SMA",
                Name = "Sami (Southern)",
                NativeName = "åarjelsaemiengïele",
                Direction = "LTR",
                ThreeLettersCode = "SMA",
            },

            new()
            {
                Code = "sm",
                Name = "Samoan",
                NativeName = "Gagana Sāmoa",
                Direction = "LTR",
                ThreeLettersCode = "smo",
            },

            new()
            {
                Code = "SG",
                Name = "Sango",
                NativeName = "Sängö",
                Direction = "LTR",
                ThreeLettersCode = "SAG",
            },

            new()
            {
                Code = "SBP",
                Name = "Sangu",
                NativeName = "Ishisangu",
                Direction = "LTR",
                ThreeLettersCode = "SBP",
            },

            new()
            {
                Code = "SA",
                Name = "Sanskrit",
                NativeName = "संस्कृत",
                Direction = "LTR",
                ThreeLettersCode = "SAN",
            },

            new()
            {
                Code = "GD",
                Name = "Scottish Gaelic",
                NativeName = "Gàidhlig",
                Direction = "LTR",
                ThreeLettersCode = "GLA",
            },

            new()
            {
                Code = "SEH",
                Name = "Sena",
                NativeName = "sena",
                Direction = "LTR",
                ThreeLettersCode = "SEH",
            },

            new()
            {
                Code = "SR",
                Name = "Serbian",
                NativeName = "srpski",
                Direction = "LTR",
                ThreeLettersCode = "SRP",
            },

            new()
            {
                Code = "SR",
                Name = "Serbian (Cyrillic)",
                NativeName = "српски",
                Direction = "LTR",
                ThreeLettersCode = "SRP",
            },

            new()
            {
                Code = "SR",
                Name = "Serbian (Latin)",
                NativeName = "srpski",
                Direction = "LTR",
                ThreeLettersCode = "SRP",
            },

            new()
            {
                Code = "ST",
                Name = "Sesotho",
                NativeName = "Sesotho",
                Direction = "LTR",
                ThreeLettersCode = "SOT",
            },

            new()
            {
                Code = "NSO",
                Name = "Sesotho sa Leboa",
                NativeName = "Sesotho sa Leboa",
                Direction = "LTR",
                ThreeLettersCode = "NSO",
            },

            new()
            {
                Code = "TN",
                Name = "Setswana",
                NativeName = "Setswana",
                Direction = "LTR",
                ThreeLettersCode = "TSN",
            },

            new()
            {
                Code = "KSB",
                Name = "Shambala",
                NativeName = "Kishambaa",
                Direction = "LTR",
                ThreeLettersCode = "KSB",
            },

            new()
            {
                Code = "SN",
                Name = "Shona",
                NativeName = "chiShona",
                Direction = "LTR",
                ThreeLettersCode = "SNA",
            },

            new()
            {
                Code = "SN",
                Name = "Shona (Latin)",
                NativeName = "chiShona (Latin)",
                Direction = "LTR",
                ThreeLettersCode = "SNA",
            },

            new()
            {
                Code = "SD",
                Name = "Sindhi",
                NativeName = "سنڌي",
                Direction = "RTL",
                ThreeLettersCode = "SND",
            },

            new()
            {
                Code = "SD",
                Name = "Sindhi",
                NativeName = "سنڌي",
                Direction = "RTL",
                ThreeLettersCode = "SND",
            },

            new()
            {
                Code = "SD",
                Name = "Sindhi (Devanagari)",
                NativeName = "सिन्धी",
                Direction = "LTR",
                ThreeLettersCode = "SND",
            },

            new()
            {
                Code = "SI",
                Name = "Sinhala",
                NativeName = "සිංහල",
                Direction = "LTR",
                ThreeLettersCode = "SIN",
            },

            new()
            {
                Code = "SS",
                Name = "siSwati",
                NativeName = "Siswati",
                Direction = "LTR",
                ThreeLettersCode = "SSW",
            },

            new()
            {
                Code = "SK",
                Name = "Slovak",
                NativeName = "slovenčina",
                Direction = "LTR",
                ThreeLettersCode = "SLK",
            },

            new()
            {
                Code = "SL",
                Name = "Slovenian",
                NativeName = "slovenščina",
                Direction = "LTR",
                ThreeLettersCode = "SLV",
            },

            new()
            {
                Code = "XOG",
                Name = "Soga",
                NativeName = "Olusoga",
                Direction = "LTR",
                ThreeLettersCode = "XOG",
            },

            new()
            {
                Code = "SO",
                Name = "Somali",
                NativeName = "Soomaali",
                Direction = "LTR",
                ThreeLettersCode = "SOM",
            },

            new()
            {
                Code = "NR",
                Name = "South Ndebele",
                NativeName = "isiNdebele",
                Direction = "LTR",
                ThreeLettersCode = "NBL",
            },

            new()
            {
                Code = "ES",
                Name = "Spanish",
                NativeName = "español",
                Direction = "LTR",
                ThreeLettersCode = "SPA",
            },

            new()
            {
                Code = "ZGH",
                Name = "Standard Moroccan Tamazight",
                NativeName = "ⵜⴰⵎⴰⵣⵉⵖⵜ",
                Direction = "LTR",
                ThreeLettersCode = "ZGH",
            },

            new()
            {
                Code = "ZGH",
                Name = "Standard Moroccan Tamazight (Tifinagh)",
                NativeName = "ⵜⴰⵎⴰⵣⵉⵖⵜ",
                Direction = "LTR",
                ThreeLettersCode = "ZGH",
            },

            new()
            {
                Code = "SV",
                Name = "Swedish",
                NativeName = "svenska",
                Direction = "LTR",
                ThreeLettersCode = "SWE",
            },

            new()
            {
                Code = "GSW",
                Name = "Swiss German",
                NativeName = "Schwiizertüütsch",
                Direction = "LTR",
                ThreeLettersCode = "GSW",
            },

            new()
            {
                Code = "SYR",
                Name = "Syriac",
                NativeName = "ܣܘܪܝܝܐ",
                Direction = "RTL",
                ThreeLettersCode = "SYR",
            },

            new()
            {
                Code = "SHI",
                Name = "Tachelhit",
                NativeName = "ⵜⴰⵛⵍⵃⵉⵜ",
                Direction = "LTR",
                ThreeLettersCode = "SHI",
            },

            new()
            {
                Code = "SHI",
                Name = "Tachelhit (Latin)",
                NativeName = "Tashelḥiyt",
                Direction = "LTR",
                ThreeLettersCode = "SHI",
            },

            new()
            {
                Code = "SHI",
                Name = "Tachelhit (Tifinagh)",
                NativeName = "ⵜⴰⵛⵍⵃⵉⵜ",
                Direction = "LTR",
                ThreeLettersCode = "SHI",
            },

            new()
            {
                Code = "DAV",
                Name = "Taita",
                NativeName = "Kitaita",
                Direction = "LTR",
                ThreeLettersCode = "DAV",
            },

            new()
            {
                Code = "TG",
                Name = "Tajik",
                NativeName = "Тоҷикӣ",
                Direction = "LTR",
                ThreeLettersCode = "TGK",
            },

            new()
            {
                Code = "TG",
                Name = "Tajik (Cyrillic)",
                NativeName = "тоҷикӣ",
                Direction = "LTR",
                ThreeLettersCode = "TGK",
            },

            new()
            {
                Code = "TA",
                Name = "Tamil",
                NativeName = "தமிழ்",
                Direction = "LTR",
                ThreeLettersCode = "TAM",
            },

            new()
            {
                Code = "TWQ",
                Name = "Tasawaq",
                NativeName = "Tasawaq senni",
                Direction = "LTR",
                ThreeLettersCode = "TWQ",
            },

            new()
            {
                Code = "TT",
                Name = "Tatar",
                NativeName = "Татар",
                Direction = "LTR",
                ThreeLettersCode = "TAT",
            },

            new()
            {
                Code = "TE",
                Name = "Telugu",
                NativeName = "తెలుగు",
                Direction = "LTR",
                ThreeLettersCode = "TEL",
            },

            new()
            {
                Code = "TEO",
                Name = "Teso",
                NativeName = "Kiteso",
                Direction = "LTR",
                ThreeLettersCode = "TEO",
            },

            new()
            {
                Code = "TH",
                Name = "Thai",
                NativeName = "ไทย",
                Direction = "LTR",
                ThreeLettersCode = "THA",
            },

            new()
            {
                Code = "BO",
                Name = "Tibetan",
                NativeName = "བོད་ཡིག",
                Direction = "LTR",
                ThreeLettersCode = "BOD",
            },

            new()
            {
                Code = "TIG",
                Name = "Tigre",
                NativeName = "ትግረ",
                Direction = "LTR",
                ThreeLettersCode = "TIG",
            },

            new()
            {
                Code = "TI",
                Name = "Tigrinya",
                NativeName = "ትግርኛ",
                Direction = "LTR",
                ThreeLettersCode = "TIR",
            },

            new()
            {
                Code = "TO",
                Name = "Tongan",
                NativeName = "lea fakatonga",
                Direction = "LTR",
                ThreeLettersCode = "TON",
            },

            new()
            {
                Code = "TS",
                Name = "Tsonga",
                NativeName = "Xitsonga",
                Direction = "LTR",
                ThreeLettersCode = "TSO",
            },

            new()
            {
                Code = "TR",
                Name = "Turkish",
                NativeName = "Türkçe",
                Direction = "LTR",
                ThreeLettersCode = "TUR",
            },

            new()
            {
                Code = "TK",
                Name = "Turkmen",
                NativeName = "Türkmen dili",
                Direction = "LTR",
                ThreeLettersCode = "TUK",
            },

            new()
            {
                Code = "UK",
                Name = "Ukrainian",
                NativeName = "українська",
                Direction = "LTR",
                ThreeLettersCode = "UKR",
            },

            new()
            {
                Code = "HSB",
                Name = "Upper Sorbian",
                NativeName = "hornjoserbšćina",
                Direction = "LTR",
                ThreeLettersCode = "HSB",
            },

            new()
            {
                Code = "UR",
                Name = "Urdu",
                NativeName = "اُردو",
                Direction = "RTL",
                ThreeLettersCode = "URD",
            },

            new()
            {
                Code = "UG",
                Name = "Uyghur",
                NativeName = "ئۇيغۇرچە",
                Direction = "RTL",
                ThreeLettersCode = "UIG",
            },

            new()
            {
                Code = "UZ",
                Name = "Uzbek",
                NativeName = "o‘zbek",
                Direction = "LTR",
                ThreeLettersCode = "UZB",
            },

            new()
            {
                Code = "UZ",
                Name = "Uzbek (Cyrillic)",
                NativeName = "ўзбекча",
                Direction = "LTR",
                ThreeLettersCode = "UZB",
            },

            new()
            {
                Code = "UZ",
                Name = "Uzbek (Latin)",
                NativeName = "o‘zbek",
                Direction = "LTR",
                ThreeLettersCode = "UZB",
            },

            new()
            {
                Code = "UZ",
                Name = "Uzbek (Perso-Arabic)",
                NativeName = "اوزبیک",
                Direction = "LTR",
                ThreeLettersCode = "UZB",
            },

            new()
            {
                Code = "VAI",
                Name = "Vai",
                NativeName = "ꕙꔤ",
                Direction = "LTR",
                ThreeLettersCode = "VAI",
            },

            new()
            {
                Code = "VAI",
                Name = "Vai (Latin)",
                NativeName = "Vai",
                Direction = "LTR",
                ThreeLettersCode = "VAI",
            },

            new()
            {
                Code = "VAI",
                Name = "Vai (Vai)",
                NativeName = "ꕙꔤ",
                Direction = "LTR",
                ThreeLettersCode = "VAI",
            },

            new()
            {
                Code = "VE",
                Name = "Venda",
                NativeName = "Tshivenḓa",
                Direction = "LTR",
                ThreeLettersCode = "VEN",
            },

            new()
            {
                Code = "VI",
                Name = "Vietnamese",
                NativeName = "Tiếng Việt",
                Direction = "LTR",
                ThreeLettersCode = "VIE",
            },

            new()
            {
                Code = "VO",
                Name = "Volapük",
                NativeName = "Volapük",
                Direction = "LTR",
                ThreeLettersCode = "VOL",
            },

            new()
            {
                Code = "VUN",
                Name = "Vunjo",
                NativeName = "Kyivunjo",
                Direction = "LTR",
                ThreeLettersCode = "VUN",
            },

            new()
            {
                Code = "WAE",
                Name = "Walser",
                NativeName = "Walser",
                Direction = "LTR",
                ThreeLettersCode = "WAE",
            },

            new()
            {
                Code = "CY",
                Name = "Welsh",
                NativeName = "Cymraeg",
                Direction = "LTR",
                ThreeLettersCode = "CYM",
            },

            new()
            {
                Code = "FY",
                Name = "Western Frisian",
                NativeName = "Frysk",
                Direction = "LTR",
                ThreeLettersCode = "FRY",
            },

            new()
            {
                Code = "WAL",
                Name = "Wolaytta",
                NativeName = "ወላይታቱ",
                Direction = "LTR",
                ThreeLettersCode = "WAL",
            },

            new()
            {
                Code = "WO",
                Name = "Wolof",
                NativeName = "Wolof",
                Direction = "LTR",
                ThreeLettersCode = "WOL",
            },

            new()
            {
                Code = "YAV",
                Name = "Yangben",
                NativeName = "nuasue",
                Direction = "LTR",
                ThreeLettersCode = "YAV",
            },

            new()
            {
                Code = "II",
                Name = "Yi",
                NativeName = "ꆈꌠꁱꂷ",
                Direction = "LTR",
                ThreeLettersCode = "III",
            },

            new()
            {
                Code = "YI",
                Name = "Yiddish",
                NativeName = "ייִדיש",
                Direction = "RTL",
                ThreeLettersCode = "YID",
            },

            new()
            {
                Code = "YO",
                Name = "Yoruba",
                NativeName = "Èdè Yorùbá",
                Direction = "LTR",
                ThreeLettersCode = "YOR",
            },

            new()
            {
                Code = "DJE",
                Name = "Zarma",
                NativeName = "Zarmaciine",
                Direction = "LTR",
                ThreeLettersCode = "DJE",
            }
        };
    }
}
