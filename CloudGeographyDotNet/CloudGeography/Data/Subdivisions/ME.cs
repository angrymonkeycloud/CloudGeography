using AngryMonkey.Cloud.Geography;
namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    private static void FillInSubdivisionsME()
    {
        AddSubdivisions("ME", new List<Subdivision>()
        {
            new(){ Code ="21", LocalName="abljak", Name="abljak", Type="Municipality" },
            new(){ Code ="18", LocalName="avnik", Name="avnik", Type="Municipality" },
            new(){ Code ="1", LocalName="Andrijevica", Name="Andrijevica", Type="Municipality" },
            new(){ Code ="2", LocalName="Bar", Name="Bar", Type="Municipality" },
            new(){ Code ="3", LocalName="Berane", Name="Berane", Type="Municipality" },
            new(){ Code ="4", LocalName="Bijelo Polje", Name="Bijelo Polje", Type="Municipality" },
            new(){ Code ="5", LocalName="Budva", Name="Budva", Type="Municipality" },
            new(){ Code ="6", LocalName="Cetinje", Name="Cetinje", Type="Municipality" },
            new(){ Code ="7", LocalName="Danilovgrad", Name="Danilovgrad", Type="Municipality" },
            new(){ Code ="22", LocalName="Gusinje", Name="Gusinje", Type="Municipality" },
            new(){ Code ="8", LocalName="Herceg-Novi", Name="Herceg-Novi", Type="Municipality" },
            new(){ Code ="9", LocalName="Kolain", Name="Kolain", Type="Municipality" },
            new(){ Code ="10", LocalName="Kotor", Name="Kotor", Type="Municipality" },
            new(){ Code ="11", LocalName="Mojkovac", Name="Mojkovac", Type="Municipality" },
            new(){ Code ="12", LocalName="Nikic´", Name="Nikic´", Type="Municipality" },
            new(){ Code ="23", LocalName="Petnjica", Name="Petnjica", Type="Municipality" },
            new(){ Code ="13", LocalName="Plav", Name="Plav", Type="Municipality" },
            new(){ Code ="14", LocalName="Pljevlja", Name="Pljevlja", Type="Municipality" },
            new(){ Code ="15", LocalName="Pluine", Name="Pluine", Type="Municipality" },
            new(){ Code ="16", LocalName="Podgorica", Name="Podgorica", Type="Municipality" },
            new(){ Code ="17", LocalName="Roaje", Name="Roaje", Type="Municipality" },
            new(){ Code ="19", LocalName="Tivat", Name="Tivat", Type="Municipality" },
            new(){ Code ="20", LocalName="Ulcinj", Name="Ulcinj", Type="Municipality" }

        });
    }
}
