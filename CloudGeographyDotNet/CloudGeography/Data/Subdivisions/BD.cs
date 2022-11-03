using AngryMonkey.Cloud.Geography;
namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    private static void FillInSubdivisionsBD()
    {
        AddSubdivisions("BD", new List<Subdivision>()
        {
            new()
            { 
                Code = "5",
                Type = "District",
                Name = "Bagerhat",
                LocalName = "Bagerhat"
            },
            new()
            { 
                Code = "1",
                Type = "District",
                Name = "Bandarban",
                LocalName = "Bandarban"
            },
            new()
            { 
                Code = "2",
                Type = "District",
                Name = "Barguna",
                LocalName = "Barguna"
            },
            new()
            { 
                Code = "6",
                Type = "District",
                Name = "Barisal",
                LocalName = "Barisal"
            },
            new()
            { 
                Code = "7",
                Type = "District",
                Name = "Bhola",
                LocalName = "Bhola"
            },
            new()
            { 
                Code = "3",
                Type = "District",
                Name = "Bogra",
                LocalName = "Bogra"
            },
            new()
            { 
                Code = "4",
                Type = "District",
                Name = "Brahmanbaria",
                LocalName = "Brahmanbaria"
            },
            new()
            { 
                Code = "9",
                Type = "District",
                Name = "Chandpur",
                LocalName = "Chandpur"
            },
            new()
            { 
                Code = "45",
                Type = "District",
                Name = "Chapai Nawabganj",
                LocalName = "Chapai Nawabganj"
            },
            new()
            { 
                Code = "10",
                Type = "District",
                Name = "Chittagong",
                LocalName = "Chittagong"
            },
            new()
            { 
                Code = "12",
                Type = "District",
                Name = "Chuadanga",
                LocalName = "Chuadanga"
            },
            new()
            { 
                Code = "8",
                Type = "District",
                Name = "Comilla",
                LocalName = "Comilla"
            },
            new()
            { 
                Code = "11",
                Type = "District",
                Name = "Cox's Bazar",
                LocalName = "Cox's Bazar"
            },
            new()
            { 
                Code = "13",
                Type = "District",
                Name = "Dhaka",
                LocalName = "Dhaka"
            },
            new()
            { 
                Code = "14",
                Type = "District",
                Name = "Dinajpur",
                LocalName = "Dinajpur"
            },
            new()
            { 
                Code = "15",
                Type = "District",
                Name = "Faridpur",
                LocalName = "Faridpur"
            },
            new()
            { 
                Code = "16",
                Type = "District",
                Name = "Feni",
                LocalName = "Feni"
            },
            new()
            { 
                Code = "19",
                Type = "District",
                Name = "Gaibandha",
                LocalName = "Gaibandha"
            },
            new()
            { 
                Code = "18",
                Type = "District",
                Name = "Gazipur",
                LocalName = "Gazipur"
            },
            new()
            { 
                Code = "17",
                Type = "District",
                Name = "Gopalganj",
                LocalName = "Gopalganj"
            },
            new()
            { 
                Code = "20",
                Type = "District",
                Name = "Habiganj",
                LocalName = "Habiganj"
            },
            new()
            { 
                Code = "21",
                Type = "District",
                Name = "Jamalpur",
                LocalName = "Jamalpur"
            },
            new()
            { 
                Code = "22",
                Type = "District",
                Name = "Jessore",
                LocalName = "Jessore"
            },
            new()
            { 
                Code = "25",
                Type = "District",
                Name = "Jhalakathi",
                LocalName = "Jhalakathi"
            },
            new()
            { 
                Code = "23",
                Type = "District",
                Name = "Jhenaidah",
                LocalName = "Jhenaidah"
            },
            new()
            { 
                Code = "24",
                Type = "District",
                Name = "Joypurhat",
                LocalName = "Joypurhat"
            },
            new()
            { 
                Code = "29",
                Type = "District",
                Name = "Khagrachhari",
                LocalName = "Khagrachhari"
            },
            new()
            { 
                Code = "27",
                Type = "District",
                Name = "Khulna",
                LocalName = "Khulna"
            },
            new()
            { 
                Code = "26",
                Type = "District",
                Name = "Kishoreganj",
                LocalName = "Kishoreganj"
            },
            new()
            { 
                Code = "28",
                Type = "District",
                Name = "Kurigram",
                LocalName = "Kurigram"
            },
            new()
            { 
                Code = "30",
                Type = "District",
                Name = "Kushtia",
                LocalName = "Kushtia"
            },
            new()
            { 
                Code = "31",
                Type = "District",
                Name = "Lakshmipur",
                LocalName = "Lakshmipur"
            },
            new()
            { 
                Code = "32",
                Type = "District",
                Name = "Lalmonirhat",
                LocalName = "Lalmonirhat"
            },
            new()
            { 
                Code = "36",
                Type = "District",
                Name = "Madaripur",
                LocalName = "Madaripur"
            },
            new()
            { 
                Code = "37",
                Type = "District",
                Name = "Magura",
                LocalName = "Magura"
            },
            new()
            { 
                Code = "33",
                Type = "District",
                Name = "Manikganj",
                LocalName = "Manikganj"
            },
            new()
            { 
                Code = "39",
                Type = "District",
                Name = "Meherpur",
                LocalName = "Meherpur"
            },
            new()
            { 
                Code = "38",
                Type = "District",
                Name = "Moulvibazar",
                LocalName = "Moulvibazar"
            },
            new()
            { 
                Code = "35",
                Type = "District",
                Name = "Munshiganj",
                LocalName = "Munshiganj"
            },
            new()
            { 
                Code = "34",
                Type = "District",
                Name = "Mymensingh",
                LocalName = "Mymensingh"
            },
            new()
            { 
                Code = "48",
                Type = "District",
                Name = "Naogaon",
                LocalName = "Naogaon"
            },
            new()
            { 
                Code = "43",
                Type = "District",
                Name = "Narail",
                LocalName = "Narail"
            },
            new()
            { 
                Code = "40",
                Type = "District",
                Name = "Narayanganj",
                LocalName = "Narayanganj"
            },
            new()
            { 
                Code = "42",
                Type = "District",
                Name = "Narsingdi",
                LocalName = "Narsingdi"
            },
            new()
            { 
                Code = "44",
                Type = "District",
                Name = "Natore",
                LocalName = "Natore"
            },
            new()
            { 
                Code = "41",
                Type = "District",
                Name = "Netrakona",
                LocalName = "Netrakona"
            },
            new()
            { 
                Code = "46",
                Type = "District",
                Name = "Nilphamari",
                LocalName = "Nilphamari"
            },
            new()
            { 
                Code = "47",
                Type = "District",
                Name = "Noakhali",
                LocalName = "Noakhali"
            },
            new()
            { 
                Code = "49",
                Type = "District",
                Name = "Pabna",
                LocalName = "Pabna"
            },
            new()
            { 
                Code = "52",
                Type = "District",
                Name = "Panchagarh",
                LocalName = "Panchagarh"
            },
            new()
            { 
                Code = "51",
                Type = "District",
                Name = "Patuakhali",
                LocalName = "Patuakhali"
            },
            new()
            { 
                Code = "50",
                Type = "District",
                Name = "Pirojpur",
                LocalName = "Pirojpur"
            },
            new()
            { 
                Code = "53",
                Type = "District",
                Name = "Rajbari",
                LocalName = "Rajbari"
            },
            new()
            { 
                Code = "54",
                Type = "District",
                Name = "Rajshahi",
                LocalName = "Rajshahi"
            },
            new()
            { 
                Code = "56",
                Type = "District",
                Name = "Rangamati",
                LocalName = "Rangamati"
            },
            new()
            { 
                Code = "55",
                Type = "District",
                Name = "Rangpur",
                LocalName = "Rangpur"
            },
            new()
            { 
                Code = "58",
                Type = "District",
                Name = "Satkhira",
                LocalName = "Satkhira"
            },
            new()
            { 
                Code = "62",
                Type = "District",
                Name = "Shariatpur",
                LocalName = "Shariatpur"
            },
            new()
            { 
                Code = "57",
                Type = "District",
                Name = "Sherpur",
                LocalName = "Sherpur"
            },
            new()
            { 
                Code = "59",
                Type = "District",
                Name = "Sirajganj",
                LocalName = "Sirajganj"
            },
            new()
            { 
                Code = "61",
                Type = "District",
                Name = "Sunamganj",
                LocalName = "Sunamganj"
            },
            new()
            { 
                Code = "60",
                Type = "District",
                Name = "Sylhet",
                LocalName = "Sylhet"
            },
            new()
            { 
                Code = "63",
                Type = "District",
                Name = "Tangail",
                LocalName = "Tangail"
            },
            new()
            { 
                Code = "64",
                Type = "District",
                Name = "Thakurgaon",
                LocalName = "Thakurgaon"
            }

        });
    }
}
