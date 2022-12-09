using AngryMonkey.Cloud.Geography;
namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    private static void FillInSubdivisionsMZ()
    {
        AddSubdivisions("MZ", new List<Subdivision>()
        {
            new()
            { 
                Code = "P",
                Type = "Province",
                Name = "Cabo Delgado",
                LocalName = "Cabo Delgado"
            },
            new()
            { 
                Code = "G",
                Type = "Province",
                Name = "Gaza",
                LocalName = "Gaza"
            },
            new()
            { 
                Code = "I",
                Type = "Province",
                Name = "Inhambane",
                LocalName = "Inhambane"
            },
            new()
            { 
                Code = "B",
                Type = "Province",
                Name = "Manica",
                LocalName = "Manica"
            },
            new()
            { 
                Code = "L",
                Type = "Province",
                Name = "Maputo",
                LocalName = "Maputo"
            },
            new()
            { 
                Code = "MPM",
                Type = "City",
                Name = "Maputo",
                LocalName = "Maputo"
            },
            new()
            { 
                Code = "N",
                Type = "Province",
                Name = "Nampula",
                LocalName = "Nampula"
            },
            new()
            { 
                Code = "A",
                Type = "Province",
                Name = "Niaosa",
                LocalName = "Niaosa"
            },
            new()
            { 
                Code = "S",
                Type = "Province",
                Name = "Sofala",
                LocalName = "Sofala"
            },
            new()
            { 
                Code = "T",
                Type = "Province",
                Name = "Tete",
                LocalName = "Tete"
            },
            new()
            { 
                Code = "Q",
                Type = "Province",
                Name = "Zambézia",
                LocalName = "Zambézia"
            }

        });
    }
}
