using AngryMonkey.Cloud.Geography;
namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    private static void FillInSubdivisionsFM()
    {
        AddSubdivisions("FM", new List<Subdivision>()
        {
            new()
            { 
                Code = "TRK",
                Type = "State",
                Name = "Chuuk",
                LocalName = "Chuuk"
            },
            new()
            { 
                Code = "KSA",
                Type = "State",
                Name = "Kosrae",
                LocalName = "Kosrae"
            },
            new()
            { 
                Code = "PNI",
                Type = "State",
                Name = "Pohnpei",
                LocalName = "Pohnpei"
            },
            new()
            { 
                Code = "YAP",
                Type = "State",
                Name = "Yap",
                LocalName = "Yap"
            }

        });
    }
}
