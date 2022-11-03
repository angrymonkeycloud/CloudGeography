using AngryMonkey.Cloud.Geography;
namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    private static void FillInSubdivisionsUY()
    {
        AddSubdivisions("UY", new List<Subdivision>()
        {
            new(){ Code ="AR", LocalName="Artigas", Name="Artigas", Type="Department" },
            new(){ Code ="CA", LocalName="Canelones", Name="Canelones", Type="Department" },
            new(){ Code ="CL", LocalName="Cerro Largo", Name="Cerro Largo", Type="Department" },
            new(){ Code ="CO", LocalName="Colonia", Name="Colonia", Type="Department" },
            new(){ Code ="DU", LocalName="Durazno", Name="Durazno", Type="Department" },
            new(){ Code ="FS", LocalName="Flores", Name="Flores", Type="Department" },
            new(){ Code ="FD", LocalName="Florida", Name="Florida", Type="Department" },
            new(){ Code ="LA", LocalName="Lavalleja", Name="Lavalleja", Type="Department" },
            new(){ Code ="MA", LocalName="Maldonado", Name="Maldonado", Type="Department" },
            new(){ Code ="MO", LocalName="Montevideo", Name="Montevideo", Type="Department" },
            new(){ Code ="PA", LocalName="Paysandú", Name="Paysandú", Type="Department" },
            new(){ Code ="RN", LocalName="Río Negro", Name="Río Negro", Type="Department" },
            new(){ Code ="RV", LocalName="Rivera", Name="Rivera", Type="Department" },
            new(){ Code ="RO", LocalName="Rocha", Name="Rocha", Type="Department" },
            new(){ Code ="SA", LocalName="Salto", Name="Salto", Type="Department" },
            new(){ Code ="SJ", LocalName="San José", Name="San José", Type="Department" },
            new(){ Code ="SO", LocalName="Soriano", Name="Soriano", Type="Department" },
            new(){ Code ="TA", LocalName="Tacuarembó", Name="Tacuarembó", Type="Department" },
            new(){ Code ="TT", LocalName="Treinta y Tres", Name="Treinta y Tres", Type="Department" }

        });
    }
}
