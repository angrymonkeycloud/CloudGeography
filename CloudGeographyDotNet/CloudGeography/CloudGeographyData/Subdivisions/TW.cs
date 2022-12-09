using AngryMonkey.Cloud.Geography;
namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    private static void FillInSubdivisionsTW()
    {
        AddSubdivisions("TW", new List<Subdivision>()
        {
            new()
            { 
                Code = "CHA",
                Type = "County",
                Name = "Changhua",
                LocalName = "Changhua"
            },
            new()
            { 
                Code = "CYQ",
                Type = "County",
                Name = "Chiayi",
                LocalName = "Chiayi"
            },
            new()
            { 
                Code = "CYI",
                Type = "City",
                Name = "Chiayi",
                LocalName = "Chiayi"
            },
            new()
            { 
                Code = "HSQ",
                Type = "County",
                Name = "Hsinchu",
                LocalName = "Hsinchu"
            },
            new()
            { 
                Code = "HSZ",
                Type = "City",
                Name = "Hsinchu",
                LocalName = "Hsinchu"
            },
            new()
            { 
                Code = "HUA",
                Type = "County",
                Name = "Hualien",
                LocalName = "Hualien"
            },
            new()
            { 
                Code = "KHH",
                Type = "Municipality",
                Name = "Kaohsiung",
                LocalName = "Kaohsiung"
            },
            new()
            { 
                Code = "KEE",
                Type = "City",
                Name = "Keelung",
                LocalName = "Keelung"
            },
            new()
            { 
                Code = "KIN",
                Type = "County",
                Name = "Kinmen",
                LocalName = "Kinmen"
            },
            new()
            { 
                Code = "LIE",
                Type = "County",
                Name = "Lienchiang",
                LocalName = "Lienchiang"
            },
            new()
            { 
                Code = "MIA",
                Type = "County",
                Name = "Miaoli",
                LocalName = "Miaoli"
            },
            new()
            { 
                Code = "NAN",
                Type = "County",
                Name = "Nantou",
                LocalName = "Nantou"
            },
            new()
            { 
                Code = "NWT",
                Type = "Municipality",
                Name = "New Taipei",
                LocalName = "New Taipei"
            },
            new()
            { 
                Code = "PEN",
                Type = "County",
                Name = "Penghu",
                LocalName = "Penghu"
            },
            new()
            { 
                Code = "PIF",
                Type = "County",
                Name = "Pingtung",
                LocalName = "Pingtung"
            },
            new()
            { 
                Code = "TXG",
                Type = "Municipality",
                Name = "Taichung",
                LocalName = "Taichung"
            },
            new()
            { 
                Code = "TNN",
                Type = "Municipality",
                Name = "Tainan",
                LocalName = "Tainan"
            },
            new()
            { 
                Code = "TPE",
                Type = "Municipality",
                Name = "Taipei",
                LocalName = "Taipei"
            },
            new()
            { 
                Code = "TTT",
                Type = "County",
                Name = "Taitung",
                LocalName = "Taitung"
            },
            new()
            { 
                Code = "TAO",
                Type = "Municipality",
                Name = "Taoyuan",
                LocalName = "Taoyuan"
            },
            new()
            { 
                Code = "ILA",
                Type = "County",
                Name = "Yilan",
                LocalName = "Yilan"
            },
            new()
            { 
                Code = "YUN",
                Type = "County",
                Name = "Yunlin",
                LocalName = "Yunlin"
            }

        });
    }
}
