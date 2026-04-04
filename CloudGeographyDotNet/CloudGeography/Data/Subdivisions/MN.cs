using AngryMonkey.Cloud.Geography;
namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    private static void FillInSubdivisionsMN()
    {
        AddSubdivisions("MN",
        [
            new()
            { 
                Code = "73",
                Type = SubdivisionTypes.Province,
                Name = "Arhangay",
                LocalName = "Arhangay"
            },
            new()
            { 
                Code = "69",
                Type = SubdivisionTypes.Province,
                Name = "Bayanhongor",
                LocalName = "Bayanhongor"
            },
            new()
            { 
                Code = "71",
                Type = SubdivisionTypes.Province,
                Name = "Bayan-Ölgiy",
                LocalName = "Bayan-Ölgiy"
            },
            new()
            { 
                Code = "67",
                Type = SubdivisionTypes.Province,
                Name = "Bulgan",
                LocalName = "Bulgan"
            },
            new()
            { 
                Code = "37",
                Type = SubdivisionTypes.Province,
                Name = "Darhan uul",
                LocalName = "Darhan uul"
            },
            new()
            { 
                Code = "61",
                Type = SubdivisionTypes.Province,
                Name = "Dornod",
                LocalName = "Dornod"
            },
            new()
            { 
                Code = "63",
                Type = SubdivisionTypes.Province,
                Name = "Dornogovi",
                LocalName = "Dornogovi"
            },
            new()
            { 
                Code = "59",
                Type = SubdivisionTypes.Province,
                Name = "Dundgovi",
                LocalName = "Dundgovi"
            },
            new()
            { 
                Code = "57",
                Type = SubdivisionTypes.Province,
                Name = "Dzavhan",
                LocalName = "Dzavhan"
            },
            new()
            { 
                Code = "65",
                Type = SubdivisionTypes.Province,
                Name = "Govi-Altay",
                LocalName = "Govi-Altay"
            },
            new()
            { 
                Code = "64",
                Type = SubdivisionTypes.Province,
                Name = "Govi-Sümber",
                LocalName = "Govi-Sümber"
            },
            new()
            { 
                Code = "39",
                Type = SubdivisionTypes.Province,
                Name = "Hentiy",
                LocalName = "Hentiy"
            },
            new()
            { 
                Code = "41",
                Type = SubdivisionTypes.Province,
                Name = "Hövagöl",
                LocalName = "Hövagöl"
            },
            new()
            { 
                Code = "43",
                Type = SubdivisionTypes.Province,
                Name = "Hovd",
                LocalName = "Hovd"
            },
            new()
            { 
                Code = "53",
                Type = SubdivisionTypes.Province,
                Name = "Ömnögovi",
                LocalName = "Ömnögovi"
            },
            new()
            { 
                Code = "35",
                Type = SubdivisionTypes.Province,
                Name = "Orhon",
                LocalName = "Orhon"
            },
            new()
            { 
                Code = "55",
                Type = SubdivisionTypes.Province,
                Name = "Övörhangay",
                LocalName = "Övörhangay"
            },
            new()
            { 
                Code = "49",
                Type = SubdivisionTypes.Province,
                Name = "Selenge",
                LocalName = "Selenge"
            },
            new()
            { 
                Code = "51",
                Type = SubdivisionTypes.Province,
                Name = "Sühbaatar",
                LocalName = "Sühbaatar"
            },
            new()
            { 
                Code = "47",
                Type = SubdivisionTypes.Province,
                Name = "Töv",
                LocalName = "Töv"
            },
            new()
            { 
                Code = "1",
                Type = SubdivisionTypes.CapitalCity,
                Name = "Ulaanbaatar",
                LocalName = "Ulaanbaatar"
            },
            new()
            { 
                Code = "46",
                Type = SubdivisionTypes.Province,
                Name = "Uvs",
                LocalName = "Uvs"
            }

        ]);
    }
}
