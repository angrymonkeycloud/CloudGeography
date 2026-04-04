using AngryMonkey.Cloud.Geography;
namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    private static void FillInSubdivisionsHR()
    {
        AddSubdivisions("HR",
        [
            new()
            { 
                Code = "15",
                Type = SubdivisionTypes.County,
                Name = "ibensko-kninska upanija",
                LocalName = "ibensko-kninska upanija"
            },
            new()
            { 
                Code = "7",
                Type = SubdivisionTypes.County,
                Name = "Bjelovarsko-bilogorska upanija",
                LocalName = "Bjelovarsko-bilogorska upanija"
            },
            new()
            { 
                Code = "12",
                Type = SubdivisionTypes.County,
                Name = "Brodsko-posavska upanija",
                LocalName = "Brodsko-posavska upanija"
            },
            new()
            { 
                Code = "19",
                Type = SubdivisionTypes.County,
                Name = "Dubrovacko-neretvanska upanija",
                LocalName = "Dubrovacko-neretvanska upanija"
            },
            new()
            { 
                Code = "21",
                Type = SubdivisionTypes.City,
                Name = "Grad Zagreb",
                LocalName = "Grad Zagreb"
            },
            new()
            { 
                Code = "18",
                Type = SubdivisionTypes.County,
                Name = "Istarska upanija",
                LocalName = "Istarska upanija"
            },
            new()
            { 
                Code = "4",
                Type = SubdivisionTypes.County,
                Name = "Karlovacka upanija",
                LocalName = "Karlovacka upanija"
            },
            new()
            { 
                Code = "6",
                Type = SubdivisionTypes.County,
                Name = "Koprivnicko-krievacka upanija",
                LocalName = "Koprivnicko-krievacka upanija"
            },
            new()
            { 
                Code = "2",
                Type = SubdivisionTypes.County,
                Name = "Krapinsko-zagorska upanija",
                LocalName = "Krapinsko-zagorska upanija"
            },
            new()
            { 
                Code = "9",
                Type = SubdivisionTypes.County,
                Name = "Licko-senjska upanija",
                LocalName = "Licko-senjska upanija"
            },
            new()
            { 
                Code = "20",
                Type = SubdivisionTypes.County,
                Name = "Medimurska upanija",
                LocalName = "Medimurska upanija"
            },
            new()
            { 
                Code = "14",
                Type = SubdivisionTypes.County,
                Name = "Osjecko-baranjska upanija",
                LocalName = "Osjecko-baranjska upanija"
            },
            new()
            { 
                Code = "11",
                Type = SubdivisionTypes.County,
                Name = "Poeko-slavonska upanija",
                LocalName = "Poeko-slavonska upanija"
            },
            new()
            { 
                Code = "8",
                Type = SubdivisionTypes.County,
                Name = "Primorsko-goranska upanija",
                LocalName = "Primorsko-goranska upanija"
            },
            new()
            { 
                Code = "3",
                Type = SubdivisionTypes.County,
                Name = "Sisacko-moslavacka upanija",
                LocalName = "Sisacko-moslavacka upanija"
            },
            new()
            { 
                Code = "17",
                Type = SubdivisionTypes.County,
                Name = "Splitsko-dalmatinska upanija",
                LocalName = "Splitsko-dalmatinska upanija"
            },
            new()
            { 
                Code = "5",
                Type = SubdivisionTypes.County,
                Name = "Varadinska upanija",
                LocalName = "Varadinska upanija"
            },
            new()
            { 
                Code = "10",
                Type = SubdivisionTypes.County,
                Name = "Viroviticko-podravska upanija",
                LocalName = "Viroviticko-podravska upanija"
            },
            new()
            { 
                Code = "16",
                Type = SubdivisionTypes.County,
                Name = "Vukovarsko-srijemska upanija",
                LocalName = "Vukovarsko-srijemska upanija"
            },
            new()
            { 
                Code = "13",
                Type = SubdivisionTypes.County,
                Name = "Zadarska upanija",
                LocalName = "Zadarska upanija"
            },
            new()
            { 
                Code = "1",
                Type = SubdivisionTypes.County,
                Name = "Zagrebacka upanija",
                LocalName = "Zagrebacka upanija"
            }

        ]);
    }
}
