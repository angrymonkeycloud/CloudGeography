using AngryMonkey.Cloud.Geography;
namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    private static void FillInSubdivisionsJP()
    {
        AddSubdivisions("JP", new List<Subdivision>()
        {
            new()
            { 
                Code = "23",
                Type = "Prefecture",
                Name = "Aiti",
                LocalName = "Aiti"
            },
            new()
            { 
                Code = "5",
                Type = "Prefecture",
                Name = "Akita",
                LocalName = "Akita"
            },
            new()
            { 
                Code = "2",
                Type = "Prefecture",
                Name = "Aomori",
                LocalName = "Aomori"
            },
            new()
            { 
                Code = "38",
                Type = "Prefecture",
                Name = "Ehime",
                LocalName = "Ehime"
            },
            new()
            { 
                Code = "21",
                Type = "Prefecture",
                Name = "Gihu",
                LocalName = "Gihu"
            },
            new()
            { 
                Code = "10",
                Type = "Prefecture",
                Name = "Gunma",
                LocalName = "Gunma"
            },
            new()
            { 
                Code = "34",
                Type = "Prefecture",
                Name = "Hirosima",
                LocalName = "Hirosima"
            },
            new()
            { 
                Code = "1",
                Type = "Prefecture",
                Name = "Hokkaidô",
                LocalName = "Hokkaidô"
            },
            new()
            { 
                Code = "18",
                Type = "Prefecture",
                Name = "Hukui",
                LocalName = "Hukui"
            },
            new()
            { 
                Code = "40",
                Type = "Prefecture",
                Name = "Hukuoka",
                LocalName = "Hukuoka"
            },
            new()
            { 
                Code = "7",
                Type = "Prefecture",
                Name = "Hukusima",
                LocalName = "Hukusima"
            },
            new()
            { 
                Code = "26",
                Type = "Prefecture",
                Name = "Hyôgo",
                LocalName = "Hyôgo"
            },
            new()
            { 
                Code = "28",
                Type = "Prefecture",
                Name = "Hyôgo",
                LocalName = "Hyôgo"
            },
            new()
            { 
                Code = "8",
                Type = "Prefecture",
                Name = "Ibaraki",
                LocalName = "Ibaraki"
            },
            new()
            { 
                Code = "17",
                Type = "Prefecture",
                Name = "Isikawa",
                LocalName = "Isikawa"
            },
            new()
            { 
                Code = "3",
                Type = "Prefecture",
                Name = "Iwate",
                LocalName = "Iwate"
            },
            new()
            { 
                Code = "37",
                Type = "Prefecture",
                Name = "Kagawa",
                LocalName = "Kagawa"
            },
            new()
            { 
                Code = "46",
                Type = "Prefecture",
                Name = "Kagosima",
                LocalName = "Kagosima"
            },
            new()
            { 
                Code = "14",
                Type = "Prefecture",
                Name = "Kanagawa",
                LocalName = "Kanagawa"
            },
            new()
            { 
                Code = "39",
                Type = "Prefecture",
                Name = "Kôti",
                LocalName = "Kôti"
            },
            new()
            { 
                Code = "43",
                Type = "Prefecture",
                Name = "Kumamoto",
                LocalName = "Kumamoto"
            },
            new()
            { 
                Code = "24",
                Type = "Prefecture",
                Name = "Mie",
                LocalName = "Mie"
            },
            new()
            { 
                Code = "4",
                Type = "Prefecture",
                Name = "Miyagi",
                LocalName = "Miyagi"
            },
            new()
            { 
                Code = "45",
                Type = "Prefecture",
                Name = "Miyazaki",
                LocalName = "Miyazaki"
            },
            new()
            { 
                Code = "20",
                Type = "Prefecture",
                Name = "Nagano",
                LocalName = "Nagano"
            },
            new()
            { 
                Code = "42",
                Type = "Prefecture",
                Name = "Nagasaki",
                LocalName = "Nagasaki"
            },
            new()
            { 
                Code = "29",
                Type = "Prefecture",
                Name = "Nara",
                LocalName = "Nara"
            },
            new()
            { 
                Code = "15",
                Type = "Prefecture",
                Name = "Niigata",
                LocalName = "Niigata"
            },
            new()
            { 
                Code = "44",
                Type = "Prefecture",
                Name = "Ôita",
                LocalName = "Ôita"
            },
            new()
            { 
                Code = "33",
                Type = "Prefecture",
                Name = "Okayama",
                LocalName = "Okayama"
            },
            new()
            { 
                Code = "47",
                Type = "Prefecture",
                Name = "Okinawa",
                LocalName = "Okinawa"
            },
            new()
            { 
                Code = "27",
                Type = "Prefecture",
                Name = "Ôsaka",
                LocalName = "Ôsaka"
            },
            new()
            { 
                Code = "41",
                Type = "Prefecture",
                Name = "Saga",
                LocalName = "Saga"
            },
            new()
            { 
                Code = "11",
                Type = "Prefecture",
                Name = "Saitama",
                LocalName = "Saitama"
            },
            new()
            { 
                Code = "25",
                Type = "Prefecture",
                Name = "Siga",
                LocalName = "Siga"
            },
            new()
            { 
                Code = "32",
                Type = "Prefecture",
                Name = "Simane",
                LocalName = "Simane"
            },
            new()
            { 
                Code = "22",
                Type = "Prefecture",
                Name = "Sizuoka",
                LocalName = "Sizuoka"
            },
            new()
            { 
                Code = "12",
                Type = "Prefecture",
                Name = "Tiba",
                LocalName = "Tiba"
            },
            new()
            { 
                Code = "36",
                Type = "Prefecture",
                Name = "Tokusima",
                LocalName = "Tokusima"
            },
            new()
            { 
                Code = "13",
                Type = "Prefecture",
                Name = "Tôkyô",
                LocalName = "Tôkyô"
            },
            new()
            { 
                Code = "9",
                Type = "Prefecture",
                Name = "Totigi",
                LocalName = "Totigi"
            },
            new()
            { 
                Code = "31",
                Type = "Prefecture",
                Name = "Tottori",
                LocalName = "Tottori"
            },
            new()
            { 
                Code = "16",
                Type = "Prefecture",
                Name = "Toyama",
                LocalName = "Toyama"
            },
            new()
            { 
                Code = "30",
                Type = "Prefecture",
                Name = "Wakayama",
                LocalName = "Wakayama"
            },
            new()
            { 
                Code = "6",
                Type = "Prefecture",
                Name = "Yamagata",
                LocalName = "Yamagata"
            },
            new()
            { 
                Code = "35",
                Type = "Prefecture",
                Name = "Yamaguti",
                LocalName = "Yamaguti"
            },
            new()
            { 
                Code = "19",
                Type = "Prefecture",
                Name = "Yamanasi",
                LocalName = "Yamanasi"
            }

        });
    }
}
