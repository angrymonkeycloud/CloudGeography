using AngryMonkey.Cloud.Geography;
namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    private static void FillInSubdivisionsCH()
    {
        AddSubdivisions("CH", new List<Subdivision>()
        {
            new()
            { 
                Code = "AG",
                Type = "Canton",
                Name = "Aargau",
                LocalName = "Aargau"
            },
            new()
            { 
                Code = "AR",
                Type = "Canton",
                Name = "Appenzell Ausserrhoden",
                LocalName = "Appenzell Ausserrhoden"
            },
            new()
            { 
                Code = "AI",
                Type = "Canton",
                Name = "Appenzell Innerrhoden",
                LocalName = "Appenzell Innerrhoden"
            },
            new()
            { 
                Code = "BL",
                Type = "Canton",
                Name = "Basel-Landschaft",
                LocalName = "Basel-Landschaft"
            },
            new()
            { 
                Code = "BS",
                Type = "Canton",
                Name = "Basel-Stadt",
                LocalName = "Basel-Stadt"
            },
            new()
            { 
                Code = "BE",
                Type = "Canton",
                Name = "Bern",
                LocalName = "Bern"
            },
            new()
            { 
                Code = "FR",
                Type = "Canton",
                Name = "Fribourg",
                LocalName = "Fribourg"
            },
            new()
            { 
                Code = "GE",
                Type = "Canton",
                Name = "Genève",
                LocalName = "Genève"
            },
            new()
            { 
                Code = "GL",
                Type = "Canton",
                Name = "Glarus",
                LocalName = "Glarus"
            },
            new()
            { 
                Code = "GR",
                Type = "Canton",
                Name = "Graubünden",
                LocalName = "Graubünden"
            },
            new()
            { 
                Code = "JU",
                Type = "Canton",
                Name = "Jura",
                LocalName = "Jura"
            },
            new()
            { 
                Code = "LU",
                Type = "Canton",
                Name = "Luzern",
                LocalName = "Luzern"
            },
            new()
            { 
                Code = "NE",
                Type = "Canton",
                Name = "Neuchâtel",
                LocalName = "Neuchâtel"
            },
            new()
            { 
                Code = "NW",
                Type = "Canton",
                Name = "Nidwalden",
                LocalName = "Nidwalden"
            },
            new()
            { 
                Code = "OW",
                Type = "Canton",
                Name = "Obwalden",
                LocalName = "Obwalden"
            },
            new()
            { 
                Code = "SG",
                Type = "Canton",
                Name = "Sankt Gallen",
                LocalName = "Sankt Gallen"
            },
            new()
            { 
                Code = "SH",
                Type = "Canton",
                Name = "Schaffhausen",
                LocalName = "Schaffhausen"
            },
            new()
            { 
                Code = "SZ",
                Type = "Canton",
                Name = "Schwyz",
                LocalName = "Schwyz"
            },
            new()
            { 
                Code = "SO",
                Type = "Canton",
                Name = "Solothurn",
                LocalName = "Solothurn"
            },
            new()
            { 
                Code = "TG",
                Type = "Canton",
                Name = "Thurgau",
                LocalName = "Thurgau"
            },
            new()
            { 
                Code = "TI",
                Type = "Canton",
                Name = "Ticino",
                LocalName = "Ticino"
            },
            new()
            { 
                Code = "UR",
                Type = "Canton",
                Name = "Uri",
                LocalName = "Uri"
            },
            new()
            { 
                Code = "VS",
                Type = "Canton",
                Name = "Valais",
                LocalName = "Valais"
            },
            new()
            { 
                Code = "VD",
                Type = "Canton",
                Name = "Vaud",
                LocalName = "Vaud"
            },
            new()
            { 
                Code = "ZG",
                Type = "Canton",
                Name = "Zug",
                LocalName = "Zug"
            },
            new()
            { 
                Code = "ZH",
                Type = "Canton",
                Name = "Zürich",
                LocalName = "Zürich"
            }

        });
    }
}
