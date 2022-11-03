using AngryMonkey.Cloud.Geography;
namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    private static void FillInSubdivisionsCH()
    {
        AddSubdivisions("CH", new List<Subdivision>()
        {
            new(){ Code ="AG", LocalName="Aargau", Name="Aargau", Type="Canton" },
            new(){ Code ="AR", LocalName="Appenzell Ausserrhoden", Name="Appenzell Ausserrhoden", Type="Canton" },
            new(){ Code ="AI", LocalName="Appenzell Innerrhoden", Name="Appenzell Innerrhoden", Type="Canton" },
            new(){ Code ="BL", LocalName="Basel-Landschaft", Name="Basel-Landschaft", Type="Canton" },
            new(){ Code ="BS", LocalName="Basel-Stadt", Name="Basel-Stadt", Type="Canton" },
            new(){ Code ="BE", LocalName="Bern", Name="Bern", Type="Canton" },
            new(){ Code ="FR", LocalName="Fribourg", Name="Fribourg", Type="Canton" },
            new(){ Code ="GE", LocalName="Genève", Name="Genève", Type="Canton" },
            new(){ Code ="GL", LocalName="Glarus", Name="Glarus", Type="Canton" },
            new(){ Code ="GR", LocalName="Graubünden", Name="Graubünden", Type="Canton" },
            new(){ Code ="JU", LocalName="Jura", Name="Jura", Type="Canton" },
            new(){ Code ="LU", LocalName="Luzern", Name="Luzern", Type="Canton" },
            new(){ Code ="NE", LocalName="Neuchâtel", Name="Neuchâtel", Type="Canton" },
            new(){ Code ="NW", LocalName="Nidwalden", Name="Nidwalden", Type="Canton" },
            new(){ Code ="OW", LocalName="Obwalden", Name="Obwalden", Type="Canton" },
            new(){ Code ="SG", LocalName="Sankt Gallen", Name="Sankt Gallen", Type="Canton" },
            new(){ Code ="SH", LocalName="Schaffhausen", Name="Schaffhausen", Type="Canton" },
            new(){ Code ="SZ", LocalName="Schwyz", Name="Schwyz", Type="Canton" },
            new(){ Code ="SO", LocalName="Solothurn", Name="Solothurn", Type="Canton" },
            new(){ Code ="TG", LocalName="Thurgau", Name="Thurgau", Type="Canton" },
            new(){ Code ="TI", LocalName="Ticino", Name="Ticino", Type="Canton" },
            new(){ Code ="UR", LocalName="Uri", Name="Uri", Type="Canton" },
            new(){ Code ="VS", LocalName="Valais", Name="Valais", Type="Canton" },
            new(){ Code ="VD", LocalName="Vaud", Name="Vaud", Type="Canton" },
            new(){ Code ="ZG", LocalName="Zug", Name="Zug", Type="Canton" },
            new(){ Code ="ZH", LocalName="Zürich", Name="Zürich", Type="Canton" }

        });
    }
}
