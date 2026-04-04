using AngryMonkey.Cloud.Geography;
namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    private static void FillInSubdivisionsSM()
    {
        AddSubdivisions("SM",
        [
            new()
            { 
                Code = "1",
                Type = SubdivisionTypes.Municipality,
                Name = "Acquaviva",
                LocalName = "Acquaviva"
            },
            new()
            { 
                Code = "6",
                Type = SubdivisionTypes.Municipality,
                Name = "Borgo Maggiore",
                LocalName = "Borgo Maggiore"
            },
            new()
            { 
                Code = "2",
                Type = SubdivisionTypes.Municipality,
                Name = "Chiesanuova",
                LocalName = "Chiesanuova"
            },
            new()
            { 
                Code = "3",
                Type = SubdivisionTypes.Municipality,
                Name = "Domagnano",
                LocalName = "Domagnano"
            },
            new()
            { 
                Code = "4",
                Type = SubdivisionTypes.Municipality,
                Name = "Faetano",
                LocalName = "Faetano"
            },
            new()
            { 
                Code = "5",
                Type = SubdivisionTypes.Municipality,
                Name = "Fiorentino",
                LocalName = "Fiorentino"
            },
            new()
            { 
                Code = "8",
                Type = SubdivisionTypes.Municipality,
                Name = "Montegiardino",
                LocalName = "Montegiardino"
            },
            new()
            { 
                Code = "7",
                Type = SubdivisionTypes.Municipality,
                Name = "San Marino",
                LocalName = "San Marino"
            },
            new()
            { 
                Code = "9",
                Type = SubdivisionTypes.Municipality,
                Name = "Serravalle",
                LocalName = "Serravalle"
            }

        ]);
    }
}
