using AngryMonkey.Cloud.Geography;
namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    private static void FillInSubdivisionsCR()
    {
        AddSubdivisions("CR", new List<Subdivision>()
        {
            new(){ Code ="A", LocalName="Alajuela", Name="Alajuela", Type="Province" },
            new(){ Code ="C", LocalName="Cartago", Name="Cartago", Type="Province" },
            new(){ Code ="G", LocalName="Guanacaste", Name="Guanacaste", Type="Province" },
            new(){ Code ="H", LocalName="Heredia", Name="Heredia", Type="Province" },
            new(){ Code ="L", LocalName="Limón", Name="Limón", Type="Province" },
            new(){ Code ="P", LocalName="Puntarenas", Name="Puntarenas", Type="Province" },
            new(){ Code ="SJ", LocalName="San José", Name="San José", Type="Province" }

        });
    }
}
