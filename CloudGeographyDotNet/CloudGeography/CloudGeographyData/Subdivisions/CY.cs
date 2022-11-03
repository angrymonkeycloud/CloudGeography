using AngryMonkey.Cloud.Geography;
namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    private static void FillInSubdivisionsCY()
    {
        AddSubdivisions("CY", new List<Subdivision>()
        {
            new(){ Code ="4", LocalName="Ammochostos", Name="Ammochostos", Type="District" },
            new(){ Code ="6", LocalName="Keryneia", Name="Keryneia", Type="District" },
            new(){ Code ="3", LocalName="Larnaka", Name="Larnaka", Type="District" },
            new(){ Code ="1", LocalName="Lefkosia", Name="Lefkosia", Type="District" },
            new(){ Code ="2", LocalName="Lemesos", Name="Lemesos", Type="District" },
            new(){ Code ="5", LocalName="Pafos", Name="Pafos", Type="District" }

        });
    }
}
