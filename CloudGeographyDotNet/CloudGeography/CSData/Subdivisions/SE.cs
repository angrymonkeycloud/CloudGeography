using AngryMonkey.Cloud.Geography;
namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    private static void FillInSubdivisionsSE()
    {
        AddSubdivisions("SE", new List<Subdivision>()
        {
            new(){ Code ="K", LocalName="Blekinge län", Name="Blekinge län", Type="County" },
            new(){ Code ="W", LocalName="Dalarnes län", Name="Dalarnes län", Type="County" },
            new(){ Code ="X", LocalName="Gävleborgs län", Name="Gävleborgs län", Type="County" },
            new(){ Code ="I", LocalName="Gotlands län", Name="Gotlands län", Type="County" },
            new(){ Code ="N", LocalName="Hallands län", Name="Hallands län", Type="County" },
            new(){ Code ="Z", LocalName="Jämtlands län", Name="Jämtlands län", Type="County" },
            new(){ Code ="F", LocalName="Jönköpings län", Name="Jönköpings län", Type="County" },
            new(){ Code ="H", LocalName="Kalmar län", Name="Kalmar län", Type="County" },
            new(){ Code ="G", LocalName="Kronoborgs län", Name="Kronoborgs län", Type="County" },
            new(){ Code ="BD", LocalName="Norrbottens län", Name="Norrbottens län", Type="County" },
            new(){ Code ="T", LocalName="Örebro län", Name="Örebro län", Type="County" },
            new(){ Code ="E", LocalName="Östergötlands län", Name="Östergötlands län", Type="County" },
            new(){ Code ="M", LocalName="Skåne län", Name="Skåne län", Type="County" },
            new(){ Code ="D", LocalName="Södermanlands län", Name="Södermanlands län", Type="County" },
            new(){ Code ="AB", LocalName="Stockholms län", Name="Stockholms län", Type="County" },
            new(){ Code ="C", LocalName="Uppsala län", Name="Uppsala län", Type="County" },
            new(){ Code ="S", LocalName="Värmlands län", Name="Värmlands län", Type="County" },
            new(){ Code ="AC", LocalName="Västerbottens län", Name="Västerbottens län", Type="County" },
            new(){ Code ="Y", LocalName="Västernorrlands län", Name="Västernorrlands län", Type="County" },
            new(){ Code ="U", LocalName="Västmanlands län", Name="Västmanlands län", Type="County" },
            new(){ Code ="O", LocalName="Västra Götalands län", Name="Västra Götalands län", Type="County" }

        });
    }
}
