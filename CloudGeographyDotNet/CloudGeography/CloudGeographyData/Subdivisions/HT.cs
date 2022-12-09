using AngryMonkey.Cloud.Geography;
namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    private static void FillInSubdivisionsHT()
    {
        AddSubdivisions("HT", new List<Subdivision>()
        {
            new()
            { 
                Code = "AR",
                Type = "Department",
                Name = "Artibonite",
                LocalName = "Artibonite"
            },
            new()
            { 
                Code = "CE",
                Type = "Department",
                Name = "Centre",
                LocalName = "Centre"
            },
            new()
            { 
                Code = "GA",
                Type = "Department",
                Name = "GrandeAnse",
                LocalName = "GrandeAnse"
            },
            new()
            { 
                Code = "NI",
                Type = "Department",
                Name = "Nippes",
                LocalName = "Nippes"
            },
            new()
            { 
                Code = "ND",
                Type = "Department",
                Name = "Nord",
                LocalName = "Nord"
            },
            new()
            { 
                Code = "NE",
                Type = "Department",
                Name = "Nord-Est",
                LocalName = "Nord-Est"
            },
            new()
            { 
                Code = "NO",
                Type = "Department",
                Name = "Nord-Ouest",
                LocalName = "Nord-Ouest"
            },
            new()
            { 
                Code = "OU",
                Type = "Department",
                Name = "Ouest",
                LocalName = "Ouest"
            },
            new()
            { 
                Code = "SD",
                Type = "Department",
                Name = "Sud",
                LocalName = "Sud"
            },
            new()
            { 
                Code = "SE",
                Type = "Department",
                Name = "Sud-Est",
                LocalName = "Sud-Est"
            }

        });
    }
}
