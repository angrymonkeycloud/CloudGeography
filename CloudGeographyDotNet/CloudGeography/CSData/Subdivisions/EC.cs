using AngryMonkey.Cloud.Geography;
namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    private static void FillInSubdivisionsEC()
    {
        AddSubdivisions("EC", new List<Subdivision>()
        {
            new(){ Code ="A", LocalName="Azuay", Name="Azuay", Type="Province" },
            new(){ Code ="B", LocalName="Bolívar", Name="Bolívar", Type="Province" },
            new(){ Code ="F", LocalName="Cañar", Name="Cañar", Type="Province" },
            new(){ Code ="C", LocalName="Carchi", Name="Carchi", Type="Province" },
            new(){ Code ="H", LocalName="Chimborazo", Name="Chimborazo", Type="Province" },
            new(){ Code ="X", LocalName="Cotopaxi", Name="Cotopaxi", Type="Province" },
            new(){ Code ="O", LocalName="El Oro", Name="El Oro", Type="Province" },
            new(){ Code ="E", LocalName="Esmeraldas", Name="Esmeraldas", Type="Province" },
            new(){ Code ="W", LocalName="Galápagos", Name="Galápagos", Type="Province" },
            new(){ Code ="G", LocalName="Guayas", Name="Guayas", Type="Province" },
            new(){ Code ="I", LocalName="Imbabura", Name="Imbabura", Type="Province" },
            new(){ Code ="L", LocalName="Loja", Name="Loja", Type="Province" },
            new(){ Code ="R", LocalName="Los Ríos", Name="Los Ríos", Type="Province" },
            new(){ Code ="M", LocalName="Manabí", Name="Manabí", Type="Province" },
            new(){ Code ="S", LocalName="Morona-Santiago", Name="Morona-Santiago", Type="Province" },
            new(){ Code ="N", LocalName="Napo", Name="Napo", Type="Province" },
            new(){ Code ="D", LocalName="Orellana", Name="Orellana", Type="Province" },
            new(){ Code ="Y", LocalName="Pastaza", Name="Pastaza", Type="Province" },
            new(){ Code ="P", LocalName="Pichincha", Name="Pichincha", Type="Province" },
            new(){ Code ="SE", LocalName="Santa Elena", Name="Santa Elena", Type="Province" },
            new(){ Code ="SD", LocalName="Santo Domingo de los Tsáchilas", Name="Santo Domingo de los Tsáchilas", Type="Province" },
            new(){ Code ="U", LocalName="Sucumbíos", Name="Sucumbíos", Type="Province" },
            new(){ Code ="T", LocalName="Tungurahua", Name="Tungurahua", Type="Province" },
            new(){ Code ="Z", LocalName="Zamora-Chinchipe", Name="Zamora-Chinchipe", Type="Province" }

        });
    }
}
