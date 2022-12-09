using AngryMonkey.Cloud.Geography;
namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    private static void FillInSubdivisionsPW()
    {
        AddSubdivisions("PW", new List<Subdivision>()
        {
            new()
            { 
                Code = "2",
                Type = "State",
                Name = "Aimeliik",
                LocalName = "Aimeliik"
            },
            new()
            { 
                Code = "4",
                Type = "State",
                Name = "Airai",
                LocalName = "Airai"
            },
            new()
            { 
                Code = "10",
                Type = "State",
                Name = "Angaur",
                LocalName = "Angaur"
            },
            new()
            { 
                Code = "50",
                Type = "State",
                Name = "Hatohobei",
                LocalName = "Hatohobei"
            },
            new()
            { 
                Code = "100",
                Type = "State",
                Name = "Kayangel",
                LocalName = "Kayangel"
            },
            new()
            { 
                Code = "150",
                Type = "State",
                Name = "Koror",
                LocalName = "Koror"
            },
            new()
            { 
                Code = "212",
                Type = "State",
                Name = "Melekeok",
                LocalName = "Melekeok"
            },
            new()
            { 
                Code = "214",
                Type = "State",
                Name = "Ngaraard",
                LocalName = "Ngaraard"
            },
            new()
            { 
                Code = "218",
                Type = "State",
                Name = "Ngarchelong",
                LocalName = "Ngarchelong"
            },
            new()
            { 
                Code = "222",
                Type = "State",
                Name = "Ngardmau",
                LocalName = "Ngardmau"
            },
            new()
            { 
                Code = "224",
                Type = "State",
                Name = "Ngatpang",
                LocalName = "Ngatpang"
            },
            new()
            { 
                Code = "226",
                Type = "State",
                Name = "Ngchesar",
                LocalName = "Ngchesar"
            },
            new()
            { 
                Code = "227",
                Type = "State",
                Name = "Ngeremlengui",
                LocalName = "Ngeremlengui"
            },
            new()
            { 
                Code = "228",
                Type = "State",
                Name = "Ngiwal",
                LocalName = "Ngiwal"
            },
            new()
            { 
                Code = "350",
                Type = "State",
                Name = "Peleliu",
                LocalName = "Peleliu"
            },
            new()
            { 
                Code = "370",
                Type = "State",
                Name = "Sonsorol",
                LocalName = "Sonsorol"
            }

        });
    }
}
