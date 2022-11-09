using AngryMonkey.Cloud.Geography;
namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    private static void FillInSubdivisionsZM()
    {
        AddSubdivisions("ZM", new List<Subdivision>()
        {
            new()
            { 
                Code = "2",
                Type = "Province",
                Name = "Central",
                LocalName = "Central"
            },
            new()
            { 
                Code = "8",
                Type = "Province",
                Name = "Copperbelt",
                LocalName = "Copperbelt"
            },
            new()
            { 
                Code = "3",
                Type = "Province",
                Name = "Eastern",
                LocalName = "Eastern"
            },
            new()
            { 
                Code = "4",
                Type = "Province",
                Name = "Luapula",
                LocalName = "Luapula"
            },
            new()
            { 
                Code = "9",
                Type = "Province",
                Name = "Lusaka",
                LocalName = "Lusaka"
            },
            new()
            { 
                Code = "10",
                Type = "Province",
                Name = "Muchinga",
                LocalName = "Muchinga"
            },
            new()
            { 
                Code = "5",
                Type = "Province",
                Name = "Northern",
                LocalName = "Northern"
            },
            new()
            { 
                Code = "6",
                Type = "Province",
                Name = "North-Western",
                LocalName = "North-Western"
            },
            new()
            { 
                Code = "7",
                Type = "Province",
                Name = "Southern",
                LocalName = "Southern"
            },
            new()
            { 
                Code = "1",
                Type = "Province",
                Name = "Western",
                LocalName = "Western"
            }

        });
    }
}
