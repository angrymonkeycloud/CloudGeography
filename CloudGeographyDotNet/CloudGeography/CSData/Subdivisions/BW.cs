using AngryMonkey.Cloud.Geography;
namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    private static void FillInSubdivisionsBW()
    {
        AddSubdivisions("BW", new List<Subdivision>()
        {
            new(){ Code ="CE", LocalName="Central", Name="Central", Type="District" },
            new(){ Code ="CH", LocalName="Chobe", Name="Chobe", Type="District" },
            new(){ Code ="GH", LocalName="Ghanzi", Name="Ghanzi", Type="District" },
            new(){ Code ="KG", LocalName="Kgalagadi", Name="Kgalagadi", Type="District" },
            new(){ Code ="KL", LocalName="Kgatleng", Name="Kgatleng", Type="District" },
            new(){ Code ="KW", LocalName="Kweneng", Name="Kweneng", Type="District" },
            new(){ Code ="NE", LocalName="North East", Name="North East", Type="District" },
            new(){ Code ="NW", LocalName="North West", Name="North West", Type="District" },
            new(){ Code ="SE", LocalName="South East", Name="South East", Type="District" },
            new(){ Code ="SO", LocalName="Southern", Name="Southern", Type="District" }

        });
    }
}
