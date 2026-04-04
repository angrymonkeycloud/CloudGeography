using AngryMonkey.Cloud.Geography;
namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    private static void FillInSubdivisionsGW()
    {
        AddSubdivisions("GW",
        [
            new()
            { 
                Code = "BA",
                Type = SubdivisionTypes.Region,
                Name = "Bafatá",
                LocalName = "Bafatá"
            },
            new()
            { 
                Code = "BM",
                Type = SubdivisionTypes.Region,
                Name = "Biombo",
                LocalName = "Biombo"
            },
            new()
            { 
                Code = "BS",
                Type = SubdivisionTypes.Sector,
                Name = "Bissau",
                LocalName = "Bissau"
            },
            new()
            { 
                Code = "BL",
                Type = SubdivisionTypes.Region,
                Name = "Bolama",
                LocalName = "Bolama"
            },
            new()
            { 
                Code = "CA",
                Type = SubdivisionTypes.Region,
                Name = "Cacheu",
                LocalName = "Cacheu"
            },
            new()
            { 
                Code = "GA",
                Type = SubdivisionTypes.Region,
                Name = "Gabú",
                LocalName = "Gabú"
            },
            new()
            { 
                Code = "OI",
                Type = SubdivisionTypes.Region,
                Name = "Oio",
                LocalName = "Oio"
            },
            new()
            { 
                Code = "QU",
                Type = SubdivisionTypes.Region,
                Name = "Quinara",
                LocalName = "Quinara"
            },
            new()
            { 
                Code = "TO",
                Type = SubdivisionTypes.Region,
                Name = "Tombali",
                LocalName = "Tombali"
            }

        ]);
    }
}
