using AngryMonkey.Cloud.Geography;
namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    private static void FillInSubdivisionsMC()
    {
        AddSubdivisions("MC", new List<Subdivision>()
        {
            new()
            { 
                Code = "FO",
                Type = "Quarter",
                Name = "Fontvieille",
                LocalName = "Fontvieille"
            },
            new()
            { 
                Code = "JE",
                Type = "Quarter",
                Name = "Jardin Exotique",
                LocalName = "Jardin Exotique"
            },
            new()
            { 
                Code = "CL",
                Type = "Quarter",
                Name = "La Colle",
                LocalName = "La Colle"
            },
            new()
            { 
                Code = "CO",
                Type = "Quarter",
                Name = "La Condamine",
                LocalName = "La Condamine"
            },
            new()
            { 
                Code = "GA",
                Type = "Quarter",
                Name = "La Gare",
                LocalName = "La Gare"
            },
            new()
            { 
                Code = "SO",
                Type = "Quarter",
                Name = "La Source",
                LocalName = "La Source"
            },
            new()
            { 
                Code = "LA",
                Type = "Quarter",
                Name = "Larvotto",
                LocalName = "Larvotto"
            },
            new()
            { 
                Code = "MA",
                Type = "Quarter",
                Name = "Malbousquet",
                LocalName = "Malbousquet"
            },
            new()
            { 
                Code = "MO",
                Type = "Quarter",
                Name = "Monaco-Ville",
                LocalName = "Monaco-Ville"
            },
            new()
            { 
                Code = "MG",
                Type = "Quarter",
                Name = "Moneghetti",
                LocalName = "Moneghetti"
            },
            new()
            { 
                Code = "MC",
                Type = "Quarter",
                Name = "Monte-Carlo",
                LocalName = "Monte-Carlo"
            },
            new()
            { 
                Code = "MU",
                Type = "Quarter",
                Name = "Moulins",
                LocalName = "Moulins"
            },
            new()
            { 
                Code = "PH",
                Type = "Quarter",
                Name = "Port-Hercule",
                LocalName = "Port-Hercule"
            },
            new()
            { 
                Code = "SD",
                Type = "Quarter",
                Name = "Sainte-Dévote",
                LocalName = "Sainte-Dévote"
            },
            new()
            { 
                Code = "SR",
                Type = "Quarter",
                Name = "Saint-Roman",
                LocalName = "Saint-Roman"
            },
            new()
            { 
                Code = "SP",
                Type = "Quarter",
                Name = "Spélugues",
                LocalName = "Spélugues"
            },
            new()
            { 
                Code = "VR",
                Type = "Quarter",
                Name = "Vallon de la Rousse",
                LocalName = "Vallon de la Rousse"
            }

        });
    }
}
