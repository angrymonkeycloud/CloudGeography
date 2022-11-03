using AngryMonkey.Cloud.Geography;
namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    private static void FillInSubdivisionsZA()
    {
        AddSubdivisions("ZA", new List<Subdivision>()
        {
            new(){ Code ="EC", LocalName="Eastern Cape", Name="Eastern Cape", Type="Province" },
            new(){ Code ="FS", LocalName="Free State", Name="Free State", Type="Province" },
            new(){ Code ="GT", LocalName="Gauteng", Name="Gauteng", Type="Province" },
            new(){ Code ="NL", LocalName="Kwazulu-Natal", Name="Kwazulu-Natal", Type="Province" },
            new(){ Code ="LP", LocalName="Limpopo", Name="Limpopo", Type="Province" },
            new(){ Code ="MP", LocalName="Mpumalanga", Name="Mpumalanga", Type="Province" },
            new(){ Code ="NC", LocalName="Northern Cape", Name="Northern Cape", Type="Province" },
            new(){ Code ="NW", LocalName="North-West", Name="North-West", Type="Province" },
            new(){ Code ="WC", LocalName="Western Cape", Name="Western Cape", Type="Province" }

        });
    }
}
