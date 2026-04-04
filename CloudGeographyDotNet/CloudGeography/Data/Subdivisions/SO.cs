using AngryMonkey.Cloud.Geography;
namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    private static void FillInSubdivisionsSO()
    {
        AddSubdivisions("SO",
        [
            new()
            { 
                Code = "AW",
                Type = SubdivisionTypes.Region,
                Name = "Awdal",
                LocalName = "Awdal"
            },
            new()
            { 
                Code = "BK",
                Type = SubdivisionTypes.Region,
                Name = "Bakool",
                LocalName = "Bakool"
            },
            new()
            { 
                Code = "BN",
                Type = SubdivisionTypes.Region,
                Name = "Banaadir",
                LocalName = "Banaadir"
            },
            new()
            { 
                Code = "BR",
                Type = SubdivisionTypes.Region,
                Name = "Bari",
                LocalName = "Bari"
            },
            new()
            { 
                Code = "BY",
                Type = SubdivisionTypes.Region,
                Name = "Bay",
                LocalName = "Bay"
            },
            new()
            { 
                Code = "GA",
                Type = SubdivisionTypes.Region,
                Name = "Galguduud",
                LocalName = "Galguduud"
            },
            new()
            { 
                Code = "GE",
                Type = SubdivisionTypes.Region,
                Name = "Gedo",
                LocalName = "Gedo"
            },
            new()
            { 
                Code = "HI",
                Type = SubdivisionTypes.Region,
                Name = "Hiiraan",
                LocalName = "Hiiraan"
            },
            new()
            { 
                Code = "JD",
                Type = SubdivisionTypes.Region,
                Name = "Jubbada Dhexe",
                LocalName = "Jubbada Dhexe"
            },
            new()
            { 
                Code = "JH",
                Type = SubdivisionTypes.Region,
                Name = "Jubbada Hoose",
                LocalName = "Jubbada Hoose"
            },
            new()
            { 
                Code = "MU",
                Type = SubdivisionTypes.Region,
                Name = "Mudug",
                LocalName = "Mudug"
            },
            new()
            { 
                Code = "NU",
                Type = SubdivisionTypes.Region,
                Name = "Nugaal",
                LocalName = "Nugaal"
            },
            new()
            { 
                Code = "SA",
                Type = SubdivisionTypes.Region,
                Name = "Sanaag",
                LocalName = "Sanaag"
            },
            new()
            { 
                Code = "SD",
                Type = SubdivisionTypes.Region,
                Name = "Shabeellaha Dhexe",
                LocalName = "Shabeellaha Dhexe"
            },
            new()
            { 
                Code = "SH",
                Type = SubdivisionTypes.Region,
                Name = "Shabeellaha Hoose",
                LocalName = "Shabeellaha Hoose"
            },
            new()
            { 
                Code = "SO",
                Type = SubdivisionTypes.Region,
                Name = "Sool",
                LocalName = "Sool"
            },
            new()
            { 
                Code = "TO",
                Type = SubdivisionTypes.Region,
                Name = "Togdheer",
                LocalName = "Togdheer"
            },
            new()
            { 
                Code = "WO",
                Type = SubdivisionTypes.Region,
                Name = "Woqooyi Galbeed",
                LocalName = "Woqooyi Galbeed"
            }

        ]);
    }
}
