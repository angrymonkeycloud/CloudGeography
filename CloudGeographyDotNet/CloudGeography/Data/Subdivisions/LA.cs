using AngryMonkey.Cloud.Geography;
namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    private static void FillInSubdivisionsLA()
    {
        AddSubdivisions("LA",
        [
            new()
            { 
                Code = "AT",
                Type = SubdivisionTypes.Province,
                Name = "Attapu",
                LocalName = "Attapu"
            },
            new()
            { 
                Code = "BK",
                Type = SubdivisionTypes.Province,
                Name = "Bokèo",
                LocalName = "Bokèo"
            },
            new()
            { 
                Code = "BL",
                Type = SubdivisionTypes.Province,
                Name = "Bolikhamxai",
                LocalName = "Bolikhamxai"
            },
            new()
            { 
                Code = "CH",
                Type = SubdivisionTypes.Province,
                Name = "Champasak",
                LocalName = "Champasak"
            },
            new()
            { 
                Code = "HO",
                Type = SubdivisionTypes.Province,
                Name = "Houaphan",
                LocalName = "Houaphan"
            },
            new()
            { 
                Code = "KH",
                Type = SubdivisionTypes.Province,
                Name = "Khammouan",
                LocalName = "Khammouan"
            },
            new()
            { 
                Code = "LM",
                Type = SubdivisionTypes.Province,
                Name = "Louang Namtha",
                LocalName = "Louang Namtha"
            },
            new()
            { 
                Code = "LP",
                Type = SubdivisionTypes.Province,
                Name = "Louangphabang",
                LocalName = "Louangphabang"
            },
            new()
            { 
                Code = "OU",
                Type = SubdivisionTypes.Province,
                Name = "Oudômxai",
                LocalName = "Oudômxai"
            },
            new()
            { 
                Code = "PH",
                Type = SubdivisionTypes.Province,
                Name = "Phôngsali",
                LocalName = "Phôngsali"
            },
            new()
            { 
                Code = "SL",
                Type = SubdivisionTypes.Province,
                Name = "Salavan",
                LocalName = "Salavan"
            },
            new()
            { 
                Code = "SV",
                Type = SubdivisionTypes.Province,
                Name = "Savannakhét",
                LocalName = "Savannakhét"
            },
            new()
            { 
                Code = "VI",
                Type = SubdivisionTypes.Province,
                Name = "Vientiane",
                LocalName = "Vientiane"
            },
            new()
            { 
                Code = "VT",
                Type = SubdivisionTypes.Prefecture,
                Name = "Vientiane",
                LocalName = "Vientiane"
            },
            new()
            { 
                Code = "XA",
                Type = SubdivisionTypes.Province,
                Name = "Xaignabouli",
                LocalName = "Xaignabouli"
            },
            new()
            { 
                Code = "XS",
                Type = SubdivisionTypes.Province,
                Name = "Xaisômboun",
                LocalName = "Xaisômboun"
            },
            new()
            { 
                Code = "XE",
                Type = SubdivisionTypes.Province,
                Name = "Xékong",
                LocalName = "Xékong"
            },
            new()
            { 
                Code = "XI",
                Type = SubdivisionTypes.Province,
                Name = "Xiangkhouang",
                LocalName = "Xiangkhouang"
            }

        ]);
    }
}
