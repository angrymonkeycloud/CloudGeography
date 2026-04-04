using AngryMonkey.Cloud.Geography;
namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    private static void FillInSubdivisionsGR()
    {
        AddSubdivisions("GR",
        [
            new()
            { 
                Code = "A",
                Type = SubdivisionTypes.Region,
                Name = "Anatolikí Makedonía kai Thráki",
                LocalName = "Anatolikí Makedonía kai Thráki"
            },
            new()
            { 
                Code = "I",
                Type = SubdivisionTypes.Region,
                Name = "Attikí",
                LocalName = "Attikí"
            },
            new()
            { 
                Code = "G",
                Type = SubdivisionTypes.Region,
                Name = "Dytikí Elláda",
                LocalName = "Dytikí Elláda"
            },
            new()
            { 
                Code = "C",
                Type = SubdivisionTypes.Region,
                Name = "Dytiki Makedonia",
                LocalName = "Dytiki Makedonia"
            },
            new()
            { 
                Code = "F",
                Type = SubdivisionTypes.Region,
                Name = "Ionía Nísia",
                LocalName = "Ionía Nísia"
            },
            new()
            { 
                Code = "D",
                Type = SubdivisionTypes.Region,
                Name = "Ípeiros",
                LocalName = "Ípeiros"
            },
            new()
            { 
                Code = "B",
                Type = SubdivisionTypes.Region,
                Name = "Kentrikí Makedonía",
                LocalName = "Kentrikí Makedonía"
            },
            new()
            { 
                Code = "M",
                Type = SubdivisionTypes.Region,
                Name = "Kríti",
                LocalName = "Kríti"
            },
            new()
            { 
                Code = "L",
                Type = SubdivisionTypes.Region,
                Name = "Notío Aigaío",
                LocalName = "Notío Aigaío"
            },
            new()
            { 
                Code = "J",
                Type = SubdivisionTypes.Region,
                Name = "Peloponnísos",
                LocalName = "Peloponnísos"
            },
            new()
            { 
                Code = "H",
                Type = SubdivisionTypes.Region,
                Name = "Stereá Elláda",
                LocalName = "Stereá Elláda"
            },
            new()
            { 
                Code = "E",
                Type = SubdivisionTypes.Region,
                Name = "Thessalía",
                LocalName = "Thessalía"
            },
            new()
            { 
                Code = "K",
                Type = SubdivisionTypes.Region,
                Name = "Voreío Aigaío",
                LocalName = "Voreío Aigaío"
            }

        ]);
    }
}
