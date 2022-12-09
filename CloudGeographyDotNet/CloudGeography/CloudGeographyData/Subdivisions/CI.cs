using AngryMonkey.Cloud.Geography;
namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    private static void FillInSubdivisionsCI()
    {
        AddSubdivisions("CI", new List<Subdivision>()
        {
            new()
            { 
                Code = "AB",
                Type = "District",
                Name = "Abidjan",
                LocalName = "Abidjan"
            },
            new()
            { 
                Code = "BS",
                Type = "District",
                Name = "Bas-Sassandra",
                LocalName = "Bas-Sassandra"
            },
            new()
            { 
                Code = "CM",
                Type = "District",
                Name = "Comoé",
                LocalName = "Comoé"
            },
            new()
            { 
                Code = "DN",
                Type = "District",
                Name = "Denguélé",
                LocalName = "Denguélé"
            },
            new()
            { 
                Code = "GD",
                Type = "District",
                Name = "Gôh-Djiboua",
                LocalName = "Gôh-Djiboua"
            },
            new()
            { 
                Code = "LC",
                Type = "District",
                Name = "Lacs",
                LocalName = "Lacs"
            },
            new()
            { 
                Code = "LG",
                Type = "District",
                Name = "Lagunes",
                LocalName = "Lagunes"
            },
            new()
            { 
                Code = "MG",
                Type = "District",
                Name = "Montagnes",
                LocalName = "Montagnes"
            },
            new()
            { 
                Code = "SM",
                Type = "District",
                Name = "Sassandra-Marahoué",
                LocalName = "Sassandra-Marahoué"
            },
            new()
            { 
                Code = "SV",
                Type = "District",
                Name = "Savanes",
                LocalName = "Savanes"
            },
            new()
            { 
                Code = "VB",
                Type = "District",
                Name = "Vallée du Bandama",
                LocalName = "Vallée du Bandama"
            },
            new()
            { 
                Code = "WR",
                Type = "District",
                Name = "Woroba",
                LocalName = "Woroba"
            },
            new()
            { 
                Code = "YM",
                Type = "District",
                Name = "Yamoussoukro",
                LocalName = "Yamoussoukro"
            },
            new()
            { 
                Code = "ZZ",
                Type = "District",
                Name = "Zanzan",
                LocalName = "Zanzan"
            }

        });
    }
}
