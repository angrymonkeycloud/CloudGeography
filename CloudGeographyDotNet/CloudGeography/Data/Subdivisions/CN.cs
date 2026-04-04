using AngryMonkey.Cloud.Geography;
namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    private static void FillInSubdivisionsCN()
    {
        AddSubdivisions("CN",
        [
            new()
            { 
                Code = "34",
                Type = SubdivisionTypes.Province,
                Name = "Anhui",
                LocalName = "安徽省"
            },
            new()
            { 
                Code = "11",
                Type = SubdivisionTypes.Municipality,
                Name = "Beijing",
                LocalName = "北京市"
            },
            new()
            { 
                Code = "50",
                Type = SubdivisionTypes.Municipality,
                Name = "Chongqing",
                LocalName = "重庆市"
            },
            new()
            { 
                Code = "35",
                Type = SubdivisionTypes.Province,
                Name = "Fujian",
                LocalName = "福建省"
            },
            new()
            { 
                Code = "62",
                Type = SubdivisionTypes.Province,
                Name = "Gansu",
                LocalName = "甘肃省"
            },
            new()
            { 
                Code = "44",
                Type = SubdivisionTypes.Province,
                Name = "Guangdong",
                LocalName = "广东省"
            },
            new()
            { 
                Code = "45",
                Type = SubdivisionTypes.Region,
                Name = "Guangxi",
                LocalName = "广西壮族自治区"
            },
            new()
            { 
                Code = "52",
                Type = SubdivisionTypes.Province,
                Name = "Guizhou",
                LocalName = "贵州省"
            },
            new()
            { 
                Code = "46",
                Type = SubdivisionTypes.Province,
                Name = "Hainan",
                LocalName = "海南省"
            },
            new()
            { 
                Code = "13",
                Type = SubdivisionTypes.Province,
                Name = "Hebei",
                LocalName = "河北省"
            },
            new()
            { 
                Code = "23",
                Type = SubdivisionTypes.Province,
                Name = "Heilongjiang",
                LocalName = "黑龙江省"
            },
            new()
            { 
                Code = "41",
                Type = SubdivisionTypes.Province,
                Name = "Henan",
                LocalName = "河南省"
            },
            new()
            { 
                Code = "91",
                Type = SubdivisionTypes.Region,
                Name = "Hong Kong",
                LocalName = "香港特别行政区"
            },
            new()
            { 
                Code = "42",
                Type = SubdivisionTypes.Province,
                Name = "Hubei",
                LocalName = "河北省"
            },
            new()
            { 
                Code = "43",
                Type = SubdivisionTypes.Province,
                Name = "Hunan",
                LocalName = "湖南省"
            },
            new()
            { 
                Code = "15",
                Type = SubdivisionTypes.Region,
                Name = "Inner Mongolia",
                LocalName = "内蒙古自治区"
            },
            new()
            { 
                Code = "32",
                Type = SubdivisionTypes.Province,
                Name = "Jiangsu",
                LocalName = "江苏省"
            },
            new()
            { 
                Code = "36",
                Type = SubdivisionTypes.Province,
                Name = "Jiangxi",
                LocalName = "江西省"
            },
            new()
            { 
                Code = "22",
                Type = SubdivisionTypes.Province,
                Name = "Jilin",
                LocalName = "吉林省"
            },
            new()
            { 
                Code = "21",
                Type = SubdivisionTypes.Province,
                Name = "Liaoning",
                LocalName = "辽宁省"
            },
            new()
            { 
                Code = "92",
                Type = SubdivisionTypes.Region,
                Name = "Macau",
                LocalName = "澳门特别行政区"
            },
            new()
            { 
                Code = "64",
                Type = SubdivisionTypes.Region,
                Name = "Ningxia",
                LocalName = "宁夏回族自治区"
            },
            new()
            { 
                Code = "63",
                Type = SubdivisionTypes.Province,
                Name = "Qinghai",
                LocalName = "青海省"
            },
            new()
            { 
                Code = "61",
                Type = SubdivisionTypes.Province,
                Name = "Shaanxi",
                LocalName = "陕西省"
            },
            new()
            { 
                Code = "37",
                Type = SubdivisionTypes.Province,
                Name = "Shandong",
                LocalName = "山东省"
            },
            new()
            { 
                Code = "31",
                Type = SubdivisionTypes.Municipality,
                Name = "Shanghai",
                LocalName = "上海市"
            },
            new()
            { 
                Code = "14",
                Type = SubdivisionTypes.Province,
                Name = "Shanxi",
                LocalName = "山西省"
            },
            new()
            { 
                Code = "51",
                Type = SubdivisionTypes.Province,
                Name = "Sichuan",
                LocalName = "四川省"
            },
            new()
            { 
                Code = "71",
                Type = SubdivisionTypes.Province,
                Name = "Taiwan",
                LocalName = "台湾省"
            },
            new()
            { 
                Code = "12",
                Type = SubdivisionTypes.Municipality,
                Name = "Tianjin",
                LocalName = "天津市"
            },
            new()
            { 
                Code = "54",
                Type = SubdivisionTypes.Region,
                Name = "Tibet",
                LocalName = "西藏自治区"
            },
            new()
            { 
                Code = "65",
                Type = SubdivisionTypes.Region,
                Name = "Xinjiang",
                LocalName = "新疆维吾尔自治区"
            },
            new()
            { 
                Code = "53",
                Type = SubdivisionTypes.Province,
                Name = "Yunnan",
                LocalName = "云南省"
            },
            new()
            { 
                Code = "33",
                Type = SubdivisionTypes.Province,
                Name = "Zhejiang",
                LocalName = "浙江省"
            }

        ]);
    }
}
