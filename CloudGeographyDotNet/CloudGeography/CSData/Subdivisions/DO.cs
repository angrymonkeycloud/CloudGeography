using AngryMonkey.Cloud.Geography;
namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    private static void FillInSubdivisionsDO()
    {
        AddSubdivisions("DO", new List<Subdivision>()
        {
            new(){ Code ="2", LocalName="Azua", Name="Azua", Type="Province" },
            new(){ Code ="3", LocalName="Baoruco", Name="Baoruco", Type="Province" },
            new(){ Code ="4", LocalName="Barahona", Name="Barahona", Type="Province" },
            new(){ Code ="33", LocalName="Cibao Nordeste", Name="Cibao Nordeste", Type="Region" },
            new(){ Code ="34", LocalName="Cibao Noroeste", Name="Cibao Noroeste", Type="Region" },
            new(){ Code ="35", LocalName="Cibao Norte", Name="Cibao Norte", Type="Region" },
            new(){ Code ="36", LocalName="Cibao Sur", Name="Cibao Sur", Type="Region" },
            new(){ Code ="5", LocalName="Dajabón", Name="Dajabón", Type="Province" },
            new(){ Code ="1", LocalName="Distrito Nacional", Name="Distrito Nacional", Type="District" },
            new(){ Code ="6", LocalName="Duarte", Name="Duarte", Type="Province" },
            new(){ Code ="8", LocalName="El Seibo", Name="El Seibo", Type="Province" },
            new(){ Code ="37", LocalName="El Valle", Name="El Valle", Type="Region" },
            new(){ Code ="7", LocalName="Elías Piña", Name="Elías Piña", Type="Province" },
            new(){ Code ="38", LocalName="Enriquillo", Name="Enriquillo", Type="Region" },
            new(){ Code ="9", LocalName="Espaillat", Name="Espaillat", Type="Province" },
            new(){ Code ="30", LocalName="Hato Mayor", Name="Hato Mayor", Type="Province" },
            new(){ Code ="19", LocalName="Hermanas Mirabal", Name="Hermanas Mirabal", Type="Province" },
            new(){ Code ="39", LocalName="Higuamo", Name="Higuamo", Type="Region" },
            new(){ Code ="10", LocalName="Independencia", Name="Independencia", Type="Province" },
            new(){ Code ="11", LocalName="La Altagracia", Name="La Altagracia", Type="Province" },
            new(){ Code ="12", LocalName="La Romana", Name="La Romana", Type="Province" },
            new(){ Code ="13", LocalName="La Vega", Name="La Vega", Type="Province" },
            new(){ Code ="14", LocalName="María Trinidad Sánchez", Name="María Trinidad Sánchez", Type="Province" },
            new(){ Code ="28", LocalName="Monseñor Nouel", Name="Monseñor Nouel", Type="Province" },
            new(){ Code ="15", LocalName="Monte Cristi", Name="Monte Cristi", Type="Province" },
            new(){ Code ="29", LocalName="Monte Plata", Name="Monte Plata", Type="Province" },
            new(){ Code ="40", LocalName="Ozama", Name="Ozama", Type="Region" },
            new(){ Code ="16", LocalName="Pedernales", Name="Pedernales", Type="Province" },
            new(){ Code ="17", LocalName="Peravia", Name="Peravia", Type="Province" },
            new(){ Code ="18", LocalName="Puerto Plata", Name="Puerto Plata", Type="Province" },
            new(){ Code ="20", LocalName="Samaná", Name="Samaná", Type="Province" },
            new(){ Code ="21", LocalName="San Cristóbal", Name="San Cristóbal", Type="Province" },
            new(){ Code ="31", LocalName="San José de Ocoa", Name="San José de Ocoa", Type="Province" },
            new(){ Code ="22", LocalName="San Juan", Name="San Juan", Type="Province" },
            new(){ Code ="23", LocalName="San Pedro de Macorís", Name="San Pedro de Macorís", Type="Province" },
            new(){ Code ="24", LocalName="Sánchez Ramírez", Name="Sánchez Ramírez", Type="Province" },
            new(){ Code ="25", LocalName="Santiago", Name="Santiago", Type="Province" },
            new(){ Code ="26", LocalName="Santiago Rodríguez", Name="Santiago Rodríguez", Type="Province" },
            new(){ Code ="32", LocalName="Santo Domingo", Name="Santo Domingo", Type="Province" },
            new(){ Code ="41", LocalName="Valdesia", Name="Valdesia", Type="Region" },
            new(){ Code ="27", LocalName="Valverde", Name="Valverde", Type="Province" },
            new(){ Code ="42", LocalName="Yuma", Name="Yuma", Type="Region" }

        });
    }
}
