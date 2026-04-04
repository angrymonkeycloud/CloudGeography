using AngryMonkey.Cloud.Geography;
namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    private static void FillInSubdivisionsRW()
    {
        AddSubdivisions("RW",
        [
            new()
            { 
                Code = "2",
                Type = SubdivisionTypes.Province,
                Name = "Est",
                LocalName = "Est"
            },
            new()
            { 
                Code = "3",
                Type = SubdivisionTypes.Province,
                Name = "Nord",
                LocalName = "Nord"
            },
            new()
            { 
                Code = "4",
                Type = SubdivisionTypes.Province,
                Name = "Ouest",
                LocalName = "Ouest"
            },
            new()
            { 
                Code = "5",
                Type = SubdivisionTypes.Province,
                Name = "Sud",
                LocalName = "Sud"
            },
            new()
            { 
                Code = "1",
                Type = SubdivisionTypes.City,
                Name = "Ville de Kigali",
                LocalName = "Ville de Kigali"
            }

        ]);
    }
}
