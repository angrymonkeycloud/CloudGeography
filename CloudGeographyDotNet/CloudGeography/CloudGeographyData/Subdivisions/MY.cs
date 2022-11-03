using AngryMonkey.Cloud.Geography;
namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    private static void FillInSubdivisionsMY()
    {
        AddSubdivisions("MY", new List<Subdivision>()
        {
            new(){ Code ="1", LocalName="Johor", Name="Johor", Type="State" },
            new(){ Code ="2", LocalName="Kedah", Name="Kedah", Type="State" },
            new(){ Code ="3", LocalName="Kelantan", Name="Kelantan", Type="State" },
            new(){ Code ="4", LocalName="Melaka", Name="Melaka", Type="State" },
            new(){ Code ="5", LocalName="Negeri Sembilan", Name="Negeri Sembilan", Type="State" },
            new(){ Code ="6", LocalName="Pahang", Name="Pahang", Type="State" },
            new(){ Code ="8", LocalName="Perak", Name="Perak", Type="State" },
            new(){ Code ="9", LocalName="Perlis", Name="Perlis", Type="State" },
            new(){ Code ="7", LocalName="Pulau Pinang", Name="Pulau Pinang", Type="State" },
            new(){ Code ="12", LocalName="Sabah", Name="Sabah", Type="State" },
            new(){ Code ="13", LocalName="Sarawak", Name="Sarawak", Type="State" },
            new(){ Code ="10", LocalName="Selangor", Name="Selangor", Type="State" },
            new(){ Code ="11", LocalName="Terengganu", Name="Terengganu", Type="State" },
            new(){ Code ="14", LocalName="Wilayah Persekutuan Kuala Lumpur", Name="Wilayah Persekutuan Kuala Lumpur", Type="Territory" },
            new(){ Code ="15", LocalName="Wilayah Persekutuan Labuan", Name="Wilayah Persekutuan Labuan", Type="Territory" },
            new(){ Code ="16", LocalName="Wilayah Persekutuan Putrajaya", Name="Wilayah Persekutuan Putrajaya", Type="Territory" }

        });
    }
}
