using AngryMonkey.Cloud.Geography;
namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    private static void FillInSubdivisionsTL()
    {
        AddSubdivisions("TL", new List<Subdivision>()
        {
            new(){ Code ="AL", LocalName="Aileu", Name="Aileu", Type="District" },
            new(){ Code ="AN", LocalName="Ainaro", Name="Ainaro", Type="District" },
            new(){ Code ="BA", LocalName="Baucau", Name="Baucau", Type="District" },
            new(){ Code ="BO", LocalName="Bobonaro", Name="Bobonaro", Type="District" },
            new(){ Code ="CO", LocalName="Cova Lima", Name="Cova Lima", Type="District" },
            new(){ Code ="DI", LocalName="Díli", Name="Díli", Type="District" },
            new(){ Code ="ER", LocalName="Ermera", Name="Ermera", Type="District" },
            new(){ Code ="LA", LocalName="Lautem", Name="Lautem", Type="District" },
            new(){ Code ="LI", LocalName="Liquiça", Name="Liquiça", Type="District" },
            new(){ Code ="MT", LocalName="Manatuto", Name="Manatuto", Type="District" },
            new(){ Code ="MF", LocalName="Manufahi", Name="Manufahi", Type="District" },
            new(){ Code ="OE", LocalName="Oecussi", Name="Oecussi", Type="District" },
            new(){ Code ="VI", LocalName="Viqueque", Name="Viqueque", Type="District" }

        });
    }
}
