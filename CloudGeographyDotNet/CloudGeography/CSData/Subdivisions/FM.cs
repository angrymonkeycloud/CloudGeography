using AngryMonkey.Cloud.Geography;
namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    private static void FillInSubdivisionsFM()
    {
        AddSubdivisions("FM", new List<Subdivision>()
        {
            new(){ Code ="TRK", LocalName="Chuuk", Name="Chuuk", Type="State" },
            new(){ Code ="KSA", LocalName="Kosrae", Name="Kosrae", Type="State" },
            new(){ Code ="PNI", LocalName="Pohnpei", Name="Pohnpei", Type="State" },
            new(){ Code ="YAP", LocalName="Yap", Name="Yap", Type="State" }

        });
    }
}
