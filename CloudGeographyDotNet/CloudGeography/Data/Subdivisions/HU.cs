using AngryMonkey.Cloud.Geography;
namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    private static void FillInSubdivisionsHU()
    {
        AddSubdivisions("HU",
        [
            new()
            { 
                Code = "BK",
                Type = SubdivisionTypes.County,
                Name = "Bács-Kiskun",
                LocalName = "Bács-Kiskun"
            },
            new()
            { 
                Code = "BA",
                Type = SubdivisionTypes.County,
                Name = "Baranya",
                LocalName = "Baranya"
            },
            new()
            { 
                Code = "BE",
                Type = SubdivisionTypes.County,
                Name = "Békés",
                LocalName = "Békés"
            },
            new()
            { 
                Code = "BZ",
                Type = SubdivisionTypes.County,
                Name = "Borsod-Abaúj-Zemplén",
                LocalName = "Borsod-Abaúj-Zemplén"
            },
            new()
            { 
                Code = "BU",
                Type = SubdivisionTypes.CapitalCity,
                Name = "Budapest",
                LocalName = "Budapest"
            },
            new()
            { 
                Code = "CS",
                Type = SubdivisionTypes.County,
                Name = "Csongrád",
                LocalName = "Csongrád"
            },
            new()
            { 
                Code = "FE",
                Type = SubdivisionTypes.County,
                Name = "Fejér",
                LocalName = "Fejér"
            },
            new()
            { 
                Code = "GS",
                Type = SubdivisionTypes.County,
                Name = "Gyor-Moson-Sopron",
                LocalName = "Gyor-Moson-Sopron"
            },
            new()
            { 
                Code = "HB",
                Type = SubdivisionTypes.County,
                Name = "Hajdú-Bihar",
                LocalName = "Hajdú-Bihar"
            },
            new()
            { 
                Code = "HE",
                Type = SubdivisionTypes.County,
                Name = "Heves",
                LocalName = "Heves"
            },
            new()
            { 
                Code = "JN",
                Type = SubdivisionTypes.County,
                Name = "Jász-Nagykun-Szolnok",
                LocalName = "Jász-Nagykun-Szolnok"
            },
            new()
            { 
                Code = "KE",
                Type = SubdivisionTypes.County,
                Name = "Komárom-Esztergom",
                LocalName = "Komárom-Esztergom"
            },
            new()
            { 
                Code = "NO",
                Type = SubdivisionTypes.County,
                Name = "Nógrád",
                LocalName = "Nógrád"
            },
            new()
            { 
                Code = "PE",
                Type = SubdivisionTypes.County,
                Name = "Pest",
                LocalName = "Pest"
            },
            new()
            { 
                Code = "SO",
                Type = SubdivisionTypes.County,
                Name = "Somogy",
                LocalName = "Somogy"
            },
            new()
            { 
                Code = "SZ",
                Type = SubdivisionTypes.County,
                Name = "Szabolcs-Szatmár-Bereg",
                LocalName = "Szabolcs-Szatmár-Bereg"
            },
            new()
            { 
                Code = "TO",
                Type = SubdivisionTypes.County,
                Name = "Tolna",
                LocalName = "Tolna"
            },
            new()
            { 
                Code = "VA",
                Type = SubdivisionTypes.County,
                Name = "Vas",
                LocalName = "Vas"
            },
            new()
            { 
                Code = "VE",
                Type = SubdivisionTypes.County,
                Name = "Veszprém",
                LocalName = "Veszprém"
            },
            new()
            { 
                Code = "ZA",
                Type = SubdivisionTypes.County,
                Name = "Zala",
                LocalName = "Zala"
            }

        ]);
    }
}
