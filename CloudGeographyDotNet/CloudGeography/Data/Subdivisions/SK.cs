using AngryMonkey.Cloud.Geography;
namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    private static void FillInSubdivisionsSK()
    {
        AddSubdivisions("SK",
        [
            new()
            { 
                Code = "ZI",
                Type = SubdivisionTypes.Region,
                Name = "ilinský kraj",
                LocalName = "ilinský kraj"
            },
            new()
            { 
                Code = "BC",
                Type = SubdivisionTypes.Region,
                Name = "Banskobystrický kraj",
                LocalName = "Banskobystrický kraj"
            },
            new()
            { 
                Code = "BL",
                Type = SubdivisionTypes.Region,
                Name = "Bratislavský kraj",
                LocalName = "Bratislavský kraj"
            },
            new()
            { 
                Code = "KI",
                Type = SubdivisionTypes.Region,
                Name = "Koický kraj",
                LocalName = "Koický kraj"
            },
            new()
            { 
                Code = "NI",
                Type = SubdivisionTypes.Region,
                Name = "Nitriansky kraj",
                LocalName = "Nitriansky kraj"
            },
            new()
            { 
                Code = "PV",
                Type = SubdivisionTypes.Region,
                Name = "Preovský kraj",
                LocalName = "Preovský kraj"
            },
            new()
            { 
                Code = "TC",
                Type = SubdivisionTypes.Region,
                Name = "Trenciansky kraj",
                LocalName = "Trenciansky kraj"
            },
            new()
            { 
                Code = "TA",
                Type = SubdivisionTypes.Region,
                Name = "Trnavský kraj",
                LocalName = "Trnavský kraj"
            }

        ]);
    }
}
