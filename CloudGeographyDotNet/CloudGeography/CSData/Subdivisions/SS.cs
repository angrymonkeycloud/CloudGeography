using AngryMonkey.Cloud.Geography;
namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    private static void FillInSubdivisionsSS()
    {
        AddSubdivisions("SS", new List<Subdivision>()
        {
            new(){ Code ="EC", LocalName="Central Equatoria", Name="Central Equatoria", Type="State" },
            new(){ Code ="EE", LocalName="Eastern Equatoria", Name="Eastern Equatoria", Type="State" },
            new(){ Code ="JG", LocalName="Jonglei", Name="Jonglei", Type="State" },
            new(){ Code ="LK", LocalName="Lakes", Name="Lakes", Type="State" },
            new(){ Code ="BN", LocalName="Northern Bahr el Ghazal", Name="Northern Bahr el Ghazal", Type="State" },
            new(){ Code ="UY", LocalName="Unity", Name="Unity", Type="State" },
            new(){ Code ="NU", LocalName="Upper Nile", Name="Upper Nile", Type="State" },
            new(){ Code ="WR", LocalName="Warrap", Name="Warrap", Type="State" },
            new(){ Code ="BW", LocalName="Western Bahr el Ghazal", Name="Western Bahr el Ghazal", Type="State" },
            new(){ Code ="EW", LocalName="Western Equatoria", Name="Western Equatoria", Type="State" }

        });
    }
}
