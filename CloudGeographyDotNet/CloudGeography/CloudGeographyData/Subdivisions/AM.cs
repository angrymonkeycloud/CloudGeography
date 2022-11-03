using AngryMonkey.Cloud.Geography;
namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    private static void FillInSubdivisionsAM()
    {
        AddSubdivisions("AM", new List<Subdivision>()
        {
            new(){ Code ="SH", LocalName="Շիրակ", Name="Shirak", Type="Province" },
            new(){ Code ="AG", LocalName="Արագածոտն", Name="Aragatsotn", Type="Province" },
            new(){ Code ="AR", LocalName="Արարատ", Name="Ararat", Type="Province" },
            new(){ Code ="AV", LocalName="Արմավիր", Name="Armavir", Type="Province" },
            new(){ Code ="GR", LocalName="Գեղարքունիք ", Name="Gegharkunik ", Type="Province" },
            new(){ Code ="KT", LocalName="Կոտայք", Name="Kotayk", Type="Province" },
            new(){ Code ="LO", LocalName="Լոռի", Name="Lori", Type="Province" },
            new(){ Code ="SU", LocalName="Սյունիք", Name="Syunik", Type="Province" },
            new(){ Code ="TV", LocalName="Տավուշ", Name="Tavush", Type="Province" },
            new(){ Code ="VD", LocalName="Վայոց Ձոր", Name="Vayots Dzor", Type="Province" },
            new(){ Code ="ER", LocalName="Երևան", Name="Yerevan", Type="City" }

        });
    }
}
