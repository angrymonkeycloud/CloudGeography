using AngryMonkey.Cloud.Geography;
namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    private static void FillInSubdivisionsBY()
    {
        AddSubdivisions("BY",
        [
            new()
            { 
                Code = "BR",
                Type = SubdivisionTypes.Oblast,
                Name = "Brest Oblast",
                LocalName = "Бре́стская о́бласть"
            },
            new()
            { 
                Code = "HO",
                Type = SubdivisionTypes.Oblast,
                Name = "Gomel Oblast",
                LocalName = "Гомельская область"
            },
            new()
            { 
                Code = "HR",
                Type = SubdivisionTypes.Oblast,
                Name = "Grodno Oblast",
                LocalName = "Гродненская область"
            },
            new()
            { 
                Code = "HM",
                Type = SubdivisionTypes.City,
                Name = "Minsk",
                LocalName = "Минск"
            },
            new()
            { 
                Code = "MI",
                Type = SubdivisionTypes.Oblast,
                Name = "Minsk Oblast",
                LocalName = "Минская о́бласть"
            },
            new()
            { 
                Code = "MA",
                Type = SubdivisionTypes.Oblast,
                Name = "Mogilev Oblast",
                LocalName = "Могилёвская о́бласть"
            },
            new()
            { 
                Code = "VI",
                Type = SubdivisionTypes.Oblast,
                Name = "Vitebsk Oblast",
                LocalName = "Ви́тебская о́бласть"
            }

        ]);
    }
}
