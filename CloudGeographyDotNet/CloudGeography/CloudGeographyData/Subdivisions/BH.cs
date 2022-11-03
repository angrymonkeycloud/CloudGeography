using AngryMonkey.Cloud.Geography;
namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    private static void FillInSubdivisionsBH()
    {
        AddSubdivisions("BH", new List<Subdivision>()
        {
            new(){ Code ="13", LocalName="محافظة العاصمة", Name="Capital Governorate", Type="Governorate" },
            new(){ Code ="15", LocalName="محافظة المحرق", Name="Muharraq Governorate", Type="Governorate" },
            new(){ Code ="17", LocalName="المحافظة الشمالية", Name="Northern Governorate", Type="Governorate" },
            new(){ Code ="14", LocalName="المحافظة الجنوبية", Name="Southern Governorate", Type="Governorate" }

        });
    }
}
