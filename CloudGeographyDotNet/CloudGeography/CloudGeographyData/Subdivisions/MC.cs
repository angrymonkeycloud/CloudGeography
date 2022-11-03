using AngryMonkey.Cloud.Geography;
namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    private static void FillInSubdivisionsMC()
    {
        AddSubdivisions("MC", new List<Subdivision>()
        {
            new(){ Code ="FO", LocalName="Fontvieille", Name="Fontvieille", Type="Quarter" },
            new(){ Code ="JE", LocalName="Jardin Exotique", Name="Jardin Exotique", Type="Quarter" },
            new(){ Code ="CL", LocalName="La Colle", Name="La Colle", Type="Quarter" },
            new(){ Code ="CO", LocalName="La Condamine", Name="La Condamine", Type="Quarter" },
            new(){ Code ="GA", LocalName="La Gare", Name="La Gare", Type="Quarter" },
            new(){ Code ="SO", LocalName="La Source", Name="La Source", Type="Quarter" },
            new(){ Code ="LA", LocalName="Larvotto", Name="Larvotto", Type="Quarter" },
            new(){ Code ="MA", LocalName="Malbousquet", Name="Malbousquet", Type="Quarter" },
            new(){ Code ="MO", LocalName="Monaco-Ville", Name="Monaco-Ville", Type="Quarter" },
            new(){ Code ="MG", LocalName="Moneghetti", Name="Moneghetti", Type="Quarter" },
            new(){ Code ="MC", LocalName="Monte-Carlo", Name="Monte-Carlo", Type="Quarter" },
            new(){ Code ="MU", LocalName="Moulins", Name="Moulins", Type="Quarter" },
            new(){ Code ="PH", LocalName="Port-Hercule", Name="Port-Hercule", Type="Quarter" },
            new(){ Code ="SD", LocalName="Sainte-Dévote", Name="Sainte-Dévote", Type="Quarter" },
            new(){ Code ="SR", LocalName="Saint-Roman", Name="Saint-Roman", Type="Quarter" },
            new(){ Code ="SP", LocalName="Spélugues", Name="Spélugues", Type="Quarter" },
            new(){ Code ="VR", LocalName="Vallon de la Rousse", Name="Vallon de la Rousse", Type="Quarter" }

        });
    }
}
