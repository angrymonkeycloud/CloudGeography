using AngryMonkey.Cloud.Geography;
namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    private static void FillInSubdivisionsMH()
    {
        AddSubdivisions("MH",
        [
            new()
            { 
                Code = "ALL",
                Type = SubdivisionTypes.Municipality,
                Name = "Ailinglapalap",
                LocalName = "Ailinglapalap"
            },
            new()
            { 
                Code = "ALK",
                Type = SubdivisionTypes.Municipality,
                Name = "Ailuk",
                LocalName = "Ailuk"
            },
            new()
            { 
                Code = "ARN",
                Type = SubdivisionTypes.Municipality,
                Name = "Arno",
                LocalName = "Arno"
            },
            new()
            { 
                Code = "AUR",
                Type = SubdivisionTypes.Municipality,
                Name = "Aur",
                LocalName = "Aur"
            },
            new()
            { 
                Code = "KIL",
                Type = SubdivisionTypes.Municipality,
                Name = "Bikini and Kili",
                LocalName = "Bikini and Kili"
            },
            new()
            { 
                Code = "EBO",
                Type = SubdivisionTypes.Municipality,
                Name = "Ebon",
                LocalName = "Ebon"
            },
            new()
            { 
                Code = "ENI",
                Type = SubdivisionTypes.Municipality,
                Name = "Enewetak and Ujelang",
                LocalName = "Enewetak and Ujelang"
            },
            new()
            { 
                Code = "JAB",
                Type = SubdivisionTypes.Municipality,
                Name = "Jabat",
                LocalName = "Jabat"
            },
            new()
            { 
                Code = "JAL",
                Type = SubdivisionTypes.Municipality,
                Name = "Jaluit",
                LocalName = "Jaluit"
            },
            new()
            { 
                Code = "KWA",
                Type = SubdivisionTypes.Municipality,
                Name = "Kwajalein",
                LocalName = "Kwajalein"
            },
            new()
            { 
                Code = "LAE",
                Type = SubdivisionTypes.Municipality,
                Name = "Lae",
                LocalName = "Lae"
            },
            new()
            { 
                Code = "LIB",
                Type = SubdivisionTypes.Municipality,
                Name = "Lib",
                LocalName = "Lib"
            },
            new()
            { 
                Code = "LIK",
                Type = SubdivisionTypes.Municipality,
                Name = "Likiep",
                LocalName = "Likiep"
            },
            new()
            { 
                Code = "MAJ",
                Type = SubdivisionTypes.Municipality,
                Name = "Majuro",
                LocalName = "Majuro"
            },
            new()
            { 
                Code = "MAL",
                Type = SubdivisionTypes.Municipality,
                Name = "Maloelap",
                LocalName = "Maloelap"
            },
            new()
            { 
                Code = "MEJ",
                Type = SubdivisionTypes.Municipality,
                Name = "Mejit",
                LocalName = "Mejit"
            },
            new()
            { 
                Code = "MIL",
                Type = SubdivisionTypes.Municipality,
                Name = "Mili",
                LocalName = "Mili"
            },
            new()
            { 
                Code = "NMK",
                Type = SubdivisionTypes.Municipality,
                Name = "Namdrik",
                LocalName = "Namdrik"
            },
            new()
            { 
                Code = "NMU",
                Type = SubdivisionTypes.Municipality,
                Name = "Namu",
                LocalName = "Namu"
            },
            new()
            { 
                Code = "L",
                Type = SubdivisionTypes.District,
                Name = "Ralik chain",
                LocalName = "Ralik chain"
            },
            new()
            { 
                Code = "T",
                Type = SubdivisionTypes.District,
                Name = "Ratak chain",
                LocalName = "Ratak chain"
            },
            new()
            { 
                Code = "RON",
                Type = SubdivisionTypes.Municipality,
                Name = "Rongelap",
                LocalName = "Rongelap"
            },
            new()
            { 
                Code = "UJA",
                Type = SubdivisionTypes.Municipality,
                Name = "Ujae",
                LocalName = "Ujae"
            },
            new()
            { 
                Code = "UTI",
                Type = SubdivisionTypes.Municipality,
                Name = "Utrik",
                LocalName = "Utrik"
            },
            new()
            { 
                Code = "WTH",
                Type = SubdivisionTypes.Municipality,
                Name = "Wotho",
                LocalName = "Wotho"
            },
            new()
            { 
                Code = "WTJ",
                Type = SubdivisionTypes.Municipality,
                Name = "Wotje",
                LocalName = "Wotje"
            }

        ]);
    }
}
