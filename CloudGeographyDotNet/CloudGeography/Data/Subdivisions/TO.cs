using AngryMonkey.Cloud.Geography;
namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    private static void FillInSubdivisionsTO()
    {
        AddSubdivisions("TO",
        [
            new()
            { 
                Code = "1",
                Type = SubdivisionTypes.Division,
                Name = "'Eua",
                LocalName = "'Eua"
            },
            new()
            { 
                Code = "2",
                Type = SubdivisionTypes.Division,
                Name = "Ha'apai",
                LocalName = "Ha'apai"
            },
            new()
            { 
                Code = "3",
                Type = SubdivisionTypes.Division,
                Name = "Niuas",
                LocalName = "Niuas"
            },
            new()
            { 
                Code = "4",
                Type = SubdivisionTypes.Division,
                Name = "Tongatapu",
                LocalName = "Tongatapu"
            },
            new()
            { 
                Code = "5",
                Type = SubdivisionTypes.Division,
                Name = "Vava'u",
                LocalName = "Vava'u"
            }

        ]);
    }
}
