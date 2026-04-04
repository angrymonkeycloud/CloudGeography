using AngryMonkey.Cloud.Geography;
namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    private static void FillInSubdivisionsLU()
    {
        AddSubdivisions("LU",
        [
            new()
            { 
                Code = "CA",
                Type = SubdivisionTypes.Canton,
                Name = "Capellen",
                LocalName = "Capellen"
            },
            new()
            { 
                Code = "CL",
                Type = SubdivisionTypes.Canton,
                Name = "Clervaux",
                LocalName = "Clervaux"
            },
            new()
            { 
                Code = "DI",
                Type = SubdivisionTypes.Canton,
                Name = "Diekirch",
                LocalName = "Diekirch"
            },
            new()
            { 
                Code = "EC",
                Type = SubdivisionTypes.Canton,
                Name = "Echternach",
                LocalName = "Echternach"
            },
            new()
            { 
                Code = "ES",
                Type = SubdivisionTypes.Canton,
                Name = "Esch-sur-Alzette",
                LocalName = "Esch-sur-Alzette"
            },
            new()
            { 
                Code = "GR",
                Type = SubdivisionTypes.Canton,
                Name = "Gréivemaacher",
                LocalName = "Gréivemaacher"
            },
            new()
            { 
                Code = "LU",
                Type = SubdivisionTypes.Canton,
                Name = "Luxembourg",
                LocalName = "Luxembourg"
            },
            new()
            { 
                Code = "ME",
                Type = SubdivisionTypes.Canton,
                Name = "Mersch",
                LocalName = "Mersch"
            },
            new()
            { 
                Code = "RD",
                Type = SubdivisionTypes.Canton,
                Name = "Redange",
                LocalName = "Redange"
            },
            new()
            { 
                Code = "RM",
                Type = SubdivisionTypes.Canton,
                Name = "Remich",
                LocalName = "Remich"
            },
            new()
            { 
                Code = "VD",
                Type = SubdivisionTypes.Canton,
                Name = "Vianden",
                LocalName = "Vianden"
            },
            new()
            { 
                Code = "WI",
                Type = SubdivisionTypes.Canton,
                Name = "Wiltz",
                LocalName = "Wiltz"
            }

        ]);
    }
}
