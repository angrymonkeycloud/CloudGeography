using AngryMonkey.Cloud.Geography;
namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    private static void FillInSubdivisionsBF()
    {
        AddSubdivisions("BF",
        [
            new()
            { 
                Code = "BAL",
                Type = SubdivisionTypes.Province,
                Name = "Balé",
                LocalName = "Balé"
            },
            new()
            { 
                Code = "BAM",
                Type = SubdivisionTypes.Province,
                Name = "Bam",
                LocalName = "Bam"
            },
            new()
            { 
                Code = "BAN",
                Type = SubdivisionTypes.Province,
                Name = "Banwa",
                LocalName = "Banwa"
            },
            new()
            { 
                Code = "BAZ",
                Type = SubdivisionTypes.Province,
                Name = "Bazèga",
                LocalName = "Bazèga"
            },
            new()
            { 
                Code = "BGR",
                Type = SubdivisionTypes.Province,
                Name = "Bougouriba",
                LocalName = "Bougouriba"
            },
            new()
            { 
                Code = "BLG",
                Type = SubdivisionTypes.Province,
                Name = "Boulgou",
                LocalName = "Boulgou"
            },
            new()
            { 
                Code = "BLK",
                Type = SubdivisionTypes.Province,
                Name = "Boulkiemdé",
                LocalName = "Boulkiemdé"
            },
            new()
            { 
                Code = "COM",
                Type = SubdivisionTypes.Province,
                Name = "Comoé",
                LocalName = "Comoé"
            },
            new()
            { 
                Code = "GAN",
                Type = SubdivisionTypes.Province,
                Name = "Ganzourgou",
                LocalName = "Ganzourgou"
            },
            new()
            { 
                Code = "GNA",
                Type = SubdivisionTypes.Province,
                Name = "Gnagna",
                LocalName = "Gnagna"
            },
            new()
            { 
                Code = "GOU",
                Type = SubdivisionTypes.Province,
                Name = "Gourma",
                LocalName = "Gourma"
            },
            new()
            { 
                Code = "HOU",
                Type = SubdivisionTypes.Province,
                Name = "Houet",
                LocalName = "Houet"
            },
            new()
            { 
                Code = "IOB",
                Type = SubdivisionTypes.Province,
                Name = "Ioba",
                LocalName = "Ioba"
            },
            new()
            { 
                Code = "KAD",
                Type = SubdivisionTypes.Province,
                Name = "Kadiogo",
                LocalName = "Kadiogo"
            },
            new()
            { 
                Code = "KEN",
                Type = SubdivisionTypes.Province,
                Name = "Kénédougou",
                LocalName = "Kénédougou"
            },
            new()
            { 
                Code = "KMD",
                Type = SubdivisionTypes.Province,
                Name = "Komondjari",
                LocalName = "Komondjari"
            },
            new()
            { 
                Code = "KMP",
                Type = SubdivisionTypes.Province,
                Name = "Kompienga",
                LocalName = "Kompienga"
            },
            new()
            { 
                Code = "KOS",
                Type = SubdivisionTypes.Province,
                Name = "Kossi",
                LocalName = "Kossi"
            },
            new()
            { 
                Code = "KOP",
                Type = SubdivisionTypes.Province,
                Name = "Koulpélogo",
                LocalName = "Koulpélogo"
            },
            new()
            { 
                Code = "KOT",
                Type = SubdivisionTypes.Province,
                Name = "Kouritenga",
                LocalName = "Kouritenga"
            },
            new()
            { 
                Code = "KOW",
                Type = SubdivisionTypes.Province,
                Name = "Kourwéogo",
                LocalName = "Kourwéogo"
            },
            new()
            { 
                Code = "LER",
                Type = SubdivisionTypes.Province,
                Name = "Léraba",
                LocalName = "Léraba"
            },
            new()
            { 
                Code = "LOR",
                Type = SubdivisionTypes.Province,
                Name = "Loroum",
                LocalName = "Loroum"
            },
            new()
            { 
                Code = "MOU",
                Type = SubdivisionTypes.Province,
                Name = "Mouhoun",
                LocalName = "Mouhoun"
            },
            new()
            { 
                Code = "NAO",
                Type = SubdivisionTypes.Province,
                Name = "Nahouri",
                LocalName = "Nahouri"
            },
            new()
            { 
                Code = "NAM",
                Type = SubdivisionTypes.Province,
                Name = "Namentenga",
                LocalName = "Namentenga"
            },
            new()
            { 
                Code = "NAY",
                Type = SubdivisionTypes.Province,
                Name = "Nayala",
                LocalName = "Nayala"
            },
            new()
            { 
                Code = "NOU",
                Type = SubdivisionTypes.Province,
                Name = "Noumbiel",
                LocalName = "Noumbiel"
            },
            new()
            { 
                Code = "OUB",
                Type = SubdivisionTypes.Province,
                Name = "Oubritenga",
                LocalName = "Oubritenga"
            },
            new()
            { 
                Code = "OUD",
                Type = SubdivisionTypes.Province,
                Name = "Oudalan",
                LocalName = "Oudalan"
            },
            new()
            { 
                Code = "PAS",
                Type = SubdivisionTypes.Province,
                Name = "Passoré",
                LocalName = "Passoré"
            },
            new()
            { 
                Code = "PON",
                Type = SubdivisionTypes.Province,
                Name = "Poni",
                LocalName = "Poni"
            },
            new()
            { 
                Code = "SNG",
                Type = SubdivisionTypes.Province,
                Name = "Sanguié",
                LocalName = "Sanguié"
            },
            new()
            { 
                Code = "SMT",
                Type = SubdivisionTypes.Province,
                Name = "Sanmatenga",
                LocalName = "Sanmatenga"
            },
            new()
            { 
                Code = "SEN",
                Type = SubdivisionTypes.Province,
                Name = "Séno",
                LocalName = "Séno"
            },
            new()
            { 
                Code = "SIS",
                Type = SubdivisionTypes.Province,
                Name = "Sissili",
                LocalName = "Sissili"
            },
            new()
            { 
                Code = "SOM",
                Type = SubdivisionTypes.Province,
                Name = "Soum",
                LocalName = "Soum"
            },
            new()
            { 
                Code = "SOR",
                Type = SubdivisionTypes.Province,
                Name = "Sourou",
                LocalName = "Sourou"
            },
            new()
            { 
                Code = "TAP",
                Type = SubdivisionTypes.Province,
                Name = "Tapoa",
                LocalName = "Tapoa"
            },
            new()
            { 
                Code = "TUI",
                Type = SubdivisionTypes.Province,
                Name = "Tuy",
                LocalName = "Tuy"
            },
            new()
            { 
                Code = "YAG",
                Type = SubdivisionTypes.Province,
                Name = "Yagha",
                LocalName = "Yagha"
            },
            new()
            { 
                Code = "YAT",
                Type = SubdivisionTypes.Province,
                Name = "Yatenga",
                LocalName = "Yatenga"
            },
            new()
            { 
                Code = "ZIR",
                Type = SubdivisionTypes.Province,
                Name = "Ziro",
                LocalName = "Ziro"
            },
            new()
            { 
                Code = "ZON",
                Type = SubdivisionTypes.Province,
                Name = "Zondoma",
                LocalName = "Zondoma"
            },
            new()
            { 
                Code = "ZOU",
                Type = SubdivisionTypes.Province,
                Name = "Zoundwéogo",
                LocalName = "Zoundwéogo"
            }

        ]);
    }
}
