using AngryMonkey.Cloud.Geography;
namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    private static void FillInSubdivisionsDE()
    {
        AddSubdivisions("DE", new List<Subdivision>()
        {
            new(){ Code ="BW", LocalName="Baden-Württemberg", Name="Baden-Württemberg", Type="Land" },
            new(){ Code ="BY", LocalName="Bayern", Name="Bayern", Type="Land" },
            new(){ Code ="BE", LocalName="Berlin", Name="Berlin", Type="Land" },
            new(){ Code ="BB", LocalName="Brandenburg", Name="Brandenburg", Type="Land" },
            new(){ Code ="HB", LocalName="Bremen", Name="Bremen", Type="Land" },
            new(){ Code ="HH", LocalName="Hamburg", Name="Hamburg", Type="Land" },
            new(){ Code ="HE", LocalName="Hessen", Name="Hessen", Type="Land" },
            new(){ Code ="MV", LocalName="Mecklenburg-Vorpommern", Name="Mecklenburg-Vorpommern", Type="Land" },
            new(){ Code ="NI", LocalName="Niedersachsen", Name="Niedersachsen", Type="Land" },
            new(){ Code ="NW", LocalName="Nordrhein-Westfalen", Name="Nordrhein-Westfalen", Type="Land" },
            new(){ Code ="RP", LocalName="Rheinland-Pfalz", Name="Rheinland-Pfalz", Type="Land" },
            new(){ Code ="SL", LocalName="Saarland", Name="Saarland", Type="Land" },
            new(){ Code ="SN", LocalName="Sachsen", Name="Sachsen", Type="Land" },
            new(){ Code ="ST", LocalName="Sachsen-Anhalt", Name="Sachsen-Anhalt", Type="Land" },
            new(){ Code ="SH", LocalName="Schleswig-Holstein", Name="Schleswig-Holstein", Type="Land" },
            new(){ Code ="TH", LocalName="Thüringen", Name="Thüringen", Type="Land" }

        });
    }
}
