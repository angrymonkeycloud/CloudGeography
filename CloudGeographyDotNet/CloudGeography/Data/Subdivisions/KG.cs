using AngryMonkey.Cloud.Geography;
namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    private static void FillInSubdivisionsKG()
    {
        AddSubdivisions("KG", new List<Subdivision>()
        {
            new()
            { 
                Code = "B",
                Type = "Region",
                Name = "Batken",
                LocalName = "Batken"
            },
            new()
            { 
                Code = "GB",
                Type = "City",
                Name = "Bishkek",
                LocalName = "Bishkek"
            },
            new()
            { 
                Code = "C",
                Type = "Region",
                Name = "Chüy",
                LocalName = "Chüy"
            },
            new()
            { 
                Code = "J",
                Type = "Region",
                Name = "Jalal-Abad",
                LocalName = "Jalal-Abad"
            },
            new()
            { 
                Code = "N",
                Type = "Region",
                Name = "Naryn",
                LocalName = "Naryn"
            },
            new()
            { 
                Code = "GO",
                Type = "City",
                Name = "Osh",
                LocalName = "Osh"
            },
            new()
            { 
                Code = "O",
                Type = "Region",
                Name = "Osh",
                LocalName = "Osh"
            },
            new()
            { 
                Code = "T",
                Type = "Region",
                Name = "Talas",
                LocalName = "Talas"
            },
            new()
            { 
                Code = "Y",
                Type = "Region",
                Name = "Ysyk-Köl",
                LocalName = "Ysyk-Köl"
            }

        });
    }
}
