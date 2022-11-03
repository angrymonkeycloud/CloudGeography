using AngryMonkey.Cloud.Geography;
namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    private static void FillInSubdivisionsPW()
    {
        AddSubdivisions("PW", new List<Subdivision>()
        {
            new(){ Code ="2", LocalName="Aimeliik", Name="Aimeliik", Type="State" },
            new(){ Code ="4", LocalName="Airai", Name="Airai", Type="State" },
            new(){ Code ="10", LocalName="Angaur", Name="Angaur", Type="State" },
            new(){ Code ="50", LocalName="Hatohobei", Name="Hatohobei", Type="State" },
            new(){ Code ="100", LocalName="Kayangel", Name="Kayangel", Type="State" },
            new(){ Code ="150", LocalName="Koror", Name="Koror", Type="State" },
            new(){ Code ="212", LocalName="Melekeok", Name="Melekeok", Type="State" },
            new(){ Code ="214", LocalName="Ngaraard", Name="Ngaraard", Type="State" },
            new(){ Code ="218", LocalName="Ngarchelong", Name="Ngarchelong", Type="State" },
            new(){ Code ="222", LocalName="Ngardmau", Name="Ngardmau", Type="State" },
            new(){ Code ="224", LocalName="Ngatpang", Name="Ngatpang", Type="State" },
            new(){ Code ="226", LocalName="Ngchesar", Name="Ngchesar", Type="State" },
            new(){ Code ="227", LocalName="Ngeremlengui", Name="Ngeremlengui", Type="State" },
            new(){ Code ="228", LocalName="Ngiwal", Name="Ngiwal", Type="State" },
            new(){ Code ="350", LocalName="Peleliu", Name="Peleliu", Type="State" },
            new(){ Code ="370", LocalName="Sonsorol", Name="Sonsorol", Type="State" }

        });
    }
}
