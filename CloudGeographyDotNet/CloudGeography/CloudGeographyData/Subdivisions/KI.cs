using AngryMonkey.Cloud.Geography;
namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    private static void FillInSubdivisionsKI()
    {
        AddSubdivisions("KI", new List<Subdivision>()
        {
            new(){ Code ="G", LocalName="Gilbert Islands", Name="Gilbert Islands", Type="Islands" },
            new(){ Code ="L", LocalName="Line Islands", Name="Line Islands", Type="Islands" },
            new(){ Code ="P", LocalName="Phoenix Islands", Name="Phoenix Islands", Type="Islands" }

        });
    }
}
