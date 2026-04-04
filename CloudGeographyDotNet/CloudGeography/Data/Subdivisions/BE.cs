using AngryMonkey.Cloud.Geography;
namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    private static void FillInSubdivisionsBE()
    {
        AddSubdivisions("BE",
        [
            new()
            { 
                Code = "VAN",
                Type = SubdivisionTypes.Province,
                Name = "Antwerp",
                LocalName = "Antwerpen"
            },
            new()
            { 
                Code = "BRU",
                Type = SubdivisionTypes.Region,
                Name = "Brussels-Capital Region",
                LocalName = "Brussels Hoofdstedelijk Gewest"
            },
            new()
            { 
                Code = "VOV",
                Type = SubdivisionTypes.Province,
                Name = "East Flanders",
                LocalName = "Oost-Vlaanderen"
            },
            new()
            { 
                Code = "VBR",
                Type = SubdivisionTypes.Province,
                Name = "Flemish Brabant",
                LocalName = "Vlaams-Brabant"
            },
            new()
            { 
                Code = "WHT",
                Type = SubdivisionTypes.Province,
                Name = "Hainaut",
                LocalName = "Henegouwen"
            },
            new()
            { 
                Code = "WLG",
                Type = SubdivisionTypes.Province,
                Name = "Liège",
                LocalName = "Luik"
            },
            new()
            { 
                Code = "VLI",
                Type = SubdivisionTypes.Province,
                Name = "Limburg",
                LocalName = "Limburg"
            },
            new()
            { 
                Code = "WLX",
                Type = SubdivisionTypes.Province,
                Name = "Luxembourg",
                LocalName = "Luxemburg"
            },
            new()
            { 
                Code = "WNA",
                Type = SubdivisionTypes.Province,
                Name = "Namur",
                LocalName = "Namen"
            },
            new()
            { 
                Code = "WBR",
                Type = SubdivisionTypes.Province,
                Name = "Walloon Brabant",
                LocalName = "Waals-Brabant"
            },
            new()
            { 
                Code = "VWV",
                Type = SubdivisionTypes.Province,
                Name = "West Flanders",
                LocalName = "West-Vlaanderen"
            }

        ]);
    }
}
