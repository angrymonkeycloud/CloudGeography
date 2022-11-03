using AngryMonkey.Cloud.Geography;
namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    private static void FillInSubdivisionsHT()
    {
        AddSubdivisions("HT", new List<Subdivision>()
        {
            new(){ Code ="AR", LocalName="Artibonite", Name="Artibonite", Type="Department" },
            new(){ Code ="CE", LocalName="Centre", Name="Centre", Type="Department" },
            new(){ Code ="GA", LocalName="GrandeAnse", Name="GrandeAnse", Type="Department" },
            new(){ Code ="NI", LocalName="Nippes", Name="Nippes", Type="Department" },
            new(){ Code ="ND", LocalName="Nord", Name="Nord", Type="Department" },
            new(){ Code ="NE", LocalName="Nord-Est", Name="Nord-Est", Type="Department" },
            new(){ Code ="NO", LocalName="Nord-Ouest", Name="Nord-Ouest", Type="Department" },
            new(){ Code ="OU", LocalName="Ouest", Name="Ouest", Type="Department" },
            new(){ Code ="SD", LocalName="Sud", Name="Sud", Type="Department" },
            new(){ Code ="SE", LocalName="Sud-Est", Name="Sud-Est", Type="Department" }

        });
    }
}
