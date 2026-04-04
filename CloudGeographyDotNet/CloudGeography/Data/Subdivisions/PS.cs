using AngryMonkey.Cloud.Geography;
namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    private static void FillInSubdivisionsPS()
    {
        AddSubdivisions("PS",
        [
            new()
            { 
                Code = "BTH",
                Type = SubdivisionTypes.Governorate,
                Name = "Bethlehem",
                LocalName = "Bethlehem"
            },
            new()
            { 
                Code = "DEB",
                Type = SubdivisionTypes.Governorate,
                Name = "Deir El Balah",
                LocalName = "Deir El Balah"
            },
            new()
            { 
                Code = "GZA",
                Type = SubdivisionTypes.Governorate,
                Name = "Gaza",
                LocalName = "Gaza"
            },
            new()
            { 
                Code = "HBN",
                Type = SubdivisionTypes.Governorate,
                Name = "Hebron",
                LocalName = "Hebron"
            },
            new()
            { 
                Code = "JRH",
                Type = SubdivisionTypes.Governorate,
                Name = "Jericho and Al Aghwar",
                LocalName = "Jericho and Al Aghwar"
            },
            new()
            { 
                Code = "JEM",
                Type = SubdivisionTypes.Governorate,
                Name = "Jerusalem",
                LocalName = "Jerusalem"
            },
            new()
            { 
                Code = "KYS",
                Type = SubdivisionTypes.Governorate,
                Name = "Khan Yunis",
                LocalName = "Khan Yunis"
            },
            new()
            { 
                Code = "NBS",
                Type = SubdivisionTypes.Governorate,
                Name = "Nablus",
                LocalName = "Nablus"
            },
            new()
            { 
                Code = "NGZ",
                Type = SubdivisionTypes.Governorate,
                Name = "North Gaza",
                LocalName = "North Gaza"
            },
            new()
            { 
                Code = "QQA",
                Type = SubdivisionTypes.Governorate,
                Name = "Qalqilya",
                LocalName = "Qalqilya"
            },
            new()
            { 
                Code = "RFH",
                Type = SubdivisionTypes.Governorate,
                Name = "Rafah",
                LocalName = "Rafah"
            },
            new()
            { 
                Code = "RBH",
                Type = SubdivisionTypes.Governorate,
                Name = "Ramallah",
                LocalName = "Ramallah"
            },
            new()
            { 
                Code = "SLT",
                Type = SubdivisionTypes.Governorate,
                Name = "Salfit",
                LocalName = "Salfit"
            },
            new()
            { 
                Code = "TBS",
                Type = SubdivisionTypes.Governorate,
                Name = "Tubas",
                LocalName = "Tubas"
            },
            new()
            { 
                Code = "TKM",
                Type = SubdivisionTypes.Governorate,
                Name = "Tulkarm",
                LocalName = "Tulkarm"
            }

        ]);
    }
}
