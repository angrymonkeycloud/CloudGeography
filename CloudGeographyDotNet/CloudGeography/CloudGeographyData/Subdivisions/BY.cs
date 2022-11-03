using AngryMonkey.Cloud.Geography;
namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    private static void FillInSubdivisionsBY()
    {
        AddSubdivisions("BY", new List<Subdivision>()
        {
            new(){ Code ="BR", LocalName="Бре́стская о́бласть", Name="Brest Oblast", Type="Oblast" },
            new(){ Code ="HO", LocalName="Гомельская область", Name="Gomel Oblast", Type="Oblast" },
            new(){ Code ="HR", LocalName="Гродненская область", Name="Grodno Oblast", Type="Oblast" },
            new(){ Code ="HM", LocalName="Минск", Name="Minsk", Type="City" },
            new(){ Code ="MI", LocalName="Минская о́бласть", Name="Minsk Oblast", Type="Oblast" },
            new(){ Code ="MA", LocalName="Могилёвская о́бласть", Name="Mogilev Oblast", Type="Oblast" },
            new(){ Code ="VI", LocalName="Ви́тебская о́бласть", Name="Vitebsk Oblast", Type="Oblast" }

        });
    }
}
