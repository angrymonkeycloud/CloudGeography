using AngryMonkey.Cloud.Geography;
namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    private static void FillInSubdivisionsCG()
    {
        AddSubdivisions("CG", new List<Subdivision>()
        {
            new()
            { 
                Code = "11",
                Type = "Department",
                Name = "Bouenza",
                LocalName = "Bouenza"
            },
            new()
            { 
                Code = "BZV",
                Type = "Department",
                Name = "Brazzaville",
                LocalName = "Brazzaville"
            },
            new()
            { 
                Code = "8",
                Type = "Department",
                Name = "Cuvette",
                LocalName = "Cuvette"
            },
            new()
            { 
                Code = "15",
                Type = "Department",
                Name = "Cuvette-Ouest",
                LocalName = "Cuvette-Ouest"
            },
            new()
            { 
                Code = "5",
                Type = "Department",
                Name = "Kouilou",
                LocalName = "Kouilou"
            },
            new()
            { 
                Code = "2",
                Type = "Department",
                Name = "Lékoumou",
                LocalName = "Lékoumou"
            },
            new()
            { 
                Code = "7",
                Type = "Department",
                Name = "Likouala",
                LocalName = "Likouala"
            },
            new()
            { 
                Code = "9",
                Type = "Department",
                Name = "Niari",
                LocalName = "Niari"
            },
            new()
            { 
                Code = "14",
                Type = "Department",
                Name = "Plateaux",
                LocalName = "Plateaux"
            },
            new()
            { 
                Code = "16",
                Type = "Department",
                Name = "Pointe-Noire",
                LocalName = "Pointe-Noire"
            },
            new()
            { 
                Code = "12",
                Type = "Department",
                Name = "Pool",
                LocalName = "Pool"
            },
            new()
            { 
                Code = "13",
                Type = "Department",
                Name = "Sangha",
                LocalName = "Sangha"
            }

        });
    }
}
