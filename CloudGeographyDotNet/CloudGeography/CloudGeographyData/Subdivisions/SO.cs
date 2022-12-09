using AngryMonkey.Cloud.Geography;
namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    private static void FillInSubdivisionsSO()
    {
        AddSubdivisions("SO", new List<Subdivision>()
        {
            new()
            { 
                Code = "AW",
                Type = "Region",
                Name = "Awdal",
                LocalName = "Awdal"
            },
            new()
            { 
                Code = "BK",
                Type = "Region",
                Name = "Bakool",
                LocalName = "Bakool"
            },
            new()
            { 
                Code = "BN",
                Type = "Region",
                Name = "Banaadir",
                LocalName = "Banaadir"
            },
            new()
            { 
                Code = "BR",
                Type = "Region",
                Name = "Bari",
                LocalName = "Bari"
            },
            new()
            { 
                Code = "BY",
                Type = "Region",
                Name = "Bay",
                LocalName = "Bay"
            },
            new()
            { 
                Code = "GA",
                Type = "Region",
                Name = "Galguduud",
                LocalName = "Galguduud"
            },
            new()
            { 
                Code = "GE",
                Type = "Region",
                Name = "Gedo",
                LocalName = "Gedo"
            },
            new()
            { 
                Code = "HI",
                Type = "Region",
                Name = "Hiiraan",
                LocalName = "Hiiraan"
            },
            new()
            { 
                Code = "JD",
                Type = "Region",
                Name = "Jubbada Dhexe",
                LocalName = "Jubbada Dhexe"
            },
            new()
            { 
                Code = "JH",
                Type = "Region",
                Name = "Jubbada Hoose",
                LocalName = "Jubbada Hoose"
            },
            new()
            { 
                Code = "MU",
                Type = "Region",
                Name = "Mudug",
                LocalName = "Mudug"
            },
            new()
            { 
                Code = "NU",
                Type = "Region",
                Name = "Nugaal",
                LocalName = "Nugaal"
            },
            new()
            { 
                Code = "SA",
                Type = "Region",
                Name = "Sanaag",
                LocalName = "Sanaag"
            },
            new()
            { 
                Code = "SD",
                Type = "Region",
                Name = "Shabeellaha Dhexe",
                LocalName = "Shabeellaha Dhexe"
            },
            new()
            { 
                Code = "SH",
                Type = "Region",
                Name = "Shabeellaha Hoose",
                LocalName = "Shabeellaha Hoose"
            },
            new()
            { 
                Code = "SO",
                Type = "Region",
                Name = "Sool",
                LocalName = "Sool"
            },
            new()
            { 
                Code = "TO",
                Type = "Region",
                Name = "Togdheer",
                LocalName = "Togdheer"
            },
            new()
            { 
                Code = "WO",
                Type = "Region",
                Name = "Woqooyi Galbeed",
                LocalName = "Woqooyi Galbeed"
            }

        });
    }
}
