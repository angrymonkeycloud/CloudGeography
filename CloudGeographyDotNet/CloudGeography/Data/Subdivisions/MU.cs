using AngryMonkey.Cloud.Geography;
namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    private static void FillInSubdivisionsMU()
    {
        AddSubdivisions("MU", new List<Subdivision>()
        {
            new()
            { 
                Code = "AG",
                Type = "Dependency",
                Name = "Agalega Islands",
                LocalName = "Agalega Islands"
            },
            new()
            { 
                Code = "BR",
                Type = "City",
                Name = "Beau Bassin-Rose Hill",
                LocalName = "Beau Bassin-Rose Hill"
            },
            new()
            { 
                Code = "BL",
                Type = "District",
                Name = "Black River",
                LocalName = "Black River"
            },
            new()
            { 
                Code = "CC",
                Type = "Dependency",
                Name = "Cargados Carajos Shoals",
                LocalName = "Cargados Carajos Shoals"
            },
            new()
            { 
                Code = "CU",
                Type = "City",
                Name = "Curepipe",
                LocalName = "Curepipe"
            },
            new()
            { 
                Code = "FL",
                Type = "District",
                Name = "Flacq",
                LocalName = "Flacq"
            },
            new()
            { 
                Code = "GP",
                Type = "District",
                Name = "Grand Port",
                LocalName = "Grand Port"
            },
            new()
            { 
                Code = "MO",
                Type = "District",
                Name = "Moka",
                LocalName = "Moka"
            },
            new()
            { 
                Code = "PA",
                Type = "District",
                Name = "Pamplemousses",
                LocalName = "Pamplemousses"
            },
            new()
            { 
                Code = "PW",
                Type = "District",
                Name = "Plaines wilhems",
                LocalName = "Plaines wilhems"
            },
            new()
            { 
                Code = "PL",
                Type = "District",
                Name = "Port Louis",
                LocalName = "Port Louis"
            },
            new()
            { 
                Code = "PU",
                Type = "City",
                Name = "Port Louis",
                LocalName = "Port Louis"
            },
            new()
            { 
                Code = "QB",
                Type = "City",
                Name = "Quatre Bornes",
                LocalName = "Quatre Bornes"
            },
            new()
            { 
                Code = "RR",
                Type = "District",
                Name = "Rivière du Rempart",
                LocalName = "Rivière du Rempart"
            },
            new()
            { 
                Code = "RO",
                Type = "Dependency",
                Name = "Rodrigues Island",
                LocalName = "Rodrigues Island"
            },
            new()
            { 
                Code = "SA",
                Type = "District",
                Name = "Savanne",
                LocalName = "Savanne"
            },
            new()
            { 
                Code = "VP",
                Type = "City",
                Name = "Vacoas-Phoenix",
                LocalName = "Vacoas-Phoenix"
            }

        });
    }
}
