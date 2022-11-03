using AngryMonkey.Cloud.Geography;
namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    private static void FillInSubdivisionsHR()
    {
        AddSubdivisions("HR", new List<Subdivision>()
        {
            new(){ Code ="15", LocalName="ibensko-kninska upanija", Name="ibensko-kninska upanija", Type="County" },
            new(){ Code ="7", LocalName="Bjelovarsko-bilogorska upanija", Name="Bjelovarsko-bilogorska upanija", Type="County" },
            new(){ Code ="12", LocalName="Brodsko-posavska upanija", Name="Brodsko-posavska upanija", Type="County" },
            new(){ Code ="19", LocalName="Dubrovacko-neretvanska upanija", Name="Dubrovacko-neretvanska upanija", Type="County" },
            new(){ Code ="21", LocalName="Grad Zagreb", Name="Grad Zagreb", Type="City" },
            new(){ Code ="18", LocalName="Istarska upanija", Name="Istarska upanija", Type="County" },
            new(){ Code ="4", LocalName="Karlovacka upanija", Name="Karlovacka upanija", Type="County" },
            new(){ Code ="6", LocalName="Koprivnicko-krievacka upanija", Name="Koprivnicko-krievacka upanija", Type="County" },
            new(){ Code ="2", LocalName="Krapinsko-zagorska upanija", Name="Krapinsko-zagorska upanija", Type="County" },
            new(){ Code ="9", LocalName="Licko-senjska upanija", Name="Licko-senjska upanija", Type="County" },
            new(){ Code ="20", LocalName="Medimurska upanija", Name="Medimurska upanija", Type="County" },
            new(){ Code ="14", LocalName="Osjecko-baranjska upanija", Name="Osjecko-baranjska upanija", Type="County" },
            new(){ Code ="11", LocalName="Poeko-slavonska upanija", Name="Poeko-slavonska upanija", Type="County" },
            new(){ Code ="8", LocalName="Primorsko-goranska upanija", Name="Primorsko-goranska upanija", Type="County" },
            new(){ Code ="3", LocalName="Sisacko-moslavacka upanija", Name="Sisacko-moslavacka upanija", Type="County" },
            new(){ Code ="17", LocalName="Splitsko-dalmatinska upanija", Name="Splitsko-dalmatinska upanija", Type="County" },
            new(){ Code ="5", LocalName="Varadinska upanija", Name="Varadinska upanija", Type="County" },
            new(){ Code ="10", LocalName="Viroviticko-podravska upanija", Name="Viroviticko-podravska upanija", Type="County" },
            new(){ Code ="16", LocalName="Vukovarsko-srijemska upanija", Name="Vukovarsko-srijemska upanija", Type="County" },
            new(){ Code ="13", LocalName="Zadarska upanija", Name="Zadarska upanija", Type="County" },
            new(){ Code ="1", LocalName="Zagrebacka upanija", Name="Zagrebacka upanija", Type="County" }

        });
    }
}
