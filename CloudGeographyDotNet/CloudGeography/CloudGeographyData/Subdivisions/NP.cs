using AngryMonkey.Cloud.Geography;
namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    private static void FillInSubdivisionsNP()
    {
        AddSubdivisions("NP", new List<Subdivision>()
        {
            new()
            { 
                Code = "BA",
                Type = "Zone",
                Name = "Bagmati",
                LocalName = "Bagmati"
            },
            new()
            { 
                Code = "BH",
                Type = "Zone",
                Name = "Bheri",
                LocalName = "Bheri"
            },
            new()
            { 
                Code = "DH",
                Type = "Zone",
                Name = "Dhawalagiri",
                LocalName = "Dhawalagiri"
            },
            new()
            { 
                Code = "GA",
                Type = "Zone",
                Name = "Gandaki",
                LocalName = "Gandaki"
            },
            new()
            { 
                Code = "JA",
                Type = "Zone",
                Name = "Janakpur",
                LocalName = "Janakpur"
            },
            new()
            { 
                Code = "KA",
                Type = "Zone",
                Name = "Karnali",
                LocalName = "Karnali"
            },
            new()
            { 
                Code = "KO",
                Type = "Zone",
                Name = "Kosi",
                LocalName = "Kosi"
            },
            new()
            { 
                Code = "LU",
                Type = "Zone",
                Name = "Lumbini",
                LocalName = "Lumbini"
            },
            new()
            { 
                Code = "MA",
                Type = "Zone",
                Name = "Mahakali",
                LocalName = "Mahakali"
            },
            new()
            { 
                Code = "ME",
                Type = "Zone",
                Name = "Mechi",
                LocalName = "Mechi"
            },
            new()
            { 
                Code = "NA",
                Type = "Zone",
                Name = "Narayani",
                LocalName = "Narayani"
            },
            new()
            { 
                Code = "RA",
                Type = "Zone",
                Name = "Rapti",
                LocalName = "Rapti"
            },
            new()
            { 
                Code = "SA",
                Type = "Zone",
                Name = "Sagarmatha",
                LocalName = "Sagarmatha"
            },
            new()
            { 
                Code = "SE",
                Type = "Zone",
                Name = "Seti",
                LocalName = "Seti"
            }

        });
    }
}
