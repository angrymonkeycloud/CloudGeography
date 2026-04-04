using AngryMonkey.Cloud.Geography;
namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    private static void FillInSubdivisionsMR()
    {
        AddSubdivisions("MR",
        [
            new()
            { 
                Code = "7",
                Type = SubdivisionTypes.Region,
                Name = "Adrar",
                LocalName = "Adrar"
            },
            new()
            { 
                Code = "3",
                Type = SubdivisionTypes.Region,
                Name = "Assaba",
                LocalName = "Assaba"
            },
            new()
            { 
                Code = "5",
                Type = SubdivisionTypes.Region,
                Name = "Brakna",
                LocalName = "Brakna"
            },
            new()
            { 
                Code = "8",
                Type = SubdivisionTypes.Region,
                Name = "Dakhlet Nouâdhibou",
                LocalName = "Dakhlet Nouâdhibou"
            },
            new()
            { 
                Code = "4",
                Type = SubdivisionTypes.Region,
                Name = "Gorgol",
                LocalName = "Gorgol"
            },
            new()
            { 
                Code = "10",
                Type = SubdivisionTypes.Region,
                Name = "Guidimaka",
                LocalName = "Guidimaka"
            },
            new()
            { 
                Code = "1",
                Type = SubdivisionTypes.Region,
                Name = "Hodh ech Chargui",
                LocalName = "Hodh ech Chargui"
            },
            new()
            { 
                Code = "2",
                Type = SubdivisionTypes.Region,
                Name = "Hodh el Gharbi",
                LocalName = "Hodh el Gharbi"
            },
            new()
            { 
                Code = "12",
                Type = SubdivisionTypes.Region,
                Name = "Inchiri",
                LocalName = "Inchiri"
            },
            new()
            { 
                Code = "14",
                Type = SubdivisionTypes.Region,
                Name = "Nouakchott Nord",
                LocalName = "Nouakchott Nord"
            },
            new()
            { 
                Code = "13",
                Type = SubdivisionTypes.Region,
                Name = "Nouakchott Ouest",
                LocalName = "Nouakchott Ouest"
            },
            new()
            { 
                Code = "15",
                Type = SubdivisionTypes.Region,
                Name = "Nouakchott Sud",
                LocalName = "Nouakchott Sud"
            },
            new()
            { 
                Code = "9",
                Type = SubdivisionTypes.Region,
                Name = "Tagant",
                LocalName = "Tagant"
            },
            new()
            { 
                Code = "11",
                Type = SubdivisionTypes.Region,
                Name = "Tiris Zemmour",
                LocalName = "Tiris Zemmour"
            },
            new()
            { 
                Code = "6",
                Type = SubdivisionTypes.Region,
                Name = "Trarza",
                LocalName = "Trarza"
            }

        ]);
    }
}
