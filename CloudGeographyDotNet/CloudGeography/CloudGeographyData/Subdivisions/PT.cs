using AngryMonkey.Cloud.Geography;
namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    private static void FillInSubdivisionsPT()
    {
        AddSubdivisions("PT", new List<Subdivision>()
        {
            new()
            { 
                Code = "1",
                Type = "District",
                Name = "Aveiro",
                LocalName = "Aveiro"
            },
            new()
            { 
                Code = "2",
                Type = "District",
                Name = "Beja",
                LocalName = "Beja"
            },
            new()
            { 
                Code = "3",
                Type = "District",
                Name = "Braga",
                LocalName = "Braga"
            },
            new()
            { 
                Code = "4",
                Type = "District",
                Name = "Bragança",
                LocalName = "Bragança"
            },
            new()
            { 
                Code = "5",
                Type = "District",
                Name = "Castelo Branco",
                LocalName = "Castelo Branco"
            },
            new()
            { 
                Code = "6",
                Type = "District",
                Name = "Coimbra",
                LocalName = "Coimbra"
            },
            new()
            { 
                Code = "7",
                Type = "District",
                Name = "Évora",
                LocalName = "Évora"
            },
            new()
            { 
                Code = "8",
                Type = "District",
                Name = "Faro",
                LocalName = "Faro"
            },
            new()
            { 
                Code = "9",
                Type = "District",
                Name = "Guarda",
                LocalName = "Guarda"
            },
            new()
            { 
                Code = "10",
                Type = "District",
                Name = "Leiria",
                LocalName = "Leiria"
            },
            new()
            { 
                Code = "11",
                Type = "District",
                Name = "Lisboa",
                LocalName = "Lisboa"
            },
            new()
            { 
                Code = "12",
                Type = "District",
                Name = "Portalegre",
                LocalName = "Portalegre"
            },
            new()
            { 
                Code = "13",
                Type = "District",
                Name = "Porto",
                LocalName = "Porto"
            },
            new()
            { 
                Code = "30",
                Type = "Region",
                Name = "Região Autónoma da Madeira",
                LocalName = "Região Autónoma da Madeira"
            },
            new()
            { 
                Code = "20",
                Type = "Region",
                Name = "Região Autónoma dos Açores",
                LocalName = "Região Autónoma dos Açores"
            },
            new()
            { 
                Code = "14",
                Type = "District",
                Name = "Santarém",
                LocalName = "Santarém"
            },
            new()
            { 
                Code = "15",
                Type = "District",
                Name = "Setúbal",
                LocalName = "Setúbal"
            },
            new()
            { 
                Code = "16",
                Type = "District",
                Name = "Viana do Castelo",
                LocalName = "Viana do Castelo"
            },
            new()
            { 
                Code = "17",
                Type = "District",
                Name = "Vila Real",
                LocalName = "Vila Real"
            },
            new()
            { 
                Code = "18",
                Type = "District",
                Name = "Viseu",
                LocalName = "Viseu"
            }

        });
    }
}
