using AngryMonkey.Cloud.Geography;
namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    private static void FillInSubdivisionsPW()
    {
        AddSubdivisions("PW",
        [
            new()
            { 
                Code = "2",
                Type = SubdivisionTypes.State,
                Name = "Aimeliik",
                LocalName = "Aimeliik"
            },
            new()
            { 
                Code = "4",
                Type = SubdivisionTypes.State,
                Name = "Airai",
                LocalName = "Airai"
            },
            new()
            { 
                Code = "10",
                Type = SubdivisionTypes.State,
                Name = "Angaur",
                LocalName = "Angaur"
            },
            new()
            { 
                Code = "50",
                Type = SubdivisionTypes.State,
                Name = "Hatohobei",
                LocalName = "Hatohobei"
            },
            new()
            { 
                Code = "100",
                Type = SubdivisionTypes.State,
                Name = "Kayangel",
                LocalName = "Kayangel"
            },
            new()
            { 
                Code = "150",
                Type = SubdivisionTypes.State,
                Name = "Koror",
                LocalName = "Koror"
            },
            new()
            { 
                Code = "212",
                Type = SubdivisionTypes.State,
                Name = "Melekeok",
                LocalName = "Melekeok"
            },
            new()
            { 
                Code = "214",
                Type = SubdivisionTypes.State,
                Name = "Ngaraard",
                LocalName = "Ngaraard"
            },
            new()
            { 
                Code = "218",
                Type = SubdivisionTypes.State,
                Name = "Ngarchelong",
                LocalName = "Ngarchelong"
            },
            new()
            { 
                Code = "222",
                Type = SubdivisionTypes.State,
                Name = "Ngardmau",
                LocalName = "Ngardmau"
            },
            new()
            { 
                Code = "224",
                Type = SubdivisionTypes.State,
                Name = "Ngatpang",
                LocalName = "Ngatpang"
            },
            new()
            { 
                Code = "226",
                Type = SubdivisionTypes.State,
                Name = "Ngchesar",
                LocalName = "Ngchesar"
            },
            new()
            { 
                Code = "227",
                Type = SubdivisionTypes.State,
                Name = "Ngeremlengui",
                LocalName = "Ngeremlengui"
            },
            new()
            { 
                Code = "228",
                Type = SubdivisionTypes.State,
                Name = "Ngiwal",
                LocalName = "Ngiwal"
            },
            new()
            { 
                Code = "350",
                Type = SubdivisionTypes.State,
                Name = "Peleliu",
                LocalName = "Peleliu"
            },
            new()
            { 
                Code = "370",
                Type = SubdivisionTypes.State,
                Name = "Sonsorol",
                LocalName = "Sonsorol"
            }

        ]);
    }
}
