using AngryMonkey.Cloud.Geography;
namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    private static void FillInSubdivisionsCL()
    {
        AddSubdivisions("CL", new List<Subdivision>()
        {
            new(){ Code ="AI", LocalName="Aisén del General Carlos Ibañez del Campo", Name="Aisén del General Carlos Ibañez del Campo", Type="Region" },
            new(){ Code ="AN", LocalName="Antofagasta", Name="Antofagasta", Type="Region" },
            new(){ Code ="AP", LocalName="Arica y Parinacota", Name="Arica y Parinacota", Type="Region" },
            new(){ Code ="AT", LocalName="Atacama", Name="Atacama", Type="Region" },
            new(){ Code ="BI", LocalName="Biobío", Name="Biobío", Type="Region" },
            new(){ Code ="CO", LocalName="Coquimbo", Name="Coquimbo", Type="Region" },
            new(){ Code ="AR", LocalName="La Araucanía", Name="La Araucanía", Type="Region" },
            new(){ Code ="LI", LocalName="Libertador General Bernardo O'Higgins", Name="Libertador General Bernardo O'Higgins", Type="Region" },
            new(){ Code ="LL", LocalName="Los Lagos", Name="Los Lagos", Type="Region" },
            new(){ Code ="LR", LocalName="Los Ríos", Name="Los Ríos", Type="Region" },
            new(){ Code ="MA", LocalName="Magallanes", Name="Magallanes", Type="Region" },
            new(){ Code ="ML", LocalName="Maule", Name="Maule", Type="Region" },
            new(){ Code ="RM", LocalName="Región Metropolitana de Santiago", Name="Región Metropolitana de Santiago", Type="Region" },
            new(){ Code ="TA", LocalName="Tarapacá", Name="Tarapacá", Type="Region" },
            new(){ Code ="VS", LocalName="Valparaíso", Name="Valparaíso", Type="Region" }

        });
    }
}
