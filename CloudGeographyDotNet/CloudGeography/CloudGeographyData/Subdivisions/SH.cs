using AngryMonkey.Cloud.Geography;
namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    private static void FillInSubdivisionsSH()
    {
        AddSubdivisions("SH", new List<Subdivision>()
        {
            new()
            { 
                Code = "AC",
                Type = "Entity",
                Name = "Ascension",
                LocalName = "Ascension"
            },
            new()
            { 
                Code = "HL",
                Type = "Entity",
                Name = "Saint Helena",
                LocalName = "Saint Helena"
            },
            new()
            { 
                Code = "TA",
                Type = "Entity",
                Name = "Tristan da Cunha",
                LocalName = "Tristan da Cunha"
            }

        });
    }
}
