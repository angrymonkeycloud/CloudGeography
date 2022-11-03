using AngryMonkey.Cloud.Geography;
namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    private static void FillInSubdivisionsRO()
    {
        AddSubdivisions("RO", new List<Subdivision>()
        {
            new(){ Code ="AB", LocalName="Alba", Name="Alba", Type="Departments" },
            new(){ Code ="AR", LocalName="Arad", Name="Arad", Type="Departments" },
            new(){ Code ="AG", LocalName="Arges", Name="Arges", Type="Departments" },
            new(){ Code ="BC", LocalName="Bacau", Name="Bacau", Type="Departments" },
            new(){ Code ="BH", LocalName="Bihor", Name="Bihor", Type="Departments" },
            new(){ Code ="BN", LocalName="Bistrita-Nasaud", Name="Bistrita-Nasaud", Type="Departments" },
            new(){ Code ="BT", LocalName="Botosani", Name="Botosani", Type="Departments" },
            new(){ Code ="BR", LocalName="Braila", Name="Braila", Type="Departments" },
            new(){ Code ="BV", LocalName="Brasov", Name="Brasov", Type="Departments" },
            new(){ Code ="B", LocalName="Bucuresti", Name="Bucuresti", Type="Municipality" },
            new(){ Code ="BZ", LocalName="Buzau", Name="Buzau", Type="Departments" },
            new(){ Code ="CL", LocalName="Calarasi", Name="Calarasi", Type="Departments" },
            new(){ Code ="CS", LocalName="Caras-Severin", Name="Caras-Severin", Type="Departments" },
            new(){ Code ="CJ", LocalName="Cluj", Name="Cluj", Type="Departments" },
            new(){ Code ="CT", LocalName="Constarta", Name="Constarta", Type="Departments" },
            new(){ Code ="CV", LocalName="Covasna", Name="Covasna", Type="Departments" },
            new(){ Code ="DB", LocalName="Dâmbovita", Name="Dâmbovita", Type="Departments" },
            new(){ Code ="DJ", LocalName="Dolj", Name="Dolj", Type="Departments" },
            new(){ Code ="GL", LocalName="Galati", Name="Galati", Type="Departments" },
            new(){ Code ="GR", LocalName="Giurgiu", Name="Giurgiu", Type="Departments" },
            new(){ Code ="GJ", LocalName="Gorj", Name="Gorj", Type="Departments" },
            new(){ Code ="HR", LocalName="Harghita", Name="Harghita", Type="Departments" },
            new(){ Code ="HD", LocalName="Hunedoara", Name="Hunedoara", Type="Departments" },
            new(){ Code ="IL", LocalName="Ialomita", Name="Ialomita", Type="Departments" },
            new(){ Code ="IS", LocalName="Iasi", Name="Iasi", Type="Departments" },
            new(){ Code ="IF", LocalName="Ilfov", Name="Ilfov", Type="Departments" },
            new(){ Code ="MM", LocalName="Maramures", Name="Maramures", Type="Departments" },
            new(){ Code ="MH", LocalName="Mehedinti", Name="Mehedinti", Type="Departments" },
            new(){ Code ="MS", LocalName="Mures", Name="Mures", Type="Departments" },
            new(){ Code ="NT", LocalName="Neamt", Name="Neamt", Type="Departments" },
            new(){ Code ="OT", LocalName="Olt", Name="Olt", Type="Departments" },
            new(){ Code ="PH", LocalName="Prahova", Name="Prahova", Type="Departments" },
            new(){ Code ="SJ", LocalName="Salaj", Name="Salaj", Type="Departments" },
            new(){ Code ="SM", LocalName="Satu Mare", Name="Satu Mare", Type="Departments" },
            new(){ Code ="SB", LocalName="Sibiu", Name="Sibiu", Type="Departments" },
            new(){ Code ="SV", LocalName="Suceava", Name="Suceava", Type="Departments" },
            new(){ Code ="TR", LocalName="Teleorman", Name="Teleorman", Type="Departments" },
            new(){ Code ="TM", LocalName="Timis", Name="Timis", Type="Departments" },
            new(){ Code ="TL", LocalName="Tulcea", Name="Tulcea", Type="Departments" },
            new(){ Code ="VL", LocalName="Vâlcea", Name="Vâlcea", Type="Departments" },
            new(){ Code ="VS", LocalName="Vaslui", Name="Vaslui", Type="Departments" },
            new(){ Code ="VN", LocalName="Vrancea", Name="Vrancea", Type="Departments" }

        });
    }
}
