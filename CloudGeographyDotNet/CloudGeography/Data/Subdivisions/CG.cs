using AngryMonkey.Cloud.Geography;
namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    private static void FillInSubdivisionsCG()
    {
        AddSubdivisions("CG",
        [
            new()
            { 
                Code = "11",
                Type = SubdivisionTypes.Department,
                Name = "Bouenza",
                LocalName = "Bouenza"
            },
            new()
            { 
                Code = "BZV",
                Type = SubdivisionTypes.Department,
                Name = "Brazzaville",
                LocalName = "Brazzaville"
            },
            new()
            { 
                Code = "8",
                Type = SubdivisionTypes.Department,
                Name = "Cuvette",
                LocalName = "Cuvette"
            },
            new()
            { 
                Code = "15",
                Type = SubdivisionTypes.Department,
                Name = "Cuvette-Ouest",
                LocalName = "Cuvette-Ouest"
            },
            new()
            { 
                Code = "5",
                Type = SubdivisionTypes.Department,
                Name = "Kouilou",
                LocalName = "Kouilou"
            },
            new()
            { 
                Code = "2",
                Type = SubdivisionTypes.Department,
                Name = "Lékoumou",
                LocalName = "Lékoumou"
            },
            new()
            { 
                Code = "7",
                Type = SubdivisionTypes.Department,
                Name = "Likouala",
                LocalName = "Likouala"
            },
            new()
            { 
                Code = "9",
                Type = SubdivisionTypes.Department,
                Name = "Niari",
                LocalName = "Niari"
            },
            new()
            { 
                Code = "14",
                Type = SubdivisionTypes.Department,
                Name = "Plateaux",
                LocalName = "Plateaux"
            },
            new()
            { 
                Code = "16",
                Type = SubdivisionTypes.Department,
                Name = "Pointe-Noire",
                LocalName = "Pointe-Noire"
            },
            new()
            { 
                Code = "12",
                Type = SubdivisionTypes.Department,
                Name = "Pool",
                LocalName = "Pool"
            },
            new()
            { 
                Code = "13",
                Type = SubdivisionTypes.Department,
                Name = "Sangha",
                LocalName = "Sangha"
            }

        ]);
    }
}
