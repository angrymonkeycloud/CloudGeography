using AngryMonkey.Cloud.Geography;
namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    private static void FillInSubdivisionsLR()
    {
        AddSubdivisions("LR",
        [
            new()
            { 
                Code = "BM",
                Type = SubdivisionTypes.County,
                Name = "Bomi",
                LocalName = "Bomi"
            },
            new()
            { 
                Code = "BG",
                Type = SubdivisionTypes.County,
                Name = "Bong",
                LocalName = "Bong"
            },
            new()
            { 
                Code = "GP",
                Type = SubdivisionTypes.County,
                Name = "Gbarpolu",
                LocalName = "Gbarpolu"
            },
            new()
            { 
                Code = "GB",
                Type = SubdivisionTypes.County,
                Name = "Grand Bassa",
                LocalName = "Grand Bassa"
            },
            new()
            { 
                Code = "CM",
                Type = SubdivisionTypes.County,
                Name = "Grand Cape Mount",
                LocalName = "Grand Cape Mount"
            },
            new()
            { 
                Code = "GG",
                Type = SubdivisionTypes.County,
                Name = "Grand Gedeh",
                LocalName = "Grand Gedeh"
            },
            new()
            { 
                Code = "GK",
                Type = SubdivisionTypes.County,
                Name = "Grand Kru",
                LocalName = "Grand Kru"
            },
            new()
            { 
                Code = "LO",
                Type = SubdivisionTypes.County,
                Name = "Lofa",
                LocalName = "Lofa"
            },
            new()
            { 
                Code = "MG",
                Type = SubdivisionTypes.County,
                Name = "Margibi",
                LocalName = "Margibi"
            },
            new()
            { 
                Code = "MY",
                Type = SubdivisionTypes.County,
                Name = "Maryland",
                LocalName = "Maryland"
            },
            new()
            { 
                Code = "MO",
                Type = SubdivisionTypes.County,
                Name = "Montserrado",
                LocalName = "Montserrado"
            },
            new()
            { 
                Code = "NI",
                Type = SubdivisionTypes.County,
                Name = "Nimba",
                LocalName = "Nimba"
            },
            new()
            { 
                Code = "RI",
                Type = SubdivisionTypes.County,
                Name = "River Cess",
                LocalName = "River Cess"
            },
            new()
            { 
                Code = "RG",
                Type = SubdivisionTypes.County,
                Name = "River Gee",
                LocalName = "River Gee"
            },
            new()
            { 
                Code = "SI",
                Type = SubdivisionTypes.County,
                Name = "Sinoe",
                LocalName = "Sinoe"
            }

        ]);
    }
}
