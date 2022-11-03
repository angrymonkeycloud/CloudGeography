using AngryMonkey.Cloud.Geography;
namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    private static void FillInSubdivisionsAG()
    {
        AddSubdivisions("AG", new List<Subdivision>()
        {
            new(){ Code ="1", LocalName="Barbuda", Name="Barbuda", Type="Dependency" },
            new(){ Code ="2", LocalName="Redonda", Name="Redonda", Type="Dependency" },
            new(){ Code ="3", LocalName="Saint George", Name="Saint George", Type="Parish" },
            new(){ Code ="4", LocalName="Saint John", Name="Saint John", Type="Parish" },
            new(){ Code ="5", LocalName="Saint Mary", Name="Saint Mary", Type="Parish" },
            new(){ Code ="6", LocalName="Saint Paul", Name="Saint Paul", Type="Parish" },
            new(){ Code ="7", LocalName="Saint Peter", Name="Saint Peter", Type="Parish" },
            new(){ Code ="8", LocalName="Saint Philip", Name="Saint Philip", Type="Parish" }

        });
    }
}
