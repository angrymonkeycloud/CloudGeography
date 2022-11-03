using AngryMonkey.Cloud.Geography;
namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    private static void FillInSubdivisionsSY()
    {
        AddSubdivisions("SY", new List<Subdivision>()
        {
            new(){ Code ="HA", LocalName="الحسكة", Name="AI Hasakah", Type="Governorate" },
            new(){ Code ="HL", LocalName="حلب", Name="Aleppo", Type="Governorate" },
            new(){ Code ="SU", LocalName="السويداء", Name="As-Suwayda", Type="Governorate" },
            new(){ Code ="DI", LocalName="دمشق‎", Name="Damascus", Type="Governorate" },
            new(){ Code ="DR", LocalName="درعا", Name="Daraa", Type="Governorate" },
            new(){ Code ="DY", LocalName="دير الزور", Name="Deir ez-Zor", Type="Governorate" },
            new(){ Code ="HM", LocalName="حماة", Name="Hama", Type="Governorate" },
            new(){ Code ="HI", LocalName="حمص", Name="Homs", Type="Governorate" },
            new(){ Code ="ID", LocalName="ادلب", Name="Idlib", Type="Governorate" },
            new(){ Code ="LA", LocalName="اللاذقية", Name="Latakia", Type="Governorate" },
            new(){ Code ="QU", LocalName="القنيطرة", Name="Quneitra", Type="Governorate" },
            new(){ Code ="RA", LocalName="الرقة", Name="Raqqa", Type="Governorate" },
            new(){ Code ="RD", LocalName="ريف دمشق", Name="Rif Dimashq", Type="Governorate" },
            new(){ Code ="TA", LocalName="طرطوس", Name="Tartus", Type="Governorate" }

        });
    }
}
