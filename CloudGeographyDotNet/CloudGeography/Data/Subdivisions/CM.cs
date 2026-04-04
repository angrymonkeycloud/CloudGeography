using AngryMonkey.Cloud.Geography;
namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    private static void FillInSubdivisionsCM()
    {
        AddSubdivisions("CM",
        [
            new()
            { 
                Code = "AD",
                Type = SubdivisionTypes.Region,
                Name = "Adamaoua",
                LocalName = "Adamaoua"
            },
            new()
            { 
                Code = "CE",
                Type = SubdivisionTypes.Region,
                Name = "Centre",
                LocalName = "Centre"
            },
            new()
            { 
                Code = "ES",
                Type = SubdivisionTypes.Region,
                Name = "East",
                LocalName = "East"
            },
            new()
            { 
                Code = "EN",
                Type = SubdivisionTypes.Region,
                Name = "Far North",
                LocalName = "Far North"
            },
            new()
            { 
                Code = "LT",
                Type = SubdivisionTypes.Region,
                Name = "Littoral",
                LocalName = "Littoral"
            },
            new()
            { 
                Code = "NO",
                Type = SubdivisionTypes.Region,
                Name = "North",
                LocalName = "North"
            },
            new()
            { 
                Code = "NW",
                Type = SubdivisionTypes.Region,
                Name = "North-West",
                LocalName = "North-West"
            },
            new()
            { 
                Code = "SU",
                Type = SubdivisionTypes.Region,
                Name = "South",
                LocalName = "South"
            },
            new()
            { 
                Code = "SW",
                Type = SubdivisionTypes.Region,
                Name = "South-West",
                LocalName = "South-West"
            },
            new()
            { 
                Code = "OU",
                Type = SubdivisionTypes.Region,
                Name = "West",
                LocalName = "West"
            }

        ]);
    }
}
