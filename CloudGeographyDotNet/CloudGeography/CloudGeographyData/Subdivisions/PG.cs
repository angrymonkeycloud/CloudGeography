using AngryMonkey.Cloud.Geography;
namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    private static void FillInSubdivisionsPG()
    {
        AddSubdivisions("PG", new List<Subdivision>()
        {
            new(){ Code ="NSB", LocalName="Bougainville", Name="Bougainville", Type="Region" },
            new(){ Code ="CPM", LocalName="Central", Name="Central", Type="Province" },
            new(){ Code ="CPK", LocalName="Chimbu", Name="Chimbu", Type="Province" },
            new(){ Code ="EBR", LocalName="East New Britain", Name="East New Britain", Type="Province" },
            new(){ Code ="ESW", LocalName="East Sepik", Name="East Sepik", Type="Province" },
            new(){ Code ="EHG", LocalName="Eastern Highlands", Name="Eastern Highlands", Type="Province" },
            new(){ Code ="EPW", LocalName="Enga", Name="Enga", Type="Province" },
            new(){ Code ="GPK", LocalName="Gulf", Name="Gulf", Type="Province" },
            new(){ Code ="HLA", LocalName="Hela", Name="Hela", Type="Province" },
            new(){ Code ="JWK", LocalName="Jiwaka", Name="Jiwaka", Type="Province" },
            new(){ Code ="MPM", LocalName="Madang", Name="Madang", Type="Province" },
            new(){ Code ="MRL", LocalName="Manus", Name="Manus", Type="Province" },
            new(){ Code ="MBA", LocalName="Milne Bay", Name="Milne Bay", Type="Province" },
            new(){ Code ="MPL", LocalName="Morobe", Name="Morobe", Type="Province" },
            new(){ Code ="NCD", LocalName="National Capital District", Name="National Capital District", Type="District" },
            new(){ Code ="NIK", LocalName="New Ireland", Name="New Ireland", Type="Province" },
            new(){ Code ="NPP", LocalName="Northern", Name="Northern", Type="Province" },
            new(){ Code ="SHM", LocalName="Southern Highlands", Name="Southern Highlands", Type="Province" },
            new(){ Code ="WBK", LocalName="West New Britain", Name="West New Britain", Type="Province" },
            new(){ Code ="SAN", LocalName="West Sepik", Name="West Sepik", Type="Province" },
            new(){ Code ="WPD", LocalName="Western", Name="Western", Type="Province" },
            new(){ Code ="WHM", LocalName="Western Highlands", Name="Western Highlands", Type="Province" }

        });
    }
}
