using AngryMonkey.Cloud.Geography;
namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    private static void FillInSubdivisionsMD()
    {
        AddSubdivisions("MD",
        [
            new()
            { 
                Code = "AN",
                Type = SubdivisionTypes.District,
                Name = "Anenii Noi",
                LocalName = "Raionul Anenii Noi"
            },
            new()
            { 
                Code = "BA",
                Type = SubdivisionTypes.Municipality,
                Name = "Balti",
                LocalName = "Balti"
            },
            new()
            { 
                Code = "BS",
                Type = SubdivisionTypes.District,
                Name = "Basarabeasca",
                LocalName = "Basarabeasca"
            },
            new()
            { 
                Code = "BD",
                Type = SubdivisionTypes.Municipality,
                Name = "Bender",
                LocalName = "Bendery"
            },
            new()
            { 
                Code = "BR",
                Type = SubdivisionTypes.District,
                Name = "Briceni",
                LocalName = "Briceni"
            },
            new()
            { 
                Code = "CA",
                Type = SubdivisionTypes.District,
                Name = "Cahul",
                LocalName = "Cahul"
            },
            new()
            { 
                Code = "CL",
                Type = SubdivisionTypes.District,
                Name = "Calarasi",
                LocalName = "Calarasi"
            },
            new()
            { 
                Code = "CT",
                Type = SubdivisionTypes.District,
                Name = "Cantemir",
                LocalName = "Cantemir"
            },
            new()
            { 
                Code = "CS",
                Type = SubdivisionTypes.District,
                Name = "Causeni",
                LocalName = "Causeni"
            },
            new()
            { 
                Code = "CU",
                Type = SubdivisionTypes.Municipality,
                Name = "Chisinau",
                LocalName = "Chisinau"
            },
            new()
            { 
                Code = "CM",
                Type = SubdivisionTypes.District,
                Name = "Cimislia",
                LocalName = "Cimislia"
            },
            new()
            { 
                Code = "CR",
                Type = SubdivisionTypes.District,
                Name = "Criuleni",
                LocalName = "Criuleni"
            },
            new()
            { 
                Code = "DO",
                Type = SubdivisionTypes.District,
                Name = "Donduseni",
                LocalName = "Donduseni"
            },
            new()
            { 
                Code = "DR",
                Type = SubdivisionTypes.District,
                Name = "Drochia",
                LocalName = "Drochia"
            },
            new()
            { 
                Code = "DU",
                Type = SubdivisionTypes.District,
                Name = "Dubasari",
                LocalName = "Dubasari"
            },
            new()
            { 
                Code = "ED",
                Type = SubdivisionTypes.District,
                Name = "Edinet",
                LocalName = "Edinet"
            },
            new()
            { 
                Code = "FA",
                Type = SubdivisionTypes.District,
                Name = "Falesti",
                LocalName = "Falesti"
            },
            new()
            { 
                Code = "FL",
                Type = SubdivisionTypes.District,
                Name = "Floresti",
                LocalName = "Floresti"
            },
            new()
            { 
                Code = "GZ",
                Type = SubdivisionTypes.Territory,
                Name = "Gagauzia",
                LocalName = "Găgăuzia"
            },
            new()
            { 
                Code = "GL",
                Type = SubdivisionTypes.District,
                Name = "Glodeni",
                LocalName = "Glodeni"
            },
            new()
            { 
                Code = "HI",
                Type = SubdivisionTypes.District,
                Name = "Hîncesti",
                LocalName = "Hîncesti"
            },
            new()
            { 
                Code = "IA",
                Type = SubdivisionTypes.District,
                Name = "Ialoveni",
                LocalName = "Ialoveni"
            },
            new()
            { 
                Code = "LE",
                Type = SubdivisionTypes.District,
                Name = "Leova",
                LocalName = "Leova"
            },
            new()
            { 
                Code = "NI",
                Type = SubdivisionTypes.District,
                Name = "Nisporeni",
                LocalName = "Nisporeni"
            },
            new()
            { 
                Code = "OC",
                Type = SubdivisionTypes.District,
                Name = "Ocniþa",
                LocalName = "Ocniþa"
            },
            new()
            { 
                Code = "OR",
                Type = SubdivisionTypes.District,
                Name = "Orhei",
                LocalName = "Orhei"
            },
            new()
            { 
                Code = "RE",
                Type = SubdivisionTypes.District,
                Name = "Rezina",
                LocalName = "Rezina"
            },
            new()
            { 
                Code = "RI",
                Type = SubdivisionTypes.District,
                Name = "Rîscani",
                LocalName = "Rîscani"
            },
            new()
            { 
                Code = "SI",
                Type = SubdivisionTypes.District,
                Name = "Sîngerei",
                LocalName = "Sîngerei"
            },
            new()
            { 
                Code = "SD",
                Type = SubdivisionTypes.District,
                Name = "Soldanesti",
                LocalName = "Soldanesti"
            },
            new()
            { 
                Code = "SO",
                Type = SubdivisionTypes.District,
                Name = "Soroca",
                LocalName = "Soroca"
            },
            new()
            { 
                Code = "SV",
                Type = SubdivisionTypes.District,
                Name = "Stefan Voda",
                LocalName = "Stefan Voda"
            },
            new()
            { 
                Code = "SN",
                Type = SubdivisionTypes.Territory,
                Name = "Stînga Nistrului",
                LocalName = "Stînga Nistrului"
            },
            new()
            { 
                Code = "ST",
                Type = SubdivisionTypes.District,
                Name = "Straseni",
                LocalName = "Straseni"
            },
            new()
            { 
                Code = "TA",
                Type = SubdivisionTypes.District,
                Name = "Taraclia",
                LocalName = "Taraclia"
            },
            new()
            { 
                Code = "TE",
                Type = SubdivisionTypes.District,
                Name = "Telenesti",
                LocalName = "Telenesti"
            },
            new()
            { 
                Code = "UN",
                Type = SubdivisionTypes.District,
                Name = "Ungheni",
                LocalName = "Ungheni"
            }

        ]);
    }
}
