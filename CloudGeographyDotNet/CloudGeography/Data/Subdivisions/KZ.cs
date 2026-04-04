using AngryMonkey.Cloud.Geography;
namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    private static void FillInSubdivisionsKZ()
    {
        AddSubdivisions("KZ",
        [
            new()
            { 
                Code = "ALA",
                Type = SubdivisionTypes.City,
                Name = "Almaty",
                LocalName = "Almaty"
            },
            new()
            { 
                Code = "ALM",
                Type = SubdivisionTypes.Region,
                Name = "Almaty oblysy",
                LocalName = "Almaty oblysy"
            },
            new()
            { 
                Code = "AKM",
                Type = SubdivisionTypes.Region,
                Name = "Aqmola oblysy",
                LocalName = "Aqmola oblysy"
            },
            new()
            { 
                Code = "AKT",
                Type = SubdivisionTypes.Region,
                Name = "Aqtöbe oblysy",
                LocalName = "Aqtöbe oblysy"
            },
            new()
            { 
                Code = "AST",
                Type = SubdivisionTypes.City,
                Name = "Astana",
                LocalName = "Astana"
            },
            new()
            { 
                Code = "ATY",
                Type = SubdivisionTypes.Region,
                Name = "Atyrau oblysy",
                LocalName = "Atyrau oblysy"
            },
            new()
            { 
                Code = "ZAP",
                Type = SubdivisionTypes.Region,
                Name = "Batys Qazaqstan oblysy",
                LocalName = "Batys Qazaqstan oblysy"
            },
            new()
            { 
                Code = "BAY",
                Type = SubdivisionTypes.City,
                Name = "Bayqonyr",
                LocalName = "Bayqonyr"
            },
            new()
            { 
                Code = "MAN",
                Type = SubdivisionTypes.Region,
                Name = "Mangghystau oblysy",
                LocalName = "Mangghystau oblysy"
            },
            new()
            { 
                Code = "YUZ",
                Type = SubdivisionTypes.Region,
                Name = "Ongtüstik Qazaqstan oblysy",
                LocalName = "Ongtüstik Qazaqstan oblysy"
            },
            new()
            { 
                Code = "PAV",
                Type = SubdivisionTypes.Region,
                Name = "Pavlodar oblysy",
                LocalName = "Pavlodar oblysy"
            },
            new()
            { 
                Code = "KAR",
                Type = SubdivisionTypes.Region,
                Name = "Qaraghandy oblysy",
                LocalName = "Qaraghandy oblysy"
            },
            new()
            { 
                Code = "KUS",
                Type = SubdivisionTypes.Region,
                Name = "Qostanay oblysy",
                LocalName = "Qostanay oblysy"
            },
            new()
            { 
                Code = "KZY",
                Type = SubdivisionTypes.Region,
                Name = "Qyzylorda oblysy",
                LocalName = "Qyzylorda oblysy"
            },
            new()
            { 
                Code = "VOS",
                Type = SubdivisionTypes.Region,
                Name = "Shyghys Qazaqstan oblysy",
                LocalName = "Shyghys Qazaqstan oblysy"
            },
            new()
            { 
                Code = "SEV",
                Type = SubdivisionTypes.Region,
                Name = "Soltüstik Qazaqstan oblysy",
                LocalName = "Soltüstik Qazaqstan oblysy"
            },
            new()
            { 
                Code = "ZHA",
                Type = SubdivisionTypes.Region,
                Name = "Zhambyl oblysy",
                LocalName = "Zhambyl oblysy"
            }

        ]);
    }
}
