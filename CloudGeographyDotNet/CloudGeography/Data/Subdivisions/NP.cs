using AngryMonkey.Cloud.Geography;
namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    private static void FillInSubdivisionsNP()
    {
        AddSubdivisions("NP",
        [
            new()
            { 
                Code = "BA",
                Type = SubdivisionTypes.Zone,
                Name = "Bagmati",
                LocalName = "Bagmati"
            },
            new()
            { 
                Code = "BH",
                Type = SubdivisionTypes.Zone,
                Name = "Bheri",
                LocalName = "Bheri"
            },
            new()
            { 
                Code = "DH",
                Type = SubdivisionTypes.Zone,
                Name = "Dhawalagiri",
                LocalName = "Dhawalagiri"
            },
            new()
            { 
                Code = "GA",
                Type = SubdivisionTypes.Zone,
                Name = "Gandaki",
                LocalName = "Gandaki"
            },
            new()
            { 
                Code = "JA",
                Type = SubdivisionTypes.Zone,
                Name = "Janakpur",
                LocalName = "Janakpur"
            },
            new()
            { 
                Code = "KA",
                Type = SubdivisionTypes.Zone,
                Name = "Karnali",
                LocalName = "Karnali"
            },
            new()
            { 
                Code = "KO",
                Type = SubdivisionTypes.Zone,
                Name = "Kosi",
                LocalName = "Kosi"
            },
            new()
            { 
                Code = "LU",
                Type = SubdivisionTypes.Zone,
                Name = "Lumbini",
                LocalName = "Lumbini"
            },
            new()
            { 
                Code = "MA",
                Type = SubdivisionTypes.Zone,
                Name = "Mahakali",
                LocalName = "Mahakali"
            },
            new()
            { 
                Code = "ME",
                Type = SubdivisionTypes.Zone,
                Name = "Mechi",
                LocalName = "Mechi"
            },
            new()
            { 
                Code = "NA",
                Type = SubdivisionTypes.Zone,
                Name = "Narayani",
                LocalName = "Narayani"
            },
            new()
            { 
                Code = "RA",
                Type = SubdivisionTypes.Zone,
                Name = "Rapti",
                LocalName = "Rapti"
            },
            new()
            { 
                Code = "SA",
                Type = SubdivisionTypes.Zone,
                Name = "Sagarmatha",
                LocalName = "Sagarmatha"
            },
            new()
            { 
                Code = "SE",
                Type = SubdivisionTypes.Zone,
                Name = "Seti",
                LocalName = "Seti"
            }

        ]);
    }
}
