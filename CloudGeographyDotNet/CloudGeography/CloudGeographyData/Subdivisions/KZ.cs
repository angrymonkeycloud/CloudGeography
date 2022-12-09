using AngryMonkey.Cloud.Geography;
namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    private static void FillInSubdivisionsKZ()
    {
        AddSubdivisions("KZ", new List<Subdivision>()
        {
            new()
            { 
                Code = "ALA",
                Type = "City",
                Name = "Almaty",
                LocalName = "Almaty"
            },
            new()
            { 
                Code = "ALM",
                Type = "Region",
                Name = "Almaty oblysy",
                LocalName = "Almaty oblysy"
            },
            new()
            { 
                Code = "AKM",
                Type = "Region",
                Name = "Aqmola oblysy",
                LocalName = "Aqmola oblysy"
            },
            new()
            { 
                Code = "AKT",
                Type = "Region",
                Name = "Aqtöbe oblysy",
                LocalName = "Aqtöbe oblysy"
            },
            new()
            { 
                Code = "AST",
                Type = "City",
                Name = "Astana",
                LocalName = "Astana"
            },
            new()
            { 
                Code = "ATY",
                Type = "Region",
                Name = "Atyrau oblysy",
                LocalName = "Atyrau oblysy"
            },
            new()
            { 
                Code = "ZAP",
                Type = "Region",
                Name = "Batys Qazaqstan oblysy",
                LocalName = "Batys Qazaqstan oblysy"
            },
            new()
            { 
                Code = "BAY",
                Type = "City",
                Name = "Bayqonyr",
                LocalName = "Bayqonyr"
            },
            new()
            { 
                Code = "MAN",
                Type = "Region",
                Name = "Mangghystau oblysy",
                LocalName = "Mangghystau oblysy"
            },
            new()
            { 
                Code = "YUZ",
                Type = "Region",
                Name = "Ongtüstik Qazaqstan oblysy",
                LocalName = "Ongtüstik Qazaqstan oblysy"
            },
            new()
            { 
                Code = "PAV",
                Type = "Region",
                Name = "Pavlodar oblysy",
                LocalName = "Pavlodar oblysy"
            },
            new()
            { 
                Code = "KAR",
                Type = "Region",
                Name = "Qaraghandy oblysy",
                LocalName = "Qaraghandy oblysy"
            },
            new()
            { 
                Code = "KUS",
                Type = "Region",
                Name = "Qostanay oblysy",
                LocalName = "Qostanay oblysy"
            },
            new()
            { 
                Code = "KZY",
                Type = "Region",
                Name = "Qyzylorda oblysy",
                LocalName = "Qyzylorda oblysy"
            },
            new()
            { 
                Code = "VOS",
                Type = "Region",
                Name = "Shyghys Qazaqstan oblysy",
                LocalName = "Shyghys Qazaqstan oblysy"
            },
            new()
            { 
                Code = "SEV",
                Type = "Region",
                Name = "Soltüstik Qazaqstan oblysy",
                LocalName = "Soltüstik Qazaqstan oblysy"
            },
            new()
            { 
                Code = "ZHA",
                Type = "Region",
                Name = "Zhambyl oblysy",
                LocalName = "Zhambyl oblysy"
            }

        });
    }
}
