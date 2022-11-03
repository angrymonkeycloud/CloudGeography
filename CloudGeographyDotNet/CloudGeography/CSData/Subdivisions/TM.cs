using AngryMonkey.Cloud.Geography;
namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    private static void FillInSubdivisionsTM()
    {
        AddSubdivisions("TM", new List<Subdivision>()
        {
            new(){ Code ="A", LocalName="Ahal", Name="Ahal", Type="Region" },
            new(){ Code ="S", LocalName="Asgabat", Name="Asgabat", Type="City" },
            new(){ Code ="B", LocalName="Balkan", Name="Balkan", Type="Region" },
            new(){ Code ="D", LocalName="Dasoguz", Name="Dasoguz", Type="Region" },
            new(){ Code ="L", LocalName="Lebap", Name="Lebap", Type="Region" },
            new(){ Code ="M", LocalName="Mary", Name="Mary", Type="Region" }

        });
    }
}
