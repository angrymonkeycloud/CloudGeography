using AngryMonkey.Cloud.Geography;
namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    private static void FillInSubdivisionsBJ()
    {
        AddSubdivisions("BJ", new List<Subdivision>()
        {
            new(){ Code ="AL", LocalName="Alibori", Name="Alibori", Type="Department" },
            new(){ Code ="AK", LocalName="Atacora", Name="Atacora", Type="Department" },
            new(){ Code ="AQ", LocalName="Atlantique", Name="Atlantique", Type="Department" },
            new(){ Code ="BO", LocalName="Borgou", Name="Borgou", Type="Department" },
            new(){ Code ="CO", LocalName="Collines", Name="Collines", Type="Department" },
            new(){ Code ="KO", LocalName="Couffo", Name="Couffo", Type="Department" },
            new(){ Code ="DO", LocalName="Donga", Name="Donga", Type="Department" },
            new(){ Code ="LI", LocalName="Littoral", Name="Littoral", Type="Department" },
            new(){ Code ="MO", LocalName="Mono", Name="Mono", Type="Department" },
            new(){ Code ="OU", LocalName="Ouémé", Name="Ouémé", Type="Department" },
            new(){ Code ="PL", LocalName="Plateau", Name="Plateau", Type="Department" },
            new(){ Code ="ZO", LocalName="Zou", Name="Zou", Type="Department" }

        });
    }
}
