using AngryMonkey.Cloud.Geography;
namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    private static void FillInSubdivisionsGQ()
    {
        AddSubdivisions("GQ", new List<Subdivision>()
        {
            new(){ Code ="AN", LocalName="Annobón", Name="Annobón", Type="Province" },
            new(){ Code ="BN", LocalName="Bioko Norte", Name="Bioko Norte", Type="Province" },
            new(){ Code ="BS", LocalName="Bioko Sur", Name="Bioko Sur", Type="Province" },
            new(){ Code ="CS", LocalName="Centro Sur", Name="Centro Sur", Type="Province" },
            new(){ Code ="KN", LocalName="Kié-Ntem", Name="Kié-Ntem", Type="Province" },
            new(){ Code ="LI", LocalName="Litoral", Name="Litoral", Type="Province" },
            new(){ Code ="WN", LocalName="Wele-Nzas", Name="Wele-Nzas", Type="Province" }

        });
    }
}
