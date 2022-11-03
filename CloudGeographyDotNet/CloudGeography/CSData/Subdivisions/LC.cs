using AngryMonkey.Cloud.Geography;
namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    private static void FillInSubdivisionsLC()
    {
        AddSubdivisions("LC", new List<Subdivision>()
        {
            new(){ Code ="1", LocalName="Anse la Raye", Name="Anse la Raye", Type="District" },
            new(){ Code ="12", LocalName="Canaries", Name="Canaries", Type="District" },
            new(){ Code ="2", LocalName="Castries", Name="Castries", Type="District" },
            new(){ Code ="3", LocalName="Choiseul", Name="Choiseul", Type="District" },
            new(){ Code ="5", LocalName="Dennery", Name="Dennery", Type="District" },
            new(){ Code ="6", LocalName="Gros Islet", Name="Gros Islet", Type="District" },
            new(){ Code ="7", LocalName="Laborie", Name="Laborie", Type="District" },
            new(){ Code ="8", LocalName="Micoud", Name="Micoud", Type="District" },
            new(){ Code ="10", LocalName="Soufrière", Name="Soufrière", Type="District" },
            new(){ Code ="11", LocalName="Vieux Fort", Name="Vieux Fort", Type="District" }

        });
    }
}
