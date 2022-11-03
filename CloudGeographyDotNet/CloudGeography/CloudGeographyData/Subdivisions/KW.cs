using AngryMonkey.Cloud.Geography;
namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    private static void FillInSubdivisionsKW()
    {
        AddSubdivisions("KW", new List<Subdivision>()
        {
            new(){ Code ="HA", LocalName="?awalli", Name="?awalli", Type="Governorate" },
            new(){ Code ="KU", LocalName="Al Asimah", Name="Al Asimah", Type="Governorate" },
            new(){ Code ="AH", LocalName="Al A?madi", Name="Al A?madi", Type="Governorate" },
            new(){ Code ="FA", LocalName="Al Farwaniyah", Name="Al Farwaniyah", Type="Governorate" },
            new(){ Code ="JA", LocalName="Al Jahra", Name="Al Jahra", Type="Governorate" },
            new(){ Code ="MU", LocalName="Mubarak al Kabir", Name="Mubarak al Kabir", Type="Governorate" }

        });
    }
}
