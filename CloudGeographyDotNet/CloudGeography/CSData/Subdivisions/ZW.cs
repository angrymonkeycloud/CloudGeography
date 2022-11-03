using AngryMonkey.Cloud.Geography;
namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    private static void FillInSubdivisionsZW()
    {
        AddSubdivisions("ZW", new List<Subdivision>()
        {
            new(){ Code ="BU", LocalName="Bulawayo", Name="Bulawayo", Type="Province" },
            new(){ Code ="HA", LocalName="Harare", Name="Harare", Type="Province" },
            new(){ Code ="MA", LocalName="Manicaland", Name="Manicaland", Type="Province" },
            new(){ Code ="MC", LocalName="Mashonaland Central", Name="Mashonaland Central", Type="Province" },
            new(){ Code ="ME", LocalName="Mashonaland East", Name="Mashonaland East", Type="Province" },
            new(){ Code ="MW", LocalName="Mashonaland West", Name="Mashonaland West", Type="Province" },
            new(){ Code ="MV", LocalName="Masvingo", Name="Masvingo", Type="Province" },
            new(){ Code ="MN", LocalName="Matabeleland North", Name="Matabeleland North", Type="Province" },
            new(){ Code ="MS", LocalName="Matabeleland South", Name="Matabeleland South", Type="Province" },
            new(){ Code ="MI", LocalName="Midlands", Name="Midlands", Type="Province" }

        });
    }
}
