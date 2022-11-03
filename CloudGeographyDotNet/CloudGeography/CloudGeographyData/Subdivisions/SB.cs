using AngryMonkey.Cloud.Geography;
namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    private static void FillInSubdivisionsSB()
    {
        AddSubdivisions("SB", new List<Subdivision>()
        {
            new(){ Code ="CT", LocalName="Capital Territory", Name="Capital Territory", Type="Territory" },
            new(){ Code ="CE", LocalName="Central", Name="Central", Type="Province" },
            new(){ Code ="CH", LocalName="Choiseul", Name="Choiseul", Type="Province" },
            new(){ Code ="GU", LocalName="Guadalcanal", Name="Guadalcanal", Type="Province" },
            new(){ Code ="IS", LocalName="Isabel", Name="Isabel", Type="Province" },
            new(){ Code ="MK", LocalName="Makira-Ulawa", Name="Makira-Ulawa", Type="Province" },
            new(){ Code ="ML", LocalName="Malaita", Name="Malaita", Type="Province" },
            new(){ Code ="RB", LocalName="Rennell and Bellona", Name="Rennell and Bellona", Type="Province" },
            new(){ Code ="TE", LocalName="Temotu", Name="Temotu", Type="Province" },
            new(){ Code ="WE", LocalName="Western", Name="Western", Type="Province" }

        });
    }
}
