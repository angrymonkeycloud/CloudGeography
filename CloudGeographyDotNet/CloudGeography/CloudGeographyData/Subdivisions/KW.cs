using AngryMonkey.Cloud.Geography;
namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    private static void FillInSubdivisionsKW()
    {
        AddSubdivisions("KW", new List<Subdivision>()
        {
            new()
            { 
                Code = "HA",
                Type = "Governorate",
                Name = "?awalli",
                LocalName = "?awalli"
            },
            new()
            { 
                Code = "KU",
                Type = "Governorate",
                Name = "Al Asimah",
                LocalName = "Al Asimah"
            },
            new()
            { 
                Code = "AH",
                Type = "Governorate",
                Name = "Al A?madi",
                LocalName = "Al A?madi"
            },
            new()
            { 
                Code = "FA",
                Type = "Governorate",
                Name = "Al Farwaniyah",
                LocalName = "Al Farwaniyah"
            },
            new()
            { 
                Code = "JA",
                Type = "Governorate",
                Name = "Al Jahra",
                LocalName = "Al Jahra"
            },
            new()
            { 
                Code = "MU",
                Type = "Governorate",
                Name = "Mubarak al Kabir",
                LocalName = "Mubarak al Kabir"
            }

        });
    }
}
