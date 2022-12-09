using AngryMonkey.Cloud.Geography;
namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    private static void FillInSubdivisionsLU()
    {
        AddSubdivisions("LU", new List<Subdivision>()
        {
            new()
            { 
                Code = "CA",
                Type = "Canton",
                Name = "Capellen",
                LocalName = "Capellen"
            },
            new()
            { 
                Code = "CL",
                Type = "Canton",
                Name = "Clervaux",
                LocalName = "Clervaux"
            },
            new()
            { 
                Code = "DI",
                Type = "Canton",
                Name = "Diekirch",
                LocalName = "Diekirch"
            },
            new()
            { 
                Code = "EC",
                Type = "Canton",
                Name = "Echternach",
                LocalName = "Echternach"
            },
            new()
            { 
                Code = "ES",
                Type = "Canton",
                Name = "Esch-sur-Alzette",
                LocalName = "Esch-sur-Alzette"
            },
            new()
            { 
                Code = "GR",
                Type = "Canton",
                Name = "Gréivemaacher",
                LocalName = "Gréivemaacher"
            },
            new()
            { 
                Code = "LU",
                Type = "Canton",
                Name = "Luxembourg",
                LocalName = "Luxembourg"
            },
            new()
            { 
                Code = "ME",
                Type = "Canton",
                Name = "Mersch",
                LocalName = "Mersch"
            },
            new()
            { 
                Code = "RD",
                Type = "Canton",
                Name = "Redange",
                LocalName = "Redange"
            },
            new()
            { 
                Code = "RM",
                Type = "Canton",
                Name = "Remich",
                LocalName = "Remich"
            },
            new()
            { 
                Code = "VD",
                Type = "Canton",
                Name = "Vianden",
                LocalName = "Vianden"
            },
            new()
            { 
                Code = "WI",
                Type = "Canton",
                Name = "Wiltz",
                LocalName = "Wiltz"
            }

        });
    }
}
