using AngryMonkey.Cloud.Geography;
namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    private static void FillInSubdivisionsBQ()
    {
        AddSubdivisions("BQ",
        [
            new()
            { 
                Code = "BO",
                Type = SubdivisionTypes.Municipality,
                Name = "Bonaire",
                LocalName = "Bonaire"
            },
            new()
            { 
                Code = "SA",
                Type = SubdivisionTypes.Municipality,
                Name = "Saba",
                LocalName = "Saba"
            },
            new()
            { 
                Code = "SE",
                Type = SubdivisionTypes.Municipality,
                Name = "Sint Eustatius",
                LocalName = "Sint Eustatius"
            }

        ]);
    }
}
