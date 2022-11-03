using AngryMonkey.Cloud.Geography;
namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    private static void FillInSubdivisionsCI()
    {
        AddSubdivisions("CI", new List<Subdivision>()
        {
            new(){ Code ="AB", LocalName="Abidjan", Name="Abidjan", Type="District" },
            new(){ Code ="BS", LocalName="Bas-Sassandra", Name="Bas-Sassandra", Type="District" },
            new(){ Code ="CM", LocalName="Comoé", Name="Comoé", Type="District" },
            new(){ Code ="DN", LocalName="Denguélé", Name="Denguélé", Type="District" },
            new(){ Code ="GD", LocalName="Gôh-Djiboua", Name="Gôh-Djiboua", Type="District" },
            new(){ Code ="LC", LocalName="Lacs", Name="Lacs", Type="District" },
            new(){ Code ="LG", LocalName="Lagunes", Name="Lagunes", Type="District" },
            new(){ Code ="MG", LocalName="Montagnes", Name="Montagnes", Type="District" },
            new(){ Code ="SM", LocalName="Sassandra-Marahoué", Name="Sassandra-Marahoué", Type="District" },
            new(){ Code ="SV", LocalName="Savanes", Name="Savanes", Type="District" },
            new(){ Code ="VB", LocalName="Vallée du Bandama", Name="Vallée du Bandama", Type="District" },
            new(){ Code ="WR", LocalName="Woroba", Name="Woroba", Type="District" },
            new(){ Code ="YM", LocalName="Yamoussoukro", Name="Yamoussoukro", Type="District" },
            new(){ Code ="ZZ", LocalName="Zanzan", Name="Zanzan", Type="District" }

        });
    }
}
