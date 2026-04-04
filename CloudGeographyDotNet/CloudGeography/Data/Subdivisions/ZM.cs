using AngryMonkey.Cloud.Geography;
namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    private static void FillInSubdivisionsZM()
    {
        AddSubdivisions("ZM",
        [
            new()
            { 
                Code = "2",
                Type = SubdivisionTypes.Province,
                Name = "Central",
                LocalName = "Central"
            },
            new()
            { 
                Code = "8",
                Type = SubdivisionTypes.Province,
                Name = "Copperbelt",
                LocalName = "Copperbelt"
            },
            new()
            { 
                Code = "3",
                Type = SubdivisionTypes.Province,
                Name = "Eastern",
                LocalName = "Eastern"
            },
            new()
            { 
                Code = "4",
                Type = SubdivisionTypes.Province,
                Name = "Luapula",
                LocalName = "Luapula"
            },
            new()
            { 
                Code = "9",
                Type = SubdivisionTypes.Province,
                Name = "Lusaka",
                LocalName = "Lusaka"
            },
            new()
            { 
                Code = "10",
                Type = SubdivisionTypes.Province,
                Name = "Muchinga",
                LocalName = "Muchinga"
            },
            new()
            { 
                Code = "5",
                Type = SubdivisionTypes.Province,
                Name = "Northern",
                LocalName = "Northern"
            },
            new()
            { 
                Code = "6",
                Type = SubdivisionTypes.Province,
                Name = "North-Western",
                LocalName = "North-Western"
            },
            new()
            { 
                Code = "7",
                Type = SubdivisionTypes.Province,
                Name = "Southern",
                LocalName = "Southern"
            },
            new()
            { 
                Code = "1",
                Type = SubdivisionTypes.Province,
                Name = "Western",
                LocalName = "Western"
            }

        ]);
    }
}
