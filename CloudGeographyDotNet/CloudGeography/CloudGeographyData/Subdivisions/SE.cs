using AngryMonkey.Cloud.Geography;
namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    private static void FillInSubdivisionsSE()
    {
        AddSubdivisions("SE", new List<Subdivision>()
        {
            new()
            { 
                Code = "K",
                Type = "County",
                Name = "Blekinge län",
                LocalName = "Blekinge län"
            },
            new()
            { 
                Code = "W",
                Type = "County",
                Name = "Dalarnes län",
                LocalName = "Dalarnes län"
            },
            new()
            { 
                Code = "X",
                Type = "County",
                Name = "Gävleborgs län",
                LocalName = "Gävleborgs län"
            },
            new()
            { 
                Code = "I",
                Type = "County",
                Name = "Gotlands län",
                LocalName = "Gotlands län"
            },
            new()
            { 
                Code = "N",
                Type = "County",
                Name = "Hallands län",
                LocalName = "Hallands län"
            },
            new()
            { 
                Code = "Z",
                Type = "County",
                Name = "Jämtlands län",
                LocalName = "Jämtlands län"
            },
            new()
            { 
                Code = "F",
                Type = "County",
                Name = "Jönköpings län",
                LocalName = "Jönköpings län"
            },
            new()
            { 
                Code = "H",
                Type = "County",
                Name = "Kalmar län",
                LocalName = "Kalmar län"
            },
            new()
            { 
                Code = "G",
                Type = "County",
                Name = "Kronoborgs län",
                LocalName = "Kronoborgs län"
            },
            new()
            { 
                Code = "BD",
                Type = "County",
                Name = "Norrbottens län",
                LocalName = "Norrbottens län"
            },
            new()
            { 
                Code = "T",
                Type = "County",
                Name = "Örebro län",
                LocalName = "Örebro län"
            },
            new()
            { 
                Code = "E",
                Type = "County",
                Name = "Östergötlands län",
                LocalName = "Östergötlands län"
            },
            new()
            { 
                Code = "M",
                Type = "County",
                Name = "Skåne län",
                LocalName = "Skåne län"
            },
            new()
            { 
                Code = "D",
                Type = "County",
                Name = "Södermanlands län",
                LocalName = "Södermanlands län"
            },
            new()
            { 
                Code = "AB",
                Type = "County",
                Name = "Stockholms län",
                LocalName = "Stockholms län"
            },
            new()
            { 
                Code = "C",
                Type = "County",
                Name = "Uppsala län",
                LocalName = "Uppsala län"
            },
            new()
            { 
                Code = "S",
                Type = "County",
                Name = "Värmlands län",
                LocalName = "Värmlands län"
            },
            new()
            { 
                Code = "AC",
                Type = "County",
                Name = "Västerbottens län",
                LocalName = "Västerbottens län"
            },
            new()
            { 
                Code = "Y",
                Type = "County",
                Name = "Västernorrlands län",
                LocalName = "Västernorrlands län"
            },
            new()
            { 
                Code = "U",
                Type = "County",
                Name = "Västmanlands län",
                LocalName = "Västmanlands län"
            },
            new()
            { 
                Code = "O",
                Type = "County",
                Name = "Västra Götalands län",
                LocalName = "Västra Götalands län"
            }

        });
    }
}
