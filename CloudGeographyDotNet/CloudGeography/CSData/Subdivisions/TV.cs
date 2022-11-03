using AngryMonkey.Cloud.Geography;
namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    private static void FillInSubdivisionsTV()
    {
        AddSubdivisions("TV", new List<Subdivision>()
        {
            new(){ Code ="NMG", LocalName="Nanumaga", Name="Nanumaga", Type="Island" },
            new(){ Code ="NMA", LocalName="Nanumea", Name="Nanumea", Type="Island" },
            new(){ Code ="NIT", LocalName="Niutao", Name="Niutao", Type="Island" },
            new(){ Code ="NIU", LocalName="Nui", Name="Nui", Type="Island" },
            new(){ Code ="NKF", LocalName="Nukufetau", Name="Nukufetau", Type="Island" },
            new(){ Code ="NKL", LocalName="Nukulaelae", Name="Nukulaelae", Type="Island" },
            new(){ Code ="VAI", LocalName="Vaitupu", Name="Vaitupu", Type="Island" }

        });
    }
}
