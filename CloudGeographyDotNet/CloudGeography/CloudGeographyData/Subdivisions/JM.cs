using AngryMonkey.Cloud.Geography;
namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    private static void FillInSubdivisionsJM()
    {
        AddSubdivisions("JM", new List<Subdivision>()
        {
            new(){ Code ="13", LocalName="Clarendon", Name="Clarendon", Type="Parish" },
            new(){ Code ="9", LocalName="Hanover", Name="Hanover", Type="Parish" },
            new(){ Code ="1", LocalName="Kingston", Name="Kingston", Type="Parish" },
            new(){ Code ="12", LocalName="Manchester", Name="Manchester", Type="Parish" },
            new(){ Code ="4", LocalName="Portland", Name="Portland", Type="Parish" },
            new(){ Code ="2", LocalName="Saint Andrew", Name="Saint Andrew", Type="Parish" },
            new(){ Code ="6", LocalName="Saint Ann", Name="Saint Ann", Type="Parish" },
            new(){ Code ="14", LocalName="Saint Catherine", Name="Saint Catherine", Type="Parish" },
            new(){ Code ="11", LocalName="Saint Elizabeth", Name="Saint Elizabeth", Type="Parish" },
            new(){ Code ="8", LocalName="Saint James", Name="Saint James", Type="Parish" },
            new(){ Code ="5", LocalName="Saint Mary", Name="Saint Mary", Type="Parish" },
            new(){ Code ="3", LocalName="Saint Thomas", Name="Saint Thomas", Type="Parish" },
            new(){ Code ="7", LocalName="Trelawny", Name="Trelawny", Type="Parish" },
            new(){ Code ="10", LocalName="Westmoreland", Name="Westmoreland", Type="Parish" }

        });
    }
}
