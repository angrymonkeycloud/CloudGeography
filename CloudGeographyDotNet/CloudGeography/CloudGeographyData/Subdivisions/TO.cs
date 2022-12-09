using AngryMonkey.Cloud.Geography;
namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    private static void FillInSubdivisionsTO()
    {
        AddSubdivisions("TO", new List<Subdivision>()
        {
            new()
            { 
                Code = "1",
                Type = "Division",
                Name = "'Eua",
                LocalName = "'Eua"
            },
            new()
            { 
                Code = "2",
                Type = "Division",
                Name = "Ha'apai",
                LocalName = "Ha'apai"
            },
            new()
            { 
                Code = "3",
                Type = "Division",
                Name = "Niuas",
                LocalName = "Niuas"
            },
            new()
            { 
                Code = "4",
                Type = "Division",
                Name = "Tongatapu",
                LocalName = "Tongatapu"
            },
            new()
            { 
                Code = "5",
                Type = "Division",
                Name = "Vava'u",
                LocalName = "Vava'u"
            }

        });
    }
}
