using AngryMonkey.Cloud.Geography;
namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    private static void FillInSubdivisionsKG()
    {
        AddSubdivisions("KG", new List<Subdivision>()
        {
            new(){ Code ="B", LocalName="Batken", Name="Batken", Type="Region" },
            new(){ Code ="GB", LocalName="Bishkek", Name="Bishkek", Type="City" },
            new(){ Code ="C", LocalName="Chüy", Name="Chüy", Type="Region" },
            new(){ Code ="J", LocalName="Jalal-Abad", Name="Jalal-Abad", Type="Region" },
            new(){ Code ="N", LocalName="Naryn", Name="Naryn", Type="Region" },
            new(){ Code ="GO", LocalName="Osh", Name="Osh", Type="City" },
            new(){ Code ="O", LocalName="Osh", Name="Osh", Type="Region" },
            new(){ Code ="T", LocalName="Talas", Name="Talas", Type="Region" },
            new(){ Code ="Y", LocalName="Ysyk-Köl", Name="Ysyk-Köl", Type="Region" }

        });
    }
}
