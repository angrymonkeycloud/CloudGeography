using AngryMonkey.Cloud.Geography;
namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    private static void FillInSubdivisionsKH()
    {
        AddSubdivisions("KH",
        [
            new()
            { 
                Code = "1",
                Type = SubdivisionTypes.Province,
                Name = "Banteay Meanchey",
                LocalName = "ខេត្តបន្ទាយមានជ័យ"
            },
            new()
            { 
                Code = "2",
                Type = SubdivisionTypes.Province,
                Name = "Battambang",
                LocalName = "បាត់ដំបង"
            },
            new()
            { 
                Code = "3",
                Type = SubdivisionTypes.Province,
                Name = "Kampong Cham",
                LocalName = "កំពង់ចាម"
            },
            new()
            { 
                Code = "4",
                Type = SubdivisionTypes.Province,
                Name = "Kampong Chhnang",
                LocalName = "ខេត្តកំពង់ឆ្នាំង"
            },
            new()
            { 
                Code = "5",
                Type = SubdivisionTypes.Province,
                Name = "Kampong Speu",
                LocalName = "ខេត្តកំពង់ស្ពឺ"
            },
            new()
            { 
                Code = "6",
                Type = SubdivisionTypes.Province,
                Name = "Kampong Thom",
                LocalName = "ខេត្តកំពង់ធំ"
            },
            new()
            { 
                Code = "7",
                Type = SubdivisionTypes.Province,
                Name = "Kampot",
                LocalName = "ខេត្តកំពត"
            },
            new()
            { 
                Code = "8",
                Type = SubdivisionTypes.Province,
                Name = "Kandal",
                LocalName = "កណ្ដាល"
            },
            new()
            { 
                Code = "23",
                Type = SubdivisionTypes.Province,
                Name = "Kep",
                LocalName = "កែប"
            },
            new()
            { 
                Code = "9",
                Type = SubdivisionTypes.Province,
                Name = "Koh Kong",
                LocalName = "កណ្ដាល"
            },
            new()
            { 
                Code = "10",
                Type = SubdivisionTypes.Province,
                Name = "Kratié",
                LocalName = "ក្រចេះ"
            },
            new()
            { 
                Code = "11",
                Type = SubdivisionTypes.Province,
                Name = "Mondulkiri",
                LocalName = "មណ្ឌលគិរី"
            },
            new()
            { 
                Code = "22",
                Type = SubdivisionTypes.Province,
                Name = "Oddar Meanchey",
                LocalName = "ឧត្ដរមានជ័យ"
            },
            new()
            { 
                Code = "24",
                Type = SubdivisionTypes.Province,
                Name = "Pailin",
                LocalName = "ប៉ៃលិន"
            },
            new()
            { 
                Code = "12",
                Type = SubdivisionTypes.Municipality,
                Name = "Phnom Penh",
                LocalName = "រាជធានីភ្នំពេញ"
            },
            new()
            { 
                Code = "13",
                Type = SubdivisionTypes.Province,
                Name = "Preah Vihear",
                LocalName = "ព្រះវិហារ"
            },
            new()
            { 
                Code = "14",
                Type = SubdivisionTypes.Province,
                Name = "Prey Veng",
                LocalName = "ខេត្តព្រៃវែង"
            },
            new()
            { 
                Code = "15",
                Type = SubdivisionTypes.Province,
                Name = "Pursat",
                LocalName = "ខេត្តពោធិ៏សាត់"
            },
            new()
            { 
                Code = "16",
                Type = SubdivisionTypes.Province,
                Name = "Ratanakiri",
                LocalName = "រតនគិរី"
            },
            new()
            { 
                Code = "17",
                Type = SubdivisionTypes.Province,
                Name = "Siem Reap",
                LocalName = "សៀមរាប"
            },
            new()
            { 
                Code = "18",
                Type = SubdivisionTypes.Province,
                Name = "Sihanoukville",
                LocalName = "ខេត្តព្រះសីហនុ"
            },
            new()
            { 
                Code = "19",
                Type = SubdivisionTypes.Province,
                Name = "Stueng Traeng",
                LocalName = "ស្ទឹងត្រែង"
            },
            new()
            { 
                Code = "20",
                Type = SubdivisionTypes.Province,
                Name = "Svaay Rieng",
                LocalName = "ស្វាយរៀង"
            },
            new()
            { 
                Code = "21",
                Type = SubdivisionTypes.Province,
                Name = "Takéo",
                LocalName = "ខេត្តតាកែវ"
            },
            new()
            { 
                Code = "25",
                Type = SubdivisionTypes.Province,
                Name = "Tbong Khmum",
                LocalName = "ត្បូងឃ្មុំ"
            }

        ]);
    }
}
