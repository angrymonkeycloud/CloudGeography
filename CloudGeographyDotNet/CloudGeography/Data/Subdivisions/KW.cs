using AngryMonkey.Cloud.Geography;
namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    private static void FillInSubdivisionsKW()
    {
        AddSubdivisions("KW",
        [
            new()
            { 
                Code = "HA",
                Type = SubdivisionTypes.Governorate,
                Name = "?awalli",
                LocalName = "?awalli"
            },
            new()
            { 
                Code = "KU",
                Type = SubdivisionTypes.Governorate,
                Name = "Al Asimah",
                LocalName = "Al Asimah"
            },
            new()
            { 
                Code = "AH",
                Type = SubdivisionTypes.Governorate,
                Name = "Al A?madi",
                LocalName = "Al A?madi"
            },
            new()
            { 
                Code = "FA",
                Type = SubdivisionTypes.Governorate,
                Name = "Al Farwaniyah",
                LocalName = "Al Farwaniyah"
            },
            new()
            { 
                Code = "JA",
                Type = SubdivisionTypes.Governorate,
                Name = "Al Jahra",
                LocalName = "Al Jahra"
            },
            new()
            { 
                Code = "MU",
                Type = SubdivisionTypes.Governorate,
                Name = "Mubarak al Kabir",
                LocalName = "Mubarak al Kabir"
            }

        ]);
    }
}
