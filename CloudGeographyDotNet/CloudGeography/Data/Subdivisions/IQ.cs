using AngryMonkey.Cloud.Geography;
namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    private static void FillInSubdivisionsIQ()
    {
        AddSubdivisions("IQ", new List<Subdivision>()
        {
            new(){ Code ="AN", LocalName="AI Anbar", Name="AI Anbar", Type="Governorate" },
            new(){ Code ="MU", LocalName="AI Muthanná", Name="AI Muthanná", Type="Governorate" },
            new(){ Code ="BA", LocalName="Al Basrah", Name="Al Basrah", Type="Governorate" },
            new(){ Code ="QA", LocalName="Al Qadisiyah", Name="Al Qadisiyah", Type="Governorate" },
            new(){ Code ="NA", LocalName="An Najaf", Name="An Najaf", Type="Governorate" },
            new(){ Code ="AR", LocalName="Arbil", Name="Arbil", Type="Governorate" },
            new(){ Code ="SU", LocalName="As Sulaymaniyah", Name="As Sulaymaniyah", Type="Governorate" },
            new(){ Code ="BB", LocalName="Babil", Name="Babil", Type="Governorate" },
            new(){ Code ="BG", LocalName="Baghdad", Name="Baghdad", Type="Governorate" },
            new(){ Code ="DA", LocalName="Dahuk", Name="Dahuk", Type="Governorate" },
            new(){ Code ="DQ", LocalName="Dhi Qar", Name="Dhi Qar", Type="Governorate" },
            new(){ Code ="DI", LocalName="Diyalá", Name="Diyalá", Type="Governorate" },
            new(){ Code ="KA", LocalName="Karbala'", Name="Karbala'", Type="Governorate" },
            new(){ Code ="KI", LocalName="Kirkuk", Name="Kirkuk", Type="Governorate" },
            new(){ Code ="MA", LocalName="Maysan", Name="Maysan", Type="Governorate" },
            new(){ Code ="NI", LocalName="Ninawá", Name="Ninawá", Type="Governorate" },
            new(){ Code ="SD", LocalName="Salah ad Din", Name="Salah ad Din", Type="Governorate" },
            new(){ Code ="WA", LocalName="Wasit", Name="Wasit", Type="Governorate" }

        });
    }
}
