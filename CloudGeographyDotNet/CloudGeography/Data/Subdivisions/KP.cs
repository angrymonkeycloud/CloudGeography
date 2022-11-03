using AngryMonkey.Cloud.Geography;
namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    private static void FillInSubdivisionsKP()
    {
        AddSubdivisions("KP", new List<Subdivision>()
        {
            new(){ Code ="4", LocalName="자강도", Name="Chagang", Type="Province" },
            new(){ Code ="7", LocalName="강원도", Name="Kangwon", Type="Province" },
            new(){ Code ="9", LocalName="함경북도", Name="North Hamgyong", Type="Province" },
            new(){ Code ="6", LocalName="황해북도", Name="North Hwanghae", Type="Province" },
            new(){ Code ="3", LocalName="평안남도", Name="North Pyongan", Type="Province" },
            new(){ Code ="1", LocalName="평양시 平壤市", Name="Pyongyang", Type="CapitalCity" },
            new(){ Code ="13", LocalName="라선시", Name="Rason", Type="SpecialCity" },
            new(){ Code ="10", LocalName="량강도", Name="Ryanggang", Type="Province" },
            new(){ Code ="8", LocalName="함경남도", Name="South Hamgyong", Type="Province" },
            new(){ Code ="5", LocalName="황해남도", Name="South Hwanghae", Type="Province" },
            new(){ Code ="2", LocalName="평안남도", Name="South Pyongan", Type="Province" }

        });
    }
}
