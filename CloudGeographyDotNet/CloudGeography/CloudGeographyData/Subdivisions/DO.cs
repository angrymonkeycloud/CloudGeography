using AngryMonkey.Cloud.Geography;
namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    private static void FillInSubdivisionsDO()
    {
        AddSubdivisions("DO", new List<Subdivision>()
        {
            new()
            { 
                Code = "2",
                Type = "Province",
                Name = "Azua",
                LocalName = "Azua"
            },
            new()
            { 
                Code = "3",
                Type = "Province",
                Name = "Baoruco",
                LocalName = "Baoruco"
            },
            new()
            { 
                Code = "4",
                Type = "Province",
                Name = "Barahona",
                LocalName = "Barahona"
            },
            new()
            { 
                Code = "33",
                Type = "Region",
                Name = "Cibao Nordeste",
                LocalName = "Cibao Nordeste"
            },
            new()
            { 
                Code = "34",
                Type = "Region",
                Name = "Cibao Noroeste",
                LocalName = "Cibao Noroeste"
            },
            new()
            { 
                Code = "35",
                Type = "Region",
                Name = "Cibao Norte",
                LocalName = "Cibao Norte"
            },
            new()
            { 
                Code = "36",
                Type = "Region",
                Name = "Cibao Sur",
                LocalName = "Cibao Sur"
            },
            new()
            { 
                Code = "5",
                Type = "Province",
                Name = "Dajabón",
                LocalName = "Dajabón"
            },
            new()
            { 
                Code = "1",
                Type = "District",
                Name = "Distrito Nacional",
                LocalName = "Distrito Nacional"
            },
            new()
            { 
                Code = "6",
                Type = "Province",
                Name = "Duarte",
                LocalName = "Duarte"
            },
            new()
            { 
                Code = "8",
                Type = "Province",
                Name = "El Seibo",
                LocalName = "El Seibo"
            },
            new()
            { 
                Code = "37",
                Type = "Region",
                Name = "El Valle",
                LocalName = "El Valle"
            },
            new()
            { 
                Code = "7",
                Type = "Province",
                Name = "Elías Piña",
                LocalName = "Elías Piña"
            },
            new()
            { 
                Code = "38",
                Type = "Region",
                Name = "Enriquillo",
                LocalName = "Enriquillo"
            },
            new()
            { 
                Code = "9",
                Type = "Province",
                Name = "Espaillat",
                LocalName = "Espaillat"
            },
            new()
            { 
                Code = "30",
                Type = "Province",
                Name = "Hato Mayor",
                LocalName = "Hato Mayor"
            },
            new()
            { 
                Code = "19",
                Type = "Province",
                Name = "Hermanas Mirabal",
                LocalName = "Hermanas Mirabal"
            },
            new()
            { 
                Code = "39",
                Type = "Region",
                Name = "Higuamo",
                LocalName = "Higuamo"
            },
            new()
            { 
                Code = "10",
                Type = "Province",
                Name = "Independencia",
                LocalName = "Independencia"
            },
            new()
            { 
                Code = "11",
                Type = "Province",
                Name = "La Altagracia",
                LocalName = "La Altagracia"
            },
            new()
            { 
                Code = "12",
                Type = "Province",
                Name = "La Romana",
                LocalName = "La Romana"
            },
            new()
            { 
                Code = "13",
                Type = "Province",
                Name = "La Vega",
                LocalName = "La Vega"
            },
            new()
            { 
                Code = "14",
                Type = "Province",
                Name = "María Trinidad Sánchez",
                LocalName = "María Trinidad Sánchez"
            },
            new()
            { 
                Code = "28",
                Type = "Province",
                Name = "Monseñor Nouel",
                LocalName = "Monseñor Nouel"
            },
            new()
            { 
                Code = "15",
                Type = "Province",
                Name = "Monte Cristi",
                LocalName = "Monte Cristi"
            },
            new()
            { 
                Code = "29",
                Type = "Province",
                Name = "Monte Plata",
                LocalName = "Monte Plata"
            },
            new()
            { 
                Code = "40",
                Type = "Region",
                Name = "Ozama",
                LocalName = "Ozama"
            },
            new()
            { 
                Code = "16",
                Type = "Province",
                Name = "Pedernales",
                LocalName = "Pedernales"
            },
            new()
            { 
                Code = "17",
                Type = "Province",
                Name = "Peravia",
                LocalName = "Peravia"
            },
            new()
            { 
                Code = "18",
                Type = "Province",
                Name = "Puerto Plata",
                LocalName = "Puerto Plata"
            },
            new()
            { 
                Code = "20",
                Type = "Province",
                Name = "Samaná",
                LocalName = "Samaná"
            },
            new()
            { 
                Code = "21",
                Type = "Province",
                Name = "San Cristóbal",
                LocalName = "San Cristóbal"
            },
            new()
            { 
                Code = "31",
                Type = "Province",
                Name = "San José de Ocoa",
                LocalName = "San José de Ocoa"
            },
            new()
            { 
                Code = "22",
                Type = "Province",
                Name = "San Juan",
                LocalName = "San Juan"
            },
            new()
            { 
                Code = "23",
                Type = "Province",
                Name = "San Pedro de Macorís",
                LocalName = "San Pedro de Macorís"
            },
            new()
            { 
                Code = "24",
                Type = "Province",
                Name = "Sánchez Ramírez",
                LocalName = "Sánchez Ramírez"
            },
            new()
            { 
                Code = "25",
                Type = "Province",
                Name = "Santiago",
                LocalName = "Santiago"
            },
            new()
            { 
                Code = "26",
                Type = "Province",
                Name = "Santiago Rodríguez",
                LocalName = "Santiago Rodríguez"
            },
            new()
            { 
                Code = "32",
                Type = "Province",
                Name = "Santo Domingo",
                LocalName = "Santo Domingo"
            },
            new()
            { 
                Code = "41",
                Type = "Region",
                Name = "Valdesia",
                LocalName = "Valdesia"
            },
            new()
            { 
                Code = "27",
                Type = "Province",
                Name = "Valverde",
                LocalName = "Valverde"
            },
            new()
            { 
                Code = "42",
                Type = "Region",
                Name = "Yuma",
                LocalName = "Yuma"
            }

        });
    }
}
