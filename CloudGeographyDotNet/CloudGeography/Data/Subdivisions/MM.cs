using AngryMonkey.Cloud.Geography;
namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    private static void FillInSubdivisionsMM()
    {
        AddSubdivisions("MM", new List<Subdivision>()
        {
            new(){ Code ="7", LocalName="Ayeyarwady", Name="Ayeyarwady", Type="Region" },
            new(){ Code ="2", LocalName="Bago", Name="Bago", Type="Region" },
            new(){ Code ="14", LocalName="Chin", Name="Chin", Type="State" },
            new(){ Code ="11", LocalName="Kachin", Name="Kachin", Type="State" },
            new(){ Code ="12", LocalName="Kayah", Name="Kayah", Type="State" },
            new(){ Code ="13", LocalName="Kayin", Name="Kayin", Type="State" },
            new(){ Code ="3", LocalName="Magway", Name="Magway", Type="Region" },
            new(){ Code ="4", LocalName="Mandalay", Name="Mandalay", Type="Region" },
            new(){ Code ="15", LocalName="Mon", Name="Mon", Type="State" },
            new(){ Code ="16", LocalName="Rakhine", Name="Rakhine", Type="State" },
            new(){ Code ="1", LocalName="Sagaing", Name="Sagaing", Type="Region" },
            new(){ Code ="17", LocalName="Shan", Name="Shan", Type="State" },
            new(){ Code ="5", LocalName="Tanintharyi", Name="Tanintharyi", Type="Region" },
            new(){ Code ="6", LocalName="Yangon", Name="Yangon", Type="Region" }

        });
    }
}
