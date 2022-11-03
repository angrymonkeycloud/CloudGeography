using AngryMonkey.Cloud.Geography;
namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    private static void FillInSubdivisionsAD()
    {
        AddSubdivisions("AD", new List<Subdivision>()
        {
            new()
            { 
                Code = "7",
                Type = "Parish",
                Name = "Andorra la Vella",
                LocalName = "Andorra la Vella"
            },
            new()
            { 
                Code = "2",
                Type = "Parish",
                Name = "Canillo",
                LocalName = "Canillo"
            },
            new()
            { 
                Code = "3",
                Type = "Parish",
                Name = "Encamp",
                LocalName = "Encamp"
            },
            new()
            { 
                Code = "8",
                Type = "Parish",
                Name = "Escaldes-Engordany",
                LocalName = "Escaldes-Engordany"
            },
            new()
            { 
                Code = "4",
                Type = "Parish",
                Name = "La Massana",
                LocalName = "La Massana"
            },
            new()
            { 
                Code = "5",
                Type = "Parish",
                Name = "Ordino",
                LocalName = "Ordino"
            },
            new()
            { 
                Code = "6",
                Type = "Parish",
                Name = "Sant Julià de Lòria",
                LocalName = "Sant Julià de Lòria"
            }

        });
    }
}
