using AngryMonkey.Cloud.Geography;
namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    private static void FillInSubdivisionsTL()
    {
        AddSubdivisions("TL",
        [
            new()
            { 
                Code = "AL",
                Type = SubdivisionTypes.District,
                Name = "Aileu",
                LocalName = "Aileu"
            },
            new()
            { 
                Code = "AN",
                Type = SubdivisionTypes.District,
                Name = "Ainaro",
                LocalName = "Ainaro"
            },
            new()
            { 
                Code = "BA",
                Type = SubdivisionTypes.District,
                Name = "Baucau",
                LocalName = "Baucau"
            },
            new()
            { 
                Code = "BO",
                Type = SubdivisionTypes.District,
                Name = "Bobonaro",
                LocalName = "Bobonaro"
            },
            new()
            { 
                Code = "CO",
                Type = SubdivisionTypes.District,
                Name = "Cova Lima",
                LocalName = "Cova Lima"
            },
            new()
            { 
                Code = "DI",
                Type = SubdivisionTypes.District,
                Name = "Díli",
                LocalName = "Díli"
            },
            new()
            { 
                Code = "ER",
                Type = SubdivisionTypes.District,
                Name = "Ermera",
                LocalName = "Ermera"
            },
            new()
            { 
                Code = "LA",
                Type = SubdivisionTypes.District,
                Name = "Lautem",
                LocalName = "Lautem"
            },
            new()
            { 
                Code = "LI",
                Type = SubdivisionTypes.District,
                Name = "Liquiça",
                LocalName = "Liquiça"
            },
            new()
            { 
                Code = "MT",
                Type = SubdivisionTypes.District,
                Name = "Manatuto",
                LocalName = "Manatuto"
            },
            new()
            { 
                Code = "MF",
                Type = SubdivisionTypes.District,
                Name = "Manufahi",
                LocalName = "Manufahi"
            },
            new()
            { 
                Code = "OE",
                Type = SubdivisionTypes.District,
                Name = "Oecussi",
                LocalName = "Oecussi"
            },
            new()
            { 
                Code = "VI",
                Type = SubdivisionTypes.District,
                Name = "Viqueque",
                LocalName = "Viqueque"
            }

        ]);
    }
}
