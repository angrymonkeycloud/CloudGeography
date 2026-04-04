using AngryMonkey.Cloud.Geography;
namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    private static void FillInSubdivisionsEE()
    {
        AddSubdivisions("EE",
        [
            new()
            { 
                Code = "37",
                Type = SubdivisionTypes.County,
                Name = "Harjumaa",
                LocalName = "Harjumaa"
            },
            new()
            { 
                Code = "39",
                Type = SubdivisionTypes.County,
                Name = "Hiiumaa",
                LocalName = "Hiiumaa"
            },
            new()
            { 
                Code = "44",
                Type = SubdivisionTypes.County,
                Name = "Ida-Virumaa",
                LocalName = "Ida-Virumaa"
            },
            new()
            { 
                Code = "51",
                Type = SubdivisionTypes.County,
                Name = "Järvamaa",
                LocalName = "Järvamaa"
            },
            new()
            { 
                Code = "49",
                Type = SubdivisionTypes.County,
                Name = "Jõgevamaa",
                LocalName = "Jõgevamaa"
            },
            new()
            { 
                Code = "57",
                Type = SubdivisionTypes.County,
                Name = "Läänemaa",
                LocalName = "Läänemaa"
            },
            new()
            { 
                Code = "59",
                Type = SubdivisionTypes.County,
                Name = "Lääne-Virumaa",
                LocalName = "Lääne-Virumaa"
            },
            new()
            { 
                Code = "67",
                Type = SubdivisionTypes.County,
                Name = "Pärnumaa",
                LocalName = "Pärnumaa"
            },
            new()
            { 
                Code = "65",
                Type = SubdivisionTypes.County,
                Name = "Põlvamaa",
                LocalName = "Põlvamaa"
            },
            new()
            { 
                Code = "70",
                Type = SubdivisionTypes.County,
                Name = "Raplamaa",
                LocalName = "Raplamaa"
            },
            new()
            { 
                Code = "74",
                Type = SubdivisionTypes.County,
                Name = "Saaremaa",
                LocalName = "Saaremaa"
            },
            new()
            { 
                Code = "78",
                Type = SubdivisionTypes.County,
                Name = "Tartumaa",
                LocalName = "Tartumaa"
            },
            new()
            { 
                Code = "82",
                Type = SubdivisionTypes.County,
                Name = "Valgamaa",
                LocalName = "Valgamaa"
            },
            new()
            { 
                Code = "84",
                Type = SubdivisionTypes.County,
                Name = "Viljandimaa",
                LocalName = "Viljandimaa"
            },
            new()
            { 
                Code = "86",
                Type = SubdivisionTypes.County,
                Name = "Võrumaa",
                LocalName = "Võrumaa"
            }

        ]);
    }
}
