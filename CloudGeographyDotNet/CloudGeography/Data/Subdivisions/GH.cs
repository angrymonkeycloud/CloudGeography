using AngryMonkey.Cloud.Geography;
namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    private static void FillInSubdivisionsGH()
    {
        AddSubdivisions("GH", new List<Subdivision>()
        {
            new(){ Code ="AH", LocalName="Ashanti", Name="Ashanti", Type="Region" },
            new(){ Code ="BA", LocalName="Brong-Ahafo", Name="Brong-Ahafo", Type="Region" },
            new(){ Code ="CP", LocalName="Central", Name="Central", Type="Region" },
            new(){ Code ="EP", LocalName="Eastern", Name="Eastern", Type="Region" },
            new(){ Code ="AA", LocalName="Greater Accra", Name="Greater Accra", Type="Region" },
            new(){ Code ="NP", LocalName="Northern", Name="Northern", Type="Region" },
            new(){ Code ="UE", LocalName="Upper East", Name="Upper East", Type="Region" },
            new(){ Code ="UW", LocalName="Upper West", Name="Upper West", Type="Region" },
            new(){ Code ="TV", LocalName="Volta", Name="Volta", Type="Region" },
            new(){ Code ="WP", LocalName="Western", Name="Western", Type="Region" }

        });
    }
}
