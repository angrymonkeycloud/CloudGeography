using AngryMonkey.Cloud.Geography;
namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    private static void FillInSubdivisionsTG()
    {
        AddSubdivisions("TG", new List<Subdivision>()
        {
            new(){ Code ="C", LocalName="Centrale", Name="Centrale", Type="Region" },
            new(){ Code ="K", LocalName="Kara", Name="Kara", Type="Region" },
            new(){ Code ="M", LocalName="Maritime", Name="Maritime", Type="Region" },
            new(){ Code ="P", LocalName="Plateaux", Name="Plateaux", Type="Region" },
            new(){ Code ="S", LocalName="Savannes", Name="Savannes", Type="Region" }

        });
    }
}
