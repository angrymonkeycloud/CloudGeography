using AngryMonkey.Cloud.Geography;
namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    private static void FillInSubdivisionsST()
    {
        AddSubdivisions("ST", new List<Subdivision>()
        {
            new(){ Code ="P", LocalName="Príncipe", Name="Príncipe", Type="Province" },
            new(){ Code ="S", LocalName="São Tomé", Name="São Tomé", Type="Province" }

        });
    }
}
