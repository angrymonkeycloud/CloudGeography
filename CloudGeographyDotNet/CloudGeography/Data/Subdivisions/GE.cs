using AngryMonkey.Cloud.Geography;
namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    private static void FillInSubdivisionsGE()
    {
        AddSubdivisions("GE",
        [
            new()
            { 
                Code = "AB",
                Type = SubdivisionTypes.Republic,
                Name = "Abkhazia",
                LocalName = "აფხაზეთი"
            },
            new()
            { 
                Code = "AJ",
                Type = SubdivisionTypes.Republic,
                Name = "Ajaria",
                LocalName = "აჭარა"
            },
            new()
            { 
                Code = "GU",
                Type = SubdivisionTypes.Region,
                Name = "Guria",
                LocalName = "გურია"
            },
            new()
            { 
                Code = "IM",
                Type = SubdivisionTypes.Region,
                Name = "Imereti",
                LocalName = "იმერეთი"
            },
            new()
            { 
                Code = "KA",
                Type = SubdivisionTypes.Region,
                Name = "Kakheti",
                LocalName = "კახეთი"
            },
            new()
            { 
                Code = "KK",
                Type = SubdivisionTypes.Region,
                Name = "Kvemo Kartli",
                LocalName = "ქვემო ქართლი"
            },
            new()
            { 
                Code = "MM",
                Type = SubdivisionTypes.Region,
                Name = "Mtskheta-Mtianeti",
                LocalName = "მცხეთა-მთიანეთი"
            },
            new()
            { 
                Code = "RL",
                Type = SubdivisionTypes.Region,
                Name = "Racha-Lechkhumi and Kvemo Svaneti",
                LocalName = "რაჭა-ლეჩხუმი და ქვემო სვანეთი"
            },
            new()
            { 
                Code = "SZ",
                Type = SubdivisionTypes.Region,
                Name = "Samegrelo-Zemo Svaneti",
                LocalName = "სამეგრელო-ზემო სვანეთი"
            },
            new()
            { 
                Code = "SJ",
                Type = SubdivisionTypes.Region,
                Name = "Samtskhe-Javakheti",
                LocalName = "სამცხე-ჯავახეთი"
            },
            new()
            { 
                Code = "SK",
                Type = SubdivisionTypes.Region,
                Name = "Shida Kartli",
                LocalName = "შიდა ქართლი"
            },
            new()
            { 
                Code = "TB",
                Type = SubdivisionTypes.City,
                Name = "Tbilisi",
                LocalName = "თბილისი"
            }

        ]);
    }
}
