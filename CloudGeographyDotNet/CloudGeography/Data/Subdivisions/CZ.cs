using AngryMonkey.Cloud.Geography;
namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    private static void FillInSubdivisionsCZ()
    {
        AddSubdivisions("CZ", new List<Subdivision>()
        {
            new()
            { 
                Code = "31",
                Type = "Region",
                Name = "Jihoceský kraj",
                LocalName = "Jihoceský kraj"
            },
            new()
            { 
                Code = "64",
                Type = "Region",
                Name = "Jihomoravský kraj",
                LocalName = "Jihomoravský kraj"
            },
            new()
            { 
                Code = "41",
                Type = "Region",
                Name = "Karlovarský kraj",
                LocalName = "Karlovarský kraj"
            },
            new()
            { 
                Code = "63",
                Type = "Region",
                Name = "Kraj Vysocina",
                LocalName = "Kraj Vysocina"
            },
            new()
            { 
                Code = "52",
                Type = "Region",
                Name = "Královéhradecký kraj",
                LocalName = "Královéhradecký kraj"
            },
            new()
            { 
                Code = "51",
                Type = "Region",
                Name = "Liberecký kraj",
                LocalName = "Liberecký kraj"
            },
            new()
            { 
                Code = "80",
                Type = "Region",
                Name = "Moravskoslezský kraj",
                LocalName = "Moravskoslezský kraj"
            },
            new()
            { 
                Code = "71",
                Type = "Region",
                Name = "Olomoucký kraj",
                LocalName = "Olomoucký kraj"
            },
            new()
            { 
                Code = "53",
                Type = "Region",
                Name = "Pardubický kraj",
                LocalName = "Pardubický kraj"
            },
            new()
            { 
                Code = "32",
                Type = "Region",
                Name = "Plzenský kraj",
                LocalName = "Plzenský kraj"
            },
            new()
            { 
                Code = "10",
                Type = "Region",
                Name = "Praha",
                LocalName = "Praha"
            },
            new()
            { 
                Code = "20",
                Type = "Region",
                Name = "Stredoceský kraj",
                LocalName = "Stredoceský kraj"
            },
            new()
            { 
                Code = "42",
                Type = "Region",
                Name = "Ústecký kraj",
                LocalName = "Ústecký kraj"
            },
            new()
            { 
                Code = "72",
                Type = "Region",
                Name = "Zlínský kraj",
                LocalName = "Zlínský kraj"
            }

        });
    }
}
