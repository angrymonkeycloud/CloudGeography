using AngryMonkey.Cloud.Geography;
namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    private static void FillInSubdivisionsGR()
    {
        AddSubdivisions("GR", new List<Subdivision>()
        {
            new()
            { 
                Code = "A",
                Type = "Region",
                Name = "Anatolikí Makedonía kai Thráki",
                LocalName = "Anatolikí Makedonía kai Thráki"
            },
            new()
            { 
                Code = "I",
                Type = "Region",
                Name = "Attikí",
                LocalName = "Attikí"
            },
            new()
            { 
                Code = "G",
                Type = "Region",
                Name = "Dytikí Elláda",
                LocalName = "Dytikí Elláda"
            },
            new()
            { 
                Code = "C",
                Type = "Region",
                Name = "Dytiki Makedonia",
                LocalName = "Dytiki Makedonia"
            },
            new()
            { 
                Code = "F",
                Type = "Region",
                Name = "Ionía Nísia",
                LocalName = "Ionía Nísia"
            },
            new()
            { 
                Code = "D",
                Type = "Region",
                Name = "Ípeiros",
                LocalName = "Ípeiros"
            },
            new()
            { 
                Code = "B",
                Type = "Region",
                Name = "Kentrikí Makedonía",
                LocalName = "Kentrikí Makedonía"
            },
            new()
            { 
                Code = "M",
                Type = "Region",
                Name = "Kríti",
                LocalName = "Kríti"
            },
            new()
            { 
                Code = "L",
                Type = "Region",
                Name = "Notío Aigaío",
                LocalName = "Notío Aigaío"
            },
            new()
            { 
                Code = "J",
                Type = "Region",
                Name = "Peloponnísos",
                LocalName = "Peloponnísos"
            },
            new()
            { 
                Code = "H",
                Type = "Region",
                Name = "Stereá Elláda",
                LocalName = "Stereá Elláda"
            },
            new()
            { 
                Code = "E",
                Type = "Region",
                Name = "Thessalía",
                LocalName = "Thessalía"
            },
            new()
            { 
                Code = "K",
                Type = "Region",
                Name = "Voreío Aigaío",
                LocalName = "Voreío Aigaío"
            }

        });
    }
}
