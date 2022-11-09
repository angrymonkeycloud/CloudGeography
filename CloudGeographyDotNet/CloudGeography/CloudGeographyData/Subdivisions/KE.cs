using AngryMonkey.Cloud.Geography;
namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    private static void FillInSubdivisionsKE()
    {
        AddSubdivisions("KE", new List<Subdivision>()
        {
            new()
            { 
                Code = "1",
                Type = "County",
                Name = "Baringo",
                LocalName = "Baringo"
            },
            new()
            { 
                Code = "2",
                Type = "County",
                Name = "Bomet",
                LocalName = "Bomet"
            },
            new()
            { 
                Code = "3",
                Type = "County",
                Name = "Bungoma",
                LocalName = "Bungoma"
            },
            new()
            { 
                Code = "4",
                Type = "County",
                Name = "Busia",
                LocalName = "Busia"
            },
            new()
            { 
                Code = "5",
                Type = "County",
                Name = "Elgeyo/Marakwet",
                LocalName = "Elgeyo/Marakwet"
            },
            new()
            { 
                Code = "6",
                Type = "County",
                Name = "Embu",
                LocalName = "Embu"
            },
            new()
            { 
                Code = "7",
                Type = "County",
                Name = "Garissa",
                LocalName = "Garissa"
            },
            new()
            { 
                Code = "8",
                Type = "County",
                Name = "Homa Bay",
                LocalName = "Homa Bay"
            },
            new()
            { 
                Code = "9",
                Type = "County",
                Name = "Isiolo",
                LocalName = "Isiolo"
            },
            new()
            { 
                Code = "10",
                Type = "County",
                Name = "Kajiado",
                LocalName = "Kajiado"
            },
            new()
            { 
                Code = "11",
                Type = "County",
                Name = "Kakamega",
                LocalName = "Kakamega"
            },
            new()
            { 
                Code = "12",
                Type = "County",
                Name = "Kericho",
                LocalName = "Kericho"
            },
            new()
            { 
                Code = "13",
                Type = "County",
                Name = "Kiambu",
                LocalName = "Kiambu"
            },
            new()
            { 
                Code = "14",
                Type = "County",
                Name = "Kilifi",
                LocalName = "Kilifi"
            },
            new()
            { 
                Code = "15",
                Type = "County",
                Name = "Kirinyaga",
                LocalName = "Kirinyaga"
            },
            new()
            { 
                Code = "16",
                Type = "County",
                Name = "Kisii",
                LocalName = "Kisii"
            },
            new()
            { 
                Code = "17",
                Type = "County",
                Name = "Kisumu",
                LocalName = "Kisumu"
            },
            new()
            { 
                Code = "18",
                Type = "County",
                Name = "Kitui",
                LocalName = "Kitui"
            },
            new()
            { 
                Code = "19",
                Type = "County",
                Name = "Kwale",
                LocalName = "Kwale"
            },
            new()
            { 
                Code = "20",
                Type = "County",
                Name = "Laikipia",
                LocalName = "Laikipia"
            },
            new()
            { 
                Code = "21",
                Type = "County",
                Name = "Lamu",
                LocalName = "Lamu"
            },
            new()
            { 
                Code = "22",
                Type = "County",
                Name = "Machakos",
                LocalName = "Machakos"
            },
            new()
            { 
                Code = "23",
                Type = "County",
                Name = "Makueni",
                LocalName = "Makueni"
            },
            new()
            { 
                Code = "24",
                Type = "County",
                Name = "Mandera",
                LocalName = "Mandera"
            },
            new()
            { 
                Code = "25",
                Type = "County",
                Name = "Marsabit",
                LocalName = "Marsabit"
            },
            new()
            { 
                Code = "26",
                Type = "County",
                Name = "Meru",
                LocalName = "Meru"
            },
            new()
            { 
                Code = "27",
                Type = "County",
                Name = "Migori",
                LocalName = "Migori"
            },
            new()
            { 
                Code = "28",
                Type = "County",
                Name = "Mombasa",
                LocalName = "Mombasa"
            },
            new()
            { 
                Code = "29",
                Type = "County",
                Name = "Murang'a",
                LocalName = "Murang'a"
            },
            new()
            { 
                Code = "30",
                Type = "County",
                Name = "Nairobi City",
                LocalName = "Nairobi City"
            },
            new()
            { 
                Code = "31",
                Type = "County",
                Name = "Nakuru",
                LocalName = "Nakuru"
            },
            new()
            { 
                Code = "32",
                Type = "County",
                Name = "Nandi",
                LocalName = "Nandi"
            },
            new()
            { 
                Code = "33",
                Type = "County",
                Name = "Narok",
                LocalName = "Narok"
            },
            new()
            { 
                Code = "34",
                Type = "County",
                Name = "Nyamira",
                LocalName = "Nyamira"
            },
            new()
            { 
                Code = "35",
                Type = "County",
                Name = "Nyandarua",
                LocalName = "Nyandarua"
            },
            new()
            { 
                Code = "36",
                Type = "County",
                Name = "Nyeri",
                LocalName = "Nyeri"
            },
            new()
            { 
                Code = "37",
                Type = "County",
                Name = "Samburu",
                LocalName = "Samburu"
            },
            new()
            { 
                Code = "38",
                Type = "County",
                Name = "Siaya",
                LocalName = "Siaya"
            },
            new()
            { 
                Code = "39",
                Type = "County",
                Name = "Taita/Taveta",
                LocalName = "Taita/Taveta"
            },
            new()
            { 
                Code = "40",
                Type = "County",
                Name = "Tana River",
                LocalName = "Tana River"
            },
            new()
            { 
                Code = "41",
                Type = "County",
                Name = "Tharaka-Nithi",
                LocalName = "Tharaka-Nithi"
            },
            new()
            { 
                Code = "42",
                Type = "County",
                Name = "Trans Nzoia",
                LocalName = "Trans Nzoia"
            },
            new()
            { 
                Code = "43",
                Type = "County",
                Name = "Turkana",
                LocalName = "Turkana"
            },
            new()
            { 
                Code = "44",
                Type = "County",
                Name = "Uasin Gishu",
                LocalName = "Uasin Gishu"
            },
            new()
            { 
                Code = "45",
                Type = "County",
                Name = "Vihiga",
                LocalName = "Vihiga"
            },
            new()
            { 
                Code = "46",
                Type = "County",
                Name = "Wajir",
                LocalName = "Wajir"
            },
            new()
            { 
                Code = "47",
                Type = "County",
                Name = "West Pokot",
                LocalName = "West Pokot"
            }

        });
    }
}
