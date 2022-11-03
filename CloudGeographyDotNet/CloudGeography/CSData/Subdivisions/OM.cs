using AngryMonkey.Cloud.Geography;
namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    private static void FillInSubdivisionsOM()
    {
        AddSubdivisions("OM", new List<Subdivision>()
        {
            new(){ Code ="DA", LocalName="Ad Dakhiliyah", Name="Ad Dakhiliyah", Type="Governorate" },
            new(){ Code ="WU", LocalName="AI Wusta", Name="AI Wusta", Type="Governorate" },
            new(){ Code ="BU", LocalName="Al Buraymi", Name="Al Buraymi", Type="Governorate" },
            new(){ Code ="ZA", LocalName="Az Zahirah", Name="Az Zahirah", Type="Region" },
            new(){ Code ="BJ", LocalName="Janub al Batinah", Name="Janub al Batinah", Type="Governorate" },
            new(){ Code ="SJ", LocalName="Janub ash Sharqiyah", Name="Janub ash Sharqiyah", Type="Governorate" },
            new(){ Code ="MA", LocalName="Masqat", Name="Masqat", Type="Governorate" },
            new(){ Code ="MU", LocalName="Musandam", Name="Musandam", Type="Governorate" },
            new(){ Code ="BS", LocalName="Shamal al Batinah", Name="Shamal al Batinah", Type="Governorate" },
            new(){ Code ="SS", LocalName="Shamal ash Sharqiyah", Name="Shamal ash Sharqiyah", Type="Governorate" },
            new(){ Code ="ZU", LocalName="Z¸ufar", Name="Z¸ufar", Type="Governorate" }

        });
    }
}
