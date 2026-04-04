using AngryMonkey.Cloud.Geography;
namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    private static void FillInSubdivisionsGL()
    {
        AddSubdivisions("GL",
        [
            new()
            { 
                Code = "KU",
                Type = SubdivisionTypes.Municipality,
                Name = "Kommune Kujalleq",
                LocalName = "Kommune Kujalleq"
            },
            new()
            { 
                Code = "SM",
                Type = SubdivisionTypes.Municipality,
                Name = "Kommuneqarfik Sermersooq",
                LocalName = "Kommuneqarfik Sermersooq"
            },
            new()
            { 
                Code = "QA",
                Type = SubdivisionTypes.Municipality,
                Name = "Qaasuitsup Kommunia",
                LocalName = "Qaasuitsup Kommunia"
            },
            new()
            { 
                Code = "QE",
                Type = SubdivisionTypes.Municipality,
                Name = "Qeqqata Kommunia",
                LocalName = "Qeqqata Kommunia"
            }

        ]);
    }
}
