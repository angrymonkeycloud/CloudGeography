using AngryMonkey.Cloud.Geography;
namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    private static void FillInSubdivisionsSN()
    {
        AddSubdivisions("SN", new List<Subdivision>()
        {
            new()
            { 
                Code = "DK",
                Type = "Region",
                Name = "Dakar",
                LocalName = "Dakar"
            },
            new()
            { 
                Code = "DB",
                Type = "Region",
                Name = "Diourbel",
                LocalName = "Diourbel"
            },
            new()
            { 
                Code = "FK",
                Type = "Region",
                Name = "Fatick",
                LocalName = "Fatick"
            },
            new()
            { 
                Code = "KA",
                Type = "Region",
                Name = "Kaffrine",
                LocalName = "Kaffrine"
            },
            new()
            { 
                Code = "KL",
                Type = "Region",
                Name = "Kaolack",
                LocalName = "Kaolack"
            },
            new()
            { 
                Code = "KE",
                Type = "Region",
                Name = "Kédougou",
                LocalName = "Kédougou"
            },
            new()
            { 
                Code = "KD",
                Type = "Region",
                Name = "Kolda",
                LocalName = "Kolda"
            },
            new()
            { 
                Code = "LG",
                Type = "Region",
                Name = "Louga",
                LocalName = "Louga"
            },
            new()
            { 
                Code = "MT",
                Type = "Region",
                Name = "Matam",
                LocalName = "Matam"
            },
            new()
            { 
                Code = "SL",
                Type = "Region",
                Name = "Saint-Louis",
                LocalName = "Saint-Louis"
            },
            new()
            { 
                Code = "SE",
                Type = "Region",
                Name = "Sédhiou",
                LocalName = "Sédhiou"
            },
            new()
            { 
                Code = "TC",
                Type = "Region",
                Name = "Tambacounda",
                LocalName = "Tambacounda"
            },
            new()
            { 
                Code = "TH",
                Type = "Region",
                Name = "Thiès",
                LocalName = "Thiès"
            },
            new()
            { 
                Code = "ZG",
                Type = "Region",
                Name = "Ziguinchor",
                LocalName = "Ziguinchor"
            }

        });
    }
}
