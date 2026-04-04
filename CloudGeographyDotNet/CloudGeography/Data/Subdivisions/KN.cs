using AngryMonkey.Cloud.Geography;
namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    private static void FillInSubdivisionsKN()
    {
        AddSubdivisions("KN",
        [
            new()
            { 
                Code = "1",
                Type = SubdivisionTypes.Parish,
                Name = "Christ Church Nichola Town",
                LocalName = "Christ Church Nichola Town"
            },
            new()
            { 
                Code = "2",
                Type = SubdivisionTypes.Parish,
                Name = "Saint Anne Sandy Point",
                LocalName = "Saint Anne Sandy Point"
            },
            new()
            { 
                Code = "3",
                Type = SubdivisionTypes.Parish,
                Name = "Saint George Basseterre",
                LocalName = "Saint George Basseterre"
            },
            new()
            { 
                Code = "4",
                Type = SubdivisionTypes.Parish,
                Name = "Saint George Gingerland",
                LocalName = "Saint George Gingerland"
            },
            new()
            { 
                Code = "5",
                Type = SubdivisionTypes.Parish,
                Name = "Saint James Windward",
                LocalName = "Saint James Windward"
            },
            new()
            { 
                Code = "6",
                Type = SubdivisionTypes.Parish,
                Name = "Saint John Capisterre",
                LocalName = "Saint John Capisterre"
            },
            new()
            { 
                Code = "7",
                Type = SubdivisionTypes.Parish,
                Name = "Saint John Figtree",
                LocalName = "Saint John Figtree"
            },
            new()
            { 
                Code = "8",
                Type = SubdivisionTypes.Parish,
                Name = "Saint Mary Cayon",
                LocalName = "Saint Mary Cayon"
            },
            new()
            { 
                Code = "9",
                Type = SubdivisionTypes.Parish,
                Name = "Saint Paul Capisterre",
                LocalName = "Saint Paul Capisterre"
            },
            new()
            { 
                Code = "10",
                Type = SubdivisionTypes.Parish,
                Name = "Saint Paul Charlestown",
                LocalName = "Saint Paul Charlestown"
            },
            new()
            { 
                Code = "11",
                Type = SubdivisionTypes.Parish,
                Name = "Saint Peter Basseterre",
                LocalName = "Saint Peter Basseterre"
            },
            new()
            { 
                Code = "12",
                Type = SubdivisionTypes.Parish,
                Name = "Saint Thomas Lowland",
                LocalName = "Saint Thomas Lowland"
            },
            new()
            { 
                Code = "13",
                Type = SubdivisionTypes.Parish,
                Name = "Saint Thomas Middle Island",
                LocalName = "Saint Thomas Middle Island"
            },
            new()
            { 
                Code = "15",
                Type = SubdivisionTypes.Parish,
                Name = "Trinity Palmetto Point",
                LocalName = "Trinity Palmetto Point"
            }

        ]);
    }
}
