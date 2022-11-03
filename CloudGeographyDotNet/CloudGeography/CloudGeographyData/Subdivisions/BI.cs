using AngryMonkey.Cloud.Geography;
namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    private static void FillInSubdivisionsBI()
    {
        AddSubdivisions("BI", new List<Subdivision>()
        {
            new(){ Code ="BB", LocalName="Bubanza", Name="Bubanza", Type="Province" },
            new(){ Code ="BM", LocalName="Bujumbura Mairie", Name="Bujumbura Mairie", Type="Province" },
            new(){ Code ="BL", LocalName="Bujumbura Rural", Name="Bujumbura Rural", Type="Province" },
            new(){ Code ="BR", LocalName="Bururi", Name="Bururi", Type="Province" },
            new(){ Code ="CA", LocalName="Cankuzo", Name="Cankuzo", Type="Province" },
            new(){ Code ="CI", LocalName="Cibitoke", Name="Cibitoke", Type="Province" },
            new(){ Code ="GI", LocalName="Gitega", Name="Gitega", Type="Province" },
            new(){ Code ="KR", LocalName="Karuzi", Name="Karuzi", Type="Province" },
            new(){ Code ="KY", LocalName="Kayanza", Name="Kayanza", Type="Province" },
            new(){ Code ="KI", LocalName="Kirundo", Name="Kirundo", Type="Province" },
            new(){ Code ="MA", LocalName="Makamba", Name="Makamba", Type="Province" },
            new(){ Code ="MU", LocalName="Muramvya", Name="Muramvya", Type="Province" },
            new(){ Code ="MY", LocalName="Muyinga", Name="Muyinga", Type="Province" },
            new(){ Code ="MW", LocalName="Mwaro", Name="Mwaro", Type="Province" },
            new(){ Code ="NG", LocalName="Ngozi", Name="Ngozi", Type="Province" },
            new(){ Code ="RM", LocalName="Rumonge", Name="Rumonge", Type="Province" },
            new(){ Code ="RT", LocalName="Rutana", Name="Rutana", Type="Province" },
            new(){ Code ="RY", LocalName="Ruyigi", Name="Ruyigi", Type="Province" }

        });
    }
}
