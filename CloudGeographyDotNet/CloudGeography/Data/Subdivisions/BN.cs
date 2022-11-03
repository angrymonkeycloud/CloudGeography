using AngryMonkey.Cloud.Geography;
namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    private static void FillInSubdivisionsBN()
    {
        AddSubdivisions("BN", new List<Subdivision>()
        {
            new()
            { 
                Code = "BE",
                Type = "District",
                Name = "Belait",
                LocalName = "Belait"
            },
            new()
            { 
                Code = "BM",
                Type = "District",
                Name = "Brunei-Muara",
                LocalName = "Brunei-Muara"
            },
            new()
            { 
                Code = "TE",
                Type = "District",
                Name = "Temburong",
                LocalName = "Temburong"
            },
            new()
            { 
                Code = "TU",
                Type = "District",
                Name = "Tutong",
                LocalName = "Tutong"
            }

        });
    }
}
