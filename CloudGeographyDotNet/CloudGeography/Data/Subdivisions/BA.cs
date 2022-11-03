using AngryMonkey.Cloud.Geography;
namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    private static void FillInSubdivisionsBA()
    {
        AddSubdivisions("BA", new List<Subdivision>()
        {
            new(){ Code ="BRC", LocalName="Brčko Distrikt", Name="Brčko District", Type="District" },
            new(){ Code ="BIH", LocalName="Federacija Bosne i Hercegovine", Name="Federation of Bosnia and Herzegovina", Type="Entity" },
            new(){ Code ="SRP", LocalName="Република Српскa", Name="Republika Srpska", Type="Entity" }

        });
    }
}
