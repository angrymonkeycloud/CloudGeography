using AngryMonkey.Cloud.Geography;
namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    private static void FillInSubdivisionsBE()
    {
        AddSubdivisions("BE", new List<Subdivision>()
        {
            new(){ Code ="VAN", LocalName="Antwerpen", Name="Antwerp", Type="Province" },
            new(){ Code ="BRU", LocalName="Brussels Hoofdstedelijk Gewest", Name="Brussels-Capital Region", Type="Region" },
            new(){ Code ="VOV", LocalName="Oost-Vlaanderen", Name="East Flanders", Type="Province" },
            new(){ Code ="VBR", LocalName="Vlaams-Brabant", Name="Flemish Brabant", Type="Province" },
            new(){ Code ="WHT", LocalName="Henegouwen", Name="Hainaut", Type="Province" },
            new(){ Code ="WLG", LocalName="Luik", Name="Liège", Type="Province" },
            new(){ Code ="VLI", LocalName="Limburg", Name="Limburg", Type="Province" },
            new(){ Code ="WLX", LocalName="Luxemburg", Name="Luxembourg", Type="Province" },
            new(){ Code ="WNA", LocalName="Namen", Name="Namur", Type="Province" },
            new(){ Code ="WBR", LocalName="Waals-Brabant", Name="Walloon Brabant", Type="Province" },
            new(){ Code ="VWV", LocalName="West-Vlaanderen", Name="West Flanders", Type="Province" }

        });
    }
}
