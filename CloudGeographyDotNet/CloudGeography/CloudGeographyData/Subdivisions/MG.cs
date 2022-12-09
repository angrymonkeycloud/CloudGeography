using AngryMonkey.Cloud.Geography;
namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    private static void FillInSubdivisionsMG()
    {
        AddSubdivisions("MG", new List<Subdivision>()
        {
            new()
            { 
                Code = "T",
                Type = "Province",
                Name = "Antananarivo",
                LocalName = "Antananarivo"
            },
            new()
            { 
                Code = "D",
                Type = "Province",
                Name = "Antsiranana",
                LocalName = "Antsiranana"
            },
            new()
            { 
                Code = "F",
                Type = "Province",
                Name = "Fianarantsoa",
                LocalName = "Fianarantsoa"
            },
            new()
            { 
                Code = "M",
                Type = "Province",
                Name = "Mahajanga",
                LocalName = "Mahajanga"
            },
            new()
            { 
                Code = "A",
                Type = "Province",
                Name = "Toamasina",
                LocalName = "Toamasina"
            },
            new()
            { 
                Code = "U",
                Type = "Province",
                Name = "Toliara",
                LocalName = "Toliara"
            }

        });
    }
}
