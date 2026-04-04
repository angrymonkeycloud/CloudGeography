using AngryMonkey.Cloud.Geography;
namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    private static void FillInSubdivisionsBA()
    {
        AddSubdivisions("BA",
        [
            new()
            { 
                Code = "BRC",
                Type = SubdivisionTypes.District,
                Name = "Brčko District",
                LocalName = "Brčko Distrikt"
            },
            new()
            { 
                Code = "BIH",
                Type = SubdivisionTypes.Entity,
                Name = "Federation of Bosnia and Herzegovina",
                LocalName = "Federacija Bosne i Hercegovine"
            },
            new()
            { 
                Code = "SRP",
                Type = SubdivisionTypes.Entity,
                Name = "Republika Srpska",
                LocalName = "Република Српскa"
            }

        ]);
    }
}
