using AngryMonkey.Cloud.Geography;
namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    private static void FillInSubdivisionsTT()
    {
        AddSubdivisions("TT", new List<Subdivision>()
        {
            new(){ Code ="ARI", LocalName="Arima", Name="Arima", Type="Municipality" },
            new(){ Code ="CHA", LocalName="Chaguanas", Name="Chaguanas", Type="Municipality" },
            new(){ Code ="CTT", LocalName="Couva-Tabaquite-Talparo", Name="Couva-Tabaquite-Talparo", Type="Region" },
            new(){ Code ="DMN", LocalName="Diego Martin", Name="Diego Martin", Type="Region" },
            new(){ Code ="MRC", LocalName="Mayaro-Rio Claro", Name="Mayaro-Rio Claro", Type="Region" },
            new(){ Code ="PED", LocalName="Penal-Debe", Name="Penal-Debe", Type="Region" },
            new(){ Code ="PTF", LocalName="Point Fortin", Name="Point Fortin", Type="Municipality" },
            new(){ Code ="POS", LocalName="Port of Spain", Name="Port of Spain", Type="Municipality" },
            new(){ Code ="PRT", LocalName="Princes Town", Name="Princes Town", Type="Region" },
            new(){ Code ="SFO", LocalName="San Fernando", Name="San Fernando", Type="Municipality" },
            new(){ Code ="SJL", LocalName="San Juan-Laventille", Name="San Juan-Laventille", Type="Region" },
            new(){ Code ="SGE", LocalName="Sangre Grande", Name="Sangre Grande", Type="Region" },
            new(){ Code ="SIP", LocalName="Siparia", Name="Siparia", Type="Region" },
            new(){ Code ="TOB", LocalName="Tobago", Name="Tobago", Type="Ward" },
            new(){ Code ="TUP", LocalName="Tunapuna-Piarco", Name="Tunapuna-Piarco", Type="Region" }

        });
    }
}
