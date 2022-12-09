using AngryMonkey.Cloud.Geography;
namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    private static void FillInSubdivisionsCY()
    {
        AddSubdivisions("CY", new List<Subdivision>()
        {
            new()
            { 
                Code = "4",
                Type = "District",
                Name = "Ammochostos",
                LocalName = "Ammochostos"
            },
            new()
            { 
                Code = "6",
                Type = "District",
                Name = "Keryneia",
                LocalName = "Keryneia"
            },
            new()
            { 
                Code = "3",
                Type = "District",
                Name = "Larnaka",
                LocalName = "Larnaka"
            },
            new()
            { 
                Code = "1",
                Type = "District",
                Name = "Lefkosia",
                LocalName = "Lefkosia"
            },
            new()
            { 
                Code = "2",
                Type = "District",
                Name = "Lemesos",
                LocalName = "Lemesos"
            },
            new()
            { 
                Code = "5",
                Type = "District",
                Name = "Pafos",
                LocalName = "Pafos"
            }

        });
    }
}
