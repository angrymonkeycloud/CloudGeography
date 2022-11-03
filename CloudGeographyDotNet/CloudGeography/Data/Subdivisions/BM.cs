using AngryMonkey.Cloud.Geography;
namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    private static void FillInSubdivisionsBM()
    {
        AddSubdivisions("BM", new List<Subdivision>()
        {
            new()
            { 
                Code = "A",
                Type = "Municipality",
                Name = "City of Hamilton",
                LocalName = "City of Hamilton"
            },
            new()
            { 
                Code = "6",
                Type = "Parish",
                Name = "Devonshire",
                LocalName = "Devonshire"
            },
            new()
            { 
                Code = "8",
                Type = "Parish",
                Name = "Hamilton",
                LocalName = "Hamilton"
            },
            new()
            { 
                Code = "4",
                Type = "Parish",
                Name = "Paget",
                LocalName = "Paget"
            },
            new()
            { 
                Code = "5",
                Type = "Parish",
                Name = "Pembroke",
                LocalName = "Pembroke"
            },
            new()
            { 
                Code = "1",
                Type = "Parish",
                Name = "Sandys",
                LocalName = "Sandys"
            },
            new()
            { 
                Code = "7",
                Type = "Parish",
                Name = "Smith's",
                LocalName = "Smith's"
            },
            new()
            { 
                Code = "2",
                Type = "Parish",
                Name = "Southampton",
                LocalName = "Southampton"
            },
            new()
            { 
                Code = "9",
                Type = "Parish",
                Name = "St George's",
                LocalName = "St George's"
            },
            new()
            { 
                Code = "B",
                Type = "Municipality",
                Name = "Town of St. George",
                LocalName = "Town of St. George"
            },
            new()
            { 
                Code = "3",
                Type = "Parish",
                Name = "Warwick",
                LocalName = "Warwick"
            }

        });
    }
}
