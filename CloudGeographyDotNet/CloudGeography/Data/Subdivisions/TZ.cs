using AngryMonkey.Cloud.Geography;
namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    private static void FillInSubdivisionsTZ()
    {
        AddSubdivisions("TZ", new List<Subdivision>()
        {
            new()
            { 
                Code = "1",
                Type = "Region",
                Name = "Arusha",
                LocalName = "Arusha"
            },
            new()
            { 
                Code = "2",
                Type = "Region",
                Name = "Dar es Salaam",
                LocalName = "Dar es Salaam"
            },
            new()
            { 
                Code = "3",
                Type = "Region",
                Name = "Dodoma",
                LocalName = "Dodoma"
            },
            new()
            { 
                Code = "27",
                Type = "Region",
                Name = "Geita",
                LocalName = "Geita"
            },
            new()
            { 
                Code = "4",
                Type = "Region",
                Name = "Iringa",
                LocalName = "Iringa"
            },
            new()
            { 
                Code = "5",
                Type = "Region",
                Name = "Kagera",
                LocalName = "Kagera"
            },
            new()
            { 
                Code = "6",
                Type = "Region",
                Name = "Kaskazini Pemba",
                LocalName = "Kaskazini Pemba"
            },
            new()
            { 
                Code = "7",
                Type = "Region",
                Name = "Kaskazini Unguja",
                LocalName = "Kaskazini Unguja"
            },
            new()
            { 
                Code = "28",
                Type = "Region",
                Name = "Katavi",
                LocalName = "Katavi"
            },
            new()
            { 
                Code = "8",
                Type = "Region",
                Name = "Kigoma",
                LocalName = "Kigoma"
            },
            new()
            { 
                Code = "9",
                Type = "Region",
                Name = "Kilimanjaro",
                LocalName = "Kilimanjaro"
            },
            new()
            { 
                Code = "10",
                Type = "Region",
                Name = "Kusini Pemba",
                LocalName = "Kusini Pemba"
            },
            new()
            { 
                Code = "11",
                Type = "Region",
                Name = "Kusini Unguja",
                LocalName = "Kusini Unguja"
            },
            new()
            { 
                Code = "12",
                Type = "Region",
                Name = "Lindi",
                LocalName = "Lindi"
            },
            new()
            { 
                Code = "26",
                Type = "Region",
                Name = "Manyara",
                LocalName = "Manyara"
            },
            new()
            { 
                Code = "13",
                Type = "Region",
                Name = "Mara",
                LocalName = "Mara"
            },
            new()
            { 
                Code = "14",
                Type = "Region",
                Name = "Mbeya",
                LocalName = "Mbeya"
            },
            new()
            { 
                Code = "15",
                Type = "Region",
                Name = "Mjini Magharibi",
                LocalName = "Mjini Magharibi"
            },
            new()
            { 
                Code = "16",
                Type = "Region",
                Name = "Morogoro",
                LocalName = "Morogoro"
            },
            new()
            { 
                Code = "17",
                Type = "Region",
                Name = "Mtwara",
                LocalName = "Mtwara"
            },
            new()
            { 
                Code = "18",
                Type = "Region",
                Name = "Mwanza",
                LocalName = "Mwanza"
            },
            new()
            { 
                Code = "29",
                Type = "Region",
                Name = "Njombe",
                LocalName = "Njombe"
            },
            new()
            { 
                Code = "19",
                Type = "Region",
                Name = "Pwani",
                LocalName = "Pwani"
            },
            new()
            { 
                Code = "20",
                Type = "Region",
                Name = "Rukwa",
                LocalName = "Rukwa"
            },
            new()
            { 
                Code = "21",
                Type = "Region",
                Name = "Ruvuma",
                LocalName = "Ruvuma"
            },
            new()
            { 
                Code = "22",
                Type = "Region",
                Name = "Shinyanga",
                LocalName = "Shinyanga"
            },
            new()
            { 
                Code = "30",
                Type = "Region",
                Name = "Simiyu",
                LocalName = "Simiyu"
            },
            new()
            { 
                Code = "23",
                Type = "Region",
                Name = "Singida",
                LocalName = "Singida"
            },
            new()
            { 
                Code = "24",
                Type = "Region",
                Name = "Tabora",
                LocalName = "Tabora"
            },
            new()
            { 
                Code = "25",
                Type = "Region",
                Name = "Tanga",
                LocalName = "Tanga"
            }

        });
    }
}
