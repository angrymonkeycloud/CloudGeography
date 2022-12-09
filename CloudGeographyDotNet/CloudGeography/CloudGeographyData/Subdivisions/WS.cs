using AngryMonkey.Cloud.Geography;
namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    private static void FillInSubdivisionsWS()
    {
        AddSubdivisions("WS", new List<Subdivision>()
        {
            new()
            { 
                Code = "AA",
                Type = "District",
                Name = "A'ana",
                LocalName = "A'ana"
            },
            new()
            { 
                Code = "AL",
                Type = "District",
                Name = "Aiga-i-le-Tai",
                LocalName = "Aiga-i-le-Tai"
            },
            new()
            { 
                Code = "AT",
                Type = "District",
                Name = "Atua",
                LocalName = "Atua"
            },
            new()
            { 
                Code = "FA",
                Type = "District",
                Name = "Fa'asaleleaga",
                LocalName = "Fa'asaleleaga"
            },
            new()
            { 
                Code = "GE",
                Type = "District",
                Name = "Gaga'emauga",
                LocalName = "Gaga'emauga"
            },
            new()
            { 
                Code = "GI",
                Type = "District",
                Name = "Gagaifomauga",
                LocalName = "Gagaifomauga"
            },
            new()
            { 
                Code = "PA",
                Type = "District",
                Name = "Palauli",
                LocalName = "Palauli"
            },
            new()
            { 
                Code = "SA",
                Type = "District",
                Name = "Satupa 'itea",
                LocalName = "Satupa 'itea"
            },
            new()
            { 
                Code = "TU",
                Type = "District",
                Name = "Tuamasaga",
                LocalName = "Tuamasaga"
            },
            new()
            { 
                Code = "VF",
                Type = "District",
                Name = "Va'a-o-Fonoti",
                LocalName = "Va'a-o-Fonoti"
            },
            new()
            { 
                Code = "VS",
                Type = "District",
                Name = "Vaisigano",
                LocalName = "Vaisigano"
            }

        });
    }
}
