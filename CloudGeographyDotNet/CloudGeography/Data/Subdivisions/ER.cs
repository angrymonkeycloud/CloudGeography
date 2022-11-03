using AngryMonkey.Cloud.Geography;
namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    private static void FillInSubdivisionsER()
    {
        AddSubdivisions("ER", new List<Subdivision>()
        {
            new(){ Code ="AN", LocalName="Anseba", Name="Anseba", Type="Region" },
            new(){ Code ="DU", LocalName="Debub", Name="Debub", Type="Region" },
            new(){ Code ="DK", LocalName="Debubawi Keyyi? Ba?ri", Name="Debubawi Keyyi? Ba?ri", Type="Region" },
            new(){ Code ="GB", LocalName="Gash-Barka", Name="Gash-Barka", Type="Region" },
            new(){ Code ="MA", LocalName="Maikel", Name="Maikel", Type="Region" },
            new(){ Code ="SK", LocalName="Semienawi Keyyi? Ba?ri", Name="Semienawi Keyyi? Ba?ri", Type="Region" }

        });
    }
}
