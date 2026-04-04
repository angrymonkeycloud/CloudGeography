using AngryMonkey.Cloud.Geography;
namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    private static void FillInSubdivisionsAM()
    {
        AddSubdivisions("AM",
        [
            new()
            { 
                Code = "SH",
                Type = SubdivisionTypes.Province,
                Name = "Shirak",
                LocalName = "Շիրակ"
            },
            new()
            { 
                Code = "AG",
                Type = SubdivisionTypes.Province,
                Name = "Aragatsotn",
                LocalName = "Արագածոտն"
            },
            new()
            { 
                Code = "AR",
                Type = SubdivisionTypes.Province,
                Name = "Ararat",
                LocalName = "Արարատ"
            },
            new()
            { 
                Code = "AV",
                Type = SubdivisionTypes.Province,
                Name = "Armavir",
                LocalName = "Արմավիր"
            },
            new()
            { 
                Code = "GR",
                Type = SubdivisionTypes.Province,
                Name = "Gegharkunik ",
                LocalName = "Գեղարքունիք "
            },
            new()
            { 
                Code = "KT",
                Type = SubdivisionTypes.Province,
                Name = "Kotayk",
                LocalName = "Կոտայք"
            },
            new()
            { 
                Code = "LO",
                Type = SubdivisionTypes.Province,
                Name = "Lori",
                LocalName = "Լոռի"
            },
            new()
            { 
                Code = "SU",
                Type = SubdivisionTypes.Province,
                Name = "Syunik",
                LocalName = "Սյունիք"
            },
            new()
            { 
                Code = "TV",
                Type = SubdivisionTypes.Province,
                Name = "Tavush",
                LocalName = "Տավուշ"
            },
            new()
            { 
                Code = "VD",
                Type = SubdivisionTypes.Province,
                Name = "Vayots Dzor",
                LocalName = "Վայոց Ձոր"
            },
            new()
            { 
                Code = "ER",
                Type = SubdivisionTypes.City,
                Name = "Yerevan",
                LocalName = "Երևան"
            }

        ]);
    }
}
