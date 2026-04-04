using AngryMonkey.Cloud.Geography;
namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    private static void FillInSubdivisionsSE()
    {
        AddSubdivisions("SE",
        [
            new()
            { 
                Code = "K",
                Type = SubdivisionTypes.County,
                Name = "Blekinge län",
                LocalName = "Blekinge län"
            },
            new()
            { 
                Code = "W",
                Type = SubdivisionTypes.County,
                Name = "Dalarnes län",
                LocalName = "Dalarnes län"
            },
            new()
            { 
                Code = "X",
                Type = SubdivisionTypes.County,
                Name = "Gävleborgs län",
                LocalName = "Gävleborgs län"
            },
            new()
            { 
                Code = "I",
                Type = SubdivisionTypes.County,
                Name = "Gotlands län",
                LocalName = "Gotlands län"
            },
            new()
            { 
                Code = "N",
                Type = SubdivisionTypes.County,
                Name = "Hallands län",
                LocalName = "Hallands län"
            },
            new()
            { 
                Code = "Z",
                Type = SubdivisionTypes.County,
                Name = "Jämtlands län",
                LocalName = "Jämtlands län"
            },
            new()
            { 
                Code = "F",
                Type = SubdivisionTypes.County,
                Name = "Jönköpings län",
                LocalName = "Jönköpings län"
            },
            new()
            { 
                Code = "H",
                Type = SubdivisionTypes.County,
                Name = "Kalmar län",
                LocalName = "Kalmar län"
            },
            new()
            { 
                Code = "G",
                Type = SubdivisionTypes.County,
                Name = "Kronoborgs län",
                LocalName = "Kronoborgs län"
            },
            new()
            { 
                Code = "BD",
                Type = SubdivisionTypes.County,
                Name = "Norrbottens län",
                LocalName = "Norrbottens län"
            },
            new()
            { 
                Code = "T",
                Type = SubdivisionTypes.County,
                Name = "Örebro län",
                LocalName = "Örebro län"
            },
            new()
            { 
                Code = "E",
                Type = SubdivisionTypes.County,
                Name = "Östergötlands län",
                LocalName = "Östergötlands län"
            },
            new()
            { 
                Code = "M",
                Type = SubdivisionTypes.County,
                Name = "Skåne län",
                LocalName = "Skåne län"
            },
            new()
            { 
                Code = "D",
                Type = SubdivisionTypes.County,
                Name = "Södermanlands län",
                LocalName = "Södermanlands län"
            },
            new()
            { 
                Code = "AB",
                Type = SubdivisionTypes.County,
                Name = "Stockholms län",
                LocalName = "Stockholms län"
            },
            new()
            { 
                Code = "C",
                Type = SubdivisionTypes.County,
                Name = "Uppsala län",
                LocalName = "Uppsala län"
            },
            new()
            { 
                Code = "S",
                Type = SubdivisionTypes.County,
                Name = "Värmlands län",
                LocalName = "Värmlands län"
            },
            new()
            { 
                Code = "AC",
                Type = SubdivisionTypes.County,
                Name = "Västerbottens län",
                LocalName = "Västerbottens län"
            },
            new()
            { 
                Code = "Y",
                Type = SubdivisionTypes.County,
                Name = "Västernorrlands län",
                LocalName = "Västernorrlands län"
            },
            new()
            { 
                Code = "U",
                Type = SubdivisionTypes.County,
                Name = "Västmanlands län",
                LocalName = "Västmanlands län"
            },
            new()
            { 
                Code = "O",
                Type = SubdivisionTypes.County,
                Name = "Västra Götalands län",
                LocalName = "Västra Götalands län"
            }

        ]);
    }
}
