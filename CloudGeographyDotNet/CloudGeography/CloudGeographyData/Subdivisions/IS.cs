using AngryMonkey.Cloud.Geography;
namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    private static void FillInSubdivisionsIS()
    {
        AddSubdivisions("IS", new List<Subdivision>()
        {
            new(){ Code ="7", LocalName="Austurland", Name="Austurland", Type="Region" },
            new(){ Code ="1", LocalName="Höfuðborgarsvæði utan Reykjavíkur", Name="Höfuðborgarsvæði utan Reykjavíkur", Type="Region" },
            new(){ Code ="6", LocalName="Norðurland eystra", Name="Norðurland eystra", Type="Region" },
            new(){ Code ="5", LocalName="Norðurland vestra", Name="Norðurland vestra", Type="Region" },
            new(){ Code ="8", LocalName="Suðurland", Name="Suðurland", Type="Region" },
            new(){ Code ="2", LocalName="Suðurnes", Name="Suðurnes", Type="Region" },
            new(){ Code ="4", LocalName="Vestfirðir", Name="Vestfirðir", Type="Region" },
            new(){ Code ="3", LocalName="Vesturland", Name="Vesturland", Type="Region" }

        });
    }
}
