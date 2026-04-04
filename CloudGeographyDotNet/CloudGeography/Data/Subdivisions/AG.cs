using AngryMonkey.Cloud.Geography;
namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    private static void FillInSubdivisionsAG()
    {
        AddSubdivisions("AG",
        [
            new()
            { 
                Code = "1",
                Type = SubdivisionTypes.Dependency,
                Name = "Barbuda",
                LocalName = "Barbuda"
            },
            new()
            { 
                Code = "2",
                Type = SubdivisionTypes.Dependency,
                Name = "Redonda",
                LocalName = "Redonda"
            },
            new()
            { 
                Code = "3",
                Type = SubdivisionTypes.Parish,
                Name = "Saint George",
                LocalName = "Saint George"
            },
            new()
            { 
                Code = "4",
                Type = SubdivisionTypes.Parish,
                Name = "Saint John",
                LocalName = "Saint John"
            },
            new()
            { 
                Code = "5",
                Type = SubdivisionTypes.Parish,
                Name = "Saint Mary",
                LocalName = "Saint Mary"
            },
            new()
            { 
                Code = "6",
                Type = SubdivisionTypes.Parish,
                Name = "Saint Paul",
                LocalName = "Saint Paul"
            },
            new()
            { 
                Code = "7",
                Type = SubdivisionTypes.Parish,
                Name = "Saint Peter",
                LocalName = "Saint Peter"
            },
            new()
            { 
                Code = "8",
                Type = SubdivisionTypes.Parish,
                Name = "Saint Philip",
                LocalName = "Saint Philip"
            }

        ]);
    }
}
