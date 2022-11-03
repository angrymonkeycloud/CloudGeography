using AngryMonkey.Cloud.Geography;
namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    private static void FillInSubdivisionsNA()
    {
        AddSubdivisions("NA", new List<Subdivision>()
        {
            new(){ Code ="ER", LocalName="Erongo", Name="Erongo", Type="Region" },
            new(){ Code ="HA", LocalName="Hardap", Name="Hardap", Type="Region" },
            new(){ Code ="KA", LocalName="Karas", Name="Karas", Type="Region" },
            new(){ Code ="KE", LocalName="Kavango East", Name="Kavango East", Type="Region" },
            new(){ Code ="KH", LocalName="Khomas", Name="Khomas", Type="Region" },
            new(){ Code ="KU", LocalName="Kunene", Name="Kunene", Type="Region" },
            new(){ Code ="OW", LocalName="Ohangwena", Name="Ohangwena", Type="Region" },
            new(){ Code ="OH", LocalName="Omaheke", Name="Omaheke", Type="Region" },
            new(){ Code ="OS", LocalName="Omusati", Name="Omusati", Type="Region" },
            new(){ Code ="ON", LocalName="Oshana", Name="Oshana", Type="Region" },
            new(){ Code ="OT", LocalName="Oshikoto", Name="Oshikoto", Type="Region" },
            new(){ Code ="OD", LocalName="Otjozondjupa", Name="Otjozondjupa", Type="Region" },
            new(){ Code ="CA", LocalName="Zambezi", Name="Zambezi", Type="Region" }

        });
    }
}
