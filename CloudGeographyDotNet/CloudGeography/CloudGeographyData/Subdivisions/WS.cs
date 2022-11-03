using AngryMonkey.Cloud.Geography;
namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    private static void FillInSubdivisionsWS()
    {
        AddSubdivisions("WS", new List<Subdivision>()
        {
            new(){ Code ="AA", LocalName="A'ana", Name="A'ana", Type="District" },
            new(){ Code ="AL", LocalName="Aiga-i-le-Tai", Name="Aiga-i-le-Tai", Type="District" },
            new(){ Code ="AT", LocalName="Atua", Name="Atua", Type="District" },
            new(){ Code ="FA", LocalName="Fa'asaleleaga", Name="Fa'asaleleaga", Type="District" },
            new(){ Code ="GE", LocalName="Gaga'emauga", Name="Gaga'emauga", Type="District" },
            new(){ Code ="GI", LocalName="Gagaifomauga", Name="Gagaifomauga", Type="District" },
            new(){ Code ="PA", LocalName="Palauli", Name="Palauli", Type="District" },
            new(){ Code ="SA", LocalName="Satupa 'itea", Name="Satupa 'itea", Type="District" },
            new(){ Code ="TU", LocalName="Tuamasaga", Name="Tuamasaga", Type="District" },
            new(){ Code ="VF", LocalName="Va'a-o-Fonoti", Name="Va'a-o-Fonoti", Type="District" },
            new(){ Code ="VS", LocalName="Vaisigano", Name="Vaisigano", Type="District" }

        });
    }
}
