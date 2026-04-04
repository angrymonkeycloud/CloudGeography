using AngryMonkey.Cloud.Geography;
namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    private static void FillInSubdivisionsAO()
    {
        AddSubdivisions("AO",
        [
            new()
            { 
                Code = "BGO",
                Type = SubdivisionTypes.Province,
                Name = "Bengo",
                LocalName = "Bengo"
            },
            new()
            { 
                Code = "BGU",
                Type = SubdivisionTypes.Province,
                Name = "Benguela",
                LocalName = "Benguela"
            },
            new()
            { 
                Code = "BIE",
                Type = SubdivisionTypes.Province,
                Name = "Bié",
                LocalName = "Bié"
            },
            new()
            { 
                Code = "CAB",
                Type = SubdivisionTypes.Province,
                Name = "Cabinda",
                LocalName = "Cabinda"
            },
            new()
            { 
                Code = "CNN",
                Type = SubdivisionTypes.Province,
                Name = "Cunene",
                LocalName = "Cunene"
            },
            new()
            { 
                Code = "HUA",
                Type = SubdivisionTypes.Province,
                Name = "Huambo",
                LocalName = "Huambo"
            },
            new()
            { 
                Code = "HUI",
                Type = SubdivisionTypes.Province,
                Name = "Huíla",
                LocalName = "Huíla"
            },
            new()
            { 
                Code = "CCU",
                Type = SubdivisionTypes.Province,
                Name = "Kuando Kubango",
                LocalName = "Kuando Kubango"
            },
            new()
            { 
                Code = "CNO",
                Type = SubdivisionTypes.Province,
                Name = "Kwanza Norte",
                LocalName = "Kwanza Norte"
            },
            new()
            { 
                Code = "CUS",
                Type = SubdivisionTypes.Province,
                Name = "Kwanza Sul",
                LocalName = "Kwanza Sul"
            },
            new()
            { 
                Code = "LUA",
                Type = SubdivisionTypes.Province,
                Name = "Luanda",
                LocalName = "Luanda"
            },
            new()
            { 
                Code = "LNO",
                Type = SubdivisionTypes.Province,
                Name = "Lunda Norte",
                LocalName = "Lunda Norte"
            },
            new()
            { 
                Code = "LSU",
                Type = SubdivisionTypes.Province,
                Name = "Lunda Sul",
                LocalName = "Lunda Sul"
            },
            new()
            { 
                Code = "MAL",
                Type = SubdivisionTypes.Province,
                Name = "Malange",
                LocalName = "Malange"
            },
            new()
            { 
                Code = "MOX",
                Type = SubdivisionTypes.Province,
                Name = "Moxico",
                LocalName = "Moxico"
            },
            new()
            { 
                Code = "NAM",
                Type = SubdivisionTypes.Province,
                Name = "Namibe",
                LocalName = "Namibe"
            },
            new()
            { 
                Code = "UIG",
                Type = SubdivisionTypes.Province,
                Name = "Uíge",
                LocalName = "Uíge"
            },
            new()
            { 
                Code = "ZAI",
                Type = SubdivisionTypes.Province,
                Name = "Zaire",
                LocalName = "Zaire"
            }

        ]);
    }
}
