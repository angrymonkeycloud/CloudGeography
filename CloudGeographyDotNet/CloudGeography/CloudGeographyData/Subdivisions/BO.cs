using AngryMonkey.Cloud.Geography;
namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    private static void FillInSubdivisionsBO()
    {
        AddSubdivisions("BO", new List<Subdivision>()
        {
            new(){ Code ="H", LocalName="Chuquisaca", Name="Chuquisaca", Type="Department" },
            new(){ Code ="C", LocalName="Cochabamba", Name="Cochabamba", Type="Department" },
            new(){ Code ="B", LocalName="El Beni", Name="El Beni", Type="Department" },
            new(){ Code ="L", LocalName="La Paz", Name="La Paz", Type="Department" },
            new(){ Code ="O", LocalName="Oruro", Name="Oruro", Type="Department" },
            new(){ Code ="N", LocalName="Pando", Name="Pando", Type="Department" },
            new(){ Code ="P", LocalName="Potosí", Name="Potosí", Type="Department" },
            new(){ Code ="S", LocalName="Santa Cruz", Name="Santa Cruz", Type="Department" },
            new(){ Code ="T", LocalName="Tarija", Name="Tarija", Type="Department" }

        });
    }
}
