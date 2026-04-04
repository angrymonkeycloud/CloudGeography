using AngryMonkey.Cloud.Geography;
namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    private static void FillInSubdivisionsNZ()
    {
        AddSubdivisions("NZ",
        [
            new()
            { 
                Code = "AUK",
                Type = SubdivisionTypes.Region,
                Name = "Auckland",
                LocalName = "Auckland"
            },
            new()
            { 
                Code = "BOP",
                Type = SubdivisionTypes.Region,
                Name = "Bay of Plenty",
                LocalName = "Bay of Plenty"
            },
            new()
            { 
                Code = "CAN",
                Type = SubdivisionTypes.Region,
                Name = "Canterbury",
                LocalName = "Canterbury"
            },
            new()
            { 
                Code = "CIT",
                Type = SubdivisionTypes.Island,
                Name = "Chatham Islands Territory",
                LocalName = "Chatham Islands Territory"
            },
            new()
            { 
                Code = "GIS",
                Type = SubdivisionTypes.Region,
                Name = "Gisborne",
                LocalName = "Gisborne"
            },
            new()
            { 
                Code = "HKB",
                Type = SubdivisionTypes.Region,
                Name = "Hawkes's Bay",
                LocalName = "Hawkes's Bay"
            },
            new()
            { 
                Code = "MWT",
                Type = SubdivisionTypes.Region,
                Name = "Manawatu-Wanganui",
                LocalName = "Manawatu-Wanganui"
            },
            new()
            { 
                Code = "MBH",
                Type = SubdivisionTypes.Region,
                Name = "Marlborough",
                LocalName = "Marlborough"
            },
            new()
            { 
                Code = "NSN",
                Type = SubdivisionTypes.Region,
                Name = "Nelson",
                LocalName = "Nelson"
            },
            new()
            { 
                Code = "NTL",
                Type = SubdivisionTypes.Region,
                Name = "Northland",
                LocalName = "Northland"
            },
            new()
            { 
                Code = "OTA",
                Type = SubdivisionTypes.Region,
                Name = "Otago",
                LocalName = "Otago"
            },
            new()
            { 
                Code = "STL",
                Type = SubdivisionTypes.Region,
                Name = "Southland",
                LocalName = "Southland"
            },
            new()
            { 
                Code = "TKI",
                Type = SubdivisionTypes.Region,
                Name = "Taranaki",
                LocalName = "Taranaki"
            },
            new()
            { 
                Code = "TAS",
                Type = SubdivisionTypes.Region,
                Name = "Tasman",
                LocalName = "Tasman"
            },
            new()
            { 
                Code = "WKO",
                Type = SubdivisionTypes.Region,
                Name = "Waikato",
                LocalName = "Waikato"
            },
            new()
            { 
                Code = "WGN",
                Type = SubdivisionTypes.Region,
                Name = "Wellington",
                LocalName = "Wellington"
            },
            new()
            { 
                Code = "WTC",
                Type = SubdivisionTypes.Region,
                Name = "West Coast",
                LocalName = "West Coast"
            }

        ]);
    }
}
