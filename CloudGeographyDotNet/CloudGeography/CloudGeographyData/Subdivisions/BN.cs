using AngryMonkey.Cloud.Geography;
namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    private static void FillInSubdivisionsBN()
    {
        AddSubdivisions("BN", new List<Subdivision>()
        {
            new(){ Code ="BE", LocalName="Belait", Name="Belait", Type="District" },
            new(){ Code ="BM", LocalName="Brunei-Muara", Name="Brunei-Muara", Type="District" },
            new(){ Code ="TE", LocalName="Temburong", Name="Temburong", Type="District" },
            new(){ Code ="TU", LocalName="Tutong", Name="Tutong", Type="District" }

        });
    }
}
