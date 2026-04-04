using AngryMonkey.Cloud.Geography;
namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    private static void FillInSubdivisionsSC()
    {
        AddSubdivisions("SC",
        [
            new()
            { 
                Code = "1",
                Type = SubdivisionTypes.District,
                Name = "Anse aux Pins",
                LocalName = "Anse aux Pins"
            },
            new()
            { 
                Code = "2",
                Type = SubdivisionTypes.District,
                Name = "Anse Boileau",
                LocalName = "Anse Boileau"
            },
            new()
            { 
                Code = "3",
                Type = SubdivisionTypes.District,
                Name = "Anse Étoile",
                LocalName = "Anse Étoile"
            },
            new()
            { 
                Code = "5",
                Type = SubdivisionTypes.District,
                Name = "Anse Royale",
                LocalName = "Anse Royale"
            },
            new()
            { 
                Code = "4",
                Type = SubdivisionTypes.District,
                Name = "Au Cap",
                LocalName = "Au Cap"
            },
            new()
            { 
                Code = "6",
                Type = SubdivisionTypes.District,
                Name = "Baie Lazare",
                LocalName = "Baie Lazare"
            },
            new()
            { 
                Code = "7",
                Type = SubdivisionTypes.District,
                Name = "Baie Sainte Anne",
                LocalName = "Baie Sainte Anne"
            },
            new()
            { 
                Code = "8",
                Type = SubdivisionTypes.District,
                Name = "Beau Vallon",
                LocalName = "Beau Vallon"
            },
            new()
            { 
                Code = "9",
                Type = SubdivisionTypes.District,
                Name = "Bel Air",
                LocalName = "Bel Air"
            },
            new()
            { 
                Code = "10",
                Type = SubdivisionTypes.District,
                Name = "Bel Ombre",
                LocalName = "Bel Ombre"
            },
            new()
            { 
                Code = "11",
                Type = SubdivisionTypes.District,
                Name = "Cascade",
                LocalName = "Cascade"
            },
            new()
            { 
                Code = "12",
                Type = SubdivisionTypes.District,
                Name = "Glacis",
                LocalName = "Glacis"
            },
            new()
            { 
                Code = "13",
                Type = SubdivisionTypes.District,
                Name = "Grand'Anse Mahé",
                LocalName = "Grand'Anse Mahé"
            },
            new()
            { 
                Code = "14",
                Type = SubdivisionTypes.District,
                Name = "Grand'Anse Praslin",
                LocalName = "Grand'Anse Praslin"
            },
            new()
            { 
                Code = "15",
                Type = SubdivisionTypes.District,
                Name = "La Digue",
                LocalName = "La Digue"
            },
            new()
            { 
                Code = "16",
                Type = SubdivisionTypes.District,
                Name = "La Rivière Anglaise",
                LocalName = "La Rivière Anglaise"
            },
            new()
            { 
                Code = "24",
                Type = SubdivisionTypes.District,
                Name = "Lemamel",
                LocalName = "Lemamel"
            },
            new()
            { 
                Code = "17",
                Type = SubdivisionTypes.District,
                Name = "Mont Buxton",
                LocalName = "Mont Buxton"
            },
            new()
            { 
                Code = "18",
                Type = SubdivisionTypes.District,
                Name = "Mont Fleuri",
                LocalName = "Mont Fleuri"
            },
            new()
            { 
                Code = "19",
                Type = SubdivisionTypes.District,
                Name = "Plaisance",
                LocalName = "Plaisance"
            },
            new()
            { 
                Code = "20",
                Type = SubdivisionTypes.District,
                Name = "Pointe La Rue",
                LocalName = "Pointe La Rue"
            },
            new()
            { 
                Code = "21",
                Type = SubdivisionTypes.District,
                Name = "Port Glaud",
                LocalName = "Port Glaud"
            },
            new()
            { 
                Code = "25",
                Type = SubdivisionTypes.District,
                Name = "Ros Kaiman",
                LocalName = "Ros Kaiman"
            },
            new()
            { 
                Code = "22",
                Type = SubdivisionTypes.District,
                Name = "Saint Louis",
                LocalName = "Saint Louis"
            },
            new()
            { 
                Code = "23",
                Type = SubdivisionTypes.District,
                Name = "Takamaka",
                LocalName = "Takamaka"
            }

        ]);
    }
}
