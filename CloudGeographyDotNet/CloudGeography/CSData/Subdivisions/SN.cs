using AngryMonkey.Cloud.Geography;
namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    private static void FillInSubdivisionsSN()
    {
        AddSubdivisions("SN", new List<Subdivision>()
        {
            new(){ Code ="DK", LocalName="Dakar", Name="Dakar", Type="Region" },
            new(){ Code ="DB", LocalName="Diourbel", Name="Diourbel", Type="Region" },
            new(){ Code ="FK", LocalName="Fatick", Name="Fatick", Type="Region" },
            new(){ Code ="KA", LocalName="Kaffrine", Name="Kaffrine", Type="Region" },
            new(){ Code ="KL", LocalName="Kaolack", Name="Kaolack", Type="Region" },
            new(){ Code ="KE", LocalName="Kédougou", Name="Kédougou", Type="Region" },
            new(){ Code ="KD", LocalName="Kolda", Name="Kolda", Type="Region" },
            new(){ Code ="LG", LocalName="Louga", Name="Louga", Type="Region" },
            new(){ Code ="MT", LocalName="Matam", Name="Matam", Type="Region" },
            new(){ Code ="SL", LocalName="Saint-Louis", Name="Saint-Louis", Type="Region" },
            new(){ Code ="SE", LocalName="Sédhiou", Name="Sédhiou", Type="Region" },
            new(){ Code ="TC", LocalName="Tambacounda", Name="Tambacounda", Type="Region" },
            new(){ Code ="TH", LocalName="Thiès", Name="Thiès", Type="Region" },
            new(){ Code ="ZG", LocalName="Ziguinchor", Name="Ziguinchor", Type="Region" }

        });
    }
}
