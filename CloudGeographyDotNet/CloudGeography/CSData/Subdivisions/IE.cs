using AngryMonkey.Cloud.Geography;
namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    private static void FillInSubdivisionsIE()
    {
        AddSubdivisions("IE", new List<Subdivision>()
        {
            new(){ Code ="CW", LocalName="Carlow", Name="Carlow", Type="County" },
            new(){ Code ="CN", LocalName="Cavan", Name="Cavan", Type="County" },
            new(){ Code ="CE", LocalName="Clare", Name="Clare", Type="County" },
            new(){ Code ="CO", LocalName="Cork", Name="Cork", Type="County" },
            new(){ Code ="DL", LocalName="Donegal", Name="Donegal", Type="County" },
            new(){ Code ="D", LocalName="Dublin", Name="Dublin", Type="County" },
            new(){ Code ="G", LocalName="Galway", Name="Galway", Type="County" },
            new(){ Code ="KY", LocalName="Kerry", Name="Kerry", Type="County" },
            new(){ Code ="KE", LocalName="Kildare", Name="Kildare", Type="County" },
            new(){ Code ="KK", LocalName="Kilkenny", Name="Kilkenny", Type="County" },
            new(){ Code ="LS", LocalName="Laois", Name="Laois", Type="County" },
            new(){ Code ="LM", LocalName="Leitrim", Name="Leitrim", Type="County" },
            new(){ Code ="LK", LocalName="Limerick", Name="Limerick", Type="County" },
            new(){ Code ="LD", LocalName="Longford", Name="Longford", Type="County" },
            new(){ Code ="LH", LocalName="Louth", Name="Louth", Type="County" },
            new(){ Code ="MO", LocalName="Mayo", Name="Mayo", Type="County" },
            new(){ Code ="MH", LocalName="Meath", Name="Meath", Type="County" },
            new(){ Code ="MN", LocalName="Monaghan", Name="Monaghan", Type="County" },
            new(){ Code ="OY", LocalName="Offaly", Name="Offaly", Type="County" },
            new(){ Code ="RN", LocalName="Roscommon", Name="Roscommon", Type="County" },
            new(){ Code ="SO", LocalName="Sligo", Name="Sligo", Type="County" },
            new(){ Code ="TA", LocalName="Tipperary", Name="Tipperary", Type="County" },
            new(){ Code ="WD", LocalName="Waterford", Name="Waterford", Type="County" },
            new(){ Code ="WH", LocalName="Westmeath", Name="Westmeath", Type="County" },
            new(){ Code ="WX", LocalName="Wexford", Name="Wexford", Type="County" },
            new(){ Code ="WW", LocalName="Wicklow", Name="Wicklow", Type="County" }

        });
    }
}
