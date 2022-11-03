using AngryMonkey.Cloud.Geography;
namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    private static void FillInSubdivisionsDM()
    {
        AddSubdivisions("DM", new List<Subdivision>()
        {
            new(){ Code ="2", LocalName="Saint Andrew", Name="Saint Andrew", Type="Parish" },
            new(){ Code ="3", LocalName="Saint David", Name="Saint David", Type="Parish" },
            new(){ Code ="4", LocalName="Saint George", Name="Saint George", Type="Parish" },
            new(){ Code ="5", LocalName="Saint John", Name="Saint John", Type="Parish" },
            new(){ Code ="6", LocalName="Saint Joseph", Name="Saint Joseph", Type="Parish" },
            new(){ Code ="7", LocalName="Saint Luke", Name="Saint Luke", Type="Parish" },
            new(){ Code ="8", LocalName="Saint Mark", Name="Saint Mark", Type="Parish" },
            new(){ Code ="9", LocalName="Saint Patrick", Name="Saint Patrick", Type="Parish" },
            new(){ Code ="10", LocalName="Saint Paul", Name="Saint Paul", Type="Parish" },
            new(){ Code ="11", LocalName="Saint Peter", Name="Saint Peter", Type="Parish" }

        });
    }
}
