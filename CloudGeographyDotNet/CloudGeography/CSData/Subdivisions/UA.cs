using AngryMonkey.Cloud.Geography;
namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    private static void FillInSubdivisionsUA()
    {
        AddSubdivisions("UA", new List<Subdivision>()
        {
            new(){ Code ="43", LocalName="Avtonomna Respublika Krym", Name="Avtonomna Respublika Krym", Type="Republic" },
            new(){ Code ="71", LocalName="Cherkaska oblast", Name="Cherkaska oblast", Type="Region" },
            new(){ Code ="74", LocalName="Chernihivska oblast", Name="Chernihivska oblast", Type="Region" },
            new(){ Code ="77", LocalName="Chernivetska oblast", Name="Chernivetska oblast", Type="Region" },
            new(){ Code ="12", LocalName="Dnipropetrovska oblast", Name="Dnipropetrovska oblast", Type="Region" },
            new(){ Code ="14", LocalName="Donetska oblast", Name="Donetska oblast", Type="Region" },
            new(){ Code ="26", LocalName="Ivano-Frankivska oblast", Name="Ivano-Frankivska oblast", Type="Region" },
            new(){ Code ="63", LocalName="Kharkivska oblast", Name="Kharkivska oblast", Type="Region" },
            new(){ Code ="65", LocalName="Khersonska oblast", Name="Khersonska oblast", Type="Region" },
            new(){ Code ="68", LocalName="Khmelnytska oblast", Name="Khmelnytska oblast", Type="Region" },
            new(){ Code ="35", LocalName="Kirovohradska oblast", Name="Kirovohradska oblast", Type="Region" },
            new(){ Code ="30", LocalName="Kyiv", Name="Kyiv", Type="City" },
            new(){ Code ="32", LocalName="Kyivska oblast", Name="Kyivska oblast", Type="Region" },
            new(){ Code ="9", LocalName="Luhanska oblast", Name="Luhanska oblast", Type="Region" },
            new(){ Code ="46", LocalName="Lvivska oblast", Name="Lvivska oblast", Type="Region" },
            new(){ Code ="48", LocalName="Mykolaivska oblast", Name="Mykolaivska oblast", Type="Region" },
            new(){ Code ="51", LocalName="Odeska oblast", Name="Odeska oblast", Type="Region" },
            new(){ Code ="53", LocalName="Poltavska oblast", Name="Poltavska oblast", Type="Region" },
            new(){ Code ="56", LocalName="Rivnenska oblast", Name="Rivnenska oblast", Type="Region" },
            new(){ Code ="40", LocalName="Sevastopol", Name="Sevastopol", Type="City" },
            new(){ Code ="59", LocalName="Sumska oblast", Name="Sumska oblast", Type="Region" },
            new(){ Code ="61", LocalName="Ternopilska oblast", Name="Ternopilska oblast", Type="Region" },
            new(){ Code ="5", LocalName="Vinnytska oblast", Name="Vinnytska oblast", Type="Region" },
            new(){ Code ="7", LocalName="Volynska oblast", Name="Volynska oblast", Type="Region" },
            new(){ Code ="21", LocalName="Zakarpatska oblast", Name="Zakarpatska oblast", Type="Region" },
            new(){ Code ="23", LocalName="Zaporizka oblast", Name="Zaporizka oblast", Type="Region" },
            new(){ Code ="18", LocalName="Zhytomyrska oblast", Name="Zhytomyrska oblast", Type="Region" }

        });
    }
}
