using AngryMonkey.Cloud.Geography;
namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    private static void FillInSubdivisionsSG()
    {
        AddSubdivisions("SG", new List<Subdivision>()
        {
            new()
            { 
                Code = "1",
                Type = "District",
                Name = "Central Singapore",
                LocalName = "Central Singapore"
            },
            new()
            { 
                Code = "2",
                Type = "District",
                Name = "North East",
                LocalName = "North East"
            },
            new()
            { 
                Code = "3",
                Type = "District",
                Name = "North West",
                LocalName = "North West"
            },
            new()
            { 
                Code = "4",
                Type = "District",
                Name = "South East",
                LocalName = "South East"
            },
            new()
            { 
                Code = "5",
                Type = "District",
                Name = "South West",
                LocalName = "South West"
            }

        });
    }
}
