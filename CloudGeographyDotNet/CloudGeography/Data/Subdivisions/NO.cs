using AngryMonkey.Cloud.Geography;
namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    private static void FillInSubdivisionsNO()
    {
        AddSubdivisions("NO",
        [
            new()
            { 
                Code = "2",
                Type = SubdivisionTypes.County,
                Name = "Akershus",
                LocalName = "Akershus"
            },
            new()
            { 
                Code = "9",
                Type = SubdivisionTypes.County,
                Name = "Aust-Agder",
                LocalName = "Aust-Agder"
            },
            new()
            { 
                Code = "6",
                Type = SubdivisionTypes.County,
                Name = "Buskerud",
                LocalName = "Buskerud"
            },
            new()
            { 
                Code = "20",
                Type = SubdivisionTypes.County,
                Name = "Finnmark",
                LocalName = "Finnmark"
            },
            new()
            { 
                Code = "4",
                Type = SubdivisionTypes.County,
                Name = "Hedmark",
                LocalName = "Hedmark"
            },
            new()
            { 
                Code = "12",
                Type = SubdivisionTypes.County,
                Name = "Hordaland",
                LocalName = "Hordaland"
            },
            new()
            { 
                Code = "15",
                Type = SubdivisionTypes.County,
                Name = "Møre og Romsdal",
                LocalName = "Møre og Romsdal"
            },
            new()
            { 
                Code = "18",
                Type = SubdivisionTypes.County,
                Name = "Nordland",
                LocalName = "Nordland"
            },
            new()
            { 
                Code = "17",
                Type = SubdivisionTypes.County,
                Name = "Nord-Trøndelag",
                LocalName = "Nord-Trøndelag"
            },
            new()
            { 
                Code = "5",
                Type = SubdivisionTypes.County,
                Name = "Oppland",
                LocalName = "Oppland"
            },
            new()
            { 
                Code = "3",
                Type = SubdivisionTypes.County,
                Name = "Oslo",
                LocalName = "Oslo"
            },
            new()
            { 
                Code = "1",
                Type = SubdivisionTypes.County,
                Name = "Østfold",
                LocalName = "Østfold"
            },
            new()
            { 
                Code = "11",
                Type = SubdivisionTypes.County,
                Name = "Rogaland",
                LocalName = "Rogaland"
            },
            new()
            { 
                Code = "14",
                Type = SubdivisionTypes.County,
                Name = "Sogn og Fjordane",
                LocalName = "Sogn og Fjordane"
            },
            new()
            { 
                Code = "16",
                Type = SubdivisionTypes.County,
                Name = "Sør-Trøndelag",
                LocalName = "Sør-Trøndelag"
            },
            new()
            { 
                Code = "8",
                Type = SubdivisionTypes.County,
                Name = "Telemark",
                LocalName = "Telemark"
            },
            new()
            { 
                Code = "19",
                Type = SubdivisionTypes.County,
                Name = "Troms",
                LocalName = "Troms"
            },
            new()
            { 
                Code = "10",
                Type = SubdivisionTypes.County,
                Name = "Vest-Agder",
                LocalName = "Vest-Agder"
            },
            new()
            { 
                Code = "7",
                Type = SubdivisionTypes.County,
                Name = "Vestfold",
                LocalName = "Vestfold"
            }

        ]);
    }
}
