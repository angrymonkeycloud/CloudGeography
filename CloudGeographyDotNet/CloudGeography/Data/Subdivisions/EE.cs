using AngryMonkey.Cloud.Geography;
namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    private static void FillInSubdivisionsEE()
    {
        AddSubdivisions("EE", new List<Subdivision>()
        {
            new()
            { 
                Code = "37",
                Type = "County",
                Name = "Harjumaa",
                LocalName = "Harjumaa"
            },
            new()
            { 
                Code = "39",
                Type = "County",
                Name = "Hiiumaa",
                LocalName = "Hiiumaa"
            },
            new()
            { 
                Code = "44",
                Type = "County",
                Name = "Ida-Virumaa",
                LocalName = "Ida-Virumaa"
            },
            new()
            { 
                Code = "51",
                Type = "County",
                Name = "Järvamaa",
                LocalName = "Järvamaa"
            },
            new()
            { 
                Code = "49",
                Type = "County",
                Name = "Jõgevamaa",
                LocalName = "Jõgevamaa"
            },
            new()
            { 
                Code = "57",
                Type = "County",
                Name = "Läänemaa",
                LocalName = "Läänemaa"
            },
            new()
            { 
                Code = "59",
                Type = "County",
                Name = "Lääne-Virumaa",
                LocalName = "Lääne-Virumaa"
            },
            new()
            { 
                Code = "67",
                Type = "County",
                Name = "Pärnumaa",
                LocalName = "Pärnumaa"
            },
            new()
            { 
                Code = "65",
                Type = "County",
                Name = "Põlvamaa",
                LocalName = "Põlvamaa"
            },
            new()
            { 
                Code = "70",
                Type = "County",
                Name = "Raplamaa",
                LocalName = "Raplamaa"
            },
            new()
            { 
                Code = "74",
                Type = "County",
                Name = "Saaremaa",
                LocalName = "Saaremaa"
            },
            new()
            { 
                Code = "78",
                Type = "County",
                Name = "Tartumaa",
                LocalName = "Tartumaa"
            },
            new()
            { 
                Code = "82",
                Type = "County",
                Name = "Valgamaa",
                LocalName = "Valgamaa"
            },
            new()
            { 
                Code = "84",
                Type = "County",
                Name = "Viljandimaa",
                LocalName = "Viljandimaa"
            },
            new()
            { 
                Code = "86",
                Type = "County",
                Name = "Võrumaa",
                LocalName = "Võrumaa"
            }

        });
    }
}
