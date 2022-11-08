using AngryMonkey.Cloud.Geography;
namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    private static void FillInSubdivisionsAD()
    {
        AddSubdivisions("AD", new List<Subdivision>()
        {
            new()
            { 
                Code ="7",
                Type="Parish",
                Name="Andorra la Vella",
                LocalName="Andorra la Vella"
            },
            new(){ Code ="2", LocalName="Canillo", Name="Canillo", Type="Parish" },
            new(){ Code ="3", LocalName="Encamp", Name="Encamp", Type="Parish" },
            new(){ Code ="8", LocalName="Escaldes-Engordany", Name="Escaldes-Engordany", Type="Parish" },
            new(){ Code ="4", LocalName="La Massana", Name="La Massana", Type="Parish" },
            new(){ Code ="5", LocalName="Ordino", Name="Ordino", Type="Parish" },
            new(){ Code ="6", LocalName="Sant Julià de Lòria", Name="Sant Julià de Lòria", Type="Parish" }

        });
    }
}
