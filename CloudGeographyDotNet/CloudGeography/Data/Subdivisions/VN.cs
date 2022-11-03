using AngryMonkey.Cloud.Geography;
namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    private static void FillInSubdivisionsVN()
    {
        AddSubdivisions("VN", new List<Subdivision>()
        {
            new()
            { 
                Code = "44",
                Type = "Province",
                Name = "An Giang",
                LocalName = "An Giang"
            },
            new()
            { 
                Code = "54",
                Type = "Province",
                Name = "B?c Giang",
                LocalName = "B?c Giang"
            },
            new()
            { 
                Code = "53",
                Type = "Province",
                Name = "B?c K?n",
                LocalName = "B?c K?n"
            },
            new()
            { 
                Code = "55",
                Type = "Province",
                Name = "B?c Liêu",
                LocalName = "B?c Liêu"
            },
            new()
            { 
                Code = "56",
                Type = "Province",
                Name = "B?c Ninh",
                LocalName = "B?c Ninh"
            },
            new()
            { 
                Code = "50",
                Type = "Province",
                Name = "B?n Tre",
                LocalName = "B?n Tre"
            },
            new()
            { 
                Code = "43",
                Type = "Province",
                Name = "Bà R?a - Vung Tàu",
                LocalName = "Bà R?a - Vung Tàu"
            },
            new()
            { 
                Code = "31",
                Type = "Province",
                Name = "Bình Ð?nh",
                LocalName = "Bình Ð?nh"
            },
            new()
            { 
                Code = "57",
                Type = "Province",
                Name = "Bình Duong",
                LocalName = "Bình Duong"
            },
            new()
            { 
                Code = "58",
                Type = "Province",
                Name = "Bình Phu?c",
                LocalName = "Bình Phu?c"
            },
            new()
            { 
                Code = "40",
                Type = "Province",
                Name = "Bình Thu?n",
                LocalName = "Bình Thu?n"
            },
            new()
            { 
                Code = "59",
                Type = "Province",
                Name = "Cà Mau",
                LocalName = "Cà Mau"
            },
            new()
            { 
                Code = "CT",
                Type = "Municipality",
                Name = "Can Tho",
                LocalName = "Can Tho"
            },
            new()
            { 
                Code = "4",
                Type = "Province",
                Name = "Cao B?ng",
                LocalName = "Cao B?ng"
            },
            new()
            { 
                Code = "33",
                Type = "Province",
                Name = "Ð?k L?k",
                LocalName = "Ð?k L?k"
            },
            new()
            { 
                Code = "72",
                Type = "Province",
                Name = "Ð?k Nông",
                LocalName = "Ð?k Nông"
            },
            new()
            { 
                Code = "39",
                Type = "Province",
                Name = "Ð?ng Nai",
                LocalName = "Ð?ng Nai"
            },
            new()
            { 
                Code = "45",
                Type = "Province",
                Name = "Ð?ng Tháp",
                LocalName = "Ð?ng Tháp"
            },
            new()
            { 
                Code = "DN",
                Type = "Municipality",
                Name = "Da Nang",
                LocalName = "Da Nang"
            },
            new()
            { 
                Code = "71",
                Type = "Province",
                Name = "Ði?n Biên",
                LocalName = "Ði?n Biên"
            },
            new()
            { 
                Code = "30",
                Type = "Province",
                Name = "Gia Lai",
                LocalName = "Gia Lai"
            },
            new()
            { 
                Code = "61",
                Type = "Province",
                Name = "H?i Duong",
                LocalName = "H?i Duong"
            },
            new()
            { 
                Code = "73",
                Type = "Province",
                Name = "H?u Giang",
                LocalName = "H?u Giang"
            },
            new()
            { 
                Code = "3",
                Type = "Province",
                Name = "Hà Giang",
                LocalName = "Hà Giang"
            },
            new()
            { 
                Code = "63",
                Type = "Province",
                Name = "Hà Nam",
                LocalName = "Hà Nam"
            },
            new()
            { 
                Code = "HN",
                Type = "Municipality",
                Name = "Ha Noi",
                LocalName = "Ha Noi"
            },
            new()
            { 
                Code = "23",
                Type = "Province",
                Name = "Hà Tinh",
                LocalName = "Hà Tinh"
            },
            new()
            { 
                Code = "HP",
                Type = "Municipality",
                Name = "Hai Phong",
                LocalName = "Hai Phong"
            },
            new()
            { 
                Code = "SG",
                Type = "Municipality",
                Name = "Ho Chi Minh",
                LocalName = "Ho Chi Minh"
            },
            new()
            { 
                Code = "14",
                Type = "Province",
                Name = "Hòa Bình",
                LocalName = "Hòa Bình"
            },
            new()
            { 
                Code = "66",
                Type = "Province",
                Name = "Hung Yên",
                LocalName = "Hung Yên"
            },
            new()
            { 
                Code = "34",
                Type = "Province",
                Name = "Khánh Hòa",
                LocalName = "Khánh Hòa"
            },
            new()
            { 
                Code = "47",
                Type = "Province",
                Name = "Ki?n Giang",
                LocalName = "Ki?n Giang"
            },
            new()
            { 
                Code = "28",
                Type = "Province",
                Name = "Kon Tum",
                LocalName = "Kon Tum"
            },
            new()
            { 
                Code = "9",
                Type = "Province",
                Name = "L?ng Son",
                LocalName = "L?ng Son"
            },
            new()
            { 
                Code = "1",
                Type = "Province",
                Name = "Lai Châu",
                LocalName = "Lai Châu"
            },
            new()
            { 
                Code = "35",
                Type = "Province",
                Name = "Lâm Ð?ng",
                LocalName = "Lâm Ð?ng"
            },
            new()
            { 
                Code = "2",
                Type = "Province",
                Name = "Lào Cai",
                LocalName = "Lào Cai"
            },
            new()
            { 
                Code = "41",
                Type = "Province",
                Name = "Long An",
                LocalName = "Long An"
            },
            new()
            { 
                Code = "67",
                Type = "Province",
                Name = "Nam Ð?nh",
                LocalName = "Nam Ð?nh"
            },
            new()
            { 
                Code = "22",
                Type = "Province",
                Name = "Ngh? An",
                LocalName = "Ngh? An"
            },
            new()
            { 
                Code = "18",
                Type = "Province",
                Name = "Ninh Bình",
                LocalName = "Ninh Bình"
            },
            new()
            { 
                Code = "36",
                Type = "Province",
                Name = "Ninh Thu?n",
                LocalName = "Ninh Thu?n"
            },
            new()
            { 
                Code = "68",
                Type = "Province",
                Name = "Phú Th?",
                LocalName = "Phú Th?"
            },
            new()
            { 
                Code = "32",
                Type = "Province",
                Name = "Phú Yên",
                LocalName = "Phú Yên"
            },
            new()
            { 
                Code = "24",
                Type = "Province",
                Name = "Qu?ng Bình",
                LocalName = "Qu?ng Bình"
            },
            new()
            { 
                Code = "27",
                Type = "Province",
                Name = "Qu?ng Nam",
                LocalName = "Qu?ng Nam"
            },
            new()
            { 
                Code = "29",
                Type = "Province",
                Name = "Qu?ng Ngãi",
                LocalName = "Qu?ng Ngãi"
            },
            new()
            { 
                Code = "13",
                Type = "Province",
                Name = "Qu?ng Ninh",
                LocalName = "Qu?ng Ninh"
            },
            new()
            { 
                Code = "25",
                Type = "Province",
                Name = "Qu?ng Tr?",
                LocalName = "Qu?ng Tr?"
            },
            new()
            { 
                Code = "52",
                Type = "Province",
                Name = "Sóc Trang",
                LocalName = "Sóc Trang"
            },
            new()
            { 
                Code = "5",
                Type = "Province",
                Name = "Son La",
                LocalName = "Son La"
            },
            new()
            { 
                Code = "37",
                Type = "Province",
                Name = "Tây Ninh",
                LocalName = "Tây Ninh"
            },
            new()
            { 
                Code = "26",
                Type = "Province",
                Name = "Th?a Thiên-Hu?",
                LocalName = "Th?a Thiên-Hu?"
            },
            new()
            { 
                Code = "20",
                Type = "Province",
                Name = "Thái Bình",
                LocalName = "Thái Bình"
            },
            new()
            { 
                Code = "69",
                Type = "Province",
                Name = "Thái Nguyên",
                LocalName = "Thái Nguyên"
            },
            new()
            { 
                Code = "21",
                Type = "Province",
                Name = "Thanh Hóa",
                LocalName = "Thanh Hóa"
            },
            new()
            { 
                Code = "46",
                Type = "Province",
                Name = "Ti?n Giang",
                LocalName = "Ti?n Giang"
            },
            new()
            { 
                Code = "51",
                Type = "Province",
                Name = "Trà Vinh",
                LocalName = "Trà Vinh"
            },
            new()
            { 
                Code = "7",
                Type = "Province",
                Name = "Tuyên Quang",
                LocalName = "Tuyên Quang"
            },
            new()
            { 
                Code = "49",
                Type = "Province",
                Name = "Vinh Long",
                LocalName = "Vinh Long"
            },
            new()
            { 
                Code = "70",
                Type = "Province",
                Name = "Vinh Phúc",
                LocalName = "Vinh Phúc"
            },
            new()
            { 
                Code = "6",
                Type = "Province",
                Name = "Yên Bái",
                LocalName = "Yên Bái"
            }

        });
    }
}
