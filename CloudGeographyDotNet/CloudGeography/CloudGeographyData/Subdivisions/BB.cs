using AngryMonkey.Cloud.Geography;
namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    private static void FillInSubdivisionsBB()
    {
        AddSubdivisions("BB", new List<Subdivision>()
        {
            new()
            { 
                Code = "1",
                Type = "Parish",
                Name = "Christ Church",
                LocalName = "Christ Church"
            },
            new()
            { 
                Code = "2",
                Type = "Parish",
                Name = "Saint Andrew",
                LocalName = "Saint Andrew"
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
                Name = "Saint James",
                LocalName = "Saint James"
            },
            new()
            { 
                Code = "5",
                Type = "Parish",
                Name = "Saint John",
                LocalName = "Saint John"
            },
            new()
            { 
                Code = "6",
                Type = "Parish",
                Name = "Saint Joseph",
                LocalName = "Saint Joseph"
            },
            new()
            { 
                Code = "7",
                Type = "Parish",
                Name = "Saint Lucy",
                LocalName = "Saint Lucy"
            },
            new()
            { 
                Code = "8",
                Type = "Parish",
                Name = "Saint Michael",
                LocalName = "Saint Michael"
            },
            new()
            { 
                Code = "9",
                Type = "Parish",
                Name = "Saint Peter",
                LocalName = "Saint Peter"
            },
            new()
            { 
                Code = "10",
                Type = "Parish",
                Name = "Saint Philip",
                LocalName = "Saint Philip"
            },
            new()
            { 
                Code = "11",
                Type = "Parish",
                Name = "Saint Thomas",
                LocalName = "Saint Thomas"
            }

        });
    }
}
