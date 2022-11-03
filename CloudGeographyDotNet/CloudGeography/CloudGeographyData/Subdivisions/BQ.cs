using AngryMonkey.Cloud.Geography;
namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    private static void FillInSubdivisionsBQ()
    {
        AddSubdivisions("BQ", new List<Subdivision>()
        {
            new(){ Code ="BO", LocalName="Bonaire", Name="Bonaire", Type="Municipality" },
            new(){ Code ="SA", LocalName="Saba", Name="Saba", Type="Municipality" },
            new(){ Code ="SE", LocalName="Sint Eustatius", Name="Sint Eustatius", Type="Municipality" }

        });
    }
}
