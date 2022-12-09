using AngryMonkey.Cloud.Geography;
namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    private static void FillInSubdivisionsAL()
    {
        AddSubdivisions("AL", new List<Subdivision>()
        {
            new()
            { 
                Code = "1",
                Type = "County",
                Name = "Berat",
                LocalName = "Berat"
            },
            new()
            { 
                Code = "9",
                Type = "County",
                Name = "Dibër",
                LocalName = "Dibër"
            },
            new()
            { 
                Code = "2",
                Type = "County",
                Name = "Durrës",
                LocalName = "Durrës"
            },
            new()
            { 
                Code = "3",
                Type = "County",
                Name = "Elbasan",
                LocalName = "Elbasan"
            },
            new()
            { 
                Code = "4",
                Type = "County",
                Name = "Fier",
                LocalName = "Fier"
            },
            new()
            { 
                Code = "5",
                Type = "County",
                Name = "Gjirokastër",
                LocalName = "Gjirokastër"
            },
            new()
            { 
                Code = "6",
                Type = "County",
                Name = "Korçë",
                LocalName = "Korçë"
            },
            new()
            { 
                Code = "7",
                Type = "County",
                Name = "Kukës",
                LocalName = "Kukës"
            },
            new()
            { 
                Code = "8",
                Type = "County",
                Name = "Lezhë",
                LocalName = "Lezhë"
            },
            new()
            { 
                Code = "10",
                Type = "County",
                Name = "Shkodër",
                LocalName = "Shkodër"
            },
            new()
            { 
                Code = "11",
                Type = "County",
                Name = "Tiranë",
                LocalName = "Tiranë"
            },
            new()
            { 
                Code = "12",
                Type = "County",
                Name = "Vlorë",
                LocalName = "Vlorë"
            }

        });
    }
}
