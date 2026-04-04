using AngryMonkey.Cloud.Geography;
namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    private static void FillInSubdivisionsPK()
    {
        AddSubdivisions("PK",
        [
            new()
            { 
                Code = "JK",
                Type = SubdivisionTypes.Area,
                Name = "Azad Kashmir",
                LocalName = "Azad Kashmir"
            },
            new()
            { 
                Code = "BA",
                Type = SubdivisionTypes.Province,
                Name = "Balochistan",
                LocalName = "Balochistan"
            },
            new()
            { 
                Code = "TA",
                Type = SubdivisionTypes.Territory,
                Name = "Federally Administered Tribal Areas",
                LocalName = "Federally Administered Tribal Areas"
            },
            new()
            { 
                Code = "GB",
                Type = SubdivisionTypes.Area,
                Name = "Gilgit-Baltistan",
                LocalName = "Gilgit-Baltistan"
            },
            new()
            { 
                Code = "IS",
                Type = SubdivisionTypes.Territory,
                Name = "Islamabad",
                LocalName = "Islamabad"
            },
            new()
            { 
                Code = "KP",
                Type = SubdivisionTypes.Province,
                Name = "Khyber Pakhtunkhwa",
                LocalName = "Khyber Pakhtunkhwa"
            },
            new()
            { 
                Code = "PB",
                Type = SubdivisionTypes.Province,
                Name = "Punjab",
                LocalName = "Punjab"
            },
            new()
            { 
                Code = "SD",
                Type = SubdivisionTypes.Province,
                Name = "Sindh",
                LocalName = "Sindh"
            }

        ]);
    }
}
