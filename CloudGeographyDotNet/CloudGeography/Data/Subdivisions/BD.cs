using AngryMonkey.Cloud.Geography;
namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    private static void FillInSubdivisionsBD()
    {
        AddSubdivisions("BD",
        [
            new()
            { 
                Code = "5",
                Type = SubdivisionTypes.District,
                Name = "Bagerhat",
                LocalName = "Bagerhat"
            },
            new()
            { 
                Code = "1",
                Type = SubdivisionTypes.District,
                Name = "Bandarban",
                LocalName = "Bandarban"
            },
            new()
            { 
                Code = "2",
                Type = SubdivisionTypes.District,
                Name = "Barguna",
                LocalName = "Barguna"
            },
            new()
            { 
                Code = "6",
                Type = SubdivisionTypes.District,
                Name = "Barisal",
                LocalName = "Barisal"
            },
            new()
            { 
                Code = "7",
                Type = SubdivisionTypes.District,
                Name = "Bhola",
                LocalName = "Bhola"
            },
            new()
            { 
                Code = "3",
                Type = SubdivisionTypes.District,
                Name = "Bogra",
                LocalName = "Bogra"
            },
            new()
            { 
                Code = "4",
                Type = SubdivisionTypes.District,
                Name = "Brahmanbaria",
                LocalName = "Brahmanbaria"
            },
            new()
            { 
                Code = "9",
                Type = SubdivisionTypes.District,
                Name = "Chandpur",
                LocalName = "Chandpur"
            },
            new()
            { 
                Code = "45",
                Type = SubdivisionTypes.District,
                Name = "Chapai Nawabganj",
                LocalName = "Chapai Nawabganj"
            },
            new()
            { 
                Code = "10",
                Type = SubdivisionTypes.District,
                Name = "Chittagong",
                LocalName = "Chittagong"
            },
            new()
            { 
                Code = "12",
                Type = SubdivisionTypes.District,
                Name = "Chuadanga",
                LocalName = "Chuadanga"
            },
            new()
            { 
                Code = "8",
                Type = SubdivisionTypes.District,
                Name = "Comilla",
                LocalName = "Comilla"
            },
            new()
            { 
                Code = "11",
                Type = SubdivisionTypes.District,
                Name = "Cox's Bazar",
                LocalName = "Cox's Bazar"
            },
            new()
            { 
                Code = "13",
                Type = SubdivisionTypes.District,
                Name = "Dhaka",
                LocalName = "Dhaka"
            },
            new()
            { 
                Code = "14",
                Type = SubdivisionTypes.District,
                Name = "Dinajpur",
                LocalName = "Dinajpur"
            },
            new()
            { 
                Code = "15",
                Type = SubdivisionTypes.District,
                Name = "Faridpur",
                LocalName = "Faridpur"
            },
            new()
            { 
                Code = "16",
                Type = SubdivisionTypes.District,
                Name = "Feni",
                LocalName = "Feni"
            },
            new()
            { 
                Code = "19",
                Type = SubdivisionTypes.District,
                Name = "Gaibandha",
                LocalName = "Gaibandha"
            },
            new()
            { 
                Code = "18",
                Type = SubdivisionTypes.District,
                Name = "Gazipur",
                LocalName = "Gazipur"
            },
            new()
            { 
                Code = "17",
                Type = SubdivisionTypes.District,
                Name = "Gopalganj",
                LocalName = "Gopalganj"
            },
            new()
            { 
                Code = "20",
                Type = SubdivisionTypes.District,
                Name = "Habiganj",
                LocalName = "Habiganj"
            },
            new()
            { 
                Code = "21",
                Type = SubdivisionTypes.District,
                Name = "Jamalpur",
                LocalName = "Jamalpur"
            },
            new()
            { 
                Code = "22",
                Type = SubdivisionTypes.District,
                Name = "Jessore",
                LocalName = "Jessore"
            },
            new()
            { 
                Code = "25",
                Type = SubdivisionTypes.District,
                Name = "Jhalakathi",
                LocalName = "Jhalakathi"
            },
            new()
            { 
                Code = "23",
                Type = SubdivisionTypes.District,
                Name = "Jhenaidah",
                LocalName = "Jhenaidah"
            },
            new()
            { 
                Code = "24",
                Type = SubdivisionTypes.District,
                Name = "Joypurhat",
                LocalName = "Joypurhat"
            },
            new()
            { 
                Code = "29",
                Type = SubdivisionTypes.District,
                Name = "Khagrachhari",
                LocalName = "Khagrachhari"
            },
            new()
            { 
                Code = "27",
                Type = SubdivisionTypes.District,
                Name = "Khulna",
                LocalName = "Khulna"
            },
            new()
            { 
                Code = "26",
                Type = SubdivisionTypes.District,
                Name = "Kishoreganj",
                LocalName = "Kishoreganj"
            },
            new()
            { 
                Code = "28",
                Type = SubdivisionTypes.District,
                Name = "Kurigram",
                LocalName = "Kurigram"
            },
            new()
            { 
                Code = "30",
                Type = SubdivisionTypes.District,
                Name = "Kushtia",
                LocalName = "Kushtia"
            },
            new()
            { 
                Code = "31",
                Type = SubdivisionTypes.District,
                Name = "Lakshmipur",
                LocalName = "Lakshmipur"
            },
            new()
            { 
                Code = "32",
                Type = SubdivisionTypes.District,
                Name = "Lalmonirhat",
                LocalName = "Lalmonirhat"
            },
            new()
            { 
                Code = "36",
                Type = SubdivisionTypes.District,
                Name = "Madaripur",
                LocalName = "Madaripur"
            },
            new()
            { 
                Code = "37",
                Type = SubdivisionTypes.District,
                Name = "Magura",
                LocalName = "Magura"
            },
            new()
            { 
                Code = "33",
                Type = SubdivisionTypes.District,
                Name = "Manikganj",
                LocalName = "Manikganj"
            },
            new()
            { 
                Code = "39",
                Type = SubdivisionTypes.District,
                Name = "Meherpur",
                LocalName = "Meherpur"
            },
            new()
            { 
                Code = "38",
                Type = SubdivisionTypes.District,
                Name = "Moulvibazar",
                LocalName = "Moulvibazar"
            },
            new()
            { 
                Code = "35",
                Type = SubdivisionTypes.District,
                Name = "Munshiganj",
                LocalName = "Munshiganj"
            },
            new()
            { 
                Code = "34",
                Type = SubdivisionTypes.District,
                Name = "Mymensingh",
                LocalName = "Mymensingh"
            },
            new()
            { 
                Code = "48",
                Type = SubdivisionTypes.District,
                Name = "Naogaon",
                LocalName = "Naogaon"
            },
            new()
            { 
                Code = "43",
                Type = SubdivisionTypes.District,
                Name = "Narail",
                LocalName = "Narail"
            },
            new()
            { 
                Code = "40",
                Type = SubdivisionTypes.District,
                Name = "Narayanganj",
                LocalName = "Narayanganj"
            },
            new()
            { 
                Code = "42",
                Type = SubdivisionTypes.District,
                Name = "Narsingdi",
                LocalName = "Narsingdi"
            },
            new()
            { 
                Code = "44",
                Type = SubdivisionTypes.District,
                Name = "Natore",
                LocalName = "Natore"
            },
            new()
            { 
                Code = "41",
                Type = SubdivisionTypes.District,
                Name = "Netrakona",
                LocalName = "Netrakona"
            },
            new()
            { 
                Code = "46",
                Type = SubdivisionTypes.District,
                Name = "Nilphamari",
                LocalName = "Nilphamari"
            },
            new()
            { 
                Code = "47",
                Type = SubdivisionTypes.District,
                Name = "Noakhali",
                LocalName = "Noakhali"
            },
            new()
            { 
                Code = "49",
                Type = SubdivisionTypes.District,
                Name = "Pabna",
                LocalName = "Pabna"
            },
            new()
            { 
                Code = "52",
                Type = SubdivisionTypes.District,
                Name = "Panchagarh",
                LocalName = "Panchagarh"
            },
            new()
            { 
                Code = "51",
                Type = SubdivisionTypes.District,
                Name = "Patuakhali",
                LocalName = "Patuakhali"
            },
            new()
            { 
                Code = "50",
                Type = SubdivisionTypes.District,
                Name = "Pirojpur",
                LocalName = "Pirojpur"
            },
            new()
            { 
                Code = "53",
                Type = SubdivisionTypes.District,
                Name = "Rajbari",
                LocalName = "Rajbari"
            },
            new()
            { 
                Code = "54",
                Type = SubdivisionTypes.District,
                Name = "Rajshahi",
                LocalName = "Rajshahi"
            },
            new()
            { 
                Code = "56",
                Type = SubdivisionTypes.District,
                Name = "Rangamati",
                LocalName = "Rangamati"
            },
            new()
            { 
                Code = "55",
                Type = SubdivisionTypes.District,
                Name = "Rangpur",
                LocalName = "Rangpur"
            },
            new()
            { 
                Code = "58",
                Type = SubdivisionTypes.District,
                Name = "Satkhira",
                LocalName = "Satkhira"
            },
            new()
            { 
                Code = "62",
                Type = SubdivisionTypes.District,
                Name = "Shariatpur",
                LocalName = "Shariatpur"
            },
            new()
            { 
                Code = "57",
                Type = SubdivisionTypes.District,
                Name = "Sherpur",
                LocalName = "Sherpur"
            },
            new()
            { 
                Code = "59",
                Type = SubdivisionTypes.District,
                Name = "Sirajganj",
                LocalName = "Sirajganj"
            },
            new()
            { 
                Code = "61",
                Type = SubdivisionTypes.District,
                Name = "Sunamganj",
                LocalName = "Sunamganj"
            },
            new()
            { 
                Code = "60",
                Type = SubdivisionTypes.District,
                Name = "Sylhet",
                LocalName = "Sylhet"
            },
            new()
            { 
                Code = "63",
                Type = SubdivisionTypes.District,
                Name = "Tangail",
                LocalName = "Tangail"
            },
            new()
            { 
                Code = "64",
                Type = SubdivisionTypes.District,
                Name = "Thakurgaon",
                LocalName = "Thakurgaon"
            }

        ]);
    }
}
