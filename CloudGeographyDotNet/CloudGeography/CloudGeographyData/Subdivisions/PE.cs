using AngryMonkey.Cloud.Geography;
namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    private static void FillInSubdivisionsPE()
    {
        AddSubdivisions("PE", new List<Subdivision>()
        {
            new(){ Code ="AMA", LocalName="Amazonas", Name="Amazonas", Type="Region" },
            new(){ Code ="ANC", LocalName="Ancash", Name="Ancash", Type="Region" },
            new(){ Code ="APU", LocalName="Apurímac", Name="Apurímac", Type="Region" },
            new(){ Code ="ARE", LocalName="Arequipa", Name="Arequipa", Type="Region" },
            new(){ Code ="AYA", LocalName="Ayacucho", Name="Ayacucho", Type="Region" },
            new(){ Code ="CAJ", LocalName="Cajamarca", Name="Cajamarca", Type="Region" },
            new(){ Code ="CUS", LocalName="Cuzco", Name="Cuzco", Type="Region" },
            new(){ Code ="CAL", LocalName="El Callao", Name="El Callao", Type="Region" },
            new(){ Code ="HUV", LocalName="Huancavelica", Name="Huancavelica", Type="Region" },
            new(){ Code ="HUC", LocalName="Huánuco", Name="Huánuco", Type="Region" },
            new(){ Code ="ICA", LocalName="Ica", Name="Ica", Type="Region" },
            new(){ Code ="JUN", LocalName="Junín", Name="Junín", Type="Region" },
            new(){ Code ="LAL", LocalName="La Libertad", Name="La Libertad", Type="Region" },
            new(){ Code ="LAM", LocalName="Lambayeque", Name="Lambayeque", Type="Region" },
            new(){ Code ="LIM", LocalName="Lima", Name="Lima", Type="Region" },
            new(){ Code ="LMA", LocalName="Lima hatun llaqta", Name="Lima hatun llaqta", Type="Municipality" },
            new(){ Code ="LOR", LocalName="Loreto", Name="Loreto", Type="Region" },
            new(){ Code ="MDD", LocalName="Madre de Dios", Name="Madre de Dios", Type="Region" },
            new(){ Code ="MOQ", LocalName="Moquegua", Name="Moquegua", Type="Region" },
            new(){ Code ="PAS", LocalName="Pasco", Name="Pasco", Type="Region" },
            new(){ Code ="PIU", LocalName="Piura", Name="Piura", Type="Region" },
            new(){ Code ="PUN", LocalName="Puno", Name="Puno", Type="Region" },
            new(){ Code ="SAM", LocalName="San Martín", Name="San Martín", Type="Region" },
            new(){ Code ="TAC", LocalName="Tacna", Name="Tacna", Type="Region" },
            new(){ Code ="TUM", LocalName="Tumbes", Name="Tumbes", Type="Region" },
            new(){ Code ="UCA", LocalName="Ucayali", Name="Ucayali", Type="Region" }

        });
    }
}
