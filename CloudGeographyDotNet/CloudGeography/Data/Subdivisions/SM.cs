using AngryMonkey.Cloud.Geography;
namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    private static void FillInSubdivisionsSM()
    {
        AddSubdivisions("SM", new List<Subdivision>()
        {
            new()
            { 
                Code = "1",
                Type = "Municipality",
                Name = "Acquaviva",
                LocalName = "Acquaviva"
            },
            new()
            { 
                Code = "6",
                Type = "Municipality",
                Name = "Borgo Maggiore",
                LocalName = "Borgo Maggiore"
            },
            new()
            { 
                Code = "2",
                Type = "Municipality",
                Name = "Chiesanuova",
                LocalName = "Chiesanuova"
            },
            new()
            { 
                Code = "3",
                Type = "Municipality",
                Name = "Domagnano",
                LocalName = "Domagnano"
            },
            new()
            { 
                Code = "4",
                Type = "Municipality",
                Name = "Faetano",
                LocalName = "Faetano"
            },
            new()
            { 
                Code = "5",
                Type = "Municipality",
                Name = "Fiorentino",
                LocalName = "Fiorentino"
            },
            new()
            { 
                Code = "8",
                Type = "Municipality",
                Name = "Montegiardino",
                LocalName = "Montegiardino"
            },
            new()
            { 
                Code = "7",
                Type = "Municipality",
                Name = "San Marino",
                LocalName = "San Marino"
            },
            new()
            { 
                Code = "9",
                Type = "Municipality",
                Name = "Serravalle",
                LocalName = "Serravalle"
            }

        });
    }
}
