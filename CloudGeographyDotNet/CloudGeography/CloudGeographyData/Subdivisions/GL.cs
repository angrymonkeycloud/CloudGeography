using AngryMonkey.Cloud.Geography;
namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    private static void FillInSubdivisionsGL()
    {
        AddSubdivisions("GL", new List<Subdivision>()
        {
            new(){ Code ="KU", LocalName="Kommune Kujalleq", Name="Kommune Kujalleq", Type="Municipality" },
            new(){ Code ="SM", LocalName="Kommuneqarfik Sermersooq", Name="Kommuneqarfik Sermersooq", Type="Municipality" },
            new(){ Code ="QA", LocalName="Qaasuitsup Kommunia", Name="Qaasuitsup Kommunia", Type="Municipality" },
            new(){ Code ="QE", LocalName="Qeqqata Kommunia", Name="Qeqqata Kommunia", Type="Municipality" }

        });
    }
}
