using AngryMonkey.Cloud.Geography;
namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    private static void FillInSubdivisionsBN()
    {
        AddSubdivisions("BN",
        [
            new()
            { 
                Code = "BE",
                Type = SubdivisionTypes.District,
                Name = "Belait",
                LocalName = "Belait"
            },
            new()
            { 
                Code = "BM",
                Type = SubdivisionTypes.District,
                Name = "Brunei-Muara",
                LocalName = "Brunei-Muara"
            },
            new()
            { 
                Code = "TE",
                Type = SubdivisionTypes.District,
                Name = "Temburong",
                LocalName = "Temburong"
            },
            new()
            { 
                Code = "TU",
                Type = SubdivisionTypes.District,
                Name = "Tutong",
                LocalName = "Tutong"
            }

        ]);
    }
}
