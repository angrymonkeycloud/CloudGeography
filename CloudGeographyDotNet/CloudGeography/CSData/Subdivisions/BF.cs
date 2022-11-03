using AngryMonkey.Cloud.Geography;
namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    private static void FillInSubdivisionsBF()
    {
        AddSubdivisions("BF", new List<Subdivision>()
        {
            new(){ Code ="BAL", LocalName="Balé", Name="Balé", Type="Province" },
            new(){ Code ="BAM", LocalName="Bam", Name="Bam", Type="Province" },
            new(){ Code ="BAN", LocalName="Banwa", Name="Banwa", Type="Province" },
            new(){ Code ="BAZ", LocalName="Bazèga", Name="Bazèga", Type="Province" },
            new(){ Code ="BGR", LocalName="Bougouriba", Name="Bougouriba", Type="Province" },
            new(){ Code ="BLG", LocalName="Boulgou", Name="Boulgou", Type="Province" },
            new(){ Code ="BLK", LocalName="Boulkiemdé", Name="Boulkiemdé", Type="Province" },
            new(){ Code ="COM", LocalName="Comoé", Name="Comoé", Type="Province" },
            new(){ Code ="GAN", LocalName="Ganzourgou", Name="Ganzourgou", Type="Province" },
            new(){ Code ="GNA", LocalName="Gnagna", Name="Gnagna", Type="Province" },
            new(){ Code ="GOU", LocalName="Gourma", Name="Gourma", Type="Province" },
            new(){ Code ="HOU", LocalName="Houet", Name="Houet", Type="Province" },
            new(){ Code ="IOB", LocalName="Ioba", Name="Ioba", Type="Province" },
            new(){ Code ="KAD", LocalName="Kadiogo", Name="Kadiogo", Type="Province" },
            new(){ Code ="KEN", LocalName="Kénédougou", Name="Kénédougou", Type="Province" },
            new(){ Code ="KMD", LocalName="Komondjari", Name="Komondjari", Type="Province" },
            new(){ Code ="KMP", LocalName="Kompienga", Name="Kompienga", Type="Province" },
            new(){ Code ="KOS", LocalName="Kossi", Name="Kossi", Type="Province" },
            new(){ Code ="KOP", LocalName="Koulpélogo", Name="Koulpélogo", Type="Province" },
            new(){ Code ="KOT", LocalName="Kouritenga", Name="Kouritenga", Type="Province" },
            new(){ Code ="KOW", LocalName="Kourwéogo", Name="Kourwéogo", Type="Province" },
            new(){ Code ="LER", LocalName="Léraba", Name="Léraba", Type="Province" },
            new(){ Code ="LOR", LocalName="Loroum", Name="Loroum", Type="Province" },
            new(){ Code ="MOU", LocalName="Mouhoun", Name="Mouhoun", Type="Province" },
            new(){ Code ="NAO", LocalName="Nahouri", Name="Nahouri", Type="Province" },
            new(){ Code ="NAM", LocalName="Namentenga", Name="Namentenga", Type="Province" },
            new(){ Code ="NAY", LocalName="Nayala", Name="Nayala", Type="Province" },
            new(){ Code ="NOU", LocalName="Noumbiel", Name="Noumbiel", Type="Province" },
            new(){ Code ="OUB", LocalName="Oubritenga", Name="Oubritenga", Type="Province" },
            new(){ Code ="OUD", LocalName="Oudalan", Name="Oudalan", Type="Province" },
            new(){ Code ="PAS", LocalName="Passoré", Name="Passoré", Type="Province" },
            new(){ Code ="PON", LocalName="Poni", Name="Poni", Type="Province" },
            new(){ Code ="SNG", LocalName="Sanguié", Name="Sanguié", Type="Province" },
            new(){ Code ="SMT", LocalName="Sanmatenga", Name="Sanmatenga", Type="Province" },
            new(){ Code ="SEN", LocalName="Séno", Name="Séno", Type="Province" },
            new(){ Code ="SIS", LocalName="Sissili", Name="Sissili", Type="Province" },
            new(){ Code ="SOM", LocalName="Soum", Name="Soum", Type="Province" },
            new(){ Code ="SOR", LocalName="Sourou", Name="Sourou", Type="Province" },
            new(){ Code ="TAP", LocalName="Tapoa", Name="Tapoa", Type="Province" },
            new(){ Code ="TUI", LocalName="Tuy", Name="Tuy", Type="Province" },
            new(){ Code ="YAG", LocalName="Yagha", Name="Yagha", Type="Province" },
            new(){ Code ="YAT", LocalName="Yatenga", Name="Yatenga", Type="Province" },
            new(){ Code ="ZIR", LocalName="Ziro", Name="Ziro", Type="Province" },
            new(){ Code ="ZON", LocalName="Zondoma", Name="Zondoma", Type="Province" },
            new(){ Code ="ZOU", LocalName="Zoundwéogo", Name="Zoundwéogo", Type="Province" }

        });
    }
}
