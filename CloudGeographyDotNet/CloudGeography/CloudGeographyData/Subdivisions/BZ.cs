using AngryMonkey.Cloud.Geography;
namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    private static void FillInSubdivisionsBZ()
    {
        AddSubdivisions("BZ", new List<Subdivision>()
        {
            new()
            { 
                Code = "BZ",
                Type = "District",
                Name = "Belize",
                LocalName = "Belize"
            },
            new()
            { 
                Code = "CY",
                Type = "District",
                Name = "Cayo",
                LocalName = "Cayo"
            },
            new()
            { 
                Code = "CZL",
                Type = "District",
                Name = "Corozal",
                LocalName = "Corozal"
            },
            new()
            { 
                Code = "OW",
                Type = "District",
                Name = "Orange Walk",
                LocalName = "Orange Walk"
            },
            new()
            { 
                Code = "SC",
                Type = "District",
                Name = "Stann Creek",
                LocalName = "Stann Creek"
            },
            new()
            { 
                Code = "TOL",
                Type = "District",
                Name = "Toledo",
                LocalName = "Toledo"
            }

        });
    }
}
