using AngryMonkey.Cloud.Geography;
namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    private static void FillInSubdivisionsPT()
    {
        AddSubdivisions("PT", new List<Subdivision>()
        {
            new(){ Code ="1", LocalName="Aveiro", Name="Aveiro", Type="District" },
            new(){ Code ="2", LocalName="Beja", Name="Beja", Type="District" },
            new(){ Code ="3", LocalName="Braga", Name="Braga", Type="District" },
            new(){ Code ="4", LocalName="Bragança", Name="Bragança", Type="District" },
            new(){ Code ="5", LocalName="Castelo Branco", Name="Castelo Branco", Type="District" },
            new(){ Code ="6", LocalName="Coimbra", Name="Coimbra", Type="District" },
            new(){ Code ="7", LocalName="Évora", Name="Évora", Type="District" },
            new(){ Code ="8", LocalName="Faro", Name="Faro", Type="District" },
            new(){ Code ="9", LocalName="Guarda", Name="Guarda", Type="District" },
            new(){ Code ="10", LocalName="Leiria", Name="Leiria", Type="District" },
            new(){ Code ="11", LocalName="Lisboa", Name="Lisboa", Type="District" },
            new(){ Code ="12", LocalName="Portalegre", Name="Portalegre", Type="District" },
            new(){ Code ="13", LocalName="Porto", Name="Porto", Type="District" },
            new(){ Code ="30", LocalName="Região Autónoma da Madeira", Name="Região Autónoma da Madeira", Type="Region" },
            new(){ Code ="20", LocalName="Região Autónoma dos Açores", Name="Região Autónoma dos Açores", Type="Region" },
            new(){ Code ="14", LocalName="Santarém", Name="Santarém", Type="District" },
            new(){ Code ="15", LocalName="Setúbal", Name="Setúbal", Type="District" },
            new(){ Code ="16", LocalName="Viana do Castelo", Name="Viana do Castelo", Type="District" },
            new(){ Code ="17", LocalName="Vila Real", Name="Vila Real", Type="District" },
            new(){ Code ="18", LocalName="Viseu", Name="Viseu", Type="District" }

        });
    }
}
