using AngryMonkey.Cloud.Geography;
namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    private static void FillInSubdivisionsAO()
    {
        AddSubdivisions("AO", new List<Subdivision>()
        {
            new()
            { 
                Code = "BGO",
                Type = "Province",
                Name = "Bengo",
                LocalName = "Bengo"
            },
            new()
            { 
                Code = "BGU",
                Type = "Province",
                Name = "Benguela",
                LocalName = "Benguela"
            },
            new()
            { 
                Code = "BIE",
                Type = "Province",
                Name = "Bié",
                LocalName = "Bié"
            },
            new()
            { 
                Code = "CAB",
                Type = "Province",
                Name = "Cabinda",
                LocalName = "Cabinda"
            },
            new()
            { 
                Code = "CNN",
                Type = "Province",
                Name = "Cunene",
                LocalName = "Cunene"
            },
            new()
            { 
                Code = "HUA",
                Type = "Province",
                Name = "Huambo",
                LocalName = "Huambo"
            },
            new()
            { 
                Code = "HUI",
                Type = "Province",
                Name = "Huíla",
                LocalName = "Huíla"
            },
            new()
            { 
                Code = "CCU",
                Type = "Province",
                Name = "Kuando Kubango",
                LocalName = "Kuando Kubango"
            },
            new()
            { 
                Code = "CNO",
                Type = "Province",
                Name = "Kwanza Norte",
                LocalName = "Kwanza Norte"
            },
            new()
            { 
                Code = "CUS",
                Type = "Province",
                Name = "Kwanza Sul",
                LocalName = "Kwanza Sul"
            },
            new()
            { 
                Code = "LUA",
                Type = "Province",
                Name = "Luanda",
                LocalName = "Luanda"
            },
            new()
            { 
                Code = "LNO",
                Type = "Province",
                Name = "Lunda Norte",
                LocalName = "Lunda Norte"
            },
            new()
            { 
                Code = "LSU",
                Type = "Province",
                Name = "Lunda Sul",
                LocalName = "Lunda Sul"
            },
            new()
            { 
                Code = "MAL",
                Type = "Province",
                Name = "Malange",
                LocalName = "Malange"
            },
            new()
            { 
                Code = "MOX",
                Type = "Province",
                Name = "Moxico",
                LocalName = "Moxico"
            },
            new()
            { 
                Code = "NAM",
                Type = "Province",
                Name = "Namibe",
                LocalName = "Namibe"
            },
            new()
            { 
                Code = "UIG",
                Type = "Province",
                Name = "Uíge",
                LocalName = "Uíge"
            },
            new()
            { 
                Code = "ZAI",
                Type = "Province",
                Name = "Zaire",
                LocalName = "Zaire"
            }

        });
    }
}
