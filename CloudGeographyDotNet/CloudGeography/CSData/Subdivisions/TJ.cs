using AngryMonkey.Cloud.Geography;
namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    private static void FillInSubdivisionsTJ()
    {
        AddSubdivisions("TJ", new List<Subdivision>()
        {
            new(){ Code ="DU", LocalName="Dushanbe", Name="Dushanbe", Type="Territory" },
            new(){ Code ="KT", LocalName="Khatlon", Name="Khatlon", Type="Region" },
            new(){ Code ="GB", LocalName="Kuhistoni Badakhshon", Name="Kuhistoni Badakhshon", Type="Region" },
            new(){ Code ="RA", LocalName="Nohiyahoi Tobei Jumhurí", Name="Nohiyahoi Tobei Jumhurí", Type="District" },
            new(){ Code ="SU", LocalName="Sughd", Name="Sughd", Type="Region" }

        });
    }
}
