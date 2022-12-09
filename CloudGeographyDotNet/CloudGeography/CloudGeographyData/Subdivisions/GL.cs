using AngryMonkey.Cloud.Geography;
namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    private static void FillInSubdivisionsGL()
    {
        AddSubdivisions("GL", new List<Subdivision>()
        {
            new()
            { 
                Code = "KU",
                Type = "Municipality",
                Name = "Kommune Kujalleq",
                LocalName = "Kommune Kujalleq"
            },
            new()
            { 
                Code = "SM",
                Type = "Municipality",
                Name = "Kommuneqarfik Sermersooq",
                LocalName = "Kommuneqarfik Sermersooq"
            },
            new()
            { 
                Code = "QA",
                Type = "Municipality",
                Name = "Qaasuitsup Kommunia",
                LocalName = "Qaasuitsup Kommunia"
            },
            new()
            { 
                Code = "QE",
                Type = "Municipality",
                Name = "Qeqqata Kommunia",
                LocalName = "Qeqqata Kommunia"
            }

        });
    }
}
