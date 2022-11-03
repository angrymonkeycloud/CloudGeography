using AngryMonkey.Cloud.Geography;
namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    private static void FillInSubdivisionsAR()
    {
        AddSubdivisions("AR", new List<Subdivision>()
        {
            new(){ Code ="B", LocalName="Buenos Aires", Name="Buenos Aires", Type="Province" },
            new(){ Code ="K", LocalName="Catamarca", Name="Catamarca", Type="Province" },
            new(){ Code ="H", LocalName="Chaco", Name="Chaco", Type="Province" },
            new(){ Code ="U", LocalName="Chubut", Name="Chubut", Type="Province" },
            new(){ Code ="C", LocalName="Ciudad Autónoma de Buenos Aires", Name="Ciudad Autónoma de Buenos Aires", Type="City" },
            new(){ Code ="X", LocalName="Córdoba", Name="Córdoba", Type="Province" },
            new(){ Code ="W", LocalName="Corrientes", Name="Corrientes", Type="Province" },
            new(){ Code ="E", LocalName="Entre Ríos", Name="Entre Ríos", Type="Province" },
            new(){ Code ="P", LocalName="Formosa", Name="Formosa", Type="Province" },
            new(){ Code ="Y", LocalName="Jujuy", Name="Jujuy", Type="Province" },
            new(){ Code ="L", LocalName="La Pampa", Name="La Pampa", Type="Province" },
            new(){ Code ="F", LocalName="La Rioja", Name="La Rioja", Type="Province" },
            new(){ Code ="M", LocalName="Mendoza", Name="Mendoza", Type="Province" },
            new(){ Code ="N", LocalName="Misiones", Name="Misiones", Type="Province" },
            new(){ Code ="Q", LocalName="Neuquén", Name="Neuquén", Type="Province" },
            new(){ Code ="R", LocalName="Río Negro", Name="Río Negro", Type="Province" },
            new(){ Code ="A", LocalName="Salta", Name="Salta", Type="Province" },
            new(){ Code ="J", LocalName="San Juan", Name="San Juan", Type="Province" },
            new(){ Code ="D", LocalName="San Luis", Name="San Luis", Type="Province" },
            new(){ Code ="Z", LocalName="Santa Cruz", Name="Santa Cruz", Type="Province" },
            new(){ Code ="S", LocalName="Santa Fe", Name="Santa Fe", Type="Province" },
            new(){ Code ="G", LocalName="Santiago del Estero", Name="Santiago del Estero", Type="Province" },
            new(){ Code ="V", LocalName="Tierra del Fuego", Name="Tierra del Fuego", Type="Province" },
            new(){ Code ="T", LocalName="Tucumán", Name="Tucumán", Type="Province" }

        });
    }
}
