using AngryMonkey.Cloud.Geography;
namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    private static void FillInSubdivisionsSD()
    {
        AddSubdivisions("SD", new List<Subdivision>()
        {
            new(){ Code ="RS", LocalName="Al Ba?r al A?mar", Name="Al Ba?r al A?mar", Type="State" },
            new(){ Code ="GZ", LocalName="Al Jazirah", Name="Al Jazirah", Type="State" },
            new(){ Code ="KH", LocalName="Al Khartum", Name="Al Khartum", Type="State" },
            new(){ Code ="GD", LocalName="Al Qadarif", Name="Al Qadarif", Type="State" },
            new(){ Code ="NW", LocalName="An Nil al Abya?", Name="An Nil al Abya?", Type="State" },
            new(){ Code ="NB", LocalName="An Nil al Azraq", Name="An Nil al Azraq", Type="State" },
            new(){ Code ="NO", LocalName="Ash Shamaliyah", Name="Ash Shamaliyah", Type="State" },
            new(){ Code ="DW", LocalName="Gharb Darfur", Name="Gharb Darfur", Type="State" },
            new(){ Code ="GK", LocalName="Gharb Kurdufan", Name="Gharb Kurdufan", Type="State" },
            new(){ Code ="DS", LocalName="Janub Darfur", Name="Janub Darfur", Type="State" },
            new(){ Code ="KS", LocalName="Janub Kurdufan", Name="Janub Kurdufan", Type="State" },
            new(){ Code ="KA", LocalName="Kassala", Name="Kassala", Type="State" },
            new(){ Code ="NR", LocalName="Nahr an Nil", Name="Nahr an Nil", Type="State" },
            new(){ Code ="DN", LocalName="Shamal Darfur", Name="Shamal Darfur", Type="State" },
            new(){ Code ="DE", LocalName="Sharq Darfur", Name="Sharq Darfur", Type="State" },
            new(){ Code ="KN", LocalName="Shiamal Kurdufan", Name="Shiamal Kurdufan", Type="State" },
            new(){ Code ="SI", LocalName="Sinnar", Name="Sinnar", Type="State" },
            new(){ Code ="DC", LocalName="Wasat Darfur Zalinjay", Name="Wasat Darfur Zalinjay", Type="State" }

        });
    }
}
