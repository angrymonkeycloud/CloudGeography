using AngryMonkey.Cloud.Geography;
namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    private static void FillInSubdivisionsAE()
    {
        AddSubdivisions("AE", new List<Subdivision>()
        {
            new(){ Code ="AZ", LocalName="أَبُـوظَـبِي", Name="Abu Dhabi", Type="Emirate" },
            new(){ Code ="AJ", LocalName="عجمان", Name="Ajman", Type="Emirate" },
            new(){ Code ="FU", LocalName="الفجيرة", Name="Al Fujairah", Type="Emirate" },
            new(){ Code ="DU", LocalName="دبيّ", Name="Dubai", Type="Emirate" },
            new(){ Code ="RK", LocalName="رَأْس ٱلْخَيْمَة", Name="Ras Al Khaimah", Type="Emirate" },
            new(){ Code ="SH", LocalName="ٱلشَّارِقَة", Name="Sharjah", Type="Emirate" },
            new(){ Code ="UQ", LocalName="أم القيوين", Name="Umm Al Quwain", Type="Emirate" }

        });
    }
}
