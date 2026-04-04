using AngryMonkey.Cloud.Geography;
namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    private static void FillInSubdivisionsMG()
    {
        AddSubdivisions("MG",
        [
            new()
            { 
                Code = "T",
                Type = SubdivisionTypes.Province,
                Name = "Antananarivo",
                LocalName = "Antananarivo"
            },
            new()
            { 
                Code = "D",
                Type = SubdivisionTypes.Province,
                Name = "Antsiranana",
                LocalName = "Antsiranana"
            },
            new()
            { 
                Code = "F",
                Type = SubdivisionTypes.Province,
                Name = "Fianarantsoa",
                LocalName = "Fianarantsoa"
            },
            new()
            { 
                Code = "M",
                Type = SubdivisionTypes.Province,
                Name = "Mahajanga",
                LocalName = "Mahajanga"
            },
            new()
            { 
                Code = "A",
                Type = SubdivisionTypes.Province,
                Name = "Toamasina",
                LocalName = "Toamasina"
            },
            new()
            { 
                Code = "U",
                Type = SubdivisionTypes.Province,
                Name = "Toliara",
                LocalName = "Toliara"
            }

        ]);
    }
}
