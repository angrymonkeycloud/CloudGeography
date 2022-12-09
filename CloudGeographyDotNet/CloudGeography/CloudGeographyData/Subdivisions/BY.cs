using AngryMonkey.Cloud.Geography;
namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    private static void FillInSubdivisionsBY()
    {
        AddSubdivisions("BY", new List<Subdivision>()
        {
            new()
            { 
                Code = "BR",
                Type = "Oblast",
                Name = "Brest Oblast",
                LocalName = "Бре́стская о́бласть"
            },
            new()
            { 
                Code = "HO",
                Type = "Oblast",
                Name = "Gomel Oblast",
                LocalName = "Гомельская область"
            },
            new()
            { 
                Code = "HR",
                Type = "Oblast",
                Name = "Grodno Oblast",
                LocalName = "Гродненская область"
            },
            new()
            { 
                Code = "HM",
                Type = "City",
                Name = "Minsk",
                LocalName = "Минск"
            },
            new()
            { 
                Code = "MI",
                Type = "Oblast",
                Name = "Minsk Oblast",
                LocalName = "Минская о́бласть"
            },
            new()
            { 
                Code = "MA",
                Type = "Oblast",
                Name = "Mogilev Oblast",
                LocalName = "Могилёвская о́бласть"
            },
            new()
            { 
                Code = "VI",
                Type = "Oblast",
                Name = "Vitebsk Oblast",
                LocalName = "Ви́тебская о́бласть"
            }

        });
    }
}
