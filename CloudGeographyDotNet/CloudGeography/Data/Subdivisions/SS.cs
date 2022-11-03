using AngryMonkey.Cloud.Geography;
namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    private static void FillInSubdivisionsSS()
    {
        AddSubdivisions("SS", new List<Subdivision>()
        {
            new()
            { 
                Code = "EC",
                Type = "State",
                Name = "Central Equatoria",
                LocalName = "Central Equatoria"
            },
            new()
            { 
                Code = "EE",
                Type = "State",
                Name = "Eastern Equatoria",
                LocalName = "Eastern Equatoria"
            },
            new()
            { 
                Code = "JG",
                Type = "State",
                Name = "Jonglei",
                LocalName = "Jonglei"
            },
            new()
            { 
                Code = "LK",
                Type = "State",
                Name = "Lakes",
                LocalName = "Lakes"
            },
            new()
            { 
                Code = "BN",
                Type = "State",
                Name = "Northern Bahr el Ghazal",
                LocalName = "Northern Bahr el Ghazal"
            },
            new()
            { 
                Code = "UY",
                Type = "State",
                Name = "Unity",
                LocalName = "Unity"
            },
            new()
            { 
                Code = "NU",
                Type = "State",
                Name = "Upper Nile",
                LocalName = "Upper Nile"
            },
            new()
            { 
                Code = "WR",
                Type = "State",
                Name = "Warrap",
                LocalName = "Warrap"
            },
            new()
            { 
                Code = "BW",
                Type = "State",
                Name = "Western Bahr el Ghazal",
                LocalName = "Western Bahr el Ghazal"
            },
            new()
            { 
                Code = "EW",
                Type = "State",
                Name = "Western Equatoria",
                LocalName = "Western Equatoria"
            }

        });
    }
}
