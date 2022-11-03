using AngryMonkey.Cloud.Geography;
namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    private static void FillInSubdivisionsCZ()
    {
        AddSubdivisions("CZ", new List<Subdivision>()
        {
            new(){ Code ="31", LocalName="Jihoceský kraj", Name="Jihoceský kraj", Type="Region" },
            new(){ Code ="64", LocalName="Jihomoravský kraj", Name="Jihomoravský kraj", Type="Region" },
            new(){ Code ="41", LocalName="Karlovarský kraj", Name="Karlovarský kraj", Type="Region" },
            new(){ Code ="63", LocalName="Kraj Vysocina", Name="Kraj Vysocina", Type="Region" },
            new(){ Code ="52", LocalName="Královéhradecký kraj", Name="Královéhradecký kraj", Type="Region" },
            new(){ Code ="51", LocalName="Liberecký kraj", Name="Liberecký kraj", Type="Region" },
            new(){ Code ="80", LocalName="Moravskoslezský kraj", Name="Moravskoslezský kraj", Type="Region" },
            new(){ Code ="71", LocalName="Olomoucký kraj", Name="Olomoucký kraj", Type="Region" },
            new(){ Code ="53", LocalName="Pardubický kraj", Name="Pardubický kraj", Type="Region" },
            new(){ Code ="32", LocalName="Plzenský kraj", Name="Plzenský kraj", Type="Region" },
            new(){ Code ="10", LocalName="Praha", Name="Praha", Type="Region" },
            new(){ Code ="20", LocalName="Stredoceský kraj", Name="Stredoceský kraj", Type="Region" },
            new(){ Code ="42", LocalName="Ústecký kraj", Name="Ústecký kraj", Type="Region" },
            new(){ Code ="72", LocalName="Zlínský kraj", Name="Zlínský kraj", Type="Region" }

        });
    }
}
