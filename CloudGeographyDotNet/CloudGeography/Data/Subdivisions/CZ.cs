using AngryMonkey.Cloud.Geography;
namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    private static void FillInSubdivisionsCZ()
    {
        AddSubdivisions("CZ",
        [
            new()
            { 
                Code = "31",
                Type = SubdivisionTypes.Region,
                Name = "Jihoceský kraj",
                LocalName = "Jihoceský kraj"
            },
            new()
            { 
                Code = "64",
                Type = SubdivisionTypes.Region,
                Name = "Jihomoravský kraj",
                LocalName = "Jihomoravský kraj"
            },
            new()
            { 
                Code = "41",
                Type = SubdivisionTypes.Region,
                Name = "Karlovarský kraj",
                LocalName = "Karlovarský kraj"
            },
            new()
            { 
                Code = "63",
                Type = SubdivisionTypes.Region,
                Name = "Kraj Vysocina",
                LocalName = "Kraj Vysocina"
            },
            new()
            { 
                Code = "52",
                Type = SubdivisionTypes.Region,
                Name = "Královéhradecký kraj",
                LocalName = "Královéhradecký kraj"
            },
            new()
            { 
                Code = "51",
                Type = SubdivisionTypes.Region,
                Name = "Liberecký kraj",
                LocalName = "Liberecký kraj"
            },
            new()
            { 
                Code = "80",
                Type = SubdivisionTypes.Region,
                Name = "Moravskoslezský kraj",
                LocalName = "Moravskoslezský kraj"
            },
            new()
            { 
                Code = "71",
                Type = SubdivisionTypes.Region,
                Name = "Olomoucký kraj",
                LocalName = "Olomoucký kraj"
            },
            new()
            { 
                Code = "53",
                Type = SubdivisionTypes.Region,
                Name = "Pardubický kraj",
                LocalName = "Pardubický kraj"
            },
            new()
            { 
                Code = "32",
                Type = SubdivisionTypes.Region,
                Name = "Plzenský kraj",
                LocalName = "Plzenský kraj"
            },
            new()
            { 
                Code = "10",
                Type = SubdivisionTypes.Region,
                Name = "Praha",
                LocalName = "Praha"
            },
            new()
            { 
                Code = "20",
                Type = SubdivisionTypes.Region,
                Name = "Stredoceský kraj",
                LocalName = "Stredoceský kraj"
            },
            new()
            { 
                Code = "42",
                Type = SubdivisionTypes.Region,
                Name = "Ústecký kraj",
                LocalName = "Ústecký kraj"
            },
            new()
            { 
                Code = "72",
                Type = SubdivisionTypes.Region,
                Name = "Zlínský kraj",
                LocalName = "Zlínský kraj"
            }

        ]);
    }
}
