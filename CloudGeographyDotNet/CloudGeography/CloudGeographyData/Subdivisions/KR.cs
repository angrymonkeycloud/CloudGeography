using AngryMonkey.Cloud.Geography;
namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    private static void FillInSubdivisionsKR()
    {
        AddSubdivisions("KR", new List<Subdivision>()
        {
            new()
            { 
                Code = "26",
                Type = "MetropolitanCity",
                Name = "Busan Gwang'yeogsi",
                LocalName = "Busan Gwang'yeogsi"
            },
            new()
            { 
                Code = "43",
                Type = "Province",
                Name = "Chungcheongbugdo",
                LocalName = "Chungcheongbugdo"
            },
            new()
            { 
                Code = "44",
                Type = "Province",
                Name = "Chungcheongnamdo",
                LocalName = "Chungcheongnamdo"
            },
            new()
            { 
                Code = "27",
                Type = "MetropolitanCity",
                Name = "Daegu Gwang'yeogsi",
                LocalName = "Daegu Gwang'yeogsi"
            },
            new()
            { 
                Code = "30",
                Type = "MetropolitanCity",
                Name = "Daejeon Gwang'yeogsi",
                LocalName = "Daejeon Gwang'yeogsi"
            },
            new()
            { 
                Code = "42",
                Type = "Province",
                Name = "Gang'weondo",
                LocalName = "Gang'weondo"
            },
            new()
            { 
                Code = "29",
                Type = "MetropolitanCity",
                Name = "Gwangju Gwang'yeogsi",
                LocalName = "Gwangju Gwang'yeogsi"
            },
            new()
            { 
                Code = "41",
                Type = "Province",
                Name = "Gyeonggido",
                LocalName = "Gyeonggido"
            },
            new()
            { 
                Code = "47",
                Type = "Province",
                Name = "Gyeongsangbugdo",
                LocalName = "Gyeongsangbugdo"
            },
            new()
            { 
                Code = "48",
                Type = "Province",
                Name = "Gyeongsangnamdo",
                LocalName = "Gyeongsangnamdo"
            },
            new()
            { 
                Code = "28",
                Type = "MetropolitanCity",
                Name = "Incheon Gwang'yeogsi",
                LocalName = "Incheon Gwang'yeogsi"
            },
            new()
            { 
                Code = "49",
                Type = "Province",
                Name = "Jeju-teukbyeoljachido",
                LocalName = "Jeju-teukbyeoljachido"
            },
            new()
            { 
                Code = "45",
                Type = "Province",
                Name = "Jeonrabugdo",
                LocalName = "Jeonrabugdo"
            },
            new()
            { 
                Code = "46",
                Type = "Province",
                Name = "Jeonranamdo",
                LocalName = "Jeonranamdo"
            },
            new()
            { 
                Code = "50",
                Type = "City",
                Name = "Sejong",
                LocalName = "Sejong"
            },
            new()
            { 
                Code = "11",
                Type = "SpecialCity",
                Name = "Seoul-teukbyeolsi",
                LocalName = "Seoul-teukbyeolsi"
            },
            new()
            { 
                Code = "31",
                Type = "MetropolitanCity",
                Name = "Ulsan Gwang'yeogsi",
                LocalName = "Ulsan Gwang'yeogsi"
            }

        });
    }
}
