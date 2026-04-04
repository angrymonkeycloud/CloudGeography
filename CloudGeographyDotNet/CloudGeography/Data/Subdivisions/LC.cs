using AngryMonkey.Cloud.Geography;
namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    private static void FillInSubdivisionsLC()
    {
        AddSubdivisions("LC",
        [
            new()
            { 
                Code = "1",
                Type = SubdivisionTypes.District,
                Name = "Anse la Raye",
                LocalName = "Anse la Raye"
            },
            new()
            { 
                Code = "12",
                Type = SubdivisionTypes.District,
                Name = "Canaries",
                LocalName = "Canaries"
            },
            new()
            { 
                Code = "2",
                Type = SubdivisionTypes.District,
                Name = "Castries",
                LocalName = "Castries"
            },
            new()
            { 
                Code = "3",
                Type = SubdivisionTypes.District,
                Name = "Choiseul",
                LocalName = "Choiseul"
            },
            new()
            { 
                Code = "5",
                Type = SubdivisionTypes.District,
                Name = "Dennery",
                LocalName = "Dennery"
            },
            new()
            { 
                Code = "6",
                Type = SubdivisionTypes.District,
                Name = "Gros Islet",
                LocalName = "Gros Islet"
            },
            new()
            { 
                Code = "7",
                Type = SubdivisionTypes.District,
                Name = "Laborie",
                LocalName = "Laborie"
            },
            new()
            { 
                Code = "8",
                Type = SubdivisionTypes.District,
                Name = "Micoud",
                LocalName = "Micoud"
            },
            new()
            { 
                Code = "10",
                Type = SubdivisionTypes.District,
                Name = "Soufrière",
                LocalName = "Soufrière"
            },
            new()
            { 
                Code = "11",
                Type = SubdivisionTypes.District,
                Name = "Vieux Fort",
                LocalName = "Vieux Fort"
            }

        ]);
    }
}
