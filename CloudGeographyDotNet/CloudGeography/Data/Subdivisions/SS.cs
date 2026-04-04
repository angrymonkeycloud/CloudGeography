using AngryMonkey.Cloud.Geography;
namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    private static void FillInSubdivisionsSS()
    {
        AddSubdivisions("SS",
        [
            new()
            { 
                Code = "EC",
                Type = SubdivisionTypes.State,
                Name = "Central Equatoria",
                LocalName = "Central Equatoria"
            },
            new()
            { 
                Code = "EE",
                Type = SubdivisionTypes.State,
                Name = "Eastern Equatoria",
                LocalName = "Eastern Equatoria"
            },
            new()
            { 
                Code = "JG",
                Type = SubdivisionTypes.State,
                Name = "Jonglei",
                LocalName = "Jonglei"
            },
            new()
            { 
                Code = "LK",
                Type = SubdivisionTypes.State,
                Name = "Lakes",
                LocalName = "Lakes"
            },
            new()
            { 
                Code = "BN",
                Type = SubdivisionTypes.State,
                Name = "Northern Bahr el Ghazal",
                LocalName = "Northern Bahr el Ghazal"
            },
            new()
            { 
                Code = "UY",
                Type = SubdivisionTypes.State,
                Name = "Unity",
                LocalName = "Unity"
            },
            new()
            { 
                Code = "NU",
                Type = SubdivisionTypes.State,
                Name = "Upper Nile",
                LocalName = "Upper Nile"
            },
            new()
            { 
                Code = "WR",
                Type = SubdivisionTypes.State,
                Name = "Warrap",
                LocalName = "Warrap"
            },
            new()
            { 
                Code = "BW",
                Type = SubdivisionTypes.State,
                Name = "Western Bahr el Ghazal",
                LocalName = "Western Bahr el Ghazal"
            },
            new()
            { 
                Code = "EW",
                Type = SubdivisionTypes.State,
                Name = "Western Equatoria",
                LocalName = "Western Equatoria"
            }

        ]);
    }
}
