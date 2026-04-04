using AngryMonkey.Cloud.Geography;
namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    private static void FillInSubdivisionsKG()
    {
        AddSubdivisions("KG",
        [
            new()
            { 
                Code = "B",
                Type = SubdivisionTypes.Region,
                Name = "Batken",
                LocalName = "Batken"
            },
            new()
            { 
                Code = "GB",
                Type = SubdivisionTypes.City,
                Name = "Bishkek",
                LocalName = "Bishkek"
            },
            new()
            { 
                Code = "C",
                Type = SubdivisionTypes.Region,
                Name = "Chüy",
                LocalName = "Chüy"
            },
            new()
            { 
                Code = "J",
                Type = SubdivisionTypes.Region,
                Name = "Jalal-Abad",
                LocalName = "Jalal-Abad"
            },
            new()
            { 
                Code = "N",
                Type = SubdivisionTypes.Region,
                Name = "Naryn",
                LocalName = "Naryn"
            },
            new()
            { 
                Code = "GO",
                Type = SubdivisionTypes.City,
                Name = "Osh",
                LocalName = "Osh"
            },
            new()
            { 
                Code = "O",
                Type = SubdivisionTypes.Region,
                Name = "Osh",
                LocalName = "Osh"
            },
            new()
            { 
                Code = "T",
                Type = SubdivisionTypes.Region,
                Name = "Talas",
                LocalName = "Talas"
            },
            new()
            { 
                Code = "Y",
                Type = SubdivisionTypes.Region,
                Name = "Ysyk-Köl",
                LocalName = "Ysyk-Köl"
            }

        ]);
    }
}
