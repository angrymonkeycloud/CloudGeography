using AngryMonkey.Cloud.Geography;
namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    private static void FillInSubdivisionsME()
    {
        AddSubdivisions("ME",
        [
            new()
            { 
                Code = "21",
                Type = SubdivisionTypes.Municipality,
                Name = "abljak",
                LocalName = "abljak"
            },
            new()
            { 
                Code = "18",
                Type = SubdivisionTypes.Municipality,
                Name = "avnik",
                LocalName = "avnik"
            },
            new()
            { 
                Code = "1",
                Type = SubdivisionTypes.Municipality,
                Name = "Andrijevica",
                LocalName = "Andrijevica"
            },
            new()
            { 
                Code = "2",
                Type = SubdivisionTypes.Municipality,
                Name = "Bar",
                LocalName = "Bar"
            },
            new()
            { 
                Code = "3",
                Type = SubdivisionTypes.Municipality,
                Name = "Berane",
                LocalName = "Berane"
            },
            new()
            { 
                Code = "4",
                Type = SubdivisionTypes.Municipality,
                Name = "Bijelo Polje",
                LocalName = "Bijelo Polje"
            },
            new()
            { 
                Code = "5",
                Type = SubdivisionTypes.Municipality,
                Name = "Budva",
                LocalName = "Budva"
            },
            new()
            { 
                Code = "6",
                Type = SubdivisionTypes.Municipality,
                Name = "Cetinje",
                LocalName = "Cetinje"
            },
            new()
            { 
                Code = "7",
                Type = SubdivisionTypes.Municipality,
                Name = "Danilovgrad",
                LocalName = "Danilovgrad"
            },
            new()
            { 
                Code = "22",
                Type = SubdivisionTypes.Municipality,
                Name = "Gusinje",
                LocalName = "Gusinje"
            },
            new()
            { 
                Code = "8",
                Type = SubdivisionTypes.Municipality,
                Name = "Herceg-Novi",
                LocalName = "Herceg-Novi"
            },
            new()
            { 
                Code = "9",
                Type = SubdivisionTypes.Municipality,
                Name = "Kolain",
                LocalName = "Kolain"
            },
            new()
            { 
                Code = "10",
                Type = SubdivisionTypes.Municipality,
                Name = "Kotor",
                LocalName = "Kotor"
            },
            new()
            { 
                Code = "11",
                Type = SubdivisionTypes.Municipality,
                Name = "Mojkovac",
                LocalName = "Mojkovac"
            },
            new()
            { 
                Code = "12",
                Type = SubdivisionTypes.Municipality,
                Name = "Nikic´",
                LocalName = "Nikic´"
            },
            new()
            { 
                Code = "23",
                Type = SubdivisionTypes.Municipality,
                Name = "Petnjica",
                LocalName = "Petnjica"
            },
            new()
            { 
                Code = "13",
                Type = SubdivisionTypes.Municipality,
                Name = "Plav",
                LocalName = "Plav"
            },
            new()
            { 
                Code = "14",
                Type = SubdivisionTypes.Municipality,
                Name = "Pljevlja",
                LocalName = "Pljevlja"
            },
            new()
            { 
                Code = "15",
                Type = SubdivisionTypes.Municipality,
                Name = "Pluine",
                LocalName = "Pluine"
            },
            new()
            { 
                Code = "16",
                Type = SubdivisionTypes.Municipality,
                Name = "Podgorica",
                LocalName = "Podgorica"
            },
            new()
            { 
                Code = "17",
                Type = SubdivisionTypes.Municipality,
                Name = "Roaje",
                LocalName = "Roaje"
            },
            new()
            { 
                Code = "19",
                Type = SubdivisionTypes.Municipality,
                Name = "Tivat",
                LocalName = "Tivat"
            },
            new()
            { 
                Code = "20",
                Type = SubdivisionTypes.Municipality,
                Name = "Ulcinj",
                LocalName = "Ulcinj"
            }

        ]);
    }
}
