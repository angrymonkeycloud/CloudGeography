using AngryMonkey.Cloud.Geography;
namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    private static void FillInSubdivisionsLC()
    {
        AddSubdivisions("LC", new List<Subdivision>()
        {
            new()
            { 
                Code = "1",
                Type = "District",
                Name = "Anse la Raye",
                LocalName = "Anse la Raye"
            },
            new()
            { 
                Code = "12",
                Type = "District",
                Name = "Canaries",
                LocalName = "Canaries"
            },
            new()
            { 
                Code = "2",
                Type = "District",
                Name = "Castries",
                LocalName = "Castries"
            },
            new()
            { 
                Code = "3",
                Type = "District",
                Name = "Choiseul",
                LocalName = "Choiseul"
            },
            new()
            { 
                Code = "5",
                Type = "District",
                Name = "Dennery",
                LocalName = "Dennery"
            },
            new()
            { 
                Code = "6",
                Type = "District",
                Name = "Gros Islet",
                LocalName = "Gros Islet"
            },
            new()
            { 
                Code = "7",
                Type = "District",
                Name = "Laborie",
                LocalName = "Laborie"
            },
            new()
            { 
                Code = "8",
                Type = "District",
                Name = "Micoud",
                LocalName = "Micoud"
            },
            new()
            { 
                Code = "10",
                Type = "District",
                Name = "Soufrière",
                LocalName = "Soufrière"
            },
            new()
            { 
                Code = "11",
                Type = "District",
                Name = "Vieux Fort",
                LocalName = "Vieux Fort"
            }

        });
    }
}
