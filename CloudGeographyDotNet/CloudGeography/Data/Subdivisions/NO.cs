using AngryMonkey.Cloud.Geography;
namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    private static void FillInSubdivisionsNO()
    {
        AddSubdivisions("NO", new List<Subdivision>()
        {
            new()
            { 
                Code = "2",
                Type = "County",
                Name = "Akershus",
                LocalName = "Akershus"
            },
            new()
            { 
                Code = "9",
                Type = "County",
                Name = "Aust-Agder",
                LocalName = "Aust-Agder"
            },
            new()
            { 
                Code = "6",
                Type = "County",
                Name = "Buskerud",
                LocalName = "Buskerud"
            },
            new()
            { 
                Code = "20",
                Type = "County",
                Name = "Finnmark",
                LocalName = "Finnmark"
            },
            new()
            { 
                Code = "4",
                Type = "County",
                Name = "Hedmark",
                LocalName = "Hedmark"
            },
            new()
            { 
                Code = "12",
                Type = "County",
                Name = "Hordaland",
                LocalName = "Hordaland"
            },
            new()
            { 
                Code = "15",
                Type = "County",
                Name = "Møre og Romsdal",
                LocalName = "Møre og Romsdal"
            },
            new()
            { 
                Code = "18",
                Type = "County",
                Name = "Nordland",
                LocalName = "Nordland"
            },
            new()
            { 
                Code = "17",
                Type = "County",
                Name = "Nord-Trøndelag",
                LocalName = "Nord-Trøndelag"
            },
            new()
            { 
                Code = "5",
                Type = "County",
                Name = "Oppland",
                LocalName = "Oppland"
            },
            new()
            { 
                Code = "3",
                Type = "County",
                Name = "Oslo",
                LocalName = "Oslo"
            },
            new()
            { 
                Code = "1",
                Type = "County",
                Name = "Østfold",
                LocalName = "Østfold"
            },
            new()
            { 
                Code = "11",
                Type = "County",
                Name = "Rogaland",
                LocalName = "Rogaland"
            },
            new()
            { 
                Code = "14",
                Type = "County",
                Name = "Sogn og Fjordane",
                LocalName = "Sogn og Fjordane"
            },
            new()
            { 
                Code = "16",
                Type = "County",
                Name = "Sør-Trøndelag",
                LocalName = "Sør-Trøndelag"
            },
            new()
            { 
                Code = "8",
                Type = "County",
                Name = "Telemark",
                LocalName = "Telemark"
            },
            new()
            { 
                Code = "19",
                Type = "County",
                Name = "Troms",
                LocalName = "Troms"
            },
            new()
            { 
                Code = "10",
                Type = "County",
                Name = "Vest-Agder",
                LocalName = "Vest-Agder"
            },
            new()
            { 
                Code = "7",
                Type = "County",
                Name = "Vestfold",
                LocalName = "Vestfold"
            }

        });
    }
}
