using AngryMonkey.Cloud.Geography;
namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    private static void FillInSubdivisionsVC()
    {
        AddSubdivisions("VC", new List<Subdivision>()
        {
            new()
            { 
                Code = "1",
                Type = "Parish",
                Name = "Charlotte",
                LocalName = "Charlotte"
            },
            new()
            { 
                Code = "6",
                Type = "Parish",
                Name = "Grenadines",
                LocalName = "Grenadines"
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
                Name = "Saint Patrick",
                LocalName = "Saint Patrick"
            }

        });
    }
}
