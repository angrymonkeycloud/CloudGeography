using AngryMonkey.Cloud.Geography;
namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    private static void FillInSubdivisionsVC()
    {
        AddSubdivisions("VC", new List<Subdivision>()
        {
            new(){ Code ="1", LocalName="Charlotte", Name="Charlotte", Type="Parish" },
            new(){ Code ="6", LocalName="Grenadines", Name="Grenadines", Type="Parish" },
            new(){ Code ="2", LocalName="Saint Andrew", Name="Saint Andrew", Type="Parish" },
            new(){ Code ="3", LocalName="Saint David", Name="Saint David", Type="Parish" },
            new(){ Code ="4", LocalName="Saint George", Name="Saint George", Type="Parish" },
            new(){ Code ="5", LocalName="Saint Patrick", Name="Saint Patrick", Type="Parish" }

        });
    }
}
