using AngryMonkey.Cloud.Geography;
namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    private static void FillInSubdivisionsTW()
    {
        AddSubdivisions("TW",
        [
            new()
            { 
                Code = "CHA",
                Type = SubdivisionTypes.County,
                Name = "Changhua",
                LocalName = "Changhua"
            },
            new()
            { 
                Code = "CYQ",
                Type = SubdivisionTypes.County,
                Name = "Chiayi",
                LocalName = "Chiayi"
            },
            new()
            { 
                Code = "CYI",
                Type = SubdivisionTypes.City,
                Name = "Chiayi",
                LocalName = "Chiayi"
            },
            new()
            { 
                Code = "HSQ",
                Type = SubdivisionTypes.County,
                Name = "Hsinchu",
                LocalName = "Hsinchu"
            },
            new()
            { 
                Code = "HSZ",
                Type = SubdivisionTypes.City,
                Name = "Hsinchu",
                LocalName = "Hsinchu"
            },
            new()
            { 
                Code = "HUA",
                Type = SubdivisionTypes.County,
                Name = "Hualien",
                LocalName = "Hualien"
            },
            new()
            { 
                Code = "KHH",
                Type = SubdivisionTypes.Municipality,
                Name = "Kaohsiung",
                LocalName = "Kaohsiung"
            },
            new()
            { 
                Code = "KEE",
                Type = SubdivisionTypes.City,
                Name = "Keelung",
                LocalName = "Keelung"
            },
            new()
            { 
                Code = "KIN",
                Type = SubdivisionTypes.County,
                Name = "Kinmen",
                LocalName = "Kinmen"
            },
            new()
            { 
                Code = "LIE",
                Type = SubdivisionTypes.County,
                Name = "Lienchiang",
                LocalName = "Lienchiang"
            },
            new()
            { 
                Code = "MIA",
                Type = SubdivisionTypes.County,
                Name = "Miaoli",
                LocalName = "Miaoli"
            },
            new()
            { 
                Code = "NAN",
                Type = SubdivisionTypes.County,
                Name = "Nantou",
                LocalName = "Nantou"
            },
            new()
            { 
                Code = "NWT",
                Type = SubdivisionTypes.Municipality,
                Name = "New Taipei",
                LocalName = "New Taipei"
            },
            new()
            { 
                Code = "PEN",
                Type = SubdivisionTypes.County,
                Name = "Penghu",
                LocalName = "Penghu"
            },
            new()
            { 
                Code = "PIF",
                Type = SubdivisionTypes.County,
                Name = "Pingtung",
                LocalName = "Pingtung"
            },
            new()
            { 
                Code = "TXG",
                Type = SubdivisionTypes.Municipality,
                Name = "Taichung",
                LocalName = "Taichung"
            },
            new()
            { 
                Code = "TNN",
                Type = SubdivisionTypes.Municipality,
                Name = "Tainan",
                LocalName = "Tainan"
            },
            new()
            { 
                Code = "TPE",
                Type = SubdivisionTypes.Municipality,
                Name = "Taipei",
                LocalName = "Taipei"
            },
            new()
            { 
                Code = "TTT",
                Type = SubdivisionTypes.County,
                Name = "Taitung",
                LocalName = "Taitung"
            },
            new()
            { 
                Code = "TAO",
                Type = SubdivisionTypes.Municipality,
                Name = "Taoyuan",
                LocalName = "Taoyuan"
            },
            new()
            { 
                Code = "ILA",
                Type = SubdivisionTypes.County,
                Name = "Yilan",
                LocalName = "Yilan"
            },
            new()
            { 
                Code = "YUN",
                Type = SubdivisionTypes.County,
                Name = "Yunlin",
                LocalName = "Yunlin"
            }

        ]);
    }
}
