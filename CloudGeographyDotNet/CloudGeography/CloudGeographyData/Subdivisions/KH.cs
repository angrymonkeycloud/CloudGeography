using AngryMonkey.Cloud.Geography;
namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    private static void FillInSubdivisionsKH()
    {
        AddSubdivisions("KH", new List<Subdivision>()
        {
            new(){ Code ="1", LocalName="ខេត្តបន្ទាយមានជ័យ", Name="Banteay Meanchey", Type="Province" },
            new(){ Code ="2", LocalName="បាត់ដំបង", Name="Battambang", Type="Province" },
            new(){ Code ="3", LocalName="កំពង់ចាម", Name="Kampong Cham", Type="Province" },
            new(){ Code ="4", LocalName="ខេត្តកំពង់ឆ្នាំង", Name="Kampong Chhnang", Type="Province" },
            new(){ Code ="5", LocalName="ខេត្តកំពង់ស្ពឺ", Name="Kampong Speu", Type="Province" },
            new(){ Code ="6", LocalName="ខេត្តកំពង់ធំ", Name="Kampong Thom", Type="Province" },
            new(){ Code ="7", LocalName="ខេត្តកំពត", Name="Kampot", Type="Province" },
            new(){ Code ="8", LocalName="កណ្ដាល", Name="Kandal", Type="Province" },
            new(){ Code ="23", LocalName="កែប", Name="Kep", Type="Province" },
            new(){ Code ="9", LocalName="កណ្ដាល", Name="Koh Kong", Type="Province" },
            new(){ Code ="10", LocalName="ក្រចេះ", Name="Kratié", Type="Province" },
            new(){ Code ="11", LocalName="មណ្ឌលគិរី", Name="Mondulkiri", Type="Province" },
            new(){ Code ="22", LocalName="ឧត្ដរមានជ័យ", Name="Oddar Meanchey", Type="Province" },
            new(){ Code ="24", LocalName="ប៉ៃលិន", Name="Pailin", Type="Province" },
            new(){ Code ="12", LocalName="រាជធានីភ្នំពេញ", Name="Phnom Penh", Type="Municipality" },
            new(){ Code ="13", LocalName="ព្រះវិហារ", Name="Preah Vihear", Type="Province" },
            new(){ Code ="14", LocalName="ខេត្តព្រៃវែង", Name="Prey Veng", Type="Province" },
            new(){ Code ="15", LocalName="ខេត្តពោធិ៏សាត់", Name="Pursat", Type="Province" },
            new(){ Code ="16", LocalName="រតនគិរី", Name="Ratanakiri", Type="Province" },
            new(){ Code ="17", LocalName="សៀមរាប", Name="Siem Reap", Type="Province" },
            new(){ Code ="18", LocalName="ខេត្តព្រះសីហនុ", Name="Sihanoukville", Type="Province" },
            new(){ Code ="19", LocalName="ស្ទឹងត្រែង", Name="Stueng Traeng", Type="Province" },
            new(){ Code ="20", LocalName="ស្វាយរៀង", Name="Svaay Rieng", Type="Province" },
            new(){ Code ="21", LocalName="ខេត្តតាកែវ", Name="Takéo", Type="Province" },
            new(){ Code ="25", LocalName="ត្បូងឃ្មុំ", Name="Tbong Khmum", Type="Province" }

        });
    }
}
