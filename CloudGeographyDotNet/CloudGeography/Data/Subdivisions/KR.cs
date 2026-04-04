using AngryMonkey.Cloud.Geography;
namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    private static void FillInSubdivisionsKR()
    {
        AddSubdivisions("KR",
        [
            new()
            { 
                Code = "26",
                Type = SubdivisionTypes.MetropolitanCity,
                Name = "Busan Gwang'yeogsi",
                LocalName = "Busan Gwang'yeogsi"
            },
            new()
            { 
                Code = "43",
                Type = SubdivisionTypes.Province,
                Name = "Chungcheongbugdo",
                LocalName = "Chungcheongbugdo"
            },
            new()
            { 
                Code = "44",
                Type = SubdivisionTypes.Province,
                Name = "Chungcheongnamdo",
                LocalName = "Chungcheongnamdo"
            },
            new()
            { 
                Code = "27",
                Type = SubdivisionTypes.MetropolitanCity,
                Name = "Daegu Gwang'yeogsi",
                LocalName = "Daegu Gwang'yeogsi"
            },
            new()
            { 
                Code = "30",
                Type = SubdivisionTypes.MetropolitanCity,
                Name = "Daejeon Gwang'yeogsi",
                LocalName = "Daejeon Gwang'yeogsi"
            },
            new()
            { 
                Code = "42",
                Type = SubdivisionTypes.Province,
                Name = "Gang'weondo",
                LocalName = "Gang'weondo"
            },
            new()
            { 
                Code = "29",
                Type = SubdivisionTypes.MetropolitanCity,
                Name = "Gwangju Gwang'yeogsi",
                LocalName = "Gwangju Gwang'yeogsi"
            },
            new()
            { 
                Code = "41",
                Type = SubdivisionTypes.Province,
                Name = "Gyeonggido",
                LocalName = "Gyeonggido"
            },
            new()
            { 
                Code = "47",
                Type = SubdivisionTypes.Province,
                Name = "Gyeongsangbugdo",
                LocalName = "Gyeongsangbugdo"
            },
            new()
            { 
                Code = "48",
                Type = SubdivisionTypes.Province,
                Name = "Gyeongsangnamdo",
                LocalName = "Gyeongsangnamdo"
            },
            new()
            { 
                Code = "28",
                Type = SubdivisionTypes.MetropolitanCity,
                Name = "Incheon Gwang'yeogsi",
                LocalName = "Incheon Gwang'yeogsi"
            },
            new()
            { 
                Code = "49",
                Type = SubdivisionTypes.Province,
                Name = "Jeju-teukbyeoljachido",
                LocalName = "Jeju-teukbyeoljachido"
            },
            new()
            { 
                Code = "45",
                Type = SubdivisionTypes.Province,
                Name = "Jeonrabugdo",
                LocalName = "Jeonrabugdo"
            },
            new()
            { 
                Code = "46",
                Type = SubdivisionTypes.Province,
                Name = "Jeonranamdo",
                LocalName = "Jeonranamdo"
            },
            new()
            { 
                Code = "50",
                Type = SubdivisionTypes.City,
                Name = "Sejong",
                LocalName = "Sejong"
            },
            new()
            { 
                Code = "11",
                Type = SubdivisionTypes.SpecialCity,
                Name = "Seoul-teukbyeolsi",
                LocalName = "Seoul-teukbyeolsi"
            },
            new()
            { 
                Code = "31",
                Type = SubdivisionTypes.MetropolitanCity,
                Name = "Ulsan Gwang'yeogsi",
                LocalName = "Ulsan Gwang'yeogsi"
            }

        ]);
    }
}
