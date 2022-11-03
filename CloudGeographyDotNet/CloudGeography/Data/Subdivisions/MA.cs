using AngryMonkey.Cloud.Geography;
namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    private static void FillInSubdivisionsMA()
    {
        AddSubdivisions("MA", new List<Subdivision>()
        {
            new()
            { 
                Code = "AGD",
                Type = "Prefecture",
                Name = "Agadir-Ida-Outanane",
                LocalName = "Agadir-Ida-Outanane"
            },
            new()
            { 
                Code = "HAO",
                Type = "Province",
                Name = "Al Haouz",
                LocalName = "Al Haouz"
            },
            new()
            { 
                Code = "HOC",
                Type = "Province",
                Name = "Al Hoceïma",
                LocalName = "Al Hoceïma"
            },
            new()
            { 
                Code = "AOU",
                Type = "Prefecture",
                Name = "Aousserd",
                LocalName = "Aousserd"
            },
            new()
            { 
                Code = "ASZ",
                Type = "Province",
                Name = "Assa-Zag",
                LocalName = "Assa-Zag"
            },
            new()
            { 
                Code = "AZI",
                Type = "Province",
                Name = "Azilal",
                LocalName = "Azilal"
            },
            new()
            { 
                Code = "BES",
                Type = "Province",
                Name = "Ben Slimane",
                LocalName = "Ben Slimane"
            },
            new()
            { 
                Code = "BEM",
                Type = "Province",
                Name = "Beni Mellal",
                LocalName = "Beni Mellal"
            },
            new()
            { 
                Code = "BER",
                Type = "Province",
                Name = "Berkane",
                LocalName = "Berkane"
            },
            new()
            { 
                Code = "BOD",
                Type = "Province",
                Name = "Boujdour",
                LocalName = "Boujdour"
            },
            new()
            { 
                Code = "BOM",
                Type = "Province",
                Name = "Boulemane",
                LocalName = "Boulemane"
            },
            new()
            { 
                Code = "CAS",
                Type = "Prefecture",
                Name = "Casablanca",
                LocalName = "Casablanca"
            },
            new()
            { 
                Code = "CHE",
                Type = "Province",
                Name = "Chefchaouene",
                LocalName = "Chefchaouene"
            },
            new()
            { 
                Code = "CHI",
                Type = "Province",
                Name = "Chichaoua",
                LocalName = "Chichaoua"
            },
            new()
            { 
                Code = "CHT",
                Type = "Province",
                Name = "Chtouka-Ait Baha",
                LocalName = "Chtouka-Ait Baha"
            },
            new()
            { 
                Code = "HAJ",
                Type = "Province",
                Name = "El Hajeb",
                LocalName = "El Hajeb"
            },
            new()
            { 
                Code = "JDI",
                Type = "Province",
                Name = "El Jadida",
                LocalName = "El Jadida"
            },
            new()
            { 
                Code = "ERR",
                Type = "Province",
                Name = "Errachidia",
                LocalName = "Errachidia"
            },
            new()
            { 
                Code = "ESM",
                Type = "Province",
                Name = "Es Smara",
                LocalName = "Es Smara"
            },
            new()
            { 
                Code = "ESI",
                Type = "Province",
                Name = "Essaouira",
                LocalName = "Essaouira"
            },
            new()
            { 
                Code = "FAH",
                Type = "Prefecture",
                Name = "Fahs-Beni Makada",
                LocalName = "Fahs-Beni Makada"
            },
            new()
            { 
                Code = "FES",
                Type = "Prefecture",
                Name = "Fès-Dar-Dbibegh",
                LocalName = "Fès-Dar-Dbibegh"
            },
            new()
            { 
                Code = "FIG",
                Type = "Province",
                Name = "Figuig",
                LocalName = "Figuig"
            },
            new()
            { 
                Code = "GUE",
                Type = "Province",
                Name = "Guelmim",
                LocalName = "Guelmim"
            },
            new()
            { 
                Code = "IFR",
                Type = "Province",
                Name = "Ifrane",
                LocalName = "Ifrane"
            },
            new()
            { 
                Code = "INE",
                Type = "Prefecture",
                Name = "Inezgane-Ait Melloul",
                LocalName = "Inezgane-Ait Melloul"
            },
            new()
            { 
                Code = "JRA",
                Type = "Province",
                Name = "Jrada",
                LocalName = "Jrada"
            },
            new()
            { 
                Code = "KES",
                Type = "Province",
                Name = "Kelaat Sraghna",
                LocalName = "Kelaat Sraghna"
            },
            new()
            { 
                Code = "KEN",
                Type = "Province",
                Name = "Kénitra",
                LocalName = "Kénitra"
            },
            new()
            { 
                Code = "KHE",
                Type = "Province",
                Name = "Khemisset",
                LocalName = "Khemisset"
            },
            new()
            { 
                Code = "KHN",
                Type = "Province",
                Name = "Khenifra",
                LocalName = "Khenifra"
            },
            new()
            { 
                Code = "KHO",
                Type = "Province",
                Name = "Khouribga",
                LocalName = "Khouribga"
            },
            new()
            { 
                Code = "LAA",
                Type = "Province",
                Name = "Laâyoune",
                LocalName = "Laâyoune"
            },
            new()
            { 
                Code = "LAR",
                Type = "Province",
                Name = "Larache",
                LocalName = "Larache"
            },
            new()
            { 
                Code = "MMD",
                Type = "Prefecture",
                Name = "Marrakech-Medina",
                LocalName = "Marrakech-Medina"
            },
            new()
            { 
                Code = "MMN",
                Type = "Prefecture",
                Name = "Marrakech-Menara",
                LocalName = "Marrakech-Menara"
            },
            new()
            { 
                Code = "MED",
                Type = "Province",
                Name = "Médiouna",
                LocalName = "Médiouna"
            },
            new()
            { 
                Code = "MEK",
                Type = "Prefecture",
                Name = "Meknès*",
                LocalName = "Meknès*"
            },
            new()
            { 
                Code = "MOH",
                Type = "Prefecture",
                Name = "Mohammadia",
                LocalName = "Mohammadia"
            },
            new()
            { 
                Code = "MOU",
                Type = "Province",
                Name = "Moulay Yacoub",
                LocalName = "Moulay Yacoub"
            },
            new()
            { 
                Code = "NAD",
                Type = "Province",
                Name = "Nador",
                LocalName = "Nador"
            },
            new()
            { 
                Code = "NOU",
                Type = "Province",
                Name = "Nouaceur",
                LocalName = "Nouaceur"
            },
            new()
            { 
                Code = "OUA",
                Type = "Province",
                Name = "Ouarzazate",
                LocalName = "Ouarzazate"
            },
            new()
            { 
                Code = "OUD",
                Type = "Province",
                Name = "Oued ed Dahab",
                LocalName = "Oued ed Dahab"
            },
            new()
            { 
                Code = "OUJ",
                Type = "Prefecture",
                Name = "Oujda-Angad",
                LocalName = "Oujda-Angad"
            },
            new()
            { 
                Code = "RAB",
                Type = "Prefecture",
                Name = "Rabat",
                LocalName = "Rabat"
            },
            new()
            { 
                Code = "SAF",
                Type = "Province",
                Name = "Safi",
                LocalName = "Safi"
            },
            new()
            { 
                Code = "SAL",
                Type = "Prefecture",
                Name = "Salé",
                LocalName = "Salé"
            },
            new()
            { 
                Code = "SEF",
                Type = "Province",
                Name = "Sefrou",
                LocalName = "Sefrou"
            },
            new()
            { 
                Code = "SET",
                Type = "Province",
                Name = "Settat",
                LocalName = "Settat"
            },
            new()
            { 
                Code = "SIK",
                Type = "Province",
                Name = "Sidi Kacem",
                LocalName = "Sidi Kacem"
            },
            new()
            { 
                Code = "SYB",
                Type = "Prefecture",
                Name = "Sidi Youssef Ben Ali",
                LocalName = "Sidi Youssef Ben Ali"
            },
            new()
            { 
                Code = "SKH",
                Type = "Prefecture",
                Name = "Skhirate-Témara",
                LocalName = "Skhirate-Témara"
            },
            new()
            { 
                Code = "TNG",
                Type = "Prefecture",
                Name = "Tanger-Assilah",
                LocalName = "Tanger-Assilah"
            },
            new()
            { 
                Code = "TNT",
                Type = "Province",
                Name = "Tan-Tan",
                LocalName = "Tan-Tan"
            },
            new()
            { 
                Code = "TAO",
                Type = "Province",
                Name = "Taounate",
                LocalName = "Taounate"
            },
            new()
            { 
                Code = "TAI",
                Type = "Province",
                Name = "Taourirt",
                LocalName = "Taourirt"
            },
            new()
            { 
                Code = "TAR",
                Type = "Province",
                Name = "Taroudannt",
                LocalName = "Taroudannt"
            },
            new()
            { 
                Code = "TAT",
                Type = "Province",
                Name = "Tata",
                LocalName = "Tata"
            },
            new()
            { 
                Code = "TAZ",
                Type = "Province",
                Name = "Taza",
                LocalName = "Taza"
            },
            new()
            { 
                Code = "TET",
                Type = "Prefecture",
                Name = "Tétouan*",
                LocalName = "Tétouan*"
            },
            new()
            { 
                Code = "TIZ",
                Type = "Province",
                Name = "Tiznit",
                LocalName = "Tiznit"
            },
            new()
            { 
                Code = "ZAG",
                Type = "Province",
                Name = "Zagora",
                LocalName = "Zagora"
            }

        });
    }
}
