using AngryMonkey.Cloud.Geography;
namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    private static void FillInSubdivisionsTL()
    {
        AddSubdivisions("TL", new List<Subdivision>()
        {
            new()
            { 
                Code = "AL",
                Type = "District",
                Name = "Aileu",
                LocalName = "Aileu"
            },
            new()
            { 
                Code = "AN",
                Type = "District",
                Name = "Ainaro",
                LocalName = "Ainaro"
            },
            new()
            { 
                Code = "BA",
                Type = "District",
                Name = "Baucau",
                LocalName = "Baucau"
            },
            new()
            { 
                Code = "BO",
                Type = "District",
                Name = "Bobonaro",
                LocalName = "Bobonaro"
            },
            new()
            { 
                Code = "CO",
                Type = "District",
                Name = "Cova Lima",
                LocalName = "Cova Lima"
            },
            new()
            { 
                Code = "DI",
                Type = "District",
                Name = "Díli",
                LocalName = "Díli"
            },
            new()
            { 
                Code = "ER",
                Type = "District",
                Name = "Ermera",
                LocalName = "Ermera"
            },
            new()
            { 
                Code = "LA",
                Type = "District",
                Name = "Lautem",
                LocalName = "Lautem"
            },
            new()
            { 
                Code = "LI",
                Type = "District",
                Name = "Liquiça",
                LocalName = "Liquiça"
            },
            new()
            { 
                Code = "MT",
                Type = "District",
                Name = "Manatuto",
                LocalName = "Manatuto"
            },
            new()
            { 
                Code = "MF",
                Type = "District",
                Name = "Manufahi",
                LocalName = "Manufahi"
            },
            new()
            { 
                Code = "OE",
                Type = "District",
                Name = "Oecussi",
                LocalName = "Oecussi"
            },
            new()
            { 
                Code = "VI",
                Type = "District",
                Name = "Viqueque",
                LocalName = "Viqueque"
            }

        });
    }
}
