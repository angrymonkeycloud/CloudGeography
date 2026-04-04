using AngryMonkey.Cloud.Geography;
namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    private static void FillInSubdivisionsPT()
    {
        AddSubdivisions("PT",
        [
            new()
            { 
                Code = "1",
                Type = SubdivisionTypes.District,
                Name = "Aveiro",
                LocalName = "Aveiro"
            },
            new()
            { 
                Code = "2",
                Type = SubdivisionTypes.District,
                Name = "Beja",
                LocalName = "Beja"
            },
            new()
            { 
                Code = "3",
                Type = SubdivisionTypes.District,
                Name = "Braga",
                LocalName = "Braga"
            },
            new()
            { 
                Code = "4",
                Type = SubdivisionTypes.District,
                Name = "Bragança",
                LocalName = "Bragança"
            },
            new()
            { 
                Code = "5",
                Type = SubdivisionTypes.District,
                Name = "Castelo Branco",
                LocalName = "Castelo Branco"
            },
            new()
            { 
                Code = "6",
                Type = SubdivisionTypes.District,
                Name = "Coimbra",
                LocalName = "Coimbra"
            },
            new()
            { 
                Code = "7",
                Type = SubdivisionTypes.District,
                Name = "Évora",
                LocalName = "Évora"
            },
            new()
            { 
                Code = "8",
                Type = SubdivisionTypes.District,
                Name = "Faro",
                LocalName = "Faro"
            },
            new()
            { 
                Code = "9",
                Type = SubdivisionTypes.District,
                Name = "Guarda",
                LocalName = "Guarda"
            },
            new()
            { 
                Code = "10",
                Type = SubdivisionTypes.District,
                Name = "Leiria",
                LocalName = "Leiria"
            },
            new()
            { 
                Code = "11",
                Type = SubdivisionTypes.District,
                Name = "Lisboa",
                LocalName = "Lisboa"
            },
            new()
            { 
                Code = "12",
                Type = SubdivisionTypes.District,
                Name = "Portalegre",
                LocalName = "Portalegre"
            },
            new()
            { 
                Code = "13",
                Type = SubdivisionTypes.District,
                Name = "Porto",
                LocalName = "Porto"
            },
            new()
            { 
                Code = "30",
                Type = SubdivisionTypes.Region,
                Name = "Região Autónoma da Madeira",
                LocalName = "Região Autónoma da Madeira"
            },
            new()
            { 
                Code = "20",
                Type = SubdivisionTypes.Region,
                Name = "Região Autónoma dos Açores",
                LocalName = "Região Autónoma dos Açores"
            },
            new()
            { 
                Code = "14",
                Type = SubdivisionTypes.District,
                Name = "Santarém",
                LocalName = "Santarém"
            },
            new()
            { 
                Code = "15",
                Type = SubdivisionTypes.District,
                Name = "Setúbal",
                LocalName = "Setúbal"
            },
            new()
            { 
                Code = "16",
                Type = SubdivisionTypes.District,
                Name = "Viana do Castelo",
                LocalName = "Viana do Castelo"
            },
            new()
            { 
                Code = "17",
                Type = SubdivisionTypes.District,
                Name = "Vila Real",
                LocalName = "Vila Real"
            },
            new()
            { 
                Code = "18",
                Type = SubdivisionTypes.District,
                Name = "Viseu",
                LocalName = "Viseu"
            }

        ]);
    }
}
