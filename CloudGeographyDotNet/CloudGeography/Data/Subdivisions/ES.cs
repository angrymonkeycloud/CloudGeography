using AngryMonkey.Cloud.Geography;
namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    private static void FillInSubdivisionsES()
    {
        AddSubdivisions("ES",
        [
            new()
            { 
                Code = "C",
                Type = SubdivisionTypes.Province,
                Name = "A Coruña",
                LocalName = "A Coruña"
            },
            new()
            { 
                Code = "VI",
                Type = SubdivisionTypes.Province,
                Name = "Álava / Araba",
                LocalName = "Álava / Araba"
            },
            new()
            { 
                Code = "AB",
                Type = SubdivisionTypes.Province,
                Name = "Albacete",
                LocalName = "Albacete"
            },
            new()
            { 
                Code = "A",
                Type = SubdivisionTypes.Province,
                Name = "Alicante / Alacant",
                LocalName = "Alicante / Alacant"
            },
            new()
            { 
                Code = "AL",
                Type = SubdivisionTypes.Province,
                Name = "Almería",
                LocalName = "Almería"
            },
            new()
            { 
                Code = "O",
                Type = SubdivisionTypes.Province,
                Name = "Asturias",
                LocalName = "Asturias"
            },
            new()
            { 
                Code = "AV",
                Type = SubdivisionTypes.Province,
                Name = "Ávila",
                LocalName = "Ávila"
            },
            new()
            { 
                Code = "BA",
                Type = SubdivisionTypes.Province,
                Name = "Badajoz",
                LocalName = "Badajoz"
            },
            new()
            { 
                Code = "PM",
                Type = SubdivisionTypes.Province,
                Name = "Balears",
                LocalName = "Balears"
            },
            new()
            { 
                Code = "B",
                Type = SubdivisionTypes.Province,
                Name = "Barcelona",
                LocalName = "Barcelona"
            },
            new()
            { 
                Code = "BI",
                Type = SubdivisionTypes.Province,
                Name = "Biskaia",
                LocalName = "Biskaia"
            },
            new()
            { 
                Code = "BU",
                Type = SubdivisionTypes.Province,
                Name = "Burgos",
                LocalName = "Burgos"
            },
            new()
            { 
                Code = "CC",
                Type = SubdivisionTypes.Province,
                Name = "Cáceres",
                LocalName = "Cáceres"
            },
            new()
            { 
                Code = "CA",
                Type = SubdivisionTypes.Province,
                Name = "Cádiz",
                LocalName = "Cádiz"
            },
            new()
            { 
                Code = "S",
                Type = SubdivisionTypes.Province,
                Name = "Cantabria",
                LocalName = "Cantabria"
            },
            new()
            { 
                Code = "CS",
                Type = SubdivisionTypes.Province,
                Name = "Castellón / Castelló",
                LocalName = "Castellón / Castelló"
            },
            new()
            { 
                Code = "CR",
                Type = SubdivisionTypes.Province,
                Name = "Ciudad Real",
                LocalName = "Ciudad Real"
            },
            new()
            { 
                Code = "CO",
                Type = SubdivisionTypes.Province,
                Name = "Córdoba",
                LocalName = "Córdoba"
            },
            new()
            { 
                Code = "CU",
                Type = SubdivisionTypes.Province,
                Name = "Cuenca",
                LocalName = "Cuenca"
            },
            new()
            { 
                Code = "SS",
                Type = SubdivisionTypes.Province,
                Name = "Gipuzkoa",
                LocalName = "Gipuzkoa"
            },
            new()
            { 
                Code = "GI",
                Type = SubdivisionTypes.Province,
                Name = "Girona",
                LocalName = "Girona"
            },
            new()
            { 
                Code = "GR",
                Type = SubdivisionTypes.Province,
                Name = "Granada",
                LocalName = "Granada"
            },
            new()
            { 
                Code = "GU",
                Type = SubdivisionTypes.Province,
                Name = "Guadalajara",
                LocalName = "Guadalajara"
            },
            new()
            { 
                Code = "H",
                Type = SubdivisionTypes.Province,
                Name = "Huelva",
                LocalName = "Huelva"
            },
            new()
            { 
                Code = "HU",
                Type = SubdivisionTypes.Province,
                Name = "Huesca",
                LocalName = "Huesca"
            },
            new()
            { 
                Code = "J",
                Type = SubdivisionTypes.Province,
                Name = "Jaén",
                LocalName = "Jaén"
            },
            new()
            { 
                Code = "LO",
                Type = SubdivisionTypes.Province,
                Name = "La Rioja",
                LocalName = "La Rioja"
            },
            new()
            { 
                Code = "GC",
                Type = SubdivisionTypes.Province,
                Name = "Las Palmas",
                LocalName = "Las Palmas"
            },
            new()
            { 
                Code = "LE",
                Type = SubdivisionTypes.Province,
                Name = "León",
                LocalName = "León"
            },
            new()
            { 
                Code = "L",
                Type = SubdivisionTypes.Province,
                Name = "Lleida",
                LocalName = "Lleida"
            },
            new()
            { 
                Code = "LU",
                Type = SubdivisionTypes.Province,
                Name = "Lugo",
                LocalName = "Lugo"
            },
            new()
            { 
                Code = "M",
                Type = SubdivisionTypes.Province,
                Name = "Madrid",
                LocalName = "Madrid"
            },
            new()
            { 
                Code = "MA",
                Type = SubdivisionTypes.Province,
                Name = "Málaga",
                LocalName = "Málaga"
            },
            new()
            { 
                Code = "MU",
                Type = SubdivisionTypes.Province,
                Name = "Murcia",
                LocalName = "Murcia"
            },
            new()
            { 
                Code = "NA",
                Type = SubdivisionTypes.Province,
                Name = "Navarra / Nafarroa",
                LocalName = "Navarra / Nafarroa"
            },
            new()
            { 
                Code = "OR",
                Type = SubdivisionTypes.Province,
                Name = "Ourense",
                LocalName = "Ourense"
            },
            new()
            { 
                Code = "P",
                Type = SubdivisionTypes.Province,
                Name = "Palencia",
                LocalName = "Palencia"
            },
            new()
            { 
                Code = "PO",
                Type = SubdivisionTypes.Province,
                Name = "Pontevedra",
                LocalName = "Pontevedra"
            },
            new()
            { 
                Code = "SA",
                Type = SubdivisionTypes.Province,
                Name = "Salamanca",
                LocalName = "Salamanca"
            },
            new()
            { 
                Code = "TF",
                Type = SubdivisionTypes.Province,
                Name = "Santa Cruz de Tenerife",
                LocalName = "Santa Cruz de Tenerife"
            },
            new()
            { 
                Code = "SG",
                Type = SubdivisionTypes.Province,
                Name = "Segovia",
                LocalName = "Segovia"
            },
            new()
            { 
                Code = "SE",
                Type = SubdivisionTypes.Province,
                Name = "Sevilla",
                LocalName = "Sevilla"
            },
            new()
            { 
                Code = "SO",
                Type = SubdivisionTypes.Province,
                Name = "Soria",
                LocalName = "Soria"
            },
            new()
            { 
                Code = "T",
                Type = SubdivisionTypes.Province,
                Name = "Tarragona",
                LocalName = "Tarragona"
            },
            new()
            { 
                Code = "TE",
                Type = SubdivisionTypes.Province,
                Name = "Teruel",
                LocalName = "Teruel"
            },
            new()
            { 
                Code = "TO",
                Type = SubdivisionTypes.Province,
                Name = "Toledo",
                LocalName = "Toledo"
            },
            new()
            { 
                Code = "V",
                Type = SubdivisionTypes.Province,
                Name = "Valencia / València",
                LocalName = "Valencia / València"
            },
            new()
            { 
                Code = "VA",
                Type = SubdivisionTypes.Province,
                Name = "Valladolid",
                LocalName = "Valladolid"
            },
            new()
            { 
                Code = "ZA",
                Type = SubdivisionTypes.Province,
                Name = "Zamora",
                LocalName = "Zamora"
            },
            new()
            { 
                Code = "Z",
                Type = SubdivisionTypes.Province,
                Name = "Zaragoza",
                LocalName = "Zaragoza"
            }

        ]);
    }
}
