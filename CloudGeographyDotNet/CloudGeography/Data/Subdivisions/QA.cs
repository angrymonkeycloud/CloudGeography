using AngryMonkey.Cloud.Geography;
namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    private static void FillInSubdivisionsQA()
    {
        AddSubdivisions("QA",
        [
            new()
            { 
                Code = "DA",
                Type = SubdivisionTypes.Municipality,
                Name = "Ad Dawhah",
                LocalName = "Ad Dawhah"
            },
            new()
            { 
                Code = "KH",
                Type = SubdivisionTypes.Municipality,
                Name = "Al Khawr wa adh Dhakhirah",
                LocalName = "Al Khawr wa adh Dhakhirah"
            },
            new()
            { 
                Code = "WA",
                Type = SubdivisionTypes.Municipality,
                Name = "Al Wakrah",
                LocalName = "Al Wakrah"
            },
            new()
            { 
                Code = "RA",
                Type = SubdivisionTypes.Municipality,
                Name = "Ar Rayyan",
                LocalName = "Ar Rayyan"
            },
            new()
            { 
                Code = "MS",
                Type = SubdivisionTypes.Municipality,
                Name = "Ash Shamal",
                LocalName = "Ash Shamal"
            },
            new()
            { 
                Code = "ZA",
                Type = SubdivisionTypes.Municipality,
                Name = "Az¸ Z¸aayin",
                LocalName = "Az¸ Z¸aayin"
            },
            new()
            { 
                Code = "US",
                Type = SubdivisionTypes.Municipality,
                Name = "Umm Salal",
                LocalName = "Umm Salal"
            }

        ]);
    }
}
