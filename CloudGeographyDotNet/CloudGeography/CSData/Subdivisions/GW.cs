using AngryMonkey.Cloud.Geography;
namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    private static void FillInSubdivisionsGW()
    {
        AddSubdivisions("GW", new List<Subdivision>()
        {
            new(){ Code ="BA", LocalName="Bafatá", Name="Bafatá", Type="Region" },
            new(){ Code ="BM", LocalName="Biombo", Name="Biombo", Type="Region" },
            new(){ Code ="BS", LocalName="Bissau", Name="Bissau", Type="Sector" },
            new(){ Code ="BL", LocalName="Bolama", Name="Bolama", Type="Region" },
            new(){ Code ="CA", LocalName="Cacheu", Name="Cacheu", Type="Region" },
            new(){ Code ="GA", LocalName="Gabú", Name="Gabú", Type="Region" },
            new(){ Code ="OI", LocalName="Oio", Name="Oio", Type="Region" },
            new(){ Code ="QU", LocalName="Quinara", Name="Quinara", Type="Region" },
            new(){ Code ="TO", LocalName="Tombali", Name="Tombali", Type="Region" }

        });
    }
}
