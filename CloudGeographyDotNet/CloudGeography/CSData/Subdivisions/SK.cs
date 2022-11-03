using AngryMonkey.Cloud.Geography;
namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    private static void FillInSubdivisionsSK()
    {
        AddSubdivisions("SK", new List<Subdivision>()
        {
            new(){ Code ="ZI", LocalName="ilinský kraj", Name="ilinský kraj", Type="Region" },
            new(){ Code ="BC", LocalName="Banskobystrický kraj", Name="Banskobystrický kraj", Type="Region" },
            new(){ Code ="BL", LocalName="Bratislavský kraj", Name="Bratislavský kraj", Type="Region" },
            new(){ Code ="KI", LocalName="Koický kraj", Name="Koický kraj", Type="Region" },
            new(){ Code ="NI", LocalName="Nitriansky kraj", Name="Nitriansky kraj", Type="Region" },
            new(){ Code ="PV", LocalName="Preovský kraj", Name="Preovský kraj", Type="Region" },
            new(){ Code ="TC", LocalName="Trenciansky kraj", Name="Trenciansky kraj", Type="Region" },
            new(){ Code ="TA", LocalName="Trnavský kraj", Name="Trnavský kraj", Type="Region" }

        });
    }
}
