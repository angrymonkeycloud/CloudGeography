using AngryMonkey.Cloud.Geography;
namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    private static void FillInSubdivisionsAD()
    {
        AddSubdivisions("AD",
        [
            new()
            { 
                Code = "7",
                Type = SubdivisionTypes.Parish,
                Name = "Andorra la Vella",
                LocalName = "Andorra la Vella"
            },
            new()
            { 
                Code = "2",
                Type = SubdivisionTypes.Parish,
                Name = "Canillo",
                LocalName = "Canillo"
            },
            new()
            { 
                Code = "3",
                Type = SubdivisionTypes.Parish,
                Name = "Encamp",
                LocalName = "Encamp"
            },
            new()
            { 
                Code = "8",
                Type = SubdivisionTypes.Parish,
                Name = "Escaldes-Engordany",
                LocalName = "Escaldes-Engordany"
            },
            new()
            { 
                Code = "4",
                Type = SubdivisionTypes.Parish,
                Name = "La Massana",
                LocalName = "La Massana"
            },
            new()
            { 
                Code = "5",
                Type = SubdivisionTypes.Parish,
                Name = "Ordino",
                LocalName = "Ordino"
            },
            new()
            { 
                Code = "6",
                Type = SubdivisionTypes.Parish,
                Name = "Sant Julià de Lòria",
                LocalName = "Sant Julià de Lòria"
            }

        ]);
    }
}
