using AngryMonkey.Cloud.Geography;
namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    private static void FillInSubdivisionsLR()
    {
        AddSubdivisions("LR", new List<Subdivision>()
        {
            new(){ Code ="BM", LocalName="Bomi", Name="Bomi", Type="County" },
            new(){ Code ="BG", LocalName="Bong", Name="Bong", Type="County" },
            new(){ Code ="GP", LocalName="Gbarpolu", Name="Gbarpolu", Type="County" },
            new(){ Code ="GB", LocalName="Grand Bassa", Name="Grand Bassa", Type="County" },
            new(){ Code ="CM", LocalName="Grand Cape Mount", Name="Grand Cape Mount", Type="County" },
            new(){ Code ="GG", LocalName="Grand Gedeh", Name="Grand Gedeh", Type="County" },
            new(){ Code ="GK", LocalName="Grand Kru", Name="Grand Kru", Type="County" },
            new(){ Code ="LO", LocalName="Lofa", Name="Lofa", Type="County" },
            new(){ Code ="MG", LocalName="Margibi", Name="Margibi", Type="County" },
            new(){ Code ="MY", LocalName="Maryland", Name="Maryland", Type="County" },
            new(){ Code ="MO", LocalName="Montserrado", Name="Montserrado", Type="County" },
            new(){ Code ="NI", LocalName="Nimba", Name="Nimba", Type="County" },
            new(){ Code ="RI", LocalName="River Cess", Name="River Cess", Type="County" },
            new(){ Code ="RG", LocalName="River Gee", Name="River Gee", Type="County" },
            new(){ Code ="SI", LocalName="Sinoe", Name="Sinoe", Type="County" }

        });
    }
}
