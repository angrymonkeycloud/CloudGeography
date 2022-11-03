using AngryMonkey.Cloud.Geography;
namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    private static void FillInSubdivisionsKZ()
    {
        AddSubdivisions("KZ", new List<Subdivision>()
        {
            new(){ Code ="ALA", LocalName="Almaty", Name="Almaty", Type="City" },
            new(){ Code ="ALM", LocalName="Almaty oblysy", Name="Almaty oblysy", Type="Region" },
            new(){ Code ="AKM", LocalName="Aqmola oblysy", Name="Aqmola oblysy", Type="Region" },
            new(){ Code ="AKT", LocalName="Aqtöbe oblysy", Name="Aqtöbe oblysy", Type="Region" },
            new(){ Code ="AST", LocalName="Astana", Name="Astana", Type="City" },
            new(){ Code ="ATY", LocalName="Atyrau oblysy", Name="Atyrau oblysy", Type="Region" },
            new(){ Code ="ZAP", LocalName="Batys Qazaqstan oblysy", Name="Batys Qazaqstan oblysy", Type="Region" },
            new(){ Code ="BAY", LocalName="Bayqonyr", Name="Bayqonyr", Type="City" },
            new(){ Code ="MAN", LocalName="Mangghystau oblysy", Name="Mangghystau oblysy", Type="Region" },
            new(){ Code ="YUZ", LocalName="Ongtüstik Qazaqstan oblysy", Name="Ongtüstik Qazaqstan oblysy", Type="Region" },
            new(){ Code ="PAV", LocalName="Pavlodar oblysy", Name="Pavlodar oblysy", Type="Region" },
            new(){ Code ="KAR", LocalName="Qaraghandy oblysy", Name="Qaraghandy oblysy", Type="Region" },
            new(){ Code ="KUS", LocalName="Qostanay oblysy", Name="Qostanay oblysy", Type="Region" },
            new(){ Code ="KZY", LocalName="Qyzylorda oblysy", Name="Qyzylorda oblysy", Type="Region" },
            new(){ Code ="VOS", LocalName="Shyghys Qazaqstan oblysy", Name="Shyghys Qazaqstan oblysy", Type="Region" },
            new(){ Code ="SEV", LocalName="Soltüstik Qazaqstan oblysy", Name="Soltüstik Qazaqstan oblysy", Type="Region" },
            new(){ Code ="ZHA", LocalName="Zhambyl oblysy", Name="Zhambyl oblysy", Type="Region" }

        });
    }
}
