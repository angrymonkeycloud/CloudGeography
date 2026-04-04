using AngryMonkey.Cloud.Geography;
namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    private static void FillInSubdivisionsBR()
    {
        AddSubdivisions("BR",
        [
            new()
            { 
                Code = "AC",
                Type = SubdivisionTypes.State,
                Name = "Acre",
                LocalName = "Acre"
            },
            new()
            { 
                Code = "AL",
                Type = SubdivisionTypes.State,
                Name = "Alagoas",
                LocalName = "Alagoas"
            },
            new()
            { 
                Code = "AP",
                Type = SubdivisionTypes.State,
                Name = "Amapá",
                LocalName = "Amapá"
            },
            new()
            { 
                Code = "AM",
                Type = SubdivisionTypes.State,
                Name = "Amazonas",
                LocalName = "Amazonas"
            },
            new()
            { 
                Code = "BA",
                Type = SubdivisionTypes.State,
                Name = "Bahia",
                LocalName = "Bahia"
            },
            new()
            { 
                Code = "CE",
                Type = SubdivisionTypes.State,
                Name = "Ceará",
                LocalName = "Ceará"
            },
            new()
            { 
                Code = "DF",
                Type = SubdivisionTypes.District,
                Name = "Distrito Federal",
                LocalName = "Distrito Federal"
            },
            new()
            { 
                Code = "ES",
                Type = SubdivisionTypes.State,
                Name = "Espírito Santo",
                LocalName = "Espírito Santo"
            },
            new()
            { 
                Code = "GO",
                Type = SubdivisionTypes.State,
                Name = "Goiás",
                LocalName = "Goiás"
            },
            new()
            { 
                Code = "MA",
                Type = SubdivisionTypes.State,
                Name = "Maranhão",
                LocalName = "Maranhão"
            },
            new()
            { 
                Code = "MT",
                Type = SubdivisionTypes.State,
                Name = "Mato Grosso",
                LocalName = "Mato Grosso"
            },
            new()
            { 
                Code = "MS",
                Type = SubdivisionTypes.State,
                Name = "Mato Grosso do Sul",
                LocalName = "Mato Grosso do Sul"
            },
            new()
            { 
                Code = "MG",
                Type = SubdivisionTypes.State,
                Name = "Minas Gerais",
                LocalName = "Minas Gerais"
            },
            new()
            { 
                Code = "PA",
                Type = SubdivisionTypes.State,
                Name = "Pará",
                LocalName = "Pará"
            },
            new()
            { 
                Code = "PB",
                Type = SubdivisionTypes.State,
                Name = "Paraíba",
                LocalName = "Paraíba"
            },
            new()
            { 
                Code = "PR",
                Type = SubdivisionTypes.State,
                Name = "Paraná",
                LocalName = "Paraná"
            },
            new()
            { 
                Code = "PE",
                Type = SubdivisionTypes.State,
                Name = "Pernambuco",
                LocalName = "Pernambuco"
            },
            new()
            { 
                Code = "PI",
                Type = SubdivisionTypes.State,
                Name = "Piauí",
                LocalName = "Piauí"
            },
            new()
            { 
                Code = "RJ",
                Type = SubdivisionTypes.State,
                Name = "Rio de Janeiro",
                LocalName = "Rio de Janeiro"
            },
            new()
            { 
                Code = "RN",
                Type = SubdivisionTypes.State,
                Name = "Rio Grande do Norte",
                LocalName = "Rio Grande do Norte"
            },
            new()
            { 
                Code = "RS",
                Type = SubdivisionTypes.State,
                Name = "Rio Grande do Sul",
                LocalName = "Rio Grande do Sul"
            },
            new()
            { 
                Code = "RO",
                Type = SubdivisionTypes.State,
                Name = "Rondônia",
                LocalName = "Rondônia"
            },
            new()
            { 
                Code = "RR",
                Type = SubdivisionTypes.State,
                Name = "Roraima",
                LocalName = "Roraima"
            },
            new()
            { 
                Code = "SC",
                Type = SubdivisionTypes.State,
                Name = "Santa Catarina",
                LocalName = "Santa Catarina"
            },
            new()
            { 
                Code = "SP",
                Type = SubdivisionTypes.State,
                Name = "São Paulo",
                LocalName = "São Paulo"
            },
            new()
            { 
                Code = "SE",
                Type = SubdivisionTypes.State,
                Name = "Sergipe",
                LocalName = "Sergipe"
            },
            new()
            { 
                Code = "TO",
                Type = SubdivisionTypes.State,
                Name = "Tocantins",
                LocalName = "Tocantins"
            }

        ]);
    }
}
