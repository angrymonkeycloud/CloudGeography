using AngryMonkey.Cloud.Geography;
namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    private static void FillInSubdivisionsKM()
    {
        AddSubdivisions("KM", new List<Subdivision>()
        {
            new(){ Code ="A", LocalName="Anjouan", Name="Anjouan", Type="Island" },
            new(){ Code ="G", LocalName="Grande Comore", Name="Grande Comore", Type="Island" },
            new(){ Code ="M", LocalName="Mohéli", Name="Mohéli", Type="Island" }

        });
    }
}
