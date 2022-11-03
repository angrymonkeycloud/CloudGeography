using AngryMonkey.Cloud.Geography;
namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    private static void FillInSubdivisionsLB()
    {
        AddSubdivisions("LB", new List<Subdivision>()
        {
            new(){ Code ="AK", LocalName="عكار", Name="Akkar", Type="Governorate" },
            new(){ Code ="BH", LocalName="بعلبك - الهرمل", Name="Baalbek-Hermel", Type="Governorate" },
            new(){ Code ="BA", LocalName="بيروت", Name="Beirut", Type="Governorate" },
            new(){ Code ="BI", LocalName="البقاع", Name="Beqaa", Type="Governorate" },
            new(){ Code ="JL", LocalName="جبل لبنان", Name="Mount Lebanon", Type="Governorate" },
            new(){ Code ="NA", LocalName="النبطية", Name="Nabatieh", Type="Governorate" },
            new(){ Code ="AS", LocalName="الشمال", Name="North", Type="Governorate" },
            new(){ Code ="JA", LocalName="الجنوب", Name="South", Type="Governorate" }

        });
    }
}
