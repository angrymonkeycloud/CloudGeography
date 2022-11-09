using AngryMonkey.Cloud.Geography;
namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    private static void FillInSubdivisionsBW()
    {
        AddSubdivisions("BW", new List<Subdivision>()
        {
            new()
            { 
                Code = "CE",
                Type = "District",
                Name = "Central",
                LocalName = "Central"
            },
            new()
            { 
                Code = "CH",
                Type = "District",
                Name = "Chobe",
                LocalName = "Chobe"
            },
            new()
            { 
                Code = "GH",
                Type = "District",
                Name = "Ghanzi",
                LocalName = "Ghanzi"
            },
            new()
            { 
                Code = "KG",
                Type = "District",
                Name = "Kgalagadi",
                LocalName = "Kgalagadi"
            },
            new()
            { 
                Code = "KL",
                Type = "District",
                Name = "Kgatleng",
                LocalName = "Kgatleng"
            },
            new()
            { 
                Code = "KW",
                Type = "District",
                Name = "Kweneng",
                LocalName = "Kweneng"
            },
            new()
            { 
                Code = "NE",
                Type = "District",
                Name = "North East",
                LocalName = "North East"
            },
            new()
            { 
                Code = "NW",
                Type = "District",
                Name = "North West",
                LocalName = "North West"
            },
            new()
            { 
                Code = "SE",
                Type = "District",
                Name = "South East",
                LocalName = "South East"
            },
            new()
            { 
                Code = "SO",
                Type = "District",
                Name = "Southern",
                LocalName = "Southern"
            }

        });
    }
}
