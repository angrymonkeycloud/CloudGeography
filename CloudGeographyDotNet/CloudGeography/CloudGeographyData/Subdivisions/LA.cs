using AngryMonkey.Cloud.Geography;
namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    private static void FillInSubdivisionsLA()
    {
        AddSubdivisions("LA", new List<Subdivision>()
        {
            new(){ Code ="AT", LocalName="Attapu", Name="Attapu", Type="Province" },
            new(){ Code ="BK", LocalName="Bokèo", Name="Bokèo", Type="Province" },
            new(){ Code ="BL", LocalName="Bolikhamxai", Name="Bolikhamxai", Type="Province" },
            new(){ Code ="CH", LocalName="Champasak", Name="Champasak", Type="Province" },
            new(){ Code ="HO", LocalName="Houaphan", Name="Houaphan", Type="Province" },
            new(){ Code ="KH", LocalName="Khammouan", Name="Khammouan", Type="Province" },
            new(){ Code ="LM", LocalName="Louang Namtha", Name="Louang Namtha", Type="Province" },
            new(){ Code ="LP", LocalName="Louangphabang", Name="Louangphabang", Type="Province" },
            new(){ Code ="OU", LocalName="Oudômxai", Name="Oudômxai", Type="Province" },
            new(){ Code ="PH", LocalName="Phôngsali", Name="Phôngsali", Type="Province" },
            new(){ Code ="SL", LocalName="Salavan", Name="Salavan", Type="Province" },
            new(){ Code ="SV", LocalName="Savannakhét", Name="Savannakhét", Type="Province" },
            new(){ Code ="VI", LocalName="Vientiane", Name="Vientiane", Type="Province" },
            new(){ Code ="VT", LocalName="Vientiane", Name="Vientiane", Type="Prefecture" },
            new(){ Code ="XA", LocalName="Xaignabouli", Name="Xaignabouli", Type="Province" },
            new(){ Code ="XS", LocalName="Xaisômboun", Name="Xaisômboun", Type="Province" },
            new(){ Code ="XE", LocalName="Xékong", Name="Xékong", Type="Province" },
            new(){ Code ="XI", LocalName="Xiangkhouang", Name="Xiangkhouang", Type="Province" }

        });
    }
}
