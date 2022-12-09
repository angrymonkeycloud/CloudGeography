using AngryMonkey.Cloud.Geography;
namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    private static void FillInSubdivisionsPG()
    {
        AddSubdivisions("PG", new List<Subdivision>()
        {
            new()
            { 
                Code = "NSB",
                Type = "Region",
                Name = "Bougainville",
                LocalName = "Bougainville"
            },
            new()
            { 
                Code = "CPM",
                Type = "Province",
                Name = "Central",
                LocalName = "Central"
            },
            new()
            { 
                Code = "CPK",
                Type = "Province",
                Name = "Chimbu",
                LocalName = "Chimbu"
            },
            new()
            { 
                Code = "EBR",
                Type = "Province",
                Name = "East New Britain",
                LocalName = "East New Britain"
            },
            new()
            { 
                Code = "ESW",
                Type = "Province",
                Name = "East Sepik",
                LocalName = "East Sepik"
            },
            new()
            { 
                Code = "EHG",
                Type = "Province",
                Name = "Eastern Highlands",
                LocalName = "Eastern Highlands"
            },
            new()
            { 
                Code = "EPW",
                Type = "Province",
                Name = "Enga",
                LocalName = "Enga"
            },
            new()
            { 
                Code = "GPK",
                Type = "Province",
                Name = "Gulf",
                LocalName = "Gulf"
            },
            new()
            { 
                Code = "HLA",
                Type = "Province",
                Name = "Hela",
                LocalName = "Hela"
            },
            new()
            { 
                Code = "JWK",
                Type = "Province",
                Name = "Jiwaka",
                LocalName = "Jiwaka"
            },
            new()
            { 
                Code = "MPM",
                Type = "Province",
                Name = "Madang",
                LocalName = "Madang"
            },
            new()
            { 
                Code = "MRL",
                Type = "Province",
                Name = "Manus",
                LocalName = "Manus"
            },
            new()
            { 
                Code = "MBA",
                Type = "Province",
                Name = "Milne Bay",
                LocalName = "Milne Bay"
            },
            new()
            { 
                Code = "MPL",
                Type = "Province",
                Name = "Morobe",
                LocalName = "Morobe"
            },
            new()
            { 
                Code = "NCD",
                Type = "District",
                Name = "National Capital District",
                LocalName = "National Capital District"
            },
            new()
            { 
                Code = "NIK",
                Type = "Province",
                Name = "New Ireland",
                LocalName = "New Ireland"
            },
            new()
            { 
                Code = "NPP",
                Type = "Province",
                Name = "Northern",
                LocalName = "Northern"
            },
            new()
            { 
                Code = "SHM",
                Type = "Province",
                Name = "Southern Highlands",
                LocalName = "Southern Highlands"
            },
            new()
            { 
                Code = "WBK",
                Type = "Province",
                Name = "West New Britain",
                LocalName = "West New Britain"
            },
            new()
            { 
                Code = "SAN",
                Type = "Province",
                Name = "West Sepik",
                LocalName = "West Sepik"
            },
            new()
            { 
                Code = "WPD",
                Type = "Province",
                Name = "Western",
                LocalName = "Western"
            },
            new()
            { 
                Code = "WHM",
                Type = "Province",
                Name = "Western Highlands",
                LocalName = "Western Highlands"
            }

        });
    }
}
