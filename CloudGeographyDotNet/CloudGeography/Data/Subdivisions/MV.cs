using AngryMonkey.Cloud.Geography;
namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    private static void FillInSubdivisionsMV()
    {
        AddSubdivisions("MV", new List<Subdivision>()
        {
            new(){ Code ="SU", LocalName="Dhekunu", Name="Dhekunu", Type="Province" },
            new(){ Code ="MLE", LocalName="Male", Name="Male", Type="Capital" },
            new(){ Code ="US", LocalName="Mathi-Dhekunu", Name="Mathi-Dhekunu", Type="Province" },
            new(){ Code ="UN", LocalName="Mathi-Uthuru", Name="Mathi-Uthuru", Type="Province" },
            new(){ Code ="CE", LocalName="Medhu", Name="Medhu", Type="Province" },
            new(){ Code ="SC", LocalName="Medhu-Dhekunu", Name="Medhu-Dhekunu", Type="Province" },
            new(){ Code ="NC", LocalName="Medhu-Uthuru", Name="Medhu-Uthuru", Type="Province" },
            new(){ Code ="NO", LocalName="Uthuru", Name="Uthuru", Type="Province" }

        });
    }
}
