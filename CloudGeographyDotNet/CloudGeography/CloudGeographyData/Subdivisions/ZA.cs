using AngryMonkey.Cloud.Geography;
namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    private static void FillInSubdivisionsZA()
    {
        AddSubdivisions("ZA", new List<Subdivision>()
        {
            new()
            { 
                Code = "EC",
                Type = "Province",
                Name = "Eastern Cape",
                LocalName = "Eastern Cape"
            },
            new()
            { 
                Code = "FS",
                Type = "Province",
                Name = "Free State",
                LocalName = "Free State"
            },
            new()
            { 
                Code = "GT",
                Type = "Province",
                Name = "Gauteng",
                LocalName = "Gauteng"
            },
            new()
            { 
                Code = "NL",
                Type = "Province",
                Name = "Kwazulu-Natal",
                LocalName = "Kwazulu-Natal"
            },
            new()
            { 
                Code = "LP",
                Type = "Province",
                Name = "Limpopo",
                LocalName = "Limpopo"
            },
            new()
            { 
                Code = "MP",
                Type = "Province",
                Name = "Mpumalanga",
                LocalName = "Mpumalanga"
            },
            new()
            { 
                Code = "NC",
                Type = "Province",
                Name = "Northern Cape",
                LocalName = "Northern Cape"
            },
            new()
            { 
                Code = "NW",
                Type = "Province",
                Name = "North-West",
                LocalName = "North-West"
            },
            new()
            { 
                Code = "WC",
                Type = "Province",
                Name = "Western Cape",
                LocalName = "Western Cape"
            }

        });
    }
}
