using AngryMonkey.Cloud.Geography;
namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    private static void FillInSubdivisionsET()
    {
        AddSubdivisions("ET", new List<Subdivision>()
        {
            new(){ Code ="AF", LocalName="Afar", Name="Afar", Type="State" },
            new(){ Code ="AM", LocalName="Amara", Name="Amara", Type="State" },
            new(){ Code ="BE", LocalName="Binshangul Gumuz", Name="Binshangul Gumuz", Type="State" },
            new(){ Code ="GA", LocalName="Gambela Hizboch", Name="Gambela Hizboch", Type="State" },
            new(){ Code ="HA", LocalName="Hareri Hizb", Name="Hareri Hizb", Type="State" },
            new(){ Code ="OR", LocalName="Oromiya", Name="Oromiya", Type="State" },
            new(){ Code ="SO", LocalName="Sumale", Name="Sumale", Type="State" },
            new(){ Code ="TI", LocalName="Tigray", Name="Tigray", Type="State" },
            new(){ Code ="SN", LocalName="YeDebub Biheroch Bihereseboch na Hizboch", Name="YeDebub Biheroch Bihereseboch na Hizboch", Type="State" }

        });
    }
}
