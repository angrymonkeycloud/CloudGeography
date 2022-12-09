using AngryMonkey.Cloud.Geography;
namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    private static void FillInSubdivisionsTJ()
    {
        AddSubdivisions("TJ", new List<Subdivision>()
        {
            new()
            { 
                Code = "DU",
                Type = "Territory",
                Name = "Dushanbe",
                LocalName = "Dushanbe"
            },
            new()
            { 
                Code = "KT",
                Type = "Region",
                Name = "Khatlon",
                LocalName = "Khatlon"
            },
            new()
            { 
                Code = "GB",
                Type = "Region",
                Name = "Kuhistoni Badakhshon",
                LocalName = "Kuhistoni Badakhshon"
            },
            new()
            { 
                Code = "RA",
                Type = "District",
                Name = "Nohiyahoi Tobei Jumhurí",
                LocalName = "Nohiyahoi Tobei Jumhurí"
            },
            new()
            { 
                Code = "SU",
                Type = "Region",
                Name = "Sughd",
                LocalName = "Sughd"
            }

        });
    }
}
