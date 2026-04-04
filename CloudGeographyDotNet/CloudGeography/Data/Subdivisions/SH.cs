using AngryMonkey.Cloud.Geography;
namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    private static void FillInSubdivisionsSH()
    {
        AddSubdivisions("SH",
        [
            new()
            { 
                Code = "AC",
                Type = SubdivisionTypes.Entity,
                Name = "Ascension",
                LocalName = "Ascension"
            },
            new()
            { 
                Code = "HL",
                Type = SubdivisionTypes.Entity,
                Name = "Saint Helena",
                LocalName = "Saint Helena"
            },
            new()
            { 
                Code = "TA",
                Type = SubdivisionTypes.Entity,
                Name = "Tristan da Cunha",
                LocalName = "Tristan da Cunha"
            }

        ]);
    }
}
