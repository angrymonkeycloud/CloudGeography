using AngryMonkey.Cloud.Geography;
namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    private static void FillInSubdivisionsDM()
    {
        AddSubdivisions("DM", new List<Subdivision>()
        {
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
                Name = "Saint David",
                LocalName = "Saint David"
            },
            new()
            { 
                Code = "4",
                Type = "Parish",
                Name = "Saint George",
                LocalName = "Saint George"
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
                Name = "Saint Luke",
                LocalName = "Saint Luke"
            },
            new()
            { 
                Code = "8",
                Type = "Parish",
                Name = "Saint Mark",
                LocalName = "Saint Mark"
            },
            new()
            { 
                Code = "9",
                Type = "Parish",
                Name = "Saint Patrick",
                LocalName = "Saint Patrick"
            },
            new()
            { 
                Code = "10",
                Type = "Parish",
                Name = "Saint Paul",
                LocalName = "Saint Paul"
            },
            new()
            { 
                Code = "11",
                Type = "Parish",
                Name = "Saint Peter",
                LocalName = "Saint Peter"
            }

        });
    }
}
