using AngryMonkey.Cloud.Geography;
namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    private static void FillInSubdivisionsFM()
    {
        AddSubdivisions("FM",
        [
            new()
            { 
                Code = "TRK",
                Type = SubdivisionTypes.State,
                Name = "Chuuk",
                LocalName = "Chuuk"
            },
            new()
            { 
                Code = "KSA",
                Type = SubdivisionTypes.State,
                Name = "Kosrae",
                LocalName = "Kosrae"
            },
            new()
            { 
                Code = "PNI",
                Type = SubdivisionTypes.State,
                Name = "Pohnpei",
                LocalName = "Pohnpei"
            },
            new()
            { 
                Code = "YAP",
                Type = SubdivisionTypes.State,
                Name = "Yap",
                LocalName = "Yap"
            }

        ]);
    }
}
