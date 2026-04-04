using AngryMonkey.Cloud.Geography;
namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    private static void FillInSubdivisionsMK()
    {
        AddSubdivisions("MK",
        [
            new()
            { 
                Code = "2",
                Type = SubdivisionTypes.Municipality,
                Name = "Aracinovo",
                LocalName = "Арачиново"
            },
            new()
            { 
                Code = "3",
                Type = SubdivisionTypes.Municipality,
                Name = "Berovo",
                LocalName = "Берово"
            },
            new()
            { 
                Code = "4",
                Type = SubdivisionTypes.Municipality,
                Name = "Bitola",
                LocalName = "Битола"
            },
            new()
            { 
                Code = "5",
                Type = SubdivisionTypes.Municipality,
                Name = "Bogdanci",
                LocalName = "Богданци"
            },
            new()
            { 
                Code = "6",
                Type = SubdivisionTypes.Municipality,
                Name = "Bogovinje",
                LocalName = "Боговиње"
            },
            new()
            { 
                Code = "7",
                Type = SubdivisionTypes.Municipality,
                Name = "Bosilovo",
                LocalName = "Босилово"
            },
            new()
            { 
                Code = "8",
                Type = SubdivisionTypes.Municipality,
                Name = "Brvenica",
                LocalName = "Брвеница"
            },
            new()
            { 
                Code = "80",
                Type = SubdivisionTypes.Municipality,
                Name = "Čaška",
                LocalName = "Чашка"
            },
            new()
            { 
                Code = "78",
                Type = SubdivisionTypes.Municipality,
                Name = "Centar Župa",
                LocalName = "Центар Жупа"
            },
            new()
            { 
                Code = "81",
                Type = SubdivisionTypes.Municipality,
                Name = "Češinovo-Obleševo ",
                LocalName = "Чешиново-Облешево"
            },
            new()
            { 
                Code = "82",
                Type = SubdivisionTypes.Municipality,
                Name = "Čučer-Sandevo",
                LocalName = "Чучер Сандево"
            },
            new()
            { 
                Code = "21",
                Type = SubdivisionTypes.Municipality,
                Name = "Debar",
                LocalName = "Дебар"
            },
            new()
            { 
                Code = "22",
                Type = SubdivisionTypes.Municipality,
                Name = "Debarca",
                LocalName = "Дебарца"
            },
            new()
            { 
                Code = "23",
                Type = SubdivisionTypes.Municipality,
                Name = "Delčevo",
                LocalName = "Делчево"
            },
            new()
            { 
                Code = "25",
                Type = SubdivisionTypes.Municipality,
                Name = "Demir Hisar",
                LocalName = "Демир Хисар"
            },
            new()
            { 
                Code = "24",
                Type = SubdivisionTypes.Municipality,
                Name = "Demir Kapija",
                LocalName = "Демир Капија"
            },
            new()
            { 
                Code = "26",
                Type = SubdivisionTypes.Municipality,
                Name = "Dojran",
                LocalName = "Дојран"
            },
            new()
            { 
                Code = "27",
                Type = SubdivisionTypes.Municipality,
                Name = "Dolneni",
                LocalName = "Долнени"
            },
            new()
            { 
                Code = "18",
                Type = SubdivisionTypes.Municipality,
                Name = "Gevgelija",
                LocalName = "Гевгелија"
            },
            new()
            { 
                Code = "19",
                Type = SubdivisionTypes.Municipality,
                Name = "Gostivar",
                LocalName = "Гостивар"
            },
            new()
            { 
                Code = "20",
                Type = SubdivisionTypes.Municipality,
                Name = "Gradsko",
                LocalName = "Градско"
            },
            new()
            { 
                Code = "34",
                Type = SubdivisionTypes.Municipality,
                Name = "Ilinden",
                LocalName = "Илинден"
            },
            new()
            { 
                Code = "35",
                Type = SubdivisionTypes.Municipality,
                Name = "Jegunovce",
                LocalName = "Jegunovce"
            },
            new()
            { 
                Code = "37",
                Type = SubdivisionTypes.Municipality,
                Name = "Karbinci",
                LocalName = "Карбинци"
            },
            new()
            { 
                Code = "36",
                Type = SubdivisionTypes.Municipality,
                Name = "Kavadarci",
                LocalName = "Кавадарци"
            },
            new()
            { 
                Code = "40",
                Type = SubdivisionTypes.Municipality,
                Name = "Kicevo",
                LocalName = "Кичево"
            },
            new()
            { 
                Code = "42",
                Type = SubdivisionTypes.Municipality,
                Name = "Kocani",
                LocalName = "Кочани"
            },
            new()
            { 
                Code = "41",
                Type = SubdivisionTypes.Municipality,
                Name = "Konce",
                LocalName = "Конче"
            },
            new()
            { 
                Code = "43",
                Type = SubdivisionTypes.Municipality,
                Name = "Kratovo",
                LocalName = "Кратово"
            },
            new()
            { 
                Code = "44",
                Type = SubdivisionTypes.Municipality,
                Name = "Kriva Palanka",
                LocalName = "Крива Паланка"
            },
            new()
            { 
                Code = "45",
                Type = SubdivisionTypes.Municipality,
                Name = "Krivogatani",
                LocalName = "Кривогаштани"
            },
            new()
            { 
                Code = "46",
                Type = SubdivisionTypes.Municipality,
                Name = "Kruševo",
                LocalName = "Крушево"
            },
            new()
            { 
                Code = "47",
                Type = SubdivisionTypes.Municipality,
                Name = "Kumanovo",
                LocalName = "Куманово"
            },
            new()
            { 
                Code = "48",
                Type = SubdivisionTypes.Municipality,
                Name = "Lipkovo",
                LocalName = "Липково"
            },
            new()
            { 
                Code = "49",
                Type = SubdivisionTypes.Municipality,
                Name = "Lozovo",
                LocalName = "Лозово"
            },
            new()
            { 
                Code = "51",
                Type = SubdivisionTypes.Municipality,
                Name = "Makedonska Kamenica",
                LocalName = "Македонска Каменица"
            },
            new()
            { 
                Code = "52",
                Type = SubdivisionTypes.Municipality,
                Name = "Makedonski Brod",
                LocalName = "Македонски Брод"
            },
            new()
            { 
                Code = "50",
                Type = SubdivisionTypes.Municipality,
                Name = "Mavrovo and Rostuša",
                LocalName = "Маврово и Ростуша"
            },
            new()
            { 
                Code = "53",
                Type = SubdivisionTypes.Municipality,
                Name = "Mogila",
                LocalName = "Могила"
            },
            new()
            { 
                Code = "54",
                Type = SubdivisionTypes.Municipality,
                Name = "Negotino",
                LocalName = "Неготино"
            },
            new()
            { 
                Code = "55",
                Type = SubdivisionTypes.Municipality,
                Name = "Novaci",
                LocalName = "Новаци"
            },
            new()
            { 
                Code = "56",
                Type = SubdivisionTypes.Municipality,
                Name = "Novo Selo",
                LocalName = "Ново Село"
            },
            new()
            { 
                Code = "58",
                Type = SubdivisionTypes.Municipality,
                Name = "Ohrid",
                LocalName = "Охрид"
            },
            new()
            { 
                Code = "60",
                Type = SubdivisionTypes.Municipality,
                Name = "Pehcevo",
                LocalName = "Пехчево"
            },
            new()
            { 
                Code = "59",
                Type = SubdivisionTypes.Municipality,
                Name = "Petrovec",
                LocalName = "Петровец"
            },
            new()
            { 
                Code = "61",
                Type = SubdivisionTypes.Municipality,
                Name = "Plasnica",
                LocalName = "Пласница"
            },
            new()
            { 
                Code = "62",
                Type = SubdivisionTypes.Municipality,
                Name = "Prilep",
                LocalName = "Пласница"
            },
            new()
            { 
                Code = "63",
                Type = SubdivisionTypes.Municipality,
                Name = "Probištip",
                LocalName = "Пробиштип"
            },
            new()
            { 
                Code = "64",
                Type = SubdivisionTypes.Municipality,
                Name = "Radoviš",
                LocalName = "Радовиш"
            },
            new()
            { 
                Code = "65",
                Type = SubdivisionTypes.Municipality,
                Name = "Rankovce",
                LocalName = "Ранковце"
            },
            new()
            { 
                Code = "66",
                Type = SubdivisionTypes.Municipality,
                Name = "Resen",
                LocalName = "Ресен"
            },
            new()
            { 
                Code = "67",
                Type = SubdivisionTypes.Municipality,
                Name = "Rosoman",
                LocalName = "Ресен"
            },
            new()
            { 
                Code = "85",
                Type = SubdivisionTypes.Municipality,
                Name = "Skopje",
                LocalName = "Скопски"
            },
            new()
            { 
                Code = "70",
                Type = SubdivisionTypes.Municipality,
                Name = "Sopište",
                LocalName = "Сопиште"
            },
            new()
            { 
                Code = "71",
                Type = SubdivisionTypes.Municipality,
                Name = "Staro Nagoričane",
                LocalName = "Старо Нагоричане"
            },
            new()
            { 
                Code = "83",
                Type = SubdivisionTypes.Municipality,
                Name = "Štip",
                LocalName = "Штип"
            },
            new()
            { 
                Code = "72",
                Type = SubdivisionTypes.Municipality,
                Name = "Struga",
                LocalName = "Струга"
            },
            new()
            { 
                Code = "73",
                Type = SubdivisionTypes.Municipality,
                Name = "Strumica",
                LocalName = "Струмица"
            },
            new()
            { 
                Code = "74",
                Type = SubdivisionTypes.Municipality,
                Name = "Studenicani",
                LocalName = "Студеничани"
            },
            new()
            { 
                Code = "69",
                Type = SubdivisionTypes.Municipality,
                Name = "Sveti Nikole",
                LocalName = "Свети Николе"
            },
            new()
            { 
                Code = "75",
                Type = SubdivisionTypes.Municipality,
                Name = "Tearce",
                LocalName = "Теарце"
            },
            new()
            { 
                Code = "76",
                Type = SubdivisionTypes.Municipality,
                Name = "Tetovo",
                LocalName = "Тетово"
            },
            new()
            { 
                Code = "10",
                Type = SubdivisionTypes.Municipality,
                Name = "Valandovo",
                LocalName = "Валандово"
            },
            new()
            { 
                Code = "11",
                Type = SubdivisionTypes.Municipality,
                Name = "Vasilevo",
                LocalName = "Василево"
            },
            new()
            { 
                Code = "13",
                Type = SubdivisionTypes.Municipality,
                Name = "Veles",
                LocalName = "Велес"
            },
            new()
            { 
                Code = "12",
                Type = SubdivisionTypes.Municipality,
                Name = "Vevcani",
                LocalName = "Вевчани"
            },
            new()
            { 
                Code = "14",
                Type = SubdivisionTypes.Municipality,
                Name = "Vinica",
                LocalName = "Виница"
            },
            new()
            { 
                Code = "16",
                Type = SubdivisionTypes.Municipality,
                Name = "Vrapcite",
                LocalName = "Врапчиште"
            },
            new()
            { 
                Code = "32",
                Type = SubdivisionTypes.Municipality,
                Name = "Zelenikovo",
                LocalName = "Зелениково"
            },
            new()
            { 
                Code = "30",
                Type = SubdivisionTypes.Municipality,
                Name = "Želino",
                LocalName = "Желино"
            },
            new()
            { 
                Code = "33",
                Type = SubdivisionTypes.Municipality,
                Name = "Zrnovci",
                LocalName = "Зрновци"
            }

        ]);
    }
}
