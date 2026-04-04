using AngryMonkey.Cloud.Geography;
namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    private static void FillInSubdivisionsBB()
    {
        AddSubdivisions("BB",
        [
            new()
            { 
                Code = "1",
                Type = SubdivisionTypes.Parish,
                Name = "Christ Church",
                LocalName = "Christ Church"
            },
            new()
            { 
                Code = "2",
                Type = SubdivisionTypes.Parish,
                Name = "Saint Andrew",
                LocalName = "Saint Andrew"
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
                Name = "Saint James",
                LocalName = "Saint James"
            },
            new()
            { 
                Code = "5",
                Type = SubdivisionTypes.Parish,
                Name = "Saint John",
                LocalName = "Saint John"
            },
            new()
            { 
                Code = "6",
                Type = SubdivisionTypes.Parish,
                Name = "Saint Joseph",
                LocalName = "Saint Joseph"
            },
            new()
            { 
                Code = "7",
                Type = SubdivisionTypes.Parish,
                Name = "Saint Lucy",
                LocalName = "Saint Lucy"
            },
            new()
            { 
                Code = "8",
                Type = SubdivisionTypes.Parish,
                Name = "Saint Michael",
                LocalName = "Saint Michael"
            },
            new()
            { 
                Code = "9",
                Type = SubdivisionTypes.Parish,
                Name = "Saint Peter",
                LocalName = "Saint Peter"
            },
            new()
            { 
                Code = "10",
                Type = SubdivisionTypes.Parish,
                Name = "Saint Philip",
                LocalName = "Saint Philip"
            },
            new()
            { 
                Code = "11",
                Type = SubdivisionTypes.Parish,
                Name = "Saint Thomas",
                LocalName = "Saint Thomas"
            }

        ]);
    }
}
