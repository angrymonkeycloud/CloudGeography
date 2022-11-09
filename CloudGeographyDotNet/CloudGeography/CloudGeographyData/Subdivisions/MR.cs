using AngryMonkey.Cloud.Geography;
namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    private static void FillInSubdivisionsMR()
    {
        AddSubdivisions("MR", new List<Subdivision>()
        {
            new()
            { 
                Code = "7",
                Type = "Region",
                Name = "Adrar",
                LocalName = "Adrar"
            },
            new()
            { 
                Code = "3",
                Type = "Region",
                Name = "Assaba",
                LocalName = "Assaba"
            },
            new()
            { 
                Code = "5",
                Type = "Region",
                Name = "Brakna",
                LocalName = "Brakna"
            },
            new()
            { 
                Code = "8",
                Type = "Region",
                Name = "Dakhlet Nouâdhibou",
                LocalName = "Dakhlet Nouâdhibou"
            },
            new()
            { 
                Code = "4",
                Type = "Region",
                Name = "Gorgol",
                LocalName = "Gorgol"
            },
            new()
            { 
                Code = "10",
                Type = "Region",
                Name = "Guidimaka",
                LocalName = "Guidimaka"
            },
            new()
            { 
                Code = "1",
                Type = "Region",
                Name = "Hodh ech Chargui",
                LocalName = "Hodh ech Chargui"
            },
            new()
            { 
                Code = "2",
                Type = "Region",
                Name = "Hodh el Gharbi",
                LocalName = "Hodh el Gharbi"
            },
            new()
            { 
                Code = "12",
                Type = "Region",
                Name = "Inchiri",
                LocalName = "Inchiri"
            },
            new()
            { 
                Code = "14",
                Type = "Region",
                Name = "Nouakchott Nord",
                LocalName = "Nouakchott Nord"
            },
            new()
            { 
                Code = "13",
                Type = "Region",
                Name = "Nouakchott Ouest",
                LocalName = "Nouakchott Ouest"
            },
            new()
            { 
                Code = "15",
                Type = "Region",
                Name = "Nouakchott Sud",
                LocalName = "Nouakchott Sud"
            },
            new()
            { 
                Code = "9",
                Type = "Region",
                Name = "Tagant",
                LocalName = "Tagant"
            },
            new()
            { 
                Code = "11",
                Type = "Region",
                Name = "Tiris Zemmour",
                LocalName = "Tiris Zemmour"
            },
            new()
            { 
                Code = "6",
                Type = "Region",
                Name = "Trarza",
                LocalName = "Trarza"
            }

        });
    }
}
