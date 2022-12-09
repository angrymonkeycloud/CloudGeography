using AngryMonkey.Cloud.Geography;
namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    private static void FillInSubdivisionsCL()
    {
        AddSubdivisions("CL", new List<Subdivision>()
        {
            new()
            { 
                Code = "AI",
                Type = "Region",
                Name = "Aisén del General Carlos Ibañez del Campo",
                LocalName = "Aisén del General Carlos Ibañez del Campo"
            },
            new()
            { 
                Code = "AN",
                Type = "Region",
                Name = "Antofagasta",
                LocalName = "Antofagasta"
            },
            new()
            { 
                Code = "AP",
                Type = "Region",
                Name = "Arica y Parinacota",
                LocalName = "Arica y Parinacota"
            },
            new()
            { 
                Code = "AT",
                Type = "Region",
                Name = "Atacama",
                LocalName = "Atacama"
            },
            new()
            { 
                Code = "BI",
                Type = "Region",
                Name = "Biobío",
                LocalName = "Biobío"
            },
            new()
            { 
                Code = "CO",
                Type = "Region",
                Name = "Coquimbo",
                LocalName = "Coquimbo"
            },
            new()
            { 
                Code = "AR",
                Type = "Region",
                Name = "La Araucanía",
                LocalName = "La Araucanía"
            },
            new()
            { 
                Code = "LI",
                Type = "Region",
                Name = "Libertador General Bernardo O'Higgins",
                LocalName = "Libertador General Bernardo O'Higgins"
            },
            new()
            { 
                Code = "LL",
                Type = "Region",
                Name = "Los Lagos",
                LocalName = "Los Lagos"
            },
            new()
            { 
                Code = "LR",
                Type = "Region",
                Name = "Los Ríos",
                LocalName = "Los Ríos"
            },
            new()
            { 
                Code = "MA",
                Type = "Region",
                Name = "Magallanes",
                LocalName = "Magallanes"
            },
            new()
            { 
                Code = "ML",
                Type = "Region",
                Name = "Maule",
                LocalName = "Maule"
            },
            new()
            { 
                Code = "RM",
                Type = "Region",
                Name = "Región Metropolitana de Santiago",
                LocalName = "Región Metropolitana de Santiago"
            },
            new()
            { 
                Code = "TA",
                Type = "Region",
                Name = "Tarapacá",
                LocalName = "Tarapacá"
            },
            new()
            { 
                Code = "VS",
                Type = "Region",
                Name = "Valparaíso",
                LocalName = "Valparaíso"
            }

        });
    }
}
