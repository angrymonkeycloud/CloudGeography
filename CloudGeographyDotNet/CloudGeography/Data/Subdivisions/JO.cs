using AngryMonkey.Cloud.Geography;
namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    private static void FillInSubdivisionsJO()
    {
        AddSubdivisions("JO", new List<Subdivision>()
        {
            new(){ Code ="AJ", LocalName="Ajlun", Name="Ajlun", Type="Governorate" },
            new(){ Code ="KA", LocalName="AI Karak", Name="AI Karak", Type="Governorate" },
            new(){ Code ="MA", LocalName="AI Mafraq", Name="AI Mafraq", Type="Governorate" },
            new(){ Code ="AM", LocalName="Al A¯simah", Name="Al A¯simah", Type="Governorate" },
            new(){ Code ="AQ", LocalName="Al Aqabah", Name="Al Aqabah", Type="Governorate" },
            new(){ Code ="BA", LocalName="Al Balqa", Name="Al Balqa", Type="Governorate" },
            new(){ Code ="AT", LocalName="At Tafilah", Name="At Tafilah", Type="Governorate" },
            new(){ Code ="AZ", LocalName="Az Zarqa", Name="Az Zarqa", Type="Governorate" },
            new(){ Code ="IR", LocalName="Irbid", Name="Irbid", Type="Governorate" },
            new(){ Code ="JA", LocalName="Jarash", Name="Jarash", Type="Governorate" },
            new(){ Code ="MN", LocalName="Maan", Name="Maan", Type="Governorate" },
            new(){ Code ="MD", LocalName="Madaba", Name="Madaba", Type="Governorate" }

        });
    }
}
