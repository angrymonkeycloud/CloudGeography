using AngryMonkey.Cloud.Geography;
namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    private static void FillInSubdivisionsNR()
    {
        AddSubdivisions("NR",
        [
            new()
            { 
                Code = "1",
                Type = SubdivisionTypes.District,
                Name = "Aiwo",
                LocalName = "Aiwo"
            },
            new()
            { 
                Code = "2",
                Type = SubdivisionTypes.District,
                Name = "Anabar",
                LocalName = "Anabar"
            },
            new()
            { 
                Code = "3",
                Type = SubdivisionTypes.District,
                Name = "Anetan",
                LocalName = "Anetan"
            },
            new()
            { 
                Code = "4",
                Type = SubdivisionTypes.District,
                Name = "Anibare",
                LocalName = "Anibare"
            },
            new()
            { 
                Code = "5",
                Type = SubdivisionTypes.District,
                Name = "Baiti",
                LocalName = "Baiti"
            },
            new()
            { 
                Code = "6",
                Type = SubdivisionTypes.District,
                Name = "Boe",
                LocalName = "Boe"
            },
            new()
            { 
                Code = "7",
                Type = SubdivisionTypes.District,
                Name = "Buada",
                LocalName = "Buada"
            },
            new()
            { 
                Code = "8",
                Type = SubdivisionTypes.District,
                Name = "Denigomodu",
                LocalName = "Denigomodu"
            },
            new()
            { 
                Code = "9",
                Type = SubdivisionTypes.District,
                Name = "Ewa",
                LocalName = "Ewa"
            },
            new()
            { 
                Code = "10",
                Type = SubdivisionTypes.District,
                Name = "Ijuw",
                LocalName = "Ijuw"
            },
            new()
            { 
                Code = "11",
                Type = SubdivisionTypes.District,
                Name = "Meneng",
                LocalName = "Meneng"
            },
            new()
            { 
                Code = "12",
                Type = SubdivisionTypes.District,
                Name = "Nibok",
                LocalName = "Nibok"
            },
            new()
            { 
                Code = "13",
                Type = SubdivisionTypes.District,
                Name = "Uaboe",
                LocalName = "Uaboe"
            },
            new()
            { 
                Code = "14",
                Type = SubdivisionTypes.District,
                Name = "Yaren",
                LocalName = "Yaren"
            }

        ]);
    }
}
