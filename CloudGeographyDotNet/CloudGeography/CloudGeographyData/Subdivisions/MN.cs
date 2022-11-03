using AngryMonkey.Cloud.Geography;
namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    private static void FillInSubdivisionsMN()
    {
        AddSubdivisions("MN", new List<Subdivision>()
        {
            new(){ Code ="73", LocalName="Arhangay", Name="Arhangay", Type="Province" },
            new(){ Code ="69", LocalName="Bayanhongor", Name="Bayanhongor", Type="Province" },
            new(){ Code ="71", LocalName="Bayan-Ölgiy", Name="Bayan-Ölgiy", Type="Province" },
            new(){ Code ="67", LocalName="Bulgan", Name="Bulgan", Type="Province" },
            new(){ Code ="37", LocalName="Darhan uul", Name="Darhan uul", Type="Province" },
            new(){ Code ="61", LocalName="Dornod", Name="Dornod", Type="Province" },
            new(){ Code ="63", LocalName="Dornogovi", Name="Dornogovi", Type="Province" },
            new(){ Code ="59", LocalName="Dundgovi", Name="Dundgovi", Type="Province" },
            new(){ Code ="57", LocalName="Dzavhan", Name="Dzavhan", Type="Province" },
            new(){ Code ="65", LocalName="Govi-Altay", Name="Govi-Altay", Type="Province" },
            new(){ Code ="64", LocalName="Govi-Sümber", Name="Govi-Sümber", Type="Province" },
            new(){ Code ="39", LocalName="Hentiy", Name="Hentiy", Type="Province" },
            new(){ Code ="41", LocalName="Hövagöl", Name="Hövagöl", Type="Province" },
            new(){ Code ="43", LocalName="Hovd", Name="Hovd", Type="Province" },
            new(){ Code ="53", LocalName="Ömnögovi", Name="Ömnögovi", Type="Province" },
            new(){ Code ="35", LocalName="Orhon", Name="Orhon", Type="Province" },
            new(){ Code ="55", LocalName="Övörhangay", Name="Övörhangay", Type="Province" },
            new(){ Code ="49", LocalName="Selenge", Name="Selenge", Type="Province" },
            new(){ Code ="51", LocalName="Sühbaatar", Name="Sühbaatar", Type="Province" },
            new(){ Code ="47", LocalName="Töv", Name="Töv", Type="Province" },
            new(){ Code ="1", LocalName="Ulaanbaatar", Name="Ulaanbaatar", Type="CapitalCity" },
            new(){ Code ="46", LocalName="Uvs", Name="Uvs", Type="Province" }

        });
    }
}
