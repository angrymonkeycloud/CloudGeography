using AngryMonkey.Cloud.Geography;
namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    private static void FillInSubdivisionsCY()
    {
        AddSubdivisions("CY",
        [
            new()
            { 
                Code = "4",
                Type = SubdivisionTypes.District,
                Name = "Ammochostos",
                LocalName = "Ammochostos"
            },
            new()
            { 
                Code = "6",
                Type = SubdivisionTypes.District,
                Name = "Keryneia",
                LocalName = "Keryneia"
            },
            new()
            { 
                Code = "3",
                Type = SubdivisionTypes.District,
                Name = "Larnaka",
                LocalName = "Larnaka"
            },
            new()
            { 
                Code = "1",
                Type = SubdivisionTypes.District,
                Name = "Lefkosia",
                LocalName = "Lefkosia"
            },
            new()
            { 
                Code = "2",
                Type = SubdivisionTypes.District,
                Name = "Lemesos",
                LocalName = "Lemesos"
            },
            new()
            { 
                Code = "5",
                Type = SubdivisionTypes.District,
                Name = "Pafos",
                LocalName = "Pafos"
            }

        ]);
    }
}
