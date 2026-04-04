using AngryMonkey.Cloud.Geography;
namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    private static void FillInSubdivisionsMV()
    {
        AddSubdivisions("MV",
        [
            new()
            { 
                Code = "SU",
                Type = SubdivisionTypes.Province,
                Name = "Dhekunu",
                LocalName = "Dhekunu"
            },
            new()
            { 
                Code = "MLE",
                Type = SubdivisionTypes.Capital,
                Name = "Male",
                LocalName = "Male"
            },
            new()
            { 
                Code = "US",
                Type = SubdivisionTypes.Province,
                Name = "Mathi-Dhekunu",
                LocalName = "Mathi-Dhekunu"
            },
            new()
            { 
                Code = "UN",
                Type = SubdivisionTypes.Province,
                Name = "Mathi-Uthuru",
                LocalName = "Mathi-Uthuru"
            },
            new()
            { 
                Code = "CE",
                Type = SubdivisionTypes.Province,
                Name = "Medhu",
                LocalName = "Medhu"
            },
            new()
            { 
                Code = "SC",
                Type = SubdivisionTypes.Province,
                Name = "Medhu-Dhekunu",
                LocalName = "Medhu-Dhekunu"
            },
            new()
            { 
                Code = "NC",
                Type = SubdivisionTypes.Province,
                Name = "Medhu-Uthuru",
                LocalName = "Medhu-Uthuru"
            },
            new()
            { 
                Code = "NO",
                Type = SubdivisionTypes.Province,
                Name = "Uthuru",
                LocalName = "Uthuru"
            }

        ]);
    }
}
