using AngryMonkey.Cloud.Geography;
namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    private static void FillInSubdivisionsTZ()
    {
        AddSubdivisions("TZ",
        [
            new()
            { 
                Code = "1",
                Type = SubdivisionTypes.Region,
                Name = "Arusha",
                LocalName = "Arusha"
            },
            new()
            { 
                Code = "2",
                Type = SubdivisionTypes.Region,
                Name = "Dar es Salaam",
                LocalName = "Dar es Salaam"
            },
            new()
            { 
                Code = "3",
                Type = SubdivisionTypes.Region,
                Name = "Dodoma",
                LocalName = "Dodoma"
            },
            new()
            { 
                Code = "27",
                Type = SubdivisionTypes.Region,
                Name = "Geita",
                LocalName = "Geita"
            },
            new()
            { 
                Code = "4",
                Type = SubdivisionTypes.Region,
                Name = "Iringa",
                LocalName = "Iringa"
            },
            new()
            { 
                Code = "5",
                Type = SubdivisionTypes.Region,
                Name = "Kagera",
                LocalName = "Kagera"
            },
            new()
            { 
                Code = "6",
                Type = SubdivisionTypes.Region,
                Name = "Kaskazini Pemba",
                LocalName = "Kaskazini Pemba"
            },
            new()
            { 
                Code = "7",
                Type = SubdivisionTypes.Region,
                Name = "Kaskazini Unguja",
                LocalName = "Kaskazini Unguja"
            },
            new()
            { 
                Code = "28",
                Type = SubdivisionTypes.Region,
                Name = "Katavi",
                LocalName = "Katavi"
            },
            new()
            { 
                Code = "8",
                Type = SubdivisionTypes.Region,
                Name = "Kigoma",
                LocalName = "Kigoma"
            },
            new()
            { 
                Code = "9",
                Type = SubdivisionTypes.Region,
                Name = "Kilimanjaro",
                LocalName = "Kilimanjaro"
            },
            new()
            { 
                Code = "10",
                Type = SubdivisionTypes.Region,
                Name = "Kusini Pemba",
                LocalName = "Kusini Pemba"
            },
            new()
            { 
                Code = "11",
                Type = SubdivisionTypes.Region,
                Name = "Kusini Unguja",
                LocalName = "Kusini Unguja"
            },
            new()
            { 
                Code = "12",
                Type = SubdivisionTypes.Region,
                Name = "Lindi",
                LocalName = "Lindi"
            },
            new()
            { 
                Code = "26",
                Type = SubdivisionTypes.Region,
                Name = "Manyara",
                LocalName = "Manyara"
            },
            new()
            { 
                Code = "13",
                Type = SubdivisionTypes.Region,
                Name = "Mara",
                LocalName = "Mara"
            },
            new()
            { 
                Code = "14",
                Type = SubdivisionTypes.Region,
                Name = "Mbeya",
                LocalName = "Mbeya"
            },
            new()
            { 
                Code = "15",
                Type = SubdivisionTypes.Region,
                Name = "Mjini Magharibi",
                LocalName = "Mjini Magharibi"
            },
            new()
            { 
                Code = "16",
                Type = SubdivisionTypes.Region,
                Name = "Morogoro",
                LocalName = "Morogoro"
            },
            new()
            { 
                Code = "17",
                Type = SubdivisionTypes.Region,
                Name = "Mtwara",
                LocalName = "Mtwara"
            },
            new()
            { 
                Code = "18",
                Type = SubdivisionTypes.Region,
                Name = "Mwanza",
                LocalName = "Mwanza"
            },
            new()
            { 
                Code = "29",
                Type = SubdivisionTypes.Region,
                Name = "Njombe",
                LocalName = "Njombe"
            },
            new()
            { 
                Code = "19",
                Type = SubdivisionTypes.Region,
                Name = "Pwani",
                LocalName = "Pwani"
            },
            new()
            { 
                Code = "20",
                Type = SubdivisionTypes.Region,
                Name = "Rukwa",
                LocalName = "Rukwa"
            },
            new()
            { 
                Code = "21",
                Type = SubdivisionTypes.Region,
                Name = "Ruvuma",
                LocalName = "Ruvuma"
            },
            new()
            { 
                Code = "22",
                Type = SubdivisionTypes.Region,
                Name = "Shinyanga",
                LocalName = "Shinyanga"
            },
            new()
            { 
                Code = "30",
                Type = SubdivisionTypes.Region,
                Name = "Simiyu",
                LocalName = "Simiyu"
            },
            new()
            { 
                Code = "23",
                Type = SubdivisionTypes.Region,
                Name = "Singida",
                LocalName = "Singida"
            },
            new()
            { 
                Code = "24",
                Type = SubdivisionTypes.Region,
                Name = "Tabora",
                LocalName = "Tabora"
            },
            new()
            { 
                Code = "25",
                Type = SubdivisionTypes.Region,
                Name = "Tanga",
                LocalName = "Tanga"
            }

        ]);
    }
}
