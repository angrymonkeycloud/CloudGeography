using AngryMonkey.Cloud.Geography;
namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    private static void FillInSubdivisionsBG()
    {
        AddSubdivisions("BG",
        [
            new()
            { 
                Code = "1",
                Type = SubdivisionTypes.Province,
                Name = "Blagoevgrad",
                LocalName = "Благоевград"
            },
            new()
            { 
                Code = "2",
                Type = SubdivisionTypes.Province,
                Name = "Burgas",
                LocalName = "Бургас"
            },
            new()
            { 
                Code = "8",
                Type = SubdivisionTypes.Province,
                Name = "Dobrich",
                LocalName = "Добрич"
            },
            new()
            { 
                Code = "7",
                Type = SubdivisionTypes.Province,
                Name = "Gabrovo",
                LocalName = "Габрово"
            },
            new()
            { 
                Code = "26",
                Type = SubdivisionTypes.Province,
                Name = "Haskovo",
                LocalName = "Хасково"
            },
            new()
            { 
                Code = "9",
                Type = SubdivisionTypes.Province,
                Name = "Kardzhali",
                LocalName = "Кърджали"
            },
            new()
            { 
                Code = "10",
                Type = SubdivisionTypes.Province,
                Name = "Kyustendil",
                LocalName = "Кюстендил"
            },
            new()
            { 
                Code = "11",
                Type = SubdivisionTypes.Province,
                Name = "Lovech",
                LocalName = "Ловеч"
            },
            new()
            { 
                Code = "12",
                Type = SubdivisionTypes.Province,
                Name = "Montana",
                LocalName = "Монтана"
            },
            new()
            { 
                Code = "13",
                Type = SubdivisionTypes.Province,
                Name = "Pazardzik",
                LocalName = "Пазарджик"
            },
            new()
            { 
                Code = "14",
                Type = SubdivisionTypes.Province,
                Name = "Pernik",
                LocalName = "Перник"
            },
            new()
            { 
                Code = "15",
                Type = SubdivisionTypes.Province,
                Name = "Pleven",
                LocalName = "Плевен"
            },
            new()
            { 
                Code = "16",
                Type = SubdivisionTypes.Province,
                Name = "Plovdiv",
                LocalName = "Пловдив"
            },
            new()
            { 
                Code = "17",
                Type = SubdivisionTypes.Province,
                Name = "Razgrad",
                LocalName = "Разград"
            },
            new()
            { 
                Code = "18",
                Type = SubdivisionTypes.Province,
                Name = "Ruse",
                LocalName = "Русе"
            },
            new()
            { 
                Code = "27",
                Type = SubdivisionTypes.Province,
                Name = "Shumen",
                LocalName = "Шумен"
            },
            new()
            { 
                Code = "19",
                Type = SubdivisionTypes.Province,
                Name = "Silistra",
                LocalName = "Шумен"
            },
            new()
            { 
                Code = "20",
                Type = SubdivisionTypes.Province,
                Name = "Sliven",
                LocalName = "Сливен"
            },
            new()
            { 
                Code = "21",
                Type = SubdivisionTypes.Province,
                Name = "Smolyan",
                LocalName = "Смолян"
            },
            new()
            { 
                Code = "23",
                Type = SubdivisionTypes.Province,
                Name = "Sofia",
                LocalName = "Софийска"
            },
            new()
            { 
                Code = "22",
                Type = SubdivisionTypes.Province,
                Name = "Sofia City",
                LocalName = "София-град"
            },
            new()
            { 
                Code = "24",
                Type = SubdivisionTypes.Province,
                Name = "Stara Zagora",
                LocalName = "Стара Загора"
            },
            new()
            { 
                Code = "25",
                Type = SubdivisionTypes.Province,
                Name = "Targovishte",
                LocalName = "Търговище"
            },
            new()
            { 
                Code = "3",
                Type = SubdivisionTypes.Province,
                Name = "Varna",
                LocalName = "Варна"
            },
            new()
            { 
                Code = "4",
                Type = SubdivisionTypes.Province,
                Name = "Veliko Tarnovo",
                LocalName = "Велико Търново"
            },
            new()
            { 
                Code = "5",
                Type = SubdivisionTypes.Province,
                Name = "Vidin",
                LocalName = "Видин"
            },
            new()
            { 
                Code = "6",
                Type = SubdivisionTypes.Province,
                Name = "Vratsa",
                LocalName = "Враца"
            },
            new()
            { 
                Code = "28",
                Type = SubdivisionTypes.Province,
                Name = "Yambol",
                LocalName = "Ямбол"
            }

        ]);
    }
}
