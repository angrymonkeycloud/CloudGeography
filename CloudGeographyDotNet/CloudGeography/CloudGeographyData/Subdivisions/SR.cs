using AngryMonkey.Cloud.Geography;
namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    private static void FillInSubdivisionsSR()
    {
        AddSubdivisions("SR", new List<Subdivision>()
        {
            new()
            { 
                Code = "BR",
                Type = "District",
                Name = "Brokopondo",
                LocalName = "Brokopondo"
            },
            new()
            { 
                Code = "CM",
                Type = "District",
                Name = "Commewijne",
                LocalName = "Commewijne"
            },
            new()
            { 
                Code = "CR",
                Type = "District",
                Name = "Coronie",
                LocalName = "Coronie"
            },
            new()
            { 
                Code = "MA",
                Type = "District",
                Name = "Marowijne",
                LocalName = "Marowijne"
            },
            new()
            { 
                Code = "NI",
                Type = "District",
                Name = "Nickerie",
                LocalName = "Nickerie"
            },
            new()
            { 
                Code = "PR",
                Type = "District",
                Name = "Para",
                LocalName = "Para"
            },
            new()
            { 
                Code = "SA",
                Type = "District",
                Name = "Saramacca",
                LocalName = "Saramacca"
            },
            new()
            { 
                Code = "SI",
                Type = "District",
                Name = "Sipaliwini",
                LocalName = "Sipaliwini"
            },
            new()
            { 
                Code = "WA",
                Type = "District",
                Name = "Wanica",
                LocalName = "Wanica"
            }

        });
    }
}
