using AngryMonkey.Cloud.Geography;
namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    private static void FillInSubdivisionsFJ()
    {
        AddSubdivisions("FJ", new List<Subdivision>()
        {
            new()
            { 
                Code = "1",
                Type = "Province",
                Name = "Ba",
                LocalName = "Ba"
            },
            new()
            { 
                Code = "2",
                Type = "Province",
                Name = "Bua",
                LocalName = "Bua"
            },
            new()
            { 
                Code = "3",
                Type = "Province",
                Name = "Cakaudrove",
                LocalName = "Cakaudrove"
            },
            new()
            { 
                Code = "4",
                Type = "Province",
                Name = "Kadavu",
                LocalName = "Kadavu"
            },
            new()
            { 
                Code = "5",
                Type = "Province",
                Name = "Lau",
                LocalName = "Lau"
            },
            new()
            { 
                Code = "6",
                Type = "Province",
                Name = "Lomaiviti",
                LocalName = "Lomaiviti"
            },
            new()
            { 
                Code = "7",
                Type = "Province",
                Name = "Macuata",
                LocalName = "Macuata"
            },
            new()
            { 
                Code = "8",
                Type = "Province",
                Name = "Nadroga and Navosa",
                LocalName = "Nadroga and Navosa"
            },
            new()
            { 
                Code = "9",
                Type = "Province",
                Name = "Naitasiri",
                LocalName = "Naitasiri"
            },
            new()
            { 
                Code = "10",
                Type = "Province",
                Name = "Namosi",
                LocalName = "Namosi"
            },
            new()
            { 
                Code = "11",
                Type = "Province",
                Name = "Ra",
                LocalName = "Ra"
            },
            new()
            { 
                Code = "12",
                Type = "Province",
                Name = "Rewa",
                LocalName = "Rewa"
            },
            new()
            { 
                Code = "R",
                Type = "Dependency",
                Name = "Rotuma",
                LocalName = "Rotuma"
            },
            new()
            { 
                Code = "13",
                Type = "Province",
                Name = "Serua",
                LocalName = "Serua"
            },
            new()
            { 
                Code = "14",
                Type = "Province",
                Name = "Tailevu",
                LocalName = "Tailevu"
            }

        });
    }
}
