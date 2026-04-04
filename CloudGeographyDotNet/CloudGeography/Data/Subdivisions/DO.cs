using AngryMonkey.Cloud.Geography;
namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    private static void FillInSubdivisionsDO()
    {
        AddSubdivisions("DO",
        [
            new()
            { 
                Code = "2",
                Type = SubdivisionTypes.Province,
                Name = "Azua",
                LocalName = "Azua"
            },
            new()
            { 
                Code = "3",
                Type = SubdivisionTypes.Province,
                Name = "Baoruco",
                LocalName = "Baoruco"
            },
            new()
            { 
                Code = "4",
                Type = SubdivisionTypes.Province,
                Name = "Barahona",
                LocalName = "Barahona"
            },
            new()
            { 
                Code = "33",
                Type = SubdivisionTypes.Region,
                Name = "Cibao Nordeste",
                LocalName = "Cibao Nordeste"
            },
            new()
            { 
                Code = "34",
                Type = SubdivisionTypes.Region,
                Name = "Cibao Noroeste",
                LocalName = "Cibao Noroeste"
            },
            new()
            { 
                Code = "35",
                Type = SubdivisionTypes.Region,
                Name = "Cibao Norte",
                LocalName = "Cibao Norte"
            },
            new()
            { 
                Code = "36",
                Type = SubdivisionTypes.Region,
                Name = "Cibao Sur",
                LocalName = "Cibao Sur"
            },
            new()
            { 
                Code = "5",
                Type = SubdivisionTypes.Province,
                Name = "Dajabón",
                LocalName = "Dajabón"
            },
            new()
            { 
                Code = "1",
                Type = SubdivisionTypes.District,
                Name = "Distrito Nacional",
                LocalName = "Distrito Nacional"
            },
            new()
            { 
                Code = "6",
                Type = SubdivisionTypes.Province,
                Name = "Duarte",
                LocalName = "Duarte"
            },
            new()
            { 
                Code = "8",
                Type = SubdivisionTypes.Province,
                Name = "El Seibo",
                LocalName = "El Seibo"
            },
            new()
            { 
                Code = "37",
                Type = SubdivisionTypes.Region,
                Name = "El Valle",
                LocalName = "El Valle"
            },
            new()
            { 
                Code = "7",
                Type = SubdivisionTypes.Province,
                Name = "Elías Piña",
                LocalName = "Elías Piña"
            },
            new()
            { 
                Code = "38",
                Type = SubdivisionTypes.Region,
                Name = "Enriquillo",
                LocalName = "Enriquillo"
            },
            new()
            { 
                Code = "9",
                Type = SubdivisionTypes.Province,
                Name = "Espaillat",
                LocalName = "Espaillat"
            },
            new()
            { 
                Code = "30",
                Type = SubdivisionTypes.Province,
                Name = "Hato Mayor",
                LocalName = "Hato Mayor"
            },
            new()
            { 
                Code = "19",
                Type = SubdivisionTypes.Province,
                Name = "Hermanas Mirabal",
                LocalName = "Hermanas Mirabal"
            },
            new()
            { 
                Code = "39",
                Type = SubdivisionTypes.Region,
                Name = "Higuamo",
                LocalName = "Higuamo"
            },
            new()
            { 
                Code = "10",
                Type = SubdivisionTypes.Province,
                Name = "Independencia",
                LocalName = "Independencia"
            },
            new()
            { 
                Code = "11",
                Type = SubdivisionTypes.Province,
                Name = "La Altagracia",
                LocalName = "La Altagracia"
            },
            new()
            { 
                Code = "12",
                Type = SubdivisionTypes.Province,
                Name = "La Romana",
                LocalName = "La Romana"
            },
            new()
            { 
                Code = "13",
                Type = SubdivisionTypes.Province,
                Name = "La Vega",
                LocalName = "La Vega"
            },
            new()
            { 
                Code = "14",
                Type = SubdivisionTypes.Province,
                Name = "María Trinidad Sánchez",
                LocalName = "María Trinidad Sánchez"
            },
            new()
            { 
                Code = "28",
                Type = SubdivisionTypes.Province,
                Name = "Monseñor Nouel",
                LocalName = "Monseñor Nouel"
            },
            new()
            { 
                Code = "15",
                Type = SubdivisionTypes.Province,
                Name = "Monte Cristi",
                LocalName = "Monte Cristi"
            },
            new()
            { 
                Code = "29",
                Type = SubdivisionTypes.Province,
                Name = "Monte Plata",
                LocalName = "Monte Plata"
            },
            new()
            { 
                Code = "40",
                Type = SubdivisionTypes.Region,
                Name = "Ozama",
                LocalName = "Ozama"
            },
            new()
            { 
                Code = "16",
                Type = SubdivisionTypes.Province,
                Name = "Pedernales",
                LocalName = "Pedernales"
            },
            new()
            { 
                Code = "17",
                Type = SubdivisionTypes.Province,
                Name = "Peravia",
                LocalName = "Peravia"
            },
            new()
            { 
                Code = "18",
                Type = SubdivisionTypes.Province,
                Name = "Puerto Plata",
                LocalName = "Puerto Plata"
            },
            new()
            { 
                Code = "20",
                Type = SubdivisionTypes.Province,
                Name = "Samaná",
                LocalName = "Samaná"
            },
            new()
            { 
                Code = "21",
                Type = SubdivisionTypes.Province,
                Name = "San Cristóbal",
                LocalName = "San Cristóbal"
            },
            new()
            { 
                Code = "31",
                Type = SubdivisionTypes.Province,
                Name = "San José de Ocoa",
                LocalName = "San José de Ocoa"
            },
            new()
            { 
                Code = "22",
                Type = SubdivisionTypes.Province,
                Name = "San Juan",
                LocalName = "San Juan"
            },
            new()
            { 
                Code = "23",
                Type = SubdivisionTypes.Province,
                Name = "San Pedro de Macorís",
                LocalName = "San Pedro de Macorís"
            },
            new()
            { 
                Code = "24",
                Type = SubdivisionTypes.Province,
                Name = "Sánchez Ramírez",
                LocalName = "Sánchez Ramírez"
            },
            new()
            { 
                Code = "25",
                Type = SubdivisionTypes.Province,
                Name = "Santiago",
                LocalName = "Santiago"
            },
            new()
            { 
                Code = "26",
                Type = SubdivisionTypes.Province,
                Name = "Santiago Rodríguez",
                LocalName = "Santiago Rodríguez"
            },
            new()
            { 
                Code = "32",
                Type = SubdivisionTypes.Province,
                Name = "Santo Domingo",
                LocalName = "Santo Domingo"
            },
            new()
            { 
                Code = "41",
                Type = SubdivisionTypes.Region,
                Name = "Valdesia",
                LocalName = "Valdesia"
            },
            new()
            { 
                Code = "27",
                Type = SubdivisionTypes.Province,
                Name = "Valverde",
                LocalName = "Valverde"
            },
            new()
            { 
                Code = "42",
                Type = SubdivisionTypes.Region,
                Name = "Yuma",
                LocalName = "Yuma"
            }

        ]);
    }
}
