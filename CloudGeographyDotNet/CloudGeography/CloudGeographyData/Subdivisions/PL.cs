using AngryMonkey.Cloud.Geography;
namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    private static void FillInSubdivisionsPL()
    {
        AddSubdivisions("PL", new List<Subdivision>()
        {
            new(){ Code ="DS", LocalName="Dolnoslaskie", Name="Dolnoslaskie", Type="Province" },
            new(){ Code ="KP", LocalName="Kujawsko-pomorskie", Name="Kujawsko-pomorskie", Type="Province" },
            new(){ Code ="LD", LocalName="Lódzkie", Name="Lódzkie", Type="Province" },
            new(){ Code ="LU", LocalName="Lubelskie", Name="Lubelskie", Type="Province" },
            new(){ Code ="LB", LocalName="Lubuskie", Name="Lubuskie", Type="Province" },
            new(){ Code ="MA", LocalName="Malopolskie", Name="Malopolskie", Type="Province" },
            new(){ Code ="MZ", LocalName="Mazowieckie", Name="Mazowieckie", Type="Province" },
            new(){ Code ="OP", LocalName="Opolskie", Name="Opolskie", Type="Province" },
            new(){ Code ="PK", LocalName="Podkarpackie", Name="Podkarpackie", Type="Province" },
            new(){ Code ="PD", LocalName="Podlaskie", Name="Podlaskie", Type="Province" },
            new(){ Code ="PM", LocalName="Pomorskie", Name="Pomorskie", Type="Province" },
            new(){ Code ="SL", LocalName="Slaskie", Name="Slaskie", Type="Province" },
            new(){ Code ="SK", LocalName="Swietokrzyskie", Name="Swietokrzyskie", Type="Province" },
            new(){ Code ="WN", LocalName="Warminsko-mazurskie", Name="Warminsko-mazurskie", Type="Province" },
            new(){ Code ="WP", LocalName="Wielkopolskie", Name="Wielkopolskie", Type="Province" },
            new(){ Code ="ZP", LocalName="Zachodniopomorskie", Name="Zachodniopomorskie", Type="Province" }

        });
    }
}
