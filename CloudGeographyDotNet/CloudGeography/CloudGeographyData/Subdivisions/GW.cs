using AngryMonkey.Cloud.Geography;
namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    private static void FillInSubdivisionsGW()
    {
        AddSubdivisions("GW", new List<Subdivision>()
        {
            new()
            { 
                Code = "BA",
                Type = "Region",
                Name = "Bafatá",
                LocalName = "Bafatá"
            },
            new()
            { 
                Code = "BM",
                Type = "Region",
                Name = "Biombo",
                LocalName = "Biombo"
            },
            new()
            { 
                Code = "BS",
                Type = "Sector",
                Name = "Bissau",
                LocalName = "Bissau"
            },
            new()
            { 
                Code = "BL",
                Type = "Region",
                Name = "Bolama",
                LocalName = "Bolama"
            },
            new()
            { 
                Code = "CA",
                Type = "Region",
                Name = "Cacheu",
                LocalName = "Cacheu"
            },
            new()
            { 
                Code = "GA",
                Type = "Region",
                Name = "Gabú",
                LocalName = "Gabú"
            },
            new()
            { 
                Code = "OI",
                Type = "Region",
                Name = "Oio",
                LocalName = "Oio"
            },
            new()
            { 
                Code = "QU",
                Type = "Region",
                Name = "Quinara",
                LocalName = "Quinara"
            },
            new()
            { 
                Code = "TO",
                Type = "Region",
                Name = "Tombali",
                LocalName = "Tombali"
            }

        });
    }
}
