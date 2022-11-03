using AngryMonkey.Cloud.Geography;
namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    private static void FillInSubdivisionsMG()
    {
        AddSubdivisions("MG", new List<Subdivision>()
        {
            new(){ Code ="T", LocalName="Antananarivo", Name="Antananarivo", Type="Province" },
            new(){ Code ="D", LocalName="Antsiranana", Name="Antsiranana", Type="Province" },
            new(){ Code ="F", LocalName="Fianarantsoa", Name="Fianarantsoa", Type="Province" },
            new(){ Code ="M", LocalName="Mahajanga", Name="Mahajanga", Type="Province" },
            new(){ Code ="A", LocalName="Toamasina", Name="Toamasina", Type="Province" },
            new(){ Code ="U", LocalName="Toliara", Name="Toliara", Type="Province" }

        });
    }
}
