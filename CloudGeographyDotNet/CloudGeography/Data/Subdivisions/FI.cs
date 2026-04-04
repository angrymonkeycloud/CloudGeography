using AngryMonkey.Cloud.Geography;
namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    private static void FillInSubdivisionsFI()
    {
        AddSubdivisions("FI",
        [
            new()
            { 
                Code = "1",
                Type = SubdivisionTypes.Region,
                Name = "Ahvenanmaan maakunta",
                LocalName = "Ahvenanmaan maakunta"
            },
            new()
            { 
                Code = "2",
                Type = SubdivisionTypes.Region,
                Name = "Etelä-Karjala",
                LocalName = "Etelä-Karjala"
            },
            new()
            { 
                Code = "3",
                Type = SubdivisionTypes.Region,
                Name = "Etelä-Pohjanmaa",
                LocalName = "Etelä-Pohjanmaa"
            },
            new()
            { 
                Code = "4",
                Type = SubdivisionTypes.Region,
                Name = "Etelä-Savo",
                LocalName = "Etelä-Savo"
            },
            new()
            { 
                Code = "5",
                Type = SubdivisionTypes.Region,
                Name = "Kainuu",
                LocalName = "Kainuu"
            },
            new()
            { 
                Code = "6",
                Type = SubdivisionTypes.Region,
                Name = "Kanta-Häme",
                LocalName = "Kanta-Häme"
            },
            new()
            { 
                Code = "7",
                Type = SubdivisionTypes.Region,
                Name = "Keski-Pohjanmaa",
                LocalName = "Keski-Pohjanmaa"
            },
            new()
            { 
                Code = "8",
                Type = SubdivisionTypes.Region,
                Name = "Keski-Suomi",
                LocalName = "Keski-Suomi"
            },
            new()
            { 
                Code = "9",
                Type = SubdivisionTypes.Region,
                Name = "Kymenlaakso",
                LocalName = "Kymenlaakso"
            },
            new()
            { 
                Code = "10",
                Type = SubdivisionTypes.Region,
                Name = "Lappi",
                LocalName = "Lappi"
            },
            new()
            { 
                Code = "16",
                Type = SubdivisionTypes.Region,
                Name = "Päijät-Häme",
                LocalName = "Päijät-Häme"
            },
            new()
            { 
                Code = "11",
                Type = SubdivisionTypes.Region,
                Name = "Pirkanmaa",
                LocalName = "Pirkanmaa"
            },
            new()
            { 
                Code = "12",
                Type = SubdivisionTypes.Region,
                Name = "Pohjanmaa",
                LocalName = "Pohjanmaa"
            },
            new()
            { 
                Code = "13",
                Type = SubdivisionTypes.Region,
                Name = "Pohjois-Karjala",
                LocalName = "Pohjois-Karjala"
            },
            new()
            { 
                Code = "14",
                Type = SubdivisionTypes.Region,
                Name = "Pohjois-Pohjanmaa",
                LocalName = "Pohjois-Pohjanmaa"
            },
            new()
            { 
                Code = "15",
                Type = SubdivisionTypes.Region,
                Name = "Pohjois-Savo",
                LocalName = "Pohjois-Savo"
            },
            new()
            { 
                Code = "17",
                Type = SubdivisionTypes.Region,
                Name = "Satakunta",
                LocalName = "Satakunta"
            },
            new()
            { 
                Code = "18",
                Type = SubdivisionTypes.Region,
                Name = "Uusimaa",
                LocalName = "Uusimaa"
            },
            new()
            { 
                Code = "19",
                Type = SubdivisionTypes.Region,
                Name = "Varsinais-Suomi",
                LocalName = "Varsinais-Suomi"
            }

        ]);
    }
}
