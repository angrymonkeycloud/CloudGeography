using AngryMonkey.Cloud.Geography;
namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    private static void FillInSubdivisionsNP()
    {
        AddSubdivisions("NP", new List<Subdivision>()
        {
            new(){ Code ="BA", LocalName="Bagmati", Name="Bagmati", Type="Zone" },
            new(){ Code ="BH", LocalName="Bheri", Name="Bheri", Type="Zone" },
            new(){ Code ="DH", LocalName="Dhawalagiri", Name="Dhawalagiri", Type="Zone" },
            new(){ Code ="GA", LocalName="Gandaki", Name="Gandaki", Type="Zone" },
            new(){ Code ="JA", LocalName="Janakpur", Name="Janakpur", Type="Zone" },
            new(){ Code ="KA", LocalName="Karnali", Name="Karnali", Type="Zone" },
            new(){ Code ="KO", LocalName="Kosi", Name="Kosi", Type="Zone" },
            new(){ Code ="LU", LocalName="Lumbini", Name="Lumbini", Type="Zone" },
            new(){ Code ="MA", LocalName="Mahakali", Name="Mahakali", Type="Zone" },
            new(){ Code ="ME", LocalName="Mechi", Name="Mechi", Type="Zone" },
            new(){ Code ="NA", LocalName="Narayani", Name="Narayani", Type="Zone" },
            new(){ Code ="RA", LocalName="Rapti", Name="Rapti", Type="Zone" },
            new(){ Code ="SA", LocalName="Sagarmatha", Name="Sagarmatha", Type="Zone" },
            new(){ Code ="SE", LocalName="Seti", Name="Seti", Type="Zone" }

        });
    }
}
