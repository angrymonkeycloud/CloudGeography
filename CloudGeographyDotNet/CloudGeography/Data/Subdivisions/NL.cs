using AngryMonkey.Cloud.Geography;
namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    private static void FillInSubdivisionsNL()
    {
        AddSubdivisions("NL", new List<Subdivision>()
        {
            new(){ Code ="DR", LocalName="Drenthe", Name="Drenthe", Type="Province" },
            new(){ Code ="FL", LocalName="Flevoland", Name="Flevoland", Type="Province" },
            new(){ Code ="FR", LocalName="Fryslân", Name="Fryslân", Type="Province" },
            new(){ Code ="GE", LocalName="Gelderland", Name="Gelderland", Type="Province" },
            new(){ Code ="GR", LocalName="Groningen", Name="Groningen", Type="Province" },
            new(){ Code ="LI", LocalName="Limburg", Name="Limburg", Type="Province" },
            new(){ Code ="NB", LocalName="Noord-Brabant", Name="Noord-Brabant", Type="Province" },
            new(){ Code ="NH", LocalName="Noord-Holland", Name="Noord-Holland", Type="Province" },
            new(){ Code ="OV", LocalName="Overijssel", Name="Overijssel", Type="Province" },
            new(){ Code ="UT", LocalName="Utrecht", Name="Utrecht", Type="Province" },
            new(){ Code ="ZE", LocalName="Zeeland", Name="Zeeland", Type="Province" },
            new(){ Code ="ZH", LocalName="Zuid-Holland", Name="Zuid-Holland", Type="Province" }

        });
    }
}
