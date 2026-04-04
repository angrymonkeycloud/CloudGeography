using AngryMonkey.Cloud.Geography;
namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    private static void FillInSubdivisionsIR()
    {
        AddSubdivisions("IR",
        [
            new()
            { 
                Code = "32",
                Type = SubdivisionTypes.Province,
                Name = "Alborz",
                LocalName = "البرز"
            },
            new()
            { 
                Code = "3",
                Type = SubdivisionTypes.Province,
                Name = "Ardabil",
                LocalName = "اردبیل"
            },
            new()
            { 
                Code = "6",
                Type = SubdivisionTypes.Province,
                Name = "Bushehr",
                LocalName = "بوشهر"
            },
            new()
            { 
                Code = "8",
                Type = SubdivisionTypes.Province,
                Name = "Chahar Mahaal and Bakhtiari",
                LocalName = "چهارمحال و بختیاری"
            },
            new()
            { 
                Code = "1",
                Type = SubdivisionTypes.Province,
                Name = "East Azerbaijan",
                LocalName = "آذربایجان شرقی"
            },
            new()
            { 
                Code = "14",
                Type = SubdivisionTypes.Province,
                Name = "Fars",
                LocalName = "پارس"
            },
            new()
            { 
                Code = "19",
                Type = SubdivisionTypes.Province,
                Name = "Gilan",
                LocalName = "گیلان"
            },
            new()
            { 
                Code = "27",
                Type = SubdivisionTypes.Province,
                Name = "Golestan",
                LocalName = "گلستان"
            },
            new()
            { 
                Code = "24",
                Type = SubdivisionTypes.Province,
                Name = "Hamadan",
                LocalName = "همدان"
            },
            new()
            { 
                Code = "23",
                Type = SubdivisionTypes.Province,
                Name = "Hormozgan",
                LocalName = "هرمزگان"
            },
            new()
            { 
                Code = "5",
                Type = SubdivisionTypes.Province,
                Name = "Ilam",
                LocalName = "ایلام"
            },
            new()
            { 
                Code = "4",
                Type = SubdivisionTypes.Province,
                Name = "Isfahan",
                LocalName = "اصفهان"
            },
            new()
            { 
                Code = "15",
                Type = SubdivisionTypes.Province,
                Name = "Kerman",
                LocalName = "کرمان"
            },
            new()
            { 
                Code = "17",
                Type = SubdivisionTypes.Province,
                Name = "Kermanshah",
                LocalName = "کرمانشاه"
            },
            new()
            { 
                Code = "10",
                Type = SubdivisionTypes.Province,
                Name = "Khuzestan",
                LocalName = "خوزستان"
            },
            new()
            { 
                Code = "18",
                Type = SubdivisionTypes.Province,
                Name = "Kohgiluyeh and Boyer-Ahmad ",
                LocalName = " کهگیلویه و بویراحمد"
            },
            new()
            { 
                Code = "16",
                Type = SubdivisionTypes.Province,
                Name = "Kordestan",
                LocalName = "کردستان"
            },
            new()
            { 
                Code = "20",
                Type = SubdivisionTypes.Province,
                Name = "Lorestan",
                LocalName = "لرستان"
            },
            new()
            { 
                Code = "22",
                Type = SubdivisionTypes.Province,
                Name = "Markazi",
                LocalName = "مرکزی"
            },
            new()
            { 
                Code = "21",
                Type = SubdivisionTypes.Province,
                Name = "Mazandaran",
                LocalName = "مازندران"
            },
            new()
            { 
                Code = "31",
                Type = SubdivisionTypes.Province,
                Name = "North Khorasan",
                LocalName = "خراسان شمالی"
            },
            new()
            { 
                Code = "28",
                Type = SubdivisionTypes.Province,
                Name = "Qazvin",
                LocalName = "قزوین"
            },
            new()
            { 
                Code = "26",
                Type = SubdivisionTypes.Province,
                Name = "Qom",
                LocalName = "قم"
            },
            new()
            { 
                Code = "30",
                Type = SubdivisionTypes.Province,
                Name = "Razavi Khorasan",
                LocalName = "خراسان رضوی"
            },
            new()
            { 
                Code = "12",
                Type = SubdivisionTypes.Province,
                Name = "Semnan",
                LocalName = "سمنان"
            },
            new()
            { 
                Code = "13",
                Type = SubdivisionTypes.Province,
                Name = "Sistan va Baluchestan",
                LocalName = "سیستان و بلوچستان"
            },
            new()
            { 
                Code = "29",
                Type = SubdivisionTypes.Province,
                Name = "South Khorasan",
                LocalName = "خراسان جنوبی"
            },
            new()
            { 
                Code = "7",
                Type = SubdivisionTypes.Province,
                Name = "Tehran",
                LocalName = "تهران"
            },
            new()
            { 
                Code = "2",
                Type = SubdivisionTypes.Province,
                Name = "West Azerbaijan",
                LocalName = "آذربایجان غربی"
            },
            new()
            { 
                Code = "25",
                Type = SubdivisionTypes.Province,
                Name = "Yazd",
                LocalName = "یزد"
            },
            new()
            { 
                Code = "11",
                Type = SubdivisionTypes.Province,
                Name = "Zanjan",
                LocalName = "زنجان"
            }

        ]);
    }
}
