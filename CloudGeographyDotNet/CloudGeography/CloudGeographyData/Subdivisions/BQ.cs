using AngryMonkey.Cloud.Geography;
namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    private static void FillInSubdivisionsBQ()
    {
        AddSubdivisions("BQ", new List<Subdivision>()
        {
            new()
            { 
                Code = "BO",
                Type = "Municipality",
                Name = "Bonaire",
                LocalName = "Bonaire"
            },
            new()
            { 
                Code = "SA",
                Type = "Municipality",
                Name = "Saba",
                LocalName = "Saba"
            },
            new()
            { 
                Code = "SE",
                Type = "Municipality",
                Name = "Sint Eustatius",
                LocalName = "Sint Eustatius"
            }

        });
    }
}
