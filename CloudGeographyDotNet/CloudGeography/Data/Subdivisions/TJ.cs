using AngryMonkey.Cloud.Geography;
namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    private static void FillInSubdivisionsTJ()
    {
        AddSubdivisions("TJ",
        [
            new()
            { 
                Code = "DU",
                Type = SubdivisionTypes.Territory,
                Name = "Dushanbe",
                LocalName = "Dushanbe"
            },
            new()
            { 
                Code = "KT",
                Type = SubdivisionTypes.Region,
                Name = "Khatlon",
                LocalName = "Khatlon"
            },
            new()
            { 
                Code = "GB",
                Type = SubdivisionTypes.Region,
                Name = "Kuhistoni Badakhshon",
                LocalName = "Kuhistoni Badakhshon"
            },
            new()
            { 
                Code = "RA",
                Type = SubdivisionTypes.District,
                Name = "Nohiyahoi Tobei Jumhurí",
                LocalName = "Nohiyahoi Tobei Jumhurí"
            },
            new()
            { 
                Code = "SU",
                Type = SubdivisionTypes.Region,
                Name = "Sughd",
                LocalName = "Sughd"
            }

        ]);
    }
}
