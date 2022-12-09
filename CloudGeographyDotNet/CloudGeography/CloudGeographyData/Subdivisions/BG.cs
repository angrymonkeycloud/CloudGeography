using AngryMonkey.Cloud.Geography;
namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    private static void FillInSubdivisionsBG()
    {
        AddSubdivisions("BG", new List<Subdivision>()
        {
            new()
            { 
                Code = "1",
                Type = "Province",
                Name = "Blagoevgrad",
                LocalName = "Благоевград"
            },
            new()
            { 
                Code = "2",
                Type = "Province",
                Name = "Burgas",
                LocalName = "Бургас"
            },
            new()
            { 
                Code = "8",
                Type = "Province",
                Name = "Dobrich",
                LocalName = "Добрич"
            },
            new()
            { 
                Code = "7",
                Type = "Province",
                Name = "Gabrovo",
                LocalName = "Габрово"
            },
            new()
            { 
                Code = "26",
                Type = "Province",
                Name = "Haskovo",
                LocalName = "Хасково"
            },
            new()
            { 
                Code = "9",
                Type = "Province",
                Name = "Kardzhali",
                LocalName = "Кърджали"
            },
            new()
            { 
                Code = "10",
                Type = "Province",
                Name = "Kyustendil",
                LocalName = "Кюстендил"
            },
            new()
            { 
                Code = "11",
                Type = "Province",
                Name = "Lovech",
                LocalName = "Ловеч"
            },
            new()
            { 
                Code = "12",
                Type = "Province",
                Name = "Montana",
                LocalName = "Монтана"
            },
            new()
            { 
                Code = "13",
                Type = "Province",
                Name = "Pazardzik",
                LocalName = "Пазарджик"
            },
            new()
            { 
                Code = "14",
                Type = "Province",
                Name = "Pernik",
                LocalName = "Перник"
            },
            new()
            { 
                Code = "15",
                Type = "Province",
                Name = "Pleven",
                LocalName = "Плевен"
            },
            new()
            { 
                Code = "16",
                Type = "Province",
                Name = "Plovdiv",
                LocalName = "Пловдив"
            },
            new()
            { 
                Code = "17",
                Type = "Province",
                Name = "Razgrad",
                LocalName = "Разград"
            },
            new()
            { 
                Code = "18",
                Type = "Province",
                Name = "Ruse",
                LocalName = "Русе"
            },
            new()
            { 
                Code = "27",
                Type = "Province",
                Name = "Shumen",
                LocalName = "Шумен"
            },
            new()
            { 
                Code = "19",
                Type = "Province",
                Name = "Silistra",
                LocalName = "Шумен"
            },
            new()
            { 
                Code = "20",
                Type = "Province",
                Name = "Sliven",
                LocalName = "Сливен"
            },
            new()
            { 
                Code = "21",
                Type = "Province",
                Name = "Smolyan",
                LocalName = "Смолян"
            },
            new()
            { 
                Code = "23",
                Type = "Province",
                Name = "Sofia",
                LocalName = "Софийска"
            },
            new()
            { 
                Code = "22",
                Type = "Province",
                Name = "Sofia City",
                LocalName = "София-град"
            },
            new()
            { 
                Code = "24",
                Type = "Province",
                Name = "Stara Zagora",
                LocalName = "Стара Загора"
            },
            new()
            { 
                Code = "25",
                Type = "Province",
                Name = "Targovishte",
                LocalName = "Търговище"
            },
            new()
            { 
                Code = "3",
                Type = "Province",
                Name = "Varna",
                LocalName = "Варна"
            },
            new()
            { 
                Code = "4",
                Type = "Province",
                Name = "Veliko Tarnovo",
                LocalName = "Велико Търново"
            },
            new()
            { 
                Code = "5",
                Type = "Province",
                Name = "Vidin",
                LocalName = "Видин"
            },
            new()
            { 
                Code = "6",
                Type = "Province",
                Name = "Vratsa",
                LocalName = "Враца"
            },
            new()
            { 
                Code = "28",
                Type = "Province",
                Name = "Yambol",
                LocalName = "Ямбол"
            }

        });
    }
}
