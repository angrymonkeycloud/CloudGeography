using AngryMonkey.Cloud.Geography;
namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    private static void FillInSubdivisionsNI()
    {
        AddSubdivisions("NI", new List<Subdivision>()
        {
            new(){ Code ="AN", LocalName="Atlántico Norte", Name="Atlántico Norte", Type="Region" },
            new(){ Code ="AS", LocalName="Atlántico Sur", Name="Atlántico Sur", Type="Region" },
            new(){ Code ="BO", LocalName="Boaco", Name="Boaco", Type="Department" },
            new(){ Code ="CA", LocalName="Carazo", Name="Carazo", Type="Department" },
            new(){ Code ="CI", LocalName="Chinandega", Name="Chinandega", Type="Department" },
            new(){ Code ="CO", LocalName="Chontales", Name="Chontales", Type="Department" },
            new(){ Code ="ES", LocalName="Estelí", Name="Estelí", Type="Department" },
            new(){ Code ="GR", LocalName="Granada", Name="Granada", Type="Department" },
            new(){ Code ="JI", LocalName="Jinotega", Name="Jinotega", Type="Department" },
            new(){ Code ="LE", LocalName="León", Name="León", Type="Department" },
            new(){ Code ="MD", LocalName="Madriz", Name="Madriz", Type="Department" },
            new(){ Code ="MN", LocalName="Managua", Name="Managua", Type="Department" },
            new(){ Code ="MS", LocalName="Masaya", Name="Masaya", Type="Department" },
            new(){ Code ="MT", LocalName="Matagalpa", Name="Matagalpa", Type="Department" },
            new(){ Code ="NS", LocalName="Nueva Segovia", Name="Nueva Segovia", Type="Department" },
            new(){ Code ="SJ", LocalName="Río San Juan", Name="Río San Juan", Type="Department" },
            new(){ Code ="RI", LocalName="Rivas", Name="Rivas", Type="Department" }

        });
    }
}
