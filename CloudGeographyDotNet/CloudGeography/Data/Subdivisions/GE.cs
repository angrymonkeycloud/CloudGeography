using AngryMonkey.Cloud.Geography;
namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    private static void FillInSubdivisionsGE()
    {
        AddSubdivisions("GE", new List<Subdivision>()
        {
            new(){ Code ="AB", LocalName="აფხაზეთი", Name="Abkhazia", Type="Republic" },
            new(){ Code ="AJ", LocalName="აჭარა", Name="Ajaria", Type="Republic" },
            new(){ Code ="GU", LocalName="გურია", Name="Guria", Type="Region" },
            new(){ Code ="IM", LocalName="იმერეთი", Name="Imereti", Type="Region" },
            new(){ Code ="KA", LocalName="კახეთი", Name="Kakheti", Type="Region" },
            new(){ Code ="KK", LocalName="ქვემო ქართლი", Name="Kvemo Kartli", Type="Region" },
            new(){ Code ="MM", LocalName="მცხეთა-მთიანეთი", Name="Mtskheta-Mtianeti", Type="Region" },
            new(){ Code ="RL", LocalName="რაჭა-ლეჩხუმი და ქვემო სვანეთი", Name="Racha-Lechkhumi and Kvemo Svaneti", Type="Region" },
            new(){ Code ="SZ", LocalName="სამეგრელო-ზემო სვანეთი", Name="Samegrelo-Zemo Svaneti", Type="Region" },
            new(){ Code ="SJ", LocalName="სამცხე-ჯავახეთი", Name="Samtskhe-Javakheti", Type="Region" },
            new(){ Code ="SK", LocalName="შიდა ქართლი", Name="Shida Kartli", Type="Region" },
            new(){ Code ="TB", LocalName="თბილისი", Name="Tbilisi", Type="City" }

        });
    }
}
