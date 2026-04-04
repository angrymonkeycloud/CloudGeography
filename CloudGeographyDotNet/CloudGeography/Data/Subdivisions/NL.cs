using AngryMonkey.Cloud.Geography;
namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    private static void FillInSubdivisionsNL()
    {
        AddSubdivisions("NL",
        [
            new()
            { 
                Code = "DR",
                Type = SubdivisionTypes.Province,
                Name = "Drenthe",
                LocalName = "Drenthe"
            },
            new()
            { 
                Code = "FL",
                Type = SubdivisionTypes.Province,
                Name = "Flevoland",
                LocalName = "Flevoland"
            },
            new()
            { 
                Code = "FR",
                Type = SubdivisionTypes.Province,
                Name = "Fryslân",
                LocalName = "Fryslân"
            },
            new()
            { 
                Code = "GE",
                Type = SubdivisionTypes.Province,
                Name = "Gelderland",
                LocalName = "Gelderland"
            },
            new()
            { 
                Code = "GR",
                Type = SubdivisionTypes.Province,
                Name = "Groningen",
                LocalName = "Groningen"
            },
            new()
            { 
                Code = "LI",
                Type = SubdivisionTypes.Province,
                Name = "Limburg",
                LocalName = "Limburg"
            },
            new()
            { 
                Code = "NB",
                Type = SubdivisionTypes.Province,
                Name = "Noord-Brabant",
                LocalName = "Noord-Brabant"
            },
            new()
            { 
                Code = "NH",
                Type = SubdivisionTypes.Province,
                Name = "Noord-Holland",
                LocalName = "Noord-Holland"
            },
            new()
            { 
                Code = "OV",
                Type = SubdivisionTypes.Province,
                Name = "Overijssel",
                LocalName = "Overijssel"
            },
            new()
            { 
                Code = "UT",
                Type = SubdivisionTypes.Province,
                Name = "Utrecht",
                LocalName = "Utrecht"
            },
            new()
            { 
                Code = "ZE",
                Type = SubdivisionTypes.Province,
                Name = "Zeeland",
                LocalName = "Zeeland"
            },
            new()
            { 
                Code = "ZH",
                Type = SubdivisionTypes.Province,
                Name = "Zuid-Holland",
                LocalName = "Zuid-Holland"
            }

        ]);
    }
}
