using AngryMonkey.Cloud.Geography;
namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    private static void FillInSubdivisionsNR()
    {
        AddSubdivisions("NR", new List<Subdivision>()
        {
            new(){ Code ="1", LocalName="Aiwo", Name="Aiwo", Type="District" },
            new(){ Code ="2", LocalName="Anabar", Name="Anabar", Type="District" },
            new(){ Code ="3", LocalName="Anetan", Name="Anetan", Type="District" },
            new(){ Code ="4", LocalName="Anibare", Name="Anibare", Type="District" },
            new(){ Code ="5", LocalName="Baiti", Name="Baiti", Type="District" },
            new(){ Code ="6", LocalName="Boe", Name="Boe", Type="District" },
            new(){ Code ="7", LocalName="Buada", Name="Buada", Type="District" },
            new(){ Code ="8", LocalName="Denigomodu", Name="Denigomodu", Type="District" },
            new(){ Code ="9", LocalName="Ewa", Name="Ewa", Type="District" },
            new(){ Code ="10", LocalName="Ijuw", Name="Ijuw", Type="District" },
            new(){ Code ="11", LocalName="Meneng", Name="Meneng", Type="District" },
            new(){ Code ="12", LocalName="Nibok", Name="Nibok", Type="District" },
            new(){ Code ="13", LocalName="Uaboe", Name="Uaboe", Type="District" },
            new(){ Code ="14", LocalName="Yaren", Name="Yaren", Type="District" }

        });
    }
}
