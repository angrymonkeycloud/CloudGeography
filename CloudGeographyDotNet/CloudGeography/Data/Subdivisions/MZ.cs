using AngryMonkey.Cloud.Geography;
namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    private static void FillInSubdivisionsMZ()
    {
        AddSubdivisions("MZ", new List<Subdivision>()
        {
            new(){ Code ="P", LocalName="Cabo Delgado", Name="Cabo Delgado", Type="Province" },
            new(){ Code ="G", LocalName="Gaza", Name="Gaza", Type="Province" },
            new(){ Code ="I", LocalName="Inhambane", Name="Inhambane", Type="Province" },
            new(){ Code ="B", LocalName="Manica", Name="Manica", Type="Province" },
            new(){ Code ="L", LocalName="Maputo", Name="Maputo", Type="Province" },
            new(){ Code ="MPM", LocalName="Maputo", Name="Maputo", Type="City" },
            new(){ Code ="N", LocalName="Nampula", Name="Nampula", Type="Province" },
            new(){ Code ="A", LocalName="Niaosa", Name="Niaosa", Type="Province" },
            new(){ Code ="S", LocalName="Sofala", Name="Sofala", Type="Province" },
            new(){ Code ="T", LocalName="Tete", Name="Tete", Type="Province" },
            new(){ Code ="Q", LocalName="Zambézia", Name="Zambézia", Type="Province" }

        });
    }
}
