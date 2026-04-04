using AngryMonkey.Cloud.Geography;
namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    private static void FillInSubdivisionsBZ()
    {
        AddSubdivisions("BZ",
        [
            new()
            { 
                Code = "BZ",
                Type = SubdivisionTypes.District,
                Name = "Belize",
                LocalName = "Belize"
            },
            new()
            { 
                Code = "CY",
                Type = SubdivisionTypes.District,
                Name = "Cayo",
                LocalName = "Cayo"
            },
            new()
            { 
                Code = "CZL",
                Type = SubdivisionTypes.District,
                Name = "Corozal",
                LocalName = "Corozal"
            },
            new()
            { 
                Code = "OW",
                Type = SubdivisionTypes.District,
                Name = "Orange Walk",
                LocalName = "Orange Walk"
            },
            new()
            { 
                Code = "SC",
                Type = SubdivisionTypes.District,
                Name = "Stann Creek",
                LocalName = "Stann Creek"
            },
            new()
            { 
                Code = "TOL",
                Type = SubdivisionTypes.District,
                Name = "Toledo",
                LocalName = "Toledo"
            }

        ]);
    }
}
