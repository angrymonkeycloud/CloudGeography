using AngryMonkey.Cloud.Geography;
namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    private static void FillInSubdivisionsNL()
    {
        AddSubdivisions("NL", new List<Subdivision>()
        {
            new()
            { 
                Code = "DR",
                Type = "Province",
                Name = "Drenthe",
                LocalName = "Drenthe"
            },
            new()
            { 
                Code = "FL",
                Type = "Province",
                Name = "Flevoland",
                LocalName = "Flevoland"
            },
            new()
            { 
                Code = "FR",
                Type = "Province",
                Name = "Fryslân",
                LocalName = "Fryslân"
            },
            new()
            { 
                Code = "GE",
                Type = "Province",
                Name = "Gelderland",
                LocalName = "Gelderland"
            },
            new()
            { 
                Code = "GR",
                Type = "Province",
                Name = "Groningen",
                LocalName = "Groningen"
            },
            new()
            { 
                Code = "LI",
                Type = "Province",
                Name = "Limburg",
                LocalName = "Limburg"
            },
            new()
            { 
                Code = "NB",
                Type = "Province",
                Name = "Noord-Brabant",
                LocalName = "Noord-Brabant"
            },
            new()
            { 
                Code = "NH",
                Type = "Province",
                Name = "Noord-Holland",
                LocalName = "Noord-Holland"
            },
            new()
            { 
                Code = "OV",
                Type = "Province",
                Name = "Overijssel",
                LocalName = "Overijssel"
            },
            new()
            { 
                Code = "UT",
                Type = "Province",
                Name = "Utrecht",
                LocalName = "Utrecht"
            },
            new()
            { 
                Code = "ZE",
                Type = "Province",
                Name = "Zeeland",
                LocalName = "Zeeland"
            },
            new()
            { 
                Code = "ZH",
                Type = "Province",
                Name = "Zuid-Holland",
                LocalName = "Zuid-Holland"
            }

        });
    }
}
