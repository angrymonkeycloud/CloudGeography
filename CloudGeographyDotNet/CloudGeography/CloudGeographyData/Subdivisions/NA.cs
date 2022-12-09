using AngryMonkey.Cloud.Geography;
namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    private static void FillInSubdivisionsNA()
    {
        AddSubdivisions("NA", new List<Subdivision>()
        {
            new()
            { 
                Code = "ER",
                Type = "Region",
                Name = "Erongo",
                LocalName = "Erongo"
            },
            new()
            { 
                Code = "HA",
                Type = "Region",
                Name = "Hardap",
                LocalName = "Hardap"
            },
            new()
            { 
                Code = "KA",
                Type = "Region",
                Name = "Karas",
                LocalName = "Karas"
            },
            new()
            { 
                Code = "KE",
                Type = "Region",
                Name = "Kavango East",
                LocalName = "Kavango East"
            },
            new()
            { 
                Code = "KH",
                Type = "Region",
                Name = "Khomas",
                LocalName = "Khomas"
            },
            new()
            { 
                Code = "KU",
                Type = "Region",
                Name = "Kunene",
                LocalName = "Kunene"
            },
            new()
            { 
                Code = "OW",
                Type = "Region",
                Name = "Ohangwena",
                LocalName = "Ohangwena"
            },
            new()
            { 
                Code = "OH",
                Type = "Region",
                Name = "Omaheke",
                LocalName = "Omaheke"
            },
            new()
            { 
                Code = "OS",
                Type = "Region",
                Name = "Omusati",
                LocalName = "Omusati"
            },
            new()
            { 
                Code = "ON",
                Type = "Region",
                Name = "Oshana",
                LocalName = "Oshana"
            },
            new()
            { 
                Code = "OT",
                Type = "Region",
                Name = "Oshikoto",
                LocalName = "Oshikoto"
            },
            new()
            { 
                Code = "OD",
                Type = "Region",
                Name = "Otjozondjupa",
                LocalName = "Otjozondjupa"
            },
            new()
            { 
                Code = "CA",
                Type = "Region",
                Name = "Zambezi",
                LocalName = "Zambezi"
            }

        });
    }
}
