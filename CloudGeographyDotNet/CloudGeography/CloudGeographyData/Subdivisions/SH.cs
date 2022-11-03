using AngryMonkey.Cloud.Geography;
namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    private static void FillInSubdivisionsSH()
    {
        AddSubdivisions("SH", new List<Subdivision>()
        {
            new(){ Code ="AC", LocalName="Ascension", Name="Ascension", Type="Entity" },
            new(){ Code ="HL", LocalName="Saint Helena", Name="Saint Helena", Type="Entity" },
            new(){ Code ="TA", LocalName="Tristan da Cunha", Name="Tristan da Cunha", Type="Entity" }

        });
    }
}
