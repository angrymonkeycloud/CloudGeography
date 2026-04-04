using AngryMonkey.Cloud.Geography;
namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    private static void FillInSubdivisionsGY()
    {
        AddSubdivisions("GY",
        [
            new()
            { 
                Code = "BA",
                Type = SubdivisionTypes.Region,
                Name = "Barima-Waini",
                LocalName = "Barima-Waini"
            },
            new()
            { 
                Code = "CU",
                Type = SubdivisionTypes.Region,
                Name = "Cuyuni-Mazaruni",
                LocalName = "Cuyuni-Mazaruni"
            },
            new()
            { 
                Code = "DE",
                Type = SubdivisionTypes.Region,
                Name = "Demerara-Mahaica",
                LocalName = "Demerara-Mahaica"
            },
            new()
            { 
                Code = "EB",
                Type = SubdivisionTypes.Region,
                Name = "East Berbice-Corentyne",
                LocalName = "East Berbice-Corentyne"
            },
            new()
            { 
                Code = "ES",
                Type = SubdivisionTypes.Region,
                Name = "Essequibo Islands-West Demerara",
                LocalName = "Essequibo Islands-West Demerara"
            },
            new()
            { 
                Code = "MA",
                Type = SubdivisionTypes.Region,
                Name = "Mahaica-Berbice",
                LocalName = "Mahaica-Berbice"
            },
            new()
            { 
                Code = "PM",
                Type = SubdivisionTypes.Region,
                Name = "Pomeroon-Supenaam",
                LocalName = "Pomeroon-Supenaam"
            },
            new()
            { 
                Code = "PT",
                Type = SubdivisionTypes.Region,
                Name = "Potaro-Siparuni",
                LocalName = "Potaro-Siparuni"
            },
            new()
            { 
                Code = "UD",
                Type = SubdivisionTypes.Region,
                Name = "Upper Demerara-Berbice",
                LocalName = "Upper Demerara-Berbice"
            },
            new()
            { 
                Code = "UT",
                Type = SubdivisionTypes.Region,
                Name = "Upper Takutu-Upper Essequibo",
                LocalName = "Upper Takutu-Upper Essequibo"
            }

        ]);
    }
}
