using AngryMonkey.Cloud.Geography;
namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    private static void FillInSubdivisionsIE()
    {
        AddSubdivisions("IE",
        [
            new()
            { 
                Code = "CW",
                Type = SubdivisionTypes.County,
                Name = "Carlow",
                LocalName = "Carlow"
            },
            new()
            { 
                Code = "CN",
                Type = SubdivisionTypes.County,
                Name = "Cavan",
                LocalName = "Cavan"
            },
            new()
            { 
                Code = "CE",
                Type = SubdivisionTypes.County,
                Name = "Clare",
                LocalName = "Clare"
            },
            new()
            { 
                Code = "CO",
                Type = SubdivisionTypes.County,
                Name = "Cork",
                LocalName = "Cork"
            },
            new()
            { 
                Code = "DL",
                Type = SubdivisionTypes.County,
                Name = "Donegal",
                LocalName = "Donegal"
            },
            new()
            { 
                Code = "D",
                Type = SubdivisionTypes.County,
                Name = "Dublin",
                LocalName = "Dublin"
            },
            new()
            { 
                Code = "G",
                Type = SubdivisionTypes.County,
                Name = "Galway",
                LocalName = "Galway"
            },
            new()
            { 
                Code = "KY",
                Type = SubdivisionTypes.County,
                Name = "Kerry",
                LocalName = "Kerry"
            },
            new()
            { 
                Code = "KE",
                Type = SubdivisionTypes.County,
                Name = "Kildare",
                LocalName = "Kildare"
            },
            new()
            { 
                Code = "KK",
                Type = SubdivisionTypes.County,
                Name = "Kilkenny",
                LocalName = "Kilkenny"
            },
            new()
            { 
                Code = "LS",
                Type = SubdivisionTypes.County,
                Name = "Laois",
                LocalName = "Laois"
            },
            new()
            { 
                Code = "LM",
                Type = SubdivisionTypes.County,
                Name = "Leitrim",
                LocalName = "Leitrim"
            },
            new()
            { 
                Code = "LK",
                Type = SubdivisionTypes.County,
                Name = "Limerick",
                LocalName = "Limerick"
            },
            new()
            { 
                Code = "LD",
                Type = SubdivisionTypes.County,
                Name = "Longford",
                LocalName = "Longford"
            },
            new()
            { 
                Code = "LH",
                Type = SubdivisionTypes.County,
                Name = "Louth",
                LocalName = "Louth"
            },
            new()
            { 
                Code = "MO",
                Type = SubdivisionTypes.County,
                Name = "Mayo",
                LocalName = "Mayo"
            },
            new()
            { 
                Code = "MH",
                Type = SubdivisionTypes.County,
                Name = "Meath",
                LocalName = "Meath"
            },
            new()
            { 
                Code = "MN",
                Type = SubdivisionTypes.County,
                Name = "Monaghan",
                LocalName = "Monaghan"
            },
            new()
            { 
                Code = "OY",
                Type = SubdivisionTypes.County,
                Name = "Offaly",
                LocalName = "Offaly"
            },
            new()
            { 
                Code = "RN",
                Type = SubdivisionTypes.County,
                Name = "Roscommon",
                LocalName = "Roscommon"
            },
            new()
            { 
                Code = "SO",
                Type = SubdivisionTypes.County,
                Name = "Sligo",
                LocalName = "Sligo"
            },
            new()
            { 
                Code = "TA",
                Type = SubdivisionTypes.County,
                Name = "Tipperary",
                LocalName = "Tipperary"
            },
            new()
            { 
                Code = "WD",
                Type = SubdivisionTypes.County,
                Name = "Waterford",
                LocalName = "Waterford"
            },
            new()
            { 
                Code = "WH",
                Type = SubdivisionTypes.County,
                Name = "Westmeath",
                LocalName = "Westmeath"
            },
            new()
            { 
                Code = "WX",
                Type = SubdivisionTypes.County,
                Name = "Wexford",
                LocalName = "Wexford"
            },
            new()
            { 
                Code = "WW",
                Type = SubdivisionTypes.County,
                Name = "Wicklow",
                LocalName = "Wicklow"
            }

        ]);
    }
}
