using AngryMonkey.Cloud.Geography;
namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    private static void FillInSubdivisionsVN()
    {
        AddSubdivisions("VN",
        [
            new()
            { 
                Code = "44",
                Type = SubdivisionTypes.Province,
                Name = "An Giang",
                LocalName = "An Giang"
            },
            new()
            { 
                Code = "54",
                Type = SubdivisionTypes.Province,
                Name = "B?c Giang",
                LocalName = "B?c Giang"
            },
            new()
            { 
                Code = "53",
                Type = SubdivisionTypes.Province,
                Name = "B?c K?n",
                LocalName = "B?c K?n"
            },
            new()
            { 
                Code = "55",
                Type = SubdivisionTypes.Province,
                Name = "B?c Liêu",
                LocalName = "B?c Liêu"
            },
            new()
            { 
                Code = "56",
                Type = SubdivisionTypes.Province,
                Name = "B?c Ninh",
                LocalName = "B?c Ninh"
            },
            new()
            { 
                Code = "50",
                Type = SubdivisionTypes.Province,
                Name = "B?n Tre",
                LocalName = "B?n Tre"
            },
            new()
            { 
                Code = "43",
                Type = SubdivisionTypes.Province,
                Name = "Bà R?a - Vung Tàu",
                LocalName = "Bà R?a - Vung Tàu"
            },
            new()
            { 
                Code = "31",
                Type = SubdivisionTypes.Province,
                Name = "Bình Ð?nh",
                LocalName = "Bình Ð?nh"
            },
            new()
            { 
                Code = "57",
                Type = SubdivisionTypes.Province,
                Name = "Bình Duong",
                LocalName = "Bình Duong"
            },
            new()
            { 
                Code = "58",
                Type = SubdivisionTypes.Province,
                Name = "Bình Phu?c",
                LocalName = "Bình Phu?c"
            },
            new()
            { 
                Code = "40",
                Type = SubdivisionTypes.Province,
                Name = "Bình Thu?n",
                LocalName = "Bình Thu?n"
            },
            new()
            { 
                Code = "59",
                Type = SubdivisionTypes.Province,
                Name = "Cà Mau",
                LocalName = "Cà Mau"
            },
            new()
            { 
                Code = "CT",
                Type = SubdivisionTypes.Municipality,
                Name = "Can Tho",
                LocalName = "Can Tho"
            },
            new()
            { 
                Code = "4",
                Type = SubdivisionTypes.Province,
                Name = "Cao B?ng",
                LocalName = "Cao B?ng"
            },
            new()
            { 
                Code = "33",
                Type = SubdivisionTypes.Province,
                Name = "Ð?k L?k",
                LocalName = "Ð?k L?k"
            },
            new()
            { 
                Code = "72",
                Type = SubdivisionTypes.Province,
                Name = "Ð?k Nông",
                LocalName = "Ð?k Nông"
            },
            new()
            { 
                Code = "39",
                Type = SubdivisionTypes.Province,
                Name = "Ð?ng Nai",
                LocalName = "Ð?ng Nai"
            },
            new()
            { 
                Code = "45",
                Type = SubdivisionTypes.Province,
                Name = "Ð?ng Tháp",
                LocalName = "Ð?ng Tháp"
            },
            new()
            { 
                Code = "DN",
                Type = SubdivisionTypes.Municipality,
                Name = "Da Nang",
                LocalName = "Da Nang"
            },
            new()
            { 
                Code = "71",
                Type = SubdivisionTypes.Province,
                Name = "Ði?n Biên",
                LocalName = "Ði?n Biên"
            },
            new()
            { 
                Code = "30",
                Type = SubdivisionTypes.Province,
                Name = "Gia Lai",
                LocalName = "Gia Lai"
            },
            new()
            { 
                Code = "61",
                Type = SubdivisionTypes.Province,
                Name = "H?i Duong",
                LocalName = "H?i Duong"
            },
            new()
            { 
                Code = "73",
                Type = SubdivisionTypes.Province,
                Name = "H?u Giang",
                LocalName = "H?u Giang"
            },
            new()
            { 
                Code = "3",
                Type = SubdivisionTypes.Province,
                Name = "Hà Giang",
                LocalName = "Hà Giang"
            },
            new()
            { 
                Code = "63",
                Type = SubdivisionTypes.Province,
                Name = "Hà Nam",
                LocalName = "Hà Nam"
            },
            new()
            { 
                Code = "HN",
                Type = SubdivisionTypes.Municipality,
                Name = "Ha Noi",
                LocalName = "Ha Noi"
            },
            new()
            { 
                Code = "23",
                Type = SubdivisionTypes.Province,
                Name = "Hà Tinh",
                LocalName = "Hà Tinh"
            },
            new()
            { 
                Code = "HP",
                Type = SubdivisionTypes.Municipality,
                Name = "Hai Phong",
                LocalName = "Hai Phong"
            },
            new()
            { 
                Code = "SG",
                Type = SubdivisionTypes.Municipality,
                Name = "Ho Chi Minh",
                LocalName = "Ho Chi Minh"
            },
            new()
            { 
                Code = "14",
                Type = SubdivisionTypes.Province,
                Name = "Hòa Bình",
                LocalName = "Hòa Bình"
            },
            new()
            { 
                Code = "66",
                Type = SubdivisionTypes.Province,
                Name = "Hung Yên",
                LocalName = "Hung Yên"
            },
            new()
            { 
                Code = "34",
                Type = SubdivisionTypes.Province,
                Name = "Khánh Hòa",
                LocalName = "Khánh Hòa"
            },
            new()
            { 
                Code = "47",
                Type = SubdivisionTypes.Province,
                Name = "Ki?n Giang",
                LocalName = "Ki?n Giang"
            },
            new()
            { 
                Code = "28",
                Type = SubdivisionTypes.Province,
                Name = "Kon Tum",
                LocalName = "Kon Tum"
            },
            new()
            { 
                Code = "9",
                Type = SubdivisionTypes.Province,
                Name = "L?ng Son",
                LocalName = "L?ng Son"
            },
            new()
            { 
                Code = "1",
                Type = SubdivisionTypes.Province,
                Name = "Lai Châu",
                LocalName = "Lai Châu"
            },
            new()
            { 
                Code = "35",
                Type = SubdivisionTypes.Province,
                Name = "Lâm Ð?ng",
                LocalName = "Lâm Ð?ng"
            },
            new()
            { 
                Code = "2",
                Type = SubdivisionTypes.Province,
                Name = "Lào Cai",
                LocalName = "Lào Cai"
            },
            new()
            { 
                Code = "41",
                Type = SubdivisionTypes.Province,
                Name = "Long An",
                LocalName = "Long An"
            },
            new()
            { 
                Code = "67",
                Type = SubdivisionTypes.Province,
                Name = "Nam Ð?nh",
                LocalName = "Nam Ð?nh"
            },
            new()
            { 
                Code = "22",
                Type = SubdivisionTypes.Province,
                Name = "Ngh? An",
                LocalName = "Ngh? An"
            },
            new()
            { 
                Code = "18",
                Type = SubdivisionTypes.Province,
                Name = "Ninh Bình",
                LocalName = "Ninh Bình"
            },
            new()
            { 
                Code = "36",
                Type = SubdivisionTypes.Province,
                Name = "Ninh Thu?n",
                LocalName = "Ninh Thu?n"
            },
            new()
            { 
                Code = "68",
                Type = SubdivisionTypes.Province,
                Name = "Phú Th?",
                LocalName = "Phú Th?"
            },
            new()
            { 
                Code = "32",
                Type = SubdivisionTypes.Province,
                Name = "Phú Yên",
                LocalName = "Phú Yên"
            },
            new()
            { 
                Code = "24",
                Type = SubdivisionTypes.Province,
                Name = "Qu?ng Bình",
                LocalName = "Qu?ng Bình"
            },
            new()
            { 
                Code = "27",
                Type = SubdivisionTypes.Province,
                Name = "Qu?ng Nam",
                LocalName = "Qu?ng Nam"
            },
            new()
            { 
                Code = "29",
                Type = SubdivisionTypes.Province,
                Name = "Qu?ng Ngãi",
                LocalName = "Qu?ng Ngãi"
            },
            new()
            { 
                Code = "13",
                Type = SubdivisionTypes.Province,
                Name = "Qu?ng Ninh",
                LocalName = "Qu?ng Ninh"
            },
            new()
            { 
                Code = "25",
                Type = SubdivisionTypes.Province,
                Name = "Qu?ng Tr?",
                LocalName = "Qu?ng Tr?"
            },
            new()
            { 
                Code = "52",
                Type = SubdivisionTypes.Province,
                Name = "Sóc Trang",
                LocalName = "Sóc Trang"
            },
            new()
            { 
                Code = "5",
                Type = SubdivisionTypes.Province,
                Name = "Son La",
                LocalName = "Son La"
            },
            new()
            { 
                Code = "37",
                Type = SubdivisionTypes.Province,
                Name = "Tây Ninh",
                LocalName = "Tây Ninh"
            },
            new()
            { 
                Code = "26",
                Type = SubdivisionTypes.Province,
                Name = "Th?a Thiên-Hu?",
                LocalName = "Th?a Thiên-Hu?"
            },
            new()
            { 
                Code = "20",
                Type = SubdivisionTypes.Province,
                Name = "Thái Bình",
                LocalName = "Thái Bình"
            },
            new()
            { 
                Code = "69",
                Type = SubdivisionTypes.Province,
                Name = "Thái Nguyên",
                LocalName = "Thái Nguyên"
            },
            new()
            { 
                Code = "21",
                Type = SubdivisionTypes.Province,
                Name = "Thanh Hóa",
                LocalName = "Thanh Hóa"
            },
            new()
            { 
                Code = "46",
                Type = SubdivisionTypes.Province,
                Name = "Ti?n Giang",
                LocalName = "Ti?n Giang"
            },
            new()
            { 
                Code = "51",
                Type = SubdivisionTypes.Province,
                Name = "Trà Vinh",
                LocalName = "Trà Vinh"
            },
            new()
            { 
                Code = "7",
                Type = SubdivisionTypes.Province,
                Name = "Tuyên Quang",
                LocalName = "Tuyên Quang"
            },
            new()
            { 
                Code = "49",
                Type = SubdivisionTypes.Province,
                Name = "Vinh Long",
                LocalName = "Vinh Long"
            },
            new()
            { 
                Code = "70",
                Type = SubdivisionTypes.Province,
                Name = "Vinh Phúc",
                LocalName = "Vinh Phúc"
            },
            new()
            { 
                Code = "6",
                Type = SubdivisionTypes.Province,
                Name = "Yên Bái",
                LocalName = "Yên Bái"
            }

        ]);
    }
}
