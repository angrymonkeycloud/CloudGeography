using AngryMonkey.Cloud.Geography;
namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    private static void FillInSubdivisionsSV()
    {
        AddSubdivisions("SV", new List<Subdivision>()
        {
            new(){ Code ="AH", LocalName="Ahuachapán", Name="Ahuachapán", Type="Department" },
            new(){ Code ="CA", LocalName="Cabañas", Name="Cabañas", Type="Department" },
            new(){ Code ="CH", LocalName="Chalatenango", Name="Chalatenango", Type="Department" },
            new(){ Code ="CU", LocalName="Cuscatlán", Name="Cuscatlán", Type="Department" },
            new(){ Code ="LI", LocalName="La Libertad", Name="La Libertad", Type="Department" },
            new(){ Code ="PA", LocalName="La Paz", Name="La Paz", Type="Department" },
            new(){ Code ="UN", LocalName="La Unión", Name="La Unión", Type="Department" },
            new(){ Code ="MO", LocalName="Morazán", Name="Morazán", Type="Department" },
            new(){ Code ="SM", LocalName="San Miguel", Name="San Miguel", Type="Department" },
            new(){ Code ="SS", LocalName="San Salvador", Name="San Salvador", Type="Department" },
            new(){ Code ="SV", LocalName="San Vicente", Name="San Vicente", Type="Department" },
            new(){ Code ="SA", LocalName="Santa Ana", Name="Santa Ana", Type="Department" },
            new(){ Code ="SO", LocalName="Sonsonate", Name="Sonsonate", Type="Department" },
            new(){ Code ="US", LocalName="Usulután", Name="Usulután", Type="Department" }

        });
    }
}
