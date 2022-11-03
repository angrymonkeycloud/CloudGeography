using AngryMonkey.Cloud.Geography;
namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    private static void FillInSubdivisionsAU()
    {
        AddSubdivisions("AU", new List<Subdivision>()
        {
            new(){ Code ="ACT", LocalName="Australian Capital Territory", Name="Australian Capital Territory", Type="Territory" },
            new(){ Code ="NSW", LocalName="New South Wales", Name="New South Wales", Type="State" },
            new(){ Code ="NT", LocalName="Northern Territory", Name="Northern Territory", Type="Territory" },
            new(){ Code ="QLD", LocalName="Queensland", Name="Queensland", Type="State" },
            new(){ Code ="SA", LocalName="South Australia", Name="South Australia", Type="State" },
            new(){ Code ="TAS", LocalName="Tasmania", Name="Tasmania", Type="State" },
            new(){ Code ="VIC", LocalName="Victoria", Name="Victoria", Type="State" },
            new(){ Code ="WA", LocalName="Western Australia", Name="Western Australia", Type="State" }

        });
    }
}
