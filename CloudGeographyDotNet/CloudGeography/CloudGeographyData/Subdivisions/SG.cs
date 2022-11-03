using AngryMonkey.Cloud.Geography;
namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    private static void FillInSubdivisionsSG()
    {
        AddSubdivisions("SG", new List<Subdivision>()
        {
            new(){ Code ="1", LocalName="Central Singapore", Name="Central Singapore", Type="District" },
            new(){ Code ="2", LocalName="North East", Name="North East", Type="District" },
            new(){ Code ="3", LocalName="North West", Name="North West", Type="District" },
            new(){ Code ="4", LocalName="South East", Name="South East", Type="District" },
            new(){ Code ="5", LocalName="South West", Name="South West", Type="District" }

        });
    }
}
