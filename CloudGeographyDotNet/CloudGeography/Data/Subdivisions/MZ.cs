using AngryMonkey.Cloud.Geography;
namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    private static void FillInSubdivisionsMZ()
    {
        AddSubdivisions("MZ",
        [
            new()
            { 
                Code = "P",
                Type = SubdivisionTypes.Province,
                Name = "Cabo Delgado",
                LocalName = "Cabo Delgado"
            },
            new()
            { 
                Code = "G",
                Type = SubdivisionTypes.Province,
                Name = "Gaza",
                LocalName = "Gaza"
            },
            new()
            { 
                Code = "I",
                Type = SubdivisionTypes.Province,
                Name = "Inhambane",
                LocalName = "Inhambane"
            },
            new()
            { 
                Code = "B",
                Type = SubdivisionTypes.Province,
                Name = "Manica",
                LocalName = "Manica"
            },
            new()
            { 
                Code = "L",
                Type = SubdivisionTypes.Province,
                Name = "Maputo",
                LocalName = "Maputo"
            },
            new()
            { 
                Code = "MPM",
                Type = SubdivisionTypes.City,
                Name = "Maputo",
                LocalName = "Maputo"
            },
            new()
            { 
                Code = "N",
                Type = SubdivisionTypes.Province,
                Name = "Nampula",
                LocalName = "Nampula"
            },
            new()
            { 
                Code = "A",
                Type = SubdivisionTypes.Province,
                Name = "Niaosa",
                LocalName = "Niaosa"
            },
            new()
            { 
                Code = "S",
                Type = SubdivisionTypes.Province,
                Name = "Sofala",
                LocalName = "Sofala"
            },
            new()
            { 
                Code = "T",
                Type = SubdivisionTypes.Province,
                Name = "Tete",
                LocalName = "Tete"
            },
            new()
            { 
                Code = "Q",
                Type = SubdivisionTypes.Province,
                Name = "Zambézia",
                LocalName = "Zambézia"
            }

        ]);
    }
}
