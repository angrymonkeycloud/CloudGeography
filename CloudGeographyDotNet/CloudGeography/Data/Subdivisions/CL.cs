using AngryMonkey.Cloud.Geography;
namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    private static void FillInSubdivisionsCL()
    {
        AddSubdivisions("CL",
        [
            new()
            { 
                Code = "AI",
                Type = SubdivisionTypes.Region,
                Name = "Aisén del General Carlos Ibañez del Campo",
                LocalName = "Aisén del General Carlos Ibañez del Campo"
            },
            new()
            { 
                Code = "AN",
                Type = SubdivisionTypes.Region,
                Name = "Antofagasta",
                LocalName = "Antofagasta"
            },
            new()
            { 
                Code = "AP",
                Type = SubdivisionTypes.Region,
                Name = "Arica y Parinacota",
                LocalName = "Arica y Parinacota"
            },
            new()
            { 
                Code = "AT",
                Type = SubdivisionTypes.Region,
                Name = "Atacama",
                LocalName = "Atacama"
            },
            new()
            { 
                Code = "BI",
                Type = SubdivisionTypes.Region,
                Name = "Biobío",
                LocalName = "Biobío"
            },
            new()
            { 
                Code = "CO",
                Type = SubdivisionTypes.Region,
                Name = "Coquimbo",
                LocalName = "Coquimbo"
            },
            new()
            { 
                Code = "AR",
                Type = SubdivisionTypes.Region,
                Name = "La Araucanía",
                LocalName = "La Araucanía"
            },
            new()
            { 
                Code = "LI",
                Type = SubdivisionTypes.Region,
                Name = "Libertador General Bernardo O'Higgins",
                LocalName = "Libertador General Bernardo O'Higgins"
            },
            new()
            { 
                Code = "LL",
                Type = SubdivisionTypes.Region,
                Name = "Los Lagos",
                LocalName = "Los Lagos"
            },
            new()
            { 
                Code = "LR",
                Type = SubdivisionTypes.Region,
                Name = "Los Ríos",
                LocalName = "Los Ríos"
            },
            new()
            { 
                Code = "MA",
                Type = SubdivisionTypes.Region,
                Name = "Magallanes",
                LocalName = "Magallanes"
            },
            new()
            { 
                Code = "ML",
                Type = SubdivisionTypes.Region,
                Name = "Maule",
                LocalName = "Maule"
            },
            new()
            { 
                Code = "RM",
                Type = SubdivisionTypes.Region,
                Name = "Región Metropolitana de Santiago",
                LocalName = "Región Metropolitana de Santiago"
            },
            new()
            { 
                Code = "TA",
                Type = SubdivisionTypes.Region,
                Name = "Tarapacá",
                LocalName = "Tarapacá"
            },
            new()
            { 
                Code = "VS",
                Type = SubdivisionTypes.Region,
                Name = "Valparaíso",
                LocalName = "Valparaíso"
            }

        ]);
    }
}
