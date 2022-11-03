using AngryMonkey.Cloud.Geography;
namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    private static void FillInSubdivisionsLA()
    {
        AddSubdivisions("LA", new List<Subdivision>()
        {
            new()
            { 
                Code = "AT",
                Type = "Province",
                Name = "Attapu",
                LocalName = "Attapu"
            },
            new()
            { 
                Code = "BK",
                Type = "Province",
                Name = "Bokèo",
                LocalName = "Bokèo"
            },
            new()
            { 
                Code = "BL",
                Type = "Province",
                Name = "Bolikhamxai",
                LocalName = "Bolikhamxai"
            },
            new()
            { 
                Code = "CH",
                Type = "Province",
                Name = "Champasak",
                LocalName = "Champasak"
            },
            new()
            { 
                Code = "HO",
                Type = "Province",
                Name = "Houaphan",
                LocalName = "Houaphan"
            },
            new()
            { 
                Code = "KH",
                Type = "Province",
                Name = "Khammouan",
                LocalName = "Khammouan"
            },
            new()
            { 
                Code = "LM",
                Type = "Province",
                Name = "Louang Namtha",
                LocalName = "Louang Namtha"
            },
            new()
            { 
                Code = "LP",
                Type = "Province",
                Name = "Louangphabang",
                LocalName = "Louangphabang"
            },
            new()
            { 
                Code = "OU",
                Type = "Province",
                Name = "Oudômxai",
                LocalName = "Oudômxai"
            },
            new()
            { 
                Code = "PH",
                Type = "Province",
                Name = "Phôngsali",
                LocalName = "Phôngsali"
            },
            new()
            { 
                Code = "SL",
                Type = "Province",
                Name = "Salavan",
                LocalName = "Salavan"
            },
            new()
            { 
                Code = "SV",
                Type = "Province",
                Name = "Savannakhét",
                LocalName = "Savannakhét"
            },
            new()
            { 
                Code = "VI",
                Type = "Province",
                Name = "Vientiane",
                LocalName = "Vientiane"
            },
            new()
            { 
                Code = "VT",
                Type = "Prefecture",
                Name = "Vientiane",
                LocalName = "Vientiane"
            },
            new()
            { 
                Code = "XA",
                Type = "Province",
                Name = "Xaignabouli",
                LocalName = "Xaignabouli"
            },
            new()
            { 
                Code = "XS",
                Type = "Province",
                Name = "Xaisômboun",
                LocalName = "Xaisômboun"
            },
            new()
            { 
                Code = "XE",
                Type = "Province",
                Name = "Xékong",
                LocalName = "Xékong"
            },
            new()
            { 
                Code = "XI",
                Type = "Province",
                Name = "Xiangkhouang",
                LocalName = "Xiangkhouang"
            }

        });
    }
}
