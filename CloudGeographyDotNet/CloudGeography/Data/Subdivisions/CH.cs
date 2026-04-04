using AngryMonkey.Cloud.Geography;
namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    private static void FillInSubdivisionsCH()
    {
        AddSubdivisions("CH",
        [
            new()
            { 
                Code = "AG",
                Type = SubdivisionTypes.Canton,
                Name = "Aargau",
                LocalName = "Aargau"
            },
            new()
            { 
                Code = "AR",
                Type = SubdivisionTypes.Canton,
                Name = "Appenzell Ausserrhoden",
                LocalName = "Appenzell Ausserrhoden"
            },
            new()
            { 
                Code = "AI",
                Type = SubdivisionTypes.Canton,
                Name = "Appenzell Innerrhoden",
                LocalName = "Appenzell Innerrhoden"
            },
            new()
            { 
                Code = "BL",
                Type = SubdivisionTypes.Canton,
                Name = "Basel-Landschaft",
                LocalName = "Basel-Landschaft"
            },
            new()
            { 
                Code = "BS",
                Type = SubdivisionTypes.Canton,
                Name = "Basel-Stadt",
                LocalName = "Basel-Stadt"
            },
            new()
            { 
                Code = "BE",
                Type = SubdivisionTypes.Canton,
                Name = "Bern",
                LocalName = "Bern"
            },
            new()
            { 
                Code = "FR",
                Type = SubdivisionTypes.Canton,
                Name = "Fribourg",
                LocalName = "Fribourg"
            },
            new()
            { 
                Code = "GE",
                Type = SubdivisionTypes.Canton,
                Name = "Genève",
                LocalName = "Genève"
            },
            new()
            { 
                Code = "GL",
                Type = SubdivisionTypes.Canton,
                Name = "Glarus",
                LocalName = "Glarus"
            },
            new()
            { 
                Code = "GR",
                Type = SubdivisionTypes.Canton,
                Name = "Graubünden",
                LocalName = "Graubünden"
            },
            new()
            { 
                Code = "JU",
                Type = SubdivisionTypes.Canton,
                Name = "Jura",
                LocalName = "Jura"
            },
            new()
            { 
                Code = "LU",
                Type = SubdivisionTypes.Canton,
                Name = "Luzern",
                LocalName = "Luzern"
            },
            new()
            { 
                Code = "NE",
                Type = SubdivisionTypes.Canton,
                Name = "Neuchâtel",
                LocalName = "Neuchâtel"
            },
            new()
            { 
                Code = "NW",
                Type = SubdivisionTypes.Canton,
                Name = "Nidwalden",
                LocalName = "Nidwalden"
            },
            new()
            { 
                Code = "OW",
                Type = SubdivisionTypes.Canton,
                Name = "Obwalden",
                LocalName = "Obwalden"
            },
            new()
            { 
                Code = "SG",
                Type = SubdivisionTypes.Canton,
                Name = "Sankt Gallen",
                LocalName = "Sankt Gallen"
            },
            new()
            { 
                Code = "SH",
                Type = SubdivisionTypes.Canton,
                Name = "Schaffhausen",
                LocalName = "Schaffhausen"
            },
            new()
            { 
                Code = "SZ",
                Type = SubdivisionTypes.Canton,
                Name = "Schwyz",
                LocalName = "Schwyz"
            },
            new()
            { 
                Code = "SO",
                Type = SubdivisionTypes.Canton,
                Name = "Solothurn",
                LocalName = "Solothurn"
            },
            new()
            { 
                Code = "TG",
                Type = SubdivisionTypes.Canton,
                Name = "Thurgau",
                LocalName = "Thurgau"
            },
            new()
            { 
                Code = "TI",
                Type = SubdivisionTypes.Canton,
                Name = "Ticino",
                LocalName = "Ticino"
            },
            new()
            { 
                Code = "UR",
                Type = SubdivisionTypes.Canton,
                Name = "Uri",
                LocalName = "Uri"
            },
            new()
            { 
                Code = "VS",
                Type = SubdivisionTypes.Canton,
                Name = "Valais",
                LocalName = "Valais"
            },
            new()
            { 
                Code = "VD",
                Type = SubdivisionTypes.Canton,
                Name = "Vaud",
                LocalName = "Vaud"
            },
            new()
            { 
                Code = "ZG",
                Type = SubdivisionTypes.Canton,
                Name = "Zug",
                LocalName = "Zug"
            },
            new()
            { 
                Code = "ZH",
                Type = SubdivisionTypes.Canton,
                Name = "Zürich",
                LocalName = "Zürich"
            }

        ]);
    }
}
