using AngryMonkey.Cloud.Geography;
namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    private static void FillInSubdivisionsAM()
    {
        AddSubdivisions("AM", new List<Subdivision>()
        {
            new()
            { 
                Code = "SH",
                Type = "Province",
                Name = "Shirak",
                LocalName = "Շիրակ"
            },
            new()
            { 
                Code = "AG",
                Type = "Province",
                Name = "Aragatsotn",
                LocalName = "Արագածոտն"
            },
            new()
            { 
                Code = "AR",
                Type = "Province",
                Name = "Ararat",
                LocalName = "Արարատ"
            },
            new()
            { 
                Code = "AV",
                Type = "Province",
                Name = "Armavir",
                LocalName = "Արմավիր"
            },
            new()
            { 
                Code = "GR",
                Type = "Province",
                Name = "Gegharkunik ",
                LocalName = "Գեղարքունիք "
            },
            new()
            { 
                Code = "KT",
                Type = "Province",
                Name = "Kotayk",
                LocalName = "Կոտայք"
            },
            new()
            { 
                Code = "LO",
                Type = "Province",
                Name = "Lori",
                LocalName = "Լոռի"
            },
            new()
            { 
                Code = "SU",
                Type = "Province",
                Name = "Syunik",
                LocalName = "Սյունիք"
            },
            new()
            { 
                Code = "TV",
                Type = "Province",
                Name = "Tavush",
                LocalName = "Տավուշ"
            },
            new()
            { 
                Code = "VD",
                Type = "Province",
                Name = "Vayots Dzor",
                LocalName = "Վայոց Ձոր"
            },
            new()
            { 
                Code = "ER",
                Type = "City",
                Name = "Yerevan",
                LocalName = "Երևան"
            }

        });
    }
}
