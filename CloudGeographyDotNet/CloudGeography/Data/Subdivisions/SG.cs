using AngryMonkey.Cloud.Geography;
namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    private static void FillInSubdivisionsSG()
    {
        AddSubdivisions("SG",
        [
            new()
            { 
                Code = "1",
                Type = SubdivisionTypes.District,
                Name = "Central Singapore",
                LocalName = "Central Singapore"
            },
            new()
            { 
                Code = "2",
                Type = SubdivisionTypes.District,
                Name = "North East",
                LocalName = "North East"
            },
            new()
            { 
                Code = "3",
                Type = SubdivisionTypes.District,
                Name = "North West",
                LocalName = "North West"
            },
            new()
            { 
                Code = "4",
                Type = SubdivisionTypes.District,
                Name = "South East",
                LocalName = "South East"
            },
            new()
            { 
                Code = "5",
                Type = SubdivisionTypes.District,
                Name = "South West",
                LocalName = "South West"
            }

        ]);
    }
}
