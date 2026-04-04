using AngryMonkey.Cloud.Geography;
namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    private static void FillInSubdivisionsHN()
    {
        AddSubdivisions("HN",
        [
            new()
            { 
                Code = "AT",
                Type = SubdivisionTypes.Department,
                Name = "Atlántida",
                LocalName = "Atlántida"
            },
            new()
            { 
                Code = "CH",
                Type = SubdivisionTypes.Department,
                Name = "Choluteca",
                LocalName = "Choluteca"
            },
            new()
            { 
                Code = "CL",
                Type = SubdivisionTypes.Department,
                Name = "Colón",
                LocalName = "Colón"
            },
            new()
            { 
                Code = "CM",
                Type = SubdivisionTypes.Department,
                Name = "Comayagua",
                LocalName = "Comayagua"
            },
            new()
            { 
                Code = "CP",
                Type = SubdivisionTypes.Department,
                Name = "Copán",
                LocalName = "Copán"
            },
            new()
            { 
                Code = "CR",
                Type = SubdivisionTypes.Department,
                Name = "Cortés",
                LocalName = "Cortés"
            },
            new()
            { 
                Code = "EP",
                Type = SubdivisionTypes.Department,
                Name = "El Paraíso",
                LocalName = "El Paraíso"
            },
            new()
            { 
                Code = "FM",
                Type = SubdivisionTypes.Department,
                Name = "Francisco Morazán",
                LocalName = "Francisco Morazán"
            },
            new()
            { 
                Code = "GD",
                Type = SubdivisionTypes.Department,
                Name = "Gracias a Dios",
                LocalName = "Gracias a Dios"
            },
            new()
            { 
                Code = "IN",
                Type = SubdivisionTypes.Department,
                Name = "Intibucá",
                LocalName = "Intibucá"
            },
            new()
            { 
                Code = "IB",
                Type = SubdivisionTypes.Department,
                Name = "Islas de la Bahía",
                LocalName = "Islas de la Bahía"
            },
            new()
            { 
                Code = "LP",
                Type = SubdivisionTypes.Department,
                Name = "La Paz",
                LocalName = "La Paz"
            },
            new()
            { 
                Code = "LE",
                Type = SubdivisionTypes.Department,
                Name = "Lempira",
                LocalName = "Lempira"
            },
            new()
            { 
                Code = "OC",
                Type = SubdivisionTypes.Department,
                Name = "Ocotepeque",
                LocalName = "Ocotepeque"
            },
            new()
            { 
                Code = "OL",
                Type = SubdivisionTypes.Department,
                Name = "Olancho",
                LocalName = "Olancho"
            },
            new()
            { 
                Code = "SB",
                Type = SubdivisionTypes.Department,
                Name = "Santa Bárbara",
                LocalName = "Santa Bárbara"
            },
            new()
            { 
                Code = "VA",
                Type = SubdivisionTypes.Department,
                Name = "Valle",
                LocalName = "Valle"
            },
            new()
            { 
                Code = "YO",
                Type = SubdivisionTypes.Department,
                Name = "Yoro",
                LocalName = "Yoro"
            }

        ]);
    }
}
