using AngryMonkey.Cloud.Geography;
namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    private static void FillInSubdivisionsCV()
    {
        AddSubdivisions("CV",
        [
            new()
            { 
                Code = "BV",
                Type = SubdivisionTypes.Municipality,
                Name = "Boa Vista",
                LocalName = "Boa Vista"
            },
            new()
            { 
                Code = "BR",
                Type = SubdivisionTypes.Municipality,
                Name = "Brava",
                LocalName = "Brava"
            },
            new()
            { 
                Code = "MA",
                Type = SubdivisionTypes.Municipality,
                Name = "Maio",
                LocalName = "Maio"
            },
            new()
            { 
                Code = "MO",
                Type = SubdivisionTypes.Municipality,
                Name = "Mosteiros",
                LocalName = "Mosteiros"
            },
            new()
            { 
                Code = "PA",
                Type = SubdivisionTypes.Municipality,
                Name = "Paul",
                LocalName = "Paul"
            },
            new()
            { 
                Code = "PN",
                Type = SubdivisionTypes.Municipality,
                Name = "Porto Novo",
                LocalName = "Porto Novo"
            },
            new()
            { 
                Code = "PR",
                Type = SubdivisionTypes.Municipality,
                Name = "Praia",
                LocalName = "Praia"
            },
            new()
            { 
                Code = "RB",
                Type = SubdivisionTypes.Municipality,
                Name = "Ribeira Brava",
                LocalName = "Ribeira Brava"
            },
            new()
            { 
                Code = "RG",
                Type = SubdivisionTypes.Municipality,
                Name = "Ribeira Grande",
                LocalName = "Ribeira Grande"
            },
            new()
            { 
                Code = "RS",
                Type = SubdivisionTypes.Municipality,
                Name = "Ribeira Grande de Santiago",
                LocalName = "Ribeira Grande de Santiago"
            },
            new()
            { 
                Code = "SL",
                Type = SubdivisionTypes.Municipality,
                Name = "Sal",
                LocalName = "Sal"
            },
            new()
            { 
                Code = "CA",
                Type = SubdivisionTypes.Municipality,
                Name = "Santa Catarina",
                LocalName = "Santa Catarina"
            },
            new()
            { 
                Code = "CF",
                Type = SubdivisionTypes.Municipality,
                Name = "Santa Catarina do Fogo",
                LocalName = "Santa Catarina do Fogo"
            },
            new()
            { 
                Code = "CR",
                Type = SubdivisionTypes.Municipality,
                Name = "Santa Cruz",
                LocalName = "Santa Cruz"
            },
            new()
            { 
                Code = "SD",
                Type = SubdivisionTypes.Municipality,
                Name = "São Domingos",
                LocalName = "São Domingos"
            },
            new()
            { 
                Code = "SF",
                Type = SubdivisionTypes.Municipality,
                Name = "São Filipe",
                LocalName = "São Filipe"
            },
            new()
            { 
                Code = "SO",
                Type = SubdivisionTypes.Municipality,
                Name = "São Lourenço dos Órgãos",
                LocalName = "São Lourenço dos Órgãos"
            },
            new()
            { 
                Code = "SM",
                Type = SubdivisionTypes.Municipality,
                Name = "São Miguel",
                LocalName = "São Miguel"
            },
            new()
            { 
                Code = "SS",
                Type = SubdivisionTypes.Municipality,
                Name = "São Salvador do Mundo",
                LocalName = "São Salvador do Mundo"
            },
            new()
            { 
                Code = "SV",
                Type = SubdivisionTypes.Municipality,
                Name = "São Vicente",
                LocalName = "São Vicente"
            },
            new()
            { 
                Code = "TA",
                Type = SubdivisionTypes.Municipality,
                Name = "Tarrafal",
                LocalName = "Tarrafal"
            },
            new()
            { 
                Code = "TS",
                Type = SubdivisionTypes.Municipality,
                Name = "Tarrafal de São Nicolau",
                LocalName = "Tarrafal de São Nicolau"
            }

        ]);
    }
}
