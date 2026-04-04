using AngryMonkey.Cloud.Geography;
namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    private static void FillInSubdivisionsZW()
    {
        AddSubdivisions("ZW",
        [
            new()
            { 
                Code = "BU",
                Type = SubdivisionTypes.Province,
                Name = "Bulawayo",
                LocalName = "Bulawayo"
            },
            new()
            { 
                Code = "HA",
                Type = SubdivisionTypes.Province,
                Name = "Harare",
                LocalName = "Harare"
            },
            new()
            { 
                Code = "MA",
                Type = SubdivisionTypes.Province,
                Name = "Manicaland",
                LocalName = "Manicaland"
            },
            new()
            { 
                Code = "MC",
                Type = SubdivisionTypes.Province,
                Name = "Mashonaland Central",
                LocalName = "Mashonaland Central"
            },
            new()
            { 
                Code = "ME",
                Type = SubdivisionTypes.Province,
                Name = "Mashonaland East",
                LocalName = "Mashonaland East"
            },
            new()
            { 
                Code = "MW",
                Type = SubdivisionTypes.Province,
                Name = "Mashonaland West",
                LocalName = "Mashonaland West"
            },
            new()
            { 
                Code = "MV",
                Type = SubdivisionTypes.Province,
                Name = "Masvingo",
                LocalName = "Masvingo"
            },
            new()
            { 
                Code = "MN",
                Type = SubdivisionTypes.Province,
                Name = "Matabeleland North",
                LocalName = "Matabeleland North"
            },
            new()
            { 
                Code = "MS",
                Type = SubdivisionTypes.Province,
                Name = "Matabeleland South",
                LocalName = "Matabeleland South"
            },
            new()
            { 
                Code = "MI",
                Type = SubdivisionTypes.Province,
                Name = "Midlands",
                LocalName = "Midlands"
            }

        ]);
    }
}
