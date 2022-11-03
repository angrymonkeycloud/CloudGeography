using AngryMonkey.Cloud.Geography;
namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    private static void FillInSubdivisionsSO()
    {
        AddSubdivisions("SO", new List<Subdivision>()
        {
            new(){ Code ="AW", LocalName="Awdal", Name="Awdal", Type="Region" },
            new(){ Code ="BK", LocalName="Bakool", Name="Bakool", Type="Region" },
            new(){ Code ="BN", LocalName="Banaadir", Name="Banaadir", Type="Region" },
            new(){ Code ="BR", LocalName="Bari", Name="Bari", Type="Region" },
            new(){ Code ="BY", LocalName="Bay", Name="Bay", Type="Region" },
            new(){ Code ="GA", LocalName="Galguduud", Name="Galguduud", Type="Region" },
            new(){ Code ="GE", LocalName="Gedo", Name="Gedo", Type="Region" },
            new(){ Code ="HI", LocalName="Hiiraan", Name="Hiiraan", Type="Region" },
            new(){ Code ="JD", LocalName="Jubbada Dhexe", Name="Jubbada Dhexe", Type="Region" },
            new(){ Code ="JH", LocalName="Jubbada Hoose", Name="Jubbada Hoose", Type="Region" },
            new(){ Code ="MU", LocalName="Mudug", Name="Mudug", Type="Region" },
            new(){ Code ="NU", LocalName="Nugaal", Name="Nugaal", Type="Region" },
            new(){ Code ="SA", LocalName="Sanaag", Name="Sanaag", Type="Region" },
            new(){ Code ="SD", LocalName="Shabeellaha Dhexe", Name="Shabeellaha Dhexe", Type="Region" },
            new(){ Code ="SH", LocalName="Shabeellaha Hoose", Name="Shabeellaha Hoose", Type="Region" },
            new(){ Code ="SO", LocalName="Sool", Name="Sool", Type="Region" },
            new(){ Code ="TO", LocalName="Togdheer", Name="Togdheer", Type="Region" },
            new(){ Code ="WO", LocalName="Woqooyi Galbeed", Name="Woqooyi Galbeed", Type="Region" }

        });
    }
}
