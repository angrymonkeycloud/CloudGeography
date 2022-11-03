using AngryMonkey.Cloud.Geography;
namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    private static void FillInSubdivisionsGN()
    {
        AddSubdivisions("GN", new List<Subdivision>()
        {
            new(){ Code ="BE", LocalName="Beyla", Name="Beyla", Type="Prefecture" },
            new(){ Code ="BF", LocalName="Boffa", Name="Boffa", Type="Prefecture" },
            new(){ Code ="BK", LocalName="Boké", Name="Boké", Type="Prefecture" },
            new(){ Code ="CO", LocalName="Coyah", Name="Coyah", Type="Prefecture" },
            new(){ Code ="DB", LocalName="Dabola", Name="Dabola", Type="Prefecture" },
            new(){ Code ="DL", LocalName="Dalaba", Name="Dalaba", Type="Prefecture" },
            new(){ Code ="DI", LocalName="Dinguiraye", Name="Dinguiraye", Type="Prefecture" },
            new(){ Code ="DU", LocalName="Dubréka", Name="Dubréka", Type="Prefecture" },
            new(){ Code ="FA", LocalName="Faranah", Name="Faranah", Type="Prefecture" },
            new(){ Code ="FO", LocalName="Forécariah", Name="Forécariah", Type="Prefecture" },
            new(){ Code ="FR", LocalName="Fria", Name="Fria", Type="Prefecture" },
            new(){ Code ="GA", LocalName="Gaoual", Name="Gaoual", Type="Prefecture" },
            new(){ Code ="GU", LocalName="Guékédou", Name="Guékédou", Type="Prefecture" },
            new(){ Code ="KA", LocalName="Kankan", Name="Kankan", Type="Prefecture" },
            new(){ Code ="KE", LocalName="Kérouané", Name="Kérouané", Type="Prefecture" },
            new(){ Code ="KD", LocalName="Kindia", Name="Kindia", Type="Prefecture" },
            new(){ Code ="KS", LocalName="Kissidougou", Name="Kissidougou", Type="Prefecture" },
            new(){ Code ="KB", LocalName="Koubia", Name="Koubia", Type="Prefecture" },
            new(){ Code ="KN", LocalName="Koundara", Name="Koundara", Type="Prefecture" },
            new(){ Code ="KO", LocalName="Kouroussa", Name="Kouroussa", Type="Prefecture" },
            new(){ Code ="LA", LocalName="Labé", Name="Labé", Type="Prefecture" },
            new(){ Code ="LE", LocalName="Lélouma", Name="Lélouma", Type="Prefecture" },
            new(){ Code ="LO", LocalName="Lola", Name="Lola", Type="Prefecture" },
            new(){ Code ="MC", LocalName="Macenta", Name="Macenta", Type="Prefecture" },
            new(){ Code ="ML", LocalName="Mali", Name="Mali", Type="Prefecture" },
            new(){ Code ="MM", LocalName="Mamou", Name="Mamou", Type="Prefecture" },
            new(){ Code ="MD", LocalName="Mandiana", Name="Mandiana", Type="Prefecture" },
            new(){ Code ="NZ", LocalName="Nzérékoré", Name="Nzérékoré", Type="Prefecture" },
            new(){ Code ="PI", LocalName="Pita", Name="Pita", Type="Prefecture" },
            new(){ Code ="SI", LocalName="Siguiri", Name="Siguiri", Type="Prefecture" },
            new(){ Code ="TE", LocalName="Télimélé", Name="Télimélé", Type="Prefecture" },
            new(){ Code ="TO", LocalName="Tougué", Name="Tougué", Type="Prefecture" },
            new(){ Code ="YO", LocalName="Yomou", Name="Yomou", Type="Prefecture" }

        });
    }
}
