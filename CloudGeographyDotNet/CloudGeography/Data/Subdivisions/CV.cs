using AngryMonkey.Cloud.Geography;
namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    private static void FillInSubdivisionsCV()
    {
        AddSubdivisions("CV", new List<Subdivision>()
        {
            new()
            { 
                Code = "BV",
                Type = "Municipality",
                Name = "Boa Vista",
                LocalName = "Boa Vista"
            },
            new()
            { 
                Code = "BR",
                Type = "Municipality",
                Name = "Brava",
                LocalName = "Brava"
            },
            new()
            { 
                Code = "MA",
                Type = "Municipality",
                Name = "Maio",
                LocalName = "Maio"
            },
            new()
            { 
                Code = "MO",
                Type = "Municipality",
                Name = "Mosteiros",
                LocalName = "Mosteiros"
            },
            new()
            { 
                Code = "PA",
                Type = "Municipality",
                Name = "Paul",
                LocalName = "Paul"
            },
            new()
            { 
                Code = "PN",
                Type = "Municipality",
                Name = "Porto Novo",
                LocalName = "Porto Novo"
            },
            new()
            { 
                Code = "PR",
                Type = "Municipality",
                Name = "Praia",
                LocalName = "Praia"
            },
            new()
            { 
                Code = "RB",
                Type = "Municipality",
                Name = "Ribeira Brava",
                LocalName = "Ribeira Brava"
            },
            new()
            { 
                Code = "RG",
                Type = "Municipality",
                Name = "Ribeira Grande",
                LocalName = "Ribeira Grande"
            },
            new()
            { 
                Code = "RS",
                Type = "Municipality",
                Name = "Ribeira Grande de Santiago",
                LocalName = "Ribeira Grande de Santiago"
            },
            new()
            { 
                Code = "SL",
                Type = "Municipality",
                Name = "Sal",
                LocalName = "Sal"
            },
            new()
            { 
                Code = "CA",
                Type = "Municipality",
                Name = "Santa Catarina",
                LocalName = "Santa Catarina"
            },
            new()
            { 
                Code = "CF",
                Type = "Municipality",
                Name = "Santa Catarina do Fogo",
                LocalName = "Santa Catarina do Fogo"
            },
            new()
            { 
                Code = "CR",
                Type = "Municipality",
                Name = "Santa Cruz",
                LocalName = "Santa Cruz"
            },
            new()
            { 
                Code = "SD",
                Type = "Municipality",
                Name = "S??o Domingos",
                LocalName = "S??o Domingos"
            },
            new()
            { 
                Code = "SF",
                Type = "Municipality",
                Name = "S??o Filipe",
                LocalName = "S??o Filipe"
            },
            new()
            { 
                Code = "SO",
                Type = "Municipality",
                Name = "S??o Louren??o dos ??rg??os",
                LocalName = "S??o Louren??o dos ??rg??os"
            },
            new()
            { 
                Code = "SM",
                Type = "Municipality",
                Name = "S??o Miguel",
                LocalName = "S??o Miguel"
            },
            new()
            { 
                Code = "SS",
                Type = "Municipality",
                Name = "S??o Salvador do Mundo",
                LocalName = "S??o Salvador do Mundo"
            },
            new()
            { 
                Code = "SV",
                Type = "Municipality",
                Name = "S??o Vicente",
                LocalName = "S??o Vicente"
            },
            new()
            { 
                Code = "TA",
                Type = "Municipality",
                Name = "Tarrafal",
                LocalName = "Tarrafal"
            },
            new()
            { 
                Code = "TS",
                Type = "Municipality",
                Name = "Tarrafal de S??o Nicolau",
                LocalName = "Tarrafal de S??o Nicolau"
            }

        });
    }
}
