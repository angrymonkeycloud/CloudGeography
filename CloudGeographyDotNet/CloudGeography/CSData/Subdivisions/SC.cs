using AngryMonkey.Cloud.Geography;
namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    private static void FillInSubdivisionsSC()
    {
        AddSubdivisions("SC", new List<Subdivision>()
        {
            new(){ Code ="1", LocalName="Anse aux Pins", Name="Anse aux Pins", Type="District" },
            new(){ Code ="2", LocalName="Anse Boileau", Name="Anse Boileau", Type="District" },
            new(){ Code ="3", LocalName="Anse Étoile", Name="Anse Étoile", Type="District" },
            new(){ Code ="5", LocalName="Anse Royale", Name="Anse Royale", Type="District" },
            new(){ Code ="4", LocalName="Au Cap", Name="Au Cap", Type="District" },
            new(){ Code ="6", LocalName="Baie Lazare", Name="Baie Lazare", Type="District" },
            new(){ Code ="7", LocalName="Baie Sainte Anne", Name="Baie Sainte Anne", Type="District" },
            new(){ Code ="8", LocalName="Beau Vallon", Name="Beau Vallon", Type="District" },
            new(){ Code ="9", LocalName="Bel Air", Name="Bel Air", Type="District" },
            new(){ Code ="10", LocalName="Bel Ombre", Name="Bel Ombre", Type="District" },
            new(){ Code ="11", LocalName="Cascade", Name="Cascade", Type="District" },
            new(){ Code ="12", LocalName="Glacis", Name="Glacis", Type="District" },
            new(){ Code ="13", LocalName="Grand'Anse Mahé", Name="Grand'Anse Mahé", Type="District" },
            new(){ Code ="14", LocalName="Grand'Anse Praslin", Name="Grand'Anse Praslin", Type="District" },
            new(){ Code ="15", LocalName="La Digue", Name="La Digue", Type="District" },
            new(){ Code ="16", LocalName="La Rivière Anglaise", Name="La Rivière Anglaise", Type="District" },
            new(){ Code ="24", LocalName="Lemamel", Name="Lemamel", Type="District" },
            new(){ Code ="17", LocalName="Mont Buxton", Name="Mont Buxton", Type="District" },
            new(){ Code ="18", LocalName="Mont Fleuri", Name="Mont Fleuri", Type="District" },
            new(){ Code ="19", LocalName="Plaisance", Name="Plaisance", Type="District" },
            new(){ Code ="20", LocalName="Pointe La Rue", Name="Pointe La Rue", Type="District" },
            new(){ Code ="21", LocalName="Port Glaud", Name="Port Glaud", Type="District" },
            new(){ Code ="25", LocalName="Ros Kaiman", Name="Ros Kaiman", Type="District" },
            new(){ Code ="22", LocalName="Saint Louis", Name="Saint Louis", Type="District" },
            new(){ Code ="23", LocalName="Takamaka", Name="Takamaka", Type="District" }

        });
    }
}
