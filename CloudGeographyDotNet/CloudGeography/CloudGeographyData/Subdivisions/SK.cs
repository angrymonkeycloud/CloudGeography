using AngryMonkey.Cloud.Geography;
namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    private static void FillInSubdivisionsSK()
    {
        AddSubdivisions("SK", new List<Subdivision>()
        {
            new()
            { 
                Code = "ZI",
                Type = "Region",
                Name = "ilinský kraj",
                LocalName = "ilinský kraj"
            },
            new()
            { 
                Code = "BC",
                Type = "Region",
                Name = "Banskobystrický kraj",
                LocalName = "Banskobystrický kraj"
            },
            new()
            { 
                Code = "BL",
                Type = "Region",
                Name = "Bratislavský kraj",
                LocalName = "Bratislavský kraj"
            },
            new()
            { 
                Code = "KI",
                Type = "Region",
                Name = "Koický kraj",
                LocalName = "Koický kraj"
            },
            new()
            { 
                Code = "NI",
                Type = "Region",
                Name = "Nitriansky kraj",
                LocalName = "Nitriansky kraj"
            },
            new()
            { 
                Code = "PV",
                Type = "Region",
                Name = "Preovský kraj",
                LocalName = "Preovský kraj"
            },
            new()
            { 
                Code = "TC",
                Type = "Region",
                Name = "Trenciansky kraj",
                LocalName = "Trenciansky kraj"
            },
            new()
            { 
                Code = "TA",
                Type = "Region",
                Name = "Trnavský kraj",
                LocalName = "Trnavský kraj"
            }

        });
    }
}
