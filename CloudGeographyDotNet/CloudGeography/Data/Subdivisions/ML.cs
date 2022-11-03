using AngryMonkey.Cloud.Geography;
namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    private static void FillInSubdivisionsML()
    {
        AddSubdivisions("ML", new List<Subdivision>()
        {
            new(){ Code ="BKO", LocalName="Bamako", Name="Bamako", Type="District" },
            new(){ Code ="7", LocalName="Gao", Name="Gao", Type="Region" },
            new(){ Code ="1", LocalName="Kayes", Name="Kayes", Type="Region" },
            new(){ Code ="8", LocalName="Kidal", Name="Kidal", Type="Region" },
            new(){ Code ="2", LocalName="Koulikoro", Name="Koulikoro", Type="Region" },
            new(){ Code ="5", LocalName="Mopti", Name="Mopti", Type="Region" },
            new(){ Code ="4", LocalName="Ségou", Name="Ségou", Type="Region" },
            new(){ Code ="3", LocalName="Sikasso", Name="Sikasso", Type="Region" },
            new(){ Code ="6", LocalName="Tombouctou", Name="Tombouctou", Type="Region" }

        });
    }
}
