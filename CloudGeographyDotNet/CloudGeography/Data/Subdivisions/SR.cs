using AngryMonkey.Cloud.Geography;
namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    private static void FillInSubdivisionsSR()
    {
        AddSubdivisions("SR",
        [
            new()
            { 
                Code = "BR",
                Type = SubdivisionTypes.District,
                Name = "Brokopondo",
                LocalName = "Brokopondo"
            },
            new()
            { 
                Code = "CM",
                Type = SubdivisionTypes.District,
                Name = "Commewijne",
                LocalName = "Commewijne"
            },
            new()
            { 
                Code = "CR",
                Type = SubdivisionTypes.District,
                Name = "Coronie",
                LocalName = "Coronie"
            },
            new()
            { 
                Code = "MA",
                Type = SubdivisionTypes.District,
                Name = "Marowijne",
                LocalName = "Marowijne"
            },
            new()
            { 
                Code = "NI",
                Type = SubdivisionTypes.District,
                Name = "Nickerie",
                LocalName = "Nickerie"
            },
            new()
            { 
                Code = "PR",
                Type = SubdivisionTypes.District,
                Name = "Para",
                LocalName = "Para"
            },
            new()
            { 
                Code = "SA",
                Type = SubdivisionTypes.District,
                Name = "Saramacca",
                LocalName = "Saramacca"
            },
            new()
            { 
                Code = "SI",
                Type = SubdivisionTypes.District,
                Name = "Sipaliwini",
                LocalName = "Sipaliwini"
            },
            new()
            { 
                Code = "WA",
                Type = SubdivisionTypes.District,
                Name = "Wanica",
                LocalName = "Wanica"
            }

        ]);
    }
}
