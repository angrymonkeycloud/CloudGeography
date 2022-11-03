using AngryMonkey.Cloud.Geography;
namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    private static void FillInSubdivisionsCU()
    {
        AddSubdivisions("CU", new List<Subdivision>()
        {
            new(){ Code ="15", LocalName="Artemisa", Name="Artemisa", Type="Province" },
            new(){ Code ="9", LocalName="Camagüey", Name="Camagüey", Type="Province" },
            new(){ Code ="8", LocalName="Ciego de Ávila", Name="Ciego de Ávila", Type="Province" },
            new(){ Code ="6", LocalName="Cienfuegos", Name="Cienfuegos", Type="Province" },
            new(){ Code ="3", LocalName="Ciudad de La Habana", Name="Ciudad de La Habana", Type="Province" },
            new(){ Code ="12", LocalName="Granma", Name="Granma", Type="Province" },
            new(){ Code ="14", LocalName="Guantánamo", Name="Guantánamo", Type="Province" },
            new(){ Code ="11", LocalName="Holguín", Name="Holguín", Type="Province" },
            new(){ Code ="99", LocalName="Isla de la Juventud", Name="Isla de la Juventud", Type="Municipality" },
            new(){ Code ="2", LocalName="La Habana", Name="La Habana", Type="Province" },
            new(){ Code ="10", LocalName="Las Tunas", Name="Las Tunas", Type="Province" },
            new(){ Code ="4", LocalName="Matanzas", Name="Matanzas", Type="Province" },
            new(){ Code ="16", LocalName="Mayabeque", Name="Mayabeque", Type="Province" },
            new(){ Code ="1", LocalName="Pinar del Río", Name="Pinar del Río", Type="Province" },
            new(){ Code ="7", LocalName="Sancti Spíritus", Name="Sancti Spíritus", Type="Province" },
            new(){ Code ="13", LocalName="Santiago de Cuba", Name="Santiago de Cuba", Type="Province" },
            new(){ Code ="5", LocalName="Villa Clara", Name="Villa Clara", Type="Province" }

        });
    }
}
