using AngryMonkey.Cloud.Geography;
namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    private static void FillInSubdivisionsMK()
    {
        AddSubdivisions("MK", new List<Subdivision>()
        {
            new()
            { 
                Code = "2",
                Type = "Municipality",
                Name = "Aracinovo",
                LocalName = "Арачиново"
            },
            new()
            { 
                Code = "3",
                Type = "Municipality",
                Name = "Berovo",
                LocalName = "Берово"
            },
            new()
            { 
                Code = "4",
                Type = "Municipality",
                Name = "Bitola",
                LocalName = "Битола"
            },
            new()
            { 
                Code = "5",
                Type = "Municipality",
                Name = "Bogdanci",
                LocalName = "Богданци"
            },
            new()
            { 
                Code = "6",
                Type = "Municipality",
                Name = "Bogovinje",
                LocalName = "Боговиње"
            },
            new()
            { 
                Code = "7",
                Type = "Municipality",
                Name = "Bosilovo",
                LocalName = "Босилово"
            },
            new()
            { 
                Code = "8",
                Type = "Municipality",
                Name = "Brvenica",
                LocalName = "Брвеница"
            },
            new()
            { 
                Code = "80",
                Type = "Municipality",
                Name = "Čaška",
                LocalName = "Чашка"
            },
            new()
            { 
                Code = "78",
                Type = "Municipality",
                Name = "Centar Župa",
                LocalName = "Центар Жупа"
            },
            new()
            { 
                Code = "81",
                Type = "Municipality",
                Name = "Češinovo-Obleševo ",
                LocalName = "Чешиново-Облешево"
            },
            new()
            { 
                Code = "82",
                Type = "Municipality",
                Name = "Čučer-Sandevo",
                LocalName = "Чучер Сандево"
            },
            new()
            { 
                Code = "21",
                Type = "Municipality",
                Name = "Debar",
                LocalName = "Дебар"
            },
            new()
            { 
                Code = "22",
                Type = "Municipality",
                Name = "Debarca",
                LocalName = "Дебарца"
            },
            new()
            { 
                Code = "23",
                Type = "Municipality",
                Name = "Delčevo",
                LocalName = "Делчево"
            },
            new()
            { 
                Code = "25",
                Type = "Municipality",
                Name = "Demir Hisar",
                LocalName = "Демир Хисар"
            },
            new()
            { 
                Code = "24",
                Type = "Municipality",
                Name = "Demir Kapija",
                LocalName = "Демир Капија"
            },
            new()
            { 
                Code = "26",
                Type = "Municipality",
                Name = "Dojran",
                LocalName = "Дојран"
            },
            new()
            { 
                Code = "27",
                Type = "Municipality",
                Name = "Dolneni",
                LocalName = "Долнени"
            },
            new()
            { 
                Code = "18",
                Type = "Municipality",
                Name = "Gevgelija",
                LocalName = "Гевгелија"
            },
            new()
            { 
                Code = "19",
                Type = "Municipality",
                Name = "Gostivar",
                LocalName = "Гостивар"
            },
            new()
            { 
                Code = "20",
                Type = "Municipality",
                Name = "Gradsko",
                LocalName = "Градско"
            },
            new()
            { 
                Code = "34",
                Type = "Municipality",
                Name = "Ilinden",
                LocalName = "Илинден"
            },
            new()
            { 
                Code = "35",
                Type = "Municipality",
                Name = "Jegunovce",
                LocalName = "Jegunovce"
            },
            new()
            { 
                Code = "37",
                Type = "Municipality",
                Name = "Karbinci",
                LocalName = "Карбинци"
            },
            new()
            { 
                Code = "36",
                Type = "Municipality",
                Name = "Kavadarci",
                LocalName = "Кавадарци"
            },
            new()
            { 
                Code = "40",
                Type = "Municipality",
                Name = "Kicevo",
                LocalName = "Кичево"
            },
            new()
            { 
                Code = "42",
                Type = "Municipality",
                Name = "Kocani",
                LocalName = "Кочани"
            },
            new()
            { 
                Code = "41",
                Type = "Municipality",
                Name = "Konce",
                LocalName = "Конче"
            },
            new()
            { 
                Code = "43",
                Type = "Municipality",
                Name = "Kratovo",
                LocalName = "Кратово"
            },
            new()
            { 
                Code = "44",
                Type = "Municipality",
                Name = "Kriva Palanka",
                LocalName = "Крива Паланка"
            },
            new()
            { 
                Code = "45",
                Type = "Municipality",
                Name = "Krivogatani",
                LocalName = "Кривогаштани"
            },
            new()
            { 
                Code = "46",
                Type = "Municipality",
                Name = "Kruševo",
                LocalName = "Крушево"
            },
            new()
            { 
                Code = "47",
                Type = "Municipality",
                Name = "Kumanovo",
                LocalName = "Куманово"
            },
            new()
            { 
                Code = "48",
                Type = "Municipality",
                Name = "Lipkovo",
                LocalName = "Липково"
            },
            new()
            { 
                Code = "49",
                Type = "Municipality",
                Name = "Lozovo",
                LocalName = "Лозово"
            },
            new()
            { 
                Code = "51",
                Type = "Municipality",
                Name = "Makedonska Kamenica",
                LocalName = "Македонска Каменица"
            },
            new()
            { 
                Code = "52",
                Type = "Municipality",
                Name = "Makedonski Brod",
                LocalName = "Македонски Брод"
            },
            new()
            { 
                Code = "50",
                Type = "Municipality",
                Name = "Mavrovo and Rostuša",
                LocalName = "Маврово и Ростуша"
            },
            new()
            { 
                Code = "53",
                Type = "Municipality",
                Name = "Mogila",
                LocalName = "Могила"
            },
            new()
            { 
                Code = "54",
                Type = "Municipality",
                Name = "Negotino",
                LocalName = "Неготино"
            },
            new()
            { 
                Code = "55",
                Type = "Municipality",
                Name = "Novaci",
                LocalName = "Новаци"
            },
            new()
            { 
                Code = "56",
                Type = "Municipality",
                Name = "Novo Selo",
                LocalName = "Ново Село"
            },
            new()
            { 
                Code = "58",
                Type = "Municipality",
                Name = "Ohrid",
                LocalName = "Охрид"
            },
            new()
            { 
                Code = "60",
                Type = "Municipality",
                Name = "Pehcevo",
                LocalName = "Пехчево"
            },
            new()
            { 
                Code = "59",
                Type = "Municipality",
                Name = "Petrovec",
                LocalName = "Петровец"
            },
            new()
            { 
                Code = "61",
                Type = "Municipality",
                Name = "Plasnica",
                LocalName = "Пласница"
            },
            new()
            { 
                Code = "62",
                Type = "Municipality",
                Name = "Prilep",
                LocalName = "Пласница"
            },
            new()
            { 
                Code = "63",
                Type = "Municipality",
                Name = "Probištip",
                LocalName = "Пробиштип"
            },
            new()
            { 
                Code = "64",
                Type = "Municipality",
                Name = "Radoviš",
                LocalName = "Радовиш"
            },
            new()
            { 
                Code = "65",
                Type = "Municipality",
                Name = "Rankovce",
                LocalName = "Ранковце"
            },
            new()
            { 
                Code = "66",
                Type = "Municipality",
                Name = "Resen",
                LocalName = "Ресен"
            },
            new()
            { 
                Code = "67",
                Type = "Municipality",
                Name = "Rosoman",
                LocalName = "Ресен"
            },
            new()
            { 
                Code = "85",
                Type = "Municipality",
                Name = "Skopje",
                LocalName = "Скопски"
            },
            new()
            { 
                Code = "70",
                Type = "Municipality",
                Name = "Sopište",
                LocalName = "Сопиште"
            },
            new()
            { 
                Code = "71",
                Type = "Municipality",
                Name = "Staro Nagoričane",
                LocalName = "Старо Нагоричане"
            },
            new()
            { 
                Code = "83",
                Type = "Municipality",
                Name = "Štip",
                LocalName = "Штип"
            },
            new()
            { 
                Code = "72",
                Type = "Municipality",
                Name = "Struga",
                LocalName = "Струга"
            },
            new()
            { 
                Code = "73",
                Type = "Municipality",
                Name = "Strumica",
                LocalName = "Струмица"
            },
            new()
            { 
                Code = "74",
                Type = "Municipality",
                Name = "Studenicani",
                LocalName = "Студеничани"
            },
            new()
            { 
                Code = "69",
                Type = "Municipality",
                Name = "Sveti Nikole",
                LocalName = "Свети Николе"
            },
            new()
            { 
                Code = "75",
                Type = "Municipality",
                Name = "Tearce",
                LocalName = "Теарце"
            },
            new()
            { 
                Code = "76",
                Type = "Municipality",
                Name = "Tetovo",
                LocalName = "Тетово"
            },
            new()
            { 
                Code = "10",
                Type = "Municipality",
                Name = "Valandovo",
                LocalName = "Валандово"
            },
            new()
            { 
                Code = "11",
                Type = "Municipality",
                Name = "Vasilevo",
                LocalName = "Василево"
            },
            new()
            { 
                Code = "13",
                Type = "Municipality",
                Name = "Veles",
                LocalName = "Велес"
            },
            new()
            { 
                Code = "12",
                Type = "Municipality",
                Name = "Vevcani",
                LocalName = "Вевчани"
            },
            new()
            { 
                Code = "14",
                Type = "Municipality",
                Name = "Vinica",
                LocalName = "Виница"
            },
            new()
            { 
                Code = "16",
                Type = "Municipality",
                Name = "Vrapcite",
                LocalName = "Врапчиште"
            },
            new()
            { 
                Code = "32",
                Type = "Municipality",
                Name = "Zelenikovo",
                LocalName = "Зелениково"
            },
            new()
            { 
                Code = "30",
                Type = "Municipality",
                Name = "Želino",
                LocalName = "Желино"
            },
            new()
            { 
                Code = "33",
                Type = "Municipality",
                Name = "Zrnovci",
                LocalName = "Зрновци"
            }

        });
    }
}
