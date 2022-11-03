using AngryMonkey.Cloud.Geography;
namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    private static void FillInSubdivisionsMX()
    {
        AddSubdivisions("MX", new List<Subdivision>()
        {
            new(){ Code ="AGU", LocalName="Aguascalientes", Name="Aguascalientes", Type="State" },
            new(){ Code ="BCN", LocalName="Baja California", Name="Baja California", Type="State" },
            new(){ Code ="BCS", LocalName="Baja California Sur", Name="Baja California Sur", Type="State" },
            new(){ Code ="CAM", LocalName="Campeche", Name="Campeche", Type="State" },
            new(){ Code ="CHP", LocalName="Chiapas", Name="Chiapas", Type="State" },
            new(){ Code ="CHH", LocalName="Chihuahua", Name="Chihuahua", Type="State" },
            new(){ Code ="CMX", LocalName="Ciudad de Mexico", Name="Ciudad de Mexico", Type="District" },
            new(){ Code ="COA", LocalName="Coahuila de Zaragoza", Name="Coahuila de Zaragoza", Type="State" },
            new(){ Code ="COL", LocalName="Colima", Name="Colima", Type="State" },
            new(){ Code ="DUR", LocalName="Durango", Name="Durango", Type="State" },
            new(){ Code ="GUA", LocalName="Guanajuato", Name="Guanajuato", Type="State" },
            new(){ Code ="GRO", LocalName="Guerrero", Name="Guerrero", Type="State" },
            new(){ Code ="HID", LocalName="Hidalgo", Name="Hidalgo", Type="State" },
            new(){ Code ="JAL", LocalName="Jalisco", Name="Jalisco", Type="State" },
            new(){ Code ="MEX", LocalName="México", Name="México", Type="State" },
            new(){ Code ="MIC", LocalName="Michoacán de Ocampo", Name="Michoacán de Ocampo", Type="State" },
            new(){ Code ="MOR", LocalName="Morelos", Name="Morelos", Type="State" },
            new(){ Code ="NAY", LocalName="Nayarit", Name="Nayarit", Type="State" },
            new(){ Code ="NLE", LocalName="Nuevo León", Name="Nuevo León", Type="State" },
            new(){ Code ="OAX", LocalName="Oaxaca", Name="Oaxaca", Type="State" },
            new(){ Code ="PUE", LocalName="Puebla", Name="Puebla", Type="State" },
            new(){ Code ="QUE", LocalName="Querétaro", Name="Querétaro", Type="State" },
            new(){ Code ="ROO", LocalName="Quintana Roo", Name="Quintana Roo", Type="State" },
            new(){ Code ="SLP", LocalName="San Luis Potosí", Name="San Luis Potosí", Type="State" },
            new(){ Code ="SIN", LocalName="Sinaloa", Name="Sinaloa", Type="State" },
            new(){ Code ="SON", LocalName="Sonora", Name="Sonora", Type="State" },
            new(){ Code ="TAB", LocalName="Tabasco", Name="Tabasco", Type="State" },
            new(){ Code ="TAM", LocalName="Tamaulipas", Name="Tamaulipas", Type="State" },
            new(){ Code ="TLA", LocalName="Tlaxcala", Name="Tlaxcala", Type="State" },
            new(){ Code ="VER", LocalName="Veracruz de Ignacio de la Llave", Name="Veracruz de Ignacio de la Llave", Type="State" },
            new(){ Code ="YUC", LocalName="Yucatán", Name="Yucatán", Type="State" },
            new(){ Code ="ZAC", LocalName="Zacatecas", Name="Zacatecas", Type="State" }

        });
    }
}
