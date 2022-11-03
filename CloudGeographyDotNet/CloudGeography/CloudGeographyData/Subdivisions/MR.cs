using AngryMonkey.Cloud.Geography;
namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    private static void FillInSubdivisionsMR()
    {
        AddSubdivisions("MR", new List<Subdivision>()
        {
            new(){ Code ="7", LocalName="Adrar", Name="Adrar", Type="Region" },
            new(){ Code ="3", LocalName="Assaba", Name="Assaba", Type="Region" },
            new(){ Code ="5", LocalName="Brakna", Name="Brakna", Type="Region" },
            new(){ Code ="8", LocalName="Dakhlet Nouâdhibou", Name="Dakhlet Nouâdhibou", Type="Region" },
            new(){ Code ="4", LocalName="Gorgol", Name="Gorgol", Type="Region" },
            new(){ Code ="10", LocalName="Guidimaka", Name="Guidimaka", Type="Region" },
            new(){ Code ="1", LocalName="Hodh ech Chargui", Name="Hodh ech Chargui", Type="Region" },
            new(){ Code ="2", LocalName="Hodh el Gharbi", Name="Hodh el Gharbi", Type="Region" },
            new(){ Code ="12", LocalName="Inchiri", Name="Inchiri", Type="Region" },
            new(){ Code ="14", LocalName="Nouakchott Nord", Name="Nouakchott Nord", Type="Region" },
            new(){ Code ="13", LocalName="Nouakchott Ouest", Name="Nouakchott Ouest", Type="Region" },
            new(){ Code ="15", LocalName="Nouakchott Sud", Name="Nouakchott Sud", Type="Region" },
            new(){ Code ="9", LocalName="Tagant", Name="Tagant", Type="Region" },
            new(){ Code ="11", LocalName="Tiris Zemmour", Name="Tiris Zemmour", Type="Region" },
            new(){ Code ="6", LocalName="Trarza", Name="Trarza", Type="Region" }

        });
    }
}
