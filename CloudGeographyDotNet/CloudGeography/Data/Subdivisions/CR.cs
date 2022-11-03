using AngryMonkey.Cloud.Geography;
namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    private static void FillInSubdivisionsCR()
    {
        AddSubdivisions("CR", new List<Subdivision>()
        {
            new()
            { 
                Code = "A",
                Type = "Province",
                Name = "Alajuela",
                LocalName = "Alajuela"
            },
            new()
            { 
                Code = "C",
                Type = "Province",
                Name = "Cartago",
                LocalName = "Cartago"
            },
            new()
            { 
                Code = "G",
                Type = "Province",
                Name = "Guanacaste",
                LocalName = "Guanacaste"
            },
            new()
            { 
                Code = "H",
                Type = "Province",
                Name = "Heredia",
                LocalName = "Heredia"
            },
            new()
            { 
                Code = "L",
                Type = "Province",
                Name = "Limón",
                LocalName = "Limón"
            },
            new()
            { 
                Code = "P",
                Type = "Province",
                Name = "Puntarenas",
                LocalName = "Puntarenas"
            },
            new()
            { 
                Code = "SJ",
                Type = "Province",
                Name = "San José",
                LocalName = "San José"
            }

        });
    }
}
