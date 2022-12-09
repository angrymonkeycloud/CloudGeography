using AngryMonkey.Cloud.Geography;
namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    private static void FillInSubdivisionsBE()
    {
        AddSubdivisions("BE", new List<Subdivision>()
        {
            new()
            { 
                Code = "VAN",
                Type = "Province",
                Name = "Antwerp",
                LocalName = "Antwerpen"
            },
            new()
            { 
                Code = "BRU",
                Type = "Region",
                Name = "Brussels-Capital Region",
                LocalName = "Brussels Hoofdstedelijk Gewest"
            },
            new()
            { 
                Code = "VOV",
                Type = "Province",
                Name = "East Flanders",
                LocalName = "Oost-Vlaanderen"
            },
            new()
            { 
                Code = "VBR",
                Type = "Province",
                Name = "Flemish Brabant",
                LocalName = "Vlaams-Brabant"
            },
            new()
            { 
                Code = "WHT",
                Type = "Province",
                Name = "Hainaut",
                LocalName = "Henegouwen"
            },
            new()
            { 
                Code = "WLG",
                Type = "Province",
                Name = "Liège",
                LocalName = "Luik"
            },
            new()
            { 
                Code = "VLI",
                Type = "Province",
                Name = "Limburg",
                LocalName = "Limburg"
            },
            new()
            { 
                Code = "WLX",
                Type = "Province",
                Name = "Luxembourg",
                LocalName = "Luxemburg"
            },
            new()
            { 
                Code = "WNA",
                Type = "Province",
                Name = "Namur",
                LocalName = "Namen"
            },
            new()
            { 
                Code = "WBR",
                Type = "Province",
                Name = "Walloon Brabant",
                LocalName = "Waals-Brabant"
            },
            new()
            { 
                Code = "VWV",
                Type = "Province",
                Name = "West Flanders",
                LocalName = "West-Vlaanderen"
            }

        });
    }
}
