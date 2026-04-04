using AngryMonkey.Cloud.Geography;
namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    private static void FillInSubdivisionsMC()
    {
        AddSubdivisions("MC",
        [
            new()
            { 
                Code = "FO",
                Type = SubdivisionTypes.Quarter,
                Name = "Fontvieille",
                LocalName = "Fontvieille"
            },
            new()
            { 
                Code = "JE",
                Type = SubdivisionTypes.Quarter,
                Name = "Jardin Exotique",
                LocalName = "Jardin Exotique"
            },
            new()
            { 
                Code = "CL",
                Type = SubdivisionTypes.Quarter,
                Name = "La Colle",
                LocalName = "La Colle"
            },
            new()
            { 
                Code = "CO",
                Type = SubdivisionTypes.Quarter,
                Name = "La Condamine",
                LocalName = "La Condamine"
            },
            new()
            { 
                Code = "GA",
                Type = SubdivisionTypes.Quarter,
                Name = "La Gare",
                LocalName = "La Gare"
            },
            new()
            { 
                Code = "SO",
                Type = SubdivisionTypes.Quarter,
                Name = "La Source",
                LocalName = "La Source"
            },
            new()
            { 
                Code = "LA",
                Type = SubdivisionTypes.Quarter,
                Name = "Larvotto",
                LocalName = "Larvotto"
            },
            new()
            { 
                Code = "MA",
                Type = SubdivisionTypes.Quarter,
                Name = "Malbousquet",
                LocalName = "Malbousquet"
            },
            new()
            { 
                Code = "MO",
                Type = SubdivisionTypes.Quarter,
                Name = "Monaco-Ville",
                LocalName = "Monaco-Ville"
            },
            new()
            { 
                Code = "MG",
                Type = SubdivisionTypes.Quarter,
                Name = "Moneghetti",
                LocalName = "Moneghetti"
            },
            new()
            { 
                Code = "MC",
                Type = SubdivisionTypes.Quarter,
                Name = "Monte-Carlo",
                LocalName = "Monte-Carlo"
            },
            new()
            { 
                Code = "MU",
                Type = SubdivisionTypes.Quarter,
                Name = "Moulins",
                LocalName = "Moulins"
            },
            new()
            { 
                Code = "PH",
                Type = SubdivisionTypes.Quarter,
                Name = "Port-Hercule",
                LocalName = "Port-Hercule"
            },
            new()
            { 
                Code = "SD",
                Type = SubdivisionTypes.Quarter,
                Name = "Sainte-Dévote",
                LocalName = "Sainte-Dévote"
            },
            new()
            { 
                Code = "SR",
                Type = SubdivisionTypes.Quarter,
                Name = "Saint-Roman",
                LocalName = "Saint-Roman"
            },
            new()
            { 
                Code = "SP",
                Type = SubdivisionTypes.Quarter,
                Name = "Spélugues",
                LocalName = "Spélugues"
            },
            new()
            { 
                Code = "VR",
                Type = SubdivisionTypes.Quarter,
                Name = "Vallon de la Rousse",
                LocalName = "Vallon de la Rousse"
            }

        ]);
    }
}
