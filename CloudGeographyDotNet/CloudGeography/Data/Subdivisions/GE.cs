using AngryMonkey.Cloud.Geography;
namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    private static void FillInSubdivisionsGE()
    {
        AddSubdivisions("GE", new List<Subdivision>()
        {
            new()
            { 
                Code = "AB",
                Type = "Republic",
                Name = "Abkhazia",
                LocalName = "აფხაზეთი"
            },
            new()
            { 
                Code = "AJ",
                Type = "Republic",
                Name = "Ajaria",
                LocalName = "აჭარა"
            },
            new()
            { 
                Code = "GU",
                Type = "Region",
                Name = "Guria",
                LocalName = "გურია"
            },
            new()
            { 
                Code = "IM",
                Type = "Region",
                Name = "Imereti",
                LocalName = "იმერეთი"
            },
            new()
            { 
                Code = "KA",
                Type = "Region",
                Name = "Kakheti",
                LocalName = "კახეთი"
            },
            new()
            { 
                Code = "KK",
                Type = "Region",
                Name = "Kvemo Kartli",
                LocalName = "ქვემო ქართლი"
            },
            new()
            { 
                Code = "MM",
                Type = "Region",
                Name = "Mtskheta-Mtianeti",
                LocalName = "მცხეთა-მთიანეთი"
            },
            new()
            { 
                Code = "RL",
                Type = "Region",
                Name = "Racha-Lechkhumi and Kvemo Svaneti",
                LocalName = "რაჭა-ლეჩხუმი და ქვემო სვანეთი"
            },
            new()
            { 
                Code = "SZ",
                Type = "Region",
                Name = "Samegrelo-Zemo Svaneti",
                LocalName = "სამეგრელო-ზემო სვანეთი"
            },
            new()
            { 
                Code = "SJ",
                Type = "Region",
                Name = "Samtskhe-Javakheti",
                LocalName = "სამცხე-ჯავახეთი"
            },
            new()
            { 
                Code = "SK",
                Type = "Region",
                Name = "Shida Kartli",
                LocalName = "შიდა ქართლი"
            },
            new()
            { 
                Code = "TB",
                Type = "City",
                Name = "Tbilisi",
                LocalName = "თბილისი"
            }

        });
    }
}
