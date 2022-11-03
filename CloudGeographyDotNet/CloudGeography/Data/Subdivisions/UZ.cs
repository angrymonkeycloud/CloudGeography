using AngryMonkey.Cloud.Geography;
namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    private static void FillInSubdivisionsUZ()
    {
        AddSubdivisions("UZ", new List<Subdivision>()
        {
            new(){ Code ="AN", LocalName="Andijon", Name="Andijon", Type="Region" },
            new(){ Code ="BU", LocalName="Bukhoro", Name="Bukhoro", Type="Region" },
            new(){ Code ="FA", LocalName="Fargona", Name="Fargona", Type="Region" },
            new(){ Code ="JI", LocalName="Jizzax", Name="Jizzax", Type="Region" },
            new(){ Code ="KH", LocalName="Khorazm", Name="Khorazm", Type="Region" },
            new(){ Code ="NG", LocalName="Namangan", Name="Namangan", Type="Region" },
            new(){ Code ="NW", LocalName="Nawoiy", Name="Nawoiy", Type="Region" },
            new(){ Code ="QA", LocalName="Qashqadaryo", Name="Qashqadaryo", Type="Region" },
            new(){ Code ="QR", LocalName="Qoraqalpogiston Respublikasi", Name="Qoraqalpogiston Respublikasi", Type="Republic" },
            new(){ Code ="SA", LocalName="Samarqand", Name="Samarqand", Type="Region" },
            new(){ Code ="SI", LocalName="Sirdaryo", Name="Sirdaryo", Type="Region" },
            new(){ Code ="SU", LocalName="Surkhondaryo", Name="Surkhondaryo", Type="Region" },
            new(){ Code ="TO", LocalName="Toshkent", Name="Toshkent", Type="Region" },
            new(){ Code ="TK", LocalName="Toshkent", Name="Toshkent", Type="City" },
            new(){ Code ="XO", LocalName="Xorazm", Name="Xorazm", Type="Region" }

        });
    }
}
