using AngryMonkey.Cloud.Geography;
namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    private static void FillInSubdivisionsVC()
    {
        AddSubdivisions("VC",
        [
            new()
            { 
                Code = "1",
                Type = SubdivisionTypes.Parish,
                Name = "Charlotte",
                LocalName = "Charlotte"
            },
            new()
            { 
                Code = "6",
                Type = SubdivisionTypes.Parish,
                Name = "Grenadines",
                LocalName = "Grenadines"
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
                Name = "Saint David",
                LocalName = "Saint David"
            },
            new()
            { 
                Code = "4",
                Type = SubdivisionTypes.Parish,
                Name = "Saint George",
                LocalName = "Saint George"
            },
            new()
            { 
                Code = "5",
                Type = SubdivisionTypes.Parish,
                Name = "Saint Patrick",
                LocalName = "Saint Patrick"
            }

        ]);
    }
}
