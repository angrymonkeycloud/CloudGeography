using AngryMonkey.Cloud.Geography;
namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    private static void FillInSubdivisionsZW()
    {
        AddSubdivisions("ZW", new List<Subdivision>()
        {
            new()
            { 
                Code = "BU",
                Type = "Province",
                Name = "Bulawayo",
                LocalName = "Bulawayo"
            },
            new()
            { 
                Code = "HA",
                Type = "Province",
                Name = "Harare",
                LocalName = "Harare"
            },
            new()
            { 
                Code = "MA",
                Type = "Province",
                Name = "Manicaland",
                LocalName = "Manicaland"
            },
            new()
            { 
                Code = "MC",
                Type = "Province",
                Name = "Mashonaland Central",
                LocalName = "Mashonaland Central"
            },
            new()
            { 
                Code = "ME",
                Type = "Province",
                Name = "Mashonaland East",
                LocalName = "Mashonaland East"
            },
            new()
            { 
                Code = "MW",
                Type = "Province",
                Name = "Mashonaland West",
                LocalName = "Mashonaland West"
            },
            new()
            { 
                Code = "MV",
                Type = "Province",
                Name = "Masvingo",
                LocalName = "Masvingo"
            },
            new()
            { 
                Code = "MN",
                Type = "Province",
                Name = "Matabeleland North",
                LocalName = "Matabeleland North"
            },
            new()
            { 
                Code = "MS",
                Type = "Province",
                Name = "Matabeleland South",
                LocalName = "Matabeleland South"
            },
            new()
            { 
                Code = "MI",
                Type = "Province",
                Name = "Midlands",
                LocalName = "Midlands"
            }

        });
    }
}
