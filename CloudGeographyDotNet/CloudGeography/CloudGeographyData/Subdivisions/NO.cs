using AngryMonkey.Cloud.Geography;
namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    private static void FillInSubdivisionsNO()
    {
        AddSubdivisions("NO", new List<Subdivision>()
        {
            new(){ Code ="2", LocalName="Akershus", Name="Akershus", Type="County" },
            new(){ Code ="9", LocalName="Aust-Agder", Name="Aust-Agder", Type="County" },
            new(){ Code ="6", LocalName="Buskerud", Name="Buskerud", Type="County" },
            new(){ Code ="20", LocalName="Finnmark", Name="Finnmark", Type="County" },
            new(){ Code ="4", LocalName="Hedmark", Name="Hedmark", Type="County" },
            new(){ Code ="12", LocalName="Hordaland", Name="Hordaland", Type="County" },
            new(){ Code ="15", LocalName="Møre og Romsdal", Name="Møre og Romsdal", Type="County" },
            new(){ Code ="18", LocalName="Nordland", Name="Nordland", Type="County" },
            new(){ Code ="17", LocalName="Nord-Trøndelag", Name="Nord-Trøndelag", Type="County" },
            new(){ Code ="5", LocalName="Oppland", Name="Oppland", Type="County" },
            new(){ Code ="3", LocalName="Oslo", Name="Oslo", Type="County" },
            new(){ Code ="1", LocalName="Østfold", Name="Østfold", Type="County" },
            new(){ Code ="11", LocalName="Rogaland", Name="Rogaland", Type="County" },
            new(){ Code ="14", LocalName="Sogn og Fjordane", Name="Sogn og Fjordane", Type="County" },
            new(){ Code ="16", LocalName="Sør-Trøndelag", Name="Sør-Trøndelag", Type="County" },
            new(){ Code ="8", LocalName="Telemark", Name="Telemark", Type="County" },
            new(){ Code ="19", LocalName="Troms", Name="Troms", Type="County" },
            new(){ Code ="10", LocalName="Vest-Agder", Name="Vest-Agder", Type="County" },
            new(){ Code ="7", LocalName="Vestfold", Name="Vestfold", Type="County" }

        });
    }
}
