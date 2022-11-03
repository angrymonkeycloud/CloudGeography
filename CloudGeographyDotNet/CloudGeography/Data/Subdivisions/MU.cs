using AngryMonkey.Cloud.Geography;
namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    private static void FillInSubdivisionsMU()
    {
        AddSubdivisions("MU", new List<Subdivision>()
        {
            new(){ Code ="AG", LocalName="Agalega Islands", Name="Agalega Islands", Type="Dependency" },
            new(){ Code ="BR", LocalName="Beau Bassin-Rose Hill", Name="Beau Bassin-Rose Hill", Type="City" },
            new(){ Code ="BL", LocalName="Black River", Name="Black River", Type="District" },
            new(){ Code ="CC", LocalName="Cargados Carajos Shoals", Name="Cargados Carajos Shoals", Type="Dependency" },
            new(){ Code ="CU", LocalName="Curepipe", Name="Curepipe", Type="City" },
            new(){ Code ="FL", LocalName="Flacq", Name="Flacq", Type="District" },
            new(){ Code ="GP", LocalName="Grand Port", Name="Grand Port", Type="District" },
            new(){ Code ="MO", LocalName="Moka", Name="Moka", Type="District" },
            new(){ Code ="PA", LocalName="Pamplemousses", Name="Pamplemousses", Type="District" },
            new(){ Code ="PW", LocalName="Plaines wilhems", Name="Plaines wilhems", Type="District" },
            new(){ Code ="PL", LocalName="Port Louis", Name="Port Louis", Type="District" },
            new(){ Code ="PU", LocalName="Port Louis", Name="Port Louis", Type="City" },
            new(){ Code ="QB", LocalName="Quatre Bornes", Name="Quatre Bornes", Type="City" },
            new(){ Code ="RR", LocalName="Rivière du Rempart", Name="Rivière du Rempart", Type="District" },
            new(){ Code ="RO", LocalName="Rodrigues Island", Name="Rodrigues Island", Type="Dependency" },
            new(){ Code ="SA", LocalName="Savanne", Name="Savanne", Type="District" },
            new(){ Code ="VP", LocalName="Vacoas-Phoenix", Name="Vacoas-Phoenix", Type="City" }

        });
    }
}
