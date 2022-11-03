using AngryMonkey.Cloud.Geography;
namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    private static void FillInSubdivisionsLY()
    {
        AddSubdivisions("LY", new List<Subdivision>()
        {
            new(){ Code ="BU", LocalName="Al Butnan", Name="Al Butnan", Type="Popularate" },
            new(){ Code ="JA", LocalName="Al Jabal al Akh?ar", Name="Al Jabal al Akh?ar", Type="Popularate" },
            new(){ Code ="JG", LocalName="Al Jabal al Gharbi", Name="Al Jabal al Gharbi", Type="Popularate" },
            new(){ Code ="JI", LocalName="Al Jafarah", Name="Al Jafarah", Type="Popularate" },
            new(){ Code ="JU", LocalName="Al Jufrah", Name="Al Jufrah", Type="Popularate" },
            new(){ Code ="KF", LocalName="Al Kufrah", Name="Al Kufrah", Type="Popularate" },
            new(){ Code ="MJ", LocalName="Al Marj", Name="Al Marj", Type="Popularate" },
            new(){ Code ="MB", LocalName="Al Marqab", Name="Al Marqab", Type="Popularate" },
            new(){ Code ="WA", LocalName="Al Wa?at", Name="Al Wa?at", Type="Popularate" },
            new(){ Code ="NQ", LocalName="An Nuqat al Khams", Name="An Nuqat al Khams", Type="Popularate" },
            new(){ Code ="ZA", LocalName="Az Zawiyah", Name="Az Zawiyah", Type="Popularate" },
            new(){ Code ="BA", LocalName="Banghazi", Name="Banghazi", Type="Popularate" },
            new(){ Code ="DR", LocalName="Darnah", Name="Darnah", Type="Popularate" },
            new(){ Code ="GT", LocalName="Ghat", Name="Ghat", Type="Popularate" },
            new(){ Code ="MI", LocalName="Misratah", Name="Misratah", Type="Popularate" },
            new(){ Code ="MQ", LocalName="Murzuq", Name="Murzuq", Type="Popularate" },
            new(){ Code ="NL", LocalName="Nalut", Name="Nalut", Type="Popularate" },
            new(){ Code ="SB", LocalName="Sabha", Name="Sabha", Type="Popularate" },
            new(){ Code ="SR", LocalName="Surt", Name="Surt", Type="Popularate" },
            new(){ Code ="TB", LocalName="Tarabulus", Name="Tarabulus", Type="Popularate" },
            new(){ Code ="WD", LocalName="Wadi al Hayat", Name="Wadi al Hayat", Type="Popularate" },
            new(){ Code ="WS", LocalName="Wadi ash Shati?", Name="Wadi ash Shati?", Type="Popularate" }

        });
    }
}
