using AngryMonkey.Cloud.Geography;
namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    private static void FillInSubdivisionsBB()
    {
        AddSubdivisions("BB", new List<Subdivision>()
        {
            new(){ Code ="1", LocalName="Christ Church", Name="Christ Church", Type="Parish" },
            new(){ Code ="2", LocalName="Saint Andrew", Name="Saint Andrew", Type="Parish" },
            new(){ Code ="3", LocalName="Saint George", Name="Saint George", Type="Parish" },
            new(){ Code ="4", LocalName="Saint James", Name="Saint James", Type="Parish" },
            new(){ Code ="5", LocalName="Saint John", Name="Saint John", Type="Parish" },
            new(){ Code ="6", LocalName="Saint Joseph", Name="Saint Joseph", Type="Parish" },
            new(){ Code ="7", LocalName="Saint Lucy", Name="Saint Lucy", Type="Parish" },
            new(){ Code ="8", LocalName="Saint Michael", Name="Saint Michael", Type="Parish" },
            new(){ Code ="9", LocalName="Saint Peter", Name="Saint Peter", Type="Parish" },
            new(){ Code ="10", LocalName="Saint Philip", Name="Saint Philip", Type="Parish" },
            new(){ Code ="11", LocalName="Saint Thomas", Name="Saint Thomas", Type="Parish" }

        });
    }
}
