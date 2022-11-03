using AngryMonkey.Cloud.Geography;
namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    private static void FillInSubdivisionsSR()
    {
        AddSubdivisions("SR", new List<Subdivision>()
        {
            new(){ Code ="BR", LocalName="Brokopondo", Name="Brokopondo", Type="District" },
            new(){ Code ="CM", LocalName="Commewijne", Name="Commewijne", Type="District" },
            new(){ Code ="CR", LocalName="Coronie", Name="Coronie", Type="District" },
            new(){ Code ="MA", LocalName="Marowijne", Name="Marowijne", Type="District" },
            new(){ Code ="NI", LocalName="Nickerie", Name="Nickerie", Type="District" },
            new(){ Code ="PR", LocalName="Para", Name="Para", Type="District" },
            new(){ Code ="SA", LocalName="Saramacca", Name="Saramacca", Type="District" },
            new(){ Code ="SI", LocalName="Sipaliwini", Name="Sipaliwini", Type="District" },
            new(){ Code ="WA", LocalName="Wanica", Name="Wanica", Type="District" }

        });
    }
}
