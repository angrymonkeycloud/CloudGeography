using AngryMonkey.Cloud.Geography;
namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    private static void FillInSubdivisionsBM()
    {
        AddSubdivisions("BM",
        [
            new()
            { 
                Code = "A",
                Type = SubdivisionTypes.Municipality,
                Name = "City of Hamilton",
                LocalName = "City of Hamilton"
            },
            new()
            { 
                Code = "6",
                Type = SubdivisionTypes.Parish,
                Name = "Devonshire",
                LocalName = "Devonshire"
            },
            new()
            { 
                Code = "8",
                Type = SubdivisionTypes.Parish,
                Name = "Hamilton",
                LocalName = "Hamilton"
            },
            new()
            { 
                Code = "4",
                Type = SubdivisionTypes.Parish,
                Name = "Paget",
                LocalName = "Paget"
            },
            new()
            { 
                Code = "5",
                Type = SubdivisionTypes.Parish,
                Name = "Pembroke",
                LocalName = "Pembroke"
            },
            new()
            { 
                Code = "1",
                Type = SubdivisionTypes.Parish,
                Name = "Sandys",
                LocalName = "Sandys"
            },
            new()
            { 
                Code = "7",
                Type = SubdivisionTypes.Parish,
                Name = "Smith's",
                LocalName = "Smith's"
            },
            new()
            { 
                Code = "2",
                Type = SubdivisionTypes.Parish,
                Name = "Southampton",
                LocalName = "Southampton"
            },
            new()
            { 
                Code = "9",
                Type = SubdivisionTypes.Parish,
                Name = "St George's",
                LocalName = "St George's"
            },
            new()
            { 
                Code = "B",
                Type = SubdivisionTypes.Municipality,
                Name = "Town of St. George",
                LocalName = "Town of St. George"
            },
            new()
            { 
                Code = "3",
                Type = SubdivisionTypes.Parish,
                Name = "Warwick",
                LocalName = "Warwick"
            }

        ]);
    }
}
