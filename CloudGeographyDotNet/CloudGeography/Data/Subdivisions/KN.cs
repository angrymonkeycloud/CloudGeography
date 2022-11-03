using AngryMonkey.Cloud.Geography;
namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    private static void FillInSubdivisionsKN()
    {
        AddSubdivisions("KN", new List<Subdivision>()
        {
            new(){ Code ="1", LocalName="Christ Church Nichola Town", Name="Christ Church Nichola Town", Type="Parish" },
            new(){ Code ="2", LocalName="Saint Anne Sandy Point", Name="Saint Anne Sandy Point", Type="Parish" },
            new(){ Code ="3", LocalName="Saint George Basseterre", Name="Saint George Basseterre", Type="Parish" },
            new(){ Code ="4", LocalName="Saint George Gingerland", Name="Saint George Gingerland", Type="Parish" },
            new(){ Code ="5", LocalName="Saint James Windward", Name="Saint James Windward", Type="Parish" },
            new(){ Code ="6", LocalName="Saint John Capisterre", Name="Saint John Capisterre", Type="Parish" },
            new(){ Code ="7", LocalName="Saint John Figtree", Name="Saint John Figtree", Type="Parish" },
            new(){ Code ="8", LocalName="Saint Mary Cayon", Name="Saint Mary Cayon", Type="Parish" },
            new(){ Code ="9", LocalName="Saint Paul Capisterre", Name="Saint Paul Capisterre", Type="Parish" },
            new(){ Code ="10", LocalName="Saint Paul Charlestown", Name="Saint Paul Charlestown", Type="Parish" },
            new(){ Code ="11", LocalName="Saint Peter Basseterre", Name="Saint Peter Basseterre", Type="Parish" },
            new(){ Code ="12", LocalName="Saint Thomas Lowland", Name="Saint Thomas Lowland", Type="Parish" },
            new(){ Code ="13", LocalName="Saint Thomas Middle Island", Name="Saint Thomas Middle Island", Type="Parish" },
            new(){ Code ="15", LocalName="Trinity Palmetto Point", Name="Trinity Palmetto Point", Type="Parish" }

        });
    }
}
