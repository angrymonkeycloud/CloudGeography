using AngryMonkey.Cloud.Geography;
namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    private static void FillInSubdivisionsCI()
    {
        AddSubdivisions("CI",
        [
            new()
            { 
                Code = "AB",
                Type = SubdivisionTypes.District,
                Name = "Abidjan",
                LocalName = "Abidjan"
            },
            new()
            { 
                Code = "BS",
                Type = SubdivisionTypes.District,
                Name = "Bas-Sassandra",
                LocalName = "Bas-Sassandra"
            },
            new()
            { 
                Code = "CM",
                Type = SubdivisionTypes.District,
                Name = "Comoé",
                LocalName = "Comoé"
            },
            new()
            { 
                Code = "DN",
                Type = SubdivisionTypes.District,
                Name = "Denguélé",
                LocalName = "Denguélé"
            },
            new()
            { 
                Code = "GD",
                Type = SubdivisionTypes.District,
                Name = "Gôh-Djiboua",
                LocalName = "Gôh-Djiboua"
            },
            new()
            { 
                Code = "LC",
                Type = SubdivisionTypes.District,
                Name = "Lacs",
                LocalName = "Lacs"
            },
            new()
            { 
                Code = "LG",
                Type = SubdivisionTypes.District,
                Name = "Lagunes",
                LocalName = "Lagunes"
            },
            new()
            { 
                Code = "MG",
                Type = SubdivisionTypes.District,
                Name = "Montagnes",
                LocalName = "Montagnes"
            },
            new()
            { 
                Code = "SM",
                Type = SubdivisionTypes.District,
                Name = "Sassandra-Marahoué",
                LocalName = "Sassandra-Marahoué"
            },
            new()
            { 
                Code = "SV",
                Type = SubdivisionTypes.District,
                Name = "Savanes",
                LocalName = "Savanes"
            },
            new()
            { 
                Code = "VB",
                Type = SubdivisionTypes.District,
                Name = "Vallée du Bandama",
                LocalName = "Vallée du Bandama"
            },
            new()
            { 
                Code = "WR",
                Type = SubdivisionTypes.District,
                Name = "Woroba",
                LocalName = "Woroba"
            },
            new()
            { 
                Code = "YM",
                Type = SubdivisionTypes.District,
                Name = "Yamoussoukro",
                LocalName = "Yamoussoukro"
            },
            new()
            { 
                Code = "ZZ",
                Type = SubdivisionTypes.District,
                Name = "Zanzan",
                LocalName = "Zanzan"
            }

        ]);
    }
}
