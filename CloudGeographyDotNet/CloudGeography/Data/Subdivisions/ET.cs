using AngryMonkey.Cloud.Geography;
namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    private static void FillInSubdivisionsET()
    {
        AddSubdivisions("ET", new List<Subdivision>()
        {
            new()
            { 
                Code = "AF",
                Type = "State",
                Name = "Afar",
                LocalName = "Afar"
            },
            new()
            { 
                Code = "AM",
                Type = "State",
                Name = "Amara",
                LocalName = "Amara"
            },
            new()
            { 
                Code = "BE",
                Type = "State",
                Name = "Binshangul Gumuz",
                LocalName = "Binshangul Gumuz"
            },
            new()
            { 
                Code = "GA",
                Type = "State",
                Name = "Gambela Hizboch",
                LocalName = "Gambela Hizboch"
            },
            new()
            { 
                Code = "HA",
                Type = "State",
                Name = "Hareri Hizb",
                LocalName = "Hareri Hizb"
            },
            new()
            { 
                Code = "OR",
                Type = "State",
                Name = "Oromiya",
                LocalName = "Oromiya"
            },
            new()
            { 
                Code = "SO",
                Type = "State",
                Name = "Sumale",
                LocalName = "Sumale"
            },
            new()
            { 
                Code = "TI",
                Type = "State",
                Name = "Tigray",
                LocalName = "Tigray"
            },
            new()
            { 
                Code = "SN",
                Type = "State",
                Name = "YeDebub Biheroch Bihereseboch na Hizboch",
                LocalName = "YeDebub Biheroch Bihereseboch na Hizboch"
            }

        });
    }
}
