using AngryMonkey.Cloud.Geography;
namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    private static void FillInSubdivisionsNR()
    {
        AddSubdivisions("NR", new List<Subdivision>()
        {
            new()
            { 
                Code = "1",
                Type = "District",
                Name = "Aiwo",
                LocalName = "Aiwo"
            },
            new()
            { 
                Code = "2",
                Type = "District",
                Name = "Anabar",
                LocalName = "Anabar"
            },
            new()
            { 
                Code = "3",
                Type = "District",
                Name = "Anetan",
                LocalName = "Anetan"
            },
            new()
            { 
                Code = "4",
                Type = "District",
                Name = "Anibare",
                LocalName = "Anibare"
            },
            new()
            { 
                Code = "5",
                Type = "District",
                Name = "Baiti",
                LocalName = "Baiti"
            },
            new()
            { 
                Code = "6",
                Type = "District",
                Name = "Boe",
                LocalName = "Boe"
            },
            new()
            { 
                Code = "7",
                Type = "District",
                Name = "Buada",
                LocalName = "Buada"
            },
            new()
            { 
                Code = "8",
                Type = "District",
                Name = "Denigomodu",
                LocalName = "Denigomodu"
            },
            new()
            { 
                Code = "9",
                Type = "District",
                Name = "Ewa",
                LocalName = "Ewa"
            },
            new()
            { 
                Code = "10",
                Type = "District",
                Name = "Ijuw",
                LocalName = "Ijuw"
            },
            new()
            { 
                Code = "11",
                Type = "District",
                Name = "Meneng",
                LocalName = "Meneng"
            },
            new()
            { 
                Code = "12",
                Type = "District",
                Name = "Nibok",
                LocalName = "Nibok"
            },
            new()
            { 
                Code = "13",
                Type = "District",
                Name = "Uaboe",
                LocalName = "Uaboe"
            },
            new()
            { 
                Code = "14",
                Type = "District",
                Name = "Yaren",
                LocalName = "Yaren"
            }

        });
    }
}
