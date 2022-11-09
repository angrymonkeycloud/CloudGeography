using AngryMonkey.Cloud.Geography;
namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    private static void FillInSubdivisionsPK()
    {
        AddSubdivisions("PK", new List<Subdivision>()
        {
            new()
            { 
                Code = "JK",
                Type = "Area",
                Name = "Azad Kashmir",
                LocalName = "Azad Kashmir"
            },
            new()
            { 
                Code = "BA",
                Type = "Province",
                Name = "Balochistan",
                LocalName = "Balochistan"
            },
            new()
            { 
                Code = "TA",
                Type = "Territory",
                Name = "Federally Administered Tribal Areas",
                LocalName = "Federally Administered Tribal Areas"
            },
            new()
            { 
                Code = "GB",
                Type = "Area",
                Name = "Gilgit-Baltistan",
                LocalName = "Gilgit-Baltistan"
            },
            new()
            { 
                Code = "IS",
                Type = "Territory",
                Name = "Islamabad",
                LocalName = "Islamabad"
            },
            new()
            { 
                Code = "KP",
                Type = "Province",
                Name = "Khyber Pakhtunkhwa",
                LocalName = "Khyber Pakhtunkhwa"
            },
            new()
            { 
                Code = "PB",
                Type = "Province",
                Name = "Punjab",
                LocalName = "Punjab"
            },
            new()
            { 
                Code = "SD",
                Type = "Province",
                Name = "Sindh",
                LocalName = "Sindh"
            }

        });
    }
}
