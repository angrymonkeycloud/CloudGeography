using AngryMonkey.Cloud.Geography;
namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    private static void FillInSubdivisionsIE()
    {
        AddSubdivisions("IE", new List<Subdivision>()
        {
            new()
            { 
                Code = "CW",
                Type = "County",
                Name = "Carlow",
                LocalName = "Carlow"
            },
            new()
            { 
                Code = "CN",
                Type = "County",
                Name = "Cavan",
                LocalName = "Cavan"
            },
            new()
            { 
                Code = "CE",
                Type = "County",
                Name = "Clare",
                LocalName = "Clare"
            },
            new()
            { 
                Code = "CO",
                Type = "County",
                Name = "Cork",
                LocalName = "Cork"
            },
            new()
            { 
                Code = "DL",
                Type = "County",
                Name = "Donegal",
                LocalName = "Donegal"
            },
            new()
            { 
                Code = "D",
                Type = "County",
                Name = "Dublin",
                LocalName = "Dublin"
            },
            new()
            { 
                Code = "G",
                Type = "County",
                Name = "Galway",
                LocalName = "Galway"
            },
            new()
            { 
                Code = "KY",
                Type = "County",
                Name = "Kerry",
                LocalName = "Kerry"
            },
            new()
            { 
                Code = "KE",
                Type = "County",
                Name = "Kildare",
                LocalName = "Kildare"
            },
            new()
            { 
                Code = "KK",
                Type = "County",
                Name = "Kilkenny",
                LocalName = "Kilkenny"
            },
            new()
            { 
                Code = "LS",
                Type = "County",
                Name = "Laois",
                LocalName = "Laois"
            },
            new()
            { 
                Code = "LM",
                Type = "County",
                Name = "Leitrim",
                LocalName = "Leitrim"
            },
            new()
            { 
                Code = "LK",
                Type = "County",
                Name = "Limerick",
                LocalName = "Limerick"
            },
            new()
            { 
                Code = "LD",
                Type = "County",
                Name = "Longford",
                LocalName = "Longford"
            },
            new()
            { 
                Code = "LH",
                Type = "County",
                Name = "Louth",
                LocalName = "Louth"
            },
            new()
            { 
                Code = "MO",
                Type = "County",
                Name = "Mayo",
                LocalName = "Mayo"
            },
            new()
            { 
                Code = "MH",
                Type = "County",
                Name = "Meath",
                LocalName = "Meath"
            },
            new()
            { 
                Code = "MN",
                Type = "County",
                Name = "Monaghan",
                LocalName = "Monaghan"
            },
            new()
            { 
                Code = "OY",
                Type = "County",
                Name = "Offaly",
                LocalName = "Offaly"
            },
            new()
            { 
                Code = "RN",
                Type = "County",
                Name = "Roscommon",
                LocalName = "Roscommon"
            },
            new()
            { 
                Code = "SO",
                Type = "County",
                Name = "Sligo",
                LocalName = "Sligo"
            },
            new()
            { 
                Code = "TA",
                Type = "County",
                Name = "Tipperary",
                LocalName = "Tipperary"
            },
            new()
            { 
                Code = "WD",
                Type = "County",
                Name = "Waterford",
                LocalName = "Waterford"
            },
            new()
            { 
                Code = "WH",
                Type = "County",
                Name = "Westmeath",
                LocalName = "Westmeath"
            },
            new()
            { 
                Code = "WX",
                Type = "County",
                Name = "Wexford",
                LocalName = "Wexford"
            },
            new()
            { 
                Code = "WW",
                Type = "County",
                Name = "Wicklow",
                LocalName = "Wicklow"
            }

        });
    }
}
