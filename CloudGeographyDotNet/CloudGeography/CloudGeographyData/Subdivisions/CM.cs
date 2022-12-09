using AngryMonkey.Cloud.Geography;
namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    private static void FillInSubdivisionsCM()
    {
        AddSubdivisions("CM", new List<Subdivision>()
        {
            new()
            { 
                Code = "AD",
                Type = "Region",
                Name = "Adamaoua",
                LocalName = "Adamaoua"
            },
            new()
            { 
                Code = "CE",
                Type = "Region",
                Name = "Centre",
                LocalName = "Centre"
            },
            new()
            { 
                Code = "ES",
                Type = "Region",
                Name = "East",
                LocalName = "East"
            },
            new()
            { 
                Code = "EN",
                Type = "Region",
                Name = "Far North",
                LocalName = "Far North"
            },
            new()
            { 
                Code = "LT",
                Type = "Region",
                Name = "Littoral",
                LocalName = "Littoral"
            },
            new()
            { 
                Code = "NO",
                Type = "Region",
                Name = "North",
                LocalName = "North"
            },
            new()
            { 
                Code = "NW",
                Type = "Region",
                Name = "North-West",
                LocalName = "North-West"
            },
            new()
            { 
                Code = "SU",
                Type = "Region",
                Name = "South",
                LocalName = "South"
            },
            new()
            { 
                Code = "SW",
                Type = "Region",
                Name = "South-West",
                LocalName = "South-West"
            },
            new()
            { 
                Code = "OU",
                Type = "Region",
                Name = "West",
                LocalName = "West"
            }

        });
    }
}
