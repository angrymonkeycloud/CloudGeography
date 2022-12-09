using AngryMonkey.Cloud.Geography;
namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    private static void FillInSubdivisionsQA()
    {
        AddSubdivisions("QA", new List<Subdivision>()
        {
            new()
            { 
                Code = "DA",
                Type = "Municipality",
                Name = "Ad Dawhah",
                LocalName = "Ad Dawhah"
            },
            new()
            { 
                Code = "KH",
                Type = "Municipality",
                Name = "Al Khawr wa adh Dhakhirah",
                LocalName = "Al Khawr wa adh Dhakhirah"
            },
            new()
            { 
                Code = "WA",
                Type = "Municipality",
                Name = "Al Wakrah",
                LocalName = "Al Wakrah"
            },
            new()
            { 
                Code = "RA",
                Type = "Municipality",
                Name = "Ar Rayyan",
                LocalName = "Ar Rayyan"
            },
            new()
            { 
                Code = "MS",
                Type = "Municipality",
                Name = "Ash Shamal",
                LocalName = "Ash Shamal"
            },
            new()
            { 
                Code = "ZA",
                Type = "Municipality",
                Name = "Az¸ Z¸aayin",
                LocalName = "Az¸ Z¸aayin"
            },
            new()
            { 
                Code = "US",
                Type = "Municipality",
                Name = "Umm Salal",
                LocalName = "Umm Salal"
            }

        });
    }
}
