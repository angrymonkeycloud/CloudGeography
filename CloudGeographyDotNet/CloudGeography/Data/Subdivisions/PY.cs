using AngryMonkey.Cloud.Geography;
namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    private static void FillInSubdivisionsPY()
    {
        AddSubdivisions("PY", new List<Subdivision>()
        {
            new(){ Code ="16", LocalName="Alto Paraguay", Name="Alto Paraguay", Type="Department" },
            new(){ Code ="10", LocalName="Alto Paraná", Name="Alto Paraná", Type="Department" },
            new(){ Code ="13", LocalName="Amambay", Name="Amambay", Type="Department" },
            new(){ Code ="ASU", LocalName="Asunción", Name="Asunción", Type="Capital" },
            new(){ Code ="19", LocalName="Boquerón", Name="Boquerón", Type="Department" },
            new(){ Code ="5", LocalName="Caaguazú", Name="Caaguazú", Type="Department" },
            new(){ Code ="6", LocalName="Caazapá", Name="Caazapá", Type="Department" },
            new(){ Code ="14", LocalName="Canindeyú", Name="Canindeyú", Type="Department" },
            new(){ Code ="11", LocalName="Central", Name="Central", Type="Department" },
            new(){ Code ="1", LocalName="Concepción", Name="Concepción", Type="Department" },
            new(){ Code ="3", LocalName="Cordillera", Name="Cordillera", Type="Department" },
            new(){ Code ="4", LocalName="Guairá", Name="Guairá", Type="Department" },
            new(){ Code ="7", LocalName="Itapúa", Name="Itapúa", Type="Department" },
            new(){ Code ="8", LocalName="Misiones", Name="Misiones", Type="Department" },
            new(){ Code ="12", LocalName="Ñeembucú", Name="Ñeembucú", Type="Department" },
            new(){ Code ="9", LocalName="Paraguarí", Name="Paraguarí", Type="Department" },
            new(){ Code ="15", LocalName="Presidente Hayes", Name="Presidente Hayes", Type="Department" },
            new(){ Code ="2", LocalName="San Pedro", Name="San Pedro", Type="Department" }

        });
    }
}
