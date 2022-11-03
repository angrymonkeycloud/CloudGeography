using AngryMonkey.Cloud.Geography;
namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    private static void FillInSubdivisionsGY()
    {
        AddSubdivisions("GY", new List<Subdivision>()
        {
            new()
            { 
                Code = "BA",
                Type = "Region",
                Name = "Barima-Waini",
                LocalName = "Barima-Waini"
            },
            new()
            { 
                Code = "CU",
                Type = "Region",
                Name = "Cuyuni-Mazaruni",
                LocalName = "Cuyuni-Mazaruni"
            },
            new()
            { 
                Code = "DE",
                Type = "Region",
                Name = "Demerara-Mahaica",
                LocalName = "Demerara-Mahaica"
            },
            new()
            { 
                Code = "EB",
                Type = "Region",
                Name = "East Berbice-Corentyne",
                LocalName = "East Berbice-Corentyne"
            },
            new()
            { 
                Code = "ES",
                Type = "Region",
                Name = "Essequibo Islands-West Demerara",
                LocalName = "Essequibo Islands-West Demerara"
            },
            new()
            { 
                Code = "MA",
                Type = "Region",
                Name = "Mahaica-Berbice",
                LocalName = "Mahaica-Berbice"
            },
            new()
            { 
                Code = "PM",
                Type = "Region",
                Name = "Pomeroon-Supenaam",
                LocalName = "Pomeroon-Supenaam"
            },
            new()
            { 
                Code = "PT",
                Type = "Region",
                Name = "Potaro-Siparuni",
                LocalName = "Potaro-Siparuni"
            },
            new()
            { 
                Code = "UD",
                Type = "Region",
                Name = "Upper Demerara-Berbice",
                LocalName = "Upper Demerara-Berbice"
            },
            new()
            { 
                Code = "UT",
                Type = "Region",
                Name = "Upper Takutu-Upper Essequibo",
                LocalName = "Upper Takutu-Upper Essequibo"
            }

        });
    }
}
