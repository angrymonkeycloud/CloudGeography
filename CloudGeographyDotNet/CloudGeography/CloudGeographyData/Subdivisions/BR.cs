using AngryMonkey.Cloud.Geography;
namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    private static void FillInSubdivisionsBR()
    {
        AddSubdivisions("BR", new List<Subdivision>()
        {
            new(){ Code ="AC", LocalName="Acre", Name="Acre", Type="State" },
            new(){ Code ="AL", LocalName="Alagoas", Name="Alagoas", Type="State" },
            new(){ Code ="AP", LocalName="Amapá", Name="Amapá", Type="State" },
            new(){ Code ="AM", LocalName="Amazonas", Name="Amazonas", Type="State" },
            new(){ Code ="BA", LocalName="Bahia", Name="Bahia", Type="State" },
            new(){ Code ="CE", LocalName="Ceará", Name="Ceará", Type="State" },
            new(){ Code ="DF", LocalName="Distrito Federal", Name="Distrito Federal", Type="District" },
            new(){ Code ="ES", LocalName="Espírito Santo", Name="Espírito Santo", Type="State" },
            new(){ Code ="GO", LocalName="Goiás", Name="Goiás", Type="State" },
            new(){ Code ="MA", LocalName="Maranhão", Name="Maranhão", Type="State" },
            new(){ Code ="MT", LocalName="Mato Grosso", Name="Mato Grosso", Type="State" },
            new(){ Code ="MS", LocalName="Mato Grosso do Sul", Name="Mato Grosso do Sul", Type="State" },
            new(){ Code ="MG", LocalName="Minas Gerais", Name="Minas Gerais", Type="State" },
            new(){ Code ="PA", LocalName="Pará", Name="Pará", Type="State" },
            new(){ Code ="PB", LocalName="Paraíba", Name="Paraíba", Type="State" },
            new(){ Code ="PR", LocalName="Paraná", Name="Paraná", Type="State" },
            new(){ Code ="PE", LocalName="Pernambuco", Name="Pernambuco", Type="State" },
            new(){ Code ="PI", LocalName="Piauí", Name="Piauí", Type="State" },
            new(){ Code ="RJ", LocalName="Rio de Janeiro", Name="Rio de Janeiro", Type="State" },
            new(){ Code ="RN", LocalName="Rio Grande do Norte", Name="Rio Grande do Norte", Type="State" },
            new(){ Code ="RS", LocalName="Rio Grande do Sul", Name="Rio Grande do Sul", Type="State" },
            new(){ Code ="RO", LocalName="Rondônia", Name="Rondônia", Type="State" },
            new(){ Code ="RR", LocalName="Roraima", Name="Roraima", Type="State" },
            new(){ Code ="SC", LocalName="Santa Catarina", Name="Santa Catarina", Type="State" },
            new(){ Code ="SP", LocalName="São Paulo", Name="São Paulo", Type="State" },
            new(){ Code ="SE", LocalName="Sergipe", Name="Sergipe", Type="State" },
            new(){ Code ="TO", LocalName="Tocantins", Name="Tocantins", Type="State" }

        });
    }
}
