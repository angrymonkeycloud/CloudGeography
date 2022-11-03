using AngryMonkey.Cloud.Geography;
namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    private static void FillInSubdivisionsAT()
    {
        AddSubdivisions("AT", new List<Subdivision>()
        {
            new(){ Code ="1", LocalName="Burgenland", Name="Burgenland", Type="State" },
            new(){ Code ="2", LocalName="Kärnten", Name="Kärnten", Type="State" },
            new(){ Code ="3", LocalName="Niederösterreich", Name="Niederösterreich", Type="State" },
            new(){ Code ="4", LocalName="Oberösterreich", Name="Oberösterreich", Type="State" },
            new(){ Code ="5", LocalName="Salzburg", Name="Salzburg", Type="State" },
            new(){ Code ="6", LocalName="Steiermark", Name="Steiermark", Type="State" },
            new(){ Code ="7", LocalName="Tirol", Name="Tirol", Type="State" },
            new(){ Code ="8", LocalName="Vorarlberg", Name="Vorarlberg", Type="State" },
            new(){ Code ="9", LocalName="Wien", Name="Wien", Type="State" }

        });
    }
}
