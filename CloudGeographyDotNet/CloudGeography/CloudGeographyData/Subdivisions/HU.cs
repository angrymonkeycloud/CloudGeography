using AngryMonkey.Cloud.Geography;
namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    private static void FillInSubdivisionsHU()
    {
        AddSubdivisions("HU", new List<Subdivision>()
        {
            new()
            { 
                Code = "BK",
                Type = "County",
                Name = "Bács-Kiskun",
                LocalName = "Bács-Kiskun"
            },
            new()
            { 
                Code = "BA",
                Type = "County",
                Name = "Baranya",
                LocalName = "Baranya"
            },
            new()
            { 
                Code = "BE",
                Type = "County",
                Name = "Békés",
                LocalName = "Békés"
            },
            new()
            { 
                Code = "BZ",
                Type = "County",
                Name = "Borsod-Abaúj-Zemplén",
                LocalName = "Borsod-Abaúj-Zemplén"
            },
            new()
            { 
                Code = "BU",
                Type = "CapitalCity",
                Name = "Budapest",
                LocalName = "Budapest"
            },
            new()
            { 
                Code = "CS",
                Type = "County",
                Name = "Csongrád",
                LocalName = "Csongrád"
            },
            new()
            { 
                Code = "FE",
                Type = "County",
                Name = "Fejér",
                LocalName = "Fejér"
            },
            new()
            { 
                Code = "GS",
                Type = "County",
                Name = "Gyor-Moson-Sopron",
                LocalName = "Gyor-Moson-Sopron"
            },
            new()
            { 
                Code = "HB",
                Type = "County",
                Name = "Hajdú-Bihar",
                LocalName = "Hajdú-Bihar"
            },
            new()
            { 
                Code = "HE",
                Type = "County",
                Name = "Heves",
                LocalName = "Heves"
            },
            new()
            { 
                Code = "JN",
                Type = "County",
                Name = "Jász-Nagykun-Szolnok",
                LocalName = "Jász-Nagykun-Szolnok"
            },
            new()
            { 
                Code = "KE",
                Type = "County",
                Name = "Komárom-Esztergom",
                LocalName = "Komárom-Esztergom"
            },
            new()
            { 
                Code = "NO",
                Type = "County",
                Name = "Nógrád",
                LocalName = "Nógrád"
            },
            new()
            { 
                Code = "PE",
                Type = "County",
                Name = "Pest",
                LocalName = "Pest"
            },
            new()
            { 
                Code = "SO",
                Type = "County",
                Name = "Somogy",
                LocalName = "Somogy"
            },
            new()
            { 
                Code = "SZ",
                Type = "County",
                Name = "Szabolcs-Szatmár-Bereg",
                LocalName = "Szabolcs-Szatmár-Bereg"
            },
            new()
            { 
                Code = "TO",
                Type = "County",
                Name = "Tolna",
                LocalName = "Tolna"
            },
            new()
            { 
                Code = "VA",
                Type = "County",
                Name = "Vas",
                LocalName = "Vas"
            },
            new()
            { 
                Code = "VE",
                Type = "County",
                Name = "Veszprém",
                LocalName = "Veszprém"
            },
            new()
            { 
                Code = "ZA",
                Type = "County",
                Name = "Zala",
                LocalName = "Zala"
            }

        });
    }
}
