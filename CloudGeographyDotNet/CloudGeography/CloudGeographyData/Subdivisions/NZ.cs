using AngryMonkey.Cloud.Geography;
namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    private static void FillInSubdivisionsNZ()
    {
        AddSubdivisions("NZ", new List<Subdivision>()
        {
            new()
            { 
                Code = "AUK",
                Type = "Region",
                Name = "Auckland",
                LocalName = "Auckland"
            },
            new()
            { 
                Code = "BOP",
                Type = "Region",
                Name = "Bay of Plenty",
                LocalName = "Bay of Plenty"
            },
            new()
            { 
                Code = "CAN",
                Type = "Region",
                Name = "Canterbury",
                LocalName = "Canterbury"
            },
            new()
            { 
                Code = "CIT",
                Type = "Island",
                Name = "Chatham Islands Territory",
                LocalName = "Chatham Islands Territory"
            },
            new()
            { 
                Code = "GIS",
                Type = "Region",
                Name = "Gisborne",
                LocalName = "Gisborne"
            },
            new()
            { 
                Code = "HKB",
                Type = "Region",
                Name = "Hawkes's Bay",
                LocalName = "Hawkes's Bay"
            },
            new()
            { 
                Code = "MWT",
                Type = "Region",
                Name = "Manawatu-Wanganui",
                LocalName = "Manawatu-Wanganui"
            },
            new()
            { 
                Code = "MBH",
                Type = "Region",
                Name = "Marlborough",
                LocalName = "Marlborough"
            },
            new()
            { 
                Code = "NSN",
                Type = "Region",
                Name = "Nelson",
                LocalName = "Nelson"
            },
            new()
            { 
                Code = "NTL",
                Type = "Region",
                Name = "Northland",
                LocalName = "Northland"
            },
            new()
            { 
                Code = "OTA",
                Type = "Region",
                Name = "Otago",
                LocalName = "Otago"
            },
            new()
            { 
                Code = "STL",
                Type = "Region",
                Name = "Southland",
                LocalName = "Southland"
            },
            new()
            { 
                Code = "TKI",
                Type = "Region",
                Name = "Taranaki",
                LocalName = "Taranaki"
            },
            new()
            { 
                Code = "TAS",
                Type = "Region",
                Name = "Tasman",
                LocalName = "Tasman"
            },
            new()
            { 
                Code = "WKO",
                Type = "Region",
                Name = "Waikato",
                LocalName = "Waikato"
            },
            new()
            { 
                Code = "WGN",
                Type = "Region",
                Name = "Wellington",
                LocalName = "Wellington"
            },
            new()
            { 
                Code = "WTC",
                Type = "Region",
                Name = "West Coast",
                LocalName = "West Coast"
            }

        });
    }
}
