using AngryMonkey.Cloud.Geography;
namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    private static void FillInSubdivisionsHT()
    {
        AddSubdivisions("HT",
        [
            new()
            { 
                Code = "AR",
                Type = SubdivisionTypes.Department,
                Name = "Artibonite",
                LocalName = "Artibonite"
            },
            new()
            { 
                Code = "CE",
                Type = SubdivisionTypes.Department,
                Name = "Centre",
                LocalName = "Centre"
            },
            new()
            { 
                Code = "GA",
                Type = SubdivisionTypes.Department,
                Name = "GrandeAnse",
                LocalName = "GrandeAnse"
            },
            new()
            { 
                Code = "NI",
                Type = SubdivisionTypes.Department,
                Name = "Nippes",
                LocalName = "Nippes"
            },
            new()
            { 
                Code = "ND",
                Type = SubdivisionTypes.Department,
                Name = "Nord",
                LocalName = "Nord"
            },
            new()
            { 
                Code = "NE",
                Type = SubdivisionTypes.Department,
                Name = "Nord-Est",
                LocalName = "Nord-Est"
            },
            new()
            { 
                Code = "NO",
                Type = SubdivisionTypes.Department,
                Name = "Nord-Ouest",
                LocalName = "Nord-Ouest"
            },
            new()
            { 
                Code = "OU",
                Type = SubdivisionTypes.Department,
                Name = "Ouest",
                LocalName = "Ouest"
            },
            new()
            { 
                Code = "SD",
                Type = SubdivisionTypes.Department,
                Name = "Sud",
                LocalName = "Sud"
            },
            new()
            { 
                Code = "SE",
                Type = SubdivisionTypes.Department,
                Name = "Sud-Est",
                LocalName = "Sud-Est"
            }

        ]);
    }
}
