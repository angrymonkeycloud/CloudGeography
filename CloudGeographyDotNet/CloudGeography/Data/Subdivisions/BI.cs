using AngryMonkey.Cloud.Geography;
namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    private static void FillInSubdivisionsBI()
    {
        AddSubdivisions("BI",
        [
            new()
            { 
                Code = "BB",
                Type = SubdivisionTypes.Province,
                Name = "Bubanza",
                LocalName = "Bubanza"
            },
            new()
            { 
                Code = "BM",
                Type = SubdivisionTypes.Province,
                Name = "Bujumbura Mairie",
                LocalName = "Bujumbura Mairie"
            },
            new()
            { 
                Code = "BL",
                Type = SubdivisionTypes.Province,
                Name = "Bujumbura Rural",
                LocalName = "Bujumbura Rural"
            },
            new()
            { 
                Code = "BR",
                Type = SubdivisionTypes.Province,
                Name = "Bururi",
                LocalName = "Bururi"
            },
            new()
            { 
                Code = "CA",
                Type = SubdivisionTypes.Province,
                Name = "Cankuzo",
                LocalName = "Cankuzo"
            },
            new()
            { 
                Code = "CI",
                Type = SubdivisionTypes.Province,
                Name = "Cibitoke",
                LocalName = "Cibitoke"
            },
            new()
            { 
                Code = "GI",
                Type = SubdivisionTypes.Province,
                Name = "Gitega",
                LocalName = "Gitega"
            },
            new()
            { 
                Code = "KR",
                Type = SubdivisionTypes.Province,
                Name = "Karuzi",
                LocalName = "Karuzi"
            },
            new()
            { 
                Code = "KY",
                Type = SubdivisionTypes.Province,
                Name = "Kayanza",
                LocalName = "Kayanza"
            },
            new()
            { 
                Code = "KI",
                Type = SubdivisionTypes.Province,
                Name = "Kirundo",
                LocalName = "Kirundo"
            },
            new()
            { 
                Code = "MA",
                Type = SubdivisionTypes.Province,
                Name = "Makamba",
                LocalName = "Makamba"
            },
            new()
            { 
                Code = "MU",
                Type = SubdivisionTypes.Province,
                Name = "Muramvya",
                LocalName = "Muramvya"
            },
            new()
            { 
                Code = "MY",
                Type = SubdivisionTypes.Province,
                Name = "Muyinga",
                LocalName = "Muyinga"
            },
            new()
            { 
                Code = "MW",
                Type = SubdivisionTypes.Province,
                Name = "Mwaro",
                LocalName = "Mwaro"
            },
            new()
            { 
                Code = "NG",
                Type = SubdivisionTypes.Province,
                Name = "Ngozi",
                LocalName = "Ngozi"
            },
            new()
            { 
                Code = "RM",
                Type = SubdivisionTypes.Province,
                Name = "Rumonge",
                LocalName = "Rumonge"
            },
            new()
            { 
                Code = "RT",
                Type = SubdivisionTypes.Province,
                Name = "Rutana",
                LocalName = "Rutana"
            },
            new()
            { 
                Code = "RY",
                Type = SubdivisionTypes.Province,
                Name = "Ruyigi",
                LocalName = "Ruyigi"
            }

        ]);
    }
}
