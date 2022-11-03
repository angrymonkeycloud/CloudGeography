using AngryMonkey.Cloud.Geography;
namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    private static void FillInSubdivisionsGM()
    {
        AddSubdivisions("GM", new List<Subdivision>()
        {
            new(){ Code ="B", LocalName="Banjul", Name="Banjul", Type="City" },
            new(){ Code ="M", LocalName="Central River", Name="Central River", Type="Division" },
            new(){ Code ="L", LocalName="Lower River", Name="Lower River", Type="Division" },
            new(){ Code ="N", LocalName="North Bank", Name="North Bank", Type="Division" },
            new(){ Code ="U", LocalName="Upper River", Name="Upper River", Type="Division" },
            new(){ Code ="W", LocalName="Western", Name="Western", Type="Division" }

        });
    }
}
