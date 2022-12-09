using AngryMonkey.Cloud.Geography;
namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    private static void FillInSubdivisionsBF()
    {
        AddSubdivisions("BF", new List<Subdivision>()
        {
            new()
            { 
                Code = "BAL",
                Type = "Province",
                Name = "Balé",
                LocalName = "Balé"
            },
            new()
            { 
                Code = "BAM",
                Type = "Province",
                Name = "Bam",
                LocalName = "Bam"
            },
            new()
            { 
                Code = "BAN",
                Type = "Province",
                Name = "Banwa",
                LocalName = "Banwa"
            },
            new()
            { 
                Code = "BAZ",
                Type = "Province",
                Name = "Bazèga",
                LocalName = "Bazèga"
            },
            new()
            { 
                Code = "BGR",
                Type = "Province",
                Name = "Bougouriba",
                LocalName = "Bougouriba"
            },
            new()
            { 
                Code = "BLG",
                Type = "Province",
                Name = "Boulgou",
                LocalName = "Boulgou"
            },
            new()
            { 
                Code = "BLK",
                Type = "Province",
                Name = "Boulkiemdé",
                LocalName = "Boulkiemdé"
            },
            new()
            { 
                Code = "COM",
                Type = "Province",
                Name = "Comoé",
                LocalName = "Comoé"
            },
            new()
            { 
                Code = "GAN",
                Type = "Province",
                Name = "Ganzourgou",
                LocalName = "Ganzourgou"
            },
            new()
            { 
                Code = "GNA",
                Type = "Province",
                Name = "Gnagna",
                LocalName = "Gnagna"
            },
            new()
            { 
                Code = "GOU",
                Type = "Province",
                Name = "Gourma",
                LocalName = "Gourma"
            },
            new()
            { 
                Code = "HOU",
                Type = "Province",
                Name = "Houet",
                LocalName = "Houet"
            },
            new()
            { 
                Code = "IOB",
                Type = "Province",
                Name = "Ioba",
                LocalName = "Ioba"
            },
            new()
            { 
                Code = "KAD",
                Type = "Province",
                Name = "Kadiogo",
                LocalName = "Kadiogo"
            },
            new()
            { 
                Code = "KEN",
                Type = "Province",
                Name = "Kénédougou",
                LocalName = "Kénédougou"
            },
            new()
            { 
                Code = "KMD",
                Type = "Province",
                Name = "Komondjari",
                LocalName = "Komondjari"
            },
            new()
            { 
                Code = "KMP",
                Type = "Province",
                Name = "Kompienga",
                LocalName = "Kompienga"
            },
            new()
            { 
                Code = "KOS",
                Type = "Province",
                Name = "Kossi",
                LocalName = "Kossi"
            },
            new()
            { 
                Code = "KOP",
                Type = "Province",
                Name = "Koulpélogo",
                LocalName = "Koulpélogo"
            },
            new()
            { 
                Code = "KOT",
                Type = "Province",
                Name = "Kouritenga",
                LocalName = "Kouritenga"
            },
            new()
            { 
                Code = "KOW",
                Type = "Province",
                Name = "Kourwéogo",
                LocalName = "Kourwéogo"
            },
            new()
            { 
                Code = "LER",
                Type = "Province",
                Name = "Léraba",
                LocalName = "Léraba"
            },
            new()
            { 
                Code = "LOR",
                Type = "Province",
                Name = "Loroum",
                LocalName = "Loroum"
            },
            new()
            { 
                Code = "MOU",
                Type = "Province",
                Name = "Mouhoun",
                LocalName = "Mouhoun"
            },
            new()
            { 
                Code = "NAO",
                Type = "Province",
                Name = "Nahouri",
                LocalName = "Nahouri"
            },
            new()
            { 
                Code = "NAM",
                Type = "Province",
                Name = "Namentenga",
                LocalName = "Namentenga"
            },
            new()
            { 
                Code = "NAY",
                Type = "Province",
                Name = "Nayala",
                LocalName = "Nayala"
            },
            new()
            { 
                Code = "NOU",
                Type = "Province",
                Name = "Noumbiel",
                LocalName = "Noumbiel"
            },
            new()
            { 
                Code = "OUB",
                Type = "Province",
                Name = "Oubritenga",
                LocalName = "Oubritenga"
            },
            new()
            { 
                Code = "OUD",
                Type = "Province",
                Name = "Oudalan",
                LocalName = "Oudalan"
            },
            new()
            { 
                Code = "PAS",
                Type = "Province",
                Name = "Passoré",
                LocalName = "Passoré"
            },
            new()
            { 
                Code = "PON",
                Type = "Province",
                Name = "Poni",
                LocalName = "Poni"
            },
            new()
            { 
                Code = "SNG",
                Type = "Province",
                Name = "Sanguié",
                LocalName = "Sanguié"
            },
            new()
            { 
                Code = "SMT",
                Type = "Province",
                Name = "Sanmatenga",
                LocalName = "Sanmatenga"
            },
            new()
            { 
                Code = "SEN",
                Type = "Province",
                Name = "Séno",
                LocalName = "Séno"
            },
            new()
            { 
                Code = "SIS",
                Type = "Province",
                Name = "Sissili",
                LocalName = "Sissili"
            },
            new()
            { 
                Code = "SOM",
                Type = "Province",
                Name = "Soum",
                LocalName = "Soum"
            },
            new()
            { 
                Code = "SOR",
                Type = "Province",
                Name = "Sourou",
                LocalName = "Sourou"
            },
            new()
            { 
                Code = "TAP",
                Type = "Province",
                Name = "Tapoa",
                LocalName = "Tapoa"
            },
            new()
            { 
                Code = "TUI",
                Type = "Province",
                Name = "Tuy",
                LocalName = "Tuy"
            },
            new()
            { 
                Code = "YAG",
                Type = "Province",
                Name = "Yagha",
                LocalName = "Yagha"
            },
            new()
            { 
                Code = "YAT",
                Type = "Province",
                Name = "Yatenga",
                LocalName = "Yatenga"
            },
            new()
            { 
                Code = "ZIR",
                Type = "Province",
                Name = "Ziro",
                LocalName = "Ziro"
            },
            new()
            { 
                Code = "ZON",
                Type = "Province",
                Name = "Zondoma",
                LocalName = "Zondoma"
            },
            new()
            { 
                Code = "ZOU",
                Type = "Province",
                Name = "Zoundwéogo",
                LocalName = "Zoundwéogo"
            }

        });
    }
}
