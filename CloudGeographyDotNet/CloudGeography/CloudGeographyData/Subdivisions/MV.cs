using AngryMonkey.Cloud.Geography;
namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    private static void FillInSubdivisionsMV()
    {
        AddSubdivisions("MV", new List<Subdivision>()
        {
            new()
            { 
                Code = "SU",
                Type = "Province",
                Name = "Dhekunu",
                LocalName = "Dhekunu"
            },
            new()
            { 
                Code = "MLE",
                Type = "Capital",
                Name = "Male",
                LocalName = "Male"
            },
            new()
            { 
                Code = "US",
                Type = "Province",
                Name = "Mathi-Dhekunu",
                LocalName = "Mathi-Dhekunu"
            },
            new()
            { 
                Code = "UN",
                Type = "Province",
                Name = "Mathi-Uthuru",
                LocalName = "Mathi-Uthuru"
            },
            new()
            { 
                Code = "CE",
                Type = "Province",
                Name = "Medhu",
                LocalName = "Medhu"
            },
            new()
            { 
                Code = "SC",
                Type = "Province",
                Name = "Medhu-Dhekunu",
                LocalName = "Medhu-Dhekunu"
            },
            new()
            { 
                Code = "NC",
                Type = "Province",
                Name = "Medhu-Uthuru",
                LocalName = "Medhu-Uthuru"
            },
            new()
            { 
                Code = "NO",
                Type = "Province",
                Name = "Uthuru",
                LocalName = "Uthuru"
            }

        });
    }
}
