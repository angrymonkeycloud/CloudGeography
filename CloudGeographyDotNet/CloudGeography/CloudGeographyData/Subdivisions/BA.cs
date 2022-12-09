using AngryMonkey.Cloud.Geography;
namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    private static void FillInSubdivisionsBA()
    {
        AddSubdivisions("BA", new List<Subdivision>()
        {
            new()
            { 
                Code = "BRC",
                Type = "District",
                Name = "Brčko District",
                LocalName = "Brčko Distrikt"
            },
            new()
            { 
                Code = "BIH",
                Type = "Entity",
                Name = "Federation of Bosnia and Herzegovina",
                LocalName = "Federacija Bosne i Hercegovine"
            },
            new()
            { 
                Code = "SRP",
                Type = "Entity",
                Name = "Republika Srpska",
                LocalName = "Република Српскa"
            }

        });
    }
}
