using AngryMonkey.Cloud.Geography;
namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    private static void FillInSubdivisionsPG()
    {
        AddSubdivisions("PG",
        [
            new()
            { 
                Code = "NSB",
                Type = SubdivisionTypes.Region,
                Name = "Bougainville",
                LocalName = "Bougainville"
            },
            new()
            { 
                Code = "CPM",
                Type = SubdivisionTypes.Province,
                Name = "Central",
                LocalName = "Central"
            },
            new()
            { 
                Code = "CPK",
                Type = SubdivisionTypes.Province,
                Name = "Chimbu",
                LocalName = "Chimbu"
            },
            new()
            { 
                Code = "EBR",
                Type = SubdivisionTypes.Province,
                Name = "East New Britain",
                LocalName = "East New Britain"
            },
            new()
            { 
                Code = "ESW",
                Type = SubdivisionTypes.Province,
                Name = "East Sepik",
                LocalName = "East Sepik"
            },
            new()
            { 
                Code = "EHG",
                Type = SubdivisionTypes.Province,
                Name = "Eastern Highlands",
                LocalName = "Eastern Highlands"
            },
            new()
            { 
                Code = "EPW",
                Type = SubdivisionTypes.Province,
                Name = "Enga",
                LocalName = "Enga"
            },
            new()
            { 
                Code = "GPK",
                Type = SubdivisionTypes.Province,
                Name = "Gulf",
                LocalName = "Gulf"
            },
            new()
            { 
                Code = "HLA",
                Type = SubdivisionTypes.Province,
                Name = "Hela",
                LocalName = "Hela"
            },
            new()
            { 
                Code = "JWK",
                Type = SubdivisionTypes.Province,
                Name = "Jiwaka",
                LocalName = "Jiwaka"
            },
            new()
            { 
                Code = "MPM",
                Type = SubdivisionTypes.Province,
                Name = "Madang",
                LocalName = "Madang"
            },
            new()
            { 
                Code = "MRL",
                Type = SubdivisionTypes.Province,
                Name = "Manus",
                LocalName = "Manus"
            },
            new()
            { 
                Code = "MBA",
                Type = SubdivisionTypes.Province,
                Name = "Milne Bay",
                LocalName = "Milne Bay"
            },
            new()
            { 
                Code = "MPL",
                Type = SubdivisionTypes.Province,
                Name = "Morobe",
                LocalName = "Morobe"
            },
            new()
            { 
                Code = "NCD",
                Type = SubdivisionTypes.District,
                Name = "National Capital District",
                LocalName = "National Capital District"
            },
            new()
            { 
                Code = "NIK",
                Type = SubdivisionTypes.Province,
                Name = "New Ireland",
                LocalName = "New Ireland"
            },
            new()
            { 
                Code = "NPP",
                Type = SubdivisionTypes.Province,
                Name = "Northern",
                LocalName = "Northern"
            },
            new()
            { 
                Code = "SHM",
                Type = SubdivisionTypes.Province,
                Name = "Southern Highlands",
                LocalName = "Southern Highlands"
            },
            new()
            { 
                Code = "WBK",
                Type = SubdivisionTypes.Province,
                Name = "West New Britain",
                LocalName = "West New Britain"
            },
            new()
            { 
                Code = "SAN",
                Type = SubdivisionTypes.Province,
                Name = "West Sepik",
                LocalName = "West Sepik"
            },
            new()
            { 
                Code = "WPD",
                Type = SubdivisionTypes.Province,
                Name = "Western",
                LocalName = "Western"
            },
            new()
            { 
                Code = "WHM",
                Type = SubdivisionTypes.Province,
                Name = "Western Highlands",
                LocalName = "Western Highlands"
            }

        ]);
    }
}
