using AngryMonkey.Cloud.Geography;
namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    private static void FillInSubdivisionsMU()
    {
        AddSubdivisions("MU",
        [
            new()
            { 
                Code = "AG",
                Type = SubdivisionTypes.Dependency,
                Name = "Agalega Islands",
                LocalName = "Agalega Islands"
            },
            new()
            { 
                Code = "BR",
                Type = SubdivisionTypes.City,
                Name = "Beau Bassin-Rose Hill",
                LocalName = "Beau Bassin-Rose Hill"
            },
            new()
            { 
                Code = "BL",
                Type = SubdivisionTypes.District,
                Name = "Black River",
                LocalName = "Black River"
            },
            new()
            { 
                Code = "CC",
                Type = SubdivisionTypes.Dependency,
                Name = "Cargados Carajos Shoals",
                LocalName = "Cargados Carajos Shoals"
            },
            new()
            { 
                Code = "CU",
                Type = SubdivisionTypes.City,
                Name = "Curepipe",
                LocalName = "Curepipe"
            },
            new()
            { 
                Code = "FL",
                Type = SubdivisionTypes.District,
                Name = "Flacq",
                LocalName = "Flacq"
            },
            new()
            { 
                Code = "GP",
                Type = SubdivisionTypes.District,
                Name = "Grand Port",
                LocalName = "Grand Port"
            },
            new()
            { 
                Code = "MO",
                Type = SubdivisionTypes.District,
                Name = "Moka",
                LocalName = "Moka"
            },
            new()
            { 
                Code = "PA",
                Type = SubdivisionTypes.District,
                Name = "Pamplemousses",
                LocalName = "Pamplemousses"
            },
            new()
            { 
                Code = "PW",
                Type = SubdivisionTypes.District,
                Name = "Plaines wilhems",
                LocalName = "Plaines wilhems"
            },
            new()
            { 
                Code = "PL",
                Type = SubdivisionTypes.District,
                Name = "Port Louis",
                LocalName = "Port Louis"
            },
            new()
            { 
                Code = "PU",
                Type = SubdivisionTypes.City,
                Name = "Port Louis",
                LocalName = "Port Louis"
            },
            new()
            { 
                Code = "QB",
                Type = SubdivisionTypes.City,
                Name = "Quatre Bornes",
                LocalName = "Quatre Bornes"
            },
            new()
            { 
                Code = "RR",
                Type = SubdivisionTypes.District,
                Name = "Rivière du Rempart",
                LocalName = "Rivière du Rempart"
            },
            new()
            { 
                Code = "RO",
                Type = SubdivisionTypes.Dependency,
                Name = "Rodrigues Island",
                LocalName = "Rodrigues Island"
            },
            new()
            { 
                Code = "SA",
                Type = SubdivisionTypes.District,
                Name = "Savanne",
                LocalName = "Savanne"
            },
            new()
            { 
                Code = "VP",
                Type = SubdivisionTypes.City,
                Name = "Vacoas-Phoenix",
                LocalName = "Vacoas-Phoenix"
            }

        ]);
    }
}
