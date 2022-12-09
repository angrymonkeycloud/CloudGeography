using AngryMonkey.Cloud.Geography;
namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    private static void FillInSubdivisionsAG()
    {
        AddSubdivisions("AG", new List<Subdivision>()
        {
            new()
            { 
                Code = "1",
                Type = "Dependency",
                Name = "Barbuda",
                LocalName = "Barbuda"
            },
            new()
            { 
                Code = "2",
                Type = "Dependency",
                Name = "Redonda",
                LocalName = "Redonda"
            },
            new()
            { 
                Code = "3",
                Type = "Parish",
                Name = "Saint George",
                LocalName = "Saint George"
            },
            new()
            { 
                Code = "4",
                Type = "Parish",
                Name = "Saint John",
                LocalName = "Saint John"
            },
            new()
            { 
                Code = "5",
                Type = "Parish",
                Name = "Saint Mary",
                LocalName = "Saint Mary"
            },
            new()
            { 
                Code = "6",
                Type = "Parish",
                Name = "Saint Paul",
                LocalName = "Saint Paul"
            },
            new()
            { 
                Code = "7",
                Type = "Parish",
                Name = "Saint Peter",
                LocalName = "Saint Peter"
            },
            new()
            { 
                Code = "8",
                Type = "Parish",
                Name = "Saint Philip",
                LocalName = "Saint Philip"
            }

        });
    }
}
