using AngryMonkey.Cloud.Geography;
namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    private static void FillInSubdivisionsTD()
    {
        AddSubdivisions("TD", new List<Subdivision>()
        {
            new(){ Code ="BG", LocalName="بحر الغزال", Name="Bahr el Gazel", Type="Region" },
            new(){ Code ="BA", LocalName="البطحة", Name="Batha", Type="Region" },
            new(){ Code ="BO", LocalName="بركو", Name="Borkou", Type="Region" },
            new(){ Code ="CB", LocalName="شاري باقرمي", Name="Chari-Baguirmi", Type="Region" },
            new(){ Code ="EE", LocalName="نيدي الشرقية", Name="Ennedi-Est", Type="Region" },
            new(){ Code ="EO", LocalName="إنيدي الغربية", Name="Ennedi-Ouest", Type="Region" },
            new(){ Code ="GR", LocalName="قيرا", Name="Guéra", Type="Region" },
            new(){ Code ="HL", LocalName="حجر لميس", Name="Hadjer-Lamis", Type="Region" },
            new(){ Code ="KA", LocalName="كانم", Name="Kanem", Type="Region" },
            new(){ Code ="LC", LocalName="البحيرة", Name="Lac", Type="Region" },
            new(){ Code ="LO", LocalName="Logone-Occidental", Name="Logone-Occidental", Type="Region" },
            new(){ Code ="LR", LocalName="Logone-Oriental", Name="Logone-Oriental", Type="Region" },
            new(){ Code ="MA", LocalName="Mandoul", Name="Mandoul", Type="Region" },
            new(){ Code ="ME", LocalName="Mayo-Kebbi-Est", Name="Mayo-Kebbi-Est", Type="Region" },
            new(){ Code ="MO", LocalName="Mayo-Kebbi-Ouest", Name="Mayo-Kebbi-Ouest", Type="Region" },
            new(){ Code ="MC", LocalName="Moyen-Chari", Name="Moyen-Chari", Type="Region" },
            new(){ Code ="ND", LocalName="انجمينا‎", Name="N’Djamena", Type="Region" },
            new(){ Code ="OD", LocalName="وداي", Name="Ouaddaï", Type="Region" },
            new(){ Code ="SA", LocalName="Salamat", Name="Salamat", Type="Region" },
            new(){ Code ="SI", LocalName="Sila", Name="Sila", Type="Region" },
            new(){ Code ="TA", LocalName="Tandjilé", Name="Tandjilé", Type="Region" },
            new(){ Code ="TI", LocalName="تيبستي", Name="Tibasti", Type="Region" },
            new(){ Code ="WF", LocalName="وادي فيرا", Name="Wadi Fira", Type="Region" }

        });
    }
}
