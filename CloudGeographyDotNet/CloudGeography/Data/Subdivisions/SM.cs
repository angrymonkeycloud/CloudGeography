using AngryMonkey.Cloud.Geography;
namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    private static void FillInSubdivisionsSM()
    {
        AddSubdivisions("SM", new List<Subdivision>()
        {
            new(){ Code ="1", LocalName="Acquaviva", Name="Acquaviva", Type="Municipality" },
            new(){ Code ="6", LocalName="Borgo Maggiore", Name="Borgo Maggiore", Type="Municipality" },
            new(){ Code ="2", LocalName="Chiesanuova", Name="Chiesanuova", Type="Municipality" },
            new(){ Code ="3", LocalName="Domagnano", Name="Domagnano", Type="Municipality" },
            new(){ Code ="4", LocalName="Faetano", Name="Faetano", Type="Municipality" },
            new(){ Code ="5", LocalName="Fiorentino", Name="Fiorentino", Type="Municipality" },
            new(){ Code ="8", LocalName="Montegiardino", Name="Montegiardino", Type="Municipality" },
            new(){ Code ="7", LocalName="San Marino", Name="San Marino", Type="Municipality" },
            new(){ Code ="9", LocalName="Serravalle", Name="Serravalle", Type="Municipality" }

        });
    }
}
