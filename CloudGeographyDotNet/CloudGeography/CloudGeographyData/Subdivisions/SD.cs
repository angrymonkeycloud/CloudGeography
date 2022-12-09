using AngryMonkey.Cloud.Geography;
namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    private static void FillInSubdivisionsSD()
    {
        AddSubdivisions("SD", new List<Subdivision>()
        {
            new()
            { 
                Code = "RS",
                Type = "State",
                Name = "Al Ba?r al A?mar",
                LocalName = "Al Ba?r al A?mar"
            },
            new()
            { 
                Code = "GZ",
                Type = "State",
                Name = "Al Jazirah",
                LocalName = "Al Jazirah"
            },
            new()
            { 
                Code = "KH",
                Type = "State",
                Name = "Al Khartum",
                LocalName = "Al Khartum"
            },
            new()
            { 
                Code = "GD",
                Type = "State",
                Name = "Al Qadarif",
                LocalName = "Al Qadarif"
            },
            new()
            { 
                Code = "NW",
                Type = "State",
                Name = "An Nil al Abya?",
                LocalName = "An Nil al Abya?"
            },
            new()
            { 
                Code = "NB",
                Type = "State",
                Name = "An Nil al Azraq",
                LocalName = "An Nil al Azraq"
            },
            new()
            { 
                Code = "NO",
                Type = "State",
                Name = "Ash Shamaliyah",
                LocalName = "Ash Shamaliyah"
            },
            new()
            { 
                Code = "DW",
                Type = "State",
                Name = "Gharb Darfur",
                LocalName = "Gharb Darfur"
            },
            new()
            { 
                Code = "GK",
                Type = "State",
                Name = "Gharb Kurdufan",
                LocalName = "Gharb Kurdufan"
            },
            new()
            { 
                Code = "DS",
                Type = "State",
                Name = "Janub Darfur",
                LocalName = "Janub Darfur"
            },
            new()
            { 
                Code = "KS",
                Type = "State",
                Name = "Janub Kurdufan",
                LocalName = "Janub Kurdufan"
            },
            new()
            { 
                Code = "KA",
                Type = "State",
                Name = "Kassala",
                LocalName = "Kassala"
            },
            new()
            { 
                Code = "NR",
                Type = "State",
                Name = "Nahr an Nil",
                LocalName = "Nahr an Nil"
            },
            new()
            { 
                Code = "DN",
                Type = "State",
                Name = "Shamal Darfur",
                LocalName = "Shamal Darfur"
            },
            new()
            { 
                Code = "DE",
                Type = "State",
                Name = "Sharq Darfur",
                LocalName = "Sharq Darfur"
            },
            new()
            { 
                Code = "KN",
                Type = "State",
                Name = "Shiamal Kurdufan",
                LocalName = "Shiamal Kurdufan"
            },
            new()
            { 
                Code = "SI",
                Type = "State",
                Name = "Sinnar",
                LocalName = "Sinnar"
            },
            new()
            { 
                Code = "DC",
                Type = "State",
                Name = "Wasat Darfur Zalinjay",
                LocalName = "Wasat Darfur Zalinjay"
            }

        });
    }
}
