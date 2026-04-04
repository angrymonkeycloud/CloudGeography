using AngryMonkey.Cloud.Geography;
namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    private static void FillInSubdivisionsSN()
    {
        AddSubdivisions("SN",
        [
            new()
            { 
                Code = "DK",
                Type = SubdivisionTypes.Region,
                Name = "Dakar",
                LocalName = "Dakar"
            },
            new()
            { 
                Code = "DB",
                Type = SubdivisionTypes.Region,
                Name = "Diourbel",
                LocalName = "Diourbel"
            },
            new()
            { 
                Code = "FK",
                Type = SubdivisionTypes.Region,
                Name = "Fatick",
                LocalName = "Fatick"
            },
            new()
            { 
                Code = "KA",
                Type = SubdivisionTypes.Region,
                Name = "Kaffrine",
                LocalName = "Kaffrine"
            },
            new()
            { 
                Code = "KL",
                Type = SubdivisionTypes.Region,
                Name = "Kaolack",
                LocalName = "Kaolack"
            },
            new()
            { 
                Code = "KE",
                Type = SubdivisionTypes.Region,
                Name = "Kédougou",
                LocalName = "Kédougou"
            },
            new()
            { 
                Code = "KD",
                Type = SubdivisionTypes.Region,
                Name = "Kolda",
                LocalName = "Kolda"
            },
            new()
            { 
                Code = "LG",
                Type = SubdivisionTypes.Region,
                Name = "Louga",
                LocalName = "Louga"
            },
            new()
            { 
                Code = "MT",
                Type = SubdivisionTypes.Region,
                Name = "Matam",
                LocalName = "Matam"
            },
            new()
            { 
                Code = "SL",
                Type = SubdivisionTypes.Region,
                Name = "Saint-Louis",
                LocalName = "Saint-Louis"
            },
            new()
            { 
                Code = "SE",
                Type = SubdivisionTypes.Region,
                Name = "Sédhiou",
                LocalName = "Sédhiou"
            },
            new()
            { 
                Code = "TC",
                Type = SubdivisionTypes.Region,
                Name = "Tambacounda",
                LocalName = "Tambacounda"
            },
            new()
            { 
                Code = "TH",
                Type = SubdivisionTypes.Region,
                Name = "Thiès",
                LocalName = "Thiès"
            },
            new()
            { 
                Code = "ZG",
                Type = SubdivisionTypes.Region,
                Name = "Ziguinchor",
                LocalName = "Ziguinchor"
            }

        ]);
    }
}
