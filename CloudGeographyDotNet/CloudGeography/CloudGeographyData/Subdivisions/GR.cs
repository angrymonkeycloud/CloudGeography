using AngryMonkey.Cloud.Geography;
namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    private static void FillInSubdivisionsGR()
    {
        AddSubdivisions("GR", new List<Subdivision>()
        {
            new(){ Code ="A", LocalName="Anatolikí Makedonía kai Thráki", Name="Anatolikí Makedonía kai Thráki", Type="Region" },
            new(){ Code ="I", LocalName="Attikí", Name="Attikí", Type="Region" },
            new(){ Code ="G", LocalName="Dytikí Elláda", Name="Dytikí Elláda", Type="Region" },
            new(){ Code ="C", LocalName="Dytiki Makedonia", Name="Dytiki Makedonia", Type="Region" },
            new(){ Code ="F", LocalName="Ionía Nísia", Name="Ionía Nísia", Type="Region" },
            new(){ Code ="D", LocalName="Ípeiros", Name="Ípeiros", Type="Region" },
            new(){ Code ="B", LocalName="Kentrikí Makedonía", Name="Kentrikí Makedonía", Type="Region" },
            new(){ Code ="M", LocalName="Kríti", Name="Kríti", Type="Region" },
            new(){ Code ="L", LocalName="Notío Aigaío", Name="Notío Aigaío", Type="Region" },
            new(){ Code ="J", LocalName="Peloponnísos", Name="Peloponnísos", Type="Region" },
            new(){ Code ="H", LocalName="Stereá Elláda", Name="Stereá Elláda", Type="Region" },
            new(){ Code ="E", LocalName="Thessalía", Name="Thessalía", Type="Region" },
            new(){ Code ="K", LocalName="Voreío Aigaío", Name="Voreío Aigaío", Type="Region" }

        });
    }
}
