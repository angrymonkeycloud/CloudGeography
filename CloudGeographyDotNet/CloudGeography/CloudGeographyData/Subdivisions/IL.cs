using AngryMonkey.Cloud.Geography;
namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    private static void FillInSubdivisionsIL()
    {
        AddSubdivisions("IL", new List<Subdivision>()
        {
            new(){ Code ="M", LocalName="Al Awsat", Name="Al Awsat", Type="District" },
            new(){ Code ="D", LocalName="Al Janubi", Name="Al Janubi", Type="District" },
            new(){ Code ="Z", LocalName="Ash Shamali", Name="Ash Shamali", Type="District" },
            new(){ Code ="HA", LocalName="H_efa", Name="H_efa", Type="District" },
            new(){ Code ="TA", LocalName="Tel-Aviv", Name="Tel-Aviv", Type="District" },
            new(){ Code ="JM", LocalName="Yerushalayim", Name="Yerushalayim", Type="District" }

        });
    }
}
