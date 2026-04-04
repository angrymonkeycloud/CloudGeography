using AngryMonkey.Cloud.Geography;
namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    private static void FillInSubdivisionsMY()
    {
        AddSubdivisions("MY",
        [
            new()
            { 
                Code = "1",
                Type = SubdivisionTypes.State,
                Name = "Johor",
                LocalName = "Johor"
            },
            new()
            { 
                Code = "2",
                Type = SubdivisionTypes.State,
                Name = "Kedah",
                LocalName = "Kedah"
            },
            new()
            { 
                Code = "3",
                Type = SubdivisionTypes.State,
                Name = "Kelantan",
                LocalName = "Kelantan"
            },
            new()
            { 
                Code = "4",
                Type = SubdivisionTypes.State,
                Name = "Melaka",
                LocalName = "Melaka"
            },
            new()
            { 
                Code = "5",
                Type = SubdivisionTypes.State,
                Name = "Negeri Sembilan",
                LocalName = "Negeri Sembilan"
            },
            new()
            { 
                Code = "6",
                Type = SubdivisionTypes.State,
                Name = "Pahang",
                LocalName = "Pahang"
            },
            new()
            { 
                Code = "8",
                Type = SubdivisionTypes.State,
                Name = "Perak",
                LocalName = "Perak"
            },
            new()
            { 
                Code = "9",
                Type = SubdivisionTypes.State,
                Name = "Perlis",
                LocalName = "Perlis"
            },
            new()
            { 
                Code = "7",
                Type = SubdivisionTypes.State,
                Name = "Pulau Pinang",
                LocalName = "Pulau Pinang"
            },
            new()
            { 
                Code = "12",
                Type = SubdivisionTypes.State,
                Name = "Sabah",
                LocalName = "Sabah"
            },
            new()
            { 
                Code = "13",
                Type = SubdivisionTypes.State,
                Name = "Sarawak",
                LocalName = "Sarawak"
            },
            new()
            { 
                Code = "10",
                Type = SubdivisionTypes.State,
                Name = "Selangor",
                LocalName = "Selangor"
            },
            new()
            { 
                Code = "11",
                Type = SubdivisionTypes.State,
                Name = "Terengganu",
                LocalName = "Terengganu"
            },
            new()
            { 
                Code = "14",
                Type = SubdivisionTypes.Territory,
                Name = "Wilayah Persekutuan Kuala Lumpur",
                LocalName = "Wilayah Persekutuan Kuala Lumpur"
            },
            new()
            { 
                Code = "15",
                Type = SubdivisionTypes.Territory,
                Name = "Wilayah Persekutuan Labuan",
                LocalName = "Wilayah Persekutuan Labuan"
            },
            new()
            { 
                Code = "16",
                Type = SubdivisionTypes.Territory,
                Name = "Wilayah Persekutuan Putrajaya",
                LocalName = "Wilayah Persekutuan Putrajaya"
            }

        ]);
    }
}
