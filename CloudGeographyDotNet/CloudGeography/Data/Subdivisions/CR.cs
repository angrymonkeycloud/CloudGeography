using AngryMonkey.Cloud.Geography;
namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    private static void FillInSubdivisionsCR()
    {
        AddSubdivisions("CR",
        [
            new()
            { 
                Code = "A",
                Type = SubdivisionTypes.Province,
                Name = "Alajuela",
                LocalName = "Alajuela"
            },
            new()
            { 
                Code = "C",
                Type = SubdivisionTypes.Province,
                Name = "Cartago",
                LocalName = "Cartago"
            },
            new()
            { 
                Code = "G",
                Type = SubdivisionTypes.Province,
                Name = "Guanacaste",
                LocalName = "Guanacaste"
            },
            new()
            { 
                Code = "H",
                Type = SubdivisionTypes.Province,
                Name = "Heredia",
                LocalName = "Heredia"
            },
            new()
            { 
                Code = "L",
                Type = SubdivisionTypes.Province,
                Name = "Limón",
                LocalName = "Limón"
            },
            new()
            { 
                Code = "P",
                Type = SubdivisionTypes.Province,
                Name = "Puntarenas",
                LocalName = "Puntarenas"
            },
            new()
            { 
                Code = "SJ",
                Type = SubdivisionTypes.Province,
                Name = "San José",
                LocalName = "San José"
            }

        ]);
    }
}
