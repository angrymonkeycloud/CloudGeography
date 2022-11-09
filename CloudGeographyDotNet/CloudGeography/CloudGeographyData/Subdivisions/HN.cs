using AngryMonkey.Cloud.Geography;
namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    private static void FillInSubdivisionsHN()
    {
        AddSubdivisions("HN", new List<Subdivision>()
        {
            new()
            { 
                Code = "AT",
                Type = "Department",
                Name = "Atlántida",
                LocalName = "Atlántida"
            },
            new()
            { 
                Code = "CH",
                Type = "Department",
                Name = "Choluteca",
                LocalName = "Choluteca"
            },
            new()
            { 
                Code = "CL",
                Type = "Department",
                Name = "Colón",
                LocalName = "Colón"
            },
            new()
            { 
                Code = "CM",
                Type = "Department",
                Name = "Comayagua",
                LocalName = "Comayagua"
            },
            new()
            { 
                Code = "CP",
                Type = "Department",
                Name = "Copán",
                LocalName = "Copán"
            },
            new()
            { 
                Code = "CR",
                Type = "Department",
                Name = "Cortés",
                LocalName = "Cortés"
            },
            new()
            { 
                Code = "EP",
                Type = "Department",
                Name = "El Paraíso",
                LocalName = "El Paraíso"
            },
            new()
            { 
                Code = "FM",
                Type = "Department",
                Name = "Francisco Morazán",
                LocalName = "Francisco Morazán"
            },
            new()
            { 
                Code = "GD",
                Type = "Department",
                Name = "Gracias a Dios",
                LocalName = "Gracias a Dios"
            },
            new()
            { 
                Code = "IN",
                Type = "Department",
                Name = "Intibucá",
                LocalName = "Intibucá"
            },
            new()
            { 
                Code = "IB",
                Type = "Department",
                Name = "Islas de la Bahía",
                LocalName = "Islas de la Bahía"
            },
            new()
            { 
                Code = "LP",
                Type = "Department",
                Name = "La Paz",
                LocalName = "La Paz"
            },
            new()
            { 
                Code = "LE",
                Type = "Department",
                Name = "Lempira",
                LocalName = "Lempira"
            },
            new()
            { 
                Code = "OC",
                Type = "Department",
                Name = "Ocotepeque",
                LocalName = "Ocotepeque"
            },
            new()
            { 
                Code = "OL",
                Type = "Department",
                Name = "Olancho",
                LocalName = "Olancho"
            },
            new()
            { 
                Code = "SB",
                Type = "Department",
                Name = "Santa Bárbara",
                LocalName = "Santa Bárbara"
            },
            new()
            { 
                Code = "VA",
                Type = "Department",
                Name = "Valle",
                LocalName = "Valle"
            },
            new()
            { 
                Code = "YO",
                Type = "Department",
                Name = "Yoro",
                LocalName = "Yoro"
            }

        });
    }
}
