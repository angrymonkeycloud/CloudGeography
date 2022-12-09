using AngryMonkey.Cloud.Geography;
namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    private static void FillInSubdivisionsLR()
    {
        AddSubdivisions("LR", new List<Subdivision>()
        {
            new()
            { 
                Code = "BM",
                Type = "County",
                Name = "Bomi",
                LocalName = "Bomi"
            },
            new()
            { 
                Code = "BG",
                Type = "County",
                Name = "Bong",
                LocalName = "Bong"
            },
            new()
            { 
                Code = "GP",
                Type = "County",
                Name = "Gbarpolu",
                LocalName = "Gbarpolu"
            },
            new()
            { 
                Code = "GB",
                Type = "County",
                Name = "Grand Bassa",
                LocalName = "Grand Bassa"
            },
            new()
            { 
                Code = "CM",
                Type = "County",
                Name = "Grand Cape Mount",
                LocalName = "Grand Cape Mount"
            },
            new()
            { 
                Code = "GG",
                Type = "County",
                Name = "Grand Gedeh",
                LocalName = "Grand Gedeh"
            },
            new()
            { 
                Code = "GK",
                Type = "County",
                Name = "Grand Kru",
                LocalName = "Grand Kru"
            },
            new()
            { 
                Code = "LO",
                Type = "County",
                Name = "Lofa",
                LocalName = "Lofa"
            },
            new()
            { 
                Code = "MG",
                Type = "County",
                Name = "Margibi",
                LocalName = "Margibi"
            },
            new()
            { 
                Code = "MY",
                Type = "County",
                Name = "Maryland",
                LocalName = "Maryland"
            },
            new()
            { 
                Code = "MO",
                Type = "County",
                Name = "Montserrado",
                LocalName = "Montserrado"
            },
            new()
            { 
                Code = "NI",
                Type = "County",
                Name = "Nimba",
                LocalName = "Nimba"
            },
            new()
            { 
                Code = "RI",
                Type = "County",
                Name = "River Cess",
                LocalName = "River Cess"
            },
            new()
            { 
                Code = "RG",
                Type = "County",
                Name = "River Gee",
                LocalName = "River Gee"
            },
            new()
            { 
                Code = "SI",
                Type = "County",
                Name = "Sinoe",
                LocalName = "Sinoe"
            }

        });
    }
}
