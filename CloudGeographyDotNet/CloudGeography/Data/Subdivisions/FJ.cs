using AngryMonkey.Cloud.Geography;
namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    private static void FillInSubdivisionsFJ()
    {
        AddSubdivisions("FJ",
        [
            new()
            { 
                Code = "1",
                Type = SubdivisionTypes.Province,
                Name = "Ba",
                LocalName = "Ba"
            },
            new()
            { 
                Code = "2",
                Type = SubdivisionTypes.Province,
                Name = "Bua",
                LocalName = "Bua"
            },
            new()
            { 
                Code = "3",
                Type = SubdivisionTypes.Province,
                Name = "Cakaudrove",
                LocalName = "Cakaudrove"
            },
            new()
            { 
                Code = "4",
                Type = SubdivisionTypes.Province,
                Name = "Kadavu",
                LocalName = "Kadavu"
            },
            new()
            { 
                Code = "5",
                Type = SubdivisionTypes.Province,
                Name = "Lau",
                LocalName = "Lau"
            },
            new()
            { 
                Code = "6",
                Type = SubdivisionTypes.Province,
                Name = "Lomaiviti",
                LocalName = "Lomaiviti"
            },
            new()
            { 
                Code = "7",
                Type = SubdivisionTypes.Province,
                Name = "Macuata",
                LocalName = "Macuata"
            },
            new()
            { 
                Code = "8",
                Type = SubdivisionTypes.Province,
                Name = "Nadroga and Navosa",
                LocalName = "Nadroga and Navosa"
            },
            new()
            { 
                Code = "9",
                Type = SubdivisionTypes.Province,
                Name = "Naitasiri",
                LocalName = "Naitasiri"
            },
            new()
            { 
                Code = "10",
                Type = SubdivisionTypes.Province,
                Name = "Namosi",
                LocalName = "Namosi"
            },
            new()
            { 
                Code = "11",
                Type = SubdivisionTypes.Province,
                Name = "Ra",
                LocalName = "Ra"
            },
            new()
            { 
                Code = "12",
                Type = SubdivisionTypes.Province,
                Name = "Rewa",
                LocalName = "Rewa"
            },
            new()
            { 
                Code = "R",
                Type = SubdivisionTypes.Dependency,
                Name = "Rotuma",
                LocalName = "Rotuma"
            },
            new()
            { 
                Code = "13",
                Type = SubdivisionTypes.Province,
                Name = "Serua",
                LocalName = "Serua"
            },
            new()
            { 
                Code = "14",
                Type = SubdivisionTypes.Province,
                Name = "Tailevu",
                LocalName = "Tailevu"
            }

        ]);
    }
}
