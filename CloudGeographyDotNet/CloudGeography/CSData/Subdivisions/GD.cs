using AngryMonkey.Cloud.Geography;
namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    private static void FillInSubdivisionsGD()
    {
        AddSubdivisions("GD", new List<Subdivision>()
        {
            new(){ Code ="1", LocalName="Saint Andrew", Name="Saint Andrew", Type="Parish" },
            new(){ Code ="2", LocalName="Saint David", Name="Saint David", Type="Parish" },
            new(){ Code ="3", LocalName="Saint George", Name="Saint George", Type="Parish" },
            new(){ Code ="4", LocalName="Saint John", Name="Saint John", Type="Parish" },
            new(){ Code ="5", LocalName="Saint Mark", Name="Saint Mark", Type="Parish" },
            new(){ Code ="6", LocalName="Saint Patrick", Name="Saint Patrick", Type="Parish" },
            new(){ Code ="10", LocalName="Southern Grenadine Islands", Name="Southern Grenadine Islands", Type="Dependency" }

        });
    }
}
