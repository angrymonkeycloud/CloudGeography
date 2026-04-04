using AngryMonkey.Cloud.Geography;
namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    private static void FillInSubdivisionsNA()
    {
        AddSubdivisions("NA",
        [
            new()
            { 
                Code = "ER",
                Type = SubdivisionTypes.Region,
                Name = "Erongo",
                LocalName = "Erongo"
            },
            new()
            { 
                Code = "HA",
                Type = SubdivisionTypes.Region,
                Name = "Hardap",
                LocalName = "Hardap"
            },
            new()
            { 
                Code = "KA",
                Type = SubdivisionTypes.Region,
                Name = "Karas",
                LocalName = "Karas"
            },
            new()
            { 
                Code = "KE",
                Type = SubdivisionTypes.Region,
                Name = "Kavango East",
                LocalName = "Kavango East"
            },
            new()
            { 
                Code = "KH",
                Type = SubdivisionTypes.Region,
                Name = "Khomas",
                LocalName = "Khomas"
            },
            new()
            { 
                Code = "KU",
                Type = SubdivisionTypes.Region,
                Name = "Kunene",
                LocalName = "Kunene"
            },
            new()
            { 
                Code = "OW",
                Type = SubdivisionTypes.Region,
                Name = "Ohangwena",
                LocalName = "Ohangwena"
            },
            new()
            { 
                Code = "OH",
                Type = SubdivisionTypes.Region,
                Name = "Omaheke",
                LocalName = "Omaheke"
            },
            new()
            { 
                Code = "OS",
                Type = SubdivisionTypes.Region,
                Name = "Omusati",
                LocalName = "Omusati"
            },
            new()
            { 
                Code = "ON",
                Type = SubdivisionTypes.Region,
                Name = "Oshana",
                LocalName = "Oshana"
            },
            new()
            { 
                Code = "OT",
                Type = SubdivisionTypes.Region,
                Name = "Oshikoto",
                LocalName = "Oshikoto"
            },
            new()
            { 
                Code = "OD",
                Type = SubdivisionTypes.Region,
                Name = "Otjozondjupa",
                LocalName = "Otjozondjupa"
            },
            new()
            { 
                Code = "CA",
                Type = SubdivisionTypes.Region,
                Name = "Zambezi",
                LocalName = "Zambezi"
            }

        ]);
    }
}
