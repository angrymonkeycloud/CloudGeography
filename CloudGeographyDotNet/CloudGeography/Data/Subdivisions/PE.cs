using AngryMonkey.Cloud.Geography;
namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    private static void FillInSubdivisionsPE()
    {
        AddSubdivisions("PE",
        [
            new()
            { 
                Code = "AMA",
                Type = SubdivisionTypes.Region,
                Name = "Amazonas",
                LocalName = "Amazonas"
            },
            new()
            { 
                Code = "ANC",
                Type = SubdivisionTypes.Region,
                Name = "Ancash",
                LocalName = "Ancash"
            },
            new()
            { 
                Code = "APU",
                Type = SubdivisionTypes.Region,
                Name = "Apurímac",
                LocalName = "Apurímac"
            },
            new()
            { 
                Code = "ARE",
                Type = SubdivisionTypes.Region,
                Name = "Arequipa",
                LocalName = "Arequipa"
            },
            new()
            { 
                Code = "AYA",
                Type = SubdivisionTypes.Region,
                Name = "Ayacucho",
                LocalName = "Ayacucho"
            },
            new()
            { 
                Code = "CAJ",
                Type = SubdivisionTypes.Region,
                Name = "Cajamarca",
                LocalName = "Cajamarca"
            },
            new()
            { 
                Code = "CUS",
                Type = SubdivisionTypes.Region,
                Name = "Cuzco",
                LocalName = "Cuzco"
            },
            new()
            { 
                Code = "CAL",
                Type = SubdivisionTypes.Region,
                Name = "El Callao",
                LocalName = "El Callao"
            },
            new()
            { 
                Code = "HUV",
                Type = SubdivisionTypes.Region,
                Name = "Huancavelica",
                LocalName = "Huancavelica"
            },
            new()
            { 
                Code = "HUC",
                Type = SubdivisionTypes.Region,
                Name = "Huánuco",
                LocalName = "Huánuco"
            },
            new()
            { 
                Code = "ICA",
                Type = SubdivisionTypes.Region,
                Name = "Ica",
                LocalName = "Ica"
            },
            new()
            { 
                Code = "JUN",
                Type = SubdivisionTypes.Region,
                Name = "Junín",
                LocalName = "Junín"
            },
            new()
            { 
                Code = "LAL",
                Type = SubdivisionTypes.Region,
                Name = "La Libertad",
                LocalName = "La Libertad"
            },
            new()
            { 
                Code = "LAM",
                Type = SubdivisionTypes.Region,
                Name = "Lambayeque",
                LocalName = "Lambayeque"
            },
            new()
            { 
                Code = "LIM",
                Type = SubdivisionTypes.Region,
                Name = "Lima",
                LocalName = "Lima"
            },
            new()
            { 
                Code = "LMA",
                Type = SubdivisionTypes.Municipality,
                Name = "Lima hatun llaqta",
                LocalName = "Lima hatun llaqta"
            },
            new()
            { 
                Code = "LOR",
                Type = SubdivisionTypes.Region,
                Name = "Loreto",
                LocalName = "Loreto"
            },
            new()
            { 
                Code = "MDD",
                Type = SubdivisionTypes.Region,
                Name = "Madre de Dios",
                LocalName = "Madre de Dios"
            },
            new()
            { 
                Code = "MOQ",
                Type = SubdivisionTypes.Region,
                Name = "Moquegua",
                LocalName = "Moquegua"
            },
            new()
            { 
                Code = "PAS",
                Type = SubdivisionTypes.Region,
                Name = "Pasco",
                LocalName = "Pasco"
            },
            new()
            { 
                Code = "PIU",
                Type = SubdivisionTypes.Region,
                Name = "Piura",
                LocalName = "Piura"
            },
            new()
            { 
                Code = "PUN",
                Type = SubdivisionTypes.Region,
                Name = "Puno",
                LocalName = "Puno"
            },
            new()
            { 
                Code = "SAM",
                Type = SubdivisionTypes.Region,
                Name = "San Martín",
                LocalName = "San Martín"
            },
            new()
            { 
                Code = "TAC",
                Type = SubdivisionTypes.Region,
                Name = "Tacna",
                LocalName = "Tacna"
            },
            new()
            { 
                Code = "TUM",
                Type = SubdivisionTypes.Region,
                Name = "Tumbes",
                LocalName = "Tumbes"
            },
            new()
            { 
                Code = "UCA",
                Type = SubdivisionTypes.Region,
                Name = "Ucayali",
                LocalName = "Ucayali"
            }

        ]);
    }
}
