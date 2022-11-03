using AngryMonkey.Cloud.Geography;
namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    private static void FillInSubdivisionsUG()
    {
        AddSubdivisions("UG", new List<Subdivision>()
        {
            new()
            { 
                Code = "314",
                Type = "District",
                Name = "Abim",
                LocalName = "Abim"
            },
            new()
            { 
                Code = "301",
                Type = "District",
                Name = "Adjumani",
                LocalName = "Adjumani"
            },
            new()
            { 
                Code = "315",
                Type = "District",
                Name = "Amolatar",
                LocalName = "Amolatar"
            },
            new()
            { 
                Code = "216",
                Type = "District",
                Name = "Amuria",
                LocalName = "Amuria"
            },
            new()
            { 
                Code = "316",
                Type = "District",
                Name = "Amuru",
                LocalName = "Amuru"
            },
            new()
            { 
                Code = "302",
                Type = "District",
                Name = "Apac",
                LocalName = "Apac"
            },
            new()
            { 
                Code = "303",
                Type = "District",
                Name = "Arua",
                LocalName = "Arua"
            },
            new()
            { 
                Code = "217",
                Type = "District",
                Name = "Budaka",
                LocalName = "Budaka"
            },
            new()
            { 
                Code = "218",
                Type = "District",
                Name = "Bududa",
                LocalName = "Bududa"
            },
            new()
            { 
                Code = "201",
                Type = "District",
                Name = "Bugiri",
                LocalName = "Bugiri"
            },
            new()
            { 
                Code = "420",
                Type = "District",
                Name = "Buhweju",
                LocalName = "Buhweju"
            },
            new()
            { 
                Code = "117",
                Type = "District",
                Name = "Buikwe",
                LocalName = "Buikwe"
            },
            new()
            { 
                Code = "219",
                Type = "District",
                Name = "Bukedea",
                LocalName = "Bukedea"
            },
            new()
            { 
                Code = "118",
                Type = "District",
                Name = "Bukomansibi",
                LocalName = "Bukomansibi"
            },
            new()
            { 
                Code = "220",
                Type = "District",
                Name = "Bukwa",
                LocalName = "Bukwa"
            },
            new()
            { 
                Code = "225",
                Type = "District",
                Name = "Bulambuli",
                LocalName = "Bulambuli"
            },
            new()
            { 
                Code = "416",
                Type = "District",
                Name = "Buliisa",
                LocalName = "Buliisa"
            },
            new()
            { 
                Code = "401",
                Type = "District",
                Name = "Bundibugyo",
                LocalName = "Bundibugyo"
            },
            new()
            { 
                Code = "402",
                Type = "District",
                Name = "Bushenyi",
                LocalName = "Bushenyi"
            },
            new()
            { 
                Code = "202",
                Type = "District",
                Name = "Busia",
                LocalName = "Busia"
            },
            new()
            { 
                Code = "221",
                Type = "District",
                Name = "Butaleja",
                LocalName = "Butaleja"
            },
            new()
            { 
                Code = "119",
                Type = "District",
                Name = "Butambala",
                LocalName = "Butambala"
            },
            new()
            { 
                Code = "120",
                Type = "District",
                Name = "Buvuma",
                LocalName = "Buvuma"
            },
            new()
            { 
                Code = "226",
                Type = "District",
                Name = "Buyende",
                LocalName = "Buyende"
            },
            new()
            { 
                Code = "317",
                Type = "District",
                Name = "Dokolo",
                LocalName = "Dokolo"
            },
            new()
            { 
                Code = "121",
                Type = "District",
                Name = "Gomba",
                LocalName = "Gomba"
            },
            new()
            { 
                Code = "304",
                Type = "District",
                Name = "Gulu",
                LocalName = "Gulu"
            },
            new()
            { 
                Code = "403",
                Type = "District",
                Name = "Hoima",
                LocalName = "Hoima"
            },
            new()
            { 
                Code = "417",
                Type = "District",
                Name = "Ibanda",
                LocalName = "Ibanda"
            },
            new()
            { 
                Code = "203",
                Type = "District",
                Name = "Iganga",
                LocalName = "Iganga"
            },
            new()
            { 
                Code = "418",
                Type = "District",
                Name = "Isingiro",
                LocalName = "Isingiro"
            },
            new()
            { 
                Code = "204",
                Type = "District",
                Name = "Jinja",
                LocalName = "Jinja"
            },
            new()
            { 
                Code = "318",
                Type = "District",
                Name = "Kaabong",
                LocalName = "Kaabong"
            },
            new()
            { 
                Code = "404",
                Type = "District",
                Name = "Kabale",
                LocalName = "Kabale"
            },
            new()
            { 
                Code = "405",
                Type = "District",
                Name = "Kabarole",
                LocalName = "Kabarole"
            },
            new()
            { 
                Code = "213",
                Type = "District",
                Name = "Kaberamaido",
                LocalName = "Kaberamaido"
            },
            new()
            { 
                Code = "101",
                Type = "District",
                Name = "Kalangala",
                LocalName = "Kalangala"
            },
            new()
            { 
                Code = "222",
                Type = "District",
                Name = "Kaliro",
                LocalName = "Kaliro"
            },
            new()
            { 
                Code = "122",
                Type = "District",
                Name = "Kalungu",
                LocalName = "Kalungu"
            },
            new()
            { 
                Code = "102",
                Type = "City",
                Name = "Kampala",
                LocalName = "Kampala"
            },
            new()
            { 
                Code = "205",
                Type = "District",
                Name = "Kamuli",
                LocalName = "Kamuli"
            },
            new()
            { 
                Code = "413",
                Type = "District",
                Name = "Kamwenge",
                LocalName = "Kamwenge"
            },
            new()
            { 
                Code = "414",
                Type = "District",
                Name = "Kanungu",
                LocalName = "Kanungu"
            },
            new()
            { 
                Code = "206",
                Type = "District",
                Name = "Kapchorwa",
                LocalName = "Kapchorwa"
            },
            new()
            { 
                Code = "406",
                Type = "District",
                Name = "Kasese",
                LocalName = "Kasese"
            },
            new()
            { 
                Code = "207",
                Type = "District",
                Name = "Katakwi",
                LocalName = "Katakwi"
            },
            new()
            { 
                Code = "112",
                Type = "District",
                Name = "Kayunga",
                LocalName = "Kayunga"
            },
            new()
            { 
                Code = "407",
                Type = "District",
                Name = "Kibaale",
                LocalName = "Kibaale"
            },
            new()
            { 
                Code = "103",
                Type = "District",
                Name = "Kiboga",
                LocalName = "Kiboga"
            },
            new()
            { 
                Code = "227",
                Type = "District",
                Name = "Kibuku",
                LocalName = "Kibuku"
            },
            new()
            { 
                Code = "419",
                Type = "District",
                Name = "Kiruhura",
                LocalName = "Kiruhura"
            },
            new()
            { 
                Code = "421",
                Type = "District",
                Name = "Kiryandongo",
                LocalName = "Kiryandongo"
            },
            new()
            { 
                Code = "408",
                Type = "District",
                Name = "Kisoro",
                LocalName = "Kisoro"
            },
            new()
            { 
                Code = "305",
                Type = "District",
                Name = "Kitgum",
                LocalName = "Kitgum"
            },
            new()
            { 
                Code = "319",
                Type = "District",
                Name = "Koboko",
                LocalName = "Koboko"
            },
            new()
            { 
                Code = "325",
                Type = "District",
                Name = "Kole",
                LocalName = "Kole"
            },
            new()
            { 
                Code = "306",
                Type = "District",
                Name = "Kotido",
                LocalName = "Kotido"
            },
            new()
            { 
                Code = "208",
                Type = "District",
                Name = "Kumi",
                LocalName = "Kumi"
            },
            new()
            { 
                Code = "228",
                Type = "District",
                Name = "Kween",
                LocalName = "Kween"
            },
            new()
            { 
                Code = "123",
                Type = "District",
                Name = "Kyankwanzi",
                LocalName = "Kyankwanzi"
            },
            new()
            { 
                Code = "422",
                Type = "District",
                Name = "Kyegegwa",
                LocalName = "Kyegegwa"
            },
            new()
            { 
                Code = "415",
                Type = "District",
                Name = "Kyenjojo",
                LocalName = "Kyenjojo"
            },
            new()
            { 
                Code = "326",
                Type = "District",
                Name = "Lamwo",
                LocalName = "Lamwo"
            },
            new()
            { 
                Code = "307",
                Type = "District",
                Name = "Lira",
                LocalName = "Lira"
            },
            new()
            { 
                Code = "229",
                Type = "District",
                Name = "Luuka",
                LocalName = "Luuka"
            },
            new()
            { 
                Code = "104",
                Type = "District",
                Name = "Luwero",
                LocalName = "Luwero"
            },
            new()
            { 
                Code = "124",
                Type = "District",
                Name = "Lwengo",
                LocalName = "Lwengo"
            },
            new()
            { 
                Code = "114",
                Type = "District",
                Name = "Lyantonde",
                LocalName = "Lyantonde"
            },
            new()
            { 
                Code = "223",
                Type = "District",
                Name = "Manafwa",
                LocalName = "Manafwa"
            },
            new()
            { 
                Code = "320",
                Type = "District",
                Name = "Maracha",
                LocalName = "Maracha"
            },
            new()
            { 
                Code = "105",
                Type = "District",
                Name = "Masaka",
                LocalName = "Masaka"
            },
            new()
            { 
                Code = "409",
                Type = "District",
                Name = "Masindi",
                LocalName = "Masindi"
            },
            new()
            { 
                Code = "244",
                Type = "District",
                Name = "Mayuge",
                LocalName = "Mayuge"
            },
            new()
            { 
                Code = "209",
                Type = "District",
                Name = "Mbale",
                LocalName = "Mbale"
            },
            new()
            { 
                Code = "410",
                Type = "District",
                Name = "Mbarara",
                LocalName = "Mbarara"
            },
            new()
            { 
                Code = "423",
                Type = "District",
                Name = "Mitooma",
                LocalName = "Mitooma"
            },
            new()
            { 
                Code = "115",
                Type = "District",
                Name = "Mityana",
                LocalName = "Mityana"
            },
            new()
            { 
                Code = "308",
                Type = "District",
                Name = "Moroto",
                LocalName = "Moroto"
            },
            new()
            { 
                Code = "309",
                Type = "District",
                Name = "Moyo",
                LocalName = "Moyo"
            },
            new()
            { 
                Code = "106",
                Type = "District",
                Name = "Mpigi",
                LocalName = "Mpigi"
            },
            new()
            { 
                Code = "107",
                Type = "District",
                Name = "Mubende",
                LocalName = "Mubende"
            },
            new()
            { 
                Code = "108",
                Type = "District",
                Name = "Mukono",
                LocalName = "Mukono"
            },
            new()
            { 
                Code = "311",
                Type = "District",
                Name = "Nakapiripirit",
                LocalName = "Nakapiripirit"
            },
            new()
            { 
                Code = "116",
                Type = "District",
                Name = "Nakaseke",
                LocalName = "Nakaseke"
            },
            new()
            { 
                Code = "109",
                Type = "District",
                Name = "Nakasongola",
                LocalName = "Nakasongola"
            },
            new()
            { 
                Code = "230",
                Type = "District",
                Name = "Namayingo",
                LocalName = "Namayingo"
            },
            new()
            { 
                Code = "224",
                Type = "District",
                Name = "Namutumba",
                LocalName = "Namutumba"
            },
            new()
            { 
                Code = "327",
                Type = "District",
                Name = "Napak",
                LocalName = "Napak"
            },
            new()
            { 
                Code = "310",
                Type = "District",
                Name = "Nebbi",
                LocalName = "Nebbi"
            },
            new()
            { 
                Code = "231",
                Type = "District",
                Name = "Ngora",
                LocalName = "Ngora"
            },
            new()
            { 
                Code = "424",
                Type = "District",
                Name = "Ntoroko",
                LocalName = "Ntoroko"
            },
            new()
            { 
                Code = "411",
                Type = "District",
                Name = "Ntungamo",
                LocalName = "Ntungamo"
            },
            new()
            { 
                Code = "328",
                Type = "District",
                Name = "Nwoya",
                LocalName = "Nwoya"
            },
            new()
            { 
                Code = "329",
                Type = "District",
                Name = "Otuke",
                LocalName = "Otuke"
            },
            new()
            { 
                Code = "321",
                Type = "District",
                Name = "Oyam",
                LocalName = "Oyam"
            },
            new()
            { 
                Code = "312",
                Type = "District",
                Name = "Pader",
                LocalName = "Pader"
            },
            new()
            { 
                Code = "210",
                Type = "District",
                Name = "Pallisa",
                LocalName = "Pallisa"
            },
            new()
            { 
                Code = "110",
                Type = "District",
                Name = "Rakai",
                LocalName = "Rakai"
            },
            new()
            { 
                Code = "425",
                Type = "District",
                Name = "Rubirizi",
                LocalName = "Rubirizi"
            },
            new()
            { 
                Code = "412",
                Type = "District",
                Name = "Rukungiri",
                LocalName = "Rukungiri"
            },
            new()
            { 
                Code = "111",
                Type = "District",
                Name = "Sembabule",
                LocalName = "Sembabule"
            },
            new()
            { 
                Code = "232",
                Type = "District",
                Name = "Serere",
                LocalName = "Serere"
            },
            new()
            { 
                Code = "426",
                Type = "District",
                Name = "Sheema",
                LocalName = "Sheema"
            },
            new()
            { 
                Code = "215",
                Type = "District",
                Name = "Sironko",
                LocalName = "Sironko"
            },
            new()
            { 
                Code = "211",
                Type = "District",
                Name = "Soroti",
                LocalName = "Soroti"
            },
            new()
            { 
                Code = "212",
                Type = "District",
                Name = "Tororo",
                LocalName = "Tororo"
            },
            new()
            { 
                Code = "113",
                Type = "District",
                Name = "Wakiso",
                LocalName = "Wakiso"
            },
            new()
            { 
                Code = "313",
                Type = "District",
                Name = "Yumbe",
                LocalName = "Yumbe"
            },
            new()
            { 
                Code = "330",
                Type = "District",
                Name = "Zombo",
                LocalName = "Zombo"
            }

        });
    }
}
