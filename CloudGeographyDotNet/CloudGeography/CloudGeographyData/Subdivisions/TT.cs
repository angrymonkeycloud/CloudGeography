using AngryMonkey.Cloud.Geography;
namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    private static void FillInSubdivisionsTT()
    {
        AddSubdivisions("TT", new List<Subdivision>()
        {
            new()
            { 
                Code = "ARI",
                Type = "Municipality",
                Name = "Arima",
                LocalName = "Arima"
            },
            new()
            { 
                Code = "CHA",
                Type = "Municipality",
                Name = "Chaguanas",
                LocalName = "Chaguanas"
            },
            new()
            { 
                Code = "CTT",
                Type = "Region",
                Name = "Couva-Tabaquite-Talparo",
                LocalName = "Couva-Tabaquite-Talparo"
            },
            new()
            { 
                Code = "DMN",
                Type = "Region",
                Name = "Diego Martin",
                LocalName = "Diego Martin"
            },
            new()
            { 
                Code = "MRC",
                Type = "Region",
                Name = "Mayaro-Rio Claro",
                LocalName = "Mayaro-Rio Claro"
            },
            new()
            { 
                Code = "PED",
                Type = "Region",
                Name = "Penal-Debe",
                LocalName = "Penal-Debe"
            },
            new()
            { 
                Code = "PTF",
                Type = "Municipality",
                Name = "Point Fortin",
                LocalName = "Point Fortin"
            },
            new()
            { 
                Code = "POS",
                Type = "Municipality",
                Name = "Port of Spain",
                LocalName = "Port of Spain"
            },
            new()
            { 
                Code = "PRT",
                Type = "Region",
                Name = "Princes Town",
                LocalName = "Princes Town"
            },
            new()
            { 
                Code = "SFO",
                Type = "Municipality",
                Name = "San Fernando",
                LocalName = "San Fernando"
            },
            new()
            { 
                Code = "SJL",
                Type = "Region",
                Name = "San Juan-Laventille",
                LocalName = "San Juan-Laventille"
            },
            new()
            { 
                Code = "SGE",
                Type = "Region",
                Name = "Sangre Grande",
                LocalName = "Sangre Grande"
            },
            new()
            { 
                Code = "SIP",
                Type = "Region",
                Name = "Siparia",
                LocalName = "Siparia"
            },
            new()
            { 
                Code = "TOB",
                Type = "Ward",
                Name = "Tobago",
                LocalName = "Tobago"
            },
            new()
            { 
                Code = "TUP",
                Type = "Region",
                Name = "Tunapuna-Piarco",
                LocalName = "Tunapuna-Piarco"
            }

        });
    }
}
