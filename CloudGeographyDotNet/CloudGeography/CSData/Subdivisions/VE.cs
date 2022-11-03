using AngryMonkey.Cloud.Geography;
namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    private static void FillInSubdivisionsVE()
    {
        AddSubdivisions("VE", new List<Subdivision>()
        {
            new(){ Code ="Z", LocalName="Amazonas", Name="Amazonas", Type="State" },
            new(){ Code ="B", LocalName="Anzoátegui", Name="Anzoátegui", Type="State" },
            new(){ Code ="C", LocalName="Apure", Name="Apure", Type="State" },
            new(){ Code ="D", LocalName="Aragua", Name="Aragua", Type="State" },
            new(){ Code ="E", LocalName="Barinas", Name="Barinas", Type="State" },
            new(){ Code ="F", LocalName="Bolívar", Name="Bolívar", Type="State" },
            new(){ Code ="A", LocalName="Distrito Capital", Name="Capital District", Type="District" },
            new(){ Code ="G", LocalName="Carabobo", Name="Carabobo", Type="State" },
            new(){ Code ="H", LocalName="Cojedes", Name="Cojedes", Type="State" },
            new(){ Code ="Y", LocalName="Delta Amacuro", Name="Delta Amacuro", Type="State" },
            new(){ Code ="W", LocalName="Dependencias Federales", Name="Dependencias Federales", Type="Dependencies" },
            new(){ Code ="I", LocalName="Falcón", Name="Falcón", Type="State" },
            new(){ Code ="J", LocalName="Guárico", Name="Guárico", Type="State" },
            new(){ Code ="K", LocalName="Lara", Name="Lara", Type="State" },
            new(){ Code ="L", LocalName="Mérida", Name="Mérida", Type="State" },
            new(){ Code ="M", LocalName="Miranda", Name="Miranda", Type="State" },
            new(){ Code ="N", LocalName="Monagas", Name="Monagas", Type="State" },
            new(){ Code ="O", LocalName="Nueva Esparta", Name="Nueva Esparta", Type="State" },
            new(){ Code ="P", LocalName="Portuguesa", Name="Portuguesa", Type="State" },
            new(){ Code ="R", LocalName="Sucre", Name="Sucre", Type="State" },
            new(){ Code ="S", LocalName="Táchira", Name="Táchira", Type="State" },
            new(){ Code ="T", LocalName="Trujillo", Name="Trujillo", Type="State" },
            new(){ Code ="X", LocalName="vargas", Name="vargas", Type="State" },
            new(){ Code ="U", LocalName="Yaracuy", Name="Yaracuy", Type="State" },
            new(){ Code ="V", LocalName="Zulia", Name="Zulia", Type="State" }

        });
    }
}
