using AngryMonkey.Cloud.Geography;
namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    private static void FillInSubdivisionsCD()
    {
        AddSubdivisions("CD", new List<Subdivision>()
        {
            new(){ Code ="BU", LocalName="Bas-Uélé", Name="Bas-Uélé", Type="Province" },
            new(){ Code ="EQ", LocalName="Équateur", Name="Équateur", Type="Province" },
            new(){ Code ="HK", LocalName="Haut-Katanga", Name="Haut-Katanga", Type="Province" },
            new(){ Code ="HL", LocalName="Haut-Lomami", Name="Haut-Lomami", Type="Province" },
            new(){ Code ="HU", LocalName="Haut-Uélé", Name="Haut-Uélé", Type="Province" },
            new(){ Code ="IT", LocalName="Ituri", Name="Ituri", Type="Province" },
            new(){ Code ="KS", LocalName="Kasaï", Name="Kasaï", Type="Province" },
            new(){ Code ="KC", LocalName="Kasaï Central", Name="Kasaï Central", Type="Province" },
            new(){ Code ="KE", LocalName="Kasaï Oriental", Name="Kasaï Oriental", Type="Province" },
            new(){ Code ="KN", LocalName="Kinshasa", Name="Kinshasa", Type="City" },
            new(){ Code ="BC", LocalName="Kongo Central", Name="Kongo Central", Type="Province" },
            new(){ Code ="KG", LocalName="Kwango", Name="Kwango", Type="Province" },
            new(){ Code ="KL", LocalName="Kwilu", Name="Kwilu", Type="Province" },
            new(){ Code ="LO", LocalName="Lomami", Name="Lomami", Type="Province" },
            new(){ Code ="LU", LocalName="Lualaba", Name="Lualaba", Type="Province" },
            new(){ Code ="MN", LocalName="Mai-Ndombe", Name="Mai-Ndombe", Type="Province" },
            new(){ Code ="MA", LocalName="Maniema", Name="Maniema", Type="Province" },
            new(){ Code ="MO", LocalName="Mongala", Name="Mongala", Type="Province" },
            new(){ Code ="NK", LocalName="Nord-Kivu", Name="Nord-Kivu", Type="Province" },
            new(){ Code ="NU", LocalName="Nord-Ubangi", Name="Nord-Ubangi", Type="Province" },
            new(){ Code ="SA", LocalName="Sankuru", Name="Sankuru", Type="Province" },
            new(){ Code ="SK", LocalName="Sud-Kivu", Name="Sud-Kivu", Type="Province" },
            new(){ Code ="SU", LocalName="Sud-Ubangi", Name="Sud-Ubangi", Type="Province" },
            new(){ Code ="TA", LocalName="Tanganyika", Name="Tanganyika", Type="Province" },
            new(){ Code ="TO", LocalName="Tshopo", Name="Tshopo", Type="Province" },
            new(){ Code ="TU", LocalName="Tshuapa", Name="Tshuapa", Type="Province" }

        });
    }
}
