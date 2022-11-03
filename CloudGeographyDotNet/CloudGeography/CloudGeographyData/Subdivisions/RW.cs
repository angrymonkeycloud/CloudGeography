using AngryMonkey.Cloud.Geography;
namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    private static void FillInSubdivisionsRW()
    {
        AddSubdivisions("RW", new List<Subdivision>()
        {
            new(){ Code ="2", LocalName="Est", Name="Est", Type="Province" },
            new(){ Code ="3", LocalName="Nord", Name="Nord", Type="Province" },
            new(){ Code ="4", LocalName="Ouest", Name="Ouest", Type="Province" },
            new(){ Code ="5", LocalName="Sud", Name="Sud", Type="Province" },
            new(){ Code ="1", LocalName="Ville de Kigali", Name="Ville de Kigali", Type="City" }

        });
    }
}
