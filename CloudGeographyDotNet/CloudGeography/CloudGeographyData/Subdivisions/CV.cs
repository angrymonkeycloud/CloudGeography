using AngryMonkey.Cloud.Geography;
namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    private static void FillInSubdivisionsCV()
    {
        AddSubdivisions("CV", new List<Subdivision>()
        {
            new(){ Code ="BV", LocalName="Boa Vista", Name="Boa Vista", Type="Municipality" },
            new(){ Code ="BR", LocalName="Brava", Name="Brava", Type="Municipality" },
            new(){ Code ="MA", LocalName="Maio", Name="Maio", Type="Municipality" },
            new(){ Code ="MO", LocalName="Mosteiros", Name="Mosteiros", Type="Municipality" },
            new(){ Code ="PA", LocalName="Paul", Name="Paul", Type="Municipality" },
            new(){ Code ="PN", LocalName="Porto Novo", Name="Porto Novo", Type="Municipality" },
            new(){ Code ="PR", LocalName="Praia", Name="Praia", Type="Municipality" },
            new(){ Code ="RB", LocalName="Ribeira Brava", Name="Ribeira Brava", Type="Municipality" },
            new(){ Code ="RG", LocalName="Ribeira Grande", Name="Ribeira Grande", Type="Municipality" },
            new(){ Code ="RS", LocalName="Ribeira Grande de Santiago", Name="Ribeira Grande de Santiago", Type="Municipality" },
            new(){ Code ="SL", LocalName="Sal", Name="Sal", Type="Municipality" },
            new(){ Code ="CA", LocalName="Santa Catarina", Name="Santa Catarina", Type="Municipality" },
            new(){ Code ="CF", LocalName="Santa Catarina do Fogo", Name="Santa Catarina do Fogo", Type="Municipality" },
            new(){ Code ="CR", LocalName="Santa Cruz", Name="Santa Cruz", Type="Municipality" },
            new(){ Code ="SD", LocalName="São Domingos", Name="São Domingos", Type="Municipality" },
            new(){ Code ="SF", LocalName="São Filipe", Name="São Filipe", Type="Municipality" },
            new(){ Code ="SO", LocalName="São Lourenço dos Órgãos", Name="São Lourenço dos Órgãos", Type="Municipality" },
            new(){ Code ="SM", LocalName="São Miguel", Name="São Miguel", Type="Municipality" },
            new(){ Code ="SS", LocalName="São Salvador do Mundo", Name="São Salvador do Mundo", Type="Municipality" },
            new(){ Code ="SV", LocalName="São Vicente", Name="São Vicente", Type="Municipality" },
            new(){ Code ="TA", LocalName="Tarrafal", Name="Tarrafal", Type="Municipality" },
            new(){ Code ="TS", LocalName="Tarrafal de São Nicolau", Name="Tarrafal de São Nicolau", Type="Municipality" }

        });
    }
}
