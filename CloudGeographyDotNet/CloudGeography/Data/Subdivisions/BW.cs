using AngryMonkey.Cloud.Geography;
namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    private static void FillInSubdivisionsBW()
    {
        AddSubdivisions("BW",
        [
            new()
            { 
                Code = "CE",
                Type = SubdivisionTypes.District,
                Name = "Central",
                LocalName = "Central"
            },
            new()
            { 
                Code = "CH",
                Type = SubdivisionTypes.District,
                Name = "Chobe",
                LocalName = "Chobe"
            },
            new()
            { 
                Code = "GH",
                Type = SubdivisionTypes.District,
                Name = "Ghanzi",
                LocalName = "Ghanzi"
            },
            new()
            { 
                Code = "KG",
                Type = SubdivisionTypes.District,
                Name = "Kgalagadi",
                LocalName = "Kgalagadi"
            },
            new()
            { 
                Code = "KL",
                Type = SubdivisionTypes.District,
                Name = "Kgatleng",
                LocalName = "Kgatleng"
            },
            new()
            { 
                Code = "KW",
                Type = SubdivisionTypes.District,
                Name = "Kweneng",
                LocalName = "Kweneng"
            },
            new()
            { 
                Code = "NE",
                Type = SubdivisionTypes.District,
                Name = "North East",
                LocalName = "North East"
            },
            new()
            { 
                Code = "NW",
                Type = SubdivisionTypes.District,
                Name = "North West",
                LocalName = "North West"
            },
            new()
            { 
                Code = "SE",
                Type = SubdivisionTypes.District,
                Name = "South East",
                LocalName = "South East"
            },
            new()
            { 
                Code = "SO",
                Type = SubdivisionTypes.District,
                Name = "Southern",
                LocalName = "Southern"
            }

        ]);
    }
}
