using AngryMonkey.Cloud.Geography;
namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    private static void FillInSubdivisionsWS()
    {
        AddSubdivisions("WS",
        [
            new()
            { 
                Code = "AA",
                Type = SubdivisionTypes.District,
                Name = "A'ana",
                LocalName = "A'ana"
            },
            new()
            { 
                Code = "AL",
                Type = SubdivisionTypes.District,
                Name = "Aiga-i-le-Tai",
                LocalName = "Aiga-i-le-Tai"
            },
            new()
            { 
                Code = "AT",
                Type = SubdivisionTypes.District,
                Name = "Atua",
                LocalName = "Atua"
            },
            new()
            { 
                Code = "FA",
                Type = SubdivisionTypes.District,
                Name = "Fa'asaleleaga",
                LocalName = "Fa'asaleleaga"
            },
            new()
            { 
                Code = "GE",
                Type = SubdivisionTypes.District,
                Name = "Gaga'emauga",
                LocalName = "Gaga'emauga"
            },
            new()
            { 
                Code = "GI",
                Type = SubdivisionTypes.District,
                Name = "Gagaifomauga",
                LocalName = "Gagaifomauga"
            },
            new()
            { 
                Code = "PA",
                Type = SubdivisionTypes.District,
                Name = "Palauli",
                LocalName = "Palauli"
            },
            new()
            { 
                Code = "SA",
                Type = SubdivisionTypes.District,
                Name = "Satupa 'itea",
                LocalName = "Satupa 'itea"
            },
            new()
            { 
                Code = "TU",
                Type = SubdivisionTypes.District,
                Name = "Tuamasaga",
                LocalName = "Tuamasaga"
            },
            new()
            { 
                Code = "VF",
                Type = SubdivisionTypes.District,
                Name = "Va'a-o-Fonoti",
                LocalName = "Va'a-o-Fonoti"
            },
            new()
            { 
                Code = "VS",
                Type = SubdivisionTypes.District,
                Name = "Vaisigano",
                LocalName = "Vaisigano"
            }

        ]);
    }
}
