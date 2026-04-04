using AngryMonkey.Cloud.Geography;
namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    private static void FillInSubdivisionsTT()
    {
        AddSubdivisions("TT",
        [
            new()
            { 
                Code = "ARI",
                Type = SubdivisionTypes.Municipality,
                Name = "Arima",
                LocalName = "Arima"
            },
            new()
            { 
                Code = "CHA",
                Type = SubdivisionTypes.Municipality,
                Name = "Chaguanas",
                LocalName = "Chaguanas"
            },
            new()
            { 
                Code = "CTT",
                Type = SubdivisionTypes.Region,
                Name = "Couva-Tabaquite-Talparo",
                LocalName = "Couva-Tabaquite-Talparo"
            },
            new()
            { 
                Code = "DMN",
                Type = SubdivisionTypes.Region,
                Name = "Diego Martin",
                LocalName = "Diego Martin"
            },
            new()
            { 
                Code = "MRC",
                Type = SubdivisionTypes.Region,
                Name = "Mayaro-Rio Claro",
                LocalName = "Mayaro-Rio Claro"
            },
            new()
            { 
                Code = "PED",
                Type = SubdivisionTypes.Region,
                Name = "Penal-Debe",
                LocalName = "Penal-Debe"
            },
            new()
            { 
                Code = "PTF",
                Type = SubdivisionTypes.Municipality,
                Name = "Point Fortin",
                LocalName = "Point Fortin"
            },
            new()
            { 
                Code = "POS",
                Type = SubdivisionTypes.Municipality,
                Name = "Port of Spain",
                LocalName = "Port of Spain"
            },
            new()
            { 
                Code = "PRT",
                Type = SubdivisionTypes.Region,
                Name = "Princes Town",
                LocalName = "Princes Town"
            },
            new()
            { 
                Code = "SFO",
                Type = SubdivisionTypes.Municipality,
                Name = "San Fernando",
                LocalName = "San Fernando"
            },
            new()
            { 
                Code = "SJL",
                Type = SubdivisionTypes.Region,
                Name = "San Juan-Laventille",
                LocalName = "San Juan-Laventille"
            },
            new()
            { 
                Code = "SGE",
                Type = SubdivisionTypes.Region,
                Name = "Sangre Grande",
                LocalName = "Sangre Grande"
            },
            new()
            { 
                Code = "SIP",
                Type = SubdivisionTypes.Region,
                Name = "Siparia",
                LocalName = "Siparia"
            },
            new()
            { 
                Code = "TOB",
                Type = SubdivisionTypes.Ward,
                Name = "Tobago",
                LocalName = "Tobago"
            },
            new()
            { 
                Code = "TUP",
                Type = SubdivisionTypes.Region,
                Name = "Tunapuna-Piarco",
                LocalName = "Tunapuna-Piarco"
            }

        ]);
    }
}
