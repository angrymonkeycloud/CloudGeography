using AngryMonkey.Cloud.Geography;
namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    private static void FillInSubdivisionsLU()
    {
        AddSubdivisions("LU", new List<Subdivision>()
        {
            new(){ Code ="CA", LocalName="Capellen", Name="Capellen", Type="Canton" },
            new(){ Code ="CL", LocalName="Clervaux", Name="Clervaux", Type="Canton" },
            new(){ Code ="DI", LocalName="Diekirch", Name="Diekirch", Type="Canton" },
            new(){ Code ="EC", LocalName="Echternach", Name="Echternach", Type="Canton" },
            new(){ Code ="ES", LocalName="Esch-sur-Alzette", Name="Esch-sur-Alzette", Type="Canton" },
            new(){ Code ="GR", LocalName="Gréivemaacher", Name="Gréivemaacher", Type="Canton" },
            new(){ Code ="LU", LocalName="Luxembourg", Name="Luxembourg", Type="Canton" },
            new(){ Code ="ME", LocalName="Mersch", Name="Mersch", Type="Canton" },
            new(){ Code ="RD", LocalName="Redange", Name="Redange", Type="Canton" },
            new(){ Code ="RM", LocalName="Remich", Name="Remich", Type="Canton" },
            new(){ Code ="VD", LocalName="Vianden", Name="Vianden", Type="Canton" },
            new(){ Code ="WI", LocalName="Wiltz", Name="Wiltz", Type="Canton" }

        });
    }
}
