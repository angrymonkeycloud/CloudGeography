using AngryMonkey.Cloud.Geography;
namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    private static void FillInSubdivisionsQA()
    {
        AddSubdivisions("QA", new List<Subdivision>()
        {
            new(){ Code ="DA", LocalName="Ad Dawhah", Name="Ad Dawhah", Type="Municipality" },
            new(){ Code ="KH", LocalName="Al Khawr wa adh Dhakhirah", Name="Al Khawr wa adh Dhakhirah", Type="Municipality" },
            new(){ Code ="WA", LocalName="Al Wakrah", Name="Al Wakrah", Type="Municipality" },
            new(){ Code ="RA", LocalName="Ar Rayyan", Name="Ar Rayyan", Type="Municipality" },
            new(){ Code ="MS", LocalName="Ash Shamal", Name="Ash Shamal", Type="Municipality" },
            new(){ Code ="ZA", LocalName="Az¸ Z¸aayin", Name="Az¸ Z¸aayin", Type="Municipality" },
            new(){ Code ="US", LocalName="Umm Salal", Name="Umm Salal", Type="Municipality" }

        });
    }
}
