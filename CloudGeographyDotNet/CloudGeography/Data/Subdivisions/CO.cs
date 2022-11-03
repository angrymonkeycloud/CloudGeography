using AngryMonkey.Cloud.Geography;
namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    private static void FillInSubdivisionsCO()
    {
        AddSubdivisions("CO", new List<Subdivision>()
        {
            new(){ Code ="AMA", LocalName="Amazonas", Name="Amazonas", Type="Department" },
            new(){ Code ="ANT", LocalName="Antioquia", Name="Antioquia", Type="Department" },
            new(){ Code ="ARA", LocalName="Arauca", Name="Arauca", Type="Department" },
            new(){ Code ="ATL", LocalName="Atlántico", Name="Atlántico", Type="Department" },
            new(){ Code ="BOL", LocalName="Bolívar", Name="Bolívar", Type="Department" },
            new(){ Code ="BOY", LocalName="Boyacá", Name="Boyacá", Type="Department" },
            new(){ Code ="CAL", LocalName="Caldas", Name="Caldas", Type="Department" },
            new(){ Code ="CAQ", LocalName="Caquetá", Name="Caquetá", Type="Department" },
            new(){ Code ="CAS", LocalName="Casanare", Name="Casanare", Type="Department" },
            new(){ Code ="CAU", LocalName="Cauca", Name="Cauca", Type="Department" },
            new(){ Code ="CES", LocalName="Cesar", Name="Cesar", Type="Department" },
            new(){ Code ="CHO", LocalName="Chocó", Name="Chocó", Type="Department" },
            new(){ Code ="COR", LocalName="Córdoba", Name="Córdoba", Type="Department" },
            new(){ Code ="CUN", LocalName="Cundinamarca", Name="Cundinamarca", Type="Department" },
            new(){ Code ="DC", LocalName="Distrito Capital de Bogotá", Name="Distrito Capital de Bogotá", Type="District" },
            new(){ Code ="GUA", LocalName="Guainía", Name="Guainía", Type="Department" },
            new(){ Code ="GUV", LocalName="Guaviare", Name="Guaviare", Type="Department" },
            new(){ Code ="HUI", LocalName="Huila", Name="Huila", Type="Department" },
            new(){ Code ="LAG", LocalName="La Guajira", Name="La Guajira", Type="Department" },
            new(){ Code ="MAG", LocalName="Magdalena", Name="Magdalena", Type="Department" },
            new(){ Code ="MET", LocalName="Meta", Name="Meta", Type="Department" },
            new(){ Code ="NAR", LocalName="Nariño", Name="Nariño", Type="Department" },
            new(){ Code ="NSA", LocalName="Norte de Santander", Name="Norte de Santander", Type="Department" },
            new(){ Code ="PUT", LocalName="Putumayo", Name="Putumayo", Type="Department" },
            new(){ Code ="QUI", LocalName="Quindío", Name="Quindío", Type="Department" },
            new(){ Code ="RIS", LocalName="Risaralda", Name="Risaralda", Type="Department" },
            new(){ Code ="SAP", LocalName="San Andrés", Name="San Andrés", Type="Department" },
            new(){ Code ="SAN", LocalName="Santander", Name="Santander", Type="Department" },
            new(){ Code ="SUC", LocalName="Sucre", Name="Sucre", Type="Department" },
            new(){ Code ="TOL", LocalName="Tolima", Name="Tolima", Type="Department" },
            new(){ Code ="VAC", LocalName="Valle del Cauca", Name="Valle del Cauca", Type="Department" },
            new(){ Code ="VAU", LocalName="Vaupés", Name="Vaupés", Type="Department" },
            new(){ Code ="VID", LocalName="Vichada", Name="Vichada", Type="Department" }

        });
    }
}
