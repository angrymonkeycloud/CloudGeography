using AngryMonkey.Cloud.Geography;
namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    private static void FillInSubdivisionsZA()
    {
        AddSubdivisions("ZA",
        [
            new()
            { 
                Code = "EC",
                Type = SubdivisionTypes.Province,
                Name = "Eastern Cape",
                LocalName = "Eastern Cape"
            },
            new()
            { 
                Code = "FS",
                Type = SubdivisionTypes.Province,
                Name = "Free State",
                LocalName = "Free State"
            },
            new()
            { 
                Code = "GT",
                Type = SubdivisionTypes.Province,
                Name = "Gauteng",
                LocalName = "Gauteng"
            },
            new()
            { 
                Code = "NL",
                Type = SubdivisionTypes.Province,
                Name = "Kwazulu-Natal",
                LocalName = "Kwazulu-Natal"
            },
            new()
            { 
                Code = "LP",
                Type = SubdivisionTypes.Province,
                Name = "Limpopo",
                LocalName = "Limpopo"
            },
            new()
            { 
                Code = "MP",
                Type = SubdivisionTypes.Province,
                Name = "Mpumalanga",
                LocalName = "Mpumalanga"
            },
            new()
            { 
                Code = "NC",
                Type = SubdivisionTypes.Province,
                Name = "Northern Cape",
                LocalName = "Northern Cape"
            },
            new()
            { 
                Code = "NW",
                Type = SubdivisionTypes.Province,
                Name = "North-West",
                LocalName = "North-West"
            },
            new()
            { 
                Code = "WC",
                Type = SubdivisionTypes.Province,
                Name = "Western Cape",
                LocalName = "Western Cape"
            }

        ]);
    }
}
