using AngryMonkey.Cloud.Geography;
namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    private static void FillInSubdivisionsMA()
    {
        AddSubdivisions("MA",
        [
            new()
            { 
                Code = "AGD",
                Type = SubdivisionTypes.Prefecture,
                Name = "Agadir-Ida-Outanane",
                LocalName = "Agadir-Ida-Outanane"
            },
            new()
            { 
                Code = "HAO",
                Type = SubdivisionTypes.Province,
                Name = "Al Haouz",
                LocalName = "Al Haouz"
            },
            new()
            { 
                Code = "HOC",
                Type = SubdivisionTypes.Province,
                Name = "Al Hoceïma",
                LocalName = "Al Hoceïma"
            },
            new()
            { 
                Code = "AOU",
                Type = SubdivisionTypes.Prefecture,
                Name = "Aousserd",
                LocalName = "Aousserd"
            },
            new()
            { 
                Code = "ASZ",
                Type = SubdivisionTypes.Province,
                Name = "Assa-Zag",
                LocalName = "Assa-Zag"
            },
            new()
            { 
                Code = "AZI",
                Type = SubdivisionTypes.Province,
                Name = "Azilal",
                LocalName = "Azilal"
            },
            new()
            { 
                Code = "BES",
                Type = SubdivisionTypes.Province,
                Name = "Ben Slimane",
                LocalName = "Ben Slimane"
            },
            new()
            { 
                Code = "BEM",
                Type = SubdivisionTypes.Province,
                Name = "Beni Mellal",
                LocalName = "Beni Mellal"
            },
            new()
            { 
                Code = "BER",
                Type = SubdivisionTypes.Province,
                Name = "Berkane",
                LocalName = "Berkane"
            },
            new()
            { 
                Code = "BOD",
                Type = SubdivisionTypes.Province,
                Name = "Boujdour",
                LocalName = "Boujdour"
            },
            new()
            { 
                Code = "BOM",
                Type = SubdivisionTypes.Province,
                Name = "Boulemane",
                LocalName = "Boulemane"
            },
            new()
            { 
                Code = "CAS",
                Type = SubdivisionTypes.Prefecture,
                Name = "Casablanca",
                LocalName = "Casablanca"
            },
            new()
            { 
                Code = "CHE",
                Type = SubdivisionTypes.Province,
                Name = "Chefchaouene",
                LocalName = "Chefchaouene"
            },
            new()
            { 
                Code = "CHI",
                Type = SubdivisionTypes.Province,
                Name = "Chichaoua",
                LocalName = "Chichaoua"
            },
            new()
            { 
                Code = "CHT",
                Type = SubdivisionTypes.Province,
                Name = "Chtouka-Ait Baha",
                LocalName = "Chtouka-Ait Baha"
            },
            new()
            { 
                Code = "HAJ",
                Type = SubdivisionTypes.Province,
                Name = "El Hajeb",
                LocalName = "El Hajeb"
            },
            new()
            { 
                Code = "JDI",
                Type = SubdivisionTypes.Province,
                Name = "El Jadida",
                LocalName = "El Jadida"
            },
            new()
            { 
                Code = "ERR",
                Type = SubdivisionTypes.Province,
                Name = "Errachidia",
                LocalName = "Errachidia"
            },
            new()
            { 
                Code = "ESM",
                Type = SubdivisionTypes.Province,
                Name = "Es Smara",
                LocalName = "Es Smara"
            },
            new()
            { 
                Code = "ESI",
                Type = SubdivisionTypes.Province,
                Name = "Essaouira",
                LocalName = "Essaouira"
            },
            new()
            { 
                Code = "FAH",
                Type = SubdivisionTypes.Prefecture,
                Name = "Fahs-Beni Makada",
                LocalName = "Fahs-Beni Makada"
            },
            new()
            { 
                Code = "FES",
                Type = SubdivisionTypes.Prefecture,
                Name = "Fès-Dar-Dbibegh",
                LocalName = "Fès-Dar-Dbibegh"
            },
            new()
            { 
                Code = "FIG",
                Type = SubdivisionTypes.Province,
                Name = "Figuig",
                LocalName = "Figuig"
            },
            new()
            { 
                Code = "GUE",
                Type = SubdivisionTypes.Province,
                Name = "Guelmim",
                LocalName = "Guelmim"
            },
            new()
            { 
                Code = "IFR",
                Type = SubdivisionTypes.Province,
                Name = "Ifrane",
                LocalName = "Ifrane"
            },
            new()
            { 
                Code = "INE",
                Type = SubdivisionTypes.Prefecture,
                Name = "Inezgane-Ait Melloul",
                LocalName = "Inezgane-Ait Melloul"
            },
            new()
            { 
                Code = "JRA",
                Type = SubdivisionTypes.Province,
                Name = "Jrada",
                LocalName = "Jrada"
            },
            new()
            { 
                Code = "KES",
                Type = SubdivisionTypes.Province,
                Name = "Kelaat Sraghna",
                LocalName = "Kelaat Sraghna"
            },
            new()
            { 
                Code = "KEN",
                Type = SubdivisionTypes.Province,
                Name = "Kénitra",
                LocalName = "Kénitra"
            },
            new()
            { 
                Code = "KHE",
                Type = SubdivisionTypes.Province,
                Name = "Khemisset",
                LocalName = "Khemisset"
            },
            new()
            { 
                Code = "KHN",
                Type = SubdivisionTypes.Province,
                Name = "Khenifra",
                LocalName = "Khenifra"
            },
            new()
            { 
                Code = "KHO",
                Type = SubdivisionTypes.Province,
                Name = "Khouribga",
                LocalName = "Khouribga"
            },
            new()
            { 
                Code = "LAA",
                Type = SubdivisionTypes.Province,
                Name = "Laâyoune",
                LocalName = "Laâyoune"
            },
            new()
            { 
                Code = "LAR",
                Type = SubdivisionTypes.Province,
                Name = "Larache",
                LocalName = "Larache"
            },
            new()
            { 
                Code = "MMD",
                Type = SubdivisionTypes.Prefecture,
                Name = "Marrakech-Medina",
                LocalName = "Marrakech-Medina"
            },
            new()
            { 
                Code = "MMN",
                Type = SubdivisionTypes.Prefecture,
                Name = "Marrakech-Menara",
                LocalName = "Marrakech-Menara"
            },
            new()
            { 
                Code = "MED",
                Type = SubdivisionTypes.Province,
                Name = "Médiouna",
                LocalName = "Médiouna"
            },
            new()
            { 
                Code = "MEK",
                Type = SubdivisionTypes.Prefecture,
                Name = "Meknès*",
                LocalName = "Meknès*"
            },
            new()
            { 
                Code = "MOH",
                Type = SubdivisionTypes.Prefecture,
                Name = "Mohammadia",
                LocalName = "Mohammadia"
            },
            new()
            { 
                Code = "MOU",
                Type = SubdivisionTypes.Province,
                Name = "Moulay Yacoub",
                LocalName = "Moulay Yacoub"
            },
            new()
            { 
                Code = "NAD",
                Type = SubdivisionTypes.Province,
                Name = "Nador",
                LocalName = "Nador"
            },
            new()
            { 
                Code = "NOU",
                Type = SubdivisionTypes.Province,
                Name = "Nouaceur",
                LocalName = "Nouaceur"
            },
            new()
            { 
                Code = "OUA",
                Type = SubdivisionTypes.Province,
                Name = "Ouarzazate",
                LocalName = "Ouarzazate"
            },
            new()
            { 
                Code = "OUD",
                Type = SubdivisionTypes.Province,
                Name = "Oued ed Dahab",
                LocalName = "Oued ed Dahab"
            },
            new()
            { 
                Code = "OUJ",
                Type = SubdivisionTypes.Prefecture,
                Name = "Oujda-Angad",
                LocalName = "Oujda-Angad"
            },
            new()
            { 
                Code = "RAB",
                Type = SubdivisionTypes.Prefecture,
                Name = "Rabat",
                LocalName = "Rabat"
            },
            new()
            { 
                Code = "SAF",
                Type = SubdivisionTypes.Province,
                Name = "Safi",
                LocalName = "Safi"
            },
            new()
            { 
                Code = "SAL",
                Type = SubdivisionTypes.Prefecture,
                Name = "Salé",
                LocalName = "Salé"
            },
            new()
            { 
                Code = "SEF",
                Type = SubdivisionTypes.Province,
                Name = "Sefrou",
                LocalName = "Sefrou"
            },
            new()
            { 
                Code = "SET",
                Type = SubdivisionTypes.Province,
                Name = "Settat",
                LocalName = "Settat"
            },
            new()
            { 
                Code = "SIK",
                Type = SubdivisionTypes.Province,
                Name = "Sidi Kacem",
                LocalName = "Sidi Kacem"
            },
            new()
            { 
                Code = "SYB",
                Type = SubdivisionTypes.Prefecture,
                Name = "Sidi Youssef Ben Ali",
                LocalName = "Sidi Youssef Ben Ali"
            },
            new()
            { 
                Code = "SKH",
                Type = SubdivisionTypes.Prefecture,
                Name = "Skhirate-Témara",
                LocalName = "Skhirate-Témara"
            },
            new()
            { 
                Code = "TNG",
                Type = SubdivisionTypes.Prefecture,
                Name = "Tanger-Assilah",
                LocalName = "Tanger-Assilah"
            },
            new()
            { 
                Code = "TNT",
                Type = SubdivisionTypes.Province,
                Name = "Tan-Tan",
                LocalName = "Tan-Tan"
            },
            new()
            { 
                Code = "TAO",
                Type = SubdivisionTypes.Province,
                Name = "Taounate",
                LocalName = "Taounate"
            },
            new()
            { 
                Code = "TAI",
                Type = SubdivisionTypes.Province,
                Name = "Taourirt",
                LocalName = "Taourirt"
            },
            new()
            { 
                Code = "TAR",
                Type = SubdivisionTypes.Province,
                Name = "Taroudannt",
                LocalName = "Taroudannt"
            },
            new()
            { 
                Code = "TAT",
                Type = SubdivisionTypes.Province,
                Name = "Tata",
                LocalName = "Tata"
            },
            new()
            { 
                Code = "TAZ",
                Type = SubdivisionTypes.Province,
                Name = "Taza",
                LocalName = "Taza"
            },
            new()
            { 
                Code = "TET",
                Type = SubdivisionTypes.Prefecture,
                Name = "Tétouan*",
                LocalName = "Tétouan*"
            },
            new()
            { 
                Code = "TIZ",
                Type = SubdivisionTypes.Province,
                Name = "Tiznit",
                LocalName = "Tiznit"
            },
            new()
            { 
                Code = "ZAG",
                Type = SubdivisionTypes.Province,
                Name = "Zagora",
                LocalName = "Zagora"
            }

        ]);
    }
}
