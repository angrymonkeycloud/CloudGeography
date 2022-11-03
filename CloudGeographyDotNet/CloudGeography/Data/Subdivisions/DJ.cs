using AngryMonkey.Cloud.Geography;
namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    private static void FillInSubdivisionsDJ()
    {
        AddSubdivisions("DJ", new List<Subdivision>()
        {
            new(){ Code ="AS", LocalName="Ali Sabieh", Name="Ali Sabieh", Type="Region" },
            new(){ Code ="AR", LocalName="Arta", Name="Arta", Type="Region" },
            new(){ Code ="DI", LocalName="Dikhil", Name="Dikhil", Type="Region" },
            new(){ Code ="DJ", LocalName="Djibouti", Name="Djibouti", Type="City" },
            new(){ Code ="OB", LocalName="Obock", Name="Obock", Type="Region" },
            new(){ Code ="TA", LocalName="Tadjourah", Name="Tadjourah", Type="Region" }

        });
    }
}
