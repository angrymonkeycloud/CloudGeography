using AngryMonkey.Cloud.Geography;
namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    private static void FillInSubdivisionsDK()
    {
        AddSubdivisions("DK", new List<Subdivision>()
        {
            new(){ Code ="84", LocalName="Hovedstaden", Name="Hovedstaden", Type="Region" },
            new(){ Code ="82", LocalName="Midtjylland", Name="Midtjylland", Type="Region" },
            new(){ Code ="81", LocalName="Nordjylland", Name="Nordjylland", Type="Region" },
            new(){ Code ="85", LocalName="Sjælland", Name="Sjælland", Type="Region" },
            new(){ Code ="83", LocalName="Syddanmark", Name="Syddanmark", Type="Region" }

        });
    }
}
