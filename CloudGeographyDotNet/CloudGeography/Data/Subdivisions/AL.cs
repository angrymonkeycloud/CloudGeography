using AngryMonkey.Cloud.Geography;
namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    private static void FillInSubdivisionsAL()
    {
        AddSubdivisions("AL",
        [
            new()
            { 
                Code = "1",
                Type = SubdivisionTypes.County,
                Name = "Berat",
                LocalName = "Berat"
            },
            new()
            { 
                Code = "9",
                Type = SubdivisionTypes.County,
                Name = "Dibër",
                LocalName = "Dibër"
            },
            new()
            { 
                Code = "2",
                Type = SubdivisionTypes.County,
                Name = "Durrës",
                LocalName = "Durrës"
            },
            new()
            { 
                Code = "3",
                Type = SubdivisionTypes.County,
                Name = "Elbasan",
                LocalName = "Elbasan"
            },
            new()
            { 
                Code = "4",
                Type = SubdivisionTypes.County,
                Name = "Fier",
                LocalName = "Fier"
            },
            new()
            { 
                Code = "5",
                Type = SubdivisionTypes.County,
                Name = "Gjirokastër",
                LocalName = "Gjirokastër"
            },
            new()
            { 
                Code = "6",
                Type = SubdivisionTypes.County,
                Name = "Korçë",
                LocalName = "Korçë"
            },
            new()
            { 
                Code = "7",
                Type = SubdivisionTypes.County,
                Name = "Kukës",
                LocalName = "Kukës"
            },
            new()
            { 
                Code = "8",
                Type = SubdivisionTypes.County,
                Name = "Lezhë",
                LocalName = "Lezhë"
            },
            new()
            { 
                Code = "10",
                Type = SubdivisionTypes.County,
                Name = "Shkodër",
                LocalName = "Shkodër"
            },
            new()
            { 
                Code = "11",
                Type = SubdivisionTypes.County,
                Name = "Tiranë",
                LocalName = "Tiranë"
            },
            new()
            { 
                Code = "12",
                Type = SubdivisionTypes.County,
                Name = "Vlorë",
                LocalName = "Vlorë"
            }

        ]);
    }
}
