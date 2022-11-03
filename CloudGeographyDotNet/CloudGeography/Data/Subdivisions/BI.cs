using AngryMonkey.Cloud.Geography;
namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    private static void FillInSubdivisionsBI()
    {
        AddSubdivisions("BI", new List<Subdivision>()
        {
            new()
            { 
                Code = "BB",
                Type = "Province",
                Name = "Bubanza",
                LocalName = "Bubanza"
            },
            new()
            { 
                Code = "BM",
                Type = "Province",
                Name = "Bujumbura Mairie",
                LocalName = "Bujumbura Mairie"
            },
            new()
            { 
                Code = "BL",
                Type = "Province",
                Name = "Bujumbura Rural",
                LocalName = "Bujumbura Rural"
            },
            new()
            { 
                Code = "BR",
                Type = "Province",
                Name = "Bururi",
                LocalName = "Bururi"
            },
            new()
            { 
                Code = "CA",
                Type = "Province",
                Name = "Cankuzo",
                LocalName = "Cankuzo"
            },
            new()
            { 
                Code = "CI",
                Type = "Province",
                Name = "Cibitoke",
                LocalName = "Cibitoke"
            },
            new()
            { 
                Code = "GI",
                Type = "Province",
                Name = "Gitega",
                LocalName = "Gitega"
            },
            new()
            { 
                Code = "KR",
                Type = "Province",
                Name = "Karuzi",
                LocalName = "Karuzi"
            },
            new()
            { 
                Code = "KY",
                Type = "Province",
                Name = "Kayanza",
                LocalName = "Kayanza"
            },
            new()
            { 
                Code = "KI",
                Type = "Province",
                Name = "Kirundo",
                LocalName = "Kirundo"
            },
            new()
            { 
                Code = "MA",
                Type = "Province",
                Name = "Makamba",
                LocalName = "Makamba"
            },
            new()
            { 
                Code = "MU",
                Type = "Province",
                Name = "Muramvya",
                LocalName = "Muramvya"
            },
            new()
            { 
                Code = "MY",
                Type = "Province",
                Name = "Muyinga",
                LocalName = "Muyinga"
            },
            new()
            { 
                Code = "MW",
                Type = "Province",
                Name = "Mwaro",
                LocalName = "Mwaro"
            },
            new()
            { 
                Code = "NG",
                Type = "Province",
                Name = "Ngozi",
                LocalName = "Ngozi"
            },
            new()
            { 
                Code = "RM",
                Type = "Province",
                Name = "Rumonge",
                LocalName = "Rumonge"
            },
            new()
            { 
                Code = "RT",
                Type = "Province",
                Name = "Rutana",
                LocalName = "Rutana"
            },
            new()
            { 
                Code = "RY",
                Type = "Province",
                Name = "Ruyigi",
                LocalName = "Ruyigi"
            }

        });
    }
}
