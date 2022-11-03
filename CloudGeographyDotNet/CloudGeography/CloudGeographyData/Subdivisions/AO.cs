using AngryMonkey.Cloud.Geography;
namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    private static void FillInSubdivisionsAO()
    {
        AddSubdivisions("AO", new List<Subdivision>()
        {
            new(){ Code ="BGO", LocalName="Bengo", Name="Bengo", Type="Province" },
            new(){ Code ="BGU", LocalName="Benguela", Name="Benguela", Type="Province" },
            new(){ Code ="BIE", LocalName="Bié", Name="Bié", Type="Province" },
            new(){ Code ="CAB", LocalName="Cabinda", Name="Cabinda", Type="Province" },
            new(){ Code ="CNN", LocalName="Cunene", Name="Cunene", Type="Province" },
            new(){ Code ="HUA", LocalName="Huambo", Name="Huambo", Type="Province" },
            new(){ Code ="HUI", LocalName="Huíla", Name="Huíla", Type="Province" },
            new(){ Code ="CCU", LocalName="Kuando Kubango", Name="Kuando Kubango", Type="Province" },
            new(){ Code ="CNO", LocalName="Kwanza Norte", Name="Kwanza Norte", Type="Province" },
            new(){ Code ="CUS", LocalName="Kwanza Sul", Name="Kwanza Sul", Type="Province" },
            new(){ Code ="LUA", LocalName="Luanda", Name="Luanda", Type="Province" },
            new(){ Code ="LNO", LocalName="Lunda Norte", Name="Lunda Norte", Type="Province" },
            new(){ Code ="LSU", LocalName="Lunda Sul", Name="Lunda Sul", Type="Province" },
            new(){ Code ="MAL", LocalName="Malange", Name="Malange", Type="Province" },
            new(){ Code ="MOX", LocalName="Moxico", Name="Moxico", Type="Province" },
            new(){ Code ="NAM", LocalName="Namibe", Name="Namibe", Type="Province" },
            new(){ Code ="UIG", LocalName="Uíge", Name="Uíge", Type="Province" },
            new(){ Code ="ZAI", LocalName="Zaire", Name="Zaire", Type="Province" }

        });
    }
}
