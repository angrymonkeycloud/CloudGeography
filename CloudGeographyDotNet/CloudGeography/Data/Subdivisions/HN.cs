using AngryMonkey.Cloud.Geography;
namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    private static void FillInSubdivisionsHN()
    {
        AddSubdivisions("HN", new List<Subdivision>()
        {
            new(){ Code ="AT", LocalName="Atlántida", Name="Atlántida", Type="Department" },
            new(){ Code ="CH", LocalName="Choluteca", Name="Choluteca", Type="Department" },
            new(){ Code ="CL", LocalName="Colón", Name="Colón", Type="Department" },
            new(){ Code ="CM", LocalName="Comayagua", Name="Comayagua", Type="Department" },
            new(){ Code ="CP", LocalName="Copán", Name="Copán", Type="Department" },
            new(){ Code ="CR", LocalName="Cortés", Name="Cortés", Type="Department" },
            new(){ Code ="EP", LocalName="El Paraíso", Name="El Paraíso", Type="Department" },
            new(){ Code ="FM", LocalName="Francisco Morazán", Name="Francisco Morazán", Type="Department" },
            new(){ Code ="GD", LocalName="Gracias a Dios", Name="Gracias a Dios", Type="Department" },
            new(){ Code ="IN", LocalName="Intibucá", Name="Intibucá", Type="Department" },
            new(){ Code ="IB", LocalName="Islas de la Bahía", Name="Islas de la Bahía", Type="Department" },
            new(){ Code ="LP", LocalName="La Paz", Name="La Paz", Type="Department" },
            new(){ Code ="LE", LocalName="Lempira", Name="Lempira", Type="Department" },
            new(){ Code ="OC", LocalName="Ocotepeque", Name="Ocotepeque", Type="Department" },
            new(){ Code ="OL", LocalName="Olancho", Name="Olancho", Type="Department" },
            new(){ Code ="SB", LocalName="Santa Bárbara", Name="Santa Bárbara", Type="Department" },
            new(){ Code ="VA", LocalName="Valle", Name="Valle", Type="Department" },
            new(){ Code ="YO", LocalName="Yoro", Name="Yoro", Type="Department" }

        });
    }
}
