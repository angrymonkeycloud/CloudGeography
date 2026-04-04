using AngryMonkey.Cloud.Geography;
namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    private static void FillInSubdivisionsET()
    {
        AddSubdivisions("ET",
        [
            new()
            { 
                Code = "AF",
                Type = SubdivisionTypes.State,
                Name = "Afar",
                LocalName = "Afar"
            },
            new()
            { 
                Code = "AM",
                Type = SubdivisionTypes.State,
                Name = "Amara",
                LocalName = "Amara"
            },
            new()
            { 
                Code = "BE",
                Type = SubdivisionTypes.State,
                Name = "Binshangul Gumuz",
                LocalName = "Binshangul Gumuz"
            },
            new()
            { 
                Code = "GA",
                Type = SubdivisionTypes.State,
                Name = "Gambela Hizboch",
                LocalName = "Gambela Hizboch"
            },
            new()
            { 
                Code = "HA",
                Type = SubdivisionTypes.State,
                Name = "Hareri Hizb",
                LocalName = "Hareri Hizb"
            },
            new()
            { 
                Code = "OR",
                Type = SubdivisionTypes.State,
                Name = "Oromiya",
                LocalName = "Oromiya"
            },
            new()
            { 
                Code = "SO",
                Type = SubdivisionTypes.State,
                Name = "Sumale",
                LocalName = "Sumale"
            },
            new()
            { 
                Code = "TI",
                Type = SubdivisionTypes.State,
                Name = "Tigray",
                LocalName = "Tigray"
            },
            new()
            { 
                Code = "SN",
                Type = SubdivisionTypes.State,
                Name = "YeDebub Biheroch Bihereseboch na Hizboch",
                LocalName = "YeDebub Biheroch Bihereseboch na Hizboch"
            }

        ]);
    }
}
