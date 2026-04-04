using AngryMonkey.Cloud.Geography;
namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    private static void FillInSubdivisionsYE()
    {
        AddSubdivisions("YE",
        [
            new()
            { 
                Code = "HD",
                Type = SubdivisionTypes.Governorate,
                Name = "?a?ramawt",
                LocalName = "?a?ramawt"
            },
            new()
            { 
                Code = "HJ",
                Type = SubdivisionTypes.Governorate,
                Name = "?ajjah",
                LocalName = "?ajjah"
            },
            new()
            { 
                Code = "AD",
                Type = SubdivisionTypes.Governorate,
                Name = "Adan",
                LocalName = "Adan"
            },
            new()
            { 
                Code = "AM",
                Type = SubdivisionTypes.Governorate,
                Name = "Amran",
                LocalName = "Amran"
            },
            new()
            { 
                Code = "DA",
                Type = SubdivisionTypes.Governorate,
                Name = "A? ?ali",
                LocalName = "A? ?ali"
            },
            new()
            { 
                Code = "AB",
                Type = SubdivisionTypes.Governorate,
                Name = "Abyan",
                LocalName = "Abyan"
            },
            new()
            { 
                Code = "HU",
                Type = SubdivisionTypes.Governorate,
                Name = "Al ?udaydah",
                LocalName = "Al ?udaydah"
            },
            new()
            { 
                Code = "BA",
                Type = SubdivisionTypes.Governorate,
                Name = "Al Bay?a",
                LocalName = "Al Bay?a"
            },
            new()
            { 
                Code = "JA",
                Type = SubdivisionTypes.Governorate,
                Name = "Al Jawf",
                LocalName = "Al Jawf"
            },
            new()
            { 
                Code = "MW",
                Type = SubdivisionTypes.Governorate,
                Name = "Al Ma?wit",
                LocalName = "Al Ma?wit"
            },
            new()
            { 
                Code = "MR",
                Type = SubdivisionTypes.Governorate,
                Name = "Al Mahrah",
                LocalName = "Al Mahrah"
            },
            new()
            { 
                Code = "SA",
                Type = SubdivisionTypes.Municipality,
                Name = "Amanat al Asimah",
                LocalName = "Amanat al Asimah"
            },
            new()
            { 
                Code = "SU",
                Type = SubdivisionTypes.Governorate,
                Name = "Arkhabil Suqutrá",
                LocalName = "Arkhabil Suqutrá"
            },
            new()
            { 
                Code = "DH",
                Type = SubdivisionTypes.Governorate,
                Name = "Dhamar",
                LocalName = "Dhamar"
            },
            new()
            { 
                Code = "IB",
                Type = SubdivisionTypes.Governorate,
                Name = "Ibb",
                LocalName = "Ibb"
            },
            new()
            { 
                Code = "LA",
                Type = SubdivisionTypes.Governorate,
                Name = "Lahij",
                LocalName = "Lahij"
            },
            new()
            { 
                Code = "MA",
                Type = SubdivisionTypes.Governorate,
                Name = "Marib",
                LocalName = "Marib"
            },
            new()
            { 
                Code = "RA",
                Type = SubdivisionTypes.Governorate,
                Name = "Raymah",
                LocalName = "Raymah"
            },
            new()
            { 
                Code = "SD",
                Type = SubdivisionTypes.Governorate,
                Name = "Sa'dah",
                LocalName = "Sa'dah"
            },
            new()
            { 
                Code = "SN",
                Type = SubdivisionTypes.Governorate,
                Name = "San?a'",
                LocalName = "San?a'"
            },
            new()
            { 
                Code = "SH",
                Type = SubdivisionTypes.Governorate,
                Name = "Shabwah",
                LocalName = "Shabwah"
            },
            new()
            { 
                Code = "TA",
                Type = SubdivisionTypes.Governorate,
                Name = "Ta'izz",
                LocalName = "Ta'izz"
            }

        ]);
    }
}
