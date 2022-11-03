using AngryMonkey.Cloud.Geography;
namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    private static void FillInSubdivisionsTZ()
    {
        AddSubdivisions("TZ", new List<Subdivision>()
        {
            new(){ Code ="1", LocalName="Arusha", Name="Arusha", Type="Region" },
            new(){ Code ="2", LocalName="Dar es Salaam", Name="Dar es Salaam", Type="Region" },
            new(){ Code ="3", LocalName="Dodoma", Name="Dodoma", Type="Region" },
            new(){ Code ="27", LocalName="Geita", Name="Geita", Type="Region" },
            new(){ Code ="4", LocalName="Iringa", Name="Iringa", Type="Region" },
            new(){ Code ="5", LocalName="Kagera", Name="Kagera", Type="Region" },
            new(){ Code ="6", LocalName="Kaskazini Pemba", Name="Kaskazini Pemba", Type="Region" },
            new(){ Code ="7", LocalName="Kaskazini Unguja", Name="Kaskazini Unguja", Type="Region" },
            new(){ Code ="28", LocalName="Katavi", Name="Katavi", Type="Region" },
            new(){ Code ="8", LocalName="Kigoma", Name="Kigoma", Type="Region" },
            new(){ Code ="9", LocalName="Kilimanjaro", Name="Kilimanjaro", Type="Region" },
            new(){ Code ="10", LocalName="Kusini Pemba", Name="Kusini Pemba", Type="Region" },
            new(){ Code ="11", LocalName="Kusini Unguja", Name="Kusini Unguja", Type="Region" },
            new(){ Code ="12", LocalName="Lindi", Name="Lindi", Type="Region" },
            new(){ Code ="26", LocalName="Manyara", Name="Manyara", Type="Region" },
            new(){ Code ="13", LocalName="Mara", Name="Mara", Type="Region" },
            new(){ Code ="14", LocalName="Mbeya", Name="Mbeya", Type="Region" },
            new(){ Code ="15", LocalName="Mjini Magharibi", Name="Mjini Magharibi", Type="Region" },
            new(){ Code ="16", LocalName="Morogoro", Name="Morogoro", Type="Region" },
            new(){ Code ="17", LocalName="Mtwara", Name="Mtwara", Type="Region" },
            new(){ Code ="18", LocalName="Mwanza", Name="Mwanza", Type="Region" },
            new(){ Code ="29", LocalName="Njombe", Name="Njombe", Type="Region" },
            new(){ Code ="19", LocalName="Pwani", Name="Pwani", Type="Region" },
            new(){ Code ="20", LocalName="Rukwa", Name="Rukwa", Type="Region" },
            new(){ Code ="21", LocalName="Ruvuma", Name="Ruvuma", Type="Region" },
            new(){ Code ="22", LocalName="Shinyanga", Name="Shinyanga", Type="Region" },
            new(){ Code ="30", LocalName="Simiyu", Name="Simiyu", Type="Region" },
            new(){ Code ="23", LocalName="Singida", Name="Singida", Type="Region" },
            new(){ Code ="24", LocalName="Tabora", Name="Tabora", Type="Region" },
            new(){ Code ="25", LocalName="Tanga", Name="Tanga", Type="Region" }

        });
    }
}
