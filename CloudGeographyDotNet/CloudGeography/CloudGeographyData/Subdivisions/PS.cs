using AngryMonkey.Cloud.Geography;
namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    private static void FillInSubdivisionsPS()
    {
        AddSubdivisions("PS", new List<Subdivision>()
        {
            new()
            { 
                Code = "BTH",
                Type = "Governorate",
                Name = "Bethlehem",
                LocalName = "Bethlehem"
            },
            new()
            { 
                Code = "DEB",
                Type = "Governorate",
                Name = "Deir El Balah",
                LocalName = "Deir El Balah"
            },
            new()
            { 
                Code = "GZA",
                Type = "Governorate",
                Name = "Gaza",
                LocalName = "Gaza"
            },
            new()
            { 
                Code = "HBN",
                Type = "Governorate",
                Name = "Hebron",
                LocalName = "Hebron"
            },
            new()
            { 
                Code = "JRH",
                Type = "Governorate",
                Name = "Jericho and Al Aghwar",
                LocalName = "Jericho and Al Aghwar"
            },
            new()
            { 
                Code = "JEM",
                Type = "Governorate",
                Name = "Jerusalem",
                LocalName = "Jerusalem"
            },
            new()
            { 
                Code = "KYS",
                Type = "Governorate",
                Name = "Khan Yunis",
                LocalName = "Khan Yunis"
            },
            new()
            { 
                Code = "NBS",
                Type = "Governorate",
                Name = "Nablus",
                LocalName = "Nablus"
            },
            new()
            { 
                Code = "NGZ",
                Type = "Governorate",
                Name = "North Gaza",
                LocalName = "North Gaza"
            },
            new()
            { 
                Code = "QQA",
                Type = "Governorate",
                Name = "Qalqilya",
                LocalName = "Qalqilya"
            },
            new()
            { 
                Code = "RFH",
                Type = "Governorate",
                Name = "Rafah",
                LocalName = "Rafah"
            },
            new()
            { 
                Code = "RBH",
                Type = "Governorate",
                Name = "Ramallah",
                LocalName = "Ramallah"
            },
            new()
            { 
                Code = "SLT",
                Type = "Governorate",
                Name = "Salfit",
                LocalName = "Salfit"
            },
            new()
            { 
                Code = "TBS",
                Type = "Governorate",
                Name = "Tubas",
                LocalName = "Tubas"
            },
            new()
            { 
                Code = "TKM",
                Type = "Governorate",
                Name = "Tulkarm",
                LocalName = "Tulkarm"
            }

        });
    }
}
