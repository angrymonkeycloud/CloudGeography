using AngryMonkey.Cloud.Geography;
namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    private static void FillInSubdivisionsGD()
    {
        AddSubdivisions("GD",
        [
            new()
            { 
                Code = "1",
                Type = SubdivisionTypes.Parish,
                Name = "Saint Andrew",
                LocalName = "Saint Andrew"
            },
            new()
            { 
                Code = "2",
                Type = SubdivisionTypes.Parish,
                Name = "Saint David",
                LocalName = "Saint David"
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
                Name = "Saint Mark",
                LocalName = "Saint Mark"
            },
            new()
            { 
                Code = "6",
                Type = SubdivisionTypes.Parish,
                Name = "Saint Patrick",
                LocalName = "Saint Patrick"
            },
            new()
            { 
                Code = "10",
                Type = SubdivisionTypes.Dependency,
                Name = "Southern Grenadine Islands",
                LocalName = "Southern Grenadine Islands"
            }

        ]);
    }
}
