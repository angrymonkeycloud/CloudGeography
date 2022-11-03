using AngryMonkey.Cloud.Geography;
namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    private static void FillInSubdivisionsCG()
    {
        AddSubdivisions("CG", new List<Subdivision>()
        {
            new(){ Code ="11", LocalName="Bouenza", Name="Bouenza", Type="Department" },
            new(){ Code ="BZV", LocalName="Brazzaville", Name="Brazzaville", Type="Department" },
            new(){ Code ="8", LocalName="Cuvette", Name="Cuvette", Type="Department" },
            new(){ Code ="15", LocalName="Cuvette-Ouest", Name="Cuvette-Ouest", Type="Department" },
            new(){ Code ="5", LocalName="Kouilou", Name="Kouilou", Type="Department" },
            new(){ Code ="2", LocalName="Lékoumou", Name="Lékoumou", Type="Department" },
            new(){ Code ="7", LocalName="Likouala", Name="Likouala", Type="Department" },
            new(){ Code ="9", LocalName="Niari", Name="Niari", Type="Department" },
            new(){ Code ="14", LocalName="Plateaux", Name="Plateaux", Type="Department" },
            new(){ Code ="16", LocalName="Pointe-Noire", Name="Pointe-Noire", Type="Department" },
            new(){ Code ="12", LocalName="Pool", Name="Pool", Type="Department" },
            new(){ Code ="13", LocalName="Sangha", Name="Sangha", Type="Department" }

        });
    }
}
