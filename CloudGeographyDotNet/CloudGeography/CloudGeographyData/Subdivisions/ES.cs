using AngryMonkey.Cloud.Geography;
namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    private static void FillInSubdivisionsES()
    {
        AddSubdivisions("ES", new List<Subdivision>()
        {
            new()
            { 
                Code = "C",
                Type = "Province",
                Name = "A Coruña",
                LocalName = "A Coruña"
            },
            new()
            { 
                Code = "VI",
                Type = "Province",
                Name = "Álava / Araba",
                LocalName = "Álava / Araba"
            },
            new()
            { 
                Code = "AB",
                Type = "Province",
                Name = "Albacete",
                LocalName = "Albacete"
            },
            new()
            { 
                Code = "A",
                Type = "Province",
                Name = "Alicante / Alacant",
                LocalName = "Alicante / Alacant"
            },
            new()
            { 
                Code = "AL",
                Type = "Province",
                Name = "Almería",
                LocalName = "Almería"
            },
            new()
            { 
                Code = "O",
                Type = "Province",
                Name = "Asturias",
                LocalName = "Asturias"
            },
            new()
            { 
                Code = "AV",
                Type = "Province",
                Name = "Ávila",
                LocalName = "Ávila"
            },
            new()
            { 
                Code = "BA",
                Type = "Province",
                Name = "Badajoz",
                LocalName = "Badajoz"
            },
            new()
            { 
                Code = "PM",
                Type = "Province",
                Name = "Balears",
                LocalName = "Balears"
            },
            new()
            { 
                Code = "B",
                Type = "Province",
                Name = "Barcelona",
                LocalName = "Barcelona"
            },
            new()
            { 
                Code = "BI",
                Type = "Province",
                Name = "Biskaia",
                LocalName = "Biskaia"
            },
            new()
            { 
                Code = "BU",
                Type = "Province",
                Name = "Burgos",
                LocalName = "Burgos"
            },
            new()
            { 
                Code = "CC",
                Type = "Province",
                Name = "Cáceres",
                LocalName = "Cáceres"
            },
            new()
            { 
                Code = "CA",
                Type = "Province",
                Name = "Cádiz",
                LocalName = "Cádiz"
            },
            new()
            { 
                Code = "S",
                Type = "Province",
                Name = "Cantabria",
                LocalName = "Cantabria"
            },
            new()
            { 
                Code = "CS",
                Type = "Province",
                Name = "Castellón / Castelló",
                LocalName = "Castellón / Castelló"
            },
            new()
            { 
                Code = "CR",
                Type = "Province",
                Name = "Ciudad Real",
                LocalName = "Ciudad Real"
            },
            new()
            { 
                Code = "CO",
                Type = "Province",
                Name = "Córdoba",
                LocalName = "Córdoba"
            },
            new()
            { 
                Code = "CU",
                Type = "Province",
                Name = "Cuenca",
                LocalName = "Cuenca"
            },
            new()
            { 
                Code = "SS",
                Type = "Province",
                Name = "Gipuzkoa",
                LocalName = "Gipuzkoa"
            },
            new()
            { 
                Code = "GI",
                Type = "Province",
                Name = "Girona",
                LocalName = "Girona"
            },
            new()
            { 
                Code = "GR",
                Type = "Province",
                Name = "Granada",
                LocalName = "Granada"
            },
            new()
            { 
                Code = "GU",
                Type = "Province",
                Name = "Guadalajara",
                LocalName = "Guadalajara"
            },
            new()
            { 
                Code = "H",
                Type = "Province",
                Name = "Huelva",
                LocalName = "Huelva"
            },
            new()
            { 
                Code = "HU",
                Type = "Province",
                Name = "Huesca",
                LocalName = "Huesca"
            },
            new()
            { 
                Code = "J",
                Type = "Province",
                Name = "Jaén",
                LocalName = "Jaén"
            },
            new()
            { 
                Code = "LO",
                Type = "Province",
                Name = "La Rioja",
                LocalName = "La Rioja"
            },
            new()
            { 
                Code = "GC",
                Type = "Province",
                Name = "Las Palmas",
                LocalName = "Las Palmas"
            },
            new()
            { 
                Code = "LE",
                Type = "Province",
                Name = "León",
                LocalName = "León"
            },
            new()
            { 
                Code = "L",
                Type = "Province",
                Name = "Lleida",
                LocalName = "Lleida"
            },
            new()
            { 
                Code = "LU",
                Type = "Province",
                Name = "Lugo",
                LocalName = "Lugo"
            },
            new()
            { 
                Code = "M",
                Type = "Province",
                Name = "Madrid",
                LocalName = "Madrid"
            },
            new()
            { 
                Code = "MA",
                Type = "Province",
                Name = "Málaga",
                LocalName = "Málaga"
            },
            new()
            { 
                Code = "MU",
                Type = "Province",
                Name = "Murcia",
                LocalName = "Murcia"
            },
            new()
            { 
                Code = "NA",
                Type = "Province",
                Name = "Navarra / Nafarroa",
                LocalName = "Navarra / Nafarroa"
            },
            new()
            { 
                Code = "OR",
                Type = "Province",
                Name = "Ourense",
                LocalName = "Ourense"
            },
            new()
            { 
                Code = "P",
                Type = "Province",
                Name = "Palencia",
                LocalName = "Palencia"
            },
            new()
            { 
                Code = "PO",
                Type = "Province",
                Name = "Pontevedra",
                LocalName = "Pontevedra"
            },
            new()
            { 
                Code = "SA",
                Type = "Province",
                Name = "Salamanca",
                LocalName = "Salamanca"
            },
            new()
            { 
                Code = "TF",
                Type = "Province",
                Name = "Santa Cruz de Tenerife",
                LocalName = "Santa Cruz de Tenerife"
            },
            new()
            { 
                Code = "SG",
                Type = "Province",
                Name = "Segovia",
                LocalName = "Segovia"
            },
            new()
            { 
                Code = "SE",
                Type = "Province",
                Name = "Sevilla",
                LocalName = "Sevilla"
            },
            new()
            { 
                Code = "SO",
                Type = "Province",
                Name = "Soria",
                LocalName = "Soria"
            },
            new()
            { 
                Code = "T",
                Type = "Province",
                Name = "Tarragona",
                LocalName = "Tarragona"
            },
            new()
            { 
                Code = "TE",
                Type = "Province",
                Name = "Teruel",
                LocalName = "Teruel"
            },
            new()
            { 
                Code = "TO",
                Type = "Province",
                Name = "Toledo",
                LocalName = "Toledo"
            },
            new()
            { 
                Code = "V",
                Type = "Province",
                Name = "Valencia / València",
                LocalName = "Valencia / València"
            },
            new()
            { 
                Code = "VA",
                Type = "Province",
                Name = "Valladolid",
                LocalName = "Valladolid"
            },
            new()
            { 
                Code = "ZA",
                Type = "Province",
                Name = "Zamora",
                LocalName = "Zamora"
            },
            new()
            { 
                Code = "Z",
                Type = "Province",
                Name = "Zaragoza",
                LocalName = "Zaragoza"
            }

        });
    }
}
