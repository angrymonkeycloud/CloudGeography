using AngryMonkey.Cloud.Geography;
namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    private static void FillInSubdivisionsGT()
    {
        AddSubdivisions("GT", new List<Subdivision>()
        {
            new(){ Code ="AV", LocalName="Alta Verapaz", Name="Alta Verapaz", Type="Department" },
            new(){ Code ="BV", LocalName="Baja Verapaz", Name="Baja Verapaz", Type="Department" },
            new(){ Code ="CM", LocalName="Chimaltenango", Name="Chimaltenango", Type="Department" },
            new(){ Code ="CQ", LocalName="Chiquimula", Name="Chiquimula", Type="Department" },
            new(){ Code ="PR", LocalName="El Progreso", Name="El Progreso", Type="Department" },
            new(){ Code ="ES", LocalName="Escuintla", Name="Escuintla", Type="Department" },
            new(){ Code ="GU", LocalName="Guatemala", Name="Guatemala", Type="Department" },
            new(){ Code ="HU", LocalName="Huehuetenango", Name="Huehuetenango", Type="Department" },
            new(){ Code ="IZ", LocalName="Izabal", Name="Izabal", Type="Department" },
            new(){ Code ="JA", LocalName="Jalapa", Name="Jalapa", Type="Department" },
            new(){ Code ="JU", LocalName="Jutiapa", Name="Jutiapa", Type="Department" },
            new(){ Code ="PE", LocalName="Petén", Name="Petén", Type="Department" },
            new(){ Code ="QZ", LocalName="Quetzaltenango", Name="Quetzaltenango", Type="Department" },
            new(){ Code ="QC", LocalName="Quiché", Name="Quiché", Type="Department" },
            new(){ Code ="RE", LocalName="Retalhuleu", Name="Retalhuleu", Type="Department" },
            new(){ Code ="SA", LocalName="Sacatepéquez", Name="Sacatepéquez", Type="Department" },
            new(){ Code ="SM", LocalName="San Marcos", Name="San Marcos", Type="Department" },
            new(){ Code ="SR", LocalName="Santa Rosa", Name="Santa Rosa", Type="Department" },
            new(){ Code ="SO", LocalName="Sololá", Name="Sololá", Type="Department" },
            new(){ Code ="SU", LocalName="Suchitepéquez", Name="Suchitepéquez", Type="Department" },
            new(){ Code ="TO", LocalName="Totonicapán", Name="Totonicapán", Type="Department" },
            new(){ Code ="ZA", LocalName="Zacapa", Name="Zacapa", Type="Department" }

        });
    }
}
