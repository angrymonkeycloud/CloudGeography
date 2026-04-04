using AngryMonkey.Cloud.Geography;
namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    private static void FillInSubdivisionsSD()
    {
        AddSubdivisions("SD",
        [
            new()
            { 
                Code = "RS",
                Type = SubdivisionTypes.State,
                Name = "Al Ba?r al A?mar",
                LocalName = "Al Ba?r al A?mar"
            },
            new()
            { 
                Code = "GZ",
                Type = SubdivisionTypes.State,
                Name = "Al Jazirah",
                LocalName = "Al Jazirah"
            },
            new()
            { 
                Code = "KH",
                Type = SubdivisionTypes.State,
                Name = "Al Khartum",
                LocalName = "Al Khartum"
            },
            new()
            { 
                Code = "GD",
                Type = SubdivisionTypes.State,
                Name = "Al Qadarif",
                LocalName = "Al Qadarif"
            },
            new()
            { 
                Code = "NW",
                Type = SubdivisionTypes.State,
                Name = "An Nil al Abya?",
                LocalName = "An Nil al Abya?"
            },
            new()
            { 
                Code = "NB",
                Type = SubdivisionTypes.State,
                Name = "An Nil al Azraq",
                LocalName = "An Nil al Azraq"
            },
            new()
            { 
                Code = "NO",
                Type = SubdivisionTypes.State,
                Name = "Ash Shamaliyah",
                LocalName = "Ash Shamaliyah"
            },
            new()
            { 
                Code = "DW",
                Type = SubdivisionTypes.State,
                Name = "Gharb Darfur",
                LocalName = "Gharb Darfur"
            },
            new()
            { 
                Code = "GK",
                Type = SubdivisionTypes.State,
                Name = "Gharb Kurdufan",
                LocalName = "Gharb Kurdufan"
            },
            new()
            { 
                Code = "DS",
                Type = SubdivisionTypes.State,
                Name = "Janub Darfur",
                LocalName = "Janub Darfur"
            },
            new()
            { 
                Code = "KS",
                Type = SubdivisionTypes.State,
                Name = "Janub Kurdufan",
                LocalName = "Janub Kurdufan"
            },
            new()
            { 
                Code = "KA",
                Type = SubdivisionTypes.State,
                Name = "Kassala",
                LocalName = "Kassala"
            },
            new()
            { 
                Code = "NR",
                Type = SubdivisionTypes.State,
                Name = "Nahr an Nil",
                LocalName = "Nahr an Nil"
            },
            new()
            { 
                Code = "DN",
                Type = SubdivisionTypes.State,
                Name = "Shamal Darfur",
                LocalName = "Shamal Darfur"
            },
            new()
            { 
                Code = "DE",
                Type = SubdivisionTypes.State,
                Name = "Sharq Darfur",
                LocalName = "Sharq Darfur"
            },
            new()
            { 
                Code = "KN",
                Type = SubdivisionTypes.State,
                Name = "Shiamal Kurdufan",
                LocalName = "Shiamal Kurdufan"
            },
            new()
            { 
                Code = "SI",
                Type = SubdivisionTypes.State,
                Name = "Sinnar",
                LocalName = "Sinnar"
            },
            new()
            { 
                Code = "DC",
                Type = SubdivisionTypes.State,
                Name = "Wasat Darfur Zalinjay",
                LocalName = "Wasat Darfur Zalinjay"
            }

        ]);
    }
}
