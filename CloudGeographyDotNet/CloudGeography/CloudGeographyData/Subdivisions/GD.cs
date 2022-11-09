using AngryMonkey.Cloud.Geography;
namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    private static void FillInSubdivisionsGD()
    {
        AddSubdivisions("GD", new List<Subdivision>()
        {
            new()
            { 
                Code = "1",
                Type = "Parish",
                Name = "Saint Andrew",
                LocalName = "Saint Andrew"
            },
            new()
            { 
                Code = "2",
                Type = "Parish",
                Name = "Saint David",
                LocalName = "Saint David"
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
                Name = "Saint Mark",
                LocalName = "Saint Mark"
            },
            new()
            { 
                Code = "6",
                Type = "Parish",
                Name = "Saint Patrick",
                LocalName = "Saint Patrick"
            },
            new()
            { 
                Code = "10",
                Type = "Dependency",
                Name = "Southern Grenadine Islands",
                LocalName = "Southern Grenadine Islands"
            }

        });
    }
}
