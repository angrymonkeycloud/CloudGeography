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
                IsOffical = false,
                Name = "Afar",
                NativeName = "Qafar",
                Direction = "LTR",
                ThreeLettersCode = "AAR",
            },

            new()
    {
        Code = "AF",
        IsOffical = false,
        Name = "Afrikaans",
        NativeName = "Afrikaans",
        Direction = "LTR",
        ThreeLettersCode = "AFR",
    },
    new()
    {
        Code = "AGQ",
        IsOffical = false,
        Name = "Aghem",
        NativeName = "Aghem",
        Direction = "LTR",
        ThreeLettersCode = "AGQ",
    },
    new()
    {
        Code = "AK",
        IsOffical = false,
        Name = "Akan",
        NativeName = "Akan",
        Direction = "LTR",
        ThreeLettersCode = "AKA",
    },
    new()
    {
        Code = "SQ",
        IsOffical = false,
        Name = "Albanian",
        NativeName = "shqip",
        Direction = "LTR",
        ThreeLettersCode = "SQI",
    },
    new()
    {
        Code = "AM",
        IsOffical = false,
        Name = "Amharic",
        NativeName = "አማርኛ",
        Direction = "LTR",
        ThreeLettersCode = "AMH",
    },
    new()
    {
        Code = "AR",
        IsOffical = false,
        Name = "Arabic",
        NativeName = "العربية",
        Direction = "RTL",
        ThreeLettersCode = "ARA",
    },
    new()
    {
        Code = "HY",
        IsOffical = false,
        Name = "Armenian",
        NativeName = "Հայերեն",
        Direction = "LTR",
        ThreeLettersCode = "HYE",
    },
    new()
    {
        Code = "AS",
        IsOffical = false,
        Name = "Assamese",
        NativeName = "অসমীয়া",
        Direction = "LTR",
        ThreeLettersCode = "ASM",
    },
    new()
    {
        Code = "AST",
        IsOffical = false,
        Name = "Asturian",
        NativeName = "asturianu",
        Direction = "LTR",
        ThreeLettersCode = "AST",
    },
    new()
    {
        Code = "ASA",
        IsOffical = false,
        Name = "Asu",
        NativeName = "Kipare",
        Direction = "LTR",
        ThreeLettersCode = "ASA",
    },
    new()
    {
        Code = "AZ",
        IsOffical = false,
        Name = "Azerbaijani",
        NativeName = "azərbaycan",
        Direction = "LTR",
        ThreeLettersCode = "AZE",
    },
    new()
    {
        Code = "AZ",
        IsOffical = false,
        Name = "Azerbaijani (Cyrillic)",
        NativeName = "Азәрбајҹан дили",
        Direction = "LTR",
        ThreeLettersCode = "AZE",
    },
    new()
    {
        Code = "AZ",
        IsOffical = false,
        Name = "Azerbaijani (Latin)",
        NativeName = "azərbaycan",
        Direction = "LTR",
        ThreeLettersCode = "AZE",
    },
    new()
    {
        Code = "KSF",
        IsOffical = false,
        Name = "Bafia",
        NativeName = "rikpa",
        Direction = "LTR",
        ThreeLettersCode = "KSF",
    },
    new()
    {
        Code = "BM",
        IsOffical = false,
        Name = "Bamanankan",
        NativeName = "bamanakan",
        Direction = "LTR",
        ThreeLettersCode = "BAM",
    },
    new()
    {
        Code = "BM",
        IsOffical = false,
        Name = "Bamanankan (Latin)",
        NativeName = "bamanakan",
        Direction = "LTR",
        ThreeLettersCode = "BAM",
    },
    new()
    {
        Code = "BN",
        IsOffical = false,
        Name = "Bangla",
        NativeName = "বাংলা",
        Direction = "LTR",
        ThreeLettersCode = "BEN",
    },
    new()
    {
        Code = "BAS",
        IsOffical = false,
        Name = "Basaa",
        NativeName = "Ɓàsàa",
        Direction = "LTR",
        ThreeLettersCode = "BAS",
    },
    new()
    {
        Code = "BA",
        IsOffical = false,
        Name = "Bashkir",
        NativeName = "Башҡорт",
        Direction = "LTR",
        ThreeLettersCode = "BAK",
    },
    new()
    {
        Code = "EU",
        IsOffical = false,
        Name = "Basque",
        NativeName = "euskara",
        Direction = "LTR",
        ThreeLettersCode = "EUS",
    },
    new()
    {
        Code = "BE",
        IsOffical = false,
        Name = "Belarusian",
        NativeName = "Беларуская",
        Direction = "LTR",
        ThreeLettersCode = "BEL",
    },
    new()
    {
        Code = "BEM",
        IsOffical = false,
        Name = "Bemba",
        NativeName = "Ichibemba",
        Direction = "LTR",
        ThreeLettersCode = "BEM",
    },
    new()
    {
        Code = "BEZ",
        IsOffical = false,
        Name = "Bena",
        NativeName = "Hibena",
        Direction = "LTR",
        ThreeLettersCode = "BEZ",
    },
    new()
    {
        Code = "BER",
        IsOffical = false,
        Name = "Berber",
        NativeName = "Berber",
        Direction = "LTR",
        ThreeLettersCode = "BER",
    },
    new()
    {
        Code = "BYN",
        IsOffical = false,
        Name = "Blin",
        NativeName = "ብሊን",
        Direction = "LTR",
        ThreeLettersCode = "BYN",
    },
    new()
    {
        Code = "BRX",
        IsOffical = false,
        Name = "Bodo",
        NativeName = "बड़ो",
        Direction = "LTR",
        ThreeLettersCode = "BRX",
    },
    new()
    {
        Code = "BS",
        IsOffical = false,
        Name = "Bosnian",
        NativeName = "bosanski",
        Direction = "LTR",
        ThreeLettersCode = "BOS",
    },
    new()
    {
        Code = "BS",
        IsOffical = false,
        Name = "Bosnian (Cyrillic)",
        NativeName = "босански",
        Direction = "LTR",
        ThreeLettersCode = "BOS",
    },
    new()
    {
        Code = "BS",
        IsOffical = false,
        Name = "Bosnian (Latin)",
        NativeName = "bosanski",
        Direction = "LTR",
        ThreeLettersCode = "BOS",
    },
    new()
    {
        Code = "BR",
        IsOffical = false,
        Name = "Breton",
        NativeName = "brezhoneg",
        Direction = "LTR",
        ThreeLettersCode = "BRE",
    },
    new()
    {
        Code = "BG",
        IsOffical = false,
        Name = "Bulgarian",
        NativeName = "български",
        Direction = "LTR",
        ThreeLettersCode = "BUL",
    },
    new()
    {
        Code = "MY",
        IsOffical = false,
        Name = "Burmese",
        NativeName = "ဗမာ",
        Direction = "LTR",
        ThreeLettersCode = "MYA",
    },
    new()
    {
        Code = "CA",
        IsOffical = false,
        Name = "Catalan",
        NativeName = "català",
        Direction = "LTR",
        ThreeLettersCode = "CAT",
    },
    new()
    {
        Code = "TZM",
        IsOffical = false,
        Name = "Central Atlas Tamazight",
        NativeName = "Tamaziɣt n laṭlaṣ",
        Direction = "LTR",
        ThreeLettersCode = "TZM",
    },
    new()
    {
        Code = "TZM",
        IsOffical = false,
        Name = "Central Atlas Tamazight (Arabic)",
        NativeName = "أطلس المركزية التامازيتية",
        Direction = "RTL",
        ThreeLettersCode = "TZM",
    },
    new()
    {
        Code = "TZM",
        IsOffical = false,
        Name = "Central Atlas Tamazight (Latin)",
        NativeName = "Tamaziɣt n laṭlaṣ",
        Direction = "LTR",
        ThreeLettersCode = "TZM",
    },
    new()
    {
        Code = "TZM",
        IsOffical = false,
        Name = "Central Atlas Tamazight (Tifinagh)",
        NativeName = "ⵜⴰⵎⴰⵣⵉⵖⵜ",
        Direction = "LTR",
        ThreeLettersCode = "TZM",
    },
    new()
    {
        Code = "KU",
        IsOffical = false,
        Name = "Central Kurdish",
        NativeName = "کوردیی ناوەڕاست",
        Direction = "RTL",
        ThreeLettersCode = "KUR",
    },
    new()
    {
        Code = "KU",
        IsOffical = false,
        Name = "Central Kurdish",
        NativeName = "کوردیی ناوەڕاست",
        Direction = "RTL",
        ThreeLettersCode = "KUR",
    },
    new()
    {
        Code = "CE",
        IsOffical = false,
        Name = "Chechen",
        NativeName = "нохчийн",
        Direction = "LTR",
        ThreeLettersCode = "CHE",
    },
    new()
    {
        Code = "CHR",
        IsOffical = false,
        Name = "Cherokee",
        NativeName = "ᏣᎳᎩ",
        Direction = "LTR",
        ThreeLettersCode = "CHR",
    },
    new()
    {
        Code = "CHR",
        IsOffical = false,
        Name = "Cherokee",
        NativeName = "ᏣᎳᎩ",
        Direction = "LTR",
        ThreeLettersCode = "CHR",
    },
    new()
    {
        Code = "CGG",
        IsOffical = false,
        Name = "Chiga",
        NativeName = "Rukiga",
        Direction = "LTR",
        ThreeLettersCode = "CGG",
    },
    new()
    {
        Code = "ZH",
        IsOffical = false,
        Name = "Chinese",
        NativeName = "中文",
        Direction = "LTR",
        ThreeLettersCode = "ZHO",
    },
    new()
    {
        Code = "ZH",
        IsOffical = false,
        Name = "Chinese (Simplified)",
        NativeName = "中文(简体)",
        Direction = "LTR",
        ThreeLettersCode = "ZHO",
    },
    new()
    {
        Code = "ZH",
        IsOffical = false,
        Name = "Chinese (Simplified) Legacy",
        NativeName = "中文(简体) 旧版",
        Direction = "LTR",
        ThreeLettersCode = "ZHO",
    },
    new()
    {
        Code = "ZH",
        IsOffical = false,
        Name = "Chinese (Traditional)",
        NativeName = "中文(繁體)",
        Direction = "LTR",
        ThreeLettersCode = "ZHO",
    },
    new()
    {
        Code = "ZH",
        IsOffical = false,
        Name = "Chinese (Traditional) Legacy",
        NativeName = "中文(繁體) 舊版",
        Direction = "LTR",
        ThreeLettersCode = "ZHO",
    },
    new()
    {
        Code = "CU",
        IsOffical = false,
        Name = "Church Slavic",
        NativeName = "церковнослове́нскїй",
        Direction = "LTR",
        ThreeLettersCode = "CHU",
    },
    new()
    {
        Code = "KSH",
        IsOffical = false,
        Name = "Colognian",
        NativeName = "Kölsch",
        Direction = "LTR",
        ThreeLettersCode = "KSH",
    },
    new()
    {
        Code = "KW",
        IsOffical = false,
        Name = "Cornish",
        NativeName = "kernewek",
        Direction = "LTR",
        ThreeLettersCode = "COR",
    },
    new()
    {
        Code = "CO",
        IsOffical = false,
        Name = "Corsican",
        NativeName = "Corsu",
        Direction = "LTR",
        ThreeLettersCode = "COS",
    },
    new()
    {
        Code = "HR",
        IsOffical = false,
        Name = "Croatian",
        NativeName = "hrvatski",
        Direction = "LTR",
        ThreeLettersCode = "HRV",
    },
    new()
    {
        Code = "CS",
        IsOffical = false,
        Name = "Czech",
        NativeName = "čeština",
        Direction = "LTR",
        ThreeLettersCode = "CES",
    },
    new()
    {
        Code = "DA",
        IsOffical = false,
        Name = "Danish",
        NativeName = "dansk",
        Direction = "LTR",
        ThreeLettersCode = "DAN",
    },
    new()
    {
        Code = "PRS",
        IsOffical = false,
        Name = "Dari",
        NativeName = "درى",
        Direction = "RTL",
        ThreeLettersCode = "PRS",
    },
    new()
    {
        Code = "DV",
        IsOffical = false,
        Name = "Divehi",
        NativeName = "ދިވެހިބަސް",
        Direction = "RTL",
        ThreeLettersCode = "DIV",
    },
    new()
    {
        Code = "DUA",
        IsOffical = false,
        Name = "Duala",
        NativeName = "duálá",
        Direction = "LTR",
        ThreeLettersCode = "DUA",
    },
    new()
    {
        Code = "NL",
        IsOffical = false,
        Name = "Dutch",
        NativeName = "Nederlands",
        Direction = "LTR",
        ThreeLettersCode = "NLD",
    },
    new()
    {
        Code = "DZ",
        IsOffical = false,
        Name = "Dzongkha",
        NativeName = "རྫོང་ཁ",
        Direction = "LTR",
        ThreeLettersCode = "DZO",
    },
    new()
    {
        Code = "BIN",
        IsOffical = false,
        Name = "Edo",
        NativeName = "Ẹ̀dó",
        Direction = "LTR",
        ThreeLettersCode = "BIN",
    },
    new()
    {
        Code = "EBU",
        IsOffical = false,
        Name = "Embu",
        NativeName = "Kĩembu",
        Direction = "LTR",
        ThreeLettersCode = "EBU",
    },
    new()
    {
        Code = "EN",
        IsOffical = false,
        Name = "English",
        NativeName = "English",
        Direction = "LTR",
        ThreeLettersCode = "ENG",
    },
    new()
    {
        Code = "EO",
        IsOffical = false,
        Name = "Esperanto",
        NativeName = "esperanto",
        Direction = "LTR",
        ThreeLettersCode = "EPO",
    },
    new()
    {
        Code = "ET",
        IsOffical = false,
        Name = "Estonian",
        NativeName = "eesti",
        Direction = "LTR",
        ThreeLettersCode = "EST",
    },
    new()
    {
        Code = "EE",
        IsOffical = false,
        Name = "Ewe",
        NativeName = "Eʋegbe",
        Direction = "LTR",
        ThreeLettersCode = "EWE",
    },
    new()
    {
        Code = "EWO",
        IsOffical = false,
        Name = "Ewondo",
        NativeName = "ewondo",
        Direction = "LTR",
        ThreeLettersCode = "EWO",
    },
    new()
    {
        Code = "FO",
        IsOffical = false,
        Name = "Faroese",
        NativeName = "føroyskt",
        Direction = "LTR",
        ThreeLettersCode = "FAO",
    },
    new()
    {
        Code = "FIL",
        IsOffical = false,
        Name = "Filipino",
        NativeName = "Filipino",
        Direction = "LTR",
        ThreeLettersCode = "FIL",
    },
    new()
    {
        Code = "FI",
        IsOffical = false,
        Name = "Finnish",
        NativeName = "suomi",
        Direction = "LTR",
        ThreeLettersCode = "FIN",
    },
    new()
    {
        Code = "FR",
        IsOffical = false,
        Name = "French",
        NativeName = "français",
        Direction = "LTR",
        ThreeLettersCode = "FRA",
    },
    new()
    {
        Code = "FUR",
        IsOffical = false,
        Name = "Friulian",
        NativeName = "furlan",
        Direction = "LTR",
        ThreeLettersCode = "FUR",
    },
    new()
    {
        Code = "FF",
        IsOffical = false,
        Name = "Fulah",
        NativeName = "Fulah",
        Direction = "LTR",
        ThreeLettersCode = "FUL",
    },
    new()
    {
        Code = "FF",
        IsOffical = false,
        Name = "Fulah",
        NativeName = "Fulah",
        Direction = "LTR",
        ThreeLettersCode = "FUL",
    },
    new()
    {
        Code = "GL",
        IsOffical = false,
        Name = "Galician",
        NativeName = "galego",
        Direction = "LTR",
        ThreeLettersCode = "GLG",
    },
    new()
    {
        Code = "LG",
        IsOffical = false,
        Name = "Ganda",
        NativeName = "Luganda",
        Direction = "LTR",
        ThreeLettersCode = "LUG",
    },
    new()
    {
        Code = "KA",
        IsOffical = false,
        Name = "Georgian",
        NativeName = "ქართული",
        Direction = "LTR",
        ThreeLettersCode = "KAT",
    },
    new()
    {
        Code = "DE",
        IsOffical = false,
        Name = "German",
        NativeName = "Deutsch",
        Direction = "LTR",
        ThreeLettersCode = "DEU",
    },
    new()
    {
        Code = "EL",
        IsOffical = false,
        Name = "Greek",
        NativeName = "Ελληνικά",
        Direction = "LTR",
        ThreeLettersCode = "ELL",
    },
    new()
    {
        Code = "KL",
        IsOffical = false,
        Name = "Greenlandic",
        NativeName = "kalaallisut",
        Direction = "LTR",
        ThreeLettersCode = "KAL",
    },
    new()
    {
        Code = "GN",
        IsOffical = false,
        Name = "Guarani",
        NativeName = "Avañe’ẽ",
        Direction = "LTR",
        ThreeLettersCode = "GRN",
    },
    new()
    {
        Code = "GU",
        IsOffical = false,
        Name = "Gujarati",
        NativeName = "ગુજરાતી",
        Direction = "LTR",
        ThreeLettersCode = "GUJ",
    },
    new()
    {
        Code = "GUZ",
        IsOffical = false,
        Name = "Gusii",
        NativeName = "Ekegusii",
        Direction = "LTR",
        ThreeLettersCode = "GUZ",
    },
    new()
    {
        Code = "HA",
        IsOffical = false,
        Name = "Hausa",
        NativeName = "Hausa",
        Direction = "LTR",
        ThreeLettersCode = "HAU",
    },
    new()
    {
        Code = "HA",
        IsOffical = false,
        Name = "Hausa (Latin)",
        NativeName = "Hausa",
        Direction = "LTR",
        ThreeLettersCode = "HAU",
    },
    new()
    {
        Code = "HAW",
        IsOffical = false,
        Name = "Hawaiian",
        NativeName = "ʻŌlelo Hawaiʻi",
        Direction = "LTR",
        ThreeLettersCode = "HAW",
    },
    new()
    {
        Code = "HE",
        IsOffical = false,
        Name = "Hebrew",
        NativeName = "עברית",
        Direction = "RTL",
        ThreeLettersCode = "HEB",
    },
    new()
    {
        Code = "HI",
        IsOffical = false,
        Name = "Hindi",
        NativeName = "हिंदी",
        Direction = "LTR",
        ThreeLettersCode = "HIN",
    },
    new()
    {
        Code = "HU",
        IsOffical = false,
        Name = "Hungarian",
        NativeName = "magyar",
        Direction = "LTR",
        ThreeLettersCode = "HUN",
    },
    new()
    {
        Code = "IBB",
        IsOffical = false,
        Name = "Ibibio",
        NativeName = "Ibibio-Efik",
        Direction = "LTR",
        ThreeLettersCode = "IBB",
    },
    new()
    {
        Code = "IS",
        IsOffical = false,
        Name = "Icelandic",
        NativeName = "íslenska",
        Direction = "LTR",
        ThreeLettersCode = "ISL",
    },
    new()
    {
        Code = "IG",
        IsOffical = false,
        Name = "Igbo",
        NativeName = "Igbo",
        Direction = "LTR",
        ThreeLettersCode = "IBO",
    },
    new()
    {
        Code = "ID",
        IsOffical = false,
        Name = "Indonesian",
        NativeName = "Indonesia",
        Direction = "LTR",
        ThreeLettersCode = "IND",
    },
    new()
    {
        Code = "IA",
        IsOffical = false,
        Name = "Interlingua",
        NativeName = "interlingua",
        Direction = "LTR",
        ThreeLettersCode = "INA",
    },
    new()
    {
        Code = "IU",
        IsOffical = false,
        Name = "Inuktitut",
        NativeName = "Inuktitut",
        Direction = "LTR",
        ThreeLettersCode = "IKU",
    },
    new()
    {
        Code = "IU",
        IsOffical = false,
        Name = "Inuktitut (Latin)",
        NativeName = "Inuktitut",
        Direction = "LTR",
        ThreeLettersCode = "IKU",
    },
    new()
    {
        Code = "IU",
        IsOffical = false,
        Name = "Inuktitut (Syllabics)",
        NativeName = "ᐃᓄᒃᑎᑐᑦ",
        Direction = "LTR",
        ThreeLettersCode = "IKU",
    },
    new()
    {
        Code = "IV",
        IsOffical = false,
        Name = "Invariant Language (Invariant Country)",
        NativeName = "Invariant Language (Invariant Country)",
        Direction = "LTR",
        ThreeLettersCode = "IVL",
    },
    new()
    {
        Code = "GA",
        IsOffical = false,
        Name = "Irish",
        NativeName = "Gaeilge",
        Direction = "LTR",
        ThreeLettersCode = "GLE",
    },
    new()
    {
        Code = "XH",
        IsOffical = false,
        Name = "isiXhosa",
        NativeName = "isiXhosa",
        Direction = "LTR",
        ThreeLettersCode = "XHO",
    },
    new()
    {
        Code = "ZU",
        IsOffical = false,
        Name = "isiZulu",
        NativeName = "isiZulu",
        Direction = "LTR",
        ThreeLettersCode = "ZUL",
    },
    new()
    {
        Code = "IT",
        IsOffical = false,
        Name = "Italian",
        NativeName = "italiano",
        Direction = "LTR",
        ThreeLettersCode = "ITA",
    },
    new()
    {
        Code = "JA",
        IsOffical = false,
        Name = "Japanese",
        NativeName = "日本語",
        Direction = "LTR",
        ThreeLettersCode = "JPN",
    },
    new()
    {
        Code = "JV",
        IsOffical = false,
        Name = "Javanese",
        NativeName = "Basa Jawa",
        Direction = "LTR",
        ThreeLettersCode = "JAV",
    },
    new()
    {
        Code = "JV",
        IsOffical = false,
        Name = "Javanese",
        NativeName = "Basa Jawa",
        Direction = "LTR",
        ThreeLettersCode = "JAV",
    },
    new()
    {
        Code = "JV",
        IsOffical = false,
        Name = "Javanese (Javanese)",
        NativeName = "ꦧꦱꦗꦮ",
        Direction = "LTR",
        ThreeLettersCode = "JAV",
    },
    new()
    {
        Code = "DYO",
        IsOffical = false,
        Name = "Jola-Fonyi",
        NativeName = "joola",
        Direction = "LTR",
        ThreeLettersCode = "DYO",
    },
    new()
    {
        Code = "KEA",
        IsOffical = false,
        Name = "Kabuverdianu",
        NativeName = "kabuverdianu",
        Direction = "LTR",
        ThreeLettersCode = "KEA",
    },
    new()
    {
        Code = "KAB",
        IsOffical = false,
        Name = "Kabyle",
        NativeName = "Taqbaylit",
        Direction = "LTR",
        ThreeLettersCode = "KAB",
    },
    new()
    {
        Code = "KKJ",
        IsOffical = false,
        Name = "Kako",
        NativeName = "kakɔ",
        Direction = "LTR",
        ThreeLettersCode = "KKJ",
    },
    new()
    {
        Code = "KLN",
        IsOffical = false,
        Name = "Kalenjin",
        NativeName = "Kalenjin",
        Direction = "LTR",
        ThreeLettersCode = "KLN",
    },
    new()
    {
        Code = "KAM",
        IsOffical = false,
        Name = "Kamba",
        NativeName = "Kikamba",
        Direction = "LTR",
        ThreeLettersCode = "KAM",
    },
    new()
    {
        Code = "KN",
        IsOffical = false,
        Name = "Kannada",
        NativeName = "ಕನ್ನಡ",
        Direction = "LTR",
        ThreeLettersCode = "KAN",
    },
    new()
    {
        Code = "KR",
        IsOffical = false,
        Name = "Kanuri",
        NativeName = "Kanuri",
        Direction = "LTR",
        ThreeLettersCode = "KAU",
    },
    new()
    {
        Code = "KS",
        IsOffical = false,
        Name = "Kashmiri",
        NativeName = "کٲشُر",
        Direction = "LTR",
        ThreeLettersCode = "KAS",
    },
    new()
    {
        Code = "KS",
        IsOffical = false,
        Name = "Kashmiri (Devanagari)",
        NativeName = "कॉशुर",
        Direction = "LTR",
        ThreeLettersCode = "KAS",
    },
    new()
    {
        Code = "KS",
        IsOffical = false,
        Name = "Kashmiri (Perso-Arabic)",
        NativeName = "کٲشُر",
        Direction = "LTR",
        ThreeLettersCode = "KAS",
    },
    new()
    {
        Code = "KK",
        IsOffical = false,
        Name = "Kazakh",
        NativeName = "қазақ тілі",
        Direction = "LTR",
        ThreeLettersCode = "KAZ",
    },
    new()
    {
        Code = "KM",
        IsOffical = false,
        Name = "Khmer",
        NativeName = "ភាសាខ្មែរ",
        Direction = "LTR",
        ThreeLettersCode = "KHM",
    },
    new()
    {
        Code = "QUC",
        IsOffical = false,
        Name = "K'iche'",
        NativeName = "K'iche'",
        Direction = "LTR",
        ThreeLettersCode = "QUC",
    },
    new()
    {
        Code = "QUC",
        IsOffical = false,
        Name = "K'iche'",
        NativeName = "K'iche'",
        Direction = "LTR",
        ThreeLettersCode = "QUC",
    },
    new()
    {
        Code = "KI",
        IsOffical = false,
        Name = "Kikuyu",
        NativeName = "Gikuyu",
        Direction = "LTR",
        ThreeLettersCode = "KIK",
    },
    new()
    {
        Code = "RW",
        IsOffical = false,
        Name = "Kinyarwanda",
        NativeName = "Kinyarwanda",
        Direction = "LTR",
        ThreeLettersCode = "KIN",
    },
    new()
    {
        Code = "SW",
        IsOffical = false,
        Name = "Kiswahili",
        NativeName = "Kiswahili",
        Direction = "LTR",
        ThreeLettersCode = "SWA",
    },
    new()
    {
        Code = "KOK",
        IsOffical = false,
        Name = "Konkani",
        NativeName = "कोंकणी",
        Direction = "LTR",
        ThreeLettersCode = "KOK",
    },
    new()
    {
        Code = "KO",
        IsOffical = false,
        Name = "Korean",
        NativeName = "한국어",
        Direction = "LTR",
        ThreeLettersCode = "KOR",
    },
    new()
    {
        Code = "KHQ",
        IsOffical = false,
        Name = "Koyra Chiini",
        NativeName = "Koyra ciini",
        Direction = "LTR",
        ThreeLettersCode = "KHQ",
    },
    new()
    {
        Code = "SES",
        IsOffical = false,
        Name = "Koyraboro Senni",
        NativeName = "Koyraboro senni",
        Direction = "LTR",
        ThreeLettersCode = "SES",
    },
    new()
    {
        Code = "NMG",
        IsOffical = false,
        Name = "Kwasio",
        NativeName = "Kwasio",
        Direction = "LTR",
        ThreeLettersCode = "NMG",
    },
    new()
    {
        Code = "KY",
        IsOffical = false,
        Name = "Kyrgyz",
        NativeName = "Кыргыз",
        Direction = "LTR",
        ThreeLettersCode = "KIR",
    },
    new()
    {
        Code = "LKT",
        IsOffical = false,
        Name = "Lakota",
        NativeName = "Lakȟólʼiyapi",
        Direction = "LTR",
        ThreeLettersCode = "LKT",
    },
    new()
    {
        Code = "LAG",
        IsOffical = false,
        Name = "Langi",
        NativeName = "Kɨlaangi",
        Direction = "LTR",
        ThreeLettersCode = "LAG",
    },
    new()
    {
        Code = "LO",
        IsOffical = false,
        Name = "Lao",
        NativeName = "ລາວ",
        Direction = "LTR",
        ThreeLettersCode = "LAO",
    },
    new()
    {
        Code = "LA",
        IsOffical = false,
        Name = "Latin",
        NativeName = "lingua latīna",
        Direction = "LTR",
        ThreeLettersCode = "LAT",
    },
    new()
    {
        Code = "LV",
        IsOffical = false,
        Name = "Latvian",
        NativeName = "latviešu",
        Direction = "LTR",
        ThreeLettersCode = "LAV",
    },
    new()
    {
        Code = "LN",
        IsOffical = false,
        Name = "Lingala",
        NativeName = "lingála",
        Direction = "LTR",
        ThreeLettersCode = "LIN",
    },
    new()
    {
        Code = "LT",
        IsOffical = false,
        Name = "Lithuanian",
        NativeName = "lietuvių",
        Direction = "LTR",
        ThreeLettersCode = "LIT",
    },
    new()
    {
        Code = "NDS",
        IsOffical = false,
        Name = "Low German",
        NativeName = "Neddersass’sch",
        Direction = "LTR",
        ThreeLettersCode = "NDS",
    },
    new()
    {
        Code = "DSB",
        IsOffical = false,
        Name = "Lower Sorbian",
        NativeName = "dolnoserbšćina",
        Direction = "LTR",
        ThreeLettersCode = "DSB",
    },
    new()
    {
        Code = "LU",
        IsOffical = false,
        Name = "Luba-Katanga",
        NativeName = "Tshiluba",
        Direction = "LTR",
        ThreeLettersCode = "LUB",
    },
    new()
    {
        Code = "LUO",
        IsOffical = false,
        Name = "Luo",
        NativeName = "Dholuo",
        Direction = "LTR",
        ThreeLettersCode = "LUO",
    },
    new()
    {
        Code = "LB",
        IsOffical = false,
        Name = "Luxembourgish",
        NativeName = "Lëtzebuergesch",
        Direction = "LTR",
        ThreeLettersCode = "LTZ",
    },
    new()
    {
        Code = "LUY",
        IsOffical = false,
        Name = "Luyia",
        NativeName = "Luluhia",
        Direction = "LTR",
        ThreeLettersCode = "LUY",
    },
    new()
    {
        Code = "MK",
        IsOffical = false,
        Name = "Macedonian",
        NativeName = "македонски",
        Direction = "LTR",
        ThreeLettersCode = "MKD",
    },
    new()
    {
        Code = "JMC",
        IsOffical = false,
        Name = "Machame",
        NativeName = "Kimachame",
        Direction = "LTR",
        ThreeLettersCode = "JMC",
    },
    new()
    {
        Code = "MGH",
        IsOffical = false,
        Name = "Makhuwa-Meetto",
        NativeName = "Makua",
        Direction = "LTR",
        ThreeLettersCode = "MGH",
    },
    new()
    {
        Code = "KDE",
        IsOffical = false,
        Name = "Makonde",
        NativeName = "Chimakonde",
        Direction = "LTR",
        ThreeLettersCode = "KDE",
    },
    new()
    {
        Code = "MG",
        IsOffical = false,
        Name = "Malagasy",
        NativeName = "Malagasy",
        Direction = "LTR",
        ThreeLettersCode = "MLG",
    },
    new()
    {
        Code = "MS",
        IsOffical = false,
        Name = "Malay",
        NativeName = "Bahasa Melayu",
        Direction = "LTR",
        ThreeLettersCode = "MSA",
    },
    new()
    {
        Code = "ML",
        IsOffical = false,
        Name = "Malayalam",
        NativeName = "മലയാളം",
        Direction = "LTR",
        ThreeLettersCode = "MAL",
    },
    new()
    {
        Code = "MT",
        IsOffical = false,
        Name = "Maltese",
        NativeName = "Malti",
        Direction = "LTR",
        ThreeLettersCode = "MLT",
    },
    new()
    {
        Code = "MNI",
        IsOffical = false,
        Name = "Manipuri",
        NativeName = "মৈতৈলোন্",
        Direction = "LTR",
        ThreeLettersCode = "MNI",
    },
    new()
    {
        Code = "GV",
        IsOffical = false,
        Name = "Manx",
        NativeName = "Gaelg",
        Direction = "LTR",
        ThreeLettersCode = "GLV",
    },
    new()
    {
        Code = "MI",
        IsOffical = false,
        Name = "Maori",
        NativeName = "Reo Māori",
        Direction = "LTR",
        ThreeLettersCode = "MRI",
    },
    new()
    {
        Code = "ARN",
        IsOffical = false,
        Name = "Mapudungun",
        NativeName = "Mapudungun",
        Direction = "LTR",
        ThreeLettersCode = "ARN",
    },
    new()
    {
        Code = "MR",
        IsOffical = false,
        Name = "Marathi",
        NativeName = "मराठी",
        Direction = "LTR",
        ThreeLettersCode = "MAR",
    },
    new()
    {
        Code = "MAS",
        IsOffical = false,
        Name = "Masai",
        NativeName = "Maa",
        Direction = "LTR",
        ThreeLettersCode = "MAS",
    },
    new()
    {
        Code = "MZN",
        IsOffical = false,
        Name = "Mazanderani",
        NativeName = "مازرونی",
        Direction = "LTR",
        ThreeLettersCode = "MZN",
    },
    new()
    {
        Code = "MER",
        IsOffical = false,
        Name = "Meru",
        NativeName = "Kĩmĩrũ",
        Direction = "LTR",
        ThreeLettersCode = "MER",
    },
    new()
    {
        Code = "MGO",
        IsOffical = false,
        Name = "Metaʼ",
        NativeName = "metaʼ",
        Direction = "LTR",
        ThreeLettersCode = "MGO",
    },
    new()
    {
        Code = "MOH",
        IsOffical = false,
        Name = "Mohawk",
        NativeName = "Kanien’kéha",
        Direction = "LTR",
        ThreeLettersCode = "MOH",
    },
    new()
    {
        Code = "MN",
        IsOffical = false,
        Name = "Mongolian",
        NativeName = "монгол",
        Direction = "LTR",
        ThreeLettersCode = "MON",
    },
    new()
    {
        Code = "MN",
        IsOffical = false,
        Name = "Mongolian",
        NativeName = "монгол",
        Direction = "LTR",
        ThreeLettersCode = "MON",
    },
    new()
    {
        Code = "MN",
        IsOffical = false,
        Name = "Mongolian (Traditional Mongolian)",
        NativeName = "ᠮᠣᠩᠭᠣᠤᠯ ᠬᠡᠯᠡ",
        Direction = "LTR",
        ThreeLettersCode = "MON",
    },
    new()
    {
        Code = "MFE",
        IsOffical = false,
        Name = "Morisyen",
        NativeName = "kreol morisien",
        Direction = "LTR",
        ThreeLettersCode = "MFE",
    },
    new()
    {
        Code = "MUA",
        IsOffical = false,
        Name = "Mundang",
        NativeName = "MUNDAŊ",
        Direction = "LTR",
        ThreeLettersCode = "MUA",
    },
    new()
    {
        Code = "NAQ",
        IsOffical = false,
        Name = "Nama",
        NativeName = "Khoekhoegowab",
        Direction = "LTR",
        ThreeLettersCode = "NAQ",
    },
    new()
    {
        Code = "NE",
        IsOffical = false,
        Name = "Nepali",
        NativeName = "नेपाली",
        Direction = "LTR",
        ThreeLettersCode = "NEP",
    },
    new()
    {
        Code = "NNH",
        IsOffical = false,
        Name = "Ngiemboon",
        NativeName = "Shwóŋò ngiembɔɔn",
        Direction = "LTR",
        ThreeLettersCode = "NNH",
    },
    new()
    {
        Code = "JGO",
        IsOffical = false,
        Name = "Ngomba",
        NativeName = "Ndaꞌa",
        Direction = "LTR",
        ThreeLettersCode = "JGO",
    },
    new()
    {
        Code = "NQO",
        IsOffical = false,
        Name = "N'ko",
        NativeName = "ߒߞߏ",
        Direction = "RTL",
        ThreeLettersCode = "NQO",
    },
    new()
    {
        Code = "ND",
        IsOffical = false,
        Name = "North Ndebele",
        NativeName = "isiNdebele",
        Direction = "LTR",
        ThreeLettersCode = "NDE",
    },
    new()
    {
        Code = "LRC",
        IsOffical = false,
        Name = "Northern Luri",
        NativeName = "لۊری شومالی",
        Direction = "LTR",
        ThreeLettersCode = "LRC",
    },
    new()
    {
        Code = "SE",
        IsOffical = false,
        Name = "Northern Sami",
        NativeName = "davvisámegiella",
        Direction = "LTR",
        ThreeLettersCode = "SME",
    },
    new()
    {
        Code = "NB",
        IsOffical = false,
        Name = "Norwegian",
        NativeName = "norsk",
        Direction = "LTR",
        ThreeLettersCode = "NOB",
    },
    new()
    {
        Code = "NB",
        IsOffical = false,
        Name = "Norwegian Bokmål",
        NativeName = "norsk bokmål",
        Direction = "LTR",
        ThreeLettersCode = "NOB",
    },
    new()
    {
        Code = "NN",
        IsOffical = false,
        Name = "Norwegian Nynorsk",
        NativeName = "nynorsk",
        Direction = "LTR",
        ThreeLettersCode = "NNO",
    },
    new()
    {
        Code = "NUS",
        IsOffical = false,
        Name = "Nuer",
        NativeName = "Thok Nath",
        Direction = "LTR",
        ThreeLettersCode = "NUS",
    },
    new()
    {
        Code = "NYN",
        IsOffical = false,
        Name = "Nyankole",
        NativeName = "Runyankore",
        Direction = "LTR",
        ThreeLettersCode = "NYN",
    },
    new()
    {
        Code = "OC",
        IsOffical = false,
        Name = "Occitan",
        NativeName = "Occitan",
        Direction = "LTR",
        ThreeLettersCode = "OCI",
    },
    new()
    {
        Code = "OR",
        IsOffical = false,
        Name = "Odia",
        NativeName = "ଓଡ଼ିଆ",
        Direction = "LTR",
        ThreeLettersCode = "ORI",
    },
    new()
    {
        Code = "OM",
        IsOffical = false,
        Name = "Oromo",
        NativeName = "Oromoo",
        Direction = "LTR",
        ThreeLettersCode = "ORM",
    },
    new()
    {
        Code = "OS",
        IsOffical = false,
        Name = "Ossetic",
        NativeName = "ирон",
        Direction = "LTR",
        ThreeLettersCode = "OSS",
    },
    new()
    {
        Code = "PAP",
        IsOffical = false,
        Name = "Papiamento",
        NativeName = "Papiamentu",
        Direction = "LTR",
        ThreeLettersCode = "PAP",
    },
    new()
    {
        Code = "PS",
        IsOffical = false,
        Name = "Pashto",
        NativeName = "پښتو",
        Direction = "RTL",
        ThreeLettersCode = "PUS",
    },
    new()
    {
        Code = "FA",
        IsOffical = false,
        Name = "Persian",
        NativeName = "فارسى",
        Direction = "RTL",
        ThreeLettersCode = "FAS",
    },
    new()
    {
        Code = "PL",
        IsOffical = false,
        Name = "Polish",
        NativeName = "polski",
        Direction = "LTR",
        ThreeLettersCode = "POL",
    },
    new()
    {
        Code = "PT",
        IsOffical = false,
        Name = "Portuguese",
        NativeName = "português",
        Direction = "LTR",
        ThreeLettersCode = "POR",
    },
    new()
    {
        Code = "PRG",
        IsOffical = false,
        Name = "Prussian",
        NativeName = "prūsiskan",
        Direction = "LTR",
        ThreeLettersCode = "PRG",
    },
    new()
    {
        Code = "PA",
        IsOffical = false,
        Name = "Punjabi",
        NativeName = "پنجابی",
        Direction = "RTL",
        ThreeLettersCode = "PAN",
    },
    new()
    {
        Code = "PA",
        IsOffical = false,
        Name = "Punjabi",
        NativeName = "ਪੰਜਾਬੀ",
        Direction = "LTR",
        ThreeLettersCode = "PAN",
    },
    new()
    {
        Code = "QUZ",
        IsOffical = false,
        Name = "Quechua",
        NativeName = "Runasimi",
        Direction = "LTR",
        ThreeLettersCode = "QUB",
    },
    new()
    {
        Code = "RO",
        IsOffical = false,
        Name = "Romanian",
        NativeName = "română",
        Direction = "LTR",
        ThreeLettersCode = "RON",
    },
    new()
    {
        Code = "RM",
        IsOffical = false,
        Name = "Romansh",
        NativeName = "rumantsch",
        Direction = "LTR",
        ThreeLettersCode = "ROH",
    },
    new()
    {
        Code = "ROF",
        IsOffical = false,
        Name = "Rombo",
        NativeName = "Kihorombo",
        Direction = "LTR",
        ThreeLettersCode = "ROF",
    },
    new()
    {
        Code = "RN",
        IsOffical = false,
        Name = "Rundi",
        NativeName = "Ikirundi",
        Direction = "LTR",
        ThreeLettersCode = "RUN",
    },
    new()
    {
        Code = "RU",
        IsOffical = false,
        Name = "Russian",
        NativeName = "русский",
        Direction = "LTR",
        ThreeLettersCode = "RUS",
    },
    new()
    {
        Code = "RWK",
        IsOffical = false,
        Name = "Rwa",
        NativeName = "Kiruwa",
        Direction = "LTR",
        ThreeLettersCode = "RWK",
    },
    new()
    {
        Code = "SSY",
        IsOffical = false,
        Name = "Saho",
        NativeName = "Saho",
        Direction = "LTR",
        ThreeLettersCode = "SSY",
    },
    new()
    {
        Code = "SAH",
        IsOffical = false,
        Name = "Sakha",
        NativeName = "Саха",
        Direction = "LTR",
        ThreeLettersCode = "SAH",
    },
    new()
    {
        Code = "SAQ",
        IsOffical = false,
        Name = "Samburu",
        NativeName = "Kisampur",
        Direction = "LTR",
        ThreeLettersCode = "SAQ",
    },
    new()
    {
        Code = "SMN",
        IsOffical = false,
        Name = "Sami (Inari)",
        NativeName = "anarâškielâ",
        Direction = "LTR",
        ThreeLettersCode = "SMN",
    },
    new()
    {
        Code = "SMJ",
        IsOffical = false,
        Name = "Sami (Lule)",
        NativeName = "julevusámegiella",
        Direction = "LTR",
        ThreeLettersCode = "SMJ",
    },
    new()
    {
        Code = "SMS",
        IsOffical = false,
        Name = "Sami (Skolt)",
        NativeName = "sää´mǩiõll",
        Direction = "LTR",
        ThreeLettersCode = "SMS",
    },
    new()
    {
        Code = "SMA",
        IsOffical = false,
        Name = "Sami (Southern)",
        NativeName = "åarjelsaemiengïele",
        Direction = "LTR",
        ThreeLettersCode = "SMA",
    },
    new()
    {
        Code = "sm",
        IsOffical = false,
        Name = "Samoan",
        NativeName = "Gagana Sāmoa",
        Direction = "LTR",
        ThreeLettersCode = "smo",
    },
    new()
    {
        Code = "SG",
        IsOffical = false,
        Name = "Sango",
        NativeName = "Sängö",
        Direction = "LTR",
        ThreeLettersCode = "SAG",
    },
    new()
    {
        Code = "SBP",
        IsOffical = false,
        Name = "Sangu",
        NativeName = "Ishisangu",
        Direction = "LTR",
        ThreeLettersCode = "SBP",
    },
    new()
    {
        Code = "SA",
        IsOffical = false,
        Name = "Sanskrit",
        NativeName = "संस्कृत",
        Direction = "LTR",
        ThreeLettersCode = "SAN",
    },
    new()
    {
        Code = "GD",
        IsOffical = false,
        Name = "Scottish Gaelic",
        NativeName = "Gàidhlig",
        Direction = "LTR",
        ThreeLettersCode = "GLA",
    },
    new()
    {
        Code = "SEH",
        IsOffical = false,
        Name = "Sena",
        NativeName = "sena",
        Direction = "LTR",
        ThreeLettersCode = "SEH",
    },
    new()
    {
        Code = "SR",
        IsOffical = false,
        Name = "Serbian",
        NativeName = "srpski",
        Direction = "LTR",
        ThreeLettersCode = "SRP",
    },
    new()
    {
        Code = "SR",
        IsOffical = false,
        Name = "Serbian (Cyrillic)",
        NativeName = "српски",
        Direction = "LTR",
        ThreeLettersCode = "SRP",
    },
    new()
    {
        Code = "SR",
        IsOffical = false,
        Name = "Serbian (Latin)",
        NativeName = "srpski",
        Direction = "LTR",
        ThreeLettersCode = "SRP",
    },
    new()
    {
        Code = "ST",
        IsOffical = false,
        Name = "Sesotho",
        NativeName = "Sesotho",
        Direction = "LTR",
        ThreeLettersCode = "SOT",
    },
    new()
    {
        Code = "NSO",
        IsOffical = false,
        Name = "Sesotho sa Leboa",
        NativeName = "Sesotho sa Leboa",
        Direction = "LTR",
        ThreeLettersCode = "NSO",
    },
    new()
    {
        Code = "TN",
        IsOffical = false,
        Name = "Setswana",
        NativeName = "Setswana",
        Direction = "LTR",
        ThreeLettersCode = "TSN",
    },
    new()
    {
        Code = "KSB",
        IsOffical = false,
        Name = "Shambala",
        NativeName = "Kishambaa",
        Direction = "LTR",
        ThreeLettersCode = "KSB",
    },
    new()
    {
        Code = "SN",
        IsOffical = false,
        Name = "Shona",
        NativeName = "chiShona",
        Direction = "LTR",
        ThreeLettersCode = "SNA",
    },
    new()
    {
        Code = "SN",
        IsOffical = false,
        Name = "Shona (Latin)",
        NativeName = "chiShona (Latin)",
        Direction = "LTR",
        ThreeLettersCode = "SNA",
    },
    new()
    {
        Code = "SD",
        IsOffical = false,
        Name = "Sindhi",
        NativeName = "سنڌي",
        Direction = "RTL",
        ThreeLettersCode = "SND",
    },
    new()
    {
        Code = "SD",
        IsOffical = false,
        Name = "Sindhi",
        NativeName = "سنڌي",
        Direction = "RTL",
        ThreeLettersCode = "SND",
    },
    new()
    {
        Code = "SD",
        IsOffical = false,
        Name = "Sindhi (Devanagari)",
        NativeName = "सिन्धी",
        Direction = "LTR",
        ThreeLettersCode = "SND",
    },
    new()
    {
        Code = "SI",
        IsOffical = false,
        Name = "Sinhala",
        NativeName = "සිංහල",
        Direction = "LTR",
        ThreeLettersCode = "SIN",
    },
    new()
    {
        Code = "SS",
        IsOffical = false,
        Name = "siSwati",
        NativeName = "Siswati",
        Direction = "LTR",
        ThreeLettersCode = "SSW",
    },
    new()
    {
        Code = "SK",
        IsOffical = false,
        Name = "Slovak",
        NativeName = "slovenčina",
        Direction = "LTR",
        ThreeLettersCode = "SLK",
    },
    new()
    {
        Code = "SL",
        IsOffical = false,
        Name = "Slovenian",
        NativeName = "slovenščina",
        Direction = "LTR",
        ThreeLettersCode = "SLV",
    },
    new()
    {
        Code = "XOG",
        IsOffical = false,
        Name = "Soga",
        NativeName = "Olusoga",
        Direction = "LTR",
        ThreeLettersCode = "XOG",
    },
    new()
    {
        Code = "SO",
        IsOffical = false,
        Name = "Somali",
        NativeName = "Soomaali",
        Direction = "LTR",
        ThreeLettersCode = "SOM",
    },
    new()
    {
        Code = "NR",
        IsOffical = false,
        Name = "South Ndebele",
        NativeName = "isiNdebele",
        Direction = "LTR",
        ThreeLettersCode = "NBL",
    },
    new()
    {
        Code = "ES",
        IsOffical = false,
        Name = "Spanish",
        NativeName = "español",
        Direction = "LTR",
        ThreeLettersCode = "SPA",
    },
    new()
    {
        Code = "ZGH",
        IsOffical = false,
        Name = "Standard Moroccan Tamazight",
        NativeName = "ⵜⴰⵎⴰⵣⵉⵖⵜ",
        Direction = "LTR",
        ThreeLettersCode = "ZGH",
    },
    new()
    {
        Code = "ZGH",
        IsOffical = false,
        Name = "Standard Moroccan Tamazight (Tifinagh)",
        NativeName = "ⵜⴰⵎⴰⵣⵉⵖⵜ",
        Direction = "LTR",
        ThreeLettersCode = "ZGH",
    },
    new()
    {
        Code = "SV",
        IsOffical = false,
        Name = "Swedish",
        NativeName = "svenska",
        Direction = "LTR",
        ThreeLettersCode = "SWE",
    },
    new()
    {
        Code = "GSW",
        IsOffical = false,
        Name = "Swiss German",
        NativeName = "Schwiizertüütsch",
        Direction = "LTR",
        ThreeLettersCode = "GSW",
    },
    new()
    {
        Code = "SYR",
        IsOffical = false,
        Name = "Syriac",
        NativeName = "ܣܘܪܝܝܐ",
        Direction = "RTL",
        ThreeLettersCode = "SYR",
    },
    new()
    {
        Code = "SHI",
        IsOffical = false,
        Name = "Tachelhit",
        NativeName = "ⵜⴰⵛⵍⵃⵉⵜ",
        Direction = "LTR",
        ThreeLettersCode = "SHI",
    },
    new()
    {
        Code = "SHI",
        IsOffical = false,
        Name = "Tachelhit (Latin)",
        NativeName = "Tashelḥiyt",
        Direction = "LTR",
        ThreeLettersCode = "SHI",
    },
    new()
    {
        Code = "SHI",
        IsOffical = false,
        Name = "Tachelhit (Tifinagh)",
        NativeName = "ⵜⴰⵛⵍⵃⵉⵜ",
        Direction = "LTR",
        ThreeLettersCode = "SHI",
    },
    new()
    {
        Code = "DAV",
        IsOffical = false,
        Name = "Taita",
        NativeName = "Kitaita",
        Direction = "LTR",
        ThreeLettersCode = "DAV",
    },
    new()
    {
        Code = "TG",
        IsOffical = false,
        Name = "Tajik",
        NativeName = "Тоҷикӣ",
        Direction = "LTR",
        ThreeLettersCode = "TGK",
    },
    new()
    {
        Code = "TG",
        IsOffical = false,
        Name = "Tajik (Cyrillic)",
        NativeName = "тоҷикӣ",
        Direction = "LTR",
        ThreeLettersCode = "TGK",
    },
    new()
    {
        Code = "TA",
        IsOffical = false,
        Name = "Tamil",
        NativeName = "தமிழ்",
        Direction = "LTR",
        ThreeLettersCode = "TAM",
    },
    new()
    {
        Code = "TWQ",
        IsOffical = false,
        Name = "Tasawaq",
        NativeName = "Tasawaq senni",
        Direction = "LTR",
        ThreeLettersCode = "TWQ",
    },
    new()
    {
        Code = "TT",
        IsOffical = false,
        Name = "Tatar",
        NativeName = "Татар",
        Direction = "LTR",
        ThreeLettersCode = "TAT",
    },
    new()
    {
        Code = "TE",
        IsOffical = false,
        Name = "Telugu",
        NativeName = "తెలుగు",
        Direction = "LTR",
        ThreeLettersCode = "TEL",
    },
    new()
    {
        Code = "TEO",
        IsOffical = false,
        Name = "Teso",
        NativeName = "Kiteso",
        Direction = "LTR",
        ThreeLettersCode = "TEO",
    },
    new()
    {
        Code = "TH",
        IsOffical = false,
        Name = "Thai",
        NativeName = "ไทย",
        Direction = "LTR",
        ThreeLettersCode = "THA",
    },
    new()
    {
        Code = "BO",
        IsOffical = false,
        Name = "Tibetan",
        NativeName = "བོད་ཡིག",
        Direction = "LTR",
        ThreeLettersCode = "BOD",
    },
    new()
    {
        Code = "TIG",
        IsOffical = false,
        Name = "Tigre",
        NativeName = "ትግረ",
        Direction = "LTR",
        ThreeLettersCode = "TIG",
    },
    new()
    {
        Code = "TI",
        IsOffical = false,
        Name = "Tigrinya",
        NativeName = "ትግርኛ",
        Direction = "LTR",
        ThreeLettersCode = "TIR",
    },
    new()
    {
        Code = "TO",
        IsOffical = false,
        Name = "Tongan",
        NativeName = "lea fakatonga",
        Direction = "LTR",
        ThreeLettersCode = "TON",
    },
    new()
    {
        Code = "TS",
        IsOffical = false,
        Name = "Tsonga",
        NativeName = "Xitsonga",
        Direction = "LTR",
        ThreeLettersCode = "TSO",
    },
    new()
    {
        Code = "TR",
        IsOffical = false,
        Name = "Turkish",
        NativeName = "Türkçe",
        Direction = "LTR",
        ThreeLettersCode = "TUR",
    },
    new()
    {
        Code = "TK",
        IsOffical = false,
        Name = "Turkmen",
        NativeName = "Türkmen dili",
        Direction = "LTR",
        ThreeLettersCode = "TUK",
    },
    new()
    {
        Code = "UK",
        IsOffical = false,
        Name = "Ukrainian",
        NativeName = "українська",
        Direction = "LTR",
        ThreeLettersCode = "UKR",
    },
    new()
    {
        Code = "HSB",
        IsOffical = false,
        Name = "Upper Sorbian",
        NativeName = "hornjoserbšćina",
        Direction = "LTR",
        ThreeLettersCode = "HSB",
    },
    new()
    {
        Code = "UR",
        IsOffical = false,
        Name = "Urdu",
        NativeName = "اُردو",
        Direction = "RTL",
        ThreeLettersCode = "URD",
    },
    new()
    {
        Code = "UG",
        IsOffical = false,
        Name = "Uyghur",
        NativeName = "ئۇيغۇرچە",
        Direction = "RTL",
        ThreeLettersCode = "UIG",
    },
    new()
    {
        Code = "UZ",
        IsOffical = false,
        Name = "Uzbek",
        NativeName = "o‘zbek",
        Direction = "LTR",
        ThreeLettersCode = "UZB",
    },
    new()
    {
        Code = "UZ",
        IsOffical = false,
        Name = "Uzbek (Cyrillic)",
        NativeName = "ўзбекча",
        Direction = "LTR",
        ThreeLettersCode = "UZB",
    },
    new()
    {
        Code = "UZ",
        IsOffical = false,
        Name = "Uzbek (Latin)",
        NativeName = "o‘zbek",
        Direction = "LTR",
        ThreeLettersCode = "UZB",
    },
    new()
    {
        Code = "UZ",
        IsOffical = false,
        Name = "Uzbek (Perso-Arabic)",
        NativeName = "اوزبیک",
        Direction = "LTR",
        ThreeLettersCode = "UZB",
    },
    new()
    {
        Code = "VAI",
        IsOffical = false,
        Name = "Vai",
        NativeName = "ꕙꔤ",
        Direction = "LTR",
        ThreeLettersCode = "VAI",
    },
    new()
    {
        Code = "VAI",
        IsOffical = false,
        Name = "Vai (Latin)",
        NativeName = "Vai",
        Direction = "LTR",
        ThreeLettersCode = "VAI",
    },
    new()
    {
        Code = "VAI",
        IsOffical = false,
        Name = "Vai (Vai)",
        NativeName = "ꕙꔤ",
        Direction = "LTR",
        ThreeLettersCode = "VAI",
    },
    new()
    {
        Code = "VE",
        IsOffical = false,
        Name = "Venda",
        NativeName = "Tshivenḓa",
        Direction = "LTR",
        ThreeLettersCode = "VEN",
    },
    new()
    {
        Code = "VI",
        IsOffical = false,
        Name = "Vietnamese",
        NativeName = "Tiếng Việt",
        Direction = "LTR",
        ThreeLettersCode = "VIE",
    },
    new()
    {
        Code = "VO",
        IsOffical = false,
        Name = "Volapük",
        NativeName = "Volapük",
        Direction = "LTR",
        ThreeLettersCode = "VOL",
    },
    new()
    {
        Code = "VUN",
        IsOffical = false,
        Name = "Vunjo",
        NativeName = "Kyivunjo",
        Direction = "LTR",
        ThreeLettersCode = "VUN",
    },
    new()
    {
        Code = "WAE",
        IsOffical = false,
        Name = "Walser",
        NativeName = "Walser",
        Direction = "LTR",
        ThreeLettersCode = "WAE",
    },
    new()
    {
        Code = "CY",
        IsOffical = false,
        Name = "Welsh",
        NativeName = "Cymraeg",
        Direction = "LTR",
        ThreeLettersCode = "CYM",
    },
    new()
    {
        Code = "FY",
        IsOffical = false,
        Name = "Western Frisian",
        NativeName = "Frysk",
        Direction = "LTR",
        ThreeLettersCode = "FRY",
    },
    new()
    {
        Code = "WAL",
        IsOffical = false,
        Name = "Wolaytta",
        NativeName = "ወላይታቱ",
        Direction = "LTR",
        ThreeLettersCode = "WAL",
    },
    new()
    {
        Code = "WO",
        IsOffical = false,
        Name = "Wolof",
        NativeName = "Wolof",
        Direction = "LTR",
        ThreeLettersCode = "WOL",
    },
    new()
    {
        Code = "YAV",
        IsOffical = false,
        Name = "Yangben",
        NativeName = "nuasue",
        Direction = "LTR",
        ThreeLettersCode = "YAV",
    },
    new()
    {
        Code = "II",
        IsOffical = false,
        Name = "Yi",
        NativeName = "ꆈꌠꁱꂷ",
        Direction = "LTR",
        ThreeLettersCode = "III",
    },
    new()
    {
        Code = "YI",
        IsOffical = false,
        Name = "Yiddish",
        NativeName = "ייִדיש",
        Direction = "RTL",
        ThreeLettersCode = "YID",
    },
    new()
    {
        Code = "YO",
        IsOffical = false,
        Name = "Yoruba",
        NativeName = "Èdè Yorùbá",
        Direction = "LTR",
        ThreeLettersCode = "YOR",
    },
    new()
    {
        Code = "DJE",
        IsOffical = false,
        Name = "Zarma",
        NativeName = "Zarmaciine",
        Direction = "LTR",
        ThreeLettersCode = "DJE",
    }
        };
    }
}